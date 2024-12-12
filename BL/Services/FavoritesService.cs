using BL.Interfaces;
using DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class FavoriteService : IFavoriteService
    {
        private readonly FavoriteDbContext _context;

        public FavoriteService(FavoriteDbContext context)
        {
            _context = context;
        }

        public async Task AddFavoriteAsync(GitHubRepository favorite)
        {
            var exists = await _context.Favorite.AnyAsync(f => f.Id == favorite.Id);
            if (!exists)
            {
                try
                {
                    _context.Favorite.Add(favorite);
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {

                    throw;//TODO
                }

            }
        }

        public async Task<List<GitHubRepository>> GetFavoriteByIdAsync(string id)
        {
            return await _context.Favorite
                                 .ToListAsync();
        }
        public async Task<List<GitHubRepository>> GetFavoritesAsync()
        {
            return await _context.Favorite
                                 .ToListAsync();
        }
    }
}
