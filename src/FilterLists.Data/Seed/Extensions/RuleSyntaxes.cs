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
                                CreatedDateUtc = DateTime.Now,
                                ModifiedDateUtc = DateTime.Now,
                                Name = "Comment"
                            },
                            new
                            {
                                Id = (uint)2,
                                CreatedDateUtc = DateTime.Now,
                                ModifiedDateUtc = DateTime.Now,
                                Name = "Title"
                            },
                            new
                            {
                                Id = (uint)3,
                                CreatedDateUtc = DateTime.Now,
                                ModifiedDateUtc = DateTime.Now,
                                Name = "Expires"
                            },
                            new
                            {
                                Id = (uint)4,
                                CreatedDateUtc = DateTime.Now,
                                ModifiedDateUtc = DateTime.Now,
                                Name = "Platform Hint"
                            },
                            new
                            {
                                Id = (uint)5,
                                CreatedDateUtc = DateTime.Now,
                                ModifiedDateUtc = DateTime.Now,
                                Name = "Pre-processor Directive"
                            });
        }
    }
}