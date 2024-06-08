using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SetGuidToDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "File",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: false),
                    NameExtension = table.Column<string>(type: "text", nullable: false),
                    FilePath = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_File", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GraphData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    PointName = table.Column<string>(type: "text", nullable: false),
                    RepId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraphData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IntegerIceClass",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MinSpeed = table.Column<int>(type: "integer", nullable: false),
                    MaxSpeed = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegerIceClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShipClass",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ShipType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ship",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ShipName = table.Column<string>(type: "text", nullable: false),
                    Speed = table.Column<double>(type: "double precision", nullable: false),
                    ShipClassId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ship_ShipClass_ShipClassId",
                        column: x => x.ShipClassId,
                        principalTable: "ShipClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShipClassIntegerClass",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ShipClassId = table.Column<Guid>(type: "uuid", nullable: false),
                    IntegerIceClassId = table.Column<Guid>(type: "uuid", nullable: false),
                    Debuff = table.Column<bool>(type: "boolean", nullable: false),
                    IsCanSoloMove = table.Column<bool>(type: "boolean", nullable: false),
                    IsCanHelpMove = table.Column<bool>(type: "boolean", nullable: false),
                    DebuffValue = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipClassIntegerClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipClassIntegerClass_IntegerIceClass_IntegerIceClassId",
                        column: x => x.IntegerIceClassId,
                        principalTable: "IntegerIceClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShipClassIntegerClass_ShipClass_ShipClassId",
                        column: x => x.ShipClassId,
                        principalTable: "ShipClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GraphData",
                columns: new[] { "Id", "Latitude", "Longitude", "PointName", "RepId" },
                values: new object[,]
                {
                    { new Guid("02ba7c84-2f9e-4adb-958f-2dea9960d2b0"), 69.900000000000006, 179.0, "пролив Лонга", 2027 },
                    { new Guid("0e193900-1f37-4136-93d2-c332948f4dee"), 69.75, 169.90000000000001, "Рейд Певек", 1006 },
                    { new Guid("15d1f7bb-ad63-4290-aed0-65a28a736603"), 74.0, 76.700000000000003, "Карское - 1 (сбор каравана)", 2006 },
                    { new Guid("1d2600e2-d3b0-4849-ba6a-709720fbb9b8"), 74.599999999999994, 63.899999999999999, "Победа месторождение", 1011 },
                    { new Guid("281a4f1d-16f7-4b5d-8896-524ffac216b3"), 77.700000000000003, 99.5, "пролив Вилькицкого - запад", 2011 },
                    { new Guid("29c81ca1-a170-40bd-abdc-0d5b66d8734c"), 71.739999999999995, 184.69999999999999, "остров Врангеля", 2026 },
                    { new Guid("2babc793-3095-44b1-8207-5e18a56152ca"), 73.099999999999994, 80.0, "Бухта Север и Диксон", 1010 },
                    { new Guid("2c1369ad-2287-4aae-ae7e-c2c7d3d0b612"), 69.400000000000006, 86.150000000000006, "Дудинка", 1007 },
                    { new Guid("2ce903da-f786-4c77-abc2-4b2d31857834"), 73.099999999999994, 72.700000000000003, "Вход в Обскую губу", 2009 },
                    { new Guid("2f73c202-d037-4fcb-ba14-3a4c8a591f67"), 69.900000000000006, 44.600000000000001, "кромка льда на Западе", 2002 },
                    { new Guid("3570fd5c-1f96-428f-807b-d86715e15249"), 76.5, 97.599999999999994, "Таймырский залив", 2010 },
                    { new Guid("38ddc2cf-b955-4820-9234-5251a4dc7b5d"), 73.700000000000003, 109.26000000000001, "Хатангский залив", 1008 },
                    { new Guid("3cc9420f-dba7-48db-8401-960c96c56476"), 65.900000000000006, -169.34999999999999, "Берингов пролив", 2028 },
                    { new Guid("3f1215f9-e1f7-43d9-840b-89e9dd5d8ad8"), 60.700000000000003, 175.30000000000001, "кромка льда на Востоке", 2030 },
                    { new Guid("441e20fe-a97f-40cd-b057-2fdfbff09ec2"), 75.900000000000006, 152.59999999999999, "Лаптевых - 3 (восток)", 2017 },
                    { new Guid("44c4eee8-9567-43bb-94a3-07b83522eeda"), 74.0, 128.09999999999999, "устье Лены", 2019 },
                    { new Guid("4f24e7a9-0b2b-4a4b-83fd-1f125158a16b"), 69.150000000000006, 57.68, "Варандей-Приразломное", 1015 },
                    { new Guid("5685632a-5580-4de5-a9ef-067f1556c7ca"), 77.599999999999994, 107.7, "пролив Вилькицкого - 3", 2013 },
                    { new Guid("596d378f-c315-4156-b58c-9c19b6d71bb8"), 77.299999999999997, 67.700000000000003, "Мыс Желания", 2003 },
                    { new Guid("600f5a18-35a5-40a3-b7b2-78d8ca21c2fd"), 76.700000000000003, 140.80000000000001, "остров Котельный", 2022 },
                    { new Guid("63fbcec7-809a-44e4-ad7d-954add7792a8"), 69.5, 33.75, "Рейд Мурманска", 1001 },
                    { new Guid("68d09485-c84f-4fe8-8030-ce68b276cdd9"), 71.5, 22.0, "Окно в Европу", 2001 },
                    { new Guid("6e8e4022-22a9-46bd-833c-fe8192555cf8"), 69.099999999999994, 169.40000000000001, "мыс.Наглёйнын", 1009 },
                    { new Guid("75de6b98-8576-4e50-ba67-d621149bec19"), 77.799999999999997, 104.09999999999999, "пролив Вилькицкого - восток", 2012 },
                    { new Guid("86d732be-f379-4910-9716-3267539db52e"), 74.900000000000006, 116.7, "Лаптевых - 4 (юг)", 2018 },
                    { new Guid("890b4ebc-1ae2-4893-8fba-b697c751f7c8"), 64.950000000000003, 40.049999999999997, "Архангельск", 1002 },
                    { new Guid("8b8c7fc5-19af-4ec2-b855-30eab15c479e"), 71.0, 73.730000000000004, "терминал Утренний", 1005 },
                    { new Guid("8d21e9d7-0b52-4141-a405-3caf431215e6"), 72.349999999999994, 79.599999999999994, "Лескинское м-е", 1014 },
                    { new Guid("8e49592c-8405-4e55-934b-c7d43ed033e2"), 72.0, 159.5, "Восточно-Сибирское - 2 (запад)", 2024 },
                    { new Guid("90241e65-425e-4cdf-9072-431eeff79375"), 70.700000000000003, 170.5, "Восточно-Сибирское - 1 (восток)", 2023 },
                    { new Guid("97b2acba-4e65-4e32-8254-b05c26f2f1d3"), 68.370000000000005, 54.600000000000001, "МОТ Печора", 1017 },
                    { new Guid("a8f01e4e-bfe4-48e8-9e82-29968e858662"), 70.299999999999997, 57.799999999999997, "Карские ворота", 2005 },
                    { new Guid("bf1ca7df-5ba2-40b4-9ca1-6ae8bca79f76"), 55.700000000000003, 164.25, "Окно в Азию", 2031 },
                    { new Guid("c0b99028-2d0b-4de3-a3a3-7947ffa1429a"), 76.400000000000006, 86.400000000000006, "Карское - 3 (центр)", 2008 },
                    { new Guid("ca22d9a8-ce47-4b09-a489-69651b60bb28"), 76.75, 116.0, "Лаптевых - 1 (центр)", 2015 },
                    { new Guid("cd27f690-d5ec-4a59-a594-aea9651bc9c6"), 74.799999999999997, 84.200000000000003, "Карское - 2 (прибрежный)", 2007 },
                    { new Guid("ce065896-1eab-44e6-947c-d8a4b6509269"), 75.5, 131.5, "Лаптевых - 2 (центр)", 2016 },
                    { new Guid("d6438812-64c7-4115-ac84-d7e0215a3215"), 76.200000000000003, 58.299999999999997, "около Новой Земли", 2004 },
                    { new Guid("dc6ef39c-94b5-4468-ac8b-fd3eeef0d022"), 68.5, 73.700000000000003, "Новый порт", 1004 },
                    { new Guid("de163a55-63ce-4dac-9891-4ebcf5428afd"), 74.299999999999997, 146.69999999999999, "Пролив Санникова - 2", 2021 },
                    { new Guid("de7af488-e464-4bc8-baf4-21b20044fa89"), 73.0, 44.0, "Штокман", 1012 },
                    { new Guid("e30a9443-02bf-4a76-a7cc-af0295db2d26"), 71.299999999999997, 72.150000000000006, "Сабетта", 1003 },
                    { new Guid("e790e641-3891-4064-b123-8514f5f90b3d"), 67.579999999999998, 47.82, "Индига", 1016 },
                    { new Guid("e84d7f20-abfe-4fc5-9fc8-9d0707ca0a7e"), 74.400000000000006, 139.0, "Пролив Санникова - 1", 2020 },
                    { new Guid("ed2f1dcd-8012-41b9-b8d3-42180faab66d"), 64.200000000000003, 188.19999999999999, "Берингово", 2029 },
                    { new Guid("fc6f549a-9d25-4fcc-b2bd-138d47d70364"), 73.5, 169.90000000000001, "Восточно-Сибирское - 3 (север)", 2025 },
                    { new Guid("fe4e4df3-77dd-4d68-b7cd-90415f33ffee"), 72.400000000000006, 65.599999999999994, "Ленинградское-Русановское", 1013 }
                });

            migrationBuilder.InsertData(
                table: "IntegerIceClass",
                columns: new[] { "Id", "MaxSpeed", "MinSpeed" },
                values: new object[,]
                {
                    { new Guid("52322012-7370-4cc5-9465-dd5b8c2ec807"), 19, 15 },
                    { new Guid("716381e8-b93d-4a43-873e-41c4e035ae53"), 21, 20 },
                    { new Guid("fb6a7a09-95ad-4e62-acac-217dd899ad45"), 14, 10 }
                });

            migrationBuilder.InsertData(
                table: "ShipClass",
                columns: new[] { "Id", "ShipType" },
                values: new object[,]
                {
                    { new Guid("49b35e3d-d6fc-405f-a39f-340663d8c622"), "Ice1" },
                    { new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "Arc4" },
                    { new Guid("7b82569c-4c1c-4083-b076-7a1ffd2c16a8"), "Ice3" },
                    { new Guid("a253c1a5-83ae-4217-9daa-f48c562ddd06"), "Ice2" },
                    { new Guid("a3a8f25c-5f0c-4ced-8a16-c20e9b00ec30"), "Arc9-2" },
                    { new Guid("ac31310c-1290-41a6-b013-0a2f895cdc63"), "Arc9-1" },
                    { new Guid("c1760005-d3b5-42ce-88d9-4821e37a2515"), "Arc6" },
                    { new Guid("d28ea89c-95c8-43b1-ba63-46443c02d58c"), "Without class" },
                    { new Guid("f2d3b63f-e026-44e7-915c-70ae695b4b1e"), "Arc5" },
                    { new Guid("ff8b5898-d2a1-4be3-acd5-8f2320e885ce"), "Arc7" }
                });

            migrationBuilder.InsertData(
                table: "Ship",
                columns: new[] { "Id", "ShipClassId", "ShipName", "Speed" },
                values: new object[,]
                {
                    { new Guid("04a8a1dd-941e-489b-9286-bf8b6f9484b4"), new Guid("ff8b5898-d2a1-4be3-acd5-8f2320e885ce"), "NIKOLAY YEVGENOV", 14.0 },
                    { new Guid("07fc7ea1-048f-44d1-adc4-c617be5bde74"), new Guid("ff8b5898-d2a1-4be3-acd5-8f2320e885ce"), "EDUARD TOLL", 15.0 },
                    { new Guid("08bfc7f6-f981-4640-a81f-ea73eb52f8e5"), new Guid("ff8b5898-d2a1-4be3-acd5-8f2320e885ce"), "VLADIMIR VORONIN", 15.0 },
                    { new Guid("0c8e34b5-6c4d-4374-9839-c95022902e53"), new Guid("ff8b5898-d2a1-4be3-acd5-8f2320e885ce"), "BORIS SOKOLOV", 14.0 },
                    { new Guid("0d992970-98e1-4e9e-bb32-9a97e2c87ddd"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "ЯМАЛ КРЕЧЕТ", 16.0 },
                    { new Guid("1b35f469-aa66-4d20-9bb8-deeae4ac09ac"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "БЕРИНГ", 16.0 },
                    { new Guid("239ebab7-61c6-4de3-895b-b1d79805afd4"), new Guid("ff8b5898-d2a1-4be3-acd5-8f2320e885ce"), "GEORGIY USHAKOV", 15.0 },
                    { new Guid("27a4c77d-0e32-497d-acf2-f482a9eb8950"), new Guid("ff8b5898-d2a1-4be3-acd5-8f2320e885ce"), "RUDOLF SAMOYLOVICH", 15.0 },
                    { new Guid("29a9b0cc-cf96-4666-83ed-1422900b85ff"), new Guid("d28ea89c-95c8-43b1-ba63-46443c02d58c"), "НИКОЛАЙ ЧУДОТВОРЕЦ", 16.0 },
                    { new Guid("2dd884a8-9138-44a1-aa11-4b8a488c18ee"), new Guid("ff8b5898-d2a1-4be3-acd5-8f2320e885ce"), "ШТУРМАН СКУРАТОВ", 15.0 },
                    { new Guid("3072968a-ff0b-4b16-844a-0afadc2ebdba"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "ГРИГОРИЙ ШЕЛИХОВ", 14.0 },
                    { new Guid("521435e2-8a58-4363-b10c-7853d59148ea"), new Guid("f2d3b63f-e026-44e7-915c-70ae695b4b1e"), "АРКТИКА-2", 19.0 },
                    { new Guid("5ade09a1-3805-46dd-bdb7-ed6cb2b500a0"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "САБЕТТА", 16.0 },
                    { new Guid("63b8cd88-66da-4785-98da-e0f98b2d8a54"), new Guid("f2d3b63f-e026-44e7-915c-70ae695b4b1e"), "ИНЖЕНЕР ТРУБИН", 12.0 },
                    { new Guid("66f3e18c-6183-4c32-9c36-9e7fe42c2225"), new Guid("f2d3b63f-e026-44e7-915c-70ae695b4b1e"), "АЙС ИГЛ", 14.0 },
                    { new Guid("6848bc60-2d88-4fe6-a513-aefb7631f67c"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "УРАРТУ", 18.0 },
                    { new Guid("7397091a-a993-4131-a29f-ff9777386263"), new Guid("f2d3b63f-e026-44e7-915c-70ae695b4b1e"), "ИОГАНН МАХМАСТАЛЬ", 14.0 },
                    { new Guid("7b030864-2f86-48d0-ab6b-d78578381a4a"), new Guid("f2d3b63f-e026-44e7-915c-70ae695b4b1e"), "ДЮК II", 15.0 },
                    { new Guid("94a247e0-1066-4b6e-a9cd-d7fbdb3d6069"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "НИКИФОР БЕГИЧЕВ", 16.0 },
                    { new Guid("99fd9224-c3ec-4c73-a441-800ef9ae4e49"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "CLEAN VISION", 14.0 },
                    { new Guid("9a1a53d5-7e23-453e-8581-6b0d4f28cf99"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "МЫС ДЕЖНЕВА", 16.0 },
                    { new Guid("a9af71a8-4600-4c87-9634-3e579f64abcb"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "ГЕОРГИЙ УШАКОВ", 16.0 },
                    { new Guid("ab8d0789-99a0-4c86-aa05-f1d123ea7f1f"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "ТИКСИ", 16.0 },
                    { new Guid("b4c12b3c-ea21-4958-827e-cd27af5e827c"), new Guid("ff8b5898-d2a1-4be3-acd5-8f2320e885ce"), "CHRISTOPHE DE MARGERIE", 14.0 },
                    { new Guid("b54a07ec-72cf-452f-a051-c56aeb7edd6b"), new Guid("ff8b5898-d2a1-4be3-acd5-8f2320e885ce"), "ШТУРМАН КОШЕЛЕВ", 15.0 },
                    { new Guid("b8b812bb-21ce-47be-8f3a-84dc7542add8"), new Guid("f2d3b63f-e026-44e7-915c-70ae695b4b1e"), "ИНЖЕНЕР ВЕШНЯКОВ", 19.0 },
                    { new Guid("bf373b3c-5434-406b-8309-45109e1b9893"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "ТАМБЕЙ", 19.0 },
                    { new Guid("c20e4f9e-2721-45b1-b045-26e11e76ebef"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "ФЕСКО ПАРИС", 18.0 },
                    { new Guid("c64fd006-ef94-4be4-b868-a5f8104dcd5d"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "ТОЛБУХИН", 16.0 },
                    { new Guid("c88bb079-4420-4f24-87de-a6271c1d216b"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "ТАЙБОЛА", 16.0 },
                    { new Guid("cd987331-6a58-4f66-84bd-faa59efd4ece"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "САРМАТ", 15.0 },
                    { new Guid("d09a0578-ba93-410d-94fd-8943baa95a7c"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "СЕВЕРНЫЙ ПРОЕКТ", 16.0 },
                    { new Guid("dbbf664a-8b38-4fbd-8c71-73c080ec5bd3"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "МИХАИЛ БРИТНЕВ", 18.0 },
                    { new Guid("de8a0803-5a2c-46f0-b778-d09e53cccae1"), new Guid("f2d3b63f-e026-44e7-915c-70ae695b4b1e"), "ПОЛАР КИНГ", 16.0 },
                    { new Guid("e2f6e432-9f05-4c5c-aa48-65057b42c7a9"), new Guid("ff8b5898-d2a1-4be3-acd5-8f2320e885ce"), "НОРИЛЬСКИЙ НИКЕЛЬ", 14.0 },
                    { new Guid("e8813678-9ff1-4e11-b8be-fd44dce7a3fe"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "ПРОГРЕСС", 18.0 },
                    { new Guid("e8aa5d6e-4b0d-4a80-a478-3c0b8049caab"), new Guid("ff8b5898-d2a1-4be3-acd5-8f2320e885ce"), "ШТУРМАН ЩЕРБИНИН", 15.0 },
                    { new Guid("e958b7ab-bc0e-4b1e-ad34-431c5f995ec8"), new Guid("f2d3b63f-e026-44e7-915c-70ae695b4b1e"), "СЕВМОРПУТЬ", 14.0 },
                    { new Guid("ea46a007-08d6-4c5a-ad49-38df90ff67ac"), new Guid("ff8b5898-d2a1-4be3-acd5-8f2320e885ce"), "ШТУРМАН АЛЬБАНОВ", 19.0 },
                    { new Guid("f5d86c42-5d26-4d78-9710-e060677ede63"), new Guid("ff8b5898-d2a1-4be3-acd5-8f2320e885ce"), "BORIS VILKITSKY", 19.0 },
                    { new Guid("f82386ea-3c86-4dca-87bc-3fd6eaad3d8f"), new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e"), "БАРЕНЦ", 16.0 },
                    { new Guid("fd65953f-9f79-46f2-975a-aaadbadeff71"), new Guid("d28ea89c-95c8-43b1-ba63-46443c02d58c"), "YAMAL SPIRIT", 14.0 }
                });

            migrationBuilder.InsertData(
                table: "ShipClassIntegerClass",
                columns: new[] { "Id", "Debuff", "DebuffValue", "IntegerIceClassId", "IsCanHelpMove", "IsCanSoloMove", "ShipClassId" },
                values: new object[,]
                {
                    { new Guid("055c4950-bf85-4bb2-9803-df9b300a61ba"), true, 0.80000000000000004, new Guid("52322012-7370-4cc5-9465-dd5b8c2ec807"), true, false, new Guid("f2d3b63f-e026-44e7-915c-70ae695b4b1e") },
                    { new Guid("0635daf6-6ecb-413f-a8fa-8ec18bc19a8b"), false, 1.0, new Guid("52322012-7370-4cc5-9465-dd5b8c2ec807"), true, false, new Guid("49b35e3d-d6fc-405f-a39f-340663d8c622") },
                    { new Guid("0a05f59d-a45b-4663-a4af-0750ca5a4aa3"), true, 0.69999999999999996, new Guid("fb6a7a09-95ad-4e62-acac-217dd899ad45"), true, false, new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e") },
                    { new Guid("0b965bc5-9a48-4783-8b3a-0e8a0d5e4f73"), false, 1.0, new Guid("716381e8-b93d-4a43-873e-41c4e035ae53"), false, true, new Guid("d28ea89c-95c8-43b1-ba63-46443c02d58c") },
                    { new Guid("15297413-4fd1-4d11-ab97-e527a3c3f801"), true, 0.69999999999999996, new Guid("fb6a7a09-95ad-4e62-acac-217dd899ad45"), true, false, new Guid("f2d3b63f-e026-44e7-915c-70ae695b4b1e") },
                    { new Guid("1dcec9c2-e343-4b0d-b003-79ce20a02c7b"), false, 1.0, new Guid("716381e8-b93d-4a43-873e-41c4e035ae53"), false, true, new Guid("f2d3b63f-e026-44e7-915c-70ae695b4b1e") },
                    { new Guid("20175b78-a758-4a21-9557-1ef89a239626"), false, 1.0, new Guid("fb6a7a09-95ad-4e62-acac-217dd899ad45"), false, false, new Guid("49b35e3d-d6fc-405f-a39f-340663d8c622") },
                    { new Guid("219d7d0f-dcac-40a4-a38e-a8ca4a214418"), true, 0.59999999999999998, new Guid("52322012-7370-4cc5-9465-dd5b8c2ec807"), true, false, new Guid("ff8b5898-d2a1-4be3-acd5-8f2320e885ce") },
                    { new Guid("2dd7f476-6e79-4682-b2d1-d575d1be1289"), true, 0.75, new Guid("fb6a7a09-95ad-4e62-acac-217dd899ad45"), false, true, new Guid("a3a8f25c-5f0c-4ced-8a16-c20e9b00ec30") },
                    { new Guid("2fe01a5c-003f-4ca2-a020-b1eec46bf98a"), true, 0.80000000000000004, new Guid("52322012-7370-4cc5-9465-dd5b8c2ec807"), true, false, new Guid("c1760005-d3b5-42ce-88d9-4821e37a2515") },
                    { new Guid("41b7b75c-1cab-431e-964e-83e2cf265bfa"), false, 1.0, new Guid("716381e8-b93d-4a43-873e-41c4e035ae53"), false, true, new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e") },
                    { new Guid("43bcc9f0-811f-4b6e-acb5-0bf24c08c994"), false, 1.0, new Guid("716381e8-b93d-4a43-873e-41c4e035ae53"), false, true, new Guid("a3a8f25c-5f0c-4ced-8a16-c20e9b00ec30") },
                    { new Guid("482ee419-1bde-4874-85c7-743cf8aa4c57"), false, 1.0, new Guid("716381e8-b93d-4a43-873e-41c4e035ae53"), false, true, new Guid("ff8b5898-d2a1-4be3-acd5-8f2320e885ce") },
                    { new Guid("578aac67-8c4a-4526-be4a-df7cd45b5070"), false, 1.0, new Guid("52322012-7370-4cc5-9465-dd5b8c2ec807"), true, false, new Guid("d28ea89c-95c8-43b1-ba63-46443c02d58c") },
                    { new Guid("5b38e425-2b84-4279-bf7e-fd317c182b30"), false, 1.0, new Guid("716381e8-b93d-4a43-873e-41c4e035ae53"), false, true, new Guid("7b82569c-4c1c-4083-b076-7a1ffd2c16a8") },
                    { new Guid("5ec177d0-1bb2-48e5-81a8-87f284332b5f"), false, 1.0, new Guid("fb6a7a09-95ad-4e62-acac-217dd899ad45"), false, false, new Guid("d28ea89c-95c8-43b1-ba63-46443c02d58c") },
                    { new Guid("70cb16ed-b9f7-4eb1-9401-c752ff475e19"), false, 1.0, new Guid("716381e8-b93d-4a43-873e-41c4e035ae53"), false, true, new Guid("c1760005-d3b5-42ce-88d9-4821e37a2515") },
                    { new Guid("729d8232-a0c7-4616-890b-c77452b1e0dc"), true, 0.14999999999999999, new Guid("fb6a7a09-95ad-4e62-acac-217dd899ad45"), true, false, new Guid("ff8b5898-d2a1-4be3-acd5-8f2320e885ce") },
                    { new Guid("8a217850-ab70-4a21-8a5d-072b9e5de22c"), false, 1.0, new Guid("fb6a7a09-95ad-4e62-acac-217dd899ad45"), false, true, new Guid("ac31310c-1290-41a6-b013-0a2f895cdc63") },
                    { new Guid("8c2e81e3-bd55-42d7-ae22-e7a750cd83a7"), false, 1.0, new Guid("716381e8-b93d-4a43-873e-41c4e035ae53"), false, true, new Guid("ac31310c-1290-41a6-b013-0a2f895cdc63") },
                    { new Guid("a22765fe-da70-42b6-b901-ec1fac292219"), true, 0.80000000000000004, new Guid("52322012-7370-4cc5-9465-dd5b8c2ec807"), true, false, new Guid("69155bb6-229c-4a7b-87d4-3b9072c6cd8e") },
                    { new Guid("ae37ec78-b6b7-4d4e-bb4c-e5dd65dd20fd"), false, 1.0, new Guid("fb6a7a09-95ad-4e62-acac-217dd899ad45"), false, false, new Guid("7b82569c-4c1c-4083-b076-7a1ffd2c16a8") },
                    { new Guid("c7a74df5-7ac2-4181-afc9-70ad87c5416a"), true, 0.69999999999999996, new Guid("fb6a7a09-95ad-4e62-acac-217dd899ad45"), true, false, new Guid("c1760005-d3b5-42ce-88d9-4821e37a2515") },
                    { new Guid("d72f6b94-bc74-4283-9936-27c1d59a44dc"), false, 1.0, new Guid("52322012-7370-4cc5-9465-dd5b8c2ec807"), true, false, new Guid("7b82569c-4c1c-4083-b076-7a1ffd2c16a8") },
                    { new Guid("dbdf4fa4-6d25-41a4-874c-f6e67261b383"), true, 0.90000000000000002, new Guid("52322012-7370-4cc5-9465-dd5b8c2ec807"), false, true, new Guid("a3a8f25c-5f0c-4ced-8a16-c20e9b00ec30") },
                    { new Guid("e9eb5d56-c26a-4f1c-90ff-8bfaf872e9a6"), false, 1.0, new Guid("52322012-7370-4cc5-9465-dd5b8c2ec807"), true, false, new Guid("a253c1a5-83ae-4217-9daa-f48c562ddd06") },
                    { new Guid("f411c13d-c65e-4737-981a-9bb708243960"), false, 1.0, new Guid("716381e8-b93d-4a43-873e-41c4e035ae53"), false, true, new Guid("49b35e3d-d6fc-405f-a39f-340663d8c622") },
                    { new Guid("fa763465-19f5-4f0c-a73e-86d3c3e4c984"), false, 1.0, new Guid("716381e8-b93d-4a43-873e-41c4e035ae53"), false, true, new Guid("a253c1a5-83ae-4217-9daa-f48c562ddd06") },
                    { new Guid("fd32093b-71d9-4b27-a32b-6603a17bc409"), false, 1.0, new Guid("fb6a7a09-95ad-4e62-acac-217dd899ad45"), false, false, new Guid("a253c1a5-83ae-4217-9daa-f48c562ddd06") },
                    { new Guid("fecf6924-d4c7-4fad-8d09-895d15df3e9a"), false, 1.0, new Guid("52322012-7370-4cc5-9465-dd5b8c2ec807"), false, true, new Guid("ac31310c-1290-41a6-b013-0a2f895cdc63") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ship_ShipClassId",
                table: "Ship",
                column: "ShipClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipClassIntegerClass_IntegerIceClassId",
                table: "ShipClassIntegerClass",
                column: "IntegerIceClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipClassIntegerClass_ShipClassId",
                table: "ShipClassIntegerClass",
                column: "ShipClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "File");

            migrationBuilder.DropTable(
                name: "GraphData");

            migrationBuilder.DropTable(
                name: "Ship");

            migrationBuilder.DropTable(
                name: "ShipClassIntegerClass");

            migrationBuilder.DropTable(
                name: "IntegerIceClass");

            migrationBuilder.DropTable(
                name: "ShipClass");
        }
    }
}
