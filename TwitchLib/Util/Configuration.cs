using System.Diagnostics;
using System.IO;
using System.Reflection;
using TwitchLib.Models;

namespace TwitchLib.Util
{
    public class Configuration
    {
        public Twitch Twitch;

        public Configuration()
        {
            Twitch = new Twitch(this);
        }

        public string DirectoryCurrent => Directory.GetCurrentDirectory();

        public string Version => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;

        public string Channel { get; set; }
        public string ApiToken { get; set; }
    }
}