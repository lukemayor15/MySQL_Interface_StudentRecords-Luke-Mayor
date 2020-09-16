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
    public partial class JobRoleForm : Form
    {
        //Database connection to object
        DBConnection mySqlSrc = new DBConnection();

        //id field name
        string idFieldName = "role_id";

        //list of fields / column names (except id)
        List<string> jobRoleFieldList = new List<string>()
        { "staff_id", "dep_id", "j_title"};

        //corresponding list of types; true is string false is numerical 
        List<bool> jobRoleTypeIsStringList = new List<bool>()
        { true,true, true};

        //refrence to main form (for when we close)
        MainForm mainFormRef;
        //flag for insert; if true insert mode, else update
        bool insertFlag = false;
        // row id to update
        string updateId;

        //-------Staff TABLE-----------------------------
        //list of fields / colmns names

        List<string> staffFieldList = new List<string>()
        { "staff_id","user_id", "st_fname", "st_sname", "st_mname", "st_dob", "st_phone_no", "st_email", "st_id_image" };

        int staffRows = 0;

        //-------DEPARTMENT TABLE-----------------------------
        //list of fields / colmns names

        List<string> depFieldList = new List<string>()
        { "dep_id","dep_name", "dep_email", "dep_phone_no", "dep_leader"};

        int depRows = 0;
        public JobRoleForm(ref MainForm mainFormHandle, bool isInsert, string upId = "0")
        {
            //set vars from method params
            insertFlag = isInsert;
            mainFormRef = mainFormHandle;
            updateId = upId;

            //initialise form 
            InitializeComponent();

            //-------------------------STAFF COMBO BOX-------------------------

            //bind combo box to dictionary
            //this allows us a key laue pair
            Dictionary<string, string> staffItem = new Dictionary<string, string>();

            //get net list for results of customer table
            List<string>[] staffResults = new List<string>[staffFieldList.Count];
            staffResults = mySqlSrc.SelectQuery("staff", staffFieldList);

            //count the rows
            staffRows = staffResults[0].Count;
            for (int i = 0; i < staffRows; i++)
            {
                //column row
                //add to the dictionary object the id and name
                string fullName = staffResults[3][i] + " " + staffResults[4][i];
                staffItem.Add(staffResults[0][i], fullName);
            }
            //bind the dictionary object and set key -> value
            // as id name
           
            staff_id_cmb.DisplayMember = "Value";
            staff_id_cmb.ValueMember = "Key";
            staff_id_cmb.DataSource = new BindingSource(staffItem, null);
            //-------------------------DEPARTMENT COMBO BOX-------------------------

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
           
            dep_id_cmb.DisplayMember = "Value";
            dep_id_cmb.ValueMember = "Key";
            dep_id_cmb.DataSource = new BindingSource(depItem, null);
            //fields must be populated after initialised
            //(otherwise the controls are null / not created)
            if (!isInsert)
                PopulateFields();
        }
        private void PopulateFields()
        {
            // query to get row to update
            List<string>[] updateRow = mySqlSrc.SelectRowWithId("job_role", jobRoleFieldList, idFieldName, updateId);


            //------------- STAFF COMBO BOX

            //get the stafffrom the selected record
            string tempStaffId = updateRow[0][0].ToString();

            //loop thorugh row of full customer result
            for (int i = 0; i < staffRows; i++)
            {
                //get the custeomer id of current combo box index
                string Key =
                    ((KeyValuePair<string, string>)staff_id_cmb.Items[i]).Key;

                //if the value matches the current u id'
                //set the selcted index to this iteration
                //to display correct customer
                if (Key == tempStaffId)
                    staff_id_cmb.SelectedIndex = i;
            }
            //------------- DEPARTMENT COMBO BOX

            //get the depr id from the selected record
            string tempDepId = updateRow[1][0].ToString();

            //loop thorugh row of full customer result
            for (int i = 0; i < depRows; i++)
            {
                //get the custeomer id of current combo box index
                string Key =
                    ((KeyValuePair<string, string>)dep_id_cmb.Items[i]).Key;

                //if the value matches the current u id'
                //set the selcted index to this iteration
                //to display correct customer
                if (Key == tempDepId)
                    dep_id_cmb.SelectedIndex = i;
            }
            //populate text fields from results list
            
            j_title_txt.Text = updateRow[2][0].ToString();
            

        }
        public bool ValidateFields()
        {
            // flag for validation
            //(true if vaild, set to false if invaild data)
            bool vaildFlag = true;

            //message to display user if invaild fields
            string vaildMsg = "";
            //checks staff id
            if (staff_id_cmb.Text.ToString() == "")
            {
                vaildMsg += " You need to select staff ID \n\n";
                vaildFlag = false;
            }
            //check dep ID
            if (dep_id_cmb.Text.ToString() == "")
            {
                //add message and set flag to false
                vaildMsg += " You need to enter Department ID \n\n";
                vaildFlag = false;
            }
            //checks for surname
            if (j_title_txt.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a Job Title \n\n";
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
            if (ValidateFields())
            {
                //creates list of values to insert / insert from form fields
                List<string> values = new List<string>();

                //add in text enter into form fields from list
                values.Add(
                    ((KeyValuePair<string, string>)staff_id_cmb.SelectedItem).Key.ToString());
                values.Add(
                    ((KeyValuePair<string, string>)dep_id_cmb.SelectedItem).Key.ToString());
                values.Add(j_title_txt.Text);
               
                if (insertFlag)
                {
                    //insert mode branch
                    mySqlSrc.InsertRow("job_role", jobRoleFieldList, values,jobRoleTypeIsStringList);
                }
                else
                {
                    //update mode branch
                    mySqlSrc.UpdateRow("job_role", jobRoleFieldList, values, jobRoleTypeIsStringList, idFieldName, updateId);
                }
                this.Close();
            }
        }
        private void JobRoleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainFormRef.JobRoleFormClosed();
        }
        //set staff id text field to strin for unit testing
        public void SetRoleStaffIdAdded(string value)
        {
            staff_id_cmb.Text = value;
        }

        //set dep id text field to string for unit testing
        public void SetRoleDepIdAdded(string value)
        {
            dep_id_cmb.Text = value;
        }
        //set job title text field to string for unit testing
        public void SetRoleTitleAdded(string value)
        {
            j_title_txt.Text = value;
        }

    }
}
