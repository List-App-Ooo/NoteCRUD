using Microsoft.EntityFrameworkCore;
using NoteCRUD.Models;

namespace NoteCRUD.Data 
{
    public class NoteContext : DbContext 
    {
        public NoteContext(DbContextOptions<NoteContext> options) : base(options) { }

        public DbSet<NoteItemModel> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}