﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThirdPartyPolicy.Data;

namespace ThirdPartyPolicy.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ThirdPartyPolicy.Models.BodyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BodyTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PremiumId")
                        .HasColumnType("int");

                    b.Property<int?>("PurchasePolicyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PremiumId");

                    b.HasIndex("PurchasePolicyId");

                    b.ToTable("BodyType");
                });

            modelBuilder.Entity("ThirdPartyPolicy.Models.ChangeUserPassword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmNewPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("ChangeUserPasswords");
                });

            modelBuilder.Entity("ThirdPartyPolicy.Models.CustomerInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DOB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CustomerInfos");
                });

            modelBuilder.Entity("ThirdPartyPolicy.Models.Policy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BodyType")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Premium")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("Policies");
                });

            modelBuilder.Entity("ThirdPartyPolicy.Models.Premium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PremiumAmount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PurchasePolicyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PurchasePolicyId");

                    b.ToTable("Premium");
                });

            modelBuilder.Entity("ThirdPartyPolicy.Models.PurchasePolicy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PurchasePolicies");
                });

            modelBuilder.Entity("ThirdPartyPolicy.Models.UserLogin", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RememberMe")
                        .HasColumnType("bit");

                    b.HasKey("Email");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("ThirdPartyPolicy.Models.VehicleInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BodyType")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("RegNo")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("VehicleMake")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("VehicleModel")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("VehicleInfos");
                });

            modelBuilder.Entity("ThirdPartyPolicy.Models.BodyType", b =>
                {
                    b.HasOne("ThirdPartyPolicy.Models.Premium", null)
                        .WithMany("BodyTypes")
                        .HasForeignKey("PremiumId");

                    b.HasOne("ThirdPartyPolicy.Models.PurchasePolicy", null)
                        .WithMany("BodyTypes")
                        .HasForeignKey("PurchasePolicyId");
                });

            modelBuilder.Entity("ThirdPartyPolicy.Models.Premium", b =>
                {
                    b.HasOne("ThirdPartyPolicy.Models.PurchasePolicy", null)
                        .WithMany("Premia")
                        .HasForeignKey("PurchasePolicyId");
                });

            modelBuilder.Entity("ThirdPartyPolicy.Models.Premium", b =>
                {
                    b.Navigation("BodyTypes");
                });

            modelBuilder.Entity("ThirdPartyPolicy.Models.PurchasePolicy", b =>
                {
                    b.Navigation("BodyTypes");

                    b.Navigation("Premia");
                });
#pragma warning restore 612, 618
        }
    }
}
