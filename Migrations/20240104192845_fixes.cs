using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace System_zarządzania_błędami.Migrations
{
    /// <inheritdoc />
    public partial class fixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReportId",
                table: "UserReports");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserReports");

            migrationBuilder.DropColumn(
                name: "ErrorId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "PriorityId",
                table: "Errors");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReportId",
                table: "UserReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ErrorId",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PriorityId",
                table: "Errors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
