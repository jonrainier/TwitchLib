using System.Collections.Generic;
using Newtonsoft.Json;
using TwitchLib.Models.Static;

namespace TwitchLib.Models
{
    public class StreamsTop
    {
        [JsonProperty("streams")]
        public IList<Stream> Streams { get; set; }

        [JsonProperty("_total")]
        public int Total { get; set; }
    }
}