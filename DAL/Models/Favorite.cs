//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.Json.Serialization;
//using System.Threading.Tasks;

//namespace DAL.Models
//{
//    public class GitHubSearchResult
//    {
//        [JsonPropertyName("total_count")]
//        public int TotalCount { get; set; }

//        [JsonPropertyName("items")]
//        public List<Favorite> Items { get; set; }
//    }

//    public class Favorite
//    {
//        [JsonPropertyName("id")]
//        public long Id { get; set; }

//        [JsonPropertyName("name")]
//        public string Name { get; set; }

//        public string Description { get; set; }

//        [JsonPropertyName("stargazers_count")]
//        public int Stars { get; set; }

//        [JsonPropertyName("html_url")]
//        public string Url { get; set; }
//    }
//}
