using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class GitHubSearchResult
    {
        [JsonPropertyName("total_count")]
        public int TotalCount { get; set; }     

        [JsonPropertyName("items")]
        public List<GitHubRepository> Items { get; set; }
    }

    public class GitHubRepository
    {

        [JsonPropertyName("id")]
        public int Id { get; set; } = 0;

        [JsonPropertyName("name")]
        public string? Name { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string? Description { get; set; } = string.Empty;

        [JsonPropertyName("stargazers_count")]
        public int Stargazers_count { get; set; } = 0;

        [JsonPropertyName("html_url")]
        public string Html_url { get; set; } = string.Empty;

    }
}
