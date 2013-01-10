using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication13
{
    class Report
    {

        public static void LogError(string exception)
        {
            if (!Directory.Exists(@"C:\Error Logs"))
            {
                Directory.CreateDirectory(@"C:\Error Logs");
            }

            using (StreamWriter sw = new StreamWriter(@"C:/Error Logs\Errors.txt",true))
            {
                sw.WriteLine(exception);
                sw.Close();
            }
        }
    }
}
