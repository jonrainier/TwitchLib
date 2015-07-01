using TwitchLib.Models;
using TwitchLib.Util;

namespace TwitchLib.Models
{
    public class Twitch
    {
        public Twitch(string channel, string apiToken = "")
        {
            Configuration = new Configuration
            {
                Channel = channel,
                ApiToken = apiToken
            };
            Logger = new Logger();
            Parse = new Parse();
        }

        public Twitch(Parse p)
        {
            Parse = p;
        }

        // TwitchLib.Util
        public Configuration Configuration { get; set; }
        public Logger Logger { get; set; }
        public Parse Parse { get; set; }
        // TwitchLib.Model
        public Channel Channel { get; set; }
        public Chat Chat { get; set; }
        public ChatBadges ChatBadges { get; set; }
        public ChatEmoticons ChatEmoticons { get; set; }
        public GamesTop GamesTop { get; set; }
        public IngestServer IngestServer { get; set; }
        public StreamLive StreamLive { get; set; }
        public User User { get; set; }
        public UserVideos UserVideos { get; set; }
    }
}