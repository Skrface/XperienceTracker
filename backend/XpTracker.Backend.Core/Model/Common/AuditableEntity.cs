using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace XpTracker.Backend.Core.Model.Common
{
    internal interface IAuditableEntity
    {
        DateTime CreatedDate { get; set; }

        string CreatedBy { get; set; }

        DateTime UpdatedDate { get; set; }

        string UpdatedBy { get; set; }
    }

    internal abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity
    {
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = Constants.EF.NVARCHAR_LENGTH_CODE)]
        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Column(TypeName = Constants.EF.NVARCHAR_LENGTH_CODE)]
        public string UpdatedBy { get; set; }
    }
}
