using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Data.Seed.Extensions
{
    public static class RuleSyntaxes
    {
        private static readonly RuleSyntax[] RuleSyntaxesSeed =
        {
            new RuleSyntax
            {
                Id = 1, CreatedDateUtc = null, ModifiedDateUtc = null, Name = "Comment"
            },
            new RuleSyntax
            {
                Id = 2, CreatedDateUtc = null, ModifiedDateUtc = null, Name = "Title"
            },
            new RuleSyntax
            {
                Id = 3, CreatedDateUtc = null, ModifiedDateUtc = null, Name = "Expires"
            },
            new RuleSyntax
            {
                Id = 4, CreatedDateUtc = null, ModifiedDateUtc = null, Name = "Platform Hint"
            },
            new RuleSyntax
            {
                Id = 5, CreatedDateUtc = null, ModifiedDateUtc = null, Name = "Pre-processor Directive"
            }
        };

        public static void SeedRuleSyntaxes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RuleSyntax>().HasData(RuleSyntaxesSeed);
        }
    }
}