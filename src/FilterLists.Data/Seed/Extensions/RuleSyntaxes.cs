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
                                Name = "Comment"
                            },
                            new
                            {
                                Id = (uint)2,
                                Name = "Title"
                            },
                            new
                            {
                                Id = (uint)3,
                                Name = "Expires"
                            },
                            new
                            {
                                Id = (uint)4,
                                Name = "Platform Hint"
                            },
                            new
                            {
                                Id = (uint)5,
                                Name = "Pre-processor Directive"
                            });
        }
    }
}