using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pruebas.Models;

namespace Pruebas.Data.Mappings
{
    public class CountryEntityConfigurationn : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c=> c.Name).IsRequired();
            builder.Property(c=> c.Logo).IsRequired();
            builder.HasMany(c=> c.Leagues).WithOne(c=> c.Country).HasForeignKey(c=> c.CountryId);
            builder.HasMany(c=> c.Teams).WithOne(c=> c.Country).HasForeignKey(c=> c.CountryId);
            builder.HasMany(c=> c.Players).WithOne(c=> c.Country).HasForeignKey(c=> c.CountryId);
        }
    }
}
