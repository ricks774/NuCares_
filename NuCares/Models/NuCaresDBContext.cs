using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NuCares.Models
{
    public partial class NuCaresDBContext : DbContext
    {
        public NuCaresDBContext()
            : base("name=NuCaresDB")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Nutritionist> Nutritionists { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
