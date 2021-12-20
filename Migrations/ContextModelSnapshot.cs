﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webTeste.Models;

#nullable disable

namespace webTeste.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("webTeste.Models.Cliente", b =>
                {
                    b.Property<int>("Id_cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_cliente"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_cliente");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("webTeste.Models.Contato", b =>
                {
                    b.Property<int>("Id_Contato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Contato"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mensagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Contato");

                    b.ToTable("contatos");
                });

            modelBuilder.Entity("webTeste.Models.Voo", b =>
                {
                    b.Property<int>("Id_Voo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Voo"), 1L, 1);

                    b.Property<DateTime>("Data_Partida")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_Retorno")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_cliente")
                        .HasColumnType("int");

                    b.HasKey("Id_Voo");

                    b.HasIndex("Id_cliente");

                    b.ToTable("voos");
                });

            modelBuilder.Entity("webTeste.Models.Voo", b =>
                {
                    b.HasOne("webTeste.Models.Cliente", "ClienteList")
                        .WithMany("ClienteList")
                        .HasForeignKey("Id_cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClienteList");
                });

            modelBuilder.Entity("webTeste.Models.Cliente", b =>
                {
                    b.Navigation("ClienteList");
                });
#pragma warning restore 612, 618
        }
    }
}
