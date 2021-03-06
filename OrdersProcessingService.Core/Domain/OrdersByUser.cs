﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersProcessingService.Core.Domain
{
    public class OrdersByUser
    {
        public Guid UserId { get; set; }
        public IEnumerable<Guid> Orders { get; set; }
        public long TotalAmount { get; set; }
    }
}
