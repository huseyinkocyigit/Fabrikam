using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class PgFabrikaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"User ID=postgres;Password=123456;Server=localhost;Port=5432;Database=Fabrika;Integrated Security=true;Pooling=true");
        }

        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Operasyon> Operasyon { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleOperasyon> RoleOperasyon { get; set; }
        public DbSet<Arac> Arac{ get; set; }
        public DbSet<AracRezervasyon> AracRezervasyon{ get; set; }
    }
}
