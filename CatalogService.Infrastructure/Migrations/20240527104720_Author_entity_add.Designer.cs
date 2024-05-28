﻿// <auto-generated />
using System;
using CatalogService.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CatalogService.Infrastructure.Migrations
{
    [DbContext(typeof(CatalogServiceContext))]
    [Migration("20240527104720_Author_entity_add")]
    partial class Author_entity_add
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CatalogService.Domain.Aggregates.AuthorAggregate.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("CatalogService.Domain.Aggregates.BookAggregate.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AuthorId")
                        .HasMaxLength(250)
                        .HasColumnType("uuid");

                    b.Property<int>("BookCondition")
                        .HasColumnType("integer");

                    b.Property<int>("BookGenre")
                        .HasMaxLength(250)
                        .HasColumnType("integer");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("boolean");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("CatalogService.Domain.Aggregates.AuthorAggregate.Author", b =>
                {
                    b.OwnsOne("CatalogService.Domain.Aggregates.AuthorAggregate.FullName", "AuthorFullName", b1 =>
                        {
                            b1.Property<Guid>("AuthorId")
                                .HasColumnType("uuid");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("MiddleName")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("AuthorId");

                            b1.ToTable("Authors");

                            b1.WithOwner()
                                .HasForeignKey("AuthorId");
                        });

                    b.Navigation("AuthorFullName")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}