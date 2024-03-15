﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReactFoodApp.API_DotNet7.Data;

#nullable disable

namespace ReactFoodApp.API_DotNet7.Migrations
{
    [DbContext(typeof(FoodAppDbContext))]
    partial class FoodAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ReactFoodApp.API_DotNet7.Models.Domain.Meal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Meals");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cdeddcaa-4909-49e8-a6cb-4bf1a23c4b43"),
                            Description = "Creamy cheddar cheese mixed with perfectly cooked macaroni, topped with crispy breadcrumbs. A classic comfort Meal.",
                            Image = "images/mac-and-cheese.jpg",
                            Name = "Mac & Cheese",
                            Price = "8.99"
                        },
                        new
                        {
                            Id = new Guid("aef16b60-9121-421e-8b05-50a3c2a5f59b"),
                            Description = "A classic pizza with fresh mozzarella, tomatoes, and basil on a thin and crispy crust.",
                            Image = "images/margherita-pizza.jpg",
                            Name = "Margherita Pizza",
                            Price = "12.99"
                        },
                        new
                        {
                            Id = new Guid("03cb137b-b7c1-43d3-8a23-7c55a48a252c"),
                            Description = "Romaine lettuce tossed in Caesar dressing, topped with croutons and parmesan shavings.",
                            Image = "images/caesar-salad.jpg",
                            Name = "Caesar Salad",
                            Price = "7.99"
                        },
                        new
                        {
                            Id = new Guid("82ed8dc4-072f-40ac-99f8-4d23130a15e6"),
                            Description = "Al dente spaghetti with a creamy sauce made from egg yolk, pecorino cheese, pancetta, and pepper.",
                            Image = "images/spaghetti-carbonara.jpg",
                            Name = "Spaghetti Carbonara",
                            Price = "10.99"
                        },
                        new
                        {
                            Id = new Guid("9b1307a6-0f15-4393-a9b2-f56279e2d7e4"),
                            Description = "A juicy veggie patty served on a whole grain bun with lettuce, tomato, and a tangy sauce.",
                            Image = "images/veggie-burger.jpg",
                            Name = "Veggie Burger",
                            Price = "9.99"
                        },
                        new
                        {
                            Id = new Guid("b6fe06d3-66f2-4814-9b53-5f383c68125c"),
                            Description = "Tender grilled chicken breast with avocado, bacon, lettuce, and honey mustard on a toasted bun.",
                            Image = "images/grilled-chicken-sandwich.jpg",
                            Name = "Grilled Chicken Sandwich",
                            Price = "10.99"
                        },
                        new
                        {
                            Id = new Guid("5f2c18c3-693e-4b55-b4b8-f22f192a73c0"),
                            Description = "Succulent steak cooked to your preference, served with crispy golden fries and herb butter.",
                            Image = "images/steak-frites.jpg",
                            Name = "Steak Frites",
                            Price = "17.99"
                        },
                        new
                        {
                            Id = new Guid("44d360e7-5b38-4342-b1a4-614e59817a92"),
                            Description = "An assortment of fresh sushi rolls including California, Spicy Tuna, and Eel Avocado.",
                            Image = "images/sushi-roll-platter.jpg",
                            Name = "Sushi Roll Platter",
                            Price = "15.99"
                        },
                        new
                        {
                            Id = new Guid("cf067ea7-b671-4b2d-bb51-24e046ed3d46"),
                            Description = "Tender pieces of chicken simmered in a rich and aromatic curry sauce, served with basmati rice.",
                            Image = "images/chicken-curry.jpg",
                            Name = "Chicken Curry",
                            Price = "13.99"
                        },
                        new
                        {
                            Id = new Guid("575b6f77-1b9d-4039-b659-62023111b517"),
                            Description = "A hearty bowl filled with quinoa, roasted veggies, avocado, and a tahini dressing.",
                            Image = "images/vegan-buddha-bowl.jpg",
                            Name = "Vegan Buddha Bowl",
                            Price = "11.99"
                        },
                        new
                        {
                            Id = new Guid("0b741c80-d3d4-4045-9077-55f5394c6a3c"),
                            Description = "A Spanish delicacy filled with saffron-infused rice, shrimp, mussels, and chorizo.",
                            Image = "images/seaMeal-paella.jpg",
                            Name = "SeaMeal Paella",
                            Price = "19.99"
                        },
                        new
                        {
                            Id = new Guid("2a24410e-72f7-4a4d-8aef-c743837bda26"),
                            Description = "Fluffy pancakes stacked high, drizzled with maple syrup and topped with fresh berries.",
                            Image = "images/pancake-stack.jpg",
                            Name = "Pancake Stack",
                            Price = "8.99"
                        },
                        new
                        {
                            Id = new Guid("c1d23e71-1cf9-460a-8f2a-c4de25640982"),
                            Description = "A warming bowl of ramen with miso broth, tender pork, soft-boiled egg, and green onions.",
                            Image = "images/miso-ramen.jpg",
                            Name = "Miso Ramen",
                            Price = "12.99"
                        },
                        new
                        {
                            Id = new Guid("82371ba0-dcc1-42e7-9123-c478c4f6a0ac"),
                            Description = "Three soft tortillas filled with seasoned beef, fresh salsa, cheese, and sour cream.",
                            Image = "images/beef-tacos.jpg",
                            Name = "Beef Tacos",
                            Price = "9.99"
                        },
                        new
                        {
                            Id = new Guid("c144fe74-20b0-4b48-8e10-625f3a0e58e8"),
                            Description = "A rich and fudgy brownie, topped with a scoop of vanilla ice cream and chocolate sauce.",
                            Image = "images/chocolate-brownie.jpg",
                            Name = "Chocolate Brownie",
                            Price = "5.99"
                        },
                        new
                        {
                            Id = new Guid("780fd0a1-8838-4769-9b45-c5c6b82aae4a"),
                            Description = "A creamy soup made from lobster stock, aromatic vegetables, and a touch of brandy.",
                            Image = "images/lobster-bisque.jpg",
                            Name = "Lobster Bisque",
                            Price = "14.99"
                        },
                        new
                        {
                            Id = new Guid("1708bc09-58dc-49ff-9332-9edf55fc9a2a"),
                            Description = "Creamy Arborio rice cooked with a medley of wild mushrooms and finished with parmesan.",
                            Image = "images/mushroom-risotto.jpg",
                            Name = "Mushroom Risotto",
                            Price = "13.99"
                        },
                        new
                        {
                            Id = new Guid("a0791c28-7381-4728-8c97-6b80050cf3f5"),
                            Description = "Layers of breaded eggplant, marinara sauce, and melted mozzarella and parmesan cheeses.",
                            Image = "images/eggplant-parmesan.jpg",
                            Name = "Eggplant Parmesan",
                            Price = "11.99"
                        },
                        new
                        {
                            Id = new Guid("b90f0123-b9ad-4268-9823-dcf2047e4313"),
                            Description = "A creamy cheesecake with a tangy lemon flavor, served on a crumbly biscuit base.",
                            Image = "images/lemon-cheesecake.jpg",
                            Name = "Lemon Cheesecake",
                            Price = "6.99"
                        },
                        new
                        {
                            Id = new Guid("c44ba500-3fc3-4f99-915a-af867a220c38"),
                            Description = "Crispy falafels wrapped in a warm pita with lettuce, tomatoes, and a tahini sauce.",
                            Image = "images/falafel-wrap.jpg",
                            Name = "Falafel Wrap",
                            Price = "8.99"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
