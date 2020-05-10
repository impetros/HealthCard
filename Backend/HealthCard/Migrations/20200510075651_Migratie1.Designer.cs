﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectMDS.Contexts;

namespace ProiectMDS.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200510075651_Migratie1")]
    partial class Migratie1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProiectMDS.Models.Diagnostic", b =>
                {
                    b.Property<int>("DiagnosticId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoctorId");

                    b.Property<int>("PacientId");

                    b.HasKey("DiagnosticId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PacientId");

                    b.ToTable("Diagnostice");
                });

            modelBuilder.Entity("ProiectMDS.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DoctorNume");

                    b.Property<string>("DoctorPrenume");

                    b.Property<string>("Specialitate");

                    b.Property<int>("Varsta");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctori");
                });

            modelBuilder.Entity("ProiectMDS.Models.Medicament", b =>
                {
                    b.Property<int>("MedicamentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CantitateDisponibila");

                    b.Property<string>("Nume");

                    b.Property<float>("Pret");

                    b.HasKey("MedicamentId");

                    b.ToTable("Medicamente");
                });

            modelBuilder.Entity("ProiectMDS.Models.Pacient", b =>
                {
                    b.Property<int>("PacientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNP");

                    b.Property<string>("PacientNume");

                    b.Property<string>("PacientPrenume");

                    b.Property<int>("Varsta");

                    b.HasKey("PacientId");

                    b.ToTable("Pacienti");
                });

            modelBuilder.Entity("ProiectMDS.Models.Tratament", b =>
                {
                    b.Property<int>("TratamentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DataAdministrare");

                    b.Property<string>("DataTerminare");

                    b.Property<int>("DiagnosticId");

                    b.Property<float>("Dozaj");

                    b.Property<int>("MedicamentId");

                    b.HasKey("TratamentId");

                    b.HasIndex("DiagnosticId");

                    b.HasIndex("MedicamentId");

                    b.ToTable("Tratamente");
                });

            modelBuilder.Entity("ProiectMDS.Models.Diagnostic", b =>
                {
                    b.HasOne("ProiectMDS.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProiectMDS.Models.Pacient", "Pacient")
                        .WithMany()
                        .HasForeignKey("PacientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProiectMDS.Models.Tratament", b =>
                {
                    b.HasOne("ProiectMDS.Models.Diagnostic", "Diagnostic")
                        .WithMany()
                        .HasForeignKey("DiagnosticId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProiectMDS.Models.Medicament", "Medicament")
                        .WithMany()
                        .HasForeignKey("MedicamentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
