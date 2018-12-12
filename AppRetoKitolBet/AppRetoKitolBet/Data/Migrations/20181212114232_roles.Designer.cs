﻿// <auto-generated />
using System;
using AppRetoKitolBet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppRetoKitolBet.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181212114232_roles")]
    partial class roles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppRetoKitolBet.Models._Links", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssigneeId");

                    b.Property<int?>("PriorityId");

                    b.Property<int?>("StatusId");

                    b.Property<int?>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("AssigneeId");

                    b.HasIndex("PriorityId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.ToTable("_Links");
                });

            modelBuilder.Entity("AppRetoKitolBet.Models.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("AppRetoKitolBet.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Rol");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AppRetoKitolBet.Models.AssigneeWP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssigneeWPId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("AssigneeWPId");

                    b.ToTable("AssigneeWP");
                });

            modelBuilder.Entity("AppRetoKitolBet.Models.Description", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DescriptionId");

                    b.Property<string>("Raw");

                    b.HasKey("Id");

                    b.HasIndex("DescriptionId");

                    b.ToTable("Description");
                });

            modelBuilder.Entity("AppRetoKitolBet.Models.Priority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PriorityId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("PriorityId");

                    b.ToTable("Priority");
                });

            modelBuilder.Entity("AppRetoKitolBet.Models.StatusWP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estado");

                    b.Property<int?>("StatusWPId");

                    b.HasKey("Id");

                    b.HasIndex("StatusWPId");

                    b.ToTable("StatusWP");
                });

            modelBuilder.Entity("AppRetoKitolBet.Models.TypeWP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tipo");

                    b.Property<int?>("TypeWPId");

                    b.HasKey("Id");

                    b.HasIndex("TypeWPId");

                    b.ToTable("TypeWP");
                });

            modelBuilder.Entity("AppRetoKitolBet.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUserOpenProject");

                    b.Property<string>("Login");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("AppRetoKitolBet.Models.UserWorkPackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId");

                    b.Property<int>("WorkPackageId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WorkPackageId");

                    b.ToTable("UserWorkPackage");
                });

            modelBuilder.Entity("AppRetoKitolBet.Models.WorkPackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DescriptionId");

                    b.Property<string>("DueDate");

                    b.Property<string>("EstimatedTime");

                    b.Property<int>("IdWPOpenProject");

                    b.Property<string>("RemainingTime");

                    b.Property<string>("StartDate");

                    b.Property<string>("Subject");

                    b.Property<int?>("_LinksId");

                    b.HasKey("Id");

                    b.HasIndex("DescriptionId");

                    b.HasIndex("_LinksId");

                    b.ToTable("WorkPackage");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AppRetoKitolBet.Models._Links", b =>
                {
                    b.HasOne("AppRetoKitolBet.Models.AssigneeWP", "Assignee")
                        .WithMany()
                        .HasForeignKey("AssigneeId");

                    b.HasOne("AppRetoKitolBet.Models.Priority", "Priority")
                        .WithMany()
                        .HasForeignKey("PriorityId");

                    b.HasOne("AppRetoKitolBet.Models.StatusWP", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("AppRetoKitolBet.Models.TypeWP", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("AppRetoKitolBet.Models.AssigneeWP", b =>
                {
                    b.HasOne("AppRetoKitolBet.Models.AssigneeWP")
                        .WithMany("assignee")
                        .HasForeignKey("AssigneeWPId");
                });

            modelBuilder.Entity("AppRetoKitolBet.Models.Description", b =>
                {
                    b.HasOne("AppRetoKitolBet.Models.Description")
                        .WithMany("Descriptions")
                        .HasForeignKey("DescriptionId");
                });

            modelBuilder.Entity("AppRetoKitolBet.Models.Priority", b =>
                {
                    b.HasOne("AppRetoKitolBet.Models.Priority")
                        .WithMany("priority")
                        .HasForeignKey("PriorityId");
                });

            modelBuilder.Entity("AppRetoKitolBet.Models.StatusWP", b =>
                {
                    b.HasOne("AppRetoKitolBet.Models.StatusWP")
                        .WithMany("status")
                        .HasForeignKey("StatusWPId");
                });

            modelBuilder.Entity("AppRetoKitolBet.Models.TypeWP", b =>
                {
                    b.HasOne("AppRetoKitolBet.Models.TypeWP")
                        .WithMany("type")
                        .HasForeignKey("TypeWPId");
                });

            modelBuilder.Entity("AppRetoKitolBet.Models.UserWorkPackage", b =>
                {
                    b.HasOne("AppRetoKitolBet.Models.User", "User")
                        .WithMany("UserWorkPackages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AppRetoKitolBet.Models.WorkPackage", "WorkPackage")
                        .WithMany("UserWorkPackages")
                        .HasForeignKey("WorkPackageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AppRetoKitolBet.Models.WorkPackage", b =>
                {
                    b.HasOne("AppRetoKitolBet.Models.Description", "Description")
                        .WithMany()
                        .HasForeignKey("DescriptionId");

                    b.HasOne("AppRetoKitolBet.Models._Links", "_Links")
                        .WithMany()
                        .HasForeignKey("_LinksId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("AppRetoKitolBet.Models.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AppRetoKitolBet.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AppRetoKitolBet.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("AppRetoKitolBet.Models.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AppRetoKitolBet.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AppRetoKitolBet.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
