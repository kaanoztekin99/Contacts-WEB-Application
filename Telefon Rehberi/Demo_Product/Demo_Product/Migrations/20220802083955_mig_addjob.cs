﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_addjob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobID",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_JobID",
                table: "Employees",
                column: "JobID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Jobs_JobID",
                table: "Employees",
                column: "JobID",
                principalTable: "Jobs",
                principalColumn: "JobID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Jobs_JobID",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Customers_JobID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "JobID",
                table: "Employees");
        }
    }
}
