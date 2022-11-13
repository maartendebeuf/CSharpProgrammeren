using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView._3.AdvancedDotNet.Error_handling
{
    internal class CustomFileLog
    {
        const string _logPath = @"C:\Users\Maarten De Beuf\GitHub\MD_CSharpProgrammeren\CSharp1-22-23\2.Exeptions\OefeningenLes3\Logging";

        public static void AddErrorLog(string? message)
        {
            //Create directory if it does not exists
            Directory.CreateDirectory(_logPath);
            File.AppendAllText(_logPath + "/log.txt", string.Format("{0} - {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), message + "\n"));
        }
    }
}
