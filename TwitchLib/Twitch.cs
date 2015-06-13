using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Model;
using TwitchLib.Util;

namespace TwitchLib
{
    public class Twitch
    {
        // TwitchLib.Util
        public static Configuration Configuration { get; set; }
        public static Logger Logger { get; set; }
        public static Parse Parse { get; set; }

        // TwitchLib.Model
        public static Channel Channel { get; set; }
        public static Chat Chat { get; set; }
        public static ChatBadges ChatBadges { get; set; }
        public static ChatEmoticons ChatEmoticons { get; set; }
        public static GamesTop GamesTop { get; set; }
        public static IngestServer IngestServer { get; set; }
        public static StreamLive StreamLive { get; set; }
        public static User User { get; set; }
        public static UserVideos UserVideos { get; set; }

        public Twitch(string channel, string apiToken = "")
        {
            Configuration = new Configuration()
            {
                Channel = channel,
                APIToken = apiToken,
            };
            Logger = new Logger();
            Parse = new Parse();
        }
    }
}
