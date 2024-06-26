﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PackIT.Infrastructure.EFCore.Models;

namespace PackIT.Infrastructure.EFCore.Config
{
    public class ReadConfiguration : IEntityTypeConfiguration<PackingListReadModel>, IEntityTypeConfiguration<PackingItemReadModel>
    {
        public void Configure(EntityTypeBuilder<PackingItemReadModel> builder)
        {
            builder.ToTable("PackingItems");
        }

        public void Configure(EntityTypeBuilder<PackingListReadModel> builder)
        {
            builder.ToTable("PackingLists");

            builder.HasKey(pl => pl.Id);

            builder.Property(pl => pl.Localization)
                .HasConversion(l => l.ToString(), l => LocalizationReadModel.Create(l));

            builder.HasMany(pl => pl.Items)
                .WithOne(pi => pi.PackingList);
        }
    }
}
