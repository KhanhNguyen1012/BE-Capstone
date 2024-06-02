﻿using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class UnitOfMeasurement
    {
        public UnitOfMeasurement()
        {
            Foods = new HashSet<Food>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime CreateAt { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
    }
}
