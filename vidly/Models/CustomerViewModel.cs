﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidlyDbContext;
using vidlyDbContext.Entities;

namespace vidly.Models
{
    public class CustomerViewModel : Customer
    {
        public Customer Customer { get; set; }
    }
}