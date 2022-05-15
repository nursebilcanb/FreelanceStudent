using FreelanceStudent.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreelanceStudent.Data.EntityFramework.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.CategoryId);
            builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(250);

            builder.HasData(new Category
            {
                CategoryId = 1,
                CategoryName = "Yazılım",
            });
        }
    }
}