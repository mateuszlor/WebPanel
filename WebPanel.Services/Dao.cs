using System;
using System.Collections.Generic;
using System.Data.Entity;
using WebPanel.Model;

namespace WebPanel.Services
{
    public class Dao : DbContext, IDao
    {
        #region Constructors

        public Dao() : base("AzureZIM")
        {
        }

        #endregion

        #region Sets
         
        public DbSet<Task> Tasks { get; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Dao>());
        }
    }
}
