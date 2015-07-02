using System.Collections.Generic;
using Newtonsoft.Json;
using TwitchLib.Models.Static;

namespace TwitchLib.Models
{
    public class IngestServer
    {
        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("ingests")]
        public IList<Ingest> Ingests { get; set; }
    }
}