﻿// <auto-generated />
using MemoTime.Infrastructure.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace MemoTime.Api.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20171217133204_tasks_added")]
    partial class tasks_added
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MemoTime.Core.Domain.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DueDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("MemoTime.Core.Domain.TodoTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("DueDate");

                    b.Property<string>("Label");

                    b.Property<string>("Name");

                    b.Property<string>("Priority");

                    b.Property<Guid>("ProjectId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("MemoTime.Core.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("Salt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MemoTime.Core.Domain.TodoTask", b =>
                {
                    b.HasOne("MemoTime.Core.Domain.Project")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
