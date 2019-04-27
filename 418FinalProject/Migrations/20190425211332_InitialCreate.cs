using Microsoft.EntityFrameworkCore.Migrations;

namespace _418FinalProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    QuestionID = table.Column<int>(name: "Question ID", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(type: "varchar(20)", nullable: false),
                    QuestionText = table.Column<string>(name: "Question Text", type: "varchar(100)", maxLength: 100, nullable: false),
                    TrueFalse = table.Column<bool>(name: "True False", type: "bit", nullable: false),
                    ANS1 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ANS2 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ANS3 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ANS4 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.QuestionID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    USER_ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    USER_NAME = table.Column<string>(type: "varchar(20)", nullable: false),
                    PASSWORD = table.Column<string>(type: "varchar(20)", nullable: false),
                    ADMIN = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.USER_ID);
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
