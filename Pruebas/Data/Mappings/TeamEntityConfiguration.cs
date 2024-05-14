using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Pruebas.Models;

namespace Pruebas.Data.Mappings
{
    public class TeamEntityConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.Founded).IsRequired();
            builder.Property(t => t.Logo).IsRequired();
            builder.Property(t => t.Stadium).IsRequired();
            builder.Property(t => t.Coach).IsRequired();
            builder.HasOne(t => t.Country).WithMany().HasForeignKey(t => t.CountryId);
            builder.HasMany(t => t.Leagues).WithMany(l => l.Teams);
        }
    }
}
