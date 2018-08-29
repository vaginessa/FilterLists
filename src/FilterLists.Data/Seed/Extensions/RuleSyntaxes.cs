using System;
using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Data.Seed.Extensions
{
    public static class RuleSyntaxes
    {
        public static void SeedRuleSyntaxes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RuleSyntax>()
                        .HasData(
                            new
                            {
                                Id = 1,
                                CreatedDateUtc = DateTime.Now,
                                ModifiedDateUtc = DateTime.Now,
                                Name = "Comment"
                            },
                            new
                            {
                                Id = 2,
                                CreatedDateUtc = DateTime.Now,
                                ModifiedDateUtc = DateTime.Now,
                                Name = "Title"
                            },
                            new
                            {
                                Id = 3,
                                CreatedDateUtc = DateTime.Now,
                                ModifiedDateUtc = DateTime.Now,
                                Name = "Expires"
                            },
                            new
                            {
                                Id = 4,
                                CreatedDateUtc = DateTime.Now,
                                ModifiedDateUtc = DateTime.Now,
                                Name = "Platform Hint"
                            },
                            new
                            {
                                Id = 5,
                                CreatedDateUtc = DateTime.Now,
                                ModifiedDateUtc = DateTime.Now,
                                Name = "Pre-processor Directive"
                            });
        }
    }
}