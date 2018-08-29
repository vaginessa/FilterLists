using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class RuleSyntaxTypeConfiguration : BaseEntityTypeConfiguration<RuleSyntax>
    {
        public override void Configure(EntityTypeBuilder<RuleSyntax> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("rule_syntaxes");
            entityTypeBuilder.Property(x => x.Id)
                             .HasColumnType("TINYINT UNSIGNED");
            entityTypeBuilder.Property(x => x.Name)
                             .HasColumnType("VARCHAR(126)")
                             .IsRequired();
        }
    }
}