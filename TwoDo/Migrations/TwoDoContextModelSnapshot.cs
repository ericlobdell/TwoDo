using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TwoDo.Data;

namespace TwoDo.Migrations
{
    [DbContext(typeof(TwoDoContext))]
    partial class TwoDoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("TwoDo.StandardLib.Models.ToDoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Complete");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Expires");

                    b.Property<string>("Name");

                    b.Property<bool>("Postponed");

                    b.HasKey("Id");

                    b.ToTable("ToDos");
                });
        }
    }
}
