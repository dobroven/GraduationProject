// <auto-generated />
using System;
using AspNetCoreApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetCoreApp.Migrations
{
    [DbContext(typeof(RestaurantDBContext))]
    [Migration("20201203084505_RestaurantCartAdd")]
    partial class RestaurantCartAdd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetCoreApp.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("AspNetCoreApp.Data.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Image");

                    b.Property<bool>("IsFavourite");

                    b.Property<string>("LongDesc");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.Property<string>("ShortDesc");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Dish");
                });

            modelBuilder.Entity("AspNetCoreApp.Data.Models.RestaurantCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DishId");

                    b.Property<int>("Price");

                    b.Property<string>("RestaurantCartId");

                    b.HasKey("Id");

                    b.HasIndex("DishId");

                    b.ToTable("RestaurantCartItem");
                });

            modelBuilder.Entity("AspNetCoreApp.Data.Models.Dish", b =>
                {
                    b.HasOne("AspNetCoreApp.Data.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AspNetCoreApp.Data.Models.RestaurantCartItem", b =>
                {
                    b.HasOne("AspNetCoreApp.Data.Models.Dish", "Dish")
                        .WithMany()
                        .HasForeignKey("DishId");
                });
#pragma warning restore 612, 618
        }
    }
}
