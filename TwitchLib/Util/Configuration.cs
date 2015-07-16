using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace TwitchLib.Util
{
    public class Configuration
    {
        public string DirectoryCurrent => Directory.GetCurrentDirectory();

        public string DirectoryConfiguration => Path.Combine(DirectoryCurrent, "Configuration");

        public string FileLog => Path.Combine(DirectoryConfiguration, "TwitchLib.log");

        public string Channel { get; set; }

        public string ApiToken { get; set; }

        public string Version => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
    }
}
