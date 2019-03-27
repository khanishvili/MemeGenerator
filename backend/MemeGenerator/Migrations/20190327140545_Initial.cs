using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MemeGenerator.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Memes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Top = table.Column<string>(nullable: true),
                    Bottom = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Memes",
                columns: new[] { "Id", "Bottom", "Image", "Top" },
                values: new object[,]
                {
                    { 1, "Yo git like me", "./Images/4.jpg", "Js on my tree" },
                    { 2, "\"Cross-Origin Request Blocked\"", "./Images/Taken.jpg", "I will look for you and I will find you" },
                    { 3, "of MVC", "./Images/9.jpg", "International Man" },
                    { 4, "but old ones start failing", "./Images/5.jpg", "When a new test passes" },
                    { 5, "is it called a method and an action?", "./Images/StarTrek.png", "WHY THE FUNCTION" },
                    { 6, "and you feel a sneeze coming", "./Images/2.jpg", "When you've been holding a fart in the whole interview," }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Memes");
        }
    }
}
