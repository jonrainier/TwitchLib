// Visual Studio Extension "JsonUtilsToolbar" created by Jonathan "Pwnoz0r" Rainier - Initial Servers LLC. - 2016
// Generated using Xamasoft JSON Class Generator Lib - http://www.xamasoft.com/json-class-generator

using Newtonsoft.Json;

namespace TwitchLib.Models.PubSub.Actions.MessageModels
{
    public class Data
    {

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ModMessageModel
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
