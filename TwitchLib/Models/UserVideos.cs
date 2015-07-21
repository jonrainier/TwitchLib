using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TwitchLib.Models.Static;

namespace TwitchLib.Models
{
    public class Video
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("broadcast_id")]
        public object BroadcastId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tag_list")]
        public string TagList { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("recorded_at")]
        public DateTime RecordedAt { get; set; }

        [JsonProperty("game")]
        public string Game { get; set; }

        [JsonProperty("length")]
        public double Length { get; set; }

        [JsonProperty("preview")]
        public string Preview { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("views")]
        public int Views { get; set; }

        [JsonProperty("fps")]
        public Fps Fps { get; set; }

        [JsonProperty("resolutions")]
        public Resolutions Resolutions { get; set; }

        [JsonProperty("broadcast_type")]
        public string BroadcastType { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("channel")]
        public Channel Channel { get; set; }
    }

    public class UserVideos
    {
        [JsonProperty("_total")]
        public int Total { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("videos")]
        public IList<Video> Videos { get; set; }
    }
}