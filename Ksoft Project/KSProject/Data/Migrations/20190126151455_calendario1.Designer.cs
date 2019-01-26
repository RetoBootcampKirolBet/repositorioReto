﻿// <auto-generated />
using System;
using KSProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KSProject.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190126151455_calendario1")]
    partial class calendario1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KSProject.Models._Links", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssigneeId");

                    b.Property<int?>("AuthorId");

                    b.Property<int?>("CustomField1Id");

                    b.Property<int?>("CustomField2Id");

                    b.Property<int?>("PriorityId");

                    b.Property<int?>("ResponsibleId");

                    b.Property<int?>("StatusId");

                    b.Property<int?>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("AssigneeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CustomField1Id");

                    b.HasIndex("CustomField2Id");

                    b.HasIndex("PriorityId");

                    b.HasIndex("ResponsibleId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.ToTable("_Links");
                });

            modelBuilder.Entity("KSProject.Models.AssigneeWP", b =>
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

            modelBuilder.Entity("KSProject.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("KSProject.Models.Calendario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaFin");

                    b.Property<DateTime>("FechaInicio");

                    b.Property<double>("Jueves");

                    b.Property<double>("Lunes");

                    b.Property<double>("Martes");

                    b.Property<double>("Miercoles");

                    b.Property<double>("Viernes");

                    b.HasKey("Id");

                    b.ToTable("Calendario");
                });

            modelBuilder.Entity("KSProject.Models.CalendarioPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonaId");

                    b.Property<int>("WorkPackageId");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.HasIndex("WorkPackageId");

                    b.ToTable("CalendarioPersona");
                });

            modelBuilder.Entity("KSProject.Models.CustomField1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomField1Id");

                    b.Property<string>("KsoftProject");

                    b.HasKey("Id");

                    b.HasIndex("CustomField1Id");

                    b.ToTable("CustomField1");
                });

            modelBuilder.Entity("KSProject.Models.CustomField2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomField2Id");

                    b.Property<string>("Sprint");

                    b.HasKey("Id");

                    b.HasIndex("CustomField2Id");

                    b.ToTable("CustomField2");
                });

            modelBuilder.Entity("KSProject.Models.Dedication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Desarrollo");

                    b.Property<double>("Formacion");

                    b.Property<double>("Gestion");

                    b.Property<double>("Investigacion");

                    b.Property<double>("NoDedicadas");

                    b.Property<int?>("PersonaId");

                    b.Property<double>("Soporte");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.ToTable("Dedication");
                });

            modelBuilder.Entity("KSProject.Models.Description", b =>
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

            modelBuilder.Entity("KSProject.Models.EmbeddedUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("_linksId");

                    b.HasKey("Id");

                    b.HasIndex("_linksId");

                    b.ToTable("EmbeddedUser");
                });

            modelBuilder.Entity("KSProject.Models.EmbeddedWP", b =>
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

            modelBuilder.Entity("KSProject.Models.KSUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

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

            modelBuilder.Entity("KSProject.Models.Oporrak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DiasDeVacaciones");

                    b.Property<double>("HorasDeVacaciones");

                    b.Property<int?>("PersonaId");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.ToTable("Oporrak");
                });

            modelBuilder.Entity("KSProject.Models.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdOP");

                    b.Property<double>("TotalHorasEstimadas");

                    b.Property<double>("TotalHorasTrabajadas");

                    b.HasKey("Id");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("KSProject.Models.Priority", b =>
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

            modelBuilder.Entity("KSProject.Models.ResponseUser", b =>
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

            modelBuilder.Entity("KSProject.Models.ResponseWP", b =>
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

            modelBuilder.Entity("KSProject.Models.Responsible", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("ResponsibleId");

                    b.HasKey("Id");

                    b.HasIndex("ResponsibleId");

                    b.ToTable("Responsible");
                });

            modelBuilder.Entity("KSProject.Models.StatusWP", b =>
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

            modelBuilder.Entity("KSProject.Models.TypeWP", b =>
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

            modelBuilder.Entity("KSProject.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmbeddedUserId");

                    b.Property<int>("IdUserOpenProject");

                    b.Property<string>("Login");

                    b.Property<string>("Name");

                    b.Property<string>("Team");

                    b.Property<string>("UserRole");

                    b.HasKey("Id");

                    b.HasIndex("EmbeddedUserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("KSProject.Models.UserWorkPackage", b =>
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

            modelBuilder.Entity("KSProject.Models.WorkPackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activation");

                    b.Property<int?>("DescriptionId");

                    b.Property<string>("DueDate");

                    b.Property<int?>("EmbeddedWPId");

                    b.Property<string>("EstimatedTime");

                    b.Property<int>("IdOP");

                    b.Property<string>("SpentTime");

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

            modelBuilder.Entity("KSProject.Models._Links", b =>
                {
                    b.HasOne("KSProject.Models.AssigneeWP", "Assignee")
                        .WithMany()
                        .HasForeignKey("AssigneeId");

                    b.HasOne("KSProject.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("KSProject.Models.CustomField1", "CustomField1")
                        .WithMany()
                        .HasForeignKey("CustomField1Id");

                    b.HasOne("KSProject.Models.CustomField2", "CustomField2")
                        .WithMany()
                        .HasForeignKey("CustomField2Id");

                    b.HasOne("KSProject.Models.Priority", "Priority")
                        .WithMany()
                        .HasForeignKey("PriorityId");

                    b.HasOne("KSProject.Models.Responsible", "Responsible")
                        .WithMany()
                        .HasForeignKey("ResponsibleId");

                    b.HasOne("KSProject.Models.StatusWP", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("KSProject.Models.TypeWP", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("KSProject.Models.AssigneeWP", b =>
                {
                    b.HasOne("KSProject.Models.AssigneeWP")
                        .WithMany("Assignee")
                        .HasForeignKey("AssigneeWPId");
                });

            modelBuilder.Entity("KSProject.Models.Author", b =>
                {
                    b.HasOne("KSProject.Models.Author")
                        .WithMany("author")
                        .HasForeignKey("AuthorId");
                });

            modelBuilder.Entity("KSProject.Models.CalendarioPersona", b =>
                {
                    b.HasOne("KSProject.Models.Calendario", "Calendario")
                        .WithMany()
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KSProject.Models.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("WorkPackageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KSProject.Models.CustomField1", b =>
                {
                    b.HasOne("KSProject.Models.CustomField1")
                        .WithMany("customField1")
                        .HasForeignKey("CustomField1Id");
                });

            modelBuilder.Entity("KSProject.Models.CustomField2", b =>
                {
                    b.HasOne("KSProject.Models.CustomField2")
                        .WithMany("customField2")
                        .HasForeignKey("CustomField2Id");
                });

            modelBuilder.Entity("KSProject.Models.Dedication", b =>
                {
                    b.HasOne("KSProject.Models.Persona")
                        .WithMany("Dedications")
                        .HasForeignKey("PersonaId");
                });

            modelBuilder.Entity("KSProject.Models.Description", b =>
                {
                    b.HasOne("KSProject.Models.Description")
                        .WithMany("Descriptions")
                        .HasForeignKey("DescriptionId");
                });

            modelBuilder.Entity("KSProject.Models.EmbeddedUser", b =>
                {
                    b.HasOne("KSProject.Models._Links", "_links")
                        .WithMany()
                        .HasForeignKey("_linksId");
                });

            modelBuilder.Entity("KSProject.Models.EmbeddedWP", b =>
                {
                    b.HasOne("KSProject.Models.Description", "Descriptions")
                        .WithMany()
                        .HasForeignKey("DescriptionsId");

                    b.HasOne("KSProject.Models._Links", "_links")
                        .WithMany()
                        .HasForeignKey("_linksId");
                });

            modelBuilder.Entity("KSProject.Models.Oporrak", b =>
                {
                    b.HasOne("KSProject.Models.Persona")
                        .WithMany("Oporrak")
                        .HasForeignKey("PersonaId");
                });

            modelBuilder.Entity("KSProject.Models.Priority", b =>
                {
                    b.HasOne("KSProject.Models.Priority")
                        .WithMany("priority")
                        .HasForeignKey("PriorityId");
                });

            modelBuilder.Entity("KSProject.Models.ResponseUser", b =>
                {
                    b.HasOne("KSProject.Models.EmbeddedUser", "UsersContainer")
                        .WithMany()
                        .HasForeignKey("UsersContainerId");
                });

            modelBuilder.Entity("KSProject.Models.ResponseWP", b =>
                {
                    b.HasOne("KSProject.Models.EmbeddedWP", "WorkPackagesContainer")
                        .WithMany()
                        .HasForeignKey("WorkPackagesContainerId");
                });

            modelBuilder.Entity("KSProject.Models.Responsible", b =>
                {
                    b.HasOne("KSProject.Models.Responsible")
                        .WithMany("responsible")
                        .HasForeignKey("ResponsibleId");
                });

            modelBuilder.Entity("KSProject.Models.StatusWP", b =>
                {
                    b.HasOne("KSProject.Models.StatusWP")
                        .WithMany("status")
                        .HasForeignKey("StatusWPId");
                });

            modelBuilder.Entity("KSProject.Models.TypeWP", b =>
                {
                    b.HasOne("KSProject.Models.TypeWP")
                        .WithMany("Type")
                        .HasForeignKey("TypeWPId");
                });

            modelBuilder.Entity("KSProject.Models.User", b =>
                {
                    b.HasOne("KSProject.Models.EmbeddedUser")
                        .WithMany("Users")
                        .HasForeignKey("EmbeddedUserId");
                });

            modelBuilder.Entity("KSProject.Models.UserWorkPackage", b =>
                {
                    b.HasOne("KSProject.Models.User", "User")
                        .WithMany("UserWorkPackages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KSProject.Models.WorkPackage", "WorkPackage")
                        .WithMany("UserWorkPackages")
                        .HasForeignKey("WorkPackageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KSProject.Models.WorkPackage", b =>
                {
                    b.HasOne("KSProject.Models.Description", "Description")
                        .WithMany()
                        .HasForeignKey("DescriptionId");

                    b.HasOne("KSProject.Models.EmbeddedWP")
                        .WithMany("WorkPackages")
                        .HasForeignKey("EmbeddedWPId");

                    b.HasOne("KSProject.Models._Links", "_Links")
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
                    b.HasOne("KSProject.Models.KSUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("KSProject.Models.KSUser")
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

                    b.HasOne("KSProject.Models.KSUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("KSProject.Models.KSUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
