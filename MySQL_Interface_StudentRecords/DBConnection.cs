using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_Interface_StudentRecords
{
    class DBConnection
    {
        // The private vars for the class
        private MySqlConnection connection;
        private string server;
        private string port;
        private string database;
        private string username;
        private string password;

        public DBConnection()
        {
            Initialize();
        }
        private void Initialize()
        {
            // details to connect to the server
            server = "localhost";
            username = "root";
            password = "";
            port = "3306";
            database = "studentrecords";

            // string to connect to the database
            string connectionString = "SERVER=" + server + ";"
                                    + "PORT=" + port + ";"
                                    + "DATABASE=" + database + ";"
                                    + "UID=" + username + ";"
                                    + "PASSWORD=" + password + ";"
                                    + "ALLOW ZERO DATETIME=True;"
                                    + "CONVERT ZERO DATETIME=True;";

            //store the connection, supplying connection string
            connection = new MySqlConnection(connectionString);
        }
        // open the connection
        private bool OpenConnection()
        {
            //exeception handling
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Open fail \n\n" + ex);
                return false;
            }
        }
        // close the connection
        private bool CloseConnection()
        {
            //exeception handling
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Close fail \n\n" + ex);
                return false;
            }

        }
        // test the connection
        public void TestConnection()
        {
            //use the OpenConnection method
            if (this.OpenConnection())
            {
                // if succesful, show it through dialouge
                MessageBox.Show("I R CONNECT!");
            }
            // use the CloseConnection method
            this.CloseConnection();
        }

        // genreal purpose slelect statement genrator and caller
        public List<string>[] SelectQuery(string tableName, List<string> fieldNames)
        {
            //RESULTS LIST CONSTRUCTION
            //creates main list object (rows) to hold indivaidual values(columns)
            List<string>[] results = new List<string>[fieldNames.Count];

            // generic counter to use for the loop
            int counter = 0;

            while (counter < fieldNames.Count)
            {
                results[counter] = new List<string>();

                counter++;
            }

            //rest the counter
            counter = 0;

            //SELECT QUERY CONSRUCTION

            //query initaliastion - SELECT part
            string query = "SELECT ";

            //loop through each fieldname and add to select statement
            foreach (var field in fieldNames)
            {
                // add comma to seprate around filed name and add field to quey (and a space)
                if (counter > 0)
                {
                    query += ",";
                }
                // add backquotes around filed name and add field to query
                query += "`" + field + "` ";
                counter++;

            }
            //reset counter
            counter = 0;

            // now add FROM part - table name with backquotes around it
            query += "FROM " + "`" + tableName + "`";

            // comment / uncomment to debug - this message box will display the query
            MessageBox.Show(query);

            //CONNECT, RUN QUERY and POPULATE RESULTS

            // open connection
            if (this.OpenConnection())
            {
                //create MySQL command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a 'data reder' to get the results
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loop though each row off the results
                while (dataReader.Read())
                {
                    //loop through each fieldname and add to select statement
                    foreach (var field in fieldNames)
                    {
                        //in the square brackets, the string must match
                        //the column / filed on the databaase
                        //step through to check values

                        //if this is a data value then we need to conver to prevent issues
                        if (dataReader[field].GetType().ToString() ==
                                "MySql.Data.Types.MySqlDateTime")
                        {
                            //get the current mysql data object
                            MySql.Data.Types.MySqlDateTime mySqlFormat =
                                (MySql.Data.Types.MySqlDateTime)dataReader[field];
                            //convert to c# data type
                            DateTime csFormat = mySqlFormat.GetDateTime();
                            //format in the MySQL style before adding results
                            results[counter].Add(csFormat.ToString("yyyy-MM-dd"));
                        }
                        else
                        {
                            //add the value to the results
                            results[counter].Add(dataReader[field].ToString());
                        }

                        counter++;
                    }
                    // reset couner before geting new row of data
                    counter = 0;
                }
                // close data reader and connection
                dataReader.Close();
                this.CloseConnection();
            }
            //return the results
            return results;
        }
        //genreal purpose insert statement genrator and caller for single row
        // assumes null allowable for id with auto increment
        public void InsertRow(string tableName, List<string> fieldNames,
                                List<string> values, List<bool> isStringType)
        {
            //build insert query
            //not the backquotes around table name
            string query = "INSERT INTO " + "`" + tableName + "`";

            //genric counter for loops used for comma placement
            int counter = 0;

            //FIELD NAMES----------------------------------------------------

            //add opening brackets for list of fields
            query += " (";

            //loop though each field name and add insert statement
            foreach (var field in fieldNames)
            {
                if (counter > 0)
                {
                    query += ",";
                }

                //add back quotes around field name and add field to query and a space
                query += "`" + field + "` ";
                counter++;
            }
            //add the closing bracket for list of fields
            query += " )";

            //VALUES TO INSERT ------------------------------------------------------

            //reset counter
            counter = 0;

            //add va;ies keyword
            query += "VALUES ";
            //add opening bracket fir list of values
            query += " (";

            //loop through each field name and add to insert statment
            foreach (var value in values)
            {
                //add comma to seprate list if not first item
                if (counter > 0)
                {
                    query += ",";
                }

                //check to add open quote if string type
                //(string type needs quotes, not numeric values)
                if (isStringType[counter])

                    query += "'";
                query += value;

                //check to add close quote if is stirng
                if (isStringType[counter])

                    query += "'";

                //update counter
                counter++;


            }
            // add closing brackets for list of values
            query += ") ";

            //comment / uncomment to beug ,the message box will display query
            MessageBox.Show(query);

            //run query
            if (this.OpenConnection())
            {
                // set mySQL command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // excute statement (no results expected)
                cmd.ExecuteNonQuery();
            }
            this.CloseConnection();
        }
        public void DeleteRowWithId(string tableName, string idFieldName, string idValue)
        {
            //build delete query
            //note the backquotes around the table field
            //no quotes around id as numeric value
            string query = "DELETE FROM " + "`" + tableName + "`" +
                " WHERE " + "`" + idFieldName + "`" + "=" + idValue;

            //comment / uncomment to debug (dispaly the query)
            MessageBox.Show(query);

            // run query
            if (this.OpenConnection())
            {
                //set mySQL command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //excute statement
                cmd.ExecuteNonQuery();
            }
            this.CloseConnection();
        }
        // general purpose statement genrator and caller for single row from id
        public List<string>[] SelectRowWithId(string tableName, List<string> fieldNames,
            string idFieldName, string idValue)
        {
            //RESULTS LIST CONSTRUCTION--------------------------------------------------
            //create main list object (rows) to hold individual lists (columns)
            List<string>[] results = new List<string>[fieldNames.Count];

            // generic counter to be used for loop
            int counter = 0;
            
            //create the individual lists to hold the results for each field/column
            while (counter < fieldNames.Count)
            {
                results[counter] = new List<string>();
                counter++;
            }
            // reset counnter
            counter = 0;

            // SELECT QUERY CONSTRUCTION
            string query = "SELECT ";
            
            //loop thorugh each fieldname and add to select statemnt
            foreach (var field in fieldNames)
            {
                //add comma to each field name and add to select statement
                if (counter > 0)
                {
                    query += ",";
                }
                // add backquotes around field name and add field to quetu ( and a space)
                query += "`" + field + "`";

                counter++;
            }
            //reset counter
            counter = 0;
            // now add from part
            query += "FROM " + "`" + tableName + "`";

            // now add where part to select the row based on ID
            query += " WHERE " + "`" + idFieldName + "`" + "=" + idValue;

            //comment / uncomment to debug
            MessageBox.Show(query);

            //connect, run query and populate results --------------------------------------

            // open connection
            if (this.OpenConnection())
            {
                //create me Sql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a data reader to get the results
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loop thorugh each row of results
                while (dataReader.Read())
                {
                    foreach (var field in fieldNames)
                    {
                        //in the square brackets, the string must macth
                        //the column/ field name on the database
                        //step through to check valeus

                    //if this is a data value then we need to convert to pervent issues
                    if (dataReader[field].GetType().ToString() == "MySql.Data.Types.MySqlDateTime")
                        {
                            // get the current mysql date object
                            MySql.Data.Types.MySqlDateTime mySqlFormat =
                                (MySql.Data.Types.MySqlDateTime)dataReader[field];
                            //convert to csharp data type
                            DateTime csFormat = mySqlFormat.GetDateTime();
                            //format in the MySQL style before adding results
                            results[counter].Add(csFormat.ToString("yyyy-MM-dd"));
                        }
                    else
                        {
                            //add values to the results
                            results[counter].Add(dataReader[field].ToString());
                        }
                        counter++;
                    }
                    //reset the counter before getting next row of data 
                    counter = 0;
                }
                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();
            }
            //return results
            return results;
        }
        public void UpdateRow(string tableName, List<string> fieldNames, List<string> values,
                List<bool> isStringTypes, string idFieldName, string idValue)
        {
            //build update query
            //note the backquotes around the table name
            string query = "UPDATE " + "`" + tableName + "`";

            //genric counter for loops, used for comma placement
            int counter = 0;

            //SET FIELDS WITH VALUES ----------------------------------------------------------------

            // set keyword
            query += "SET ";

            //loop thorugh each field name and add to insert statement
            foreach (var field in fieldNames)
            {
                //add comma to sepate list if not first item
                if (counter > 0)
                {
                    query += ",";
                }

                //add backquotes around field name and add field to query (and a space)
                query += "`" + field + "`";

                // add the assigment operator to link fields with values
                query += "=";

                //check to add open quote if  a sting (no numeric valeus)
                if (isStringTypes[counter])
                    query += "'";

                query += values[counter];

                //check to add close quote if string typr
                if (isStringTypes[counter])
                    query += "'";

                counter++;
            }
            //WHERE CLAUSE ---------------------------------------------------------------------
            query += " WHERE " + "`" + idFieldName + "`" + "=" + idValue;
            //comment / uncoment to help debug
            MessageBox.Show(query);

            //run query
            if (this.OpenConnection())
            {
                //set my sql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //excute statemnt
                cmd.ExecuteNonQuery();
            }
            this.CloseConnection();
        }
       //genral purpose select query for searching strings
       public List<string>[] SearchLikeQuery (string tableName, List<string> fieldNames,
                                                string searchField, string searchValue)
       {
            //RESULTS LIST CONSTRUCTION------------------------------------

            //create main list object (rows) to hold individual lists (column)
            List<string>[] results = new List<string>[fieldNames.Count];

            //genric counter to be used for loops
            int counter = 0;

            //create the indivual list to hold the results for each field / column
            while (counter < fieldNames.Count)
            {
                results[counter] = new List<string>();

                counter++;
            }

            //reset counter
            counter = 0;

            //SELECT QUERY CONSTUCTION--------------------------------------------

            //query initialisation - SElECT part

            string query = "SELECT ";

            //loop tough each field name and add to select statement
            foreach (var field in fieldNames)
            {
                //add comma to separate list items not first item
                if (counter > 0)
                {
                    query += ",";
                }

                //add backquotes around fieldname and add field to query and a space
                query += "`" + field + "` ";

                counter++;
            }
            //rest counter
            counter = 0;

            //now add FROM part - table name woth backquotes around it
            query += "FROM " + "`" + tableName + "`";

            //now add where clause with Like for search

            query += " WHERE " + "`" + searchField + "`" +
                " LIKE " + "'" + "%" + searchValue + "%" + "'";

            //comment / uncomment to debug - this messagebox will display the query
            MessageBox.Show(query);

            //CONNECT, RUN QUERY AND POPULATE RESULTS------------------------------------

            //open connection
            if(this.OpenConnection())
            {
                //create MYSQL command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a 'data reader' to get results
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loop thorugh each row of results
                while (dataReader.Read())
                {
                    //loop through each field name and add to select statemnts
                    foreach(var field in fieldNames)
                    {
                        //in the square brackets, the string must match
                        //the column / field name on the data base
                        // step through to check values
                        if (dataReader[field].GetType().ToString() ==
                            "MySql.Data.Types.MySqlDataTime")
                        {
                            //get the current my squl object
                            MySql.Data.Types.MySqlDateTime mySqlFormat =
                                (MySql.Data.Types.MySqlDateTime)dataReader[field];
                            //conver to c# data type
                            DateTime csFormat = mySqlFormat.GetDateTime();
                            //format in style of my sql
                            results[counter].Add(csFormat.ToString("yyyy-MM--dd"));
                        }
                        else
                        {
                            //add the value to results
                            results[counter].Add(dataReader[field].ToString());
                        }
                        counter++;
                    }
                    //reset counter
                    counter = 0;
                }
                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();
            }
            //return results
            return results;
       }
        //method to filter specific enrolment results - hardcoded
       public List<string>[] EnrolmentFilterQuery(string searchField, string searchValue)
        {
            List<string> fieldNames = new List<string>() { "enrolment_id", "c_cname", "s_name" };

            //create main list object (rows) to hold individual list columns
            List<string>[] results = new List<string>[fieldNames.Count];

            

            int counter = 0;
            //create the individual Lists to hod the resluts for each field / column
            while (counter < fieldNames.Count)
            {
                results[counter] = new List<string>();

                counter++;
            }

            //full query to join enrolemt, student, course wit the fields we required
            string query = "SELECT `enrolment`.`enrolment_id`," +
                            "CONCAT(`student`.`s_fname`,' ',`student`.`s_sname`) AS 's_name'," +
                            "`course`.`c_cname`" +

                            "FROM `enrolment` " +

                            "INNER JOIN `student` " +
                            "ON `enrolment`.`student_id` = `student`.`student_id` " +

                            "INNER JOIN `course` " +
                            "ON `enrolment`.`course_id` = `course`.`course_id` ";
            //if we are searching on c_id then here it is where clause
            if (searchField == "student_id")
            {
                query += "WHERE `enrolment`.`student_id` = " + searchValue;
            }

            //comment / uncomment to debug
            MessageBox.Show(query);

            //CONNECT< RUN QUERY AND POPULATE RESULTS--------

            counter = 0;
            //open connectiob
            if(this.OpenConnection())
            {
                //create MySQOl command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a data reader to get the results
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loop tyhorugh each row of the results
                while (dataReader.Read())
                {
                    //loop through each filedname and add to select statement
                    foreach (var field in fieldNames)
                    {
                        //inn the square brackets, the string must match
                        //the column / field name on the data base
                        //step through to check values

                        //add the value to the results
                        results[counter].Add(dataReader[field].ToString());

                        counter++;
                    }

                    //reset counter before getting next row data 
                    counter = 0;
                }
                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();
            }
            //return the results list
            return results;
        }

        public List<string>[] JobRoleFilterQuery(string searchField, string searchValue)
        {
            List<string> fieldNames = new List<string>() { "role_id", "dep_id", "st_name" };

            //create main list object (rows) to hold individual list columns
            List<string>[] results = new List<string>[fieldNames.Count];



            int counter = 0;
            //create the individual Lists to hod the resluts for each field / column
            while (counter < fieldNames.Count)
            {
                results[counter] = new List<string>();

                counter++;
            }

            //full query to join enrolemt, student, course wit the fields we required
            string query = "SELECT `job_role`.`role_id`," +
                            "CONCAT(`staff`.`st_fname`,' ',`staff`.`st_sname`) AS 'st_name'," +
                            "`department`.`dep_id`" +

                            "FROM `job_role` " +

                            "INNER JOIN `staff` " +
                            "ON `job_role`.`staff_id` = `staff`.`staff_id` " +

                            "INNER JOIN `department` " +
                            "ON `job_role`.`dep_id` = `department`.`dep_id` ";
            //if we are searching on c_id then here it is where clause
            if (searchField == "staff_id")
            {
                query += "WHERE `job_role`.`staff_id` = " + searchValue;
            }

            //comment / uncomment to debug
            MessageBox.Show(query);

            //CONNECT< RUN QUERY AND POPULATE RESULTS--------

            counter = 0;
            //open connectiob
            if (this.OpenConnection())
            {
                //create MySQOl command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a data reader to get the results
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loop tyhorugh each row of the results
                while (dataReader.Read())
                {
                    //loop through each filedname and add to select statement
                    foreach (var field in fieldNames)
                    {
                        //inn the square brackets, the string must match
                        //the column / field name on the data base
                        //step through to check values

                        //add the value to the results
                        results[counter].Add(dataReader[field].ToString());

                        counter++;
                    }

                    //reset counter before getting next row data 
                    counter = 0;
                }
                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();
            }
            //return the results list
            return results;
        }



    }
}
