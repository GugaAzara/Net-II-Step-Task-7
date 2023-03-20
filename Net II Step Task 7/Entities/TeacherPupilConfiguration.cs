using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Net_II_Step_Task_7.Entities
{
	public class TeacherPupilConfiguration : IEntityTypeConfiguration<TeacherPupil>
	{
		public void Configure(EntityTypeBuilder<TeacherPupil> builder)
		{
			builder.HasKey(c => c.Id);
			builder.HasOne(c => c.Pupil)
				.WithMany(c => c.TeacherPupil)
				.HasForeignKey(c => c.PupilId);
			builder.HasOne(c => c.Teacher)
				.WithMany(c => c.TeacherPupil)
				.HasForeignKey(c => c.TeacherId);
		}
	}
		
}
