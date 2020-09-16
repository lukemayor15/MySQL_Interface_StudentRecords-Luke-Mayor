using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySQL_Interface_StudentRecords;

namespace DatabaseUnitTests
{
    [TestClass]
    public class ValidationUnitTests
    {
        //instance of the mainform neceassry for subform constructors
        MainForm mainform = new MainForm();


        //-----------STUDENT TESTS------------------------------

        [TestMethod]

        public void StudentFormNullDateTest()
        {
            //create instane to test
            StudentForm stForm = new StudentForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            stForm.SetDateAdded("0000-00-00");

            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void StudentFormErroneousDataTest()
        {
            //create instane to test
            StudentForm stForm = new StudentForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            stForm.SetDateAdded("erroneous data");

            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void StudentFormDateFormatTest()
        {
            //create instane to test
            StudentForm stForm = new StudentForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            stForm.SetDateAdded("19-08-19");

            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);

        }
        //check student from user id for incorrect data
        [TestMethod]
        public void StudentFormUserIdErroneusdate()
        {
            //create instance to test
            StudentForm stForm = new StudentForm(ref mainform, true);
            //define a test input and output value
            bool expectedResult = false;
            stForm.SetUserIdAdded("1");
            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        //cehcks first name for incorrect data
        [TestMethod]
        public void StudentFormFnameErroneusdate()
        {
            //create instance to test
            StudentForm stForm = new StudentForm(ref mainform, true);
            //define a test input and output value
            bool expectedResult = false;
            stForm.SetFnameAdded("James");
            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        // Checks usrname for incorrect data 

        public void StudentFormSnameErroneusdate()
        {
            //create instance to test
            StudentForm stForm = new StudentForm(ref mainform, true);
            //define a test input and output value
            bool expectedResult = false;
            stForm.SetSnameAdded("Johnson");
            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //Checks phone no for incorrect data
        public void StudentFormPhoneNoErroneusdate()
        {
            //create instance to test
            StudentForm stForm = new StudentForm(ref mainform, true);
            //define a test input and output value
            bool expectedResult = false;
            stForm.SetPhoneNoAdded("63927086202");
            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //checks email for incorrect data
        public void StudentFormEmailErroneusdate()
        {
            //create instance to test
            StudentForm stForm = new StudentForm(ref mainform, true);
            //define a test input and output value
            bool expectedResult = false;
            stForm.SetEmailAdded("james15@hotmail.co.uk");
            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //checks id image for inccrect data
        public void StudentFormIdImageErroneusdate()
        {
            //create instance to test
            StudentForm stForm = new StudentForm(ref mainform, true);
            //define a test input and output value
            bool expectedResult = false;
            stForm.SetIdImagedded("https:blackpool/301893060373");
            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        //---------------STAFF FORM TESTS
        [TestMethod]

        public void StaffFormNullDateTest()
        {
            //create instane to test
            StaffForm stForm = new StaffForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            stForm.SetDateAdded("0000-00-00");

            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void StaffFormErroneousDataTest()
        {
            //create instane to test
            StaffForm stForm = new StaffForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            stForm.SetDateAdded("erroneous data");

            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void StaffFormDateFormatTest()
        {
            //create instane to test
            StaffForm stForm = new StaffForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            stForm.SetDateAdded("19-08-19");

            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);

        }
        //check student from user id for incorrect data
        [TestMethod]
        public void StaffFormUserIdErroneusdate()
        {
            //create instance to test
            StaffForm stForm = new StaffForm(ref mainform, true);
            //define a test input and output value
            bool expectedResult = false;
            stForm.SetUserIdAdded("1");
            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        //cehcks first name for incorrect data
        [TestMethod]
        public void StafftFormFnameErroneusdate()
        {
            //create instance to test
            StaffForm stForm = new StaffForm(ref mainform, true);
            //define a test input and output value
            bool expectedResult = false;
            stForm.SetFnameAdded("James");
            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        // Checks usrname for incorrect data 

        public void StaffFormSnameErroneusdate()
        {
            //create instance to test
            StaffForm stForm = new StaffForm(ref mainform, true);
            //define a test input and output value
            bool expectedResult = false;
            stForm.SetSnameAdded("Johnson");
            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //Checks phone no for incorrect data
        public void StaffFormPhoneNoErroneusdate()
        {
            //create instance to test
            StaffForm stForm = new StaffForm(ref mainform, true);
            //define a test input and output value
            bool expectedResult = false;
            stForm.SetPhoneNoAdded("63927086202");
            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //checks email for incorrect data
        public void StaffFormEmailErroneusdate()
        {
            //create instance to test
            StaffForm stForm = new StaffForm(ref mainform, true);
            //define a test input and output value
            bool expectedResult = false;
            stForm.SetEmailAdded("james15@hotmail.co.uk");
            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //checks id image for inccrect data
        public void StaffFormIdImageErroneusdate()
        {
            //create instance to test
            StaffForm stForm = new StaffForm(ref mainform, true);
            //define a test input and output value
            bool expectedResult = false;
            stForm.SetIdImagedded("https:blackpool/301893060373");
            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }

        //-----------ENROLMENT FORM TESTS
        [TestMethod]

        public void EnrolmentFormNullDateTest()
        {
            //create instane to test
            StaffForm stForm = new StaffForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            stForm.SetDateAdded("0000-00-00");

            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EnrolmentFormErroneousDataTest()
        {
            //create instane to test
            EnrolmentForm stForm = new EnrolmentForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            stForm.SetDateAdded("erroneous data");

            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void EnrolmentFormDateFormatTest()
        {
            //create instane to test
            EnrolmentForm stForm = new EnrolmentForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            stForm.SetDateAdded("19-08-19");

            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        //checks course id for incorrect data
        public void EnrolmentFormCourseIdErroneusdata()
        {
            //create instane to test
            EnrolmentForm stForm = new EnrolmentForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            stForm.SetCourseIdAddedd("4");

            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        //checks course id for incorrect data
        public void EnrolmentFormStudnetIdErroneusdata()
        {
            //create instane to test
            EnrolmentForm stForm = new EnrolmentForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            stForm.SetstudentIdAdded("17");

            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);

        }

        //COURSE TEST METHODS
        [TestMethod]
        //checks for null
        public void CourseFormNullDateTest()
        {
            //create instane to test
            CourseForm stForm = new CourseForm(ref mainform, true);

            //define a test input and output value

            bool expectedResult = false;
            stForm.SetStartDateAdded("0000-00-00");

            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
            //do the same for end data of course form

            stForm.SetEndDateAdded("0000-00-00");

            //run the method under test
            actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        //checks for incoorect data for data
        [TestMethod]
        public void CourseFormErroneousDataTest()
        {
            //create instane to test
            CourseForm stForm = new CourseForm(ref mainform, true);

            //define a test input and output value

            bool expectedResult = false;
            stForm.SetStartDateAdded("erroneous data");

            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);

            //do the same for end data of course form

            stForm.SetEndDateAdded("0000-00-00");

            //run the method under test
            actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        //checks for incorrect format of date
        public void CourseFormDateFormatTest()
        {
            //create instane to test
            CourseForm stForm = new CourseForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            stForm.SetStartDateAdded("19-08-19");

            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);

            //do the same for end data of course form

            stForm.SetEndDateAdded("0000-00-00");

            //run the method under test
            actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        //check learning aim for incorrect data
        public void CourseFormLearningAimErroenousData()
        {
            //create instane to test
            CourseForm stForm = new CourseForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            stForm.SetLearningAimAdded("1");

            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //check course level for incorrect data
        public void CourseFormCourseLevelErroenousData()
        {
            //create instane to test
            CourseForm stForm = new CourseForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            stForm.SetCourseLevelAdded("3");

            //run the method under test
            bool actualResult = stForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }

        //--------------Learning AIm Test---------------
        [TestMethod]
        //checks department id for incorrect data
        public void LearningAimDepIdErroenousData()
        {
            //create instance to test
            LearningAimForm laForm = new LearningAimForm(ref mainform, true);
            //define a test input and out put value

            bool expectedResult = false;
            laForm.SetAimDepAdded("4");

            //run the method
            bool actualResult = laForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        //check title for incorrect data
        public void LearningAimTitleErroenousData()
        {
            //create instance to test
            LearningAimForm laForm = new LearningAimForm(ref mainform, true);
            //define a test input and out put value

            bool expectedResult = false;
            laForm.SetAimTitleAdded("computing");

            //run the method
            bool actualResult = laForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        //check desc for incrrect data
        public void LearningAimDescErroenousData()
        {
            //create instance to test
            LearningAimForm laForm = new LearningAimForm(ref mainform, true);
            //define a test input and out put value

            bool expectedResult = false;
            laForm.SetAimTitleAdded("Erroenous data");

            //run the method
            bool actualResult = laForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);

        }

        //----------Job ROle TEST--------------------------------
        [TestMethod]
        //check staff id for incorrect data
        public void RoleStaffIdErroenousData()
        {
            //create instance to test
            JobRoleForm rForm = new JobRoleForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            rForm.SetRoleStaffIdAdded("6");

            //run the method
            bool actualResult = rForm.ValidateFields();
            //cechks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //check dep id for incorrect data
        public void RoleDepIdErroenousData()
        {
            //create instance to test
             JobRoleForm rForm = new JobRoleForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            rForm.SetRoleDepIdAdded("3");

            //run the method
            bool actualResult = rForm.ValidateFields();
            //cechks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //check job title for incorrect data
        public void RoleTitleErroenousData()
        {
            //create instance to test
            JobRoleForm rForm = new JobRoleForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            rForm.SetRoleTitleAdded("");

            //run the method
            bool actualResult = rForm.ValidateFields();
            //cechks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        //--------------Test FOr DEPARTMENT TABLE---------------------
        [TestMethod]
        //checks dep_name for incorrect data
        public void DepNameErroenousData()
        {
            //create instance to test
            DepartmentForm depForm = new DepartmentForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            depForm.SetDepNameAdded("computing");

            //run the method
            bool actualResult = depForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //checks phone no for incorrrect data
        public void DepPhoneNoErroenousData()
        {
            //create instance to test
            DepartmentForm depForm = new DepartmentForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            depForm.SetDepPhoneNoAdded("45698154262347");

            //run the method
            bool actualResult = depForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //checks email for incorrect data
        public void DepEmailErroenousData()
        {
            //create instance to test
            DepartmentForm depForm = new DepartmentForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            depForm.SetDepEmailAdded("computing@blackpool.ac.uk");

            //run the method
            bool actualResult = depForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //checks leadre for incorrect data
        public void DepLeaderErroenousData()
        {
            //create instance to test
            DepartmentForm depForm = new DepartmentForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            depForm.SetLeaderAdded("Matthew hall");

            //run the method
            bool actualResult = depForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }

        //---------------TESTING FOR USER ACCOUNTS
        [TestMethod]

        //checks user name for incorrect data
        public void UserNameErroenousData()
        {
            //create instance to test
            UserAccountForm uForm = new UserAccountForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            uForm.SetNameAdded("james");

            //runs the method
            bool actualresult = uForm.ValidateFields();
            //checks results 
            Assert.AreEqual(expectedResult, actualresult);
        }
        [TestMethod]

        //checks user password for incorrect data
        public void UserPasswordErroenousData()
        {
            //create instance to test
            UserAccountForm uForm = new UserAccountForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            uForm.SetPasswordAdded("hello");

            //runs the method
            bool actualresult = uForm.ValidateFields();
            //checks results 
            Assert.AreEqual(expectedResult, actualresult);
        }
        [TestMethod]

        //checks user access level for incorrect data
        public void UserAccessLevelErroenousData()
        {
            //create instance to test
            UserAccountForm uForm = new UserAccountForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            uForm.SetAccessLevelAdded("4");

            //runs the method
            bool actualResult = uForm.ValidateFields();
            //checks results 
            Assert.AreEqual(expectedResult, actualResult);
        }
        

        //----------NEXT OF KIN TESTS----------------#
        [TestMethod]
        //checks user id
        public void KinUserIdErroenousData()
        {
            //create instance to test
            NextOfKinForm kForm = new NextOfKinForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            kForm.SetUserIdAdded("3");

            //runs the method
            bool actualResult = kForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }

       [TestMethod]
        //checks first name
        public void KinFnameErroenousData()
        {
            //create instance to test
            NextOfKinForm kForm = new NextOfKinForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            kForm.SetFnameAdded("Mike");

            //runs the method
            bool actualResult = kForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //checks phone no
        public void KinPhoneNoErroenousData()
        {
            //create instance to test
            NextOfKinForm kForm = new NextOfKinForm(ref mainform, true);
            //define a test input and output value

            bool expectedResult = false;
            kForm.SetPhoneNoAdded("7598672976527");

            //runs the method
            bool actualResult = kForm.ValidateFields();
            //checks results
            Assert.AreEqual(expectedResult, actualResult);
        }
        //-------------Test for ADDRESS---------------
        [TestMethod]
        //check user id
        public void AddressUserIdErroenousData()
        {
            //create instance to test
            AddressForm aForm = new AddressForm(ref mainform, true);
            //define a test input and out put value 

            bool expectedResult = false;
            aForm.SetUserIdAdded("5");

            //runs the method
            bool actualResult = aForm.ValidateFields();
            //check results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //check  address line 1
        public void AddressLineOneErroenousData()
        {
            //create instance to test
            AddressForm aForm = new AddressForm(ref mainform, true);
            //define a test input and out put value 

            bool expectedResult = false;
            aForm.SetAddressLineOneAdded("mayor lane 44");

            //runs the method
            bool actualResult = aForm.ValidateFields();
            //check results
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //check  address line 2
        public void AddressLineTwoErroenousData()
        {
            //create instance to test
            AddressForm aForm = new AddressForm(ref mainform, true);
            //define a test input and out put value 

            bool expectedResult = false;
            aForm.SetAddressLineTwoAdded("mayor lane 44");

            //runs the method
            bool actualResult = aForm.ValidateFields();
            //check results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //check postcode
        public void AddressPostcodeErroenousData()
        {
            //create instance to test
            AddressForm aForm = new AddressForm(ref mainform, true);
            //define a test input and out put value 

            bool expectedResult = false;
            aForm.SetPostcodeAdded("FL5 5LH");

            //runs the method
            bool actualResult = aForm.ValidateFields();
            //check results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //check Town
        public void AddressTownErroenousData()
        {
            //create instance to test
            AddressForm aForm = new AddressForm(ref mainform, true);
            //define a test input and out put value 

            bool expectedResult = false;
            aForm.SetTownAdded("blackpool");

            //runs the method
            bool actualResult = aForm.ValidateFields();
            //check results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //check COUNTY
        public void AddressCountyErroenousData()
        {
            //create instance to test
            AddressForm aForm = new AddressForm(ref mainform, true);
            //define a test input and out put value 

            bool expectedResult = false;
            aForm.SetCountyAdded("Lanchasire");

            //runs the method
            bool actualResult = aForm.ValidateFields();
            //check results
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //check current address
        public void AddressCurrentAddressErroenousData()
        {
            //create instance to test
            AddressForm aForm = new AddressForm(ref mainform, true);
            //define a test input and out put value 

            bool expectedResult = false;
            aForm.SetCurrentAddressAdded("1");

            //runs the method
            bool actualResult = aForm.ValidateFields();
            //check results
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
    }
