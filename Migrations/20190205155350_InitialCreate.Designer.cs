﻿// <auto-generated />
using System;
using EfCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ProjectTo_Issue.Migrations
{
    [DbContext(typeof(MyAppContext))]
    [Migration("20190205155350_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("EFCore.Models.Cat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CatBreedId");

                    b.Property<string>("CreatedByDisplayName")
                        .IsRequired();

                    b.Property<string>("CreatedByWUPeopleId")
                        .IsRequired();

                    b.Property<DateTime>("CreatedOnUtc");

                    b.Property<int>("MeowLoudness");

                    b.Property<string>("UpdatedByDisplayName")
                        .IsRequired();

                    b.Property<string>("UpdatedByWUPeopleId")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedOnUtc");

                    b.HasKey("Id");

                    b.HasIndex("CatBreedId");

                    b.ToTable("Cat");
                });

            modelBuilder.Entity("EFCore.Models.CatBreed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BreedName");

                    b.Property<string>("CreatedByDisplayName");

                    b.Property<string>("CreatedByWUPeopleId");

                    b.Property<DateTime>("CreatedOnUtc");

                    b.Property<string>("UpdatedByDisplayName");

                    b.Property<string>("UpdatedByWUPeopleId");

                    b.Property<DateTime>("UpdatedOnUtc");

                    b.HasKey("Id");

                    b.ToTable("CatBreed");
                });

            modelBuilder.Entity("EFCore.Models.GenericAudit", b =>
                {
                    b.Property<int>("GenericAuditId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action")
                        .IsRequired();

                    b.Property<string>("AuditData")
                        .IsRequired();

                    b.Property<DateTime>("AuditDateUtc");

                    b.Property<string>("AuditIdentity")
                        .IsRequired();

                    b.Property<string>("AuditIdentityDisplayName")
                        .IsRequired();

                    b.Property<string>("CorrelationId")
                        .IsRequired();

                    b.Property<string>("EntityType")
                        .IsRequired();

                    b.Property<string>("ErrorMessage");

                    b.Property<int>("MSDuration");

                    b.Property<int>("NumObjectsEffected");

                    b.Property<string>("PrimaryKey")
                        .IsRequired();

                    b.Property<bool>("Success");

                    b.HasKey("GenericAuditId");

                    b.ToTable("GenericAudit");
                });

            modelBuilder.Entity("EFCore.Models.Cat", b =>
                {
                    b.HasOne("EFCore.Models.CatBreed", "Breed")
                        .WithMany("Cats")
                        .HasForeignKey("CatBreedId");
                });
#pragma warning restore 612, 618
        }
    }
}
