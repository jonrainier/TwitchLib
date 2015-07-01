using System;
using Newtonsoft.Json;
using TwitchLib.Model;

namespace TwitchLib.Util
{
    public class Parse
    {
        public enum RequestType
        {
            Kraken,
            Tmi
        }

        public void TwitchParse(string requestUrl, string model, RequestType type)
        {
            var prefix = "";

            switch (type)
            {
                case RequestType.Kraken:
                    prefix = "https://api.twitch.tv/kraken";
                    break;
                case RequestType.Tmi:
                    prefix = "https://tmi.twitch.tv";
                    break;
            }

            var client = new RestClient(prefix);
            var request = new RestRequest(requestUrl, Method.GET);
            request.AddHeader("Accept", "application/vnd.twitchtv.v3+json");

            var json = "";

            try
            {
                json = client.Execute(request).Content;
            }
            catch (Exception ex)
            {
                Twitch.Logger.Log(1, ex.Message);
            }

            if (json != "")
            {
                switch (model)
                {
                    case "CHANNEL":
                        Twitch.Channel = JsonConvert.DeserializeObject<Channel>(json);
                        break;
                    case "CHAT":
                        Twitch.Chat = JsonConvert.DeserializeObject<Chat>(json);
                        break;
                    case "CHATBADGES":
                        Twitch.ChatBadges = JsonConvert.DeserializeObject<ChatBadges>(json);
                        break;
                    case "CHATEMOTICONS":
                        Twitch.ChatEmoticons = JsonConvert.DeserializeObject<ChatEmoticons>(json);
                        break;
                    case "GAMESTOP":
                        Twitch.GamesTop = JsonConvert.DeserializeObject<GamesTop>(json);
                        break;
                    case "INGEST":
                        Twitch.IngestServer = JsonConvert.DeserializeObject<IngestServer>(json);
                        break;
                    case "STREAM":
                        Twitch.StreamLive = JsonConvert.DeserializeObject<StreamLive>(json);
                        break;
                    case "USER":
                        Twitch.User = JsonConvert.DeserializeObject<User>(json);
                        break;
                    case "USERVIDEOS":
                        Twitch.UserVideos = JsonConvert.DeserializeObject<UserVideos>(json);
                        break;
                }
            }
        }
    }
}