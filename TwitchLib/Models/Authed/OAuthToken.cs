using System.Collections.Generic;
using Newtonsoft.Json;

namespace TwitchLib.Models.Authed
{
    public class OAuthToken
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("scope")]
        public IList<string> Scope { get; set; }
    }
}