﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using car_app.Models;

namespace car_app.DataBase
{
    class DatabaseRepository: DbContext

    {
        public DbSet<Customer> Customers { get; set; }

    }
}
