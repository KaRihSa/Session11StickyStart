// create a dbcontext

using Microsoft.EntityFrameworkCore;
using stickynotes.Models;
using Stickynotes.Models;

namespace stickynotes.Data {
    public class StickyContext : DbContext
    {
        public StickyContext (DbContextOptions<StickyContext> options)
            : base(options)
        {
        }
        public DbSet<Stickynotes.Models.Sticky> Sticky { get; set; }

        // create a model, then insert a dbset here that matches it.
        // public DbSet<Movie> Movie { get; set; }
    }
}