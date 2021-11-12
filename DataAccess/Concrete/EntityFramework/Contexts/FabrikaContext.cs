using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class FabrikaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=1LP001;Database=Fabrika;Trusted_Connection=true");
        }

        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Operasyon> Operasyon { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleOperasyon> RoleOperasyon { get; set; }
    }
}
