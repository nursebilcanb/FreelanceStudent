using FreelanceStudent.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreelanceStudent.Data.EntityFramework.Configuration
{
    public class ProgrammingLanguageConfiguration : IEntityTypeConfiguration<ProgrammingLanguage>
    {
        public void Configure(EntityTypeBuilder<ProgrammingLanguage> builder)
        {
            builder.HasKey(x => x.LanguageId);
            builder.HasOne(x => x.Background)
                .WithMany(b => b.ProgrammingLanguages)
                .HasForeignKey(x => x.BackgroundId);
        }
    }
}