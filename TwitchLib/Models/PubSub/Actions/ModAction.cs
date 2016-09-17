// Visual Studio Extension "JsonUtilsToolbar" created by Jonathan "Pwnoz0r" Rainier - Initial Servers LLC. - 2016
// Generated using Xamasoft JSON Class Generator Lib - http://www.xamasoft.com/json-class-generator

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TwitchLib.Models.PubSub.Actions
{

    public class Data
    {

        [JsonProperty("topics")]
        public IList<string> Topics { get; set; }

        [JsonProperty("auth_token")]
        public string AuthToken { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ModAction
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
