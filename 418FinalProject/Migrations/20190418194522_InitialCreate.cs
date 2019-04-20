using Microsoft.EntityFrameworkCore.Migrations;

namespace _418FinalProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionNumber = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuestionText = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Answer1 = table.Column<string>(type: "varchar(2)", maxLength: 100, nullable: false),
                    Answer1Text = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Answer2 = table.Column<string>(type: "varchar(2)", maxLength: 100, nullable: false),
                    Answer2Text = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Answer3 = table.Column<string>(type: "varchar(2)", maxLength: 100, nullable: false),
                    Answer3Text = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Answer4 = table.Column<string>(type: "varchar(2)", maxLength: 100, nullable: false),
                    Answer4Text = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Category = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
