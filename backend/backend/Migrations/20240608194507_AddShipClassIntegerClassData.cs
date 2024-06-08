using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddShipClassIntegerClassData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ShipClassIntegerClass",
                columns: new[] { "Id", "Debuff", "DebuffValue", "IntegerIceClassId", "IsCanHelpMove", "IsCanSoloMove", "ShipClassId" },
                values: new object[,]
                {
                    { 1, false, 1.0, 1, false, true, 1 },
                    { 2, false, 1.0, 2, true, false, 1 },
                    { 3, false, 1.0, 3, false, false, 1 },
                    { 4, false, 1.0, 1, false, true, 2 },
                    { 5, false, 1.0, 2, true, false, 2 },
                    { 6, false, 1.0, 3, false, false, 2 },
                    { 7, false, 1.0, 1, false, true, 3 },
                    { 8, false, 1.0, 2, true, false, 3 },
                    { 9, false, 1.0, 3, false, false, 3 },
                    { 10, false, 1.0, 1, false, true, 4 },
                    { 11, false, 1.0, 2, true, false, 4 },
                    { 12, false, 1.0, 3, false, false, 4 },
                    { 13, false, 1.0, 1, false, true, 5 },
                    { 14, true, 0.80000000000000004, 2, true, false, 5 },
                    { 15, true, 0.69999999999999996, 3, true, false, 5 },
                    { 16, false, 1.0, 1, false, true, 6 },
                    { 17, true, 0.80000000000000004, 2, true, false, 6 },
                    { 18, true, 0.69999999999999996, 3, true, false, 6 },
                    { 22, false, 1.0, 1, false, true, 7 },
                    { 23, true, 0.80000000000000004, 2, true, false, 7 },
                    { 24, true, 0.69999999999999996, 3, true, false, 7 },
                    { 25, false, 1.0, 1, false, true, 8 },
                    { 26, true, 0.59999999999999998, 2, true, false, 8 },
                    { 27, true, 0.14999999999999999, 3, true, false, 8 },
                    { 28, false, 1.0, 1, false, true, 9 },
                    { 29, false, 1.0, 2, false, true, 9 },
                    { 30, false, 1.0, 3, false, true, 9 },
                    { 31, false, 1.0, 1, false, true, 10 },
                    { 32, true, 0.90000000000000002, 2, false, true, 10 },
                    { 33, true, 0.75, 3, false, true, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ShipClassIntegerClass",
                keyColumn: "Id",
                keyValue: 33);
        }
    }
}
