using Microsoft.EntityFrameworkCore;
using CMS4A4.Model.Content;

namespace CMS4A4.Repository.SQLServer.Context
{
    public class CmsContext : DbContext
    {
        public DbSet<Field> Fields { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PORTATIL-CASA\SQLEXPRESS;Database=CMS4A4;Trusted_Connection=True;");
        }
    }
}
