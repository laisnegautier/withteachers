﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineEducation.Data;

namespace OnlineEducation.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
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

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OnlineEducation.Data.Models.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOngoing")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ScheduledFor")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("TimeSpan")
                        .HasColumnType("time");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ActivityId");

                    b.HasIndex("UserId");

                    b.ToTable("Activities");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Activity");
                });

            modelBuilder.Entity("OnlineEducation.Data.Models.SignalRConnection", b =>
                {
                    b.Property<int>("SignalRConnectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Connected")
                        .HasColumnType("bit");

                    b.Property<string>("ConnectionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserAgent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VideoconferenceUserId")
                        .HasColumnType("int");

                    b.HasKey("SignalRConnectionId");

                    b.HasIndex("VideoconferenceUserId");

                    b.ToTable("SignalRConnections");
                });

            modelBuilder.Entity("OnlineEducation.Data.Models.VideoconferenceUser", b =>
                {
                    b.Property<int>("VideoconferenceUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("VideoconferenceActivityId")
                        .HasColumnType("int");

                    b.HasKey("VideoconferenceUserId");

                    b.HasIndex("UserId1");

                    b.HasIndex("VideoconferenceActivityId");

                    b.ToTable("VideoconferenceUsers");
                });

            modelBuilder.Entity("OnlineEducation.Data.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<bool>("IsAnonymous")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pseudo")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("OnlineEducation.Data.Models.Videoconference", b =>
                {
                    b.HasBaseType("OnlineEducation.Data.Models.Activity");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomId")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Videoconference");

                    b.HasData(
                        new
                        {
                            ActivityId = 1,
                            CreationDate = new DateTime(2020, 3, 24, 4, 45, 19, 0, DateTimeKind.Unspecified),
                            Description = "You have to follow now",
                            IsCompleted = false,
                            IsOngoing = true,
                            ScheduledFor = new DateTime(2020, 7, 30, 16, 1, 56, 173, DateTimeKind.Local).AddTicks(9415),
                            TimeSpan = new TimeSpan(0, 2, 30, 0, 0),
                            Title = "Course of Mathematics",
                            UserId = "5925d79e-5ed1-4e19-ae1f-8ef0e4474cad",
                            Password = "SOIT",
                            RoomId = "course-of-mathXBZ"
                        },
                        new
                        {
                            ActivityId = 2,
                            CreationDate = new DateTime(2019, 3, 24, 4, 45, 19, 0, DateTimeKind.Unspecified),
                            Description = "Goodbye Ornald",
                            IsCompleted = true,
                            IsOngoing = false,
                            ScheduledFor = new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeSpan = new TimeSpan(0, 1, 0, 0, 0),
                            Title = "Video already passed",
                            UserId = "5925d79e-5ed1-4e19-ae1f-8ef0e4474cad",
                            Password = "4XUBG",
                            RoomId = "this-is-me"
                        },
                        new
                        {
                            ActivityId = 3,
                            CreationDate = new DateTime(2018, 3, 24, 4, 45, 19, 0, DateTimeKind.Unspecified),
                            Description = "Hy Iceland",
                            IsCompleted = false,
                            IsOngoing = false,
                            ScheduledFor = new DateTime(2020, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeSpan = new TimeSpan(0, 5, 0, 0, 0),
                            Title = "Video to come",
                            UserId = "5925d79e-5ed1-4e19-ae1f-8ef0e4474cad",
                            Password = "YEAH",
                            RoomId = "to-come"
                        },
                        new
                        {
                            ActivityId = 4,
                            CreationDate = new DateTime(2020, 3, 24, 4, 45, 19, 0, DateTimeKind.Unspecified),
                            Description = "You",
                            IsCompleted = false,
                            IsOngoing = true,
                            ScheduledFor = new DateTime(2020, 7, 30, 16, 1, 56, 182, DateTimeKind.Local).AddTicks(2777),
                            TimeSpan = new TimeSpan(0, 0, 30, 0, 0),
                            Title = "Without Password",
                            UserId = "5925d79e-5ed1-4e19-ae1f-8ef0e4474cad",
                            RoomId = "without-password"
                        });
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

            modelBuilder.Entity("OnlineEducation.Data.Models.Activity", b =>
                {
                    b.HasOne("OnlineEducation.Data.Models.ApplicationUser", "User")
                        .WithMany("Activities")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("OnlineEducation.Data.Models.SignalRConnection", b =>
                {
                    b.HasOne("OnlineEducation.Data.Models.VideoconferenceUser", null)
                        .WithMany("Connections")
                        .HasForeignKey("VideoconferenceUserId");
                });

            modelBuilder.Entity("OnlineEducation.Data.Models.VideoconferenceUser", b =>
                {
                    b.HasOne("OnlineEducation.Data.Models.ApplicationUser", "User")
                        .WithMany("VideoconferenceUsers")
                        .HasForeignKey("UserId1");

                    b.HasOne("OnlineEducation.Data.Models.Videoconference", "Videoconference")
                        .WithMany("VideoconferenceUsers")
                        .HasForeignKey("VideoconferenceActivityId");
                });
#pragma warning restore 612, 618
        }
    }
}
