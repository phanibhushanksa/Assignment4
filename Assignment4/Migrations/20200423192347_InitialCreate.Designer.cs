﻿// <auto-generated />
using System;
using Assignment4.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment4.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200423192347_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment4.Models.EF_Models+Applications", b =>
                {
                    b.Property<string>("StudentEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Major")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("University")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentEmail");

                    b.HasIndex("StudentName");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("Assignment4.Models.EF_Models+LogIn", b =>
                {
                    b.Property<string>("email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("email");

                    b.ToTable("LogIn");
                });

            modelBuilder.Entity("Assignment4.Models.EF_Models+Results", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("accCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("schoolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("schoolUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("schoolZip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("studentSize")
                        .HasColumnType("int");

                    b.Property<int?>("tuitionOutState")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("Assignment4.Models.EF_Models+Student", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("contact")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Assignment4.Models.EF_Models+Applications", b =>
                {
                    b.HasOne("Assignment4.Models.EF_Models+Student", null)
                        .WithMany("applications")
                        .HasForeignKey("StudentName");
                });
#pragma warning restore 612, 618
        }
    }
}