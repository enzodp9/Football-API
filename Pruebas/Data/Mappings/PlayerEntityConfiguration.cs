using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pruebas.Models;

namespace Pruebas.Data.Mappings
{
    public class PlayerEntityConfiguration: IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Image).IsRequired();
            builder.Property(p => p.Number).IsRequired();
            builder.Property(p => p.Age).IsRequired();
            builder.Property(p => p.Position).IsRequired();
            builder.HasOne(p => p.Team).WithMany().HasForeignKey(p => p.TeamId);
            builder.HasOne(p => p.Country).WithMany().HasForeignKey(p => p.CountryId);
        }
    }
}
