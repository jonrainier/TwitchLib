using System;
using System.IO;

namespace TwitchLib.Util
{
    public class Logger
    {
        public void Log(int type, object obj, bool logFile = true)
        {
            var prefix = "";
            switch (type)
            {
                case 0:
                    prefix = "DEBUG";
                    break;
                case 1:
                    prefix = "ERROR";
                    break;
            }

            var logMessage = string.Format("{0} [{1}]: {2}", DateTime.Now.ToString("T"), prefix, obj);
            var fileLog = Twitch.Configuration.FileLog;
            var directoryConfig = Twitch.Configuration.DirectoryConfiguration;

            if (logFile)
            {
                if (!Directory.Exists(directoryConfig))
                    Directory.CreateDirectory((directoryConfig));
                using (var sw = (File.Exists(fileLog)) ? File.AppendText(fileLog) : File.CreateText(fileLog))
                    sw.WriteLine(logMessage);
            }

            Console.WriteLine(logMessage);
        }
    }
}