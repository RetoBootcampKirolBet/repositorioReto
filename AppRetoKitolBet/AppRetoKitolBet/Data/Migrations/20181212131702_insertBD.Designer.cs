﻿// <auto-generated />
using System;
using AppRetoKirolBet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppRetoKirolBet.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181212131702_insertBD")]
    partial class insertBD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppRetoKirolBet.Models._Links", b =>
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

            modelBuilder.Entity("AppRetoKirolBet.Models.AssigneeWP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssigneeWPId");

                    b.Property<string>("Name");

                    b.Property<int?>("StatusWPId");

                    b.HasKey("Id");

                    b.HasIndex("AssigneeWPId");

                    b.HasIndex("StatusWPId");

                    b.ToTable("AssigneeWP");
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.Description", b =>
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

            modelBuilder.Entity("AppRetoKirolBet.Models.EmbeddedUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("_linksId");

                    b.HasKey("Id");

                    b.HasIndex("_linksId");

                    b.ToTable("EmbeddedUser");
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.EmbeddedWP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DescriptionsId");

                    b.Property<int?>("_linksId");

                    b.HasKey("Id");

                    b.HasIndex("DescriptionsId");

                    b.HasIndex("_linksId");

                    b.ToTable("EmbeddedWP");
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.Priority", b =>
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

            modelBuilder.Entity("AppRetoKirolBet.Models.ResponseUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<int>("Offset");

                    b.Property<int>("Total");

                    b.Property<int?>("UsersContainerId");

                    b.HasKey("Id");

                    b.HasIndex("UsersContainerId");

                    b.ToTable("ResponseUser");
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.ResponseWP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<int>("Offset");

                    b.Property<int>("Total");

                    b.Property<int?>("WorkPackagesContainerId");

                    b.HasKey("Id");

                    b.HasIndex("WorkPackagesContainerId");

                    b.ToTable("ResponseWP");
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.StatusWP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estado");

                    b.HasKey("Id");

                    b.ToTable("StatusWP");
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.TypeWP", b =>
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

            modelBuilder.Entity("AppRetoKirolBet.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmbeddedUserId");

                    b.Property<string>("Login");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("EmbeddedUserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.UserWorkPackage", b =>
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

            modelBuilder.Entity("AppRetoKirolBet.Models.WorkPackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DescriptionId");

                    b.Property<string>("DueDate");

                    b.Property<int?>("EmbeddedWPId");

                    b.Property<string>("EstimatedTime");

                    b.Property<int>("IdWPOpenProject");

                    b.Property<string>("RemainingTime");

                    b.Property<string>("StartDate");

                    b.Property<string>("Subject");

                    b.Property<int?>("_LinksId");

                    b.HasKey("Id");

                    b.HasIndex("DescriptionId");

                    b.HasIndex("EmbeddedWPId");

                    b.HasIndex("_LinksId");

                    b.ToTable("WorkPackage");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

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

            modelBuilder.Entity("AppRetoKirolBet.Models._Links", b =>
                {
                    b.HasOne("AppRetoKirolBet.Models.AssigneeWP", "Assignee")
                        .WithMany()
                        .HasForeignKey("AssigneeId");

                    b.HasOne("AppRetoKirolBet.Models.Priority", "Priority")
                        .WithMany()
                        .HasForeignKey("PriorityId");

                    b.HasOne("AppRetoKirolBet.Models.StatusWP", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("AppRetoKirolBet.Models.TypeWP", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.AssigneeWP", b =>
                {
                    b.HasOne("AppRetoKirolBet.Models.AssigneeWP")
                        .WithMany("assignee")
                        .HasForeignKey("AssigneeWPId");

                    b.HasOne("AppRetoKirolBet.Models.StatusWP")
                        .WithMany("assignee")
                        .HasForeignKey("StatusWPId");
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.Description", b =>
                {
                    b.HasOne("AppRetoKirolBet.Models.Description")
                        .WithMany("Descriptions")
                        .HasForeignKey("DescriptionId");
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.EmbeddedUser", b =>
                {
                    b.HasOne("AppRetoKirolBet.Models._Links", "_links")
                        .WithMany()
                        .HasForeignKey("_linksId");
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.EmbeddedWP", b =>
                {
                    b.HasOne("AppRetoKirolBet.Models.Description", "Descriptions")
                        .WithMany()
                        .HasForeignKey("DescriptionsId");

                    b.HasOne("AppRetoKirolBet.Models._Links", "_links")
                        .WithMany()
                        .HasForeignKey("_linksId");
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.Priority", b =>
                {
                    b.HasOne("AppRetoKirolBet.Models.Priority")
                        .WithMany("priority")
                        .HasForeignKey("PriorityId");
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.ResponseUser", b =>
                {
                    b.HasOne("AppRetoKirolBet.Models.EmbeddedUser", "UsersContainer")
                        .WithMany()
                        .HasForeignKey("UsersContainerId");
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.ResponseWP", b =>
                {
                    b.HasOne("AppRetoKirolBet.Models.EmbeddedWP", "WorkPackagesContainer")
                        .WithMany()
                        .HasForeignKey("WorkPackagesContainerId");
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.TypeWP", b =>
                {
                    b.HasOne("AppRetoKirolBet.Models.TypeWP")
                        .WithMany("Type")
                        .HasForeignKey("TypeWPId");
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.User", b =>
                {
                    b.HasOne("AppRetoKirolBet.Models.EmbeddedUser")
                        .WithMany("Users")
                        .HasForeignKey("EmbeddedUserId");
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.UserWorkPackage", b =>
                {
                    b.HasOne("AppRetoKirolBet.Models.User", "User")
                        .WithMany("UserWorkPackages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AppRetoKirolBet.Models.WorkPackage", "WorkPackage")
                        .WithMany("UserWorkPackages")
                        .HasForeignKey("WorkPackageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AppRetoKirolBet.Models.WorkPackage", b =>
                {
                    b.HasOne("AppRetoKirolBet.Models.Description", "Description")
                        .WithMany()
                        .HasForeignKey("DescriptionId");

                    b.HasOne("AppRetoKirolBet.Models.EmbeddedWP")
                        .WithMany("WorkPackages")
                        .HasForeignKey("EmbeddedWPId");

                    b.HasOne("AppRetoKirolBet.Models._Links", "_Links")
                        .WithMany()
                        .HasForeignKey("_LinksId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
