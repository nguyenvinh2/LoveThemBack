﻿// <auto-generated />
using LoveThemBackWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoveThemBackWebApp.Migrations
{
    [DbContext(typeof(LTBDBContext))]
    [Migration("20181108180034_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LoveThemBackWebApp.Models.Favorite", b =>
                {
                    b.Property<int>("UserID");

                    b.Property<int>("PetID");

                    b.Property<string>("Notes");

                    b.HasKey("UserID", "PetID");

                    b.ToTable("Favorites");

                    b.HasData(
                        new { UserID = 1, PetID = 1, Notes = "notes 1" },
                        new { UserID = 1, PetID = 2, Notes = "notes 2" }
                    );
                });

            modelBuilder.Entity("LoveThemBackWebApp.Models.Profile", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LocationZip");

                    b.Property<string>("Username");

                    b.HasKey("UserID");

                    b.ToTable("Profiles");

                    b.HasData(
                        new { UserID = 1, LocationZip = 98144, Username = "username1" },
                        new { UserID = 2, LocationZip = 98144, Username = "username2" }
                    );
                });

            modelBuilder.Entity("LoveThemBackWebApp.Models.Favorite", b =>
                {
                    b.HasOne("LoveThemBackWebApp.Models.Profile", "Profile")
                        .WithMany("Favorites")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
