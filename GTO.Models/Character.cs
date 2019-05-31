using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace GOT.Models
{
    public class Character
    {
        [JsonProperty("_id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("house")]
        public string House { get; set; }
        public DateTime DateLastUpdate { get; set; }

        private string[] _titles { get; set; }
        [JsonProperty("titles")]
        public string[] Titles
        {
            get { return _titles; }
            set { _titles = value; }
        }

        [Required]
        public string TitlesAsString
        {
            get { return String.Join("@", _titles); }
            set { _titles = value.Split('@'); }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
