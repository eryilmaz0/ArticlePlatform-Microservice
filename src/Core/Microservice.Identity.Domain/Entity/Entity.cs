﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Identity.Domain.Entity
{
    public class Entity<TId> : IEntity<TId>
    {
        public TId Id { get; set; }
        public DateTime Created { get; set; }
    }
}
