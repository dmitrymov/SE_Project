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
            actual = target.GetAllSprintDays();
            CollectionAssert.AreEqual(expected, actual);
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }
        /*
        /// <summary>
        ///A test for update_work_hours
        ///</summary>
        [TestMethod()]
        public void update_work_hoursTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int Programmer_ID = 0; // TODO: Initialize to an appropriate value
            int hours = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.update_work_hours(Programmer_ID, hours);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
        */
        /// <summary>
        ///A test for update_day_status
        ///</summary>
        [TestMethod()]
        public void update_day_statusTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            DateTime day = DateTime.Parse("21.01.2013");
            actual = target.UpdateDayStatus(day, 1);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for get_sprint_passed_days
        ///</summary>
        [TestMethod()]
        public void get_sprint_passed_daysTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetSprintPassedDays();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for get_sprint_length
        ///</summary>
        [TestMethod()]
        public void get_sprint_lengthTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int expected = 3; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetSprintLengthWorkingDays();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for get_sprint_beggining_day
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WindowsFormsApplication13.exe")]
        public void get_sprint_beggining_dayTest()
        {
            DataManager_Accessor target = new DataManager_Accessor(); // TODO: Initialize to an appropriate value
            DateTime expected = DateTime.MinValue; // TODO: Initialize to an appropriate value
            DateTime actual;
            actual = target.get_sprint_beggining_day();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for get_remain_days
        ///</summary>
        [TestMethod()]
        public void get_remain_daysTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetSprintRemainDays();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for get_ending_day
        ///</summary>
        [TestMethod()]
        public void get_ending_dayTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            DateTime expected = DateTime.MinValue; // TODO: Initialize to an appropriate value
            DateTime actual;
            actual = target.GetSprintEndingDay();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for get_current_day
        ///</summary>
        [TestMethod()]
        public void get_current_dayTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            DateTime expected = DateTime.Today; // TODO: Initialize to an appropriate value
            DateTime actual;
            actual = target.GetCurrentDay();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for get_all_work_hours
        ///</summary>
        [TestMethod()]
        public void get_all_work_hoursTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetAllSprintWorkHours();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for get_all_remain_hours
        ///</summary>
        [TestMethod()]
        public void get_all_remain_hoursTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetAllSprintRemainHours();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for get_all_expected_hours
        ///</summary>
        [TestMethod()]
        public void get_all_sprint_expected_hoursTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int expected = 12; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetAllSprintExpectedHours();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

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

        /// <summary>
        ///A test for UpdateProgrammerExpectedWorkHours
        ///</summary>
        [TestMethod()]
        public void UpdateProgrammerExpectedWorkHoursTest()
        {
            DataManager target = new DataManager(); // TODO: Initialize to an appropriate value
            int programmerId = 0; // TODO: Initialize to an appropriate value
            int expectedHours = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.UpdateProgrammerExpectedWorkHours(programmerId, expectedHours);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateProgrammerName
        ///</summary>
        [TestMethod()]
        public void UpdateProgrammerNameTest()
        {
            int ID = 2; 
            string name = "AAA";
            int expected = 0;
            int actual;
            actual = DataManager.UpdateProgrammerName(ID, name);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
