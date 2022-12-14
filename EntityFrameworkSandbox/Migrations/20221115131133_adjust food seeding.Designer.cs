// <auto-generated />
using System;
using EntityFrameworkSandbox;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkSandbox.Migrations
{
    [DbContext(typeof(FoodContext))]
    [Migration("20221115131133_adjust food seeding")]
    partial class adjustfoodseeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("EntityFrameworkSandbox.Food", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b559d96b-cd55-4bde-8814-225e815828bc"),
                            Name = "Cheese Cake",
                            Origin = "Greece"
                        },
                        new
                        {
                            Id = new Guid("b30085f2-522e-4200-885d-b662af6151c6"),
                            Name = "Sushi",
                            Origin = "Asia"
                        },
                        new
                        {
                            Id = new Guid("64d22bfd-0e55-487b-87fb-f96ce0cb7c1b"),
                            Name = "French Fries",
                            Origin = "Belgium"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
