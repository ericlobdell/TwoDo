using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TwoDo.Data;

namespace TwoDo.Migrations
{
    [DbContext(typeof(TwoDoContext))]
    [Migration("20170430183543_Create_TwoDoDb_Migration")]
    partial class Create_TwoDoDb_Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
