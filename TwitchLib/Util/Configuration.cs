using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace TwitchLib.Util
{
    public class Configuration
    {
        public string Channel { get; set; }
        public string ApiToken { get; set; }

        public string Version => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
    }
}