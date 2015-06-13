using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Util
{
    public class Configuration
    {
        public string DirectoryCurrent
        {
            get
            {
                return Directory.GetCurrentDirectory();
            }
        }

        public string DirectoryConfiguration
        {
            get
            {
                return Path.Combine(DirectoryCurrent, "Configuration");
            }
        }

        public string FileLog
        {
            get
            {
                return Path.Combine(DirectoryConfiguration, "TwitchLib.log");
            }
        }

        public string Channel { get; set; }

        public string APIToken { get; set; }

        public string Version
        {
            get
            {
                return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
            }
        }
    }
}
