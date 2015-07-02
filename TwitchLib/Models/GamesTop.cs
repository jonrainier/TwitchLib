using System.Collections.Generic;
using Newtonsoft.Json;
using TwitchLib.Models.Static;

namespace TwitchLib.Models
{
    public class Box
    {
        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }
    }

    public class Logo
    {
        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }
    }

    public class Game
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("_id")]
        public int Id { get; set; }

        [JsonProperty("giantbomb_id")]
        public int GiantbombId { get; set; }

        [JsonProperty("box")]
        public Box Box { get; set; }

        [JsonProperty("logo")]
        public Logo Logo { get; set; }
    }

    public class Top
    {
        [JsonProperty("viewers")]
        public int Viewers { get; set; }

        [JsonProperty("channels")]
        public int Channels { get; set; }

        [JsonProperty("game")]
        public Game Game { get; set; }
    }

    public class GamesTop
    {
        [JsonProperty("_total")]
        public int Total { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("top")]
        public IList<Top> Top { get; set; }
    }
}