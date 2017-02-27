using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Task_2.Models;

namespace Task_2
{
	public class MyDbContext : DbContext
	{
		public DbSet<Order> Order { get; set; }
		public MyDbContext() : base("name=Task_2DBContext")
		{
			Database.SetInitializer<MyDbContext>(new CreateDatabaseIfNotExists<MyDbContext>());
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			Database.SetInitializer(new MyDbContextInitializer());
			modelBuilder.Entity<Order>()
			 .Property(c => c.ID)
			 .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			base.OnModelCreating(modelBuilder);
		}

		public class MyDbContextInitializer : DropCreateDatabaseIfModelChanges<MyDbContext>
		{
			protected override void Seed(MyDbContext dbContext)
			{
				// seed data

				base.Seed(dbContext);
			}
		}
	}
}