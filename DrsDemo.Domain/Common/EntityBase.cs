﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Domain.Common
{
    public abstract class EntityBase<TKey> : IEntity
    {
        public TKey Id { get; protected set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public DateTime? UpdatedTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
