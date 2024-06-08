using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class addSoloMoveHelpMove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsCanMove",
                table: "ShipClassIntegerClass",
                newName: "IsCanSoloMove");

            migrationBuilder.AddColumn<bool>(
                name: "IsCanHelpMove",
                table: "ShipClassIntegerClass",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "IntegerIceClass",
                columns: new[] { "Id", "MaxSpeed", "MinSpeed" },
                values: new object[,]
                {
                    { 1, 21, 20 },
                    { 2, 19, 15 },
                    { 3, 14, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IntegerIceClass",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IntegerIceClass",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IntegerIceClass",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "IsCanHelpMove",
                table: "ShipClassIntegerClass");

            migrationBuilder.RenameColumn(
                name: "IsCanSoloMove",
                table: "ShipClassIntegerClass",
                newName: "IsCanMove");
        }
    }
}
