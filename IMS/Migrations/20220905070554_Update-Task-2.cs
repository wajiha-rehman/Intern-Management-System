using Microsoft.EntityFrameworkCore.Migrations;

namespace IMS.Migrations
{
    public partial class UpdateTask2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "InternID");

            migrationBuilder.CreateIndex(
                name: "IX_tblTask_InternID",
                table: "tblTask",
                column: "InternID");

            migrationBuilder.AddForeignKey(
                name: "FK_tblTask_tblIntern_InternID",
                table: "tblTask",
                column: "InternID",
                principalTable: "tblIntern",
                principalColumn: "InternID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblTask_tblIntern_InternID",
                table: "tblTask");

            migrationBuilder.DropIndex(
                name: "IX_tblTask_InternID",
                table: "tblTask");

            migrationBuilder.RenameColumn(
                name: "InternID",
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
    }
}
