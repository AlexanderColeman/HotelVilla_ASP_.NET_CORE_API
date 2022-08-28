using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelVillaAPI.Migrations
{
    public partial class AddForeignKeyToVillaNumberTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaId",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 28, 6, 33, 45, 187, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 28, 6, 33, 45, 187, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 28, 6, 33, 45, 187, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 28, 6, 33, 45, 187, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 28, 6, 33, 45, 187, DateTimeKind.Local).AddTicks(3823));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VillaId",
                table: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 27, 7, 31, 15, 450, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 27, 7, 31, 15, 450, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 27, 7, 31, 15, 450, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 27, 7, 31, 15, 450, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 27, 7, 31, 15, 450, DateTimeKind.Local).AddTicks(4975));
        }
    }
}
