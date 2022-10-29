﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Migrations
{
    public partial class AddTestDBToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ms_storage_location",
                columns: table => new
                {
                    location_id = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    location_name = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ms_storage_location", x => x.location_id);
                });

            migrationBuilder.CreateTable(
                name: "tr_bpkb",
                columns: table => new
                {
                    agreement_number = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    bpkb_no = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    branch_id = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    bpkb_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    faktur_no = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    faktur_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    location_id = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    police_no = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    bpkb_date_in = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tr_bpkb", x => x.agreement_number);
                    table.ForeignKey(
                        name: "FK_tr_bpkb_ms_storage_location_location_id",
                        column: x => x.location_id,
                        principalTable: "ms_storage_location",
                        principalColumn: "location_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tr_bpkb_location_id",
                table: "tr_bpkb",
                column: "location_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tr_bpkb");

            migrationBuilder.DropTable(
                name: "ms_storage_location");
        }
    }
}
