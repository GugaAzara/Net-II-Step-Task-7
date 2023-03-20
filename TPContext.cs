using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Net_II_Step_Task_7.Entities;

namespace Net_II_Step_Task_7
{
	public class TPContext : DbContext
	{
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Pupil> Pupils { get; set; }
		public DbSet<TeacherPupil> TeacherPupil { get; set; }

		public TPContext(DbContextOptions options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new  PupilConfiguration());
			builder.ApplyConfiguration(new TeacherConfiguration());
			builder.ApplyConfiguration(new TeacherPupilConfiguration());
		}
	}
}
