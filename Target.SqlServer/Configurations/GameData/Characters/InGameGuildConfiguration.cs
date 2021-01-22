﻿using LaDanse.Target.Entities.GameData.Characters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Target.SqlServer.Configurations.GameData.Characters
{
    public class InGameGuildConfiguration : IEntityTypeConfiguration<InGameGuild>
    {
        public void Configure(EntityTypeBuilder<InGameGuild> builder)
        {
            builder.ToTable("InGameGuild");

            builder.HasIndex(e => e.GameCharacterId)
                .HasDatabaseName("IDX_CA2244C5AF690F3");

            builder.HasIndex(e => e.GameGuildId)
                .HasDatabaseName("IDX_CA2244C75407DAB");

            builder.HasGuidKey();

            builder.TimeVersioned();

            builder.Property(e => e.GameCharacterId)
                .HasColumnName("gameCharacterId")
                .HasForeignKeyColumnType();
            builder.HasOne(d => d.GameCharacter)
                .WithMany()
                .HasForeignKey(d => d.GameCharacterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CA2244C5AF690F3");

            builder.Property(e => e.GameGuildId)
                .HasColumnName("gameGuildId")
                .HasForeignKeyColumnType();
            builder.HasOne(d => d.GameGuild)
                .WithMany()
                .HasForeignKey(d => d.GameGuildId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CA2244C75407DAB");
        }
    }
}
