﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectOp.Context;

namespace ProjectOp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200514160813_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectOp.Entities.Achievement", b =>
                {
                    b.Property<int>("AchievementID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("achieve")
                        .HasColumnType("NVARCHAR(300)");

                    b.HasKey("AchievementID");

                    b.HasIndex("UserId");

                    b.ToTable("achievements");
                });

            modelBuilder.Entity("ProjectOp.Entities.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("department")
                        .HasColumnType("NVARCHAR(300)");

                    b.Property<string>("image1")
                        .HasColumnType("NVARCHAR(300)");

                    b.Property<string>("image2")
                        .HasColumnType("NVARCHAR(300)");

                    b.Property<string>("name")
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("nationality")
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("quote")
                        .HasColumnType("NVARCHAR(300)");

                    b.HasKey("UserID");

                    b.ToTable("users");
                });

            modelBuilder.Entity("ProjectOp.Entities.Achievement", b =>
                {
                    b.HasOne("ProjectOp.Entities.User", "User")
                        .WithMany("achievements")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
