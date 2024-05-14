using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pruebas.Models;

namespace Pruebas.Data.Mappings
{
    public class LeagueEntityConfiguration : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Name).IsRequired();
            builder.Property(l => l.Logo).IsRequired();
            builder.HasOne(l => l.Country).WithMany().HasForeignKey(l => l.CountryId);
            builder.HasMany(l => l.Teams).WithMany(l => l.Leagues);
        }
    }
}
