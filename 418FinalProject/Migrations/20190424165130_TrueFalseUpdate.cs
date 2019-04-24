using Microsoft.EntityFrameworkCore.Migrations;

namespace _418FinalProject.Migrations
{
    public partial class TrueFalseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "True_False",
                table: "Question",
                newName: "True False");

            migrationBuilder.RenameColumn(
                name: "Question_Text",
                table: "Question",
                newName: "Question Text");

            migrationBuilder.RenameColumn(
                name: "Question_ID",
                table: "Question",
                newName: "Question ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "True False",
                table: "Question",
                newName: "True_False");

            migrationBuilder.RenameColumn(
                name: "Question Text",
                table: "Question",
                newName: "Question_Text");

            migrationBuilder.RenameColumn(
                name: "Question ID",
                table: "Question",
                newName: "Question_ID");
        }
    }
}
