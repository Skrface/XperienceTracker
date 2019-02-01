using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace XpTracker.Backend.Core.Model.Common
{
    internal interface IEntity<T>
    {
        T Id { get; set; }
    }

    internal abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual T Id { get; set; }
    }
}
