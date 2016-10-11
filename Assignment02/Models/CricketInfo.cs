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

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Team2> Team2 { get; set; }
        public virtual DbSet<Team1> Team1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Team2>()
                .Property(e => e.TEAMSCORE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Team2>()
                .Property(e => e.BATSMANOUT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Team2>()
                .Property(e => e.SPECTATORS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Team1>()
                .Property(e => e.TEAMSCORE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Team1>()
                .Property(e => e.BATSMANOUT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Team1>()
                .Property(e => e.SPECTATORS)
                .HasPrecision(18, 0);
        }
    }
}
