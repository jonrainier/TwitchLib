using Newtonsoft.Json;

namespace TwitchLib.Models.Static
{
    public class Links
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("follows")]
        public string Follows { get; set; }

        [JsonProperty("commercial")]
        public string Commercial { get; set; }

        [JsonProperty("stream_key")]
        public string StreamKey { get; set; }

        [JsonProperty("chat")]
        public string Chat { get; set; }

        [JsonProperty("features")]
        public string Features { get; set; }

        [JsonProperty("subscriptions")]
        public string Subscriptions { get; set; }

        [JsonProperty("editors")]
        public string Editors { get; set; }

        [JsonProperty("teams")]
        public string Teams { get; set; }

        [JsonProperty("videos")]
        public string Videos { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }
    }
}