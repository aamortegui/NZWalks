using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2b2b5b23-d298-4750-89cb-910d3c9b8aef"), "Easy" },
                    { new Guid("61c5e25e-77d9-4ed4-88c0-50564f809da9"), "Hard" },
                    { new Guid("f638fa7e-1fa5-47ed-a018-ef6c52e267b2"), "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("0530f273-6b0e-4f07-a03e-702ef58cfbaf"), "NTL", "Northland", null },
                    { new Guid("29a6dd05-1dd6-4709-aafe-7b143aa7e8f2"), "STL", "Southland", null },
                    { new Guid("3da99569-8372-4fe1-b9af-ea8ce054a3fa"), "AKL", "Auckland", "https://images.pexels.com/photos/21286407/pexels-photo-21286407/free-photo-of-mar-punto-de-referencia-oceano-viaje.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("4e2e0bdf-3384-4351-8e7f-2d8025b5aa11"), "BOP", "Bay Of Plenty", null },
                    { new Guid("b5e3d57a-6c18-44dd-82d5-3ad0d9486312"), "AAA", "Andres", "https://images.pexels.com/photos/20759547/pexels-photo-20759547/free-photo-of-carretera-montana-vehiculo-asfalto.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("d6cad55c-4037-4dc4-b18b-d630b7213820"), "WGN", "Wellington", "https://images.pexels.com/photos/11639884/pexels-photo-11639884.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("2b2b5b23-d298-4750-89cb-910d3c9b8aef"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("61c5e25e-77d9-4ed4-88c0-50564f809da9"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("f638fa7e-1fa5-47ed-a018-ef6c52e267b2"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("0530f273-6b0e-4f07-a03e-702ef58cfbaf"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("29a6dd05-1dd6-4709-aafe-7b143aa7e8f2"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3da99569-8372-4fe1-b9af-ea8ce054a3fa"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("4e2e0bdf-3384-4351-8e7f-2d8025b5aa11"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("b5e3d57a-6c18-44dd-82d5-3ad0d9486312"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d6cad55c-4037-4dc4-b18b-d630b7213820"));
        }
    }
}
