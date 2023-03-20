using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Net_II_Step_Task_7.Entities
{
	public class TeacherPupilConfiguration : IEntityTypeConfiguration<TeacherPupil>
	{
		public void Configure(EntityTypeBuilder<TeacherPupil> builder)
		{
			builder.HasKey(x => x.Id);
			builder.HasOne(x => x.Teachers)
				.WithMany(x => x.TeacherPupil)
				.HasForeignKey(x => x.TeacherId);
			builder.HasOne(x => x.Pupils)
				.WithMany(x => x.TeacherPupil)
				.HasForeignKey(x => x.PupilId);
		}
	}
}
