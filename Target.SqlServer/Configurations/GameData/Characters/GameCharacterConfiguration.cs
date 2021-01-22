﻿using LaDanse.Target.Entities.GameData.Characters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Target.SqlServer.Configurations.GameData.Characters
{
    public class GameCharacterConfiguration : IEntityTypeConfiguration<GameCharacter>
    {
        public void Configure(EntityTypeBuilder<GameCharacter> builder)
        {
            builder.ToTable("GameCharacter");

            builder.HasIndex(e => e.GameRealmId)
                .HasDatabaseName("IDX_92AF3B34FA96DBDA");

            builder.HasGuidKey();

            builder.TimeVersioned();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasUtf8ColumnType(SqlServerBuilderTypes.String(255));

            builder.Property(e => e.GameRealmId)
                .HasColumnName("gameRealmId")
                .HasForeignKeyColumnType();
            builder.HasOne(d => d.GameRealm)
                .WithMany()
                .HasForeignKey(d => d.GameRealmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_92AF3B34FA96DBDA");
        }
    }
}
