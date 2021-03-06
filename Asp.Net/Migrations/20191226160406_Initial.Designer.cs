﻿// <auto-generated />
using System;
using Kursach.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kursach.Migrations
{
    [DbContext(typeof(DocumentsDbContext))]
    [Migration("20191226160406_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kursach.Data.Entities.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department_name");

                    b.Property<int>("TypeOfDocumentId");

                    b.HasKey("DepartmentId");

                    b.HasIndex("TypeOfDocumentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Kursach.Data.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId");

                    b.Property<int>("PositionId");

                    b.Property<string>("employee_name");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PositionId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Kursach.Data.Entities.Input_Documents", b =>
                {
                    b.Property<int>("Input_DocumentsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Access_Level");

                    b.Property<int>("ApproverEmployeeId");

                    b.Property<DateTime?>("Data_register");

                    b.Property<DateTime?>("DeadLine");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("FileHref");

                    b.Property<string>("Status");

                    b.Property<int?>("TypeId");

                    b.HasKey("Input_DocumentsId");

                    b.HasIndex("ApproverEmployeeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("TypeId");

                    b.ToTable("input_Documents");
                });

            modelBuilder.Entity("Kursach.Data.Entities.Interior_Document", b =>
                {
                    b.Property<int>("Interior_DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ExecutorEmployeeId");

                    b.Property<int?>("ApproverEmployeeId");

                    b.Property<int?>("Access_Level");

                    b.Property<DateTime?>("Data_register");

                    b.Property<DateTime?>("DeadLine");

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("FileHref");

                    b.Property<string>("Status");

                    b.Property<int>("TypeId");

                    b.HasKey("Interior_DocumentId", "ExecutorEmployeeId", "ApproverEmployeeId");

                    b.HasAlternateKey("Interior_DocumentId");

                    b.HasIndex("ApproverEmployeeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ExecutorEmployeeId");

                    b.HasIndex("TypeId");

                    b.ToTable("Interior_Documents");
                });

            modelBuilder.Entity("Kursach.Data.Entities.Output_Documents", b =>
                {
                    b.Property<int>("Output_DocumentsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Access_Level");

                    b.Property<DateTime?>("Data_register");

                    b.Property<DateTime?>("Date_of_Execution");

                    b.Property<int>("DepartmentId");

                    b.Property<int>("ExecutorEmployeeId");

                    b.Property<string>("FileHref");

                    b.Property<string>("Status");

                    b.Property<int?>("TypeId");

                    b.HasKey("Output_DocumentsId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ExecutorEmployeeId");

                    b.HasIndex("TypeId");

                    b.ToTable("Output_Documents");
                });

            modelBuilder.Entity("Kursach.Data.Entities.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccessLevel");

                    b.Property<string>("Name_of_position");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Kursach.Data.Entities.TypeOfDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("type_name");

                    b.HasKey("Id");

                    b.ToTable("TypeOfDocuments");
                });

            modelBuilder.Entity("Kursach.Data.Entities.Department", b =>
                {
                    b.HasOne("Kursach.Data.Entities.TypeOfDocument", "type")
                        .WithMany("departments")
                        .HasForeignKey("TypeOfDocumentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kursach.Data.Entities.Employee", b =>
                {
                    b.HasOne("Kursach.Data.Entities.Department", "employee_department")
                        .WithMany("employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kursach.Data.Entities.Position", "employee_position")
                        .WithMany("employees")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kursach.Data.Entities.Input_Documents", b =>
                {
                    b.HasOne("Kursach.Data.Entities.Employee", "Approver")
                        .WithMany("input_Documents")
                        .HasForeignKey("ApproverEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kursach.Data.Entities.Department", "department")
                        .WithMany("input_Documents")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kursach.Data.Entities.TypeOfDocument", "Type")
                        .WithMany("input_Documents")
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("Kursach.Data.Entities.Interior_Document", b =>
                {
                    b.HasOne("Kursach.Data.Entities.Employee", "ApproverEmployee")
                        .WithMany("interior_Documents_approver")
                        .HasForeignKey("ApproverEmployeeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Kursach.Data.Entities.Department", "department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("Kursach.Data.Entities.Employee", "ExecutorEmployee")
                        .WithMany("interior_Documents_executor")
                        .HasForeignKey("ExecutorEmployeeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Kursach.Data.Entities.TypeOfDocument", "Type")
                        .WithMany("interior_Documents")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kursach.Data.Entities.Output_Documents", b =>
                {
                    b.HasOne("Kursach.Data.Entities.Department", "department")
                        .WithMany("output_Documents")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kursach.Data.Entities.Employee", "Executor")
                        .WithMany("output_Documents")
                        .HasForeignKey("ExecutorEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kursach.Data.Entities.TypeOfDocument", "Type")
                        .WithMany("output_Documents")
                        .HasForeignKey("TypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
