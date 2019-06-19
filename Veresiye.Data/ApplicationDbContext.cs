using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Data.Builders;
using Veresiye.Model;

namespace Veresiye.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(): base("name=DefaultConnection")
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var userBuilder = new UserBuilder(modelBuilder.Entity<User>());
        }
    }
}
