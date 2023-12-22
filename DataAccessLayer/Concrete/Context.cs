using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
   public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-LC55U5G\\SQLEXPRESS;database=DBDenemeGamePoint;integrated security=true;");
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Firmalar> Firmalars { get; set; }
        public DbSet<Hareketler> Hareketlers { get; set; }
        public DbSet<Oyunlar> Oyunlars { get; set; }
        public DbSet<Platform> Platforms { get; set; }

    }
}
