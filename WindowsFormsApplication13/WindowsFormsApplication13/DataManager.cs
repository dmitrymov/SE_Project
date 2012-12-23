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

        public int GetMaximumTablesSize()
        {
            int ans = 0;
            if(GetSprintTableLength() > ans)
                ans = GetSprintTableLength();
            if (GetTaskTableLength() > ans)
                ans = GetTaskTableLength();
            if (GetStoryTableLength() > ans)
                ans = GetStoryTableLength();
            if (GetProgrammerTableLength() > ans)
                ans = GetProgrammerTableLength();
            if (GetWorkHoursTableLength() > ans)
                ans = GetWorkHoursTableLength();
            if (GetStoryInSprintTableLength() > ans)
                ans = GetStoryInSprintTableLength();
            return ans;
        }

        /*************************************************************************************************
         **************************  Sprint  ************************************************************
         */

        public int GetSprintTableLength()
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
            int ans;
            string str;
            SqlDataReader reader;
            str = "Select Count(*) From Sprint";
            SqlCommand command = new SqlCommand(str, conn);
            reader = command.ExecuteReader();
            reader.Read();
            ans = Convert.ToInt32(reader[0].ToString());
            reader.Close();
            conn.Close();
            return ans;
        }


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

        public int get_sprint_length_all_days()
        {
            int ans = (int)Math.Floor((get_sprint_ending_day() - get_sprint_beggining_day()).TotalDays);
            return ans;
        }

        // return date
        public DateTime get_sprint_beggining_day()
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
            string qStr = "SELECT Count(*) FROM Sprint";
            SqlCommand sqlCom = new SqlCommand(qStr, conn);
            SqlDataReader reader = sqlCom.ExecuteReader();
            DateTime end;
            while (reader.Read())
            {
                ans = reader.GetDateTime(0);
                end = reader.GetDateTime(1);
                if ((end - today_date).TotalDays > 0)   // if sprint end > current day then return ans
                {   

                    break;
                }
            }
            reader.Close();
            conn.Close();
            return ans;
        }


        // return array with sprint days that are in Date table
        // if day_d doesnt exist array[day_d] = -1
        // return null if exception
        public DateTime[] get_all_sprint_days()
        {
            int max_sprint_days = get_sprint_length_all_days();
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

        // return array of working days
        public DateTime[] get_all_sprint_working_days()
        {
            int max_sprint_days = GetSprintLengthWorkingDays();
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
            string qStr = "SELECT Date_Day FROM Date Where status = 1";
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
        public DateTime get_sprint_ending_day()
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
            string qStr = "SELECT Sprint_Finish_Day FROM Sprint Where Sprint_Beginning_Day = @date";
            SqlCommand sqlCom = new SqlCommand(qStr, conn);
            sqlCom.Parameters.AddWithValue("@date", begin);
            SqlDataReader reader = sqlCom.ExecuteReader();
            reader.Read();
            ending =  reader.GetDateTime(0);
            reader.Close();
            conn.Close();
            return ending;
        }

        // get number of days to sprint end
        // get ending day from sprint and get current day from date
        public int get_sprint_remain_days()
        {
            DateTime ending = get_sprint_ending_day();
            DateTime curr = get_current_day();
            if (ending == DateTime.MinValue || curr == DateTime.MinValue)
                return -1;
            int ans = (int) Math.Floor((ending - curr).TotalDays);    /// calculation
            return ans;
        }

        // dont sure that function is correct
        public int get_sprint_remain_working_days()
        {
            DateTime ending = get_sprint_ending_day();
            DateTime curr = get_current_day();
            if (ending == DateTime.MinValue || curr == DateTime.MinValue)
                return -1;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return -1;
            }
            int ans;
            
            string qStr = "SELECT Count(*) FROM Date where Date_Day > @curr_day and Date_Day_status = 1";
            SqlCommand sqlCom = new SqlCommand(qStr, conn);
            sqlCom.Parameters.AddWithValue("@curr_day", curr);
            try
            {
                ans = sqlCom.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            conn.Close();
            //int ans = (int)Math.Floor((ending - curr).TotalDays);    /// calculation
            return ans;
        }


        // return number of days passed from sprint beginnig
        public int get_sprint_passed_all_days()
        {
            int len = get_sprint_length_all_days();
            int rem = get_sprint_remain_days();
            int ans = len - rem;
            return ans;
        }


        // return number of days passed from sprint beginnig
        public int get_sprint_passed_working_days()
        {
            int ans = GetSprintLengthWorkingDays() - get_sprint_remain_working_days();
            return ans;
        }

        // retun number of done hours
        public int get_number_of_sprint_work_hours()
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
                ans += Convert.ToInt32(reader[0].ToString());
                //ans += reader.GetInt32(0);
            }
            conn.Close();
            return ans;
        }


        // return hours to finish sprint
        public int get_all_sprint_remain_hours()
        {
            int all_hours = get_all_sprint_expected_hours();
            int worked_hours = get_number_of_sprint_work_hours();
            if (all_hours == -1 || worked_hours == -1)
                return -1;
            return all_hours - worked_hours;     // all - current
        }


        // get expected work hours in sprint
        public int get_all_sprint_expected_hours()
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
        public int add_new_sprint(DateTime start, DateTime end)
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

        // return number of stoies (size of sprint table)
        public int GetStoryTableLength()
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
            string str = "Select Count(*) From Story";
            SqlCommand command = new SqlCommand(str, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int ans = Convert.ToInt32(reader[0].ToString());
            conn.Close();
            return ans;
        }

        public int add_new_story(int Story_Owner, DateTime Current_Sprint, string Story_Demo_DES, Image Story_Demo_PIC, string Story_Description, int Story_Priority, int Story_Work_Status)
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
            string str = "Insert Into Story (Story_Owner, Story_Current_Sprint, Story_Demo_DES, Story_Demo_PIC, Story_Description, Story_Priority, Story_Work_Status) values (" + Story_Owner + ", @date, '" + Story_Demo_DES + "'," +null /* Story_Demo_PIC*/ + ", '" + Story_Description + "', " + Story_Priority + ", " + Story_Work_Status + ")";
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

        public int GetStoryOwnerID(int story_ID)
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
            string str = "Select Story_Owner From Story Where Story_ID = " + story_ID;
            SqlCommand command = new SqlCommand(str, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int ans = Convert.ToInt32(reader[0].ToString());
            conn.Close();
            return ans;
        }

        public int SetStoryOwnerID(int story_ID, int old_ID, int new_ID)
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
            //string str = "Insert Into Story(Story_Owner) values(" + new_ID + ") Where Story_ID = " + old_ID;
            string str = "Update Story Set Story_Owner=" + new_ID + " Where Story_ID = " + old_ID;
            SqlCommand command = new SqlCommand(str, conn);
            try
            {
                command.ExecuteNonQuery();
            }
            catch(Exception)
            {
                return -1;
            }
            conn.Close();
            return 0;
        }

        public DateTime GetStory_Current_Sprint()
        {
            return get_sprint_beggining_day();
        }

        public int SetStoryCurrentSprint(int story_ID, DateTime day)
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
            //string str = "Insert Into Story(Story_Current_Sprint) values(@day) Where Story_ID = " + story_ID;
            string str = "Update Story Set Story_Current_Sprint=@day Where Story_ID = " + story_ID;
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@day", day);
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

        public string GetStoryDemoDES(int story_ID)
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
            string str = "Select Story_Demo_DES From Story Where Story_ID = " + story_ID;
            SqlCommand command = new SqlCommand(str, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string ans = reader[0].ToString();
            conn.Close();
            return ans;
        }

        public int SetStoryDemoDES(int story_ID, string des)
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
            //string str = "Insert Into Story(Story_Demo_DES) values('" + des + "') Where Story_ID = " + story_ID;
            string str = "Update Story Set Story_Demo_DES='" + des + "' Where Story_ID = " + story_ID;
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

        public string GetStoryDemoPIC()
        {
            return null;
        }

        public int SetStoryDemoPIC()
        {
            return 0;
        }


        public string GetStoryDescription(int story_ID)
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
            string str = "Select Story_Description From Story Where Story_ID = " + story_ID;
            SqlCommand command = new SqlCommand(str, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string ans = reader[0].ToString();
            conn.Close();
            return ans;
        }

        public int SetStoryDescription(int story_ID, string des)
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
            //string str = "Insert Into Story(Story_Description) values('" + des + "') Where Story_ID = " + story_ID;
            string str = "Update Story Set Story_Description='" + des + "' Where Story_ID = " + story_ID;
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

        public int GetStoryPriority(int story_ID)
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
            string str = "Select Story_Priority From Story Where Story_ID = " + story_ID;
            SqlCommand command = new SqlCommand(str, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int ans = Convert.ToInt32(reader[0].ToString());
            conn.Close();
            return ans;
        }

        public int SetStoryPriority(int story_ID, int priority)
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
            //string str = "Insert Into Story(Story_Description) values(" + priority + ") Where Story_ID = " + story_ID;
            string str = "Update Story Set Story_Description=" + priority + " Where Story_ID = " + story_ID;
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

        public int SetStoryWorkStatus(int story_ID, int status)
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
            //string str = "Insert Into Story (Story_Work_Status) values(" + status + ") Where Story_ID = " + story_ID;
            string str = "Update Story Set Story_Work_Status=" + status + " Where Story_ID = " + story_ID;
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

        public int GetStoryWorkStatus(int story_ID)
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
            string str = "Select Story_Work_Status From Story Where Story_ID = " + story_ID;
            SqlCommand command = new SqlCommand(str, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int ans = Convert.ToInt32(reader[0].ToString());
            conn.Close();
            return ans;
        }

        public int[] GetStoriesIDForStoryOwner(int OwnerID)
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
            string str = "Select Story_ID From Story Where Story_Owner = " + OwnerID;
            SqlCommand command = new SqlCommand(str, conn);
            SqlDataReader reader = command.ExecuteReader();
            int[] ans = new int[GetStoryTableLength()];
            int i = 0;
            while (reader.Read() && i < GetStoryTableLength())
            {
                ans[i] = Convert.ToInt32(reader[0].ToString());
            }
            conn.Close();
            return ans;
        }
        

        /*************************************************************************************************
         **************************  Task  ************************************************************
         */

        public int GetTaskTableLength()
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
            int ans;
            string str;
            SqlDataReader reader;
            str = "Select Count(*) From Task";
            SqlCommand command = new SqlCommand(str, conn);
            reader = command.ExecuteReader();
            reader.Read();
            ans = Convert.ToInt32(reader[0].ToString());
            reader.Close();
            conn.Close();
            return ans;
        }

        // if not succeed return -1
        public int add_new_task(int Task_Story_ID, int Task_Priority, string Task_Description, int Task_Owner)
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

        public int SetTaskStoryID(int task_ID, int story_ID)
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
            //string str = "Insert Into Task (Task_Story_ID) values(" + story_ID + ") Where Task_ID = " + task_ID;
            string str = "Update Task Task_Story_ID=" + story_ID + " Where Task_ID = " + task_ID;
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

        public int GetTaskStoryID(int task_ID)
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
            string str = "Select Task_Story_ID From Task Where Task_ID = " + task_ID;
            SqlCommand command = new SqlCommand(str, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int ans = Convert.ToInt32(reader[0].ToString());
            conn.Close();
            return ans;
        }

        public int SetTaskPriority(int task_ID, int priority)
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
            //string str = "Insert Into Task (Task_Priority) values(" + priority + ") Where Task_ID = " + task_ID;
            string str = "Update Task Set Task_Priority=" + priority + " Where Task_ID = " + task_ID;
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

        public int GetTaskPriority(int task_ID)
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
            string str = "Select Task_Priority From Task Where Task_ID = " + task_ID;
            SqlCommand command = new SqlCommand(str, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int ans = Convert.ToInt32(reader[0].ToString());
            conn.Close();
            return ans;
        }

        public int SetTaskDescription(int task_ID, string description)
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
            //string str = "Insert Into Task (Task_Description) values('" + description + "') Where Task_ID = " + task_ID;
            string str = "Update Task Set Task_Description='" + description + "' Where Task_ID = " + task_ID;
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

        public string GetTaskDescription(int task_ID)
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
            string str = "Select Task_Description From Task Where Task_ID = " + task_ID;
            SqlCommand command = new SqlCommand(str, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string ans = reader[0].ToString();
            conn.Close();
            return ans;
        }

        public int SetTaskOwner(int task_ID, int owner_ID)
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
            //string str = "Insert Into Task (Task_Ovner) values(" + owner_ID + ") Where Task_ID = " + task_ID;
            string str = "Update Task Set Task_Ovner=" + owner_ID + " Where Task_ID = " + task_ID;
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

        public int GetTaskOwner(int task_ID)
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
            string str = "Select Task_Ovner From Task Where Task_ID = " + task_ID;
            SqlCommand command = new SqlCommand(str, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int ans = Convert.ToInt32(reader[0].ToString());
            conn.Close();
            return ans;
        }

        
        /*************************************************************************************************
         **************************  Programmer  ************************************************************
         */

        public int GetProgrammerTableLength()
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
            int ans;
            string str;
            SqlDataReader reader;
            str = "Select Count(*) From Programmer";
            SqlCommand command = new SqlCommand(str, conn);
            reader = command.ExecuteReader();
            reader.Read();
            ans = Convert.ToInt32(reader[0].ToString());
            reader.Close();
            conn.Close();
            return ans;
        }


        // add new programmer to Programmer table
        int add_new_programmer(int ID, string Programmer_Name, int Programmer_Expected_Work_Hours, int Programmer_Current_Work_Hours)
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
        private int add_programmer_work_hours(int Programmer_ID, int hours)
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
        public int update_programmer_expected_work_hours(int Programmer_ID, int expected_hours)
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
            //string str = "Insert Into Programmer (Programmer_Expected_Work_Hours) values ( " + expected_hours + ") Where Programmer_id = " + Programmer_ID;
            string str = "Update Programmer Set Programmer_Expected_Work_Hours=" + expected_hours + " Where Programmer_id = " + Programmer_ID;
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

        // adds to expected work hours of programmer to what gets
        public int add_programmer_expected_work_hours(int Programmer_ID, int hours)
        {
            int expct = get_programmer_expected_work_hours(Programmer_ID);
            if (expct == -1)
                return -1;
            expct += hours;
            update_programmer_expected_work_hours(Programmer_ID, expct);
            return 0;
        }


        // change programmer name
        internal static int update_programmer_name(int ID, string name)
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
            //string str = "Insert Into Programmer (Programmer_Name) values( '" + name + "') Where Programmer_id = " + ID;
            string str = "Update Programmer Set Programmer_Name='" + name + "' Where Programmer_id = " + ID;
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

        // get programmer current work hours
        public int get_programmer_current_work_hours(int ID)
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
        public int get_programmer_expected_work_hours(int ID)
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
        public string get_programmer_name(int ID)
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

        public int get_programmer_table_length()
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
            string str = "Select Count(*) From Programmer";
            SqlCommand command = new SqlCommand(str, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int ans = Convert.ToInt32(reader[0].ToString());
            conn.Close();
            return ans;
        }

        // return all programmers id that have such Name
        public int[] get_programmer_ID_by_name(string name)
        {
            int max_pr_tbl_len = get_programmer_table_length();
            int[] ans = new int[max_pr_tbl_len];
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return null;
            }
            string str = "Select Programmer_id From Programmer Where Programmer_Name like('" + name + "')";
            SqlCommand command = new SqlCommand(str, conn);
            SqlDataReader reader = command.ExecuteReader();
            int id;
            int i = 0;
            while (reader.Read() && i < max_pr_tbl_len)
            {
                id = Convert.ToInt32(reader[0].ToString());
                ans[i] = id;
                i++;
            }
            // ans = reader(0).toString();
            conn.Close();
            return ans;
        }
        

        /*************************************************************************************************
         **************************  Date  ************************************************************
         */

        public int GetDateTableLength()
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
            int ans;
            string str;
            SqlDataReader reader;
            str = "Select Count(*) From Date";
            SqlCommand command = new SqlCommand(str, conn);
            reader = command.ExecuteReader();
            reader.Read();
            ans = Convert.ToInt32(reader[0].ToString());
            reader.Close();
            conn.Close();
            return ans;
        }

        // gets current day from system
        public DateTime get_current_day()
        {
            DateTime curr = DateTime.Today;
            return curr;
        }

        // return day status(int) or -1 if error
        public int get_day_status(DateTime day)
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
        public int update_day_status(DateTime up_day, int status)
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
            //string day_to_up = up_day.ToString();
            //str = "Insert Into Date (Date_Day_status) values( "+ status + ") Where Date_Day = @date";
            str = "Update Date Set Date_Day_status=" + status + " Where Date_Day = @date";
            command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@date", up_day); // need to be checked
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

        // add new day, gets day
        public int add_new_day(DateTime day)
        {
            int status = 0;
            // check status
            add_new_day(day, status);
            return 0;
        }

        // add new day, gets day and status
        public int add_new_day(DateTime day, int status)
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
            catch (Exception)
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

        public int GetWorkHoursTableLength()
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
            int ans;
            string str;
            SqlDataReader reader;
            str = "Select Count(*) From Work_hours";
            SqlCommand command = new SqlCommand(str, conn);
            reader = command.ExecuteReader();
            reader.Read();
            ans = Convert.ToInt32(reader[0].ToString());
            reader.Close();
            conn.Close();
            return ans;
        }

        public float get_programmer_work_hours_for_today(int P_ID)
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
            DateTime day = DateTime.Today;
            float ans = -1;
            string str;
            SqlDataReader reader;
            str = "Select Work_hours_Work_hours From Work_hours Where Work_hours_Programmer_id = " + P_ID + " and Work_hours__Date_Day = @day";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@date", day);
            reader = command.ExecuteReader();
            if(reader.Read())   // if there is data to read
                ans = (float) Convert.ToDouble(reader[0].ToString());
            reader.Close();
            conn.Close();
            return ans;
        }


        public float get_programmer_work_hours_for_day(int P_ID, DateTime day)
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
            //DateTime day = DateTime.Today;
            float ans = -1;
            string str;
            SqlDataReader reader;
            str = "Select Work_hours_Work_hours From Work_hours Where Work_hours_Programmer_id = " + P_ID + " and Work_hours__Date_Day = @day";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@date", day);
            reader = command.ExecuteReader();
            if (reader.Read())   // if there is data to read
                ans = (float)Convert.ToDouble(reader[0].ToString());
            reader.Close();
            conn.Close();
            return ans;
        }

        public int set_programmer_work_hours_for_today(int P_ID, float hours)
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
            DateTime day = DateTime.Today;
            //string str = "Insert Into Work_hours (Work_hours_Work_hours) values (" + hours + ") Where Work_hours_Programmer_id = "+ P_ID +" and Work_hours__Date_Day = @day";
            string str = "Update Work_hours Set Work_hours_Work_hours=" + hours + " Where Work_hours_Programmer_id = " + P_ID + " and Work_hours__Date_Day = @day";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@date", day);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //MessageBox.Show(""+ex);
                return -1;
            }
            conn.Close();
            return 0;
        }

        
        public int set_programmer_work_hours_for_day(int P_ID, float hours, DateTime day)
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
            //string str = "Insert Into Work_hours (Work_hours_Work_hours) values (" + hours + ") Where Work_hours_Programmer_id = " + P_ID + " and Work_hours__Date_Day = @day";
            string str = "Update Work_hours Set Work_hours_Work_hours=" + hours + " Where Work_hours_Programmer_id = " + P_ID + " and Work_hours__Date_Day = @day";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@date", day);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //MessageBox.Show(""+ex);
                return -1;
            }
            conn.Close();
            return 0;
        }

        public int add_programmer_work_hours_for_today(int P_ID, float hours)
        {
           // DateTime day = DateTime.Today;
            float get_h = get_programmer_work_hours_for_today(P_ID);
            if (get_h == -1)
                return -1;
            float ans = get_h + hours;
            set_programmer_work_hours_for_today(P_ID, ans);
            return 0;
        }

        public int add_programmer_work_hours_for_day(int P_ID, float hours, DateTime day)
        {
            float get_h = get_programmer_work_hours_for_day(P_ID, day);
            if (get_h == -1)
                return -1;
            float ans = get_h + hours;
            set_programmer_work_hours_for_day(P_ID, ans, day);
            return 0;
        }

        public float get_programmer_work_hours_all(int P_ID)
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
            //DateTime day = DateTime.Today;
            float ans = 0;
            int flag = -1;
            string str;
            SqlDataReader reader;
            str = "Select Work_hours_Work_hours From Work_hours Where Work_hours_Programmer_id = " + P_ID;
            SqlCommand command = new SqlCommand(str, conn);
            reader = command.ExecuteReader();
            while (reader.Read())   // if there is data to read
            {
                flag = 0;
                ans += (float)Convert.ToDouble(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
            if (flag == -1)
                return -1;
            return ans;
        }


        public float get_all_work_hours_for_today()
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
            DateTime day = DateTime.Today;
            float ans = 0;
            int flag = -1;
            string str;
            SqlDataReader reader;
            str = "Select Work_hours_Work_hours From Work_hours Where Work_hours__Date_Day = @date";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@date", day);
            reader = command.ExecuteReader();
            while (reader.Read())   // if there is data to read
            {
                flag = 0;
                ans += (float)Convert.ToDouble(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
            if (flag == -1)
                return -1;
            return ans;
        }

        public float get_all_work_hours_for_day(DateTime day)
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
            float ans = 0;
            int flag = -1;
            string str;
            SqlDataReader reader;
            str = "Select Work_hours_Work_hours From Work_hours Where Work_hours__Date_Day = @date";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@date", day);
            reader = command.ExecuteReader();
            while (reader.Read())   // if there is data to read
            {
                flag = 0;
                ans += (float)Convert.ToDouble(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
            if (flag == -1)
                return -1;
            return ans;
        }



        /*************************************************************************************************
        **************************  Story In Sprint  ************************************************************
        */

        public int GetStoryInSprintTableLength()
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
            int ans;
            string str;
            SqlDataReader reader;
            str = "Select Count(*) From Story_In_Sprint";
            SqlCommand command = new SqlCommand(str, conn);
            reader = command.ExecuteReader();
            reader.Read();
            ans = Convert.ToInt32(reader[0].ToString());
            reader.Close();
            conn.Close();
            return ans;
        }

        public int AddNewStoryInSprint(int storyID, DateTime sprint_day)
        {
            // check if valid storyID and sprint_day
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return -1;
            }
            string str = "Insert Into Story_In_Sprint values ("+storyID+", @day)";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@day", sprint_day);
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

        public int TransferStoryToOtherSprint(int story_ID, DateTime day)
        {
            // check if day is sprint beggining day
            // delete row from database where story_ID && day
            // add new storyinsprint
            return 0;
        }

    }
}