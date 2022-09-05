﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InsuranceWebApi
{
    public partial class insuranceContext : DbContext
    {
        public insuranceContext()
        {
        }

        public insuranceContext(DbContextOptions<insuranceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AppliedPolicy> AppliedPolicies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<policy> policies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-M8PSQIS\\SQLEXPRESS;Initial Catalog=insurance;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppliedPolicy>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__AppliedP__C93A4C99284AC5F9");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.AppliedPolicies)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__AppliedPo__CustI__52593CB8");

                entity.HasOne(d => d.PidNavigation)
                    .WithMany(p => p.AppliedPolicies)
                    .HasForeignKey(d => d.Pid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__AppliedPoli__Pid__5165187F");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK__Customer__049E3AA96EAD34A7");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasKey(e => e.sno)
                    .HasName("PK__Question__DDDF6446EC9B7693");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Questions__CustI__5CD6CB2B");
            });

            modelBuilder.Entity<policy>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__policies__C570593814B2890E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}