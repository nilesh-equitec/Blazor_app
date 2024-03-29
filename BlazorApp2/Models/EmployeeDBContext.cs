﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Models;

public partial class EmployeeDBContext : DbContext
{
    public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Emp> Emps { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Emp>(entity =>
        {
            entity.ToTable("Emp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Gender)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("gender");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("((1))")
                .HasColumnName("isactive");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.Skill)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("skill");
        });

        OnModelCreatingGeneratedProcedures(modelBuilder);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}