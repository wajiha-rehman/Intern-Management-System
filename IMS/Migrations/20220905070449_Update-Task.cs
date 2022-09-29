using Microsoft.EntityFrameworkCore.Migrations;

namespace IMS.Migrations
{
    public partial class UpdateTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblTask_tblIntern_Intern",
                table: "tblTask");

            migrationBuilder.DropIndex(
                name: "IX_tblTask_Intern",
                table: "tblTask");

            migrationBuilder.RenameColumn(
                name: "Intern",
                table: "tblTask",
                newName: "AssignedTo");

            migrationBuilder.AddColumn<int>(
                name: "AssignedToInternID",
                table: "tblTask",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblTask_AssignedToInternID",
                table: "tblTask",
                column: "AssignedToInternID");

            migrationBuilder.AddForeignKey(
                name: "FK_tblTask_tblIntern_AssignedToInternID",
                table: "tblTask",
                column: "AssignedToInternID",
                principalTable: "tblIntern",
                principalColumn: "InternID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblTask_tblIntern_AssignedToInternID",
                table: "tblTask");

            migrationBuilder.DropIndex(
                name: "IX_tblTask_AssignedToInternID",
                table: "tblTask");

            migrationBuilder.DropColumn(
                name: "AssignedToInternID",
                table: "tblTask");

            migrationBuilder.RenameColumn(
                name: "AssignedTo",
                table: "tblTask",
                newName: "Intern");

            migrationBuilder.CreateIndex(
                name: "IX_tblTask_Intern",
                table: "tblTask",
                column: "Intern");

            migrationBuilder.AddForeignKey(
                name: "FK_tblTask_tblIntern_Intern",
                table: "tblTask",
                column: "Intern",
                principalTable: "tblIntern",
                principalColumn: "InternID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
