using System.Collections.Generic;
using Newtonsoft.Json;

namespace TwitchLib.Models
{
    public class ChatServers
    {
        [JsonProperty("cluster")]
        public string Cluster { get; set; }
        [JsonProperty("servers")]
        public List<string> Servers { get; set; }
        [JsonProperty("websockets_servers")]
        public List<string> WebsocketsServers { get; set; }
    }
}
