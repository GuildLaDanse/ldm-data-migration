﻿using LaDanse.Target.Entities.GameData.Characters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LaDanse.Target.Configurations.GameData.Characters
{
    public class GameGuildConfiguration : IEntityTypeConfiguration<GameGuild>
    {
        public void Configure(EntityTypeBuilder<GameGuild> builder)
        {
            builder.ToTable("GameGuild");

            builder.HasIndex(e => e.GameRealmId)
                .HasName("IDX_B48152AFFA96DBDA");

            builder.HasGuidKey();

            builder.Property(e => e.GameId)
                .IsRequired()
                .HasColumnName("gameId")
                .HasColumnType(MySqlBuilderTypes.UnsignedInt);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasUtf8ColumnType(MySqlBuilderTypes.String(100));

            builder.Property(e => e.GameRealmId)
                .HasColumnName("gameRealmId")
                .HasForeignKeyColumnType();
            builder.HasOne(d => d.GameRealm)
                .WithMany()
                .HasForeignKey(d => d.GameRealmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_B48152AFFA96DBDA");
        }
    }
}