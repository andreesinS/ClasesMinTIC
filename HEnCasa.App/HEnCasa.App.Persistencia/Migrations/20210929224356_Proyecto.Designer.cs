﻿// <auto-generated />
using System;
using HEnCasa.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HEnCasa.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210929224356_Proyecto")]
    partial class Proyecto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("HEnCasa.App.Dominio.Historia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Diagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SignoVitalId")
                        .HasColumnType("int");

                    b.Property<int?>("SugerenciaCuidadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SignoVitalId");

                    b.HasIndex("SugerenciaCuidadoId");

                    b.ToTable("HistoriasClinicas");
                });

            modelBuilder.Entity("HEnCasa.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("HEnCasa.App.Dominio.SignoVital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Dolor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaHora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PresionArterial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RitmoCardiaco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Saturacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Temperatura")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SignosVitales");
                });

            modelBuilder.Entity("HEnCasa.App.Dominio.SugerenciaCuidado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaHora")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SugerenciasCuidado");
                });

            modelBuilder.Entity("HEnCasa.App.Dominio.Enfermera", b =>
                {
                    b.HasBaseType("HEnCasa.App.Dominio.Persona");

                    b.Property<int>("HorasLaborales")
                        .HasColumnType("int");

                    b.Property<int>("IdEnfermera")
                        .HasColumnType("int")
                        .HasColumnName("Enfermera_IdEnfermera");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Enfermera");
                });

            modelBuilder.Entity("HEnCasa.App.Dominio.FamiliarDesignado", b =>
                {
                    b.HasBaseType("HEnCasa.App.Dominio.Persona");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdFamiliarDesigando")
                        .HasColumnType("int");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<string>("Parentesco")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("FamiliarDesignado");
                });

            modelBuilder.Entity("HEnCasa.App.Dominio.Medico", b =>
                {
                    b.HasBaseType("HEnCasa.App.Dominio.Persona");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdMedico")
                        .HasColumnType("int")
                        .HasColumnName("Medico_IdMedico");

                    b.HasDiscriminator().HasValue("Medico");
                });

            modelBuilder.Entity("HEnCasa.App.Dominio.Paciente", b =>
                {
                    b.HasBaseType("HEnCasa.App.Dominio.Persona");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdEnfermera")
                        .HasColumnType("int");

                    b.Property<int>("IdFamiliarDesignado")
                        .HasColumnType("int");

                    b.Property<int>("IdHistoria")
                        .HasColumnType("int");

                    b.Property<int>("IdMedico")
                        .HasColumnType("int");

                    b.Property<int>("IdPaciente")
                        .HasColumnType("int");

                    b.Property<double>("Latitud")
                        .HasColumnType("float");

                    b.Property<double>("Longitud")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("Paciente");
                });

            modelBuilder.Entity("HEnCasa.App.Dominio.Historia", b =>
                {
                    b.HasOne("HEnCasa.App.Dominio.SignoVital", "SignoVital")
                        .WithMany()
                        .HasForeignKey("SignoVitalId");

                    b.HasOne("HEnCasa.App.Dominio.SugerenciaCuidado", "SugerenciaCuidado")
                        .WithMany()
                        .HasForeignKey("SugerenciaCuidadoId");

                    b.Navigation("SignoVital");

                    b.Navigation("SugerenciaCuidado");
                });
#pragma warning restore 612, 618
        }
    }
}
