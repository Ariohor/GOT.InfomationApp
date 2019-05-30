using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOT.Models
{
    public class Character
    {
        [JsonProperty("_id")]
        public string Id { get; set; }
        [JsonProperty("titles")]
        public string[] Titles { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("house")]
        public string House { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
