using FreelanceStudent.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreelanceStudent.Data.EntityFramework.Configuration
{
    public class JobExperienceConfiguration : IEntityTypeConfiguration<JobExperience>
    {
        public void Configure(EntityTypeBuilder<JobExperience> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Background)
                .WithMany(b => b.JobExperiences)
                .HasForeignKey(x => x.BackgroundId);
        }
    }
}