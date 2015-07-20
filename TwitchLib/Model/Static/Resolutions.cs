using Newtonsoft.Json;

namespace TwitchLib.Model.Static
{
    public class Resolutions
    {
        [JsonProperty("chunked")]
        public string Chunked { get; set; }
    }
}