﻿using Destiny.Core.Flow.Model.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Destiny.Core.Flow.Model.EntityConfigurations
{
    public class UserClaimConfiguration : EntityMappingConfiguration<UserClaim, Guid>
    {
        public override void Map(EntityTypeBuilder<UserClaim> b)
        {
            b.HasKey(o => o.Id);
            b.Property(o => o.IsDeleted).HasDefaultValue(false);
            b.Property(o => o.UserId);
            b.ToTable("UserClaim");
        }
    }
}