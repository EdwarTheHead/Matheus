using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TesteAM4.Models
{
    public class DataBase : DbContext
    {
        public DataBase():base("DefaultConnection"){}

        public DbSet<Noticias> Noticias { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            base.OnModelCreating(builder);
        }
    }
}