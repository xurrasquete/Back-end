﻿// <auto-generated />
using App.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace _19_atividade_CRUD.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("App.Models.Categoria", b =>
                {
                    b.Property<int>("categoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoriaNome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sinopse")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("categoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("App.Models.Serie", b =>
                {
                    b.Property<int>("SerieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sinopse")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SerieId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("App.Models.Serie", b =>
                {
                    b.HasOne("App.Models.Categoria", "Categoria")
                        .WithMany("Series")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("App.Models.Categoria", b =>
                {
                    b.Navigation("Series");
                });
#pragma warning restore 612, 618
        }
    }
}