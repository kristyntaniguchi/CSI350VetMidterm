﻿// <auto-generated />
using System;
using CSI350VetMidterm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CSI350VetMidterm.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240520062437_addPatientSeedImages")]
    partial class addPatientSeedImages
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CSI350VetMidterm.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalHistory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medications")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 9,
                            Breed = "Plott Hound",
                            ImgURL = "https://pbs.twimg.com/media/GOAF_fSa8AAF6yl?format=jpg&name=large",
                            MedicalHistory = "Up to date on vaccinations. Seperation anxiety. Whines after meal times because he is so sad that his food is all gone",
                            Medications = "NexGuard, HeartGuard, Cosequin",
                            Name = "Max",
                            Species = "Canine"
                        },
                        new
                        {
                            Id = 2,
                            Age = 8,
                            Breed = "Australian Cattle Dog / American Staffordshire Terrier",
                            ImgURL = "https://pbs.twimg.com/media/GOAF_fObQAE7eTW?format=jpg&name=large",
                            MedicalHistory = "Up to date on vaccinations. Prefers to be an only child",
                            Medications = "NexGuard, HeartGuard, Cosequin",
                            Name = "Elsie",
                            Species = "Canine"
                        },
                        new
                        {
                            Id = 3,
                            Age = 7,
                            Breed = "German Shepherd",
                            ImgURL = "https://pbs.twimg.com/media/GOAGL3DaQAAfWPz?format=jpg&name=large",
                            MedicalHistory = "Up to date on vaccinations. Autoimmune disorder. Extensive allergies",
                            Medications = "Pentoxifylline, NexGuard, HeartGuard, Prednisone, Cosequin, Immunotherapy injections ",
                            Name = "Lila",
                            Species = "Canine"
                        },
                        new
                        {
                            Id = 4,
                            Age = 5,
                            Breed = "Labrador Retriever",
                            ImgURL = "https://pbs.twimg.com/media/GOAHgqwbMAA3ODl?format=jpg&name=large",
                            MedicalHistory = "Up to date on vaccinations. Autoimmune disorder. Extensive allergies",
                            Medications = "NexGuard, HeartGuard, Cosequin, Immunotherapy injections",
                            Name = "Lucy",
                            Species = "Canine"
                        },
                        new
                        {
                            Id = 5,
                            Age = 4,
                            Breed = "Corgi",
                            ImgURL = "https://pbs.twimg.com/media/GOAGL3CasAAl78A?format=jpg&name=large",
                            MedicalHistory = "Up to date on vaccinations. Attitude issues. Wishes he was an only child",
                            Medications = "NexGuard, HeartGuard, Cosequin",
                            Name = "Gus",
                            Species = "Canine"
                        },
                        new
                        {
                            Id = 6,
                            Age = 3,
                            Breed = "English Labrador Retriever",
                            ImgURL = "https://pbs.twimg.com/media/GOAGj4tagAEcvkL?format=jpg&name=large",
                            MedicalHistory = "Up to date on vaccinations. Very wiggly, possibly made of Jell-O",
                            Medications = "NexGuard, HeartGuard, Cosequin",
                            Name = "Ellie",
                            Species = "Canine"
                        },
                        new
                        {
                            Id = 7,
                            Age = 1,
                            Breed = "Red Eared Slider",
                            ImgURL = "https://pbs.twimg.com/media/GOAF_fTaoAAsKtp?format=jpg&name=large",
                            MedicalHistory = "Healthy",
                            Medications = "N/A",
                            Name = "Lenny",
                            Species = "Chelonian"
                        },
                        new
                        {
                            Id = 8,
                            Age = 6,
                            Breed = "American Shorthair",
                            ImgURL = "https://pbs.twimg.com/media/GOAF_fTbcAANpk9?format=jpg&name=large",
                            MedicalHistory = "Upper respiratory virus. Heart murmur",
                            Medications = "Flea Preventative",
                            Name = "Rudy",
                            Species = "Feline"
                        },
                        new
                        {
                            Id = 9,
                            Age = 5,
                            Breed = "American Shorthair",
                            ImgURL = "https://pbs.twimg.com/media/GOAGL3CbUAAhgRf?format=jpg&name=large",
                            MedicalHistory = "Chews cardboard. Not fond of other cats. Cattitude",
                            Medications = "Flea Preventative",
                            Name = "Leo",
                            Species = "Feline"
                        },
                        new
                        {
                            Id = 10,
                            Age = 4,
                            Breed = "626",
                            ImgURL = "stitch",
                            MedicalHistory = "Genetically engineered, extraterrestrial life-form.",
                            Medications = "Coffee",
                            Name = "Stitch",
                            Species = "Experiment"
                        });
                });

            modelBuilder.Entity("CSI350VetMidterm.Models.Veterinarian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearsExperience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Veterinarians");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "Born and raised on Kauai, Nani is a compassionate veterinarian and cares deeply for animals. With her warm heart and gentle touch, she provides exceptional care to her patients, earning their trust and affection. Nani's dedication to animal welfare extends beyond the clinic as she volunteers to rescue and rehabilitate injured wildlife, making her a beloved figure in the veterinary community. In her free time, Nani enjoys surfing, spending time outdoors with her sister, Lilo, and hiking with their dog, Stitch.",
                            ImgURL = "https://64.media.tumblr.com/f1e99003c04ec93242249f0b1ebb9b9e/tumblr_pvsdy8OAVI1xqfmwso1_1280.png",
                            Name = "Nani Pelekai",
                            YearsExperience = 7
                        },
                        new
                        {
                            Id = 2,
                            Bio = "A Kauai native, David is a caring veterinarian with a deep love for animals. With his gentle touch and genuine compassion, he provides exceptional care to his patients, both in the clinic and in wildlife rescue efforts. In his free time, David enjoys surfing, snorkeling, and fire dancing.",
                            ImgURL = "https://img.buzzfeed.com/buzzfeed-static/static/2023-04/25/22/campaign_images/29eff9769411/the-role-of-david-in-the-live-action-lilo-stitch--3-1447-1682462498-0_dblbig.jpg?resize=1200:*",
                            Name = "David Kawena",
                            YearsExperience = 7
                        },
                        new
                        {
                            Id = 3,
                            Bio = "Prior to becoming a veterinarian, Cobra spent time working in law enforcement.  He approaches animal care with efficiency and professionalism. Despite his stern demeanor, he's deeply empathetic and dedicated to the well-being of all creatures, making him a respected figure in both the veterinary and conservation communities. Cobra enjoys spending his free time practicing martial arts, mentoring at-risk youth, listening to jazz music, and is also passionate about mosquito conservation. ",
                            ImgURL = "https://static1.cbrimages.com/wordpress/wp-content/uploads/2023/04/lilo-and-stirch-agent-cobra-bubbles.jpg",
                            Name = "Cobra Bubbles",
                            YearsExperience = 18
                        },
                        new
                        {
                            Id = 4,
                            Bio = "Born and raised on Kauai, Lilo has a passion helping for animals. She adopted her first dog, Stitch, when she was 6 years old.",
                            ImgURL = "https://akns-images.eonline.com/eol_images/Entire_Site/2023231/rs_1200x1200-230331155207-1200-lilo-stitch-shutterstock_editorial_384800f.jpg?fit=around%7C1200:1200&output-quality=90&crop=1200:1200",
                            Name = "Lilo Pelekai",
                            YearsExperience = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
