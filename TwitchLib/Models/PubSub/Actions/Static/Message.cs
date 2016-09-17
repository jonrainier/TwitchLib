// Visual Studio Extension "JsonUtilsToolbar" created by Jonathan "Pwnoz0r" Rainier - Initial Servers LLC. - 2016
// Generated using Xamasoft JSON Class Generator Lib - http://www.xamasoft.com/json-class-generator

using System.Collections.Generic;
using Newtonsoft.Json;

namespace TwitchLib.Models.PubSub.Actions.Static
{
    public class Data
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("moderation_action")]
        public string ModerationAction { get; set; }

        [JsonProperty("args")]
        public IList<string> Args { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }
    }

    public class Message
    {

        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
