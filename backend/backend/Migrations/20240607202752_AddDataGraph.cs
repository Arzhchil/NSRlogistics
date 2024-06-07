using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddDataGraph : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GraphData",
                columns: new[] { "Id", "Latitude", "Longitude", "PointName", "RepId" },
                values: new object[,]
                {
                    { 1, 73.099999999999994, 80.0, "Бухта Север и Диксон", 1010 },
                    { 2, 69.400000000000006, 86.150000000000006, "Дудинка", 1007 },
                    { 3, 69.900000000000006, 44.600000000000001, "кромка льда на Западе", 2002 },
                    { 4, 69.150000000000006, 57.68, "Варандей-Приразломное", 1015 },
                    { 5, 73.0, 44.0, "Штокман", 1012 },
                    { 6, 71.5, 22.0, "Окно в Европу", 2001 },
                    { 7, 74.599999999999994, 63.899999999999999, "Победа месторождение", 1011 },
                    { 8, 76.400000000000006, 86.400000000000006, "Карское - 3 (центр)", 2008 },
                    { 9, 77.599999999999994, 107.7, "пролив Вилькицкого - 3", 2013 },
                    { 10, 74.900000000000006, 116.7, "Лаптевых - 4 (юг)", 2018 },
                    { 11, 73.099999999999994, 72.700000000000003, "Вход в Обскую губу", 2009 },
                    { 12, 68.5, 73.700000000000003, "Новый порт", 1004 },
                    { 13, 76.75, 116.0, "Лаптевых - 1 (центр)", 2015 },
                    { 14, 74.0, 76.700000000000003, "Карское - 1 (сбор каравана)", 2006 },
                    { 15, 72.349999999999994, 79.599999999999994, "Лескинское м-е", 1014 },
                    { 16, 70.299999999999997, 57.799999999999997, "Карские ворота", 2005 },
                    { 17, 77.299999999999997, 67.700000000000003, "Мыс Желания", 2003 },
                    { 18, 71.739999999999995, 184.69999999999999, "остров Врангеля", 2026 },
                    { 19, 70.700000000000003, 170.5, "Восточно-Сибирское - 1 (восток)", 2023 },
                    { 20, 77.799999999999997, 104.09999999999999, "пролив Вилькицкого - восток", 2012 },
                    { 21, 77.700000000000003, 99.5, "пролив Вилькицкого - запад", 2011 },
                    { 22, 76.200000000000003, 58.299999999999997, "около Новой Земли", 2004 },
                    { 23, 74.400000000000006, 139.0, "Пролив Санникова - 1", 2020 },
                    { 24, 74.299999999999997, 146.69999999999999, "Пролив Санникова - 2", 2021 },
                    { 25, 74.0, 128.09999999999999, "устье Лены", 2019 },
                    { 26, 71.299999999999997, 72.150000000000006, "Сабетта", 1003 },
                    { 27, 69.099999999999994, 169.40000000000001, "мыс.Наглёйнын", 1009 },
                    { 28, 69.900000000000006, 179.0, "пролив Лонга", 2027 },
                    { 29, 73.5, 169.90000000000001, "Восточно-Сибирское - 3 (север)", 2025 },
                    { 30, 64.950000000000003, 40.049999999999997, "Архангельск", 1002 },
                    { 31, 75.900000000000006, 152.59999999999999, "Лаптевых - 3 (восток)", 2017 },
                    { 32, 68.370000000000005, 54.600000000000001, "МОТ Печора", 1017 },
                    { 33, 73.700000000000003, 109.26000000000001, "Хатангский залив", 1008 },
                    { 34, 72.0, 159.5, "Восточно-Сибирское - 2 (запад)", 2024 },
                    { 35, 72.400000000000006, 65.599999999999994, "Ленинградское-Русановское", 1013 },
                    { 36, 71.0, 73.730000000000004, "терминал Утренний", 1005 },
                    { 37, 76.5, 97.599999999999994, "Таймырский залив", 2010 },
                    { 38, 64.200000000000003, 188.19999999999999, "Берингово", 2029 },
                    { 39, 60.700000000000003, 175.30000000000001, "кромка льда на Востоке", 2030 },
                    { 40, 69.75, 169.90000000000001, "Рейд Певек", 1006 },
                    { 41, 75.5, 131.5, "Лаптевых - 2 (центр)", 2016 },
                    { 42, 69.5, 33.75, "Рейд Мурманска", 1001 },
                    { 43, 76.700000000000003, 140.80000000000001, "остров Котельный", 2022 },
                    { 44, 74.799999999999997, 84.200000000000003, "Карское - 2 (прибрежный)", 2007 },
                    { 45, 67.579999999999998, 47.82, "Индига", 1016 },
                    { 46, 65.900000000000006, -169.34999999999999, "Берингов пролив", 2028 },
                    { 47, 55.700000000000003, 164.25, "Окно в Азию", 2031 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "GraphData",
                keyColumn: "Id",
                keyValue: 47);
        }
    }
}
