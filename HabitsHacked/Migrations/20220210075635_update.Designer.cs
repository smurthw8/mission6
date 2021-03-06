// <auto-generated />
using System;
using HabitsHacked.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HabitsHacked.Migrations
{
    [DbContext(typeof(TaskInfoContext))]
    [Migration("20220210075635_update")]
    partial class update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("HabitsHacked.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Home"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "School"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Work"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Church"
                        });
                });

            modelBuilder.Entity("HabitsHacked.Models.TaskFormResponse", b =>
                {
                    b.Property<int>("TaskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quadrant")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TaskID");

                    b.HasIndex("CategoryID");

                    b.ToTable("TaskResponses");

                    b.HasData(
                        new
                        {
                            TaskID = 1,
                            CategoryID = 2,
                            Completed = true,
                            DueDate = new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quadrant = "Quadrant 1",
                            TaskName = "Mission 6"
                        },
                        new
                        {
                            TaskID = 2,
                            CategoryID = 1,
                            Completed = false,
                            DueDate = new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quadrant = "Quadrant 2",
                            TaskName = "Feed the Dog"
                        },
                        new
                        {
                            TaskID = 3,
                            CategoryID = 4,
                            Completed = false,
                            DueDate = new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quadrant = "Quadrant 3",
                            TaskName = "Call Stake President"
                        },
                        new
                        {
                            TaskID = 4,
                            CategoryID = 1,
                            Completed = true,
                            DueDate = new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quadrant = "Quadrant 4",
                            TaskName = "Watch New Girl"
                        },
                        new
                        {
                            TaskID = 5,
                            CategoryID = 3,
                            Completed = true,
                            DueDate = new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quadrant = "Quadrant 2",
                            TaskName = "Weekly Work Meeting"
                        });
                });

            modelBuilder.Entity("HabitsHacked.Models.TaskFormResponse", b =>
                {
                    b.HasOne("HabitsHacked.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
