﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database = ReCapProject;Trusted_Connection=True ");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet <Brand> Brands { get; set; }
        public DbSet<Color> Colors  { get; set; }
    }
}
