using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_Interface_StudentRecords
{
    public partial class AddressForm : Form
    {
        //Database connection to object
        DBConnection mySqlSrc = new DBConnection();

        //id field name
        string idFieldName = "address_id";

        //list of fields / column names (except id)
        List<string> addressFieldList = new List<string>()
        { "user_id", "a_postcode", "a_address_line1", "a_address_line2", "a_town", "a_county", "a_current_address"};

        //corresponding list of types; true is string false is numerical 
        List<bool> addressTypeIsStringList = new List<bool>()
        { true,true, true, true, true, true, true };

        //refrence to main form (for when we close)
        MainForm mainFormRef;
        //flag for insert; if true insert mode, else update
        bool insertFlag = false;
        // row id to update
        string updateId;

        //-------USER ACCOUNT TABLE-----------------------------
        //list of fields / colmns names
        List<string> userAccountFieldList = new List<string>()
        { "user_id", "u_uname", "u_access_level", "u_password"};

        int userAccountRows = 0;
        public AddressForm(ref MainForm mainFormHandle, bool isInsert, string upId = "0")
        {
            //set vars from method params
            insertFlag = isInsert;
            mainFormRef = mainFormHandle;
            updateId = upId;

            //initialise form 
            InitializeComponent();

            //-------------------------USER ACCOUNT COMBO BOX-------------------------

            //bind combo box to dictionary
            //this allows us a key vlaue pair
            Dictionary<string, string> userAccountItem = new Dictionary<string, string>();

            //get net list for results of student table
            List<string>[] userAccountResults = new List<string>[userAccountFieldList.Count];
            userAccountResults = mySqlSrc.SelectQuery("user_account", userAccountFieldList);

            //count the rows
            userAccountRows = userAccountResults[0].Count;
            for (int i = 0; i < userAccountRows; i++)
            {
                //column row
                //add to the dictionary object the id and name
                string fullName = userAccountResults[1][i];
                userAccountItem.Add(userAccountResults[0][i], fullName);
            }
            //bind the dictionary object and set key -> value
            // as id name
            u_id_cmb.DisplayMember = "Value";
            u_id_cmb.ValueMember = "Key";
            u_id_cmb.DataSource = new BindingSource(userAccountItem, null);






            //fields must be populated after initialised
            //(otherwise the controls are null / not created)
            if (!isInsert)
                PopulateFields();
        }
        private void PopulateFields()
        {
            // query to get row to update
            List<string>[] updateRow = mySqlSrc.SelectRowWithId("address", addressFieldList, idFieldName, updateId);


            //-------------User ACCOUNT COMBO BOX

            //get the user id from the selected record
            string tempUserId = updateRow[0][0].ToString();

            //loop thorugh row of full student result
            for (int i = 0; i < userAccountRows; i++)
            {
                //get the custeomer id of current combo box index
                string Key =
                    ((KeyValuePair<string, string>)u_id_cmb.Items[i]).Key;

                //if the value matches the current u id'
                //set the selcted index to this iteration
                //to display correct custstudentomer
                if (Key == tempUserId)
                    u_id_cmb.SelectedIndex = i;
            }
            //populate text fields from results list
            a_postcode_txt.Text = updateRow[1][0].ToString();
            a_address_line1_txt.Text = updateRow[2][0].ToString();
            a_address_line2_txt.Text = updateRow[3][0].ToString();
            a_town_txt.Text = updateRow[4][0].ToString();
            a_county_txt.Text = updateRow[5][0].ToString();
            a_current_address_txt.Text = updateRow[6][0].ToString();
            

        }
        //check the fields 
        public bool ValidateFields()
        {
            // flag for validation
            //(true if vaild, set to false if invaild data)
            bool vaildFlag = true;

            //message to display user if invaild fields
            string vaildMsg = "";
            //combo box check user id
            if (u_id_cmb.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a User ID \n\n";
                vaildFlag = false;
            }
            //check postcode
            if (a_postcode_txt.Text.ToString() == "")
            {
                //add message and set flag to false
                vaildMsg += " You need to enter a PostCode \n\n";
                vaildFlag = false;
            }
            //checks for address line1
            if (a_address_line1_txt.Text.ToString() == "")
            {
                vaildMsg += " You need to enter Address line 1\n\n";
                vaildFlag = false;
            }
            // No middle name as the field can be Null

            //checks for county
            if (a_county_txt.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a County \n\n";
                vaildFlag = false;
            }
            // checks for Ttown
            if (a_town_txt.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a Town/City \n\n";
                vaildFlag = false;
            }
            //check current if vaild input (yes or no)
            if (a_current_address_txt.ToString() == "")
            {
                vaildMsg += " You need to enter a 1 (true) or 0 (false) \n\n";
                vaildFlag = false;
            }

            // if invaild fields dispay message to user
                if (!vaildFlag)
                MessageBox.Show(vaildMsg);
            // return if vaild check ok or not
            return vaildFlag;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            //creates list of values to insert / insert from form fields
            List<string> values = new List<string>();

            //add in text enter into form fields from list
            values.Add(
                ((KeyValuePair<string, string>)u_id_cmb.SelectedItem).Key.ToString());
            values.Add(a_postcode_txt.Text);
            values.Add(a_address_line1_txt.Text);
            values.Add(a_address_line2_txt.Text);
            values.Add(a_town_txt.Text);
            values.Add(a_county_txt.Text);
            values.Add(a_current_address_txt.Text);
           

            if (insertFlag)
            {
                //insert mode branch
                mySqlSrc.InsertRow("address", addressFieldList, values, addressTypeIsStringList);
            }
            else
            {
                //update mode branch
                mySqlSrc.UpdateRow("address", addressFieldList, values, addressTypeIsStringList, idFieldName, updateId);
            }
            this.Close();
        }
        private void AddressForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // set the main form flag to say we are closed now
            mainFormRef.AddressFormClosed();
        }
        //set user id text field to stirng for unit testing
        public void SetUserIdAdded(string value)
        {
            u_id_cmb.Text = value;
        }
        // set address line 1 text field to string for unit testing
        public void SetAddressLineOneAdded(string value)
        {
            a_address_line1_txt.Text = value;
        }
        // set address line 2 text field to string for unit testing
        public void SetAddressLineTwoAdded(string value)
        {
            a_address_line2_txt.Text = value;
        }
        //set postcode text field to string for unit testing
        public void SetPostcodeAdded(string value)
        {
            a_postcode_txt.Text = value;

        }
        // set town text field to string for unit testing
        public void SetTownAdded(string value)
        {
            a_town_txt.Text = value;
        }
        //set county text field to string for unit testing
        public void SetCountyAdded(string value)
        {
            a_county_txt.Text = value;
        }

        //set current address to string for unit testing
        public void SetCurrentAddressAdded(string value)
        {
            a_current_address_txt.Text = value;
        }
    }
    
}
