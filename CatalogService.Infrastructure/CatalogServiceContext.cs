﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogService.Application.Common.Interfaces;
using CatalogService.Domain.Aggregates;
using CatalogService.Infrastructure.Configurations;


namespace CatalogService.Infrastructure
{
    public class CatalogServiceContext : DbContext, ICatalogServiceContext
    {       
        public DbSet<Book> Books { get; set; }

        public CatalogServiceContext(DbContextOptions<CatalogServiceContext> options)
            : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Username=postgres; Password=1; Database=Library");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BookConfig());
            base.OnModelCreating(builder);
        }
        public void Migrate()
        {
            Database.Migrate();
        }



    }
}