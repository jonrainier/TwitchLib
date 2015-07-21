using System;
using Newtonsoft.Json;

namespace TwitchLib.Models.Static
{
    public class Stream
    {
        [JsonProperty("_id")]
        public long Id { get; set; }

        [JsonProperty("game")]
        public string Game { get; set; }

        [JsonProperty("viewers")]
        public int Viewers { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("video_height")]
        public int VideoHeight { get; set; }

        [JsonProperty("average_fps")]
        public double AverageFps { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("preview")]
        public Preview Preview { get; set; }

        [JsonProperty("channel")]
        public Channel Channel { get; set; }
    }
}