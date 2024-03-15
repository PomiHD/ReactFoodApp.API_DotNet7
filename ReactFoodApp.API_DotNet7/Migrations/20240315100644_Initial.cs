using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReactFoodApp.API_DotNet7.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("03cb137b-b7c1-43d3-8a23-7c55a48a252c"), "Romaine lettuce tossed in Caesar dressing, topped with croutons and parmesan shavings.", "images/caesar-salad.jpg", "Caesar Salad", "7.99" },
                    { new Guid("0b741c80-d3d4-4045-9077-55f5394c6a3c"), "A Spanish delicacy filled with saffron-infused rice, shrimp, mussels, and chorizo.", "images/seaMeal-paella.jpg", "SeaMeal Paella", "19.99" },
                    { new Guid("1708bc09-58dc-49ff-9332-9edf55fc9a2a"), "Creamy Arborio rice cooked with a medley of wild mushrooms and finished with parmesan.", "images/mushroom-risotto.jpg", "Mushroom Risotto", "13.99" },
                    { new Guid("2a24410e-72f7-4a4d-8aef-c743837bda26"), "Fluffy pancakes stacked high, drizzled with maple syrup and topped with fresh berries.", "images/pancake-stack.jpg", "Pancake Stack", "8.99" },
                    { new Guid("44d360e7-5b38-4342-b1a4-614e59817a92"), "An assortment of fresh sushi rolls including California, Spicy Tuna, and Eel Avocado.", "images/sushi-roll-platter.jpg", "Sushi Roll Platter", "15.99" },
                    { new Guid("575b6f77-1b9d-4039-b659-62023111b517"), "A hearty bowl filled with quinoa, roasted veggies, avocado, and a tahini dressing.", "images/vegan-buddha-bowl.jpg", "Vegan Buddha Bowl", "11.99" },
                    { new Guid("5f2c18c3-693e-4b55-b4b8-f22f192a73c0"), "Succulent steak cooked to your preference, served with crispy golden fries and herb butter.", "images/steak-frites.jpg", "Steak Frites", "17.99" },
                    { new Guid("780fd0a1-8838-4769-9b45-c5c6b82aae4a"), "A creamy soup made from lobster stock, aromatic vegetables, and a touch of brandy.", "images/lobster-bisque.jpg", "Lobster Bisque", "14.99" },
                    { new Guid("82371ba0-dcc1-42e7-9123-c478c4f6a0ac"), "Three soft tortillas filled with seasoned beef, fresh salsa, cheese, and sour cream.", "images/beef-tacos.jpg", "Beef Tacos", "9.99" },
                    { new Guid("82ed8dc4-072f-40ac-99f8-4d23130a15e6"), "Al dente spaghetti with a creamy sauce made from egg yolk, pecorino cheese, pancetta, and pepper.", "images/spaghetti-carbonara.jpg", "Spaghetti Carbonara", "10.99" },
                    { new Guid("9b1307a6-0f15-4393-a9b2-f56279e2d7e4"), "A juicy veggie patty served on a whole grain bun with lettuce, tomato, and a tangy sauce.", "images/veggie-burger.jpg", "Veggie Burger", "9.99" },
                    { new Guid("a0791c28-7381-4728-8c97-6b80050cf3f5"), "Layers of breaded eggplant, marinara sauce, and melted mozzarella and parmesan cheeses.", "images/eggplant-parmesan.jpg", "Eggplant Parmesan", "11.99" },
                    { new Guid("aef16b60-9121-421e-8b05-50a3c2a5f59b"), "A classic pizza with fresh mozzarella, tomatoes, and basil on a thin and crispy crust.", "images/margherita-pizza.jpg", "Margherita Pizza", "12.99" },
                    { new Guid("b6fe06d3-66f2-4814-9b53-5f383c68125c"), "Tender grilled chicken breast with avocado, bacon, lettuce, and honey mustard on a toasted bun.", "images/grilled-chicken-sandwich.jpg", "Grilled Chicken Sandwich", "10.99" },
                    { new Guid("b90f0123-b9ad-4268-9823-dcf2047e4313"), "A creamy cheesecake with a tangy lemon flavor, served on a crumbly biscuit base.", "images/lemon-cheesecake.jpg", "Lemon Cheesecake", "6.99" },
                    { new Guid("c144fe74-20b0-4b48-8e10-625f3a0e58e8"), "A rich and fudgy brownie, topped with a scoop of vanilla ice cream and chocolate sauce.", "images/chocolate-brownie.jpg", "Chocolate Brownie", "5.99" },
                    { new Guid("c1d23e71-1cf9-460a-8f2a-c4de25640982"), "A warming bowl of ramen with miso broth, tender pork, soft-boiled egg, and green onions.", "images/miso-ramen.jpg", "Miso Ramen", "12.99" },
                    { new Guid("c44ba500-3fc3-4f99-915a-af867a220c38"), "Crispy falafels wrapped in a warm pita with lettuce, tomatoes, and a tahini sauce.", "images/falafel-wrap.jpg", "Falafel Wrap", "8.99" },
                    { new Guid("cdeddcaa-4909-49e8-a6cb-4bf1a23c4b43"), "Creamy cheddar cheese mixed with perfectly cooked macaroni, topped with crispy breadcrumbs. A classic comfort Meal.", "images/mac-and-cheese.jpg", "Mac & Cheese", "8.99" },
                    { new Guid("cf067ea7-b671-4b2d-bb51-24e046ed3d46"), "Tender pieces of chicken simmered in a rich and aromatic curry sauce, served with basmati rice.", "images/chicken-curry.jpg", "Chicken Curry", "13.99" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meals");
        }
    }
}
