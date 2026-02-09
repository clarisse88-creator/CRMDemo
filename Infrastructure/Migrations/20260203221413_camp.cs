using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class camp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Campaigns",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Campaigns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "Campaigns",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_CreatedById",
                table: "Campaigns",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_UpdatedById",
                table: "Campaigns",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Campaigns_Users_CreatedById",
                table: "Campaigns",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Campaigns_Users_UpdatedById",
                table: "Campaigns",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campaigns_Users_CreatedById",
                table: "Campaigns");

            migrationBuilder.DropForeignKey(
                name: "FK_Campaigns_Users_UpdatedById",
                table: "Campaigns");

            migrationBuilder.DropIndex(
                name: "IX_Campaigns_CreatedById",
                table: "Campaigns");

            migrationBuilder.DropIndex(
                name: "IX_Campaigns_UpdatedById",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Campaigns");
        }
    }
}
