using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Pruebas.Models;

namespace Pruebas.Data.Mappings
{
    public class MatchEntityConfiguration: IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.HomeGoals).IsRequired();
            builder.Property(m => m.AwayGoals).IsRequired();
            builder.Property(m => m.Date).IsRequired();
            builder.Property(m => m.Status).IsRequired();
            builder.HasOne(m => m.HomeTeam).WithMany().HasForeignKey(m => m.HomeTeamId);
            builder.HasOne(m => m.AwayTeam).WithMany().HasForeignKey(m => m.AwayTeamId);
            builder.HasOne(m => m.League).WithMany().HasForeignKey(m => m.LeagueId);
        }
    }
}
