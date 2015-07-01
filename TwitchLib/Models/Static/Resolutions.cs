using Newtonsoft.Json;

namespace TwitchLib.Models.Static
{
    public class Resolutions
    {
        [JsonProperty("chunked")]
        public string Chunked { get; set; }
    }
}