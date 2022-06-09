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
    [Migration("20220609181222_NewTable")]
    partial class NewTable
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
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BibleId"), 1L, 1);

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Songs")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BibleId");

                    b.ToTable("Bible");
                });

            modelBuilder.Entity("BibleAPI.Model.Chapitre", b =>
                {
                    b.Property<int>("ChapitreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

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

            modelBuilder.Entity("BibleAPI.Model.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LanguageId"), 1L, 1);

                    b.Property<int>("BibleId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Songs")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LanguageId");

                    b.HasIndex("BibleId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("BibleAPI.Model.Livre", b =>
                {
                    b.Property<int>("LivreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LivreId"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int>("TestamentId")
                        .HasColumnType("int");

                    b.HasKey("LivreId");

                    b.HasIndex("TestamentId");

                    b.ToTable("Livre");
                });

            modelBuilder.Entity("BibleAPI.Model.Testament", b =>
                {
                    b.Property<int>("TestamentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestamentId"), 1L, 1);

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Songs")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestamentId");

                    b.HasIndex("LanguageId");

                    b.ToTable("Testament");
                });

            modelBuilder.Entity("BibleAPI.Model.Verset", b =>
                {
                    b.Property<int>("VersetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

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

                    b.Property<string>("correspondances")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VersetId");

                    b.HasIndex("ChapitreId");

                    b.ToTable("Verset");
                });

            modelBuilder.Entity("BibleAPI.Model.VersetVersion", b =>
                {
                    b.Property<int>("VersionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VersionId"), 1L, 1);

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name")
                        .HasColumnOrder(1);

                    b.Property<string>("Songs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Number")
                        .HasColumnOrder(2);

                    b.Property<int>("VersetId")
                        .HasColumnType("int");

                    b.HasKey("VersionId");

                    b.HasIndex("VersetId");

                    b.ToTable("Versions");
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

            modelBuilder.Entity("BibleAPI.Model.Language", b =>
                {
                    b.HasOne("BibleAPI.Model.Bible", "Bible")
                        .WithMany("Languages")
                        .HasForeignKey("BibleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bible");
                });

            modelBuilder.Entity("BibleAPI.Model.Livre", b =>
                {
                    b.HasOne("BibleAPI.Model.Testament", "Testament")
                        .WithMany("Livres")
                        .HasForeignKey("TestamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Testament");
                });

            modelBuilder.Entity("BibleAPI.Model.Testament", b =>
                {
                    b.HasOne("BibleAPI.Model.Language", "Language")
                        .WithMany("Testaments")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
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

            modelBuilder.Entity("BibleAPI.Model.VersetVersion", b =>
                {
                    b.HasOne("BibleAPI.Model.Verset", "Verset")
                        .WithMany("Versions")
                        .HasForeignKey("VersetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Verset");
                });

            modelBuilder.Entity("BibleAPI.Model.Bible", b =>
                {
                    b.Navigation("Languages");
                });

            modelBuilder.Entity("BibleAPI.Model.Chapitre", b =>
                {
                    b.Navigation("Versets");
                });

            modelBuilder.Entity("BibleAPI.Model.Language", b =>
                {
                    b.Navigation("Testaments");
                });

            modelBuilder.Entity("BibleAPI.Model.Livre", b =>
                {
                    b.Navigation("Chapitres");
                });

            modelBuilder.Entity("BibleAPI.Model.Testament", b =>
                {
                    b.Navigation("Livres");
                });

            modelBuilder.Entity("BibleAPI.Model.Verset", b =>
                {
                    b.Navigation("Versions");
                });
#pragma warning restore 612, 618
        }
    }
}
