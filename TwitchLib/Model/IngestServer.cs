using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TwitchLib.Model.Static;

namespace TwitchLib.Model
{
    public class IngestServer
    {

        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("ingests")]
        public IList<Ingest> Ingests { get; set; }
    }
}
