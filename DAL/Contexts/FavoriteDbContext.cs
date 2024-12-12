using Microsoft.EntityFrameworkCore;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contexts
{
    public class FavoriteDbContext : DbContext
    {
        public FavoriteDbContext(DbContextOptions<FavoriteDbContext> options) : base(options) { }
        public DbSet<GitHubRepository> Favorite { get; set; }
        //public DbSet<GitHubRepository> Repositories { get; set; }

    }
}
