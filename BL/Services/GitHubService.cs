using BL.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BL.Services
{
    public class GitHubService : IGitHubService
    {
        private readonly HttpClient _client;
        private readonly IMemoryCache _cache;
        public GitHubService(IHttpClientFactory httpClientFactory, IMemoryCache cache)
        {
            _client = httpClientFactory.CreateClient("GitHubClient");
            _cache = cache;
        }
        public async Task<GitHubSearchResult> SearchRepositoriesAsync(string query, int page = 1, int perPage = 10)
        {
            if (string.IsNullOrWhiteSpace(query))
                throw new ArgumentException("Query cannot be null or empty.", nameof(query));//TODO: handeling error
            string cacheKey = $"GitHubSearch-{query}-Page{page}-Size{perPage}";

            if (_cache.TryGetValue(cacheKey, out GitHubSearchResult cachedResult))
            {
                if (cachedResult == null)
                {
                    //ERROR
                }
                return cachedResult;
            }


            var url = $"search/repositories?q={query}&page={page}&per_page={perPage}";

            var response = await _client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                throw new Exception($"GitHub API Error: {response.StatusCode}");

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<GitHubSearchResult>(content);

            _cache.Set(cacheKey, result, TimeSpan.FromMinutes(15));

            return result;
        }
    }
}
