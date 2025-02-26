﻿using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.EntityMapper
{
    public class EmployeeDetailsMapper : IEntityTypeConfiguration<EmployeeDetails>
    {
        public void Configure(EntityTypeBuilder<EmployeeDetails> builder)
        {
            builder.HasKey(x => x.EmployeeId).HasName("pk_employeeid");
            builder.Property(x => x.EmployeeId).ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("UUID");

            builder.Property(x => x.Title)
             .HasColumnName("Title")
             .HasColumnType("VARCHAR(15)");

            builder.Property(x => x.FirstName)
              .HasColumnName("FirstName")
              .HasColumnType("VARCHAR(50)");

            builder.Property(x => x.LastName)
             .HasColumnName("LastName")
             .HasColumnType("VARCHAR(50)");

            builder.Property(x => x.DateOfBirth)
             .HasColumnName("DateOfBirth")
             .HasColumnType("DATE");

            builder.Property(x => x.Contact)
             .HasColumnName("Contact")
             .HasColumnType("BIGINT");

            builder.Property(x => x.Specialization)
              .HasColumnName("Specialization")
              .HasColumnType("VARCHAR(50)");

            builder.Property(x => x.Email)
             .HasColumnName("Email")
             .HasColumnType("CHARACTER VARYING");

            builder.Property(x => x.CreatedOn)
             .HasColumnName("CreatedOn")
             .HasColumnType("TIMESTAMP");

            builder.Property(x => x.RoleId)
            .HasColumnName("RoleId")
            .HasColumnType("UUID");

            builder.Property(x => x.UserId)
            .HasColumnName("UserId")
            .HasColumnType("UUID");

            builder.Property(x => x.IsActive)
           .HasColumnName("IsActive")
           .HasColumnType("BOOLEAN");


        }
    }
}
