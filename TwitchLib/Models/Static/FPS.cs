using Newtonsoft.Json;

namespace TwitchLib.Models.Static
{
    public class Fps
    {
        [JsonProperty("audio_only")]
        public double AudioOnly { get; set; }

        [JsonProperty("chunked")]
        public double Chunked { get; set; }
    }
}