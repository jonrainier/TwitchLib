using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TwitchLib.Model.Static
{
    public class FPS
    {
        [JsonProperty("audio_only")]
        public double AudioOnly { get; set; }

        [JsonProperty("chunked")]
        public double Chunked { get; set; }
    }
}
