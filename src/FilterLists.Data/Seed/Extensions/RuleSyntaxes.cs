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
                                Id = (uint)1,
                                CreatedDateUtc = (DateTime?)null,
                                ModifiedDateUtc = (DateTime?)null,
                                Name = "Comment"
                            },
                            new
                            {
                                Id = (uint)2,
                                CreatedDateUtc = (DateTime?)null,
                                ModifiedDateUtc = (DateTime?)null,
                                Name = "Title"
                            },
                            new
                            {
                                Id = (uint)3,
                                CreatedDateUtc = (DateTime?)null,
                                ModifiedDateUtc = (DateTime?)null,
                                Name = "Expires"
                            },
                            new
                            {
                                Id = (uint)4,
                                CreatedDateUtc = (DateTime?)null,
                                ModifiedDateUtc = (DateTime?)null,
                                Name = "Platform Hint"
                            },
                            new
                            {
                                Id = (uint)5,
                                CreatedDateUtc = (DateTime?)null,
                                ModifiedDateUtc = (DateTime?)null,
                                Name = "Pre-processor Directive"
                            });
        }
    }
}