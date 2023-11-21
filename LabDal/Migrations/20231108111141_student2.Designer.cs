﻿// <auto-generated />
using System;
using LabDal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LabDal.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20231108111141_student2")]
    partial class student2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LabDal.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("RelatedToStudentStudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RelatedToStudentStudentId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("LabDal.Courses", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"), 1L, 1);

                    b.Property<int?>("ManyStudentCourseId")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("ManyStudentCourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("LabDal.ManyStudent", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"), 1L, 1);

                    b.HasKey("CourseId");

                    b.ToTable("ManyStudents");
                });

            modelBuilder.Entity("LabDal.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<int?>("CoursesCourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentName")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("CoursesCourseId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LabDal.Company", b =>
                {
                    b.HasOne("LabDal.Student", "RelatedToStudent")
                        .WithMany()
                        .HasForeignKey("RelatedToStudentStudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RelatedToStudent");
                });

            modelBuilder.Entity("LabDal.Courses", b =>
                {
                    b.HasOne("LabDal.ManyStudent", null)
                        .WithMany("ManyStudents")
                        .HasForeignKey("ManyStudentCourseId");
                });

            modelBuilder.Entity("LabDal.Student", b =>
                {
                    b.HasOne("LabDal.Courses", null)
                        .WithMany("Students")
                        .HasForeignKey("CoursesCourseId");
                });

            modelBuilder.Entity("LabDal.Courses", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("LabDal.ManyStudent", b =>
                {
                    b.Navigation("ManyStudents");
                });
#pragma warning restore 612, 618
        }
    }
}
