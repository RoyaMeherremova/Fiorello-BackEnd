using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configurations
{
    public class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.Property(m => m.Title).HasMaxLength(255).IsRequired(false);
            builder.Property(m => m.Description).IsRequired(false);
            builder.Property(m => m.Image).IsRequired(false);
        }
    }
}
