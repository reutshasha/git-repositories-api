using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IGitHubService
    {
        Task<GitHubSearchResult> SearchRepositoriesAsync(string query, int page = 1, int perPage = 15);
    }
}
