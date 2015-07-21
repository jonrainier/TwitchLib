using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using TwitchLib.Models;

namespace TwitchLib.Controllers
{
    public class TwitchController
    {
        public enum RequestType
        {
            Kraken,
            Tmi
        }

        public TwitchController()
        {
            Twitch = new Twitch(this);
        }

        public Twitch Twitch { get; set; }

        public void ApiRequest<T>(string requestUrl, RequestType type)
        {
            var prefix = "";
            var response = new HttpResponseMessage();

            switch (type)
            {
                case RequestType.Kraken:
                    prefix = "https://api.twitch.tv/kraken/";
                    break;
                case RequestType.Tmi:
                    prefix = "https://tmi.twitch.tv/";
                    break;
            }

            using (var client = new WebClient())
            {
                client.Headers["application"] = "vnd.twitchtv.v3+json";
                var requestData = client.DownloadString(prefix + requestUrl);
                var formattedData = JsonConvert.DeserializeObject<T>(requestData);
                Twitch.GetType().GetProperty(typeof (T).Name).SetValue(Twitch, formattedData);
            }
        }
    }
}