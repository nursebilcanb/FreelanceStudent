using FreelanceStudent.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreelanceStudent.Data.EntityFramework.Configuration
{
    public class ForeignLanguageConfiguration : IEntityTypeConfiguration<ForeignLanguage>
    {
        public void Configure(EntityTypeBuilder<ForeignLanguage> builder)
        {
            builder.HasKey(x => x.LanguageId);
            builder.HasOne(x => x.Background)
                .WithMany(b => b.ForeignLanguages)
                .HasForeignKey(x => x.BackgroundId);
        }
    }
}