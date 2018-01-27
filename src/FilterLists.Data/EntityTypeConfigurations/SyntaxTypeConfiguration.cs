﻿using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class SyntaxTypeConfiguration : BaseEntityTypeConfiguration<Syntax>
    {
        public override void Configure(EntityTypeBuilder<Syntax> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("syntaxes");
            entityTypeBuilder.Property(x => x.ModifiedDateUtc)
                .HasColumnType("TIMESTAMP")
                .ValueGeneratedOnAddOrUpdate();
            entityTypeBuilder.Property(x => x.DefinitionUrl)
                .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.Name)
                .HasColumnType("NVARCHAR(126)")
                .IsRequired();
            base.Configure(entityTypeBuilder);
        }
    }
}