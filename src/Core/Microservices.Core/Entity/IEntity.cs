﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Core.Entity
{
    internal interface IEntity<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
        public DateTime Created { get; set; }
    }
}
