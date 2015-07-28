using Newtonsoft.Json;
using TwitchLib.Models.Static;
using TwitchLib.Models.Static.Authed;

namespace TwitchLib.Models.Authed
{
    public class UserData
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("_id")]
        public int Id { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("partnered")]
        public bool Partnered { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("notifications")]
        public Notifications Notifications { get; set; }
    }
}