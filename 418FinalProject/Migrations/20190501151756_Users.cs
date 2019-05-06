using Microsoft.EntityFrameworkCore.Migrations;

namespace _418FinalProject.Migrations
{
    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

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

            migrationBuilder.AddColumn<int>(
                name: "USER_ID",
                table: "User",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "TestID",
                table: "Question",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "USER_ID");

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    TestID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TestTitle = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.TestID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Question_TestID",
                table: "Question",
                column: "TestID");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Test_TestID",
                table: "Question",
                column: "TestID",
                principalTable: "Test",
                principalColumn: "TestID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Test_TestID",
                table: "Question");

            migrationBuilder.DropTable(
                name: "Test");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Question_TestID",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "USER_ID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "TestID",
                table: "Question");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "USER_NAME");
        }
    }
}
