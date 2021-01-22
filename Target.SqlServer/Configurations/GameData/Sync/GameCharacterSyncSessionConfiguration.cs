﻿using LaDanse.Target.Entities.GameData.Sync;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Target.SqlServer.Configurations.GameData.Sync
{
    public class GameCharacterSyncSessionConfiguration : IEntityTypeConfiguration<GameCharacterSyncSession>
    {
        public void Configure(EntityTypeBuilder<GameCharacterSyncSession> builder)
        {
            builder.ToTable("GameCharacterSyncSession");

            builder.HasIndex(e => e.GameCharacterSourceId)
                .HasDatabaseName("IDX_EC73362CDD71BB");

            builder.HasGuidKey();

            builder.Property(e => e.FromTime)
                .IsRequired()
                .HasColumnName("fromTime")
                .HasColumnType(SqlServerBuilderTypes.DateTime);
                
            builder.Property(e => e.EndTime)
                .HasColumnName("endTime")
                .HasColumnType(SqlServerBuilderTypes.DateTime);

            builder.Property(e => e.Log)
                .HasColumnName("log")
                .HasUtf8ColumnType(SqlServerBuilderTypes.LongText);

            builder.Property(e => e.GameCharacterSourceId)
                .HasColumnName("gameCharacterSourceId")
                .HasForeignKeyColumnType();
            builder.HasOne(d => d.GameCharacterSource)
                .WithMany()
                .HasForeignKey(d => d.GameCharacterSourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EC73362CDD71BB");
        }
    }
}