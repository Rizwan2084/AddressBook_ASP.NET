﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Technovert.Models;

namespace Technovert.Migrations
{
    [DbContext(typeof(TechnovertContext))]
    partial class TechnovertContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Technovert.Models.ContactDetails", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("Landline")
                        .HasMaxLength(10);

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Website");

                    b.HasKey("ID");

                    b.ToTable("ContactDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
