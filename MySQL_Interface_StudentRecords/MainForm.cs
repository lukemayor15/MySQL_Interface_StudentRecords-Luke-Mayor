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
    public partial class MainForm : Form
    {
        //Database connection object
        DBConnection mySqlSrc = new DBConnection();
        //----------CUSTOMER TABLE--------------------
        //list of fields / colim names
        List<string> studentFieldList = new List<string>()
        { "student_id", "user_id", "s_fname", "s_sname", "s_mname", "s_dob", "s_phone_no", "s_email", "s_id_image" };

        //handlers for sybfomr
        StudentForm studentFrm;
        public bool studentFrmIsOpen = false;

        //------------------------ USER ACCOUNT TABLE ----------------------------------------
        List<string> userAccountFieldList = new List<string>()
        { "user_id", "u_uname",  "u_password", "u_access_level"};

        // handlers for subform
        UserAccountForm userAccountFrm;
        public bool userAccountFrmIsOpen = false;

        //------------------------------------STAFF TABLE
        List<string> staffFieldList = new List<string>()
        { "staff_id", "user_id", "st_fname", "st_sname", "st_mname", "st_dob", "st_phone_no", "st_email", "st_id_image"};

        //subform handlers
        StaffForm staffFrm;
        public bool staffFrmIsOpen = false;

        //--------------------------NEXT OF KIN----------------------------------------
        List<string> nextOfKinFieldList = new List<string>()
        { "kin_id","user_id", "k_fname", "k_phone_no"};

        //subform handlers
        NextOfKinForm nextOfKinFrm;
        public bool nextOfKinIsOpen = false;


        //-----------------ADDRESS TABLE------------------------------------
        List<string> addressFieldList = new List<string>()
        {"address_id", "user_id", "a_postcode", "a_address_line1", "a_address_line2", "a_town", "a_county", "a_current_address"};

        //subform handlers
        AddressForm addressFrm;
        public bool addressIsOpen = false;

        //-----------------------DEPARTMENT TABLE (DEP)---------------------------
        List<string> depFieldList = new List<string>()
        { "dep_id","dep_name", "dep_email", "dep_phone_no", "dep_leader"};

        //subform handlers
        DepartmentForm depFrm;
        public bool depIsOpen = false;

        //---------------------JOB ROLE TABLE-----------------------------------------
        List<string> jobRoleFieldList = new List<string>()
        { "role_id" ,"staff_id", "dep_id", "j_title"};

        //subform handlers
        JobRoleForm jobRoleFrm;
        public bool jobRoleIsOpen = false;

        //---------LEARNING AIM FORM--------------------------
        List<string> learningAimFieldList = new List<string>()
        { "aim_id", "dep_id", "l_learning_aim_title", "l_learning_aim_description"};

        //subform handlers
        LearningAimForm learningAimFrm;
        public bool learningAimIsOpen = false;

        //----------COURSE FORM------------------------
        List<string> courseFieldList = new List<string>()
        { "course_id", "aim_id", "c_cname","c_level", "c_start_d", "c_end_d"};

        //subform handlers
        CourseForm courseFrm;
        public bool courseIsOpen = false;

        //----------ENROLMENT FORM-------------------------------
        List<string> enrolmentFieldList = new List<string>()
        {"enrolment_id","course_id", "student_id","en_date" };

        //subform handlers
        EnrolmentForm enrolmentFrm;
        public bool enrolmentIsOpen = false;

        //--------------ENROLMENT FILTER---------------------------
        List<string> enrolmentFilterFieldList = new List<string>()
        { "enrolment_id", "c_cname", "s_name" };

        //--------------STUDNET COMBO BOX
        List<string> studentCmbFieldList = new List<string>()
        { "student_id", "s_fname", "s_sname" };

        //-------------------STAFF FILTER
        List<string> jobRoleFilterFieldList = new List<string>()
        { "role_id", "dep_id", "st_name" };

        //STAFF COMBO BOX
        List<string> staffCmbFieldList = new List<string>()
        { "staff_id", "st_fname", "st_sname"};

        int studentRows = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            // test the database connection
            // a message box should apper with the results
            mySqlSrc.TestConnection();

        }

        public void SelectSearchResultsAndUpdateGrid(string tableName, List<string> fieldList,
            DataGridView datagridtoUpdate, string searchField, string searchValue)
        {
            // create results list
            List<string>[] results = new List<string>[fieldList.Count];

            // call Select query sending table name and fields
            results = mySqlSrc.SearchLikeQuery(tableName, fieldList, searchField, searchValue);

            // clera the data grid
            datagridtoUpdate.Rows.Clear();

            //count the rows
            int rows = results[0].Count;

            //loop thorugh each array for new row
            for (int i = 0; i < rows; i++)
            {
                //new string array for new row
                string[] newRow = new string[fieldList.Count];

                for (int j = 0; j < fieldList.Count; j++)
                {
                    //add new item to row
                    //j index is column name / i index for the current row value
                    newRow[j] = results[j][i];
                }
                //add the completed row to the data grid
                datagridtoUpdate.Rows.Add(newRow);
            }
        }
        public void SelectResultsAndUpdateGrid(string tableName, List<string> fieldList,
            DataGridView datagridtoUpdate)
        {
            // create results list
            List<string>[] results = new List<string>[fieldList.Count];

            // call Select query sending table name and fields
            results = mySqlSrc.SelectQuery(tableName, fieldList);

            // clera the data grid
            datagridtoUpdate.Rows.Clear();

            //count the rows
            int rows = results[0].Count;

            //loop thorugh each array for new row
            for (int i = 0; i < rows; i++)
            {
                //new string array for new row
                string[] newRow = new string[fieldList.Count];

                for (int j = 0; j < fieldList.Count; j++) 
                {
                    //add new item to row
                    //j index is column name / i index for the current row value
                    newRow[j] = results[j][i];
                }
                //add the completed row to the data grid
                datagridtoUpdate.Rows.Add(newRow);
            }
        }

        // method to manage subforms
        private void CloseAndNullAllSubforms()
        {
            //check each form to see if open flag set
            //if so close the form and null object (unset flag)
            //STUDENT FORM

            if (studentFrmIsOpen)
            {
                studentFrm.Close();
                studentFrm = null;
                studentFrmIsOpen = false;
            }
            //PRODUCT FORM
            if (userAccountFrmIsOpen)
            {
                userAccountFrm.Close();
                userAccountFrm = null;
                userAccountFrmIsOpen = false;
            }
            //STAFF TABLE
            if(staffFrmIsOpen)
            {
                staffFrm.Close();
                staffFrm = null;
                staffFrmIsOpen = false;
            }
            //NEXT OF KIN
            if(nextOfKinIsOpen)
            {
                nextOfKinFrm.Close();
                nextOfKinFrm = null;
                nextOfKinIsOpen = false;
            }
            //ADDRESS TABLE
            if(addressIsOpen)
            {
                addressFrm.Close();
                addressFrm = null;
                addressIsOpen = false;
            }
            //DEPARTMENT TABLE
            if(depIsOpen)
            {
                depFrm.Close();
                depFrm = null;
                depIsOpen = false;
            }
            //JOB ROLE TABLE
            if(jobRoleIsOpen)
            {
                jobRoleFrm.Close();
                jobRoleFrm = null;
                jobRoleIsOpen = false;
            }
            //LEARNING AIM TABLE
            if(learningAimIsOpen)
            {
                learningAimFrm.Close();
                learningAimFrm = null;
                learningAimIsOpen = false;
            }
            //COURSE TABLE
            if (courseIsOpen)
            {
                courseFrm.Close();
                courseFrm = null;
                courseIsOpen = false;
            }
            //ENROLEMT TANLE
            if (enrolmentIsOpen)
            {
                enrolmentFrm.Close();
                enrolmentFrm = null;
                enrolmentIsOpen = false;
            }
        }

        public void DeleteOrUpdateSelectedRow(string tableName, string idFieldName, 
                                                DataGridView datagridUpdate, bool isUpdate)
        {
            // check of rows in data grid
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = datagridUpdate.Rows.Count;

            //loop though the rows
            for (int i = 0; i < numRows; i++)
            {
                //of row selected in data grid
                if (datagridUpdate.Rows[i].Selected)
                {
                    rowId = i;
                    isSelected = true;
                }
            }
            if (isSelected)
            {
                string idValue = datagridUpdate.Rows[rowId].Cells[0].Value.ToString();
                //to debug comment / uncomment to show value of id selected
                //we will send this value to the query method
                //check if update or delete
                if (isUpdate)
                {
                    CloseAndNullAllSubforms();

                    //create new main form object to send to this
                    // as refrence to the student form
                    MainForm newform = new MainForm();
                    newform = this;

                    //send from refrence and set insert flag to false
                    //send id from selected row
                    switch (tableName)
                    {
                        case "student":
                            {
                                studentFrm = new StudentForm(ref newform, false, idValue);
                                //show form and set open flag
                                studentFrm.Show();
                                studentFrmIsOpen = true;
                            }
                            break;
                        case "user_account":
                            {
                                userAccountFrm = new UserAccountForm(ref newform, false, idValue);
                                //show form and set open flag
                                userAccountFrm.Show();
                                userAccountFrmIsOpen = true;
                            }
                            break;
                        case "staff":
                            {
                                staffFrm = new StaffForm(ref newform, false, idValue);
                                //show form and set open faLSE
                                staffFrm.Show();
                                staffFrmIsOpen = true;
                            }
                            break;
                       case "next_of_kin":
                            {
                                nextOfKinFrm = new NextOfKinForm(ref newform, false, idValue);
                                //show form and set open false
                                nextOfKinFrm.Show();
                                nextOfKinIsOpen = true;
                            }
                            break;
                       case "address":
                            {
                                addressFrm = new AddressForm(ref newform, false, idValue);
                                //show form and set open false
                                addressFrm.Show();
                                addressIsOpen = true;

                            }
                            break;
                        case "department":
                            {
                                depFrm = new DepartmentForm(ref newform, false, idValue);
                                //show form and set open false
                                depFrm.Show();
                                depIsOpen = true;
                            }
                            break;
                        case "job_role":
                            {
                                jobRoleFrm = new JobRoleForm(ref newform, false, idValue);
                                //show form and set open false
                                jobRoleFrm.Show();
                                jobRoleIsOpen = true;
                            }
                            break;
                        case "learning_aim":
                            {
                                learningAimFrm = new LearningAimForm(ref newform, false, idValue);
                                //show form and set open false
                                learningAimFrm.Show();
                                learningAimIsOpen = true;
                            }
                            break;
                        case "course":
                            {
                                courseFrm = new CourseForm(ref newform, false, idValue);
                                //show form and set open false
                                courseFrm.Show();
                                courseIsOpen = true;
                            }
                            break;
                        case "enrolment":
                            {
                                enrolmentFrm = new EnrolmentForm(ref newform, false, idValue);
                                //show form and set open false
                                enrolmentFrm.Show();
                                enrolmentIsOpen = true;
                            }
                            break;
                    }       
                    
                }
                else if(!isUpdate)
                {
                    //calls delete row method on DB connection
                    //and sends the id value to selected row
                    mySqlSrc.DeleteRowWithId(tableName, idFieldName, idValue);
                }
                
                    

                
            }
            else
            {
                // if no row selcted disply to user
                MessageBox.Show("No Row Selcted");
            }
        }
        public void PopulateEnrolmentFilterCombos()
        {
            //--------------------------------STUDENT COMBO BOX

            //Bind combo box to dictionary
            //this allows us a key value pair
            Dictionary<string, string> studentItem = new Dictionary<string, string>();

            //Get new list for results of customer table
            List<string>[] studentResults = new List<string>[studentCmbFieldList.Count];
            studentResults = mySqlSrc.SelectQuery("student", studentCmbFieldList);

            //count the rows
            studentRows = studentResults[0].Count;
            for (int i = 0; i < studentRows; i++)
            {
                //column row
                //add to the dictionary object the id and name
                string fullName = studentResults[1][i] + " " + studentResults[2][i];
                studentItem.Add(studentResults[0][i], fullName);
            }
            //bind the dictionary object and set key vlaue
           
            enrolmentf_s_cmb.DisplayMember = "Value";
            enrolmentf_s_cmb.ValueMember = "key";
            enrolmentf_s_cmb.DataSource = new BindingSource(studentItem, null);

        }
        //student method for wishlish filters
        public void EnrolmentFilterSearchAndUpdateGrid(string searchField, string searchValue)
        {
            //create results list
            List<string>[] results = new List<string>[enrolmentFilterFieldList.Count];

            //call SELECT query sending table name and fields

            results = mySqlSrc.EnrolmentFilterQuery(searchField, searchValue);

            //clear the data grid
            enrolmentfilter_dg.Rows.Clear();

            //count the rows
            int rows = results[0].Count;

            //loop though each row of results
            for (int i = 0; i < rows; i++)
            {
                //new string array for new row
                string[] newRow = new string[enrolmentFilterFieldList.Count];

                for (int j = 0; j < enrolmentFilterFieldList.Count; j++)
                {
                    //add new item to row
                    //j index is column names / i index for the current row value
                    newRow[j] = results[j][i];
                }

                //add the completed row to teh data grid
                enrolmentfilter_dg.Rows.Add(newRow);
            }
        }

        //staff method for job role filter
        public void JobRoleFilterSearchAndUpdateGrid(string searchField, string searchValue)
        {
            //create results list
            List<string>[] results = new List<string>[jobRoleFilterFieldList.Count];

            //call SELECT query sending table name and fields

            results = mySqlSrc.JobRoleFilterQuery(searchField, searchValue);

            //clear the data grid
            jobrolef_dg.Rows.Clear();

            //count the rows
            int rows = results[0].Count;

            //loop though each row of results
            for (int i = 0; i < rows; i++)
            {
                //new string array for new row
                string[] newRow = new string[jobRoleFilterFieldList.Count];

                for (int j = 0; j < jobRoleFilterFieldList.Count; j++)
                {
                    //add new item to row
                    //j index is column names / i index for the current row value
                    newRow[j] = results[j][i];
                }

                //add the completed row to teh data grid
                jobrolef_dg.Rows.Add(newRow);
            }
        }

        //STAFF COMBO BOX
        public void PopulateJobRoleFilterCombos()
        {
            //--------------------------------STUDENT COMBO BOX

            //Bind combo box to dictionary
            //this allows us a key value pair
            Dictionary<string, string> staffItem = new Dictionary<string, string>();

            //Get new list for results of customer table
            List<string>[] staffResults = new List<string>[staffCmbFieldList.Count];
            staffResults = mySqlSrc.SelectQuery("staff", staffCmbFieldList);

            //count the rows
            studentRows = staffResults[0].Count;
            for (int i = 0; i < studentRows; i++)
            {
                //column row
                //add to the dictionary object the id and name
                string fullName = staffResults[1][i] + " " + staffResults[2][i];
                staffItem.Add(staffResults[0][i], fullName);
            }
            //bind the dictionary object and set key vlaue
            
            jobrolef_staff_cmb.DisplayMember = "Value";
            jobrolef_staff_cmb.ValueMember = "key";
            jobrolef_staff_cmb.DataSource = new BindingSource(staffItem, null);
        }
        public void StudentFormClosed()
        {
            //reset form and flags
            studentFrmIsOpen = false;
            studentFrm = null;

            //update results
            //[table name], [field list[, [data grid]
            SelectResultsAndUpdateGrid("student", studentFieldList, student_dg);

        }
        public void UserAccountFormClosed()
        {
            //reset form and flags
            userAccountFrmIsOpen = false;
            userAccountFrm = null;
            //update results
            //([table name], [field list], [data grid])
            SelectResultsAndUpdateGrid("user_account", userAccountFieldList, user_account_dg);
        }
        public void StaffFormClosed()
        {
            //reset form and slags
            staffFrmIsOpen = false;
            staffFrm = null;
            //update results
            //table name, field list, data grid
            SelectResultsAndUpdateGrid("staff", staffFieldList, staff_dg);
        }
        public void NextOfKinFormClosed()
        {
            //reset form and flasgs
            nextOfKinIsOpen = false;
            nextOfKinFrm = null;
            //update table and results
            //table name, field list, data grid
            SelectResultsAndUpdateGrid("next_of_kin", nextOfKinFieldList, next_of_kin_dg);
        }
        public void AddressFormClosed()
        {
            //reset form and flags
            addressIsOpen = false;
            addressFrm = null;

            //update results
            //table name, field list, data grid
            SelectResultsAndUpdateGrid("address", addressFieldList, address_dg);
        }
        public void DepFormClosed()
        {
            //reset form and flags
            depIsOpen = false;
            depFrm = null;

            //update results
            //table name, field list, dat grid
            SelectResultsAndUpdateGrid("department", depFieldList, dep_dg);
        }
        public void JobRoleFormClosed()
        {
            //reset form and falgs
            jobRoleIsOpen = false;
            jobRoleFrm = null;

            //update results
            //table name, field list, data grid
            SelectResultsAndUpdateGrid("job_role", jobRoleFieldList, J_role_dg);
        }
        public void LearningAimFormClosed()
        {
            //reset form and flags
            learningAimIsOpen = false;
            learningAimFrm = null;

            //update results
            //table name, field list, data grid
            SelectResultsAndUpdateGrid("learning_aim", learningAimFieldList, learning_aim_dg);
        }
        public void CourseFormClosed()
        {
            //reset form and flags
            courseIsOpen = false;
            courseFrm = null;

            //ipdate results
            //table name, field list, data grid
            SelectResultsAndUpdateGrid("course", courseFieldList, course_dg);
        }
        public void EnrolmentFormClosed()
        {
            //reset form and flags
            enrolmentIsOpen = false;
            enrolmentFrm = null;

            //update results
            //table name, field list, data grid
            SelectResultsAndUpdateGrid("enrolment", enrolmentFieldList, enrolment_dg);
        }
        private void select_su_btn_Click(object sender, EventArgs e)
        {
            //([table name[ [filed list], [data grid])
            SelectResultsAndUpdateGrid("student", studentFieldList, student_dg);
        }

        private void insert_su_btn_Click(object sender, EventArgs e)
        {
            CloseAndNullAllSubforms();
            //create new MainForm object to send to this form
            //as refernece for customer form
            MainForm newform = new MainForm();
            newform = this;
            // send from refernce and set insert floag to true
            studentFrm = new StudentForm(ref newform, true);
            //show form and set open flag
            studentFrm.Show();
            studentFrmIsOpen = true;
        }
       


        private void delete_su_btn_Click(object sender, EventArgs e)
        {
            // do delte then update grid
            //(table name], [id field name], [data gird[)
            DeleteOrUpdateSelectedRow("student", "student_id", student_dg, false);

            //([table name], [field list], [data grid])
            SelectResultsAndUpdateGrid("student", studentFieldList, student_dg);
        }

        private void update_su_btn_Click(object sender, EventArgs e)
        {
            //([table name], [id field name], [data grid[)
            DeleteOrUpdateSelectedRow("student", "student_id", student_dg, true);
        }
        private void search_s_sname_txt_TextChange(object sender, EventArgs e)
        {
            //uncomment to see even fire and show the characters in text box
            //MessageBox.show(search_s_txt.Text.ToString());

            //table name, id field name, data grid, search field
            //search value
            SelectSearchResultsAndUpdateGrid("student", studentFieldList, student_dg,
                            "s_sname", search_s_sname_txt.Text.ToString());
        }

        private void select_user_btn_Click(object sender, EventArgs e)
        {
            SelectResultsAndUpdateGrid("user_account", userAccountFieldList, user_account_dg);
        }

        private void insert_user_btn_Click(object sender, EventArgs e)
        {
            CloseAndNullAllSubforms();

            //create new MainForm object to send to this form
            //as referce for User Account form
            MainForm newform = new MainForm();
            newform = this;
            //send from refernce and set insert flag to true
            userAccountFrm = new UserAccountForm(ref newform, true);
            //show form and set open flag
            userAccountFrm.Show();
            userAccountFrmIsOpen = true;
        }

        private void delete_user_btn_Click(object sender, EventArgs e)
        {
            //do delete then update grid
            //[table name], [id field name], [data grid])
            DeleteOrUpdateSelectedRow("user_account", "user_id", user_account_dg, false);

            //([table name], [field list], [data grid])
            SelectResultsAndUpdateGrid("user_account", userAccountFieldList, user_account_dg);
        }

        private void update_user_account_Click(object sender, EventArgs e)
        {
            //([table name], [field list], [data grid])
            DeleteOrUpdateSelectedRow("user_account", "user_id", user_account_dg, true);
        }
        private void search_user_uname_txt_TextChange(object sender, EventArgs e)
        {
            //uncomment to see the event fire and show the characters in textbox
            //MessageBox.Show(search_user_uname_txt_Text.ToString());

            //table name, id filed name, data grid , search field
            SelectSearchResultsAndUpdateGrid("user_account", userAccountFieldList, user_account_dg,
                                            "u_uname", search_user_uname_txt.Text.ToString());
        }



        private void select_staff_btn_Click(object sender, EventArgs e)
        {
            //table name, field list, datagrid
            SelectResultsAndUpdateGrid("staff", staffFieldList, staff_dg);
        }

        private void staff_insert_btn_Click(object sender, EventArgs e)
        {
            CloseAndNullAllSubforms();

            //create new Main Fprm object to send to this form
            // as refernce for staff form
            MainForm newform = new MainForm();
            newform = this;
            //send form refrence and set insert flag to true
            staffFrm = new StaffForm(ref newform, true);
            //show form and set open flag
            staffFrm.Show();
            staffFrmIsOpen = true;
        }

        private void delete_staff_btn_Click(object sender, EventArgs e)
        {
            //do delete then updaate grid
            //table name , id field name, data grid
            DeleteOrUpdateSelectedRow("staff", "staff_id", staff_dg, false);

            //table name,field list, data grid
            SelectResultsAndUpdateGrid("staff", staffFieldList, staff_dg);
        }

        private void update_staff_btn_Click(object sender, EventArgs e)
        {
            //table name, id field name, data grid
            DeleteOrUpdateSelectedRow("staff", "staff_id", staff_dg, true);
        }
        private void search_staff_sname_text_TextChange(object sender, EventArgs e)
        {
            //uncomment to see the vent fire and show the characters in textbox
            //MessageBox.Show(search_staff_txt.Text.ToString());

            //table name, id field name , data grid, search field, search value
            SelectSearchResultsAndUpdateGrid("staff", staffFieldList, staff_dg,
                "st_sname", search_staff_sname_txt.Text.ToString());
        }

        private void select_nect_of_kin_btn_Click(object sender, EventArgs e)
        {
            //table name, field list, data grid
            SelectResultsAndUpdateGrid("next_of_kin", nextOfKinFieldList, next_of_kin_dg);
        }

        private void insert_next_of_kin_btn_Click(object sender, EventArgs e)
        {
            CloseAndNullAllSubforms();
            //create new mainform object to send to this fgomr
            //as refrence for customer form
            MainForm newform = new MainForm();
            newform = this;
            //send form refrence and set insert flag to true
            nextOfKinFrm = new NextOfKinForm(ref newform, true);
            //show form and set open flag
            nextOfKinFrm.Show();
            nextOfKinIsOpen = true;
        }

        private void delete_next_of_kin_btn_Click(object sender, EventArgs e)
        {
            //do delete then update grid
            //table name, field list, data grid
            DeleteOrUpdateSelectedRow("next_of_kin","kin_id", next_of_kin_dg, false);

            //table name, field list, data grid
            SelectResultsAndUpdateGrid("next_of_kin", nextOfKinFieldList, next_of_kin_dg);
        }

        private void update_next_of_kin_btn_Click(object sender, EventArgs e)
        {
            //table name, field list, data grid
            DeleteOrUpdateSelectedRow("next_of_kin", "kin_id", next_of_kin_dg, true);
        }
        private void search_next_of_kin_kin_id_txt_TextChange(object sender, EventArgs e)
        {
            //uncomment to see the event fire and show the chracter in text box
            //MessageBox.Show(search_next_of_kin_kin_id_txt.Text.ToString());

            //table name, id field name, data grid, search field, search value
            SelectSearchResultsAndUpdateGrid("next_of_kin", nextOfKinFieldList, next_of_kin_dg,
                                            "kin_id", search_next_of_kin_kin_id_txt.Text.ToString());
        }

        private void select_address_btn_Click(object sender, EventArgs e)
        {
            //table name, field list, data grid
            SelectResultsAndUpdateGrid("address", addressFieldList, address_dg);
        }

        private void insert_address_btn_Click(object sender, EventArgs e)
        {
            CloseAndNullAllSubforms();
            //create new Mainform obejct to send to this form
            //as refrence for addres form
            MainForm newform = new MainForm();
            newform = this;
            //send form refrnce and set isnert flag to true
            addressFrm = new AddressForm(ref newform, true);
            //show and set open flag
            addressFrm.Show();
            addressIsOpen = true;
        }

        private void delete_address_btn_Click(object sender, EventArgs e)
        {
            //do dlete then update the grid
            //table name, id field name, data grid
            DeleteOrUpdateSelectedRow("address", "address_id", address_dg, false);

            //table name, field list, data grid
            SelectResultsAndUpdateGrid("address", addressFieldList, address_dg);
        }

        private void update_address_btn_Click(object sender, EventArgs e)
        {
            //table name, id field name, data grid
            DeleteOrUpdateSelectedRow("address", "address_id", address_dg, true);

            
        }
        private void search_address_town_txt_TextChange(object sender, EventArgs e)
        {
            //uncommeny to see the event fire and show the chracter in textbox
            //MessageBox.Show(search_address_town_txt.Text.ToString());

            //table name, id field name, data grid, search field, search value
            SelectSearchResultsAndUpdateGrid("address", addressFieldList, address_dg,
                                            "a_town", search_address_town_txt.Text.ToString());
        }

        private void select_dep_btn_Click(object sender, EventArgs e)
        {
            //table name, field list, data grid
            SelectResultsAndUpdateGrid("department", depFieldList, dep_dg);
        }

        private void insert_dep_btn_Click(object sender, EventArgs e)
        {
            CloseAndNullAllSubforms();

            //create new MainForm object to send to this form
            //as reference for Customer form
            MainForm newform = new MainForm();
            newform = this;
            //send from reference and set insert flag to true
            depFrm = new DepartmentForm(ref newform, true);
            //show form and set open flag
            depFrm.Show();
            depIsOpen = true;
        }

        private void delete_dep_btn_Click(object sender, EventArgs e)
        {
            //do delete then update grid
            //table name, id field name, data grid
            DeleteOrUpdateSelectedRow("department", "dep_id", dep_dg, false);

            //table name, field list, datagrid
            SelectResultsAndUpdateGrid("department", depFieldList, dep_dg);
        }

        private void update_dep_btn_Click(object sender, EventArgs e)
        {
            //table name, id field name, data grid
            DeleteOrUpdateSelectedRow("department", "dep_id", dep_dg, true);
        }
        private void search_dep_leader_txt_TextChange(object sender, EventArgs e)
        {
            //uncomment to see the event fire and sow the characters in textbox
            //MessageBox.Show(search_cust_txt.Text.Tostring());

            //table name, id field name, data grid. search field, search value
            SelectSearchResultsAndUpdateGrid("department", depFieldList, dep_dg,
                            "dep_leader", search_dep_leader_txt.Text.ToString());
        }

        private void select_j_role_btn_Click(object sender, EventArgs e)
        {
            //table name, field list, daat grid
            SelectResultsAndUpdateGrid("job_role", jobRoleFieldList, J_role_dg);
        }

        private void insert_j_role_btn_Click(object sender, EventArgs e)
        {
            CloseAndNullAllSubforms();
            //create new mainform object to send to this form
            //as refrence for job role form
            MainForm newform = new MainForm();
            newform = this;
            //send form refrence and sert insert flag to true
            jobRoleFrm = new JobRoleForm(ref newform, true);
            //shwo and set open flag
            jobRoleFrm.Show();
            jobRoleIsOpen = true;
        }

        private void delete_j_role_btn_Click(object sender, EventArgs e)
        {
            //do delete then update grid

            //table name, id field name, data grid

            DeleteOrUpdateSelectedRow("job_role", "role_id", J_role_dg, false);

            //table name, field list, data grid
            SelectResultsAndUpdateGrid("job_role", jobRoleFieldList, J_role_dg);
        }

        private void update_j_role_btn_Click(object sender, EventArgs e)
        {
            //table name, id field name , data grid
            DeleteOrUpdateSelectedRow("job_role", "role_id", J_role_dg, true);
        }
        private void search_job_title_txt_TextChange(object sender, EventArgs e)
        {
            //uncomment to see the event fire and show the charates in textbox
            //MessageBox.Show(search_job_title_txt.Text.ToString());

            //table name, id field name, data grid, search field, search value
            SelectSearchResultsAndUpdateGrid("job_role", jobRoleFieldList, J_role_dg,
                            "j_title", search_job_title_txt.Text.ToString());
        }

        private void select_learning_aim_btn_Click(object sender, EventArgs e)
        {
            //table name, field list, data grid
            SelectResultsAndUpdateGrid("learning_aim", learningAimFieldList, learning_aim_dg);
        }

        private void insert_learning_aim_btn_Click(object sender, EventArgs e)
        {
            CloseAndNullAllSubforms();

            //create ew MainForm object to send to this form
            //as refrence for Customer form
            MainForm newForm = new MainForm();
            newForm = this;
            //send from refrence and set insert flag to true
            learningAimFrm = new LearningAimForm(ref newForm, true);
            //show form and set open flag
            learningAimFrm.Show();
            learningAimIsOpen = true;
        }

        private void delete_learning_aim_btn_Click(object sender, EventArgs e)
        {
            //do dlete then update grid

            //table name , id field name, data grid
            DeleteOrUpdateSelectedRow("learning_aim", "aim_id", learning_aim_dg, false);

            //table name, field list , data grid
            SelectResultsAndUpdateGrid("learning_aim", learningAimFieldList, learning_aim_dg);
        }

        private void update_learning_aim_btn_Click(object sender, EventArgs e)
        {
            //table name , id field name, data grid
            DeleteOrUpdateSelectedRow("learning_aim", "aim_id", learning_aim_dg, true);
        }
        private void search_learning_aim_title_txt_TextChange(object sender, EventArgs e)
        {
            //uncomment to see the event fire and show the characters in text box
            //MessageBox.Show(search_learning_aim_title_txt.Text.ToString());

            //table name, lid field name, search field, search value
            SelectSearchResultsAndUpdateGrid("learning_aim", learningAimFieldList, learning_aim_dg,
                                                "l_learning_aim_title", search_learning_aim_title_txt.Text.ToString());
        }

        private void select_course_btn_Click(object sender, EventArgs e)
        {
            //table name, field list, data grid
            SelectResultsAndUpdateGrid("course", courseFieldList, course_dg);
        }
        
        private void insert_course_btn_Click(object sender, EventArgs e)
        {
            CloseAndNullAllSubforms();

            //create new mainform object to send to this form
            //as refrence for course form
            MainForm newform = new MainForm();
            newform = this;
            // send form refernce and set insert flag to true
            courseFrm = new CourseForm(ref newform, true);
            //show form and set openflag
            courseFrm.Show();
            courseIsOpen = true;
        }

        private void Delete_course_btn_Click(object sender, EventArgs e)
        {
            //do delete then update grid

            //table name, id field nae, data grid
            DeleteOrUpdateSelectedRow("course", "course_id", course_dg, false);

            //table name, field list, data grid
            SelectResultsAndUpdateGrid("course", courseFieldList, course_dg);

        }

        private void update_course_btn_Click(object sender, EventArgs e)
        {
            // table name, id field name, data grid
            DeleteOrUpdateSelectedRow("course", "course_id", course_dg, true);
        }
        private void search_course_cname_txt_TextChange(object sender, EventArgs e)
        {
            //uncomment to see the vent fire and show te characters in textbox
            //MessageBox.Show(search_course_cname_txt.Text.ToString());

            //table name, id field name, data grid, search field, search value
            SelectSearchResultsAndUpdateGrid("course", courseFieldList, course_dg,
                                                "c_cname", search_course_cname_txt.Text.ToString());
        }

        private void select_enrolment_btn_Click(object sender, EventArgs e)
        {
            //table name, field list, data grid
            SelectResultsAndUpdateGrid("enrolment", enrolmentFieldList, enrolment_dg);
        }

        private void insert_enrolment_btn_Click(object sender, EventArgs e)
        {
            CloseAndNullAllSubforms();

            //creat new main form object to send to this form
            //as reference for enrolemt form
            MainForm newform = new MainForm();
            newform = this;
            //send form refrence and set isnert falg to true
            enrolmentFrm = new EnrolmentForm(ref newform, true);
            //show form and setopen flag
            enrolmentFrm.Show();
            enrolmentIsOpen = true;
        }

        private void delete_enrolment_btn_Click(object sender, EventArgs e)
        {
            //do delete then update grid

            //table name, id filed name, data grid
            DeleteOrUpdateSelectedRow("enrolment", "enrolment_id", enrolment_dg, false);

            //table name, field list, data grid
            SelectResultsAndUpdateGrid("enrolment", enrolmentFieldList, enrolment_dg);
        }

        private void update_enrolment_btn_Click(object sender, EventArgs e)
        {
            //tanle name, id field name, data grid
            DeleteOrUpdateSelectedRow("enrolment", "enrolment_id", enrolment_dg, true);
        }

        private void search_enrolment_data_txt_TextChange(object sender, EventArgs e)
        {
            //uncomment to see the vent fire and show thecharcters in textbox
            //MessageBox.Show(search_enrolment_txt.Text.ToString());

            //table name, id field name, data grid, search field, search vaalue
            SelectSearchResultsAndUpdateGrid("enrolment", enrolmentFieldList, enrolment_dg,
                                        "en_date", search_enrolment_data_txt.Text.ToString());
        }

        //when value selected in student name filter for enrolment filter
        //update the frid
        private void enrolmentf_tab_Enter(object sender, EventArgs e)
        {
            PopulateEnrolmentFilterCombos();
        }
        private void enrolmentf_s_cmb_SelectedIndexChanged(object sender, EventArgs r)
        {
             EnrolmentFilterSearchAndUpdateGrid("student_id",
                (
                (KeyValuePair<string, string>)enrolmentf_s_cmb.SelectedItem)
                .Key.ToString());
        }
        //when value selcetd in staff name filter for jobrole filer
        //update grid
        private void jobRolef_tab_Enter(object sender, EventArgs e)
        {
            PopulateJobRoleFilterCombos();
        }
        private void jobRolef_staff_cmb_SelectedIndexChanged(object sender, EventArgs r)
        {
            JobRoleFilterSearchAndUpdateGrid("staff_id",
               (
               (KeyValuePair<string, string>)jobrolef_staff_cmb.SelectedItem)
               .Key.ToString());
        }
    }

}
