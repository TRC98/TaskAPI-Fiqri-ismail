﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskAPI.DataAccess;

namespace TaskAPI.DataAccess.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    partial class TodoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2022, 4, 3, 23, 13, 3, 78, DateTimeKind.Local).AddTicks(4009),
                            Description = "Get some text books for school",
                            Due = new DateTime(2022, 4, 8, 23, 13, 3, 78, DateTimeKind.Local).AddTicks(9914),
                            Status = 0,
                            Title = "Get books for school - DB"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}