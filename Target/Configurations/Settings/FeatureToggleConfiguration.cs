﻿using LaDanse.Target.Entities.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LaDanse.Target.Configurations.Settings
{
    public class FeatureToggleConfiguration : IEntityTypeConfiguration<FeatureToggle>
    {
        public void Configure(EntityTypeBuilder<FeatureToggle> builder)
        {
            builder.ToTable("FeatureToggle");

            builder.HasIndex(e => e.ToggleForId)
                .HasName("IDX_D25E05DD612E729E");

            builder.HasGuidKey();

            builder.Property(e => e.Feature)
                .IsRequired()
                .HasColumnName("feature")
                .HasUtf8ColumnType(MySqlBuilderTypes.String(255));

            builder.Property(e => e.Toggle)
                .HasColumnName("toggle");

            builder.Property(e => e.ToggleForId)
                .HasColumnName("toggleForId")
                .HasForeignKeyColumnType();
            builder.HasOne(d => d.ToggleFor)
                .WithMany()
                .HasForeignKey(d => d.ToggleForId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D25E05DD612E729E");
        }
    }
}
