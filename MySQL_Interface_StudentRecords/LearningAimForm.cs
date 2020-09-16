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
    public partial class LearningAimForm : Form
    {
        //Database connection to object
        DBConnection mySqlSrc = new DBConnection();

        //id field name
        string idFieldName = "aim_id";

        //list of fields / column names (except id)
        List<string> learningAimFieldList = new List<string>()
        {  "dep_id", "l_learning_aim_title", "l_learning_aim_description"};

        //corresponding list of types; true is string false is numerical 
        List<bool> learningAimTypeIsStringList = new List<bool>()
        { false,true, true};

        //refrence to main form (for when we close)
        MainForm mainFormRef;
        //flag for insert; if true insert mode, else update
        bool insertFlag = false;
        // row id to update
        string updateId;

        //-------DEPARTMENT TABLE-----------------------------
        //list of fields / colmns names
        List<string> depFieldList = new List<string>()
        { "dep_id","dep_name", "dep_email", "dep_phone_no", "dep_leader"};

        int depRows = 0;

        public LearningAimForm(ref MainForm mainFormHandle, bool isInsert, string upId = "0")
        {
            //set vars from method params
            insertFlag = isInsert;
            mainFormRef = mainFormHandle;
            updateId = upId;

            //initialise form 
            InitializeComponent();

            //-------------------------USER ACCOUNT COMBO BOX-------------------------

            //bind combo box to dictionary
            //this allows us a key laue pair
            Dictionary<string, string> depItem = new Dictionary<string, string>();

            //get net list for results of customer table
            List<string>[] depResults = new List<string>[depFieldList.Count];
           depResults = mySqlSrc.SelectQuery("department", depFieldList);

            //count the rows
            depRows = depResults[0].Count;
            for (int i = 0; i < depRows; i++)
            {
                //column row
                //add to the dictionary object the id and name
                string fullName = depResults[1][i];
                depItem.Add(depResults[0][i], fullName);
            }
            //bind the dictionary object and set key -> value
            // as id name
            dep_id_cmb.DataSource = new BindingSource(depItem, null);
            dep_id_cmb.DisplayMember = "Value";
            dep_id_cmb.ValueMember = "Key";

            //fields must be populated after initialised
            //(otherwise the controls are null / not created)
            if (!isInsert)
                PopulateFields();
        }
        private void PopulateFields()
        {
            // query to get row to update
            List<string>[] updateRow = mySqlSrc.SelectRowWithId("learning_aim", learningAimFieldList, idFieldName, updateId);


            //-------------User ACCOUNT COMBO BOX

            //get the user id from the selected record
            string tempdepId = updateRow[0][0].ToString();

            //loop thorugh row of full customer result
            for (int i = 0; i < depRows; i++)
            {
                //get the custeomer id of current combo box index
                string Key =
                    ((KeyValuePair<string, string>)dep_id_cmb.Items[i]).Key;

                //if the value matches the current u id'
                //set the selcted index to this iteration
                //to display correct customer
                if (Key == tempdepId)
                    dep_id_cmb.SelectedIndex = i;
            }
            //populate text fields from results list
            l_learning_aim_titile_txt.Text = updateRow[1][0].ToString();
            l_learning_aim_des_txt.Text = updateRow[2][0].ToString();
            

        }
        //method to enusre that all fields have vaild values enterd
        public bool ValidateFields()
        {
            // flag for validation
            //(true if vaild, set to false if invaild data)
            bool vaildFlag = true;

            //message to display user if invaild fields
            string vaildMsg = "";
            //combo box check dep id
            if (dep_id_cmb.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a Department ID\n\n";
                vaildFlag = false;
            }
            //check title
            if (l_learning_aim_titile_txt.Text.ToString() == "")
            {
                //add message and set flag to false
                vaildMsg += " You need to enter a Title \n\n";
                vaildFlag = false;
            }
            //checks descpition
            if (l_learning_aim_des_txt.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a Descrption\n\n";
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
            //Checks data vaild
            if (ValidateFields())
            {
                //creates list of values to insert / insert from form fields
                List<string> values = new List<string>();

                //add in text enter into form fields from list
                values.Add(
                    ((KeyValuePair<string, string>)dep_id_cmb.SelectedItem).Key.ToString());
                values.Add(l_learning_aim_titile_txt.Text);
                values.Add(l_learning_aim_des_txt.Text);
                

                if (insertFlag)
                {
                    //insert mode branch
                    mySqlSrc.InsertRow("learning_aim", learningAimFieldList, values, learningAimTypeIsStringList);
                }
                else
                {
                    //update mode branch
                    mySqlSrc.UpdateRow("learning_aim", learningAimFieldList, values, learningAimTypeIsStringList, idFieldName, updateId);
                }
                this.Close();
            }
        }
        private void LearningAimForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //set the main form from flag to say we are closed now
            mainFormRef.LearningAimFormClosed();
        }
        //set dep id to text field to string for unit testing
        public void SetAimDepAdded(string value)
        {
            dep_id_cmb.Text = value;
        }
        //set learning aim title text field to strin gofr unit testing
        public void SetAimTitleAdded(string value)
        {
            l_learning_aim_titile_txt.Text = value;
        }
        //set learning aim desc text field to strin gofr unit testing
        public void SetAimDescAdded(string value)
        {
            l_learning_aim_des_txt.Text = value;
        }
    }
}
