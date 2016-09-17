using TwitchLib.Controllers;
using TwitchLib.Models.Authed;
using TwitchLib.Util;

namespace TwitchLib.Models
{
    public class Twitch
    {
        public Twitch(string channel, string clientId, string apiToken = "")
        {
            Configuration = new Configuration
            {
                Channel = channel,
                ApiToken = apiToken
            };
            TwitchController = new TwitchController(clientId);
        }

        public Twitch(TwitchController p)
        {
            TwitchController = p;
        }

        public Twitch(Configuration c)
        {
            Configuration = c;
        }

        // TwitchLib.Util
        public Configuration Configuration { get; set; }
        public TwitchController TwitchController { get; set; }
        // TwitchLib.Model
        public Channel Channel { get; set; }
        public Chat Chat { get; set; }
        public ChatBadges ChatBadges { get; set; }
        public ChatEmoticons ChatEmoticons { get; set; }
		public ChatServers ChatServers { get; set; }
        public GamesTop GamesTop { get; set; }
        public IngestServer IngestServer { get; set; }
        public StreamLive StreamLive { get; set; }
        public StreamsTop StreamsTop { get; set; }
        public User User { get; set; }
        public UserData UserData { get; set; }
        public UserSubscription UserSubscription { get; set; }
        public UserVideos UserVideos { get; set; }
    }
}