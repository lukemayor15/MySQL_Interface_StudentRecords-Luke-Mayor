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
    public partial class DepartmentForm : Form
    {
        //Database connection to object
        DBConnection mySqlSrc = new DBConnection();

        //id field name
        string idFieldName = "dep_id";

        //list of fields / column names (except id)
        List<string> depFieldList = new List<string>()
        { "dep_name", "dep_email", "dep_phone_no", "dep_leader"};

        //corresponding list of types; true is string false is numerical 
        List<bool> depTypeIsStringList = new List<bool>()
        { true,true, true, true };

        //refrence to main form (for when we close)
        MainForm mainFormRef;
        //flag for insert; if true insert mode, else update
        bool insertFlag = false;
        // row id to update
        string updateId;
        //update constructor to get ref to main form and mode insert/update
        //and update record id set to 0 as default
        public DepartmentForm(ref MainForm mainFormHandle, bool isInsert, string upId = "0")
        {
            //set vars from method params
            insertFlag = isInsert;
            mainFormRef = mainFormHandle;
            updateId = upId;

            //initialise form 
            InitializeComponent();

            //fields must be populated after form initialised
            //(otherwise the controls are null / not yet created)
            if (!isInsert)
                PopulateFields();

        }
        //in update mode , populate fields with existing data
        private void PopulateFields()
        {
            // query to get row to update
            List<string>[] updateRow = mySqlSrc.SelectRowWithId("department", depFieldList, idFieldName, updateId);



            //populate text fields from results list
            dep_name_txt.Text = updateRow[0][0].ToString();
            dep_email_txt.Text = updateRow[1][0].ToString();
            dep_phone_no_txt.Text = updateRow[2][0].ToString();
            dep_leader_txt.Text = updateRow[3][0].ToString();

        }
        public bool ValidateFields()
        {
            // flag for validation
            //(true if vaild, set to false if invaild data)
            bool vaildFlag = true;

            //message to display user if invaild fields
            string vaildMsg = "";
            // check dep name
            if (dep_name_txt.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a Department Name \n\n";
                vaildFlag = false;
            }
            // check phone no
            if (dep_phone_no_txt.Text.ToString() == "")
            {
                //add message and set flag to false
                vaildMsg += " You need to enter a Phone No\n\n";
                vaildFlag = false;
            }
            //checks for email
            if (dep_email_txt.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a Email \n\n";
                vaildFlag = false;
            }
            // No middle name as the field can be Null

            //checks for leader
            if (dep_leader_txt.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a Leader \n\n";
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
            //check data valid
            if (ValidateFields())
            {
                //create lost of value to insert / update from form fields
                List<string> values = new List<string>();

                //add in tect enterd into form field to values list
                values.Add(dep_name_txt.Text);
                
                values.Add(dep_email_txt.Text);
                values.Add(dep_phone_no_txt.Text);
                values.Add(dep_leader_txt.Text);

                if (insertFlag)
                {
                    //insert mod branch
                    mySqlSrc.InsertRow("department", depFieldList, values,
                                        depTypeIsStringList);
                }
                else
                {
                    //update mode branch
                    mySqlSrc.UpdateRow("department", depFieldList, values,
                        depTypeIsStringList, idFieldName, updateId);
                }
                this.Close();
            }

        }
        private void DepForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //set main form flag to say we are closed
            mainFormRef.DepFormClosed();
        }
        //set dep name text field to string for unit testing
        public void SetDepNameAdded(string value)
        {
            dep_name_txt.Text = value;
        }
        //set phone no text filed to string for unit testing
        public void SetDepPhoneNoAdded(string value)
        {
            dep_phone_no_txt.Text = value;
        }
        //set Email text field to string for unit testing
        public void SetDepEmailAdded(string value)
        {
            dep_email_txt.Text = value;
        }
        //set Leader text field to string for unit testing
        public void SetLeaderAdded(string value)
        {
            dep_leader_txt.Text = value;
        }
    }
}
