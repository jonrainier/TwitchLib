using System.Collections.Generic;
using Newtonsoft.Json;
using TwitchLib.Models.Static;

namespace TwitchLib.Models
{
    public class Chatters
    {
        [JsonProperty("moderators")]
        public IList<string> Moderators { get; set; }

        [JsonProperty("staff")]
        public IList<object> Staff { get; set; }

        [JsonProperty("admins")]
        public IList<object> Admins { get; set; }

        [JsonProperty("global_mods")]
        public IList<object> GlobalMods { get; set; }

        [JsonProperty("viewers")]
        public IList<string> Viewers { get; set; }
    }

    public class Chat
    {
        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("chatter_count")]
        public int ChatterCount { get; set; }

        [JsonProperty("chatters")]
        public Chatters Chatters { get; set; }
    }
}