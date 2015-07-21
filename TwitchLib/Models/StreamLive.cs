using Newtonsoft.Json;
using TwitchLib.Models.Static;

namespace TwitchLib.Models
{
    public class Preview
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }
    }

    public class StreamLive
    {
        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("stream")]
        public Stream Stream { get; set; }
    }
}