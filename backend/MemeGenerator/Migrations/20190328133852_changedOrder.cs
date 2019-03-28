using Microsoft.EntityFrameworkCore.Migrations;

namespace MemeGenerator.Migrations
{
    public partial class changedOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Memes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bottom", "Image", "Top" },
                values: new object[] { "and you feel a sneeze coming", "./Images/2.jpg", "When you've been holding a fart in the whole interview," });

            migrationBuilder.UpdateData(
                table: "Memes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bottom", "Image", "Top" },
                values: new object[] { "is it called a method and an action?", "./Images/StarTrek.png", "WHY THE FUNCTION" });

            migrationBuilder.UpdateData(
                table: "Memes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bottom", "Image", "Top" },
                values: new object[] { "but old ones start failing", "./Images/5.jpg", "When a new test passes" });

            migrationBuilder.UpdateData(
                table: "Memes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bottom", "Image", "Top" },
                values: new object[] { "of MVC", "./Images/9.jpg", "International Man" });

            migrationBuilder.UpdateData(
                table: "Memes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bottom", "Image", "Top" },
                values: new object[] { "\"Cross-Origin Request Blocked\"", "./Images/Taken.jpg", "I will look for you and I will find you" });

            migrationBuilder.UpdateData(
                table: "Memes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Bottom", "Image", "Top" },
                values: new object[] { "Yo git like me", "./Images/4.jpg", "Js on my tree" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Memes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bottom", "Image", "Top" },
                values: new object[] { "Yo git like me", "./Images/4.jpg", "Js on my tree" });

            migrationBuilder.UpdateData(
                table: "Memes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bottom", "Image", "Top" },
                values: new object[] { "\"Cross-Origin Request Blocked\"", "./Images/Taken.jpg", "I will look for you and I will find you" });

            migrationBuilder.UpdateData(
                table: "Memes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bottom", "Image", "Top" },
                values: new object[] { "of MVC", "./Images/9.jpg", "International Man" });

            migrationBuilder.UpdateData(
                table: "Memes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bottom", "Image", "Top" },
                values: new object[] { "but old ones start failing", "./Images/5.jpg", "When a new test passes" });

            migrationBuilder.UpdateData(
                table: "Memes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bottom", "Image", "Top" },
                values: new object[] { "is it called a method and an action?", "./Images/StarTrek.png", "WHY THE FUNCTION" });

            migrationBuilder.UpdateData(
                table: "Memes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Bottom", "Image", "Top" },
                values: new object[] { "and you feel a sneeze coming", "./Images/2.jpg", "When you've been holding a fart in the whole interview," });
        }
    }
}
