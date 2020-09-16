using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace MySQL_Interface_StudentRecords
{
    public partial class UserAccountForm : Form
    {
        //data base connection object
        DBConnection mySqlSrc = new DBConnection();

        //id field name
        string idFieldName = "user_id";

        //list of fields / column names (except id)
        List<string> userFieldList = new List<string>()
        { "u_uname",  "u_password", "u_access_level"};

        //coorspoding list for 
        List<bool> userTypeIsStringList = new List<bool>()
        { true, true, true};

        // refrence to main form (for when we close)
        MainForm mainFormRef;

        //flag for insert; if true insert mode, else update
        bool insertFlag = false;

        //rowid to update
        string updateId;

        //Updated constructor to get ref main form and mode (insert/ update)
        //and update and record id (set to 0 as default)
        public UserAccountForm(ref MainForm mainFormHandle, bool isInsert, string upId = "0")
        {
            insertFlag = isInsert;
            mainFormRef = mainFormHandle;
            updateId = upId;

            InitializeComponent();

            //field must be popuplated  after from intialised
            //(otherwise controls are null / not yet created
            if (!isInsert)
                PopulateFields();
        }
        // is update mode, populate fields with existing data
        private void PopulateFields()
        {
            //query to get row to update
            List<string>[] updateRow =
                mySqlSrc.SelectRowWithId("user_account", userFieldList, idFieldName, updateId);

            //populate text fields from results list
            u_uname_txt.Text = updateRow[0][0].ToString();
            //hashes the password
            
            
            
            u_accesslevel_txt.Text = updateRow[2][0].ToString();
            u_password_txt.Text = updateRow[1][0].ToString();


        }
        public bool ValidateFields()
        {
            //flag for validation
            //(true if vaild, set to false if invalid data)
            bool validFlag = true;
            //message to dsiplay user input fields
            string validMsg = "";

            //user name check
            if (u_uname_txt.Text.ToString() == "")
            {
                //add to message and set flag to false
                validMsg += "You need to enter a User Name \n\n";
                validFlag = false;
            }
            //password check
            if (u_password_txt.Text.ToString() == "")
            {
                //add message to set flag to false
                validMsg += "You need to enter a User Password \n\n";
                validFlag = false;
            }
            else
            {
                // check  access level
                int number;
                if (
                    !(int.TryParse(u_accesslevel_txt.Text.ToString(), out number))
                    )
                {
                    // add message and set flag to false
                    validMsg = "access level needs to be valid Interger \n\n";
                    validFlag = false;
                }
            }
            // if invaild fields dsiplay message to user
            if (!validFlag)
                MessageBox.Show(validMsg);

            //return if valid check ok or not
            return validFlag;
        }
        //method to convert password to hass
        private void HashPasssword()
        {
            string password = u_password_txt.Text.ToString();

            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(password));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }


            u_password_txt.Text = hash.ToString();



        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            //check data valid
            if (ValidateFields())
            {
                //create lst of values to isnert / update from form fields
                List<string> values = new List<string>();

                //add in tect enterd into from fields to values list
                values.Add(u_uname_txt.Text);
                //hashes the password
                HashPasssword();
                values.Add(u_password_txt.Text);
                values.Add(u_accesslevel_txt.Text);

         
                

                if (insertFlag)
                {
                    //insert mode branch
                    mySqlSrc.InsertRow("user_account", userFieldList, values, userTypeIsStringList);
                }
                else
                {
                    //update mode branch
                    mySqlSrc.UpdateRow("user_account", userFieldList, values, userTypeIsStringList, idFieldName, updateId);
                }
                this.Close();
            }
        }
        private void UserAccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //set the main from flag to say we are closed now
            mainFormRef.UserAccountFormClosed();
        }

        //set user name text field to string for unit testing
        public void SetNameAdded(string value)
        {
            u_uname_txt.Text = value;
        }
        //set user password text field to string for unit testing
        public void SetPasswordAdded(string value)
        {
            u_password_txt.Text = value;
        }
        // set acces level text field to string for unit testing
        public void SetAccessLevelAdded(string value)
        {
            u_accesslevel_txt.Text = value;
        }
      
        
    }
}
