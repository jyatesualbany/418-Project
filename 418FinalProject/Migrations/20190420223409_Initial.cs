using Microsoft.EntityFrameworkCore.Migrations;

namespace _418FinalProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Question_ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(type: "varchar(20)", nullable: false),
                    Question_Text = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    True_False = table.Column<byte>(type: "bit", nullable: false),
                    ANS1 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ANS2 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ANS3 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ANS4 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Question_ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    USER_NAME = table.Column<string>(type: "varchar(20)", nullable: false),
                    PASSWORD = table.Column<string>(type: "varchar(20)", nullable: false),
                    ADMIN = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.USER_NAME);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
