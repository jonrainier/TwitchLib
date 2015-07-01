using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using TwitchLib.Models;

namespace TwitchLib.Util
{
    public class Parse
    {
        public enum RequestType
        {
            Kraken,
            Tmi
        }

        public Twitch _twitch;

        public Parse()
        {
            _twitch = new Twitch(this);
        }

        public async void TwitchParse<T>(string requestUrl, T model, RequestType type)
        {
            var prefix = "";
            var response = new HttpResponseMessage();

            switch (type)
            {
                case RequestType.Kraken:
                    prefix = "https://api.twitch.tv/kraken";
                    break;
                case RequestType.Tmi:
                    prefix = "https://tmi.twitch.tv";
                    break;
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(prefix);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/vnd.twitchtv.v3+json"));
                response = await client.GetAsync(requestUrl);
                if (response.IsSuccessStatusCode)
                {
                    var requestData = await response.Content.ReadAsStringAsync();
                    var formattedData = JsonConvert.DeserializeObject<T>(requestData);
                    _twitch.GetType().GetProperty(typeof (T).ToString()).SetValue(_twitch, formattedData);
                }
                else
                {
                    Twitch.Logger.Log(1, response.ReasonPhrase);
                }
            }

            //if (json == "") return;

            //switch (model)
            //{
            //    case "CHANNEL":
            //        Twitch.Channel = JsonConvert.DeserializeObject<Channel>(json);
            //        break;
            //    case "CHAT":
            //        Twitch.Chat = JsonConvert.DeserializeObject<Chat>(json);
            //        break;
            //    case "CHATBADGES":
            //        Twitch.ChatBadges = JsonConvert.DeserializeObject<ChatBadges>(json);
            //        break;
            //    case "CHATEMOTICONS":
            //        Twitch.ChatEmoticons = JsonConvert.DeserializeObject<ChatEmoticons>(json);
            //        break;
            //    case "GAMESTOP":
            //        Twitch.GamesTop = JsonConvert.DeserializeObject<GamesTop>(json);
            //        break;
            //    case "INGEST":
            //        Twitch.IngestServer = JsonConvert.DeserializeObject<IngestServer>(json);
            //        break;
            //    case "STREAM":
            //        Twitch.StreamLive = JsonConvert.DeserializeObject<StreamLive>(json);
            //        break;
            //    case "USER":
            //        Twitch.User = JsonConvert.DeserializeObject<User>(json);
            //        break;
            //    case "USERVIDEOS":
            //        Twitch.UserVideos = JsonConvert.DeserializeObject<UserVideos>(json);
            //        break;
            //}
        }
    }
}