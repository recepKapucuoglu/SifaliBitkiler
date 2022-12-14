// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(SifaliBitkilerContext))]
    partial class SifaliBitkilerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Concrete.Bitki", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Acıklaması")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResimUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bitkis");
                });

            modelBuilder.Entity("Entities.Concrete.SikayetEtki", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Etkisi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SikayetEtkis");
                });

            modelBuilder.Entity("Entities.Concrete.SikayetEtkiBitki", b =>
                {
                    b.Property<int?>("SikayetEtkiId")
                        .HasColumnType("int");

                    b.Property<int?>("BitkiId")
                        .HasColumnType("int");

                    b.HasKey("SikayetEtkiId", "BitkiId");

                    b.HasIndex("BitkiId");

                    b.ToTable("SikayetEtkiBitki");
                });

            modelBuilder.Entity("Entities.Concrete.SikayetEtkiBitki", b =>
                {
                    b.HasOne("Entities.Concrete.Bitki", "Bitki")
                        .WithMany("SikayetEtkis")
                        .HasForeignKey("BitkiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.SikayetEtki", "SikayetEtki")
                        .WithMany("Bitkis")
                        .HasForeignKey("SikayetEtkiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
