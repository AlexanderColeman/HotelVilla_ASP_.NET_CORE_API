using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelVillaAPI.Migrations
{
    public partial class changedVillaNumberIDName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VillaId",
                table: "VillaNumbers",
                newName: "VillaID");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 28, 6, 40, 42, 680, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 28, 6, 40, 42, 680, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 28, 6, 40, 42, 680, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 28, 6, 40, 42, 680, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 28, 6, 40, 42, 680, DateTimeKind.Local).AddTicks(4902));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VillaID",
                table: "VillaNumbers",
                newName: "VillaId");

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
    }
}
