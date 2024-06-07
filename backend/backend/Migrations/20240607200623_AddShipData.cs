using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddShipData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ShipClass",
                columns: new[] { "Id", "ShipType" },
                values: new object[,]
                {
                    { 1, "Without class" },
                    { 2, "Ice1" },
                    { 3, "Ice2" },
                    { 4, "Ice3" },
                    { 5, "Arc4" },
                    { 6, "Arc5" },
                    { 7, "Arc6" },
                    { 8, "Arc7" },
                    { 9, "Arc9-1" },
                    { 10, "Arc9-2" }
                });

            migrationBuilder.InsertData(
                table: "Ship",
                columns: new[] { "Id", "ShipClassId", "ShipName", "Speed" },
                values: new object[,]
                {
                    { 1, 6, "ДЮК II", 15.0 },
                    { 2, 5, "САРМАТ", 15.0 },
                    { 3, 8, "EDUARD TOLL", 15.0 },
                    { 4, 8, "GEORGIY USHAKOV", 15.0 },
                    { 5, 8, "RUDOLF SAMOYLOVICH", 15.0 },
                    { 6, 8, "VLADIMIR VORONIN", 15.0 },
                    { 7, 8, "NIKOLAY YEVGENOV", 14.0 },
                    { 8, 8, "CHRISTOPHE DE MARGERIE", 14.0 },
                    { 9, 8, "BORIS VILKITSKY", 19.0 },
                    { 10, 6, "АРКТИКА-2", 19.0 },
                    { 11, 6, "ИНЖЕНЕР ВЕШНЯКОВ", 19.0 },
                    { 12, 5, "ТАМБЕЙ", 19.0 },
                    { 13, 8, "ШТУРМАН АЛЬБАНОВ", 19.0 },
                    { 14, 5, "НИКИФОР БЕГИЧЕВ", 16.0 },
                    { 15, 8, "НОРИЛЬСКИЙ НИКЕЛЬ", 14.0 },
                    { 16, 6, "АЙС ИГЛ", 14.0 },
                    { 17, 8, "ШТУРМАН КОШЕЛЕВ", 15.0 },
                    { 18, 8, "ШТУРМАН ЩЕРБИНИН", 15.0 },
                    { 19, 8, "ШТУРМАН СКУРАТОВ", 15.0 },
                    { 20, 6, "ИОГАНН МАХМАСТАЛЬ", 14.0 },
                    { 21, 8, "BORIS SOKOLOV", 14.0 },
                    { 22, 6, "ИНЖЕНЕР ТРУБИН", 12.0 },
                    { 23, 5, "БАРЕНЦ", 16.0 },
                    { 24, 6, "ПОЛАР КИНГ", 16.0 },
                    { 25, 5, "МЫС ДЕЖНЕВА", 16.0 },
                    { 26, 6, "СЕВМОРПУТЬ", 14.0 },
                    { 27, 5, "ГРИГОРИЙ ШЕЛИХОВ", 14.0 },
                    { 28, 5, "УРАРТУ", 18.0 },
                    { 29, 5, "ФЕСКО ПАРИС", 18.0 },
                    { 30, 5, "ПРОГРЕСС", 18.0 },
                    { 31, 5, "МИХАИЛ БРИТНЕВ", 18.0 },
                    { 32, 5, "САБЕТТА", 16.0 },
                    { 33, 5, "ГЕОРГИЙ УШАКОВ", 16.0 },
                    { 34, 5, "СЕВЕРНЫЙ ПРОЕКТ", 16.0 },
                    { 35, 1, "НИКОЛАЙ ЧУДОТВОРЕЦ", 16.0 },
                    { 36, 5, "БЕРИНГ", 16.0 },
                    { 37, 5, "ТОЛБУХИН", 16.0 },
                    { 38, 5, "ЯМАЛ КРЕЧЕТ", 16.0 },
                    { 39, 5, "CLEAN VISION", 14.0 },
                    { 40, 1, "YAMAL SPIRIT", 14.0 },
                    { 41, 5, "ТИКСИ", 16.0 },
                    { 42, 5, "ТАЙБОЛА", 16.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ShipClass",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShipClass",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShipClass",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ShipClass",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ShipClass",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ShipClass",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ShipClass",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShipClass",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ShipClass",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ShipClass",
                keyColumn: "Id",
                keyValue: 8);

        }
    }
}
