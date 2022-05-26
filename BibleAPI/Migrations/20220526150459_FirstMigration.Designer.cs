﻿// <auto-generated />
using BibleAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BibleAPI.Migrations
{
    [DbContext(typeof(APIContext))]
    [Migration("20220526150459_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BibleAPI.Model.Bible", b =>
                {
                    b.Property<int>("BibleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BibleId"), 1L, 1);

                    b.Property<string>("Auteur")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(1);

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Songs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(2);

                    b.HasKey("BibleId");

                    b.ToTable("Bible");
                });

            modelBuilder.Entity("BibleAPI.Model.Chapitre", b =>
                {
                    b.Property<int>("ChapitreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChapitreId"), 1L, 1);

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LivreId")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("Numero")
                        .HasColumnOrder(1);

                    b.Property<string>("Songs")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChapitreId");

                    b.HasIndex("LivreId");

                    b.ToTable("Chapitre");
                });

            modelBuilder.Entity("BibleAPI.Model.Livre", b =>
                {
                    b.Property<int>("LivreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LivreId"), 1L, 1);

                    b.Property<int>("BibleId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Numero")
                        .HasColumnOrder(1);

                    b.Property<string>("Songs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Testament")
                        .HasColumnType("int");

                    b.HasKey("LivreId");

                    b.HasIndex("BibleId");

                    b.ToTable("Livre");
                });

            modelBuilder.Entity("BibleAPI.Model.Verset", b =>
                {
                    b.Property<int>("VersetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VersetId"), 1L, 1);

                    b.Property<int>("ChapitreId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("Number")
                        .HasColumnOrder(1);

                    b.Property<string>("Songs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(2);

                    b.Property<string>("Titre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correspondances")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(3);

                    b.HasKey("VersetId");

                    b.HasIndex("ChapitreId");

                    b.ToTable("Verset");
                });

            modelBuilder.Entity("BibleAPI.Model.Chapitre", b =>
                {
                    b.HasOne("BibleAPI.Model.Livre", "Livre")
                        .WithMany("Chapitres")
                        .HasForeignKey("LivreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livre");
                });

            modelBuilder.Entity("BibleAPI.Model.Livre", b =>
                {
                    b.HasOne("BibleAPI.Model.Bible", "Bible")
                        .WithMany("Livres")
                        .HasForeignKey("BibleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bible");
                });

            modelBuilder.Entity("BibleAPI.Model.Verset", b =>
                {
                    b.HasOne("BibleAPI.Model.Chapitre", "Chapitre")
                        .WithMany("Versets")
                        .HasForeignKey("ChapitreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chapitre");
                });

            modelBuilder.Entity("BibleAPI.Model.Bible", b =>
                {
                    b.Navigation("Livres");
                });

            modelBuilder.Entity("BibleAPI.Model.Chapitre", b =>
                {
                    b.Navigation("Versets");
                });

            modelBuilder.Entity("BibleAPI.Model.Livre", b =>
                {
                    b.Navigation("Chapitres");
                });
#pragma warning restore 612, 618
        }
    }
}
