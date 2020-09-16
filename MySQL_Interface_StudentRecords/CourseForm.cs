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
    public partial class CourseForm : Form
    {
        //Database connection to object
        DBConnection mySqlSrc = new DBConnection();

        //id field name
        string idFieldName = "course_id";

        //list of fields / column names (except id)
        List<string> courseFieldList = new List<string>()
        {  "aim_id", "c_cname", "c_level", "c_start_d", "c_end_d"};

        //corresponding list of types; true is string false is numerical 
        List<bool> courseTypeIsStringList = new List<bool>()
        { true,true,true, true, true};

        //refrence to main form (for when we close)
        MainForm mainFormRef;
        //flag for insert; if true insert mode, else update
        bool insertFlag = false;
        // row id to update
        string updateId;

        //-------LEARNING AIM TABLE-----------------------------
        //list of fields / colmns names
        List<string> learningAimFieldList = new List<string>()
        { "aim_id", "dep_id","l_learning_aim_title", "l_learning_aim_description"};

        int learningAimRows = 0;
        public CourseForm(ref MainForm mainFormHandle, bool isInsert, string upId = "0")
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
            Dictionary<string, string> learningAimItem = new Dictionary<string, string>();

            //get net list for results of customer table
            List<string>[] learningAimResults = new List<string>[learningAimFieldList.Count];
            learningAimResults = mySqlSrc.SelectQuery("learning_aim", learningAimFieldList);

            //count the rows
            learningAimRows = learningAimResults[0].Count;
            for (int i = 0; i < learningAimRows; i++)
            {
                //column row
                //add to the dictionary object the id and name
                string fullName = learningAimResults[2][i];
                learningAimItem.Add(learningAimResults[0][i], fullName);
            }
            //bind the dictionary object and set key -> value
            // as id name
            
            aim_id_cmb.DisplayMember = "Value";
            aim_id_cmb.ValueMember = "Key";
            aim_id_cmb.DataSource = new BindingSource(learningAimItem, null);

            //fields must be populated after initialised
            //(otherwise the controls are null / not created)
            if (!isInsert)
                PopulateFields();
        }
        // in update more, populate fields with existing data
        private void PopulateFields()
        {
            // query to get row to update
            List<string>[] updateRow = mySqlSrc.SelectRowWithId("course", courseFieldList, idFieldName, updateId);


            //-------------Learning Aim COMBO BOX

            //get the Leanring aim id from the selected record
            string tempAimId = updateRow[0][0].ToString();

            //loop thorugh row of full customer result
            for (int i = 0; i < learningAimRows; i++)
            {
                //get the custeomer id of current combo box index
                string Key =
                    ((KeyValuePair<string, string>)aim_id_cmb.Items[i]).Key;

                //if the value matches the current u id'
                //set the selcted index to this iteration
                //to display correct customer
                if (Key == tempAimId)
                    aim_id_cmb.SelectedIndex = i;
            }
            //populate text fields from results list
            c_cname_txt.Text = updateRow[1][0].ToString();
            c_level_txt.Text = updateRow[2][0].ToString();
            c_start_d_txt.Text = updateRow[3][0].ToString();
            c_end_d_txt.Text = updateRow[4][0].ToString();


        }
        //method to enusre that all fields have vaild values enterd
        public bool ValidateFields()
        {
            // flag for validation
            //(true if vaild, set to false if invaild data)
            bool vaildFlag = true;

            //message to display user if invaild fields
            string vaildMsg = "";
            //combo box check aim id
            if (aim_id_cmb.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a Learning Aim ID \n\n";
                vaildFlag = false;
            }
            //first check course name
            if (c_cname_txt.Text.ToString() == "")
            {
                //add message and set flag to false
                vaildMsg += " You need to enter a Course Name \n\n";
                vaildFlag = false;
            }
            
            //checks for start data
            if (c_start_d_txt.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a Start Date \n\n";
                vaildFlag = false;
            }
            else
            {
                //regular expression for yyyy-mm--dd data format
                Regex dataExpression = new Regex("^[0-9]{4}[-]{1}[0-9]{2}[-]{1}[0-9]{2}$");

                if (!dataExpression.IsMatch(c_start_d_txt.Text.ToString()))
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
                    if (!(DateTime.TryParse(c_start_d_txt.Text.ToString(), out outDate)))
                    {
                        //add message and set flag to false
                        vaildMsg += "Invailded data enterd \n\n";
                        vaildFlag = false;
                    }
                }
            }
            // No middle name as the field can be Null

            //checks for end data
            if (c_end_d_txt.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a End data \n\n";
                vaildFlag = false;
            }
            else
            {
                //regular expression for yyyy-mm--dd data format
                Regex dataExpression = new Regex("^[0-9]{4}[-]{1}[0-9]{2}[-]{1}[0-9]{2}$");

                if (!dataExpression.IsMatch(c_end_d_txt.Text.ToString()))
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
                    if (!(DateTime.TryParse(c_end_d_txt.Text.ToString(), out outDate)))
                    {
                        //add message and set flag to false
                        vaildMsg += "Invaildewd data enterd \n\n";
                        vaildFlag = false;
                    }
                }
            }
            if (c_level_txt.Text.ToString() == "")
            {
                vaildMsg += " You need to enter a course level \n\n";
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
                    ((KeyValuePair<string, string>)aim_id_cmb.SelectedItem).Key.ToString());
                values.Add(c_cname_txt.Text);
                values.Add(c_level_txt.Text);
                values.Add(c_start_d_txt.Text);
                values.Add(c_end_d_txt.Text);


                if (insertFlag)
                {
                    //insert mode branch
                    mySqlSrc.InsertRow("course", courseFieldList, values, courseTypeIsStringList);
                }
                else
                {
                    //update mode branch
                    mySqlSrc.UpdateRow("course", courseFieldList, values, courseTypeIsStringList, idFieldName, updateId);
                }
                this.Close();
            }
        }
        private void CourseForm_FormColsed(object sender, FormClosedEventArgs e)
        {
            //set the main form from flag to say we are closed now
            mainFormRef.CourseFormClosed();
        }
        public void SetStartDateAdded(string value)
        {
            c_start_d_txt.Text = value;
        }
        public void SetEndDateAdded(string value)
        {
            c_end_d_txt.Text = value;
        }
        public void SetLearningAimAdded(string value)
        {
            aim_id_cmb.Text = value;
        }
        public void SetCourseLevelAdded(string value)
        {
            c_level_txt.Text = value;
        }
    }
}
