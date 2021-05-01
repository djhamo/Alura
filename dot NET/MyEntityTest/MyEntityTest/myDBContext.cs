using MyEntityTest.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEntityTest
{
    public class myDBContext : DbContext
    {
        public myDBContext() : base("mysqlconn")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Person> People { get; set; }
    }
}
