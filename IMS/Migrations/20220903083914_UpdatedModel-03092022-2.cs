using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IMS.Migrations
{
    public partial class UpdatedModel030920222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAttendance",
                columns: table => new
                {
                    AttendanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendanceDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    CheckOutTime = table.Column<DateTime>(type: "DateTime", nullable: false),
                    CheckInTime = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Intern = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAttendance", x => x.AttendanceID);
                });

            migrationBuilder.CreateTable(
                name: "tblAttendanceCorrectionRequest",
                columns: table => new
                {
                    AttCorrectionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendanceID = table.Column<int>(type: "int", nullable: false),
                    AttendanceType = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    NewAttendanceTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    ApprovedStatus = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAttendanceCorrectionRequest", x => x.AttCorrectionID);
                });

            migrationBuilder.CreateTable(
                name: "tblLeaveRequest",
                columns: table => new
                {
                    LeaveRequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Intern = table.Column<int>(type: "int", nullable: false),
                    LeaveType = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    LeaveStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LeaveEndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ApprovedStatus = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLeaveRequest", x => x.LeaveRequestID);
                });

            migrationBuilder.CreateTable(
                name: "tblPerformanceReview",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Intern = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPerformanceReview", x => x.ReviewID);
                });

            migrationBuilder.CreateTable(
                name: "tblProgram",
                columns: table => new
                {
                    ProgramID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramTitle = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    TransportAllowance = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    CasualLeavesAllowed = table.Column<int>(type: "int", nullable: false),
                    SickLeavesAllowed = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Open = table.Column<bool>(type: "bit", nullable: false),
                    Department = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProgram", x => x.ProgramID);
                });

            migrationBuilder.CreateTable(
                name: "tblUser",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    UserRole = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUser", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "tblUserRole",
                columns: table => new
                {
                    UserRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUserRole", x => x.UserRoleID);
                });

            migrationBuilder.CreateTable(
                name: "tblDepartment",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentTitle = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    DepartmentExtension = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    DepartmentLocation = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    DepartmentFloor = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    DepartmentBuilding = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    User = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDepartment", x => x.DepartmentID);
                    table.ForeignKey(
                        name: "FK_tblDepartment_tblUser_User",
                        column: x => x.User,
                        principalTable: "tblUser",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblIntern",
                columns: table => new
                {
                    InternID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionTitle = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Stipend = table.Column<decimal>(type: "money", nullable: false),
                    CasualLeavesRemaining = table.Column<int>(type: "int", nullable: false),
                    SickLeavesRemaining = table.Column<int>(type: "int", nullable: false),
                    Program = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    HRRepresentative = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    CNICNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastWorkingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblIntern", x => x.InternID);
                    table.ForeignKey(
                        name: "FK_tblIntern_tblUser_UserID",
                        column: x => x.UserID,
                        principalTable: "tblUser",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblTask",
                columns: table => new
                {
                    TaskID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskDescription = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Intern = table.Column<int>(type: "int", nullable: false),
                    AssignedDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    StartDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    CompletedDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    InternRemarks = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    ManagerFeedback = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTask", x => x.TaskID);
                    table.ForeignKey(
                        name: "FK_tblTask_tblIntern_Intern",
                        column: x => x.Intern,
                        principalTable: "tblIntern",
                        principalColumn: "InternID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblDepartment_User",
                table: "tblDepartment",
                column: "User");

            migrationBuilder.CreateIndex(
                name: "IX_tblIntern_UserID",
                table: "tblIntern",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_tblTask_Intern",
                table: "tblTask",
                column: "Intern");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblAttendance");

            migrationBuilder.DropTable(
                name: "tblAttendanceCorrectionRequest");

            migrationBuilder.DropTable(
                name: "tblDepartment");

            migrationBuilder.DropTable(
                name: "tblLeaveRequest");

            migrationBuilder.DropTable(
                name: "tblPerformanceReview");

            migrationBuilder.DropTable(
                name: "tblProgram");

            migrationBuilder.DropTable(
                name: "tblTask");

            migrationBuilder.DropTable(
                name: "tblUserRole");

            migrationBuilder.DropTable(
                name: "tblIntern");

            migrationBuilder.DropTable(
                name: "tblUser");
        }
    }
}
