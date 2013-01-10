using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public class DataManager
    {
        // string connection to Database
        static string CONNECTION_STRING = Settings1.Default.connection_string; //@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\NATAN\Desktop\WindowsFormsApplication13\WindowsFormsApplication13\WindowsFormsApplication13\Database1.mdf;Integrated Security=True;User Instance=True";


        /*************************************************************************************************
         **************************  General  ************************************************************
         */


        /*************************************************************************************************
         **************************  Sprint  ************************************************************
         */



        // return Sprint length in days
        // if error return -1
        public int GetSprintLengthWorkingDays()
        {
            int ans = -1;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return ans;
            }
            string qStr = "SELECT Count(*) FROM Date Where Date_Day_status = 1";
            SqlCommand sqlCom = new SqlCommand(qStr, conn);
            SqlDataReader reader = sqlCom.ExecuteReader();
            reader.Read();
            ans = reader.GetInt32(0);
            conn.Close();
            return ans;
        }

        public int GetSprintLengthAllDays()
        {
            int ans = -1;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return ans;
            }
            string qStr = "SELECT Count(*) FROM Date";
            SqlCommand sqlCom = new SqlCommand(qStr, conn);
            SqlDataReader reader = sqlCom.ExecuteReader();
            reader.Read();
            ans = reader.GetInt32(0);
            conn.Close();
            return ans;
        }

        // return date
        private DateTime get_sprint_beggining_day()
        {
            DateTime ans = DateTime.MinValue;
            DateTime today_date = DateTime.Today;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return ans;
            }
            string qStr = "SELECT Sprint_Beginning_Day FROM Sprint";
            SqlCommand sqlCom = new SqlCommand(qStr, conn);
            SqlDataReader reader = sqlCom.ExecuteReader();
            while (reader.Read())
            {
                ans = reader.GetDateTime(0);
                if ((ans - today_date).TotalDays > 0)   // when difference more than 0 that meens it is a current sprint
                    break;
            }
            reader.Close();
            conn.Close();
            return ans;
        }


        // return array with sprint days
        // if day_d doesnt exist array[day_d] = -1
        // return null if exception
        public DateTime[] GetAllSprintDays()
        {
            int max_sprint_days = GetSprintLengthAllDays();
            DateTime[] ans = new DateTime[max_sprint_days];
            int i = 0;
            for (; i < max_sprint_days; i++)
            {
                ans[i] = DateTime.MinValue;    // no day
            }
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return null;
            }
            string qStr = "SELECT Date_Day FROM Date";
            SqlCommand sqlCom = new SqlCommand(qStr, conn);
            SqlDataReader reader = sqlCom.ExecuteReader();
            i = 0;
            while (reader.Read() && i < max_sprint_days)
            {
                ans[i] = reader.GetDateTime(0);
                i++;
            }
            reader.Close();
            conn.Close();
            return ans;
        }

        // return last day of sprint
        // return null if error
        public DateTime GetSprintEndingDay()
        {
            DateTime ending = DateTime.MinValue;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return ending;
            }
            DateTime begin = get_sprint_beggining_day();
            string qStr = "SELECT Sprint_Finish_Day FROM Sprint Where Sprint_Beginning_Day = " + begin.ToString();
            SqlCommand sqlCom = new SqlCommand(qStr, conn);
            SqlDataReader reader = sqlCom.ExecuteReader();
            reader.Read();
            ending =  reader.GetDateTime(0);
            reader.Close();
            conn.Close();
            return ending;
        }

        // get number of days to sprint end
        // get ending day from sprint and get current day from date
        public int GetSprintRemainDays()
        {
            DateTime ending = GetSprintEndingDay();
            DateTime curr = GetCurrentDay();
            if (ending == DateTime.MinValue || curr == DateTime.MinValue)
                return -1;
            int ans = (int) Math.Floor((ending - curr).TotalDays);    /// calculation
            return ans;
        }



        // return number of days passed from sprint beginnig
        public int GetSprintPassedDays()
        {
            /*
            DateTime ending = get_sprint_ending_day();
            DateTime curr = get_current_day();
            if (ending == DateTime.MinValue || curr == DateTime.MinValue)
                return -1;
            */
            int ans = GetSprintLengthWorkingDays() - GetSprintRemainDays();
            return ans;
        }

        // retun number of done hours
        public int GetAllSprintWorkHours()
        {
            int ans = 0;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return -1;
            }
            string qStr = "SELECT Programmer_Current_Work_Hours FROM Programmer";
            SqlCommand sqlCom = new SqlCommand(qStr, conn);
            SqlDataReader reader = sqlCom.ExecuteReader();
            //int[] answer;
            while (reader.Read())
            {
                //ans += Convert.ToInt32(reader[0].ToString());
                ans += reader.GetInt32(0);
            }
            conn.Close();
            return ans;
        }


        // return hours to finish sprint
        public int GetAllSprintRemainHours()
        {
            int all_hours = GetAllSprintExpectedHours();
            int worked_hours = GetAllSprintWorkHours();
            if (all_hours == -1 || worked_hours == -1)
                return -1;
            return all_hours - worked_hours;     // all - current
        }


        // get expected work hours in sprint
        public int GetAllSprintExpectedHours()
        {
            int ans = 0;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return -1;
            }
            // how to differ between the sprints?
            // every time each programmer must be set to other expct_w_hours
            string qStr = "SELECT Programmer_Expected_Work_Hours FROM Programmer";
            SqlCommand sqlCom = new SqlCommand(qStr, conn);
            SqlDataReader reader = sqlCom.ExecuteReader();
            //int[] answer;
            while (reader.Read())
            {
                ans += Convert.ToInt32(reader[0].ToString());
                //ans += reader.GetInt32(0);
            }
            conn.Close();
            return ans;
        }

        // add new Sprint
        public int AddNewSprint(DateTime start, DateTime end)
        {
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return -1;
            }
            string s_start = start.ToString();
            string s_end = end.ToString();
            string str = "Insert Into Sprint (Sprint_Beginning_Day, Sprint_Finish_Day) values ('" + s_start + "', '" + s_end + "')";
            SqlCommand command = new SqlCommand(str, conn);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            conn.Close();
            return 0;
        }


        /*************************************************************************************************
         **************************  Story  ************************************************************
         */

        int AddNewStory(int Story_Owner, DateTime Current_Sprint, string Story_Demo_DES, Image Story_Demo_PIC, string Story_Description, int Story_Priority, int Story_Work_Status)
        {
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return -1;
            }
            string curr_sprint_date = Current_Sprint.ToString();
            // how to insert image to table ??????????????????????????????????
            string str = "Insert Into Story (Story_Owner, Story_Current_Sprint, Story_Demo_DES, Story_Demo_PIC, Story_Description, Story_Priority, Story_Work_Status) values (" + Story_Owner + ", @date, '" + Story_Demo_DES + "'," + Story_Demo_PIC + ", '" + Story_Description + "', " + Story_Priority + ", " + Story_Work_Status + ")";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@date", curr_sprint_date);
            //command.Parameters.AddWithValue("@picture", Story_Demo_PIC); // need to be checked
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return -1;
            }
            conn.Close();
            return 0;
        }

        /*************************************************************************************************
         **************************  Task  ************************************************************
         */

        // if not succeed return -1
        int AddNewTask(int Task_Story_ID, int Task_Priority, string Task_Description, int Task_Owner)
        {
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return -1;
            }
            string str = "Insert into Task (Task_Story_ID, Task_Priority, Task_Description, Task_Ovner_Id) values (" + Task_Story_ID + ", " + Task_Priority + ", '" + Task_Description + "', " + Task_Owner + ")";
            SqlCommand command = new SqlCommand(str, conn);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return -1;
            }
            conn.Close();
            return 0;
        }

        /*************************************************************************************************
         **************************  Programmer  ************************************************************
         */

        // add new programmer to Programmer table
        int AddNewProgrammer(int ID, string Programmer_Name, int Programmer_Expected_Work_Hours, int Programmer_Current_Work_Hours)
        {
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return -1;
            }
            string str = "Insert Into Programmer (Programmer_id, Programmer_Name, Programmer_Expected_Work_Hours, Programmer_Current_Work_Hours) values (" + ID + ", '" + Programmer_Name + "', " + Programmer_Expected_Work_Hours + ", " + Programmer_Current_Work_Hours + ")";
            SqlCommand command = new SqlCommand(str, conn);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            conn.Close();
            return 0;
        }


        // this function is private because only Work_hours table must use it
        // gets Programmer_ID and work hours for current day
        // add hours to total Programmer_Current_Work_Hours
        private int AddProgrammerWorkHours(int Programmer_ID, int hours)
        {
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return -1;
            }
            int curr_hours;
            string str;
            SqlDataReader reader;
            str = "Select Programmer_Current_Work_Hours from Programmer Where Programmer_id = " + Programmer_ID;
            SqlCommand command = new SqlCommand(str, conn);
            reader = command.ExecuteReader();
            reader.Read();
            //curr_hours = Convert.ToInt32(reader[0].ToString()); // get current hours from programmer == ID
            curr_hours = reader.GetInt32(0);
            curr_hours += hours;
            reader.Close();
            str = "Update Programmer Set Programmer_Current_Work_Hours = " + curr_hours + " Where Programmer_id = " + Programmer_ID;
            command = new SqlCommand(str, conn);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            conn.Close();
            return 0;
        }

        // change expected work hours of programmer to what it gets
        public int UpdateProgrammerExpectedWorkHours(int programmerId, int expectedHours)
        {
            // connect to the DB
            var conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                // write to Log file the exeption to debug
                Report.LogError(ex.ToString());
                Report.LogError("Error: DataManager update_programmer_expected_work_hours - Cannot connect to DB");
                return -1;
            }

            // SQL command
            string str = "Update Programmer Set Programmer_Expected_Work_Hours = " + expectedHours + " Where Programmer_id = " + programmerId;

            // execute command
            var command = new SqlCommand(str, conn);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // write to Log file the exeption to debug
                Report.LogError(ex.ToString());
                Report.LogError("Error: DataManager update_programmer_expected_work_hours- cannot Execute the Query");
                return -1;
            }

            // close connection
            conn.Close();

            return 0;
        }


        // change programmer name
        internal static int UpdateProgrammerName(int ID, string name)
        {
            // connect to the DB
            var conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                // write to Log file the exeption to debug
                Report.LogError(ex.ToString());
                Report.LogError("Error: DataManager UpdateProgrammerName- Cannot connect to DB");
                return -1;
            }

            // SQL command
            string strInsert = "INSERT INTO Programmer (Programmer_Name) VALUES ('" + name + "')";

            // execute command
            var command = new SqlCommand(strInsert, conn);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // write to Log file the exeption to debug
                Report.LogError(ex.ToString());
                Report.LogError("Error: DataManager UpdateProgrammerName- Cannot Execute the Query");
                return -1;
            }

            conn.Close();
            return 0;
        }

        // get programmer current work hours
        public int GetProgrammerCurrentWorkHours(int ID)
        {
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return -1;
            }
            string str = "Select Programmer_Current_Work_Hours From Programmer Where Programmer_id = " + ID;
            SqlCommand command = new SqlCommand(str, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int ans = reader.GetInt32(0);
            conn.Close();
            return ans;
        }

        // get programmer expected work hours
        public int GetProgrammerExpectedWorkHours(int ID)
        {
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return -1;
            }
            string str = "Select Programmer_Expected_Work_Hours From Programmer Where Programmer_id = " + ID;
            SqlCommand command = new SqlCommand(str, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int ans = reader.GetInt32(0);
            conn.Close();
            return ans;
        }

        // get programmer name
        public string GetProgrammerName(int ID)
        {
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return null;
            }
            string str = "Select Programmer_Name From Programmer Where Programmer_id = " + ID;
            SqlCommand command = new SqlCommand(str, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string ans = reader.GetString(0);
            // ans = reader(0).toString();
            conn.Close();
            return ans;
        }

        // get programmer(s) ID by Name ???
        

        /*************************************************************************************************
         **************************  Date  ************************************************************
         */

        // gets current day from system
        public DateTime GetCurrentDay()
        {
            DateTime curr = DateTime.Today;
            return curr;
        }

        // return day status(int) or -1 if error
        public int GetDayStatus(DateTime day)
        {
            int ans = -1;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return ans;
            }
            string today_day = day.ToString();
            string qStr = "SELECT Date_Day_status FROM Date Where Date_Day = '" + today_day + "'";
            SqlCommand sqlCom = new SqlCommand(qStr, conn);
            SqlDataReader reader = sqlCom.ExecuteReader();
            //ans = Convert.ToInt32(reader[0].ToString());
            ans = reader.GetInt32(0);
            conn.Close();
            return ans;
        }

        // this function must update day status to parametr(status)
        public int UpdateDayStatus(DateTime up_day, int status)
        {
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            SqlCommand command;
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return -1;
            }
            string str;
            string day_to_up = up_day.ToString();
            str = "Update Date Set Date_Day_status = "+ status +" Where Date_Day = @date";
            command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@date", day_to_up); // need to be checked
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            conn.Close();
            return 0;
        }

        // add new day, gets day
        public int AddNewDay(DateTime day)
        {
            int status = 0;
            // check status
            AddNewDay(day, status);
            return 0;
        }

        // add new day, gets day and status
        public int AddNewDay(DateTime day, int status)
        {

            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return -1;
            }
            //string s_day = day.ToString();
            string str = "Insert Into Date (Date_Day_status, Date_Day) values (" + status + ", @date)";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@date", day);// pizdec ia ebal etot sql, otkuda ia znaiu c#???
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(""+ex);
                return -1;
            }
            conn.Close();
            return 0;
        }
        /*************************************************************************************************
         **************************  Work hours  ************************************************************
         */
    }
}