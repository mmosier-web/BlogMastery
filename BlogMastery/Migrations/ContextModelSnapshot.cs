﻿// <auto-generated />
using System;
using BlogMastery.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogMastery.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogMastery.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Post");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new { Id = 1, Name = "Sci-fi" },
                        new { Id = 2, Name = "Romance" },
                        new { Id = 3, Name = "Action" },
                        new { Id = 4, Name = "Fantasy" }
                    );
                });

            modelBuilder.Entity("BlogMastery.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("Body");

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("GenreId");

                    b.Property<int>("TagId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("TagId");

                    b.ToTable("Posts");

                    b.HasData(
                        new { Id = 1, Author = "Jk", Body = "sorcerer", DateTime = new DateTime(2019, 10, 17, 12, 4, 17, 689, DateTimeKind.Local), GenreId = 1, TagId = 1, Title = "Harry Potter" },
                        new { Id = 2, Author = "Ryan Gosling", Body = "Alzheimers", DateTime = new DateTime(2019, 10, 17, 12, 4, 17, 691, DateTimeKind.Local), GenreId = 2, TagId = 2, Title = "Notebook" },
                        new { Id = 3, Author = "steven spielberg", Body = "if or", DateTime = new DateTime(2019, 10, 17, 12, 4, 17, 691, DateTimeKind.Local), GenreId = 1, TagId = 1, Title = "Matrix" },
                        new { Id = 4, Author = "steven spielberg", Body = "Optimus Prime", DateTime = new DateTime(2019, 10, 17, 12, 4, 17, 691, DateTimeKind.Local), GenreId = 1, TagId = 1, Title = "Transformers" }
                    );
                });

            modelBuilder.Entity("BlogMastery.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Post");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new { Id = 1, Name = "Sci-fi" },
                        new { Id = 2, Name = "Romance" },
                        new { Id = 3, Name = "Action" },
                        new { Id = 4, Name = "Fantasy" }
                    );
                });

            modelBuilder.Entity("BlogMastery.Models.Post", b =>
                {
                    b.HasOne("BlogMastery.Models.Genre", "Genre")
                        .WithMany("Posts")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BlogMastery.Models.Tag", "Tag")
                        .WithMany("Posts")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
