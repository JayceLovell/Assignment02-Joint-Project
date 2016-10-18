namespace Assignment02.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CricketInfo : DbContext
    {
        public CricketInfo()
            : base("name=CricketInfoConnectionString")
        {
        }

        public virtual DbSet<CricketInfoMain> CricketInfoMains { get; set; }
        public virtual DbSet<CricketInfoBackUp> CricketInfoBackUps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
