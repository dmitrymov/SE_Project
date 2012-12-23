using WindowsFormsApplication13;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for DataManagerTest and is intended
    ///to contain all DataManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DataManagerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        //////////////////////////////////  ok  ////////////////////////////////////
        /// <summary>
        ///A test for get_all_sprint_days
        ///</summary>
        [TestMethod()]
        public void get_all_sprint_daysTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            DateTime[] expected = new DateTime[4]; // TODO: Initialize to an appropriate value
            expected[0] = DateTime.Parse("01.12.2012");
            expected[1] = DateTime.Parse("02.12.2012");
            expected[2] = DateTime.Parse("03.12.2012");
            expected[3] = DateTime.Parse("20.01.2013");
            DateTime[] actual;
            actual = target.get_all_sprint_days();
            CollectionAssert.AreEqual(expected, actual);
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }
        


        /// <summary>
        ///A test for update_work_hours
        ///</summary>
        [TestMethod()]
        public void update_work_hoursTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int Programmer_ID = 1; // TODO: Initialize to an appropriate value
            int hours = 14; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.update_programmer_expected_work_hours(Programmer_ID, hours);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
        


        ///////////////////////////   ok    ///////////////////////////////////
        /// <summary>
        ///A test for update_day_status
        ///</summary>
        [TestMethod()]
        public void update_day_statusTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            DateTime day = DateTime.Parse("20.01.2013");
            actual = target.update_day_status(day, 1);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        
        ////////////// not comleted. need to be tested again   ///////////////////////////////////
        //////////////  returns passed days -1 (was checked early in the mornning)
        /// <summary>
        ///A test for get_sprint_all_passed_days
        ///</summary>
        [TestMethod()]
        public void get_sprint_passed_all_daysTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int expected = 17; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.get_sprint_passed_all_days();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        //////////////////////////////////   ok   //////////////////////////////////////////////////
        /// <summary>
        ///A test for get_sprint_length_working_daysTest
        ///</summary>
        [TestMethod()]
        public void get_sprint_length_working_daysTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int expected = 3; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetSprintLengthWorkingDays();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }


        /////////////////////////////////////////////   ok    ///////////////////////////////////////
        /// <summary>
        ///A test for get_sprint_beggining_day
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WindowsFormsApplication13.exe")]
        public void get_sprint_beggining_dayTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            DateTime expected = DateTime.Parse("01.12.2012"); // TODO: Initialize to an appropriate value
            DateTime actual;
            actual = target.get_sprint_beggining_day();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        ///////////////////////////////  ok   ///////////////////////////////////////
        /// <summary>
        ///A test for get_sprint_remain_days
        ///</summary>
        [TestMethod()]
        public void get_sprint_remain_daysTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int expected = 33; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.get_sprint_remain_days();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        ///////////////////////////   ok   ///////////////////////////////////////////////
        /// <summary>
        ///A test for get_ending_day
        ///</summary>
        [TestMethod()]
        public void get_ending_dayTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            DateTime expected = DateTime.Parse("20.01.2013"); ; // TODO: Initialize to an appropriate value
            DateTime actual;
            actual = target.get_sprint_ending_day();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        //////////////////////////////   ok     ///////////////////////
        /// <summary>
        ///A test for get_current_day
        ///</summary>
        [TestMethod()]
        public void get_current_dayTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            DateTime expected = DateTime.Today; // TODO: Initialize to an appropriate value
            DateTime actual;
            actual = target.get_current_day();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /////////////////////////////////////    ok      /////////////////////////////////////////
        /// <summary>
        ///A test for get_sprint_all_work_hours
        ///</summary>
        [TestMethod()]
        public void get_all_sprint_work_hoursTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int expected = 8; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.get_number_of_sprint_work_hours();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        //////////////////////////   ok   ///////////////////////////////////////////
        /// <summary>
        ///A test for get_sprint_all_remain_hours
        ///</summary>
        [TestMethod()]
        public void get_all_sprint_remain_hoursTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int expected = 4; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.get_all_sprint_remain_hours();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        ///////////////////////   ok    ////////////////////////////////////////////
        /// <summary>
        ///A test for get_all_expected_hours
        ///</summary>
        [TestMethod()]
        public void get_all_sprint_expected_hoursTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int expected = 12; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.get_all_sprint_expected_hours();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }


        ///////////////////////    ok      ///////////////////////////////////////////////////////
        /// <summary>
        ///A test for add_new_task
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WindowsFormsApplication13.exe")]
        public void add_new_taskTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
           // int ID = 0; // TODO: Initialize to an appropriate value
            int Task_Owner = 1; // TODO: Initialize to an appropriate value
            int Story_ID = 3; // TODO: Initialize to an appropriate value
            string Description = " "; // TODO: Initialize to an appropriate value
            int Priority = 2; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.add_new_task(Story_ID, Priority, Description, Task_Owner);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        ////////////////////////////////   ok    ///////////////////////////////////
        /// <summary>
        ///A test for add_new_day
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WindowsFormsApplication13.exe")]
        public void add_new_dayTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            DateTime day = DateTime.Today;
            int status = 1;
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.add_new_day(day, status);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }


        // its dificcult to insert image to DB
        /// <summary>
        ///A test for add_new_story
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WindowsFormsApplication13.exe")]
        public void add_new_storyTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
           // int ID = 0; // TODO: Initialize to an appropriate value
            int Story_Owner = 0; // TODO: Initialize to an appropriate value
            DateTime Current_Sprint = DateTime.Parse("01.12.2012");; // TODO: Initialize to an appropriate value
            int Work_Status = 0; // TODO: Initialize to an appropriate value
            int Priority = 0; // TODO: Initialize to an appropriate value
            string Description = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            string str = " ";
            Image pic = null;
            actual = target.add_new_story(Story_Owner, Current_Sprint, str, pic ,Description, Priority, Work_Status);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }


        /*
        /// <summary>
        ///A test for get_all_sprint_remain_hours
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WindowsFormsApplication13.exe")]
        public void get_all_sprint_remain_hoursTest()
        {
            DataManager_Accessor target = new DataManager_Accessor(); // TODO: Initialize to an appropriate value
            //DateTime day = DateTime.Today;
            //int status = 1;
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.get_all_sprint_remain_hours();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
        */

        /// <summary>
        ///A test for DataManager Constructor
        ///</summary>
        [TestMethod()]
        public void DataManagerConstructorTest()
        {
            DataManager target = new DataManager();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for update_programmer_name
        ///</summary>
        /*[TestMethod()]
        public void update_programmer_nameTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int ID = 2; // TODO: Initialize to an appropriate value
            string name = "ccc2"; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.update_programmer_name(ID, name);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }*/
    }
}
