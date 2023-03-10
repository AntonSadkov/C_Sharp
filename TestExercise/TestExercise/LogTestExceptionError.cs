using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Reflection;

namespace TestExercise
{
    public class LogTestExceptionError
    {
        private static object sync = new object();
        public static void Write(Exception ex)
        {

            // Описание пути
            string pathToLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
            if (!Directory.Exists(pathToLog))
                Directory.CreateDirectory(pathToLog);

            //Описание формата
            string filename = Path.Combine(pathToLog, string.Format("{0}_{1:dd.MM.yyy}.log",
            AppDomain.CurrentDomain.FriendlyName, DateTime.Now));

            //Записываемое содержимое
            string fullText = string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] [{1}.{2}()] {3}\r\n",
            DateTime.Now,
            ex.TargetSite.DeclaringType,
            ex.TargetSite.Name,
            ex.Message);
            lock (sync)
            {
                File.AppendAllText(filename, fullText);
            }
        }
    }
}
