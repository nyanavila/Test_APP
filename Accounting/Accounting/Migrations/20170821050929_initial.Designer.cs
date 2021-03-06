﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Accounting.Models;

namespace Accounting.Migrations
{
    [DbContext(typeof(GeneralJournalContext))]
    [Migration("20170821050929_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Accounting.Models.GeneralJournal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Credit");

                    b.Property<DateTime>("Date");

                    b.Property<decimal>("Debit");

                    b.Property<string>("Description");

                    b.Property<string>("PostRef");

                    b.HasKey("ID");

                    b.ToTable("GeneralJournal");
                });
        }
    }
}
