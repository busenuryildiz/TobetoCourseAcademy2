﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Course:Entity<int>
{
    public string Name { get; set; }
   // public decimal UnitPrice { get; set; }
    public string Description { get; set; }
    
    public int CategoryId { get; set; }

}
