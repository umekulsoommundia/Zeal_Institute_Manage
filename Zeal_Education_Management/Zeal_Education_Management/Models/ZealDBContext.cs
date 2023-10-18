using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Zeal_Education_Management.Models
{
	public class ZealDBContext:DbContext
	{
		public ZealDBContext(DbContextOptions options) : base(options) { }

		public DbSet<UserModel> Users { get; set; }

        public DbSet<AdminModel> Admins { get; set; }

        public DbSet<CourseModel> Courses { get; set; }
	}
}
