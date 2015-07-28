using System;
using Newtonsoft.Json;
using TwitchLib.Models.Static;

namespace TwitchLib.Models
{
    public class Channel
    {
        [JsonProperty("mature", NullValueHandling = NullValueHandling.Ignore)]
        public bool Mature { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("broadcaster_language")]
        public string BroadcasterLanguage { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("game")]
        public string Game { get; set; }

        [JsonProperty("delay")]
        public object Delay { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("_id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("banner")]
        public object Banner { get; set; }

        [JsonProperty("video_banner")]
        public object VideoBanner { get; set; }

        [JsonProperty("background")]
        public object Background { get; set; }

        [JsonProperty("profile_banner")]
        public object ProfileBanner { get; set; }

        [JsonProperty("profile_banner_background_color")]
        public object ProfileBannerBackgroundColor { get; set; }

        [JsonProperty("partner")]
        public bool Partner { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("views")]
        public int Views { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }
    }
}