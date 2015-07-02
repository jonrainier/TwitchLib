using System.Diagnostics;
using System.IO;
using System.Reflection;
using TwitchLib.Models;

namespace TwitchLib.Util
{
    public class Configuration
    {
        public Twitch _twitch;

        public Configuration()
        {
            _twitch = new Twitch(this);
        }

        public string DirectoryCurrent
        {
            get { return Directory.GetCurrentDirectory(); }
        }

        public string DirectoryConfiguration
        {
            get { return Path.Combine(DirectoryCurrent, "Configuration"); }
        }

        public string FileLog
        {
            get { return Path.Combine(DirectoryConfiguration, "TwitchLib.log"); }
        }

        public string Channel { get; set; }
        public string ApiToken { get; set; }

        public string Version
        {
            get { return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion; }
        }
    }
}