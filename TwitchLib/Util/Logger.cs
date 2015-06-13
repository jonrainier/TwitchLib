using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Util
{
    public class Logger
    {
        public void Log(int type, object obj, bool logFile = true)
        {
            string prefix = "";
            switch (type)
            {
                case 0:
                    prefix = "DEBUG";
                    break;
                case 1:
                    prefix = "ERROR";
                    break;
            }

            string logMessage = string.Format("{0} [{1}]: {2}", DateTime.Now.ToString("T"), prefix, obj);
            string fileLog = Twitch.Configuration.FileLog;
            string directoryConfig = Twitch.Configuration.DirectoryConfiguration;

            if (logFile)
            {
                if (!Directory.Exists(directoryConfig))
                    Directory.CreateDirectory((directoryConfig));
                using (StreamWriter sw = (File.Exists(fileLog)) ? File.AppendText(fileLog) : File.CreateText(fileLog))
                    sw.WriteLine(logMessage);
            }

            Console.WriteLine(logMessage);
        }
    }
}
