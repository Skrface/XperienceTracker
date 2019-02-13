using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using XpTracker.Backend.Core.Model;

namespace XpTracker.Backend.Core.DataMapper
{
    internal class TechnologyMap
    {
        public TechnologyMap(EntityTypeBuilder<Technology> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            //entityBuilder.Property(t => t.FrameworkDisplayText).HasColumnType(Constants.EF.NVARCHAR_LENGTH_CODE);
            //entityBuilder.Property(t => t.UserUpn).HasColumnType(Constants.EF.NVARCHAR_LENGTH_CODE);
        }
    }
}
