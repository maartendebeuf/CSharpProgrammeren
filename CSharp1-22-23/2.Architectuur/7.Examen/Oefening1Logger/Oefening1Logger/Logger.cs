using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1Logger
{
    public sealed class Logger
    {
        private static Logger instance = null;

        private Logger() 
        {
            
        }

        public static Logger GetInstance
        {
            get 
            {
                if (instance == null) instance = new Logger();
                return instance; 
            }
        }
        public void Log(string message)
        {
            string AangemaaktOp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            File.WriteAllText("./Logfile.txt", $"{AangemaaktOp} {message}");

        }
    }
}
