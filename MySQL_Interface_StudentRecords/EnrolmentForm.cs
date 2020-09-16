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
    public partial class EnrolmentForm : Form
    {
        //Database connection to object
        DBConnection mySqlSrc = new DBConnection();

        //id field name
        string idFieldName = "enrolment_id";

        //list of fields / column names (except id)
        List<string> enrolmentFieldList = new List<string>()
        {"course_id", "student_id","en_date" };

        //corresponding list of types; true is string false is numerical 
        List<bool> enrolmentTypeIsStringList = new List<bool>()
        { true,true,true };

        //refrence to main form (for when we close)
        MainForm mainFormRef;
        //flag for insert; if true insert mode, else update
        bool insertFlag = false;
        // row id to update
        string updateId;

        //-------COURSE TABLE-----------------------------
        //list of fields / colmns names
        List<string> courseFieldList = new List<string>()
        { "course_id", "aim_id", "c_cname", "c_level", "c_start_d", "c_end_d"};

        int courseRows = 0;
        //-------STUDENT TABLE-----------------------------
        //list of fields / colmns names
        List<string> studentFieldList = new List<string>()
        { "student_id", "user_id", "s_fname", "s_sname", "s_mname", "s_dob", "s_phone_no", "s_email", "s_id_image"};

        int studentRows = 0;
     
        public EnrolmentForm(ref MainForm mainFormHandle, bool isInsert, string upId = "0")
        {
            //set vars from method params
            insertFlag = isInsert;
            mainFormRef = mainFormHandle;
            updateId = upId;

            //initialise form 
            InitializeComponent();

            //-------------------------COURSE COMBO BOX-------------------------

            //bind combo box to dictionary
            //this allows us a key laue pair
            Dictionary<string, string> courseItem = new Dictionary<string, string>();

            //get net list for results of customer table
            List<string>[] courseResults = new List<string>[courseFieldList.Count];
            courseResults = mySqlSrc.SelectQuery("course", courseFieldList);

            //count the rows
            courseRows = courseResults[0].Count;
            for (int i = 0; i < courseRows; i++)
            {
                //column row
                //add to the dictionary object the id and name
                string fullName = courseResults[2][i];
                courseItem.Add(courseResults[0][i], fullName);
            }
            //bind the dictionary object and set key -> value
            // as id name
            
            c_id_cmb.DisplayMember = "Value";
            c_id_cmb.ValueMember = "Key";
            c_id_cmb.DataSource = new BindingSource(courseItem, null);
            // -------------------------STUDENT COMBO BOX-------------------------

            //bind combo box to dictionary
            //this allows us a key laue pair
            Dictionary<string, string> studentItem = new Dictionary<string, string>();

            //get net list for results of customer table
            List<string>[] studentResults = new List<string>[studentFieldList.Count];
            studentResults = mySqlSrc.SelectQuery("student", studentFieldList);

            //count the rows
            studentRows = studentResults[0].Count;
            for (int i = 0; i < studentRows; i++)
            {
                //column row
                //add to the dictionary object the id and name
                string fullName = studentResults[2][i];
                studentItem.Add(studentResults[0][i], fullName);
            }
            //bind the dictionary object and set key -> value
            // as id name
           
            s_id_cmb.DisplayMember = "Value";
            s_id_cmb.ValueMember = "Key";
            s_id_cmb.DataSource = new BindingSource(studentItem, null);
            //fields must be populated after initialised
            //(otherwise the controls are null / not created)
            if (!isInsert)
                PopulateFields();
        }
        private void PopulateFields()
        {
            // query to get row to update
            List<string>[] updateRow = mySqlSrc.SelectRowWithId("enrolment", enrolmentFieldList, idFieldName, updateId);


            //-------------COURSE COMBO BOX

            //get the user id from the selected record
            string tempcourseId = updateRow[0][0].ToString();

            //loop thorugh row of full customer result
            for (int i = 0; i < courseRows; i++)
            {
                //get the custeomer id of current combo box index
                string Key =
                    ((KeyValuePair<string, string>)c_id_cmb.Items[i]).Key;

                //if the value matches the current u id'
                //set the selcted index to this iteration
                //to display correct customer
                if (Key == tempcourseId)
                    c_id_cmb.SelectedIndex = i;
            }
            //-------------STUDENT COMBO BOX

            //get the user id from the selected record
            string tempstudebtId = updateRow[1][0].ToString();

            //loop thorugh row of full customer result
            for (int i = 0; i < courseRows; i++)
            {
                //get the custeomer id of current combo box index
                string Key =
                    ((KeyValuePair<string, string>)c_id_cmb.Items[i]).Key;

                //if the value matches the current u id'
                //set the selcted index to this iteration
                //to display correct customer
                if (Key == tempcourseId)
                    c_id_cmb.SelectedIndex = i;
            }

            //populate text fields from results list
            en_date_txt.Text = updateRow[2][0].ToString();
            

        }
        public bool ValidateFields()
        {
            // flag for validation
            //(true if vaild, set to false if invaild data)
            bool vaildFlag = true;

            //message to display user if invaild fields
            string vaildMsg = "";
            //combo box check course id
            if (c_id_cmb.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a Course ID \n\n";
                vaildFlag = false;
            }
            //first check course name
            if (s_id_cmb.Text.ToString() == "")
            {
                //add message and set flag to false
                vaildMsg += " You need to enter a Student ID\n\n";
                vaildFlag = false;
            }

            //checks for start data
            if (en_date_txt.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a Start Date \n\n";
                vaildFlag = false;
            }
            else
            {
                //regular expression for yyyy-mm--dd data format
                Regex dataExpression = new Regex("^[0-9]{4}[-]{1}[0-9]{2}[-]{1}[0-9]{2}$");

                if (!dataExpression.IsMatch(en_date_txt.Text.ToString()))
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
                    if (!(DateTime.TryParse(en_date_txt.Text.ToString(), out outDate)))
                    {
                        //add message and set flag to false
                        vaildMsg += "Invailded data enterd \n\n";
                        vaildFlag = false;
                    }
                }
            }
            // No middle name as the field can be Null

            //checks for end data
            
            

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
                    ((KeyValuePair<string, string>)c_id_cmb.SelectedItem).Key.ToString());
                values.Add(
                    ((KeyValuePair<string, string>)s_id_cmb.SelectedItem).Key.ToString());
                values.Add(en_date_txt.Text);
                


                if (insertFlag)
                {
                    //insert mode branch
                    mySqlSrc.InsertRow("enrolment", enrolmentFieldList, values, enrolmentTypeIsStringList);
                }
                else
                {
                    //update mode branch
                    mySqlSrc.UpdateRow("enrolment", courseFieldList, values, enrolmentTypeIsStringList, idFieldName, updateId);
                }
                this.Close();
            }
        }

        private void EnrolmentForm_FormClosed(object sender, EventArgs e)
        {
            mainFormRef.EnrolmentFormClosed();
        }
        //set date text field to string for unit testing
        public void SetDateAdded(string value)

        {
            en_date_txt.Text = value;
        }
        //set course id text field to string for unit testing
        public void SetCourseIdAddedd(string value)
        {
            c_id_cmb.Text = value;
        }
        //set stduentxt field to string for unit testing
        public void SetstudentIdAdded(string value)
        {
            s_id_cmb.Text = value;
        }
    }
}
