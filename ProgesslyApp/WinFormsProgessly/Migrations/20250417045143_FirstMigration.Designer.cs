﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsProgessly.Data;

#nullable disable

namespace WinFormsProgessly.Migrations
{
    [DbContext(typeof(ProgesslyContext))]
    [Migration("20250417045143_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WinFormsProgessly.Entities.ProjectModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idResponsable")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("idResponsable")
                        .IsUnique()
                        .HasFilter("[idResponsable] IS NOT NULL");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("WinFormsProgessly.Entities.ResponsableModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idProject")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Responsables");
                });

            modelBuilder.Entity("WinFormsProgessly.Entities.TareaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StarDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idProject")
                        .HasColumnType("int");

                    b.Property<int?>("idResponsable")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("idResponsable");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("WinFormsProgessly.Entities.ProjectModel", b =>
                {
                    b.HasOne("WinFormsProgessly.Entities.ResponsableModel", "Responsable")
                        .WithOne("Project")
                        .HasForeignKey("WinFormsProgessly.Entities.ProjectModel", "idResponsable");

                    b.Navigation("Responsable");
                });

            modelBuilder.Entity("WinFormsProgessly.Entities.TareaModel", b =>
                {
                    b.HasOne("WinFormsProgessly.Entities.ProjectModel", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WinFormsProgessly.Entities.ResponsableModel", "Responsable")
                        .WithMany()
                        .HasForeignKey("idResponsable");

                    b.Navigation("Project");

                    b.Navigation("Responsable");
                });

            modelBuilder.Entity("WinFormsProgessly.Entities.ResponsableModel", b =>
                {
                    b.Navigation("Project")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
