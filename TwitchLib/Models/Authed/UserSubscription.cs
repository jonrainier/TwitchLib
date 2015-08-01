using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TwitchLib.Models.Static;
using TwitchLib.Models.Static.Authed;

namespace TwitchLib.Models.Authed
{
    public class UserSubscription
    {

        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("channel")]
        public Channel Channel { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
