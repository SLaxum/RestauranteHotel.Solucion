﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteHotel.Domain.Base
{
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        public virtual T Id { get; }
    }
}
