using Newtonsoft.Json;

namespace TwitchLib.Models.Static.Authed
{
    public class Notifications
    {
        [JsonProperty("email")]
        public bool Email { get; set; }

        [JsonProperty("push")]
        public bool Push { get; set; }
    }
}