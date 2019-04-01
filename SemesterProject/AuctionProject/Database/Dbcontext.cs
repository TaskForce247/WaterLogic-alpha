namespace Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Core;
    using Database.Migrations;


    public class Dbcontext : DbContext
    {
        public Dbcontext()
            : base("name=DbContext")
        {
            Database.SetInitializer(new
                MigrateDatabaseToLatestVersion<Dbcontext, Configuration>());
        }

        public virtual DbSet<Account> Accounts { get; set; } //allows method to be overwritten

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
        }
    }
}
