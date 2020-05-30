﻿using System;
using System.Linq;
using LaDanse.Source;
using LaDanse.Target;
using LaDanse.Target.Entities.CharacterClaims;
using Migration.KeyMappers.CharacterClaims;
using Migration.KeyMappers.GameData.Characters;
using Migration.KeyMappers.Identity;

namespace Migration.Migrations.CharacterClaims
{
    public class GameCharacterClaimMigration : BaseMigration
    {
        private readonly UserKeyMapper _userKeyMapper;
        private readonly GameCharacterKeyMapper _gameCharacterKeyMapper;
        private readonly GameCharacterClaimKeyMapper _gameCharacterClaimKeyMapper;

        public GameCharacterClaimMigration(
            SourceDbContext sourceDbContext, TargetDbContext targetDbContext,
            UserKeyMapper userKeyMapper,
            GameCharacterKeyMapper gameCharacterKeyMapper,
            GameCharacterClaimKeyMapper gameCharacterClaimKeyMapper)
            : base(sourceDbContext, targetDbContext)
        {
            _userKeyMapper = userKeyMapper;
            _gameCharacterKeyMapper = gameCharacterKeyMapper;
            _gameCharacterClaimKeyMapper = gameCharacterClaimKeyMapper;
        }
        
        public override void Migrate()
        {
            var claims = SourceDbContext.CharacterClaims.ToList();

            foreach (var claim in claims)
            {
                var newClaim = new GameCharacterClaim()
                {
                    Id = _gameCharacterClaimKeyMapper.MapKey(claim.Id), 
                    FromTime = claim.FromTime, 
                    EndTime = claim.EndTime, 
                    UserId = _userKeyMapper.MapKey(claim.AccountId),
                    GameCharacterId = _gameCharacterKeyMapper.MapKey(claim.CharacterId)
                };

                TargetDbContext.GameCharacterClaims.Add(newClaim);
            }

            TargetDbContext.SaveChanges();
        }
    }
}