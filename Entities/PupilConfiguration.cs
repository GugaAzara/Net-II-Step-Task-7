using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Net_II_Step_Task_7.Entities
{
	public class PupilConfiguration : IEntityTypeConfiguration<Pupil>
	{
		public void Configure(EntityTypeBuilder<Pupil> builder)
		{
			builder.HasKey(x => x.Id);
		}
	}
}
