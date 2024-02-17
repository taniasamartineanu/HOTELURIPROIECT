﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hoteluri.Data;

#nullable disable

namespace hoteluri.Migrations
{
    [DbContext(typeof(hoteluriContext))]
    [Migration("20240210225333_Rezervari")]
    partial class Rezervari
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("hoteluri.Models.Camera", b =>
                {
                    b.Property<int>("CameraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CameraId"));

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("NumarCamera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CameraId");

                    b.HasIndex("HotelId");

                    b.ToTable("Camera");
                });

            modelBuilder.Entity("hoteluri.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("hoteluri.Models.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelId"));

                    b.Property<string>("Locatie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeHotel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelId");

                    b.ToTable("Hotel");
                });

            modelBuilder.Entity("hoteluri.Models.Rezervare", b =>
                {
                    b.Property<int>("RezervareId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RezervareId"));

                    b.Property<int>("CameraId")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCheckOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.HasKey("RezervareId");

                    b.HasIndex("CameraId");

                    b.HasIndex("ClientId");

                    b.HasIndex("HotelId");

                    b.ToTable("Rezervare");
                });

            modelBuilder.Entity("hoteluri.Models.Camera", b =>
                {
                    b.HasOne("hoteluri.Models.Hotel", null)
                        .WithMany("Camere")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("hoteluri.Models.Rezervare", b =>
                {
                    b.HasOne("hoteluri.Models.Camera", "Camera")
                        .WithMany()
                        .HasForeignKey("CameraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hoteluri.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hoteluri.Models.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Camera");

                    b.Navigation("Client");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("hoteluri.Models.Hotel", b =>
                {
                    b.Navigation("Camere");
                });
#pragma warning restore 612, 618
        }
    }
}
