using Microsoft.EntityFrameworkCore;
using PulsenicsAssessments.Models;

namespace PulsenicsAssessments.Database
{
    public class FilesContext : DbContext
    {
        public DbSet<FileData> Files { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source = mydatabase.db");
    }
}
