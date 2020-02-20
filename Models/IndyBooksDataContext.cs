﻿using System;
using Microsoft.EntityFrameworkCore;

namespace IndyBooks.Models
{
    public class IndyBooksDataContext:DbContext
    {
        public IndyBooksDataContext(DbContextOptions<IndyBooksDataContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        //Access to Collections representing DB tables
        public DbSet<Book> Books { get; set; }


        /*/ Used to fine tune certain aspects of the Data model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
        }*/
    }
}
