﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhaleApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConservationStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConservationStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Whales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScientificName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lifespan = table.Column<int>(type: "int", nullable: true),
                    MigrationDistance = table.Column<int>(type: "int", nullable: true),
                    Population = table.Column<int>(type: "int", nullable: true),
                    ConservationStatusId = table.Column<int>(type: "int", nullable: true),
                    IsInArcticOcean = table.Column<bool>(type: "bit", nullable: false),
                    IsInAtlanticOcean = table.Column<bool>(type: "bit", nullable: false),
                    IsInIndianOcean = table.Column<bool>(type: "bit", nullable: false),
                    IsInPacificOcean = table.Column<bool>(type: "bit", nullable: false),
                    IsInSouthernOcean = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Whales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Whales_ConservationStatuses_ConservationStatusId",
                        column: x => x.ConservationStatusId,
                        principalTable: "ConservationStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ConservationStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Extinct" },
                    { 2, "Extinct in the Wild" },
                    { 3, "Critically Endangered" },
                    { 4, "Endangered" },
                    { 5, "Vulnerable" },
                    { 6, "Near Threatened" },
                    { 7, "Least Concern" }
                });

            migrationBuilder.InsertData(
                table: "Whales",
                columns: new[] { "Id", "CommonName", "ConservationStatusId", "Description", "IsInArcticOcean", "IsInAtlanticOcean", "IsInIndianOcean", "IsInPacificOcean", "IsInSouthernOcean", "Lifespan", "MigrationDistance", "Population", "ScientificName" },
                values: new object[,]
                {
                    { 1, "Blue whale", 2, "odio cras mi pede malesuada in imperdiet et commodo vulputate justo in blandit ultrices enim lorem ipsum dolor", true, false, true, true, false, 241, 874, 7270, "Heloderma horridum" },
                    { 2, "Humpback whale", 5, "integer ac leo pellentesque ultrices mattis odio donec vitae nisi nam", false, true, true, true, false, 105, 7575, 4143, "Phalaropus lobatus" },
                    { 3, "Fin whale", 3, "aliquet maecenas leo odio condimentum id luctus nec molestie sed justo pellentesque viverra pede ac diam", true, true, true, false, false, 379, 9548, 2956, "Limosa haemastica" },
                    { 4, "Beluga whale", 3, "aliquam lacus morbi quis tortor id nulla ultrices aliquet maecenas leo odio", false, true, true, false, true, 624, 9180, 8286, "Mycteria leucocephala" },
                    { 5, "Sperm whale", 6, "morbi a ipsum integer a nibh in quis justo maecenas rhoncus aliquam lacus morbi quis", false, false, false, true, false, 957, 5765, 831, "Bassariscus astutus" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Whales_ConservationStatusId",
                table: "Whales",
                column: "ConservationStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Whales");

            migrationBuilder.DropTable(
                name: "ConservationStatuses");
        }
    }
}
