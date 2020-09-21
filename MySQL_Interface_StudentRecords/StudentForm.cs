using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_Interface_StudentRecords
{
    
    public partial class StudentForm : Form
    {
        //Database connection to object
        DBConnection mySqlSrc = new DBConnection();

        //id field name
        string idFieldName = "student_id";

        //list of fields / column names (except id)
        List<string> studentFieldList = new List<string>()
        {  "user_id", "s_fname", "s_sname", "s_mname", "s_dob", "s_phone_no", "s_email", "s_id_image"};

        //corresponding list of types; true is string false is numerical 
        List<bool> studentTypeIsStringList = new List<bool>()
        { true,true, true, true, true, true, true, true};

        //refrence to main form (for when we close)
        MainForm mainFormRef;
        //flag for insert; if true insert mode, else update
        bool insertFlag = false;
        // row id to update
        string updateId;

        //-------USER ACCOUNT TABLE-----------------------------
        //list of fields / colmns names
        List<string> userAccountFieldList = new List<string>()
        { "user_id", "u_uname","u_access_level", "u_password"};

        int userAccountRows = 0;
        public StudentForm(ref MainForm mainFormHandle, bool isInsert, string upId = "0")
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
            Dictionary<string, string> userAccountItem = new Dictionary<string, string>();

            //get new list for results of student table
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
        
        // in update more, populate fields with existing data
        private void PopulateFields()
        {
            // query to get row to update
            List<string>[] updateRow = mySqlSrc.SelectRowWithId("student", studentFieldList, idFieldName,updateId);


            //-------------User ACCOUNT COMBO BOX

            //get the user id from the selected record
            string tempUserId = updateRow[0][0].ToString();

            //loop thorugh row of full student result
            for (int i = 0; i < userAccountRows; i++)
            {
                //get the student id of current combo box index
                string Key =
                    ((KeyValuePair<string, string>)u_id_cmb.Items[i]).Key;

                //if the value matches the current u id'
                //set the selcted index to this iteration
                //to display correct student
                if (Key == tempUserId)
                    u_id_cmb.SelectedIndex = i;
            }
            //populate text fields from results list
            s_fname_txt.Text = updateRow[1][0].ToString();
            s_sname_txt.Text = updateRow[2][0].ToString();
            s_mname_txt.Text = updateRow[3][0].ToString();
            s_dob_txt.Text = updateRow[4][0].ToString();
            s_phone_no_txt.Text = updateRow[5][0].ToString();
            s_email_txt.Text = updateRow[6][0].ToString();
            s_id_image_txt.Text = updateRow[7][0].ToString();

        }
        //method to enusre that all fields have vaild values enterd

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
            //first check name
            if (s_fname_txt.Text.ToString() == "")
            {
                //add message and set flag to false
                vaildMsg += " You need to enter a First Name \n\n";
                vaildFlag = false;
            }
            //checks for surname
            if (s_sname_txt.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a Surname \n\n";
                vaildFlag = false;
            }
            // No middle name as the field can be Null

            //checks for date of birith
            if (s_dob_txt.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a data of birth \n\n";
                vaildFlag = false;
            }
            else
            {
                //regular expression for yyyy-mm--dd data format
                Regex dataExpression = new Regex("^[0-9]{4}[-]{1}[0-9]{2}[-]{1}[0-9]{2}$");

                if (!dataExpression.IsMatch(s_dob_txt.Text.ToString()))
                {
                    // add to message and set flag to false 
                    vaildMsg += "Data must be in yyyy-mm-dd format \n\n";
                    vaildFlag = false;
                }
                else
                {
                    //create DataTime pbject to try conversiob from value enterd
                    DateTime outDate;
                    //if we cannot prase it to vaild data (out of range)
                    //e.eg no 13 month
                    if (!(DateTime.TryParse(s_dob_txt.Text.ToString(), out outDate)))
                    {
                        //add message and set flag to false
                        vaildMsg += "Invailded data enterd \n\n";
                        vaildFlag = false;
                    }
                }
            }
            // checks for phone no
            if (s_phone_no_txt.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a Phone No \n\n";
                vaildFlag = false;
            }
            //checks for email
            if (s_email_txt.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a email \n\n";
                vaildFlag = false;
            }
            // check for id image
            if (s_id_image_txt.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a ID image path \n\n";
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
            if(ValidateFields())
            {
                //creates list of values to insert / insert from form fields
                List<string> values = new List<string>();

                //add in text enter into form fields from list
                values.Add(
                    ((KeyValuePair<string, string>)u_id_cmb.SelectedItem).Key.ToString());
                values.Add(s_fname_txt.Text);
                values.Add(s_sname_txt.Text);
                values.Add(s_mname_txt.Text);
                values.Add(s_dob_txt.Text);
                values.Add(s_phone_no_txt.Text);
                values.Add(s_email_txt.Text);
                values.Add(s_id_image_txt.Text);

                if (insertFlag)
                {
                    //insert mode branch
                    mySqlSrc.InsertRow("student", studentFieldList, values, studentTypeIsStringList);
                }
                else
                {
                    //update mode branch
                    mySqlSrc.UpdateRow("student", studentFieldList, values, studentTypeIsStringList, idFieldName, updateId);
                }
                this.Close();
            }
            
        }
        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
            //set the main form falg to say we are closed now
        {
            mainFormRef.StudentFormClosed();
        }
        //set date text field to gvien string for unit testing
        public void SetDateAdded(string value)
        {
            s_dob_txt.Text = value;
        }
        //set user id text field to given string fro unit testing
        public void SetUserIdAdded(string value)
        {
            u_id_cmb.Text = value;
        }
        //set first name tect field to given string for unit testing
        public void SetFnameAdded(string value)
        {
            s_fname_txt.Text = value;
        }
        //set surname tect field to given string for unit testing
        public void SeSFnameAdded(string value)
        {
            s_sname_txt.Text = value;
        }
        //set surname tect field to given string for unit testing
        public void SetSnameAdded(string value)
        {
            s_sname_txt.Text = value;
        }
        //set phone no text field to given string for unit testing
        public void SetPhoneNoAdded(string value)
        {
            s_phone_no_txt.Text = value;
        }
        // set email text filed to given string for unit testing
        public void SetEmailAdded(string value)
        {
            s_email_txt.Text = value;
        }
        // set id image text field to given string for unit testing
        public void SetIdImagedded(string value)
        {
            s_id_image_txt.Text = value;
        }
    }
}
