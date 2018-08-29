using System;
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
                Id = 1, CreatedDateUtc = DateTime.Now, ModifiedDateUtc = DateTime.Now, Name = "Comment"
            },
            new RuleSyntax
            {
                Id = 2, CreatedDateUtc = DateTime.Now, ModifiedDateUtc = DateTime.Now, Name = "Title"
            },
            new RuleSyntax
            {
                Id = 3, CreatedDateUtc = DateTime.Now, ModifiedDateUtc = DateTime.Now, Name = "Expires"
            },
            new RuleSyntax
            {
                Id = 4, CreatedDateUtc = DateTime.Now, ModifiedDateUtc = DateTime.Now, Name = "Platform Hint"
            },
            new RuleSyntax
            {
                Id = 5, CreatedDateUtc = DateTime.Now, ModifiedDateUtc = DateTime.Now, Name = "Pre-processor Directive"
            }
        };

        public static void SeedRuleSyntaxes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RuleSyntax>().HasData(RuleSyntaxesSeed);
        }
    }
}