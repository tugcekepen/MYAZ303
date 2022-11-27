using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCProjem.Models;

namespace MVCProjem.Data.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CategoryName).IsRequired();

            builder.HasData(
                new Category(1, "Electronic Products")
                {
                    Description = "to follow the warranty periods and invoices of your products"
                },
                new Category(2, "House Cleaning Products")
                {
                    Description = ""
                },
                new Category(3, "Car Cleaning Products")
                {
                    Description = ""
                },
                new Category(4, "Fresh Food Products")
                {
                    Description = "fruits and vegetables"
                },
                new Category(5, "Frozen Food Products")
                {
                    Description = "with or without package"
                },
                new Category(6, "Drink Products")
                {
                    Description = "coffee, tea, water etc."
                },
                new Category(7, "Personal Care Products")
                {
                    Description = "oral care, skin care, hair care etc."
                },
                new Category(8, "Cosmetics Products")
                {
                    Description = ""
                },
                new Category(9, "Other Cosmetics Products")
                {
                    Description = "nail polish, deodorant, perfume etc."
                },
                new Category(10, "Pet Products")
                {
                    Description = "nutrition, medicine etc."
                }
                );
        }
    }
}
