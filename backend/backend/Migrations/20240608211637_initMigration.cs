using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class initMigration : Migration
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
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StartId = table.Column<Guid>(type: "uuid", nullable: false),
                    FinishId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Routes_GraphData_FinishId",
                        column: x => x.FinishId,
                        principalTable: "GraphData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Routes_GraphData_StartId",
                        column: x => x.StartId,
                        principalTable: "GraphData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { new Guid("00751ab9-add0-47bb-8f1b-16d6dd68d6de"), 73.0, 44.0, "Штокман", 1012 },
                    { new Guid("029c69a9-be1d-45e2-8283-ca026440943f"), 75.900000000000006, 152.59999999999999, "Лаптевых - 3 (восток)", 2017 },
                    { new Guid("030302a4-8ea1-4bd0-9459-bb28095bb638"), 73.099999999999994, 80.0, "Бухта Север и Диксон", 1010 },
                    { new Guid("0d1d323b-0fa6-4845-a41f-584603ba954f"), 71.0, 73.730000000000004, "терминал Утренний", 1005 },
                    { new Guid("1afd138d-5f66-4777-9bdf-8a787cac36a5"), 72.349999999999994, 79.599999999999994, "Лескинское м-е", 1014 },
                    { new Guid("237bbc63-31dc-496c-b9ec-1918018adda6"), 70.299999999999997, 57.799999999999997, "Карские ворота", 2005 },
                    { new Guid("247bb4cc-995b-43ba-b8c4-cf241eabab77"), 76.400000000000006, 86.400000000000006, "Карское - 3 (центр)", 2008 },
                    { new Guid("272b0c32-5473-4e26-834e-3e0a3c3d0f05"), 69.400000000000006, 86.150000000000006, "Дудинка", 1007 },
                    { new Guid("33d4c9f5-1db3-4975-a7b6-64e957df99f8"), 72.0, 159.5, "Восточно-Сибирское - 2 (запад)", 2024 },
                    { new Guid("34fe89bc-f35a-495d-ab76-5b90dd7f444c"), 77.599999999999994, 107.7, "пролив Вилькицкого - 3", 2013 },
                    { new Guid("356e23b0-9be7-4454-b745-f158bc9b5e1a"), 71.5, 22.0, "Окно в Европу", 2001 },
                    { new Guid("3f9ebd80-1db0-4f79-91e7-ebe8ee61adfd"), 74.0, 76.700000000000003, "Карское - 1 (сбор каравана)", 2006 },
                    { new Guid("4dd67b25-d17e-451a-9456-f47550d0b5c8"), 74.900000000000006, 116.7, "Лаптевых - 4 (юг)", 2018 },
                    { new Guid("4f2d6260-a66f-40b0-ac0f-9bf6fcb165bb"), 67.579999999999998, 47.82, "Индига", 1016 },
                    { new Guid("58d9de3f-a54e-4684-931f-b05ee82cecc2"), 75.5, 131.5, "Лаптевых - 2 (центр)", 2016 },
                    { new Guid("5a70e986-3b7d-4016-9d1f-2797b4d158a6"), 69.900000000000006, 44.600000000000001, "кромка льда на Западе", 2002 },
                    { new Guid("60d08494-7e75-428e-a883-9851223b71d6"), 65.900000000000006, -169.34999999999999, "Берингов пролив", 2028 },
                    { new Guid("670485f2-ad26-4efe-83a2-744e5fd6ed15"), 73.5, 169.90000000000001, "Восточно-Сибирское - 3 (север)", 2025 },
                    { new Guid("6739b2c9-d7de-4cb7-a335-35da6ad66298"), 70.700000000000003, 170.5, "Восточно-Сибирское - 1 (восток)", 2023 },
                    { new Guid("68c3c0cd-eb1d-46e8-84f9-978560b96065"), 68.370000000000005, 54.600000000000001, "МОТ Печора", 1017 },
                    { new Guid("6caa5f14-0795-48a1-84d5-c70040bc4029"), 71.739999999999995, 184.69999999999999, "остров Врангеля", 2026 },
                    { new Guid("6d537a45-4059-47ef-ae8c-1f31a915fd7a"), 76.200000000000003, 58.299999999999997, "около Новой Земли", 2004 },
                    { new Guid("7bbb9eec-b8b5-4bc0-b58f-b11950daf5c8"), 74.400000000000006, 139.0, "Пролив Санникова - 1", 2020 },
                    { new Guid("8f8e38cc-5227-4d89-82ef-c0e8aa6f685c"), 74.299999999999997, 146.69999999999999, "Пролив Санникова - 2", 2021 },
                    { new Guid("920fe75f-5f44-4f86-aa6f-b29a88a9a628"), 74.799999999999997, 84.200000000000003, "Карское - 2 (прибрежный)", 2007 },
                    { new Guid("93f8d895-e4a1-484b-894e-89d383e875cc"), 77.799999999999997, 104.09999999999999, "пролив Вилькицкого - восток", 2012 },
                    { new Guid("9720f452-8246-4ac7-ba57-b694302fac7b"), 60.700000000000003, 175.30000000000001, "кромка льда на Востоке", 2030 },
                    { new Guid("9e933083-ecf5-4075-8b9f-765b89e6f9b6"), 76.5, 97.599999999999994, "Таймырский залив", 2010 },
                    { new Guid("a121c108-df8d-4b68-8707-1b4fd3fec91d"), 74.599999999999994, 63.899999999999999, "Победа месторождение", 1011 },
                    { new Guid("a2118961-a92d-4894-b9fb-d1a469938dac"), 68.5, 73.700000000000003, "Новый порт", 1004 },
                    { new Guid("a3e16dea-5fa1-4da8-b541-69b3f54b89c5"), 73.700000000000003, 109.26000000000001, "Хатангский залив", 1008 },
                    { new Guid("acb1cb6b-2c2a-4533-90e6-48dc5d17dafc"), 69.150000000000006, 57.68, "Варандей-Приразломное", 1015 },
                    { new Guid("ae87bebd-ea73-41e6-819c-6931c94d4d7e"), 64.950000000000003, 40.049999999999997, "Архангельск", 1002 },
                    { new Guid("af8f93a9-811e-46c9-ab08-8b60c0aeb761"), 73.099999999999994, 72.700000000000003, "Вход в Обскую губу", 2009 },
                    { new Guid("ba5685fa-9397-4279-a145-98de1f2b70b9"), 76.75, 116.0, "Лаптевых - 1 (центр)", 2015 },
                    { new Guid("bc71b01c-1565-4b6d-8715-dde5d7d45e8d"), 71.299999999999997, 72.150000000000006, "Сабетта", 1003 },
                    { new Guid("bf794ef6-7a9e-409b-95fd-1f6f1800cf4a"), 77.299999999999997, 67.700000000000003, "Мыс Желания", 2003 },
                    { new Guid("d60efd73-ef0e-4eb9-8a9e-147f75635040"), 72.400000000000006, 65.599999999999994, "Ленинградское-Русановское", 1013 },
                    { new Guid("e1bbe114-4c7f-45f6-85ba-e7ba5e6cba47"), 74.0, 128.09999999999999, "устье Лены", 2019 },
                    { new Guid("e1f80466-12ac-4727-b5e6-84030cd856ea"), 55.700000000000003, 164.25, "Окно в Азию", 2031 },
                    { new Guid("eaa44e26-7421-435d-8f12-a1ac466b30db"), 77.700000000000003, 99.5, "пролив Вилькицкого - запад", 2011 },
                    { new Guid("efa5035f-aefe-4131-9236-43dab0af826d"), 69.099999999999994, 169.40000000000001, "мыс.Наглёйнын", 1009 },
                    { new Guid("f2f49549-21df-422d-8e4a-7a8fa2b2ffb9"), 76.700000000000003, 140.80000000000001, "остров Котельный", 2022 },
                    { new Guid("f625f4b6-50b9-4579-9302-8d924a773c07"), 69.900000000000006, 179.0, "пролив Лонга", 2027 },
                    { new Guid("f8339e56-89bf-4088-bde3-b481c49c06ff"), 69.75, 169.90000000000001, "Рейд Певек", 1006 },
                    { new Guid("fa4215f1-f69b-456e-b078-a20e90d620e0"), 69.5, 33.75, "Рейд Мурманска", 1001 },
                    { new Guid("fb61a824-0352-4ea3-8c3e-af3a0395d6c3"), 64.200000000000003, 188.19999999999999, "Берингово", 2029 }
                });

            migrationBuilder.InsertData(
                table: "IntegerIceClass",
                columns: new[] { "Id", "MaxSpeed", "MinSpeed" },
                values: new object[,]
                {
                    { new Guid("6f4e129c-9295-4571-874a-a10fd5005272"), 14, 10 },
                    { new Guid("9b833e38-03f3-455a-8c37-b19767a822e8"), 21, 20 },
                    { new Guid("a3bac6dd-3020-44ae-814d-34c5a6229997"), 19, 15 }
                });

            migrationBuilder.InsertData(
                table: "ShipClass",
                columns: new[] { "Id", "ShipType" },
                values: new object[,]
                {
                    { new Guid("186215e1-6d55-4dba-8683-8d08e1167e3a"), "Arc9-1" },
                    { new Guid("3b224b81-766d-4d08-900f-73308c6df48b"), "Without class" },
                    { new Guid("422087f6-9289-4e18-bd45-d2bf74eaf7aa"), "Arc5" },
                    { new Guid("578f810c-a3f7-4102-a53c-968b2d9aaa58"), "Ice2" },
                    { new Guid("5c6c234e-912f-46b1-958b-ec35a3985e45"), "Arc7" },
                    { new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "Arc4" },
                    { new Guid("98423e8d-2e0c-4429-866e-13be3bbf93bb"), "Arc9-2" },
                    { new Guid("a2fdd3ba-4f18-418d-bbe4-890ee233cf49"), "Arc6" },
                    { new Guid("a6430f42-393b-4c8f-8844-047436c8fb6f"), "Ice3" },
                    { new Guid("c33d30c9-3c3a-48ca-9abf-ba5d4c5437b5"), "Ice1" }
                });

            migrationBuilder.InsertData(
                table: "Ship",
                columns: new[] { "Id", "ShipClassId", "ShipName", "Speed" },
                values: new object[,]
                {
                    { new Guid("23082ea7-477d-427e-b8a4-e43c02eda600"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "ГЕОРГИЙ УШАКОВ", 16.0 },
                    { new Guid("295f2beb-ea35-4ae9-95e4-0c63b2a1cbc8"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "БАРЕНЦ", 16.0 },
                    { new Guid("327a8bec-15d1-450d-878e-409224266ede"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "ТОЛБУХИН", 16.0 },
                    { new Guid("3e96866e-bc47-463e-a163-518a802b6cda"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "ТИКСИ", 16.0 },
                    { new Guid("4bc5a1a7-7815-44d8-ae58-ca1e4d73b77b"), new Guid("422087f6-9289-4e18-bd45-d2bf74eaf7aa"), "ИОГАНН МАХМАСТАЛЬ", 14.0 },
                    { new Guid("50ec86fa-b179-43c9-9730-a1e71bced3f8"), new Guid("422087f6-9289-4e18-bd45-d2bf74eaf7aa"), "ИНЖЕНЕР ВЕШНЯКОВ", 19.0 },
                    { new Guid("54b84fe1-c7c9-457d-b5cb-c0a8dc520190"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "МИХАИЛ БРИТНЕВ", 18.0 },
                    { new Guid("56201e33-5a91-4856-8fa9-722361449fac"), new Guid("5c6c234e-912f-46b1-958b-ec35a3985e45"), "ШТУРМАН КОШЕЛЕВ", 15.0 },
                    { new Guid("5c889d8d-55e4-4926-bc58-5e66e8678d05"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "ГРИГОРИЙ ШЕЛИХОВ", 14.0 },
                    { new Guid("5e4bfeee-112f-4ed8-9a40-681e6313cba3"), new Guid("5c6c234e-912f-46b1-958b-ec35a3985e45"), "ШТУРМАН СКУРАТОВ", 15.0 },
                    { new Guid("5f535ee9-6bce-4e02-9d98-8088fc9ed096"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "УРАРТУ", 18.0 },
                    { new Guid("6a928fe6-2839-4672-a665-f0d359a09248"), new Guid("3b224b81-766d-4d08-900f-73308c6df48b"), "НИКОЛАЙ ЧУДОТВОРЕЦ", 16.0 },
                    { new Guid("6d386634-4e8a-46b5-b833-8348c3811a2f"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "БЕРИНГ", 16.0 },
                    { new Guid("7440ec23-9c61-4740-99fd-5e93348367d6"), new Guid("422087f6-9289-4e18-bd45-d2bf74eaf7aa"), "АЙС ИГЛ", 14.0 },
                    { new Guid("7d19615e-425c-44bf-b00a-0974855e1248"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "ТАЙБОЛА", 16.0 },
                    { new Guid("840b1afc-a4e1-4967-a70c-3303e0a5f79f"), new Guid("5c6c234e-912f-46b1-958b-ec35a3985e45"), "VLADIMIR VORONIN", 15.0 },
                    { new Guid("920c8216-5f82-4d59-86ee-fc3bf044a890"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "ЯМАЛ КРЕЧЕТ", 16.0 },
                    { new Guid("992ac8df-f761-4023-a673-4e8ae2232ee7"), new Guid("422087f6-9289-4e18-bd45-d2bf74eaf7aa"), "ИНЖЕНЕР ТРУБИН", 12.0 },
                    { new Guid("a1b3e7aa-54fd-4c8d-b665-2280b5c4edc6"), new Guid("422087f6-9289-4e18-bd45-d2bf74eaf7aa"), "ПОЛАР КИНГ", 16.0 },
                    { new Guid("a840798a-4b8e-4e56-be6c-2027235f883c"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "САРМАТ", 15.0 },
                    { new Guid("a892d560-abd8-41d8-acb1-c3d13dc3d5e4"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "СЕВЕРНЫЙ ПРОЕКТ", 16.0 },
                    { new Guid("ab8ef165-eea3-4b29-b092-d0ffca69e816"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "ТАМБЕЙ", 19.0 },
                    { new Guid("b8703914-748b-4c98-8a5f-5c1ffb6ea76d"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "CLEAN VISION", 14.0 },
                    { new Guid("b9253c68-6604-45e0-95f1-5525ae6b18eb"), new Guid("422087f6-9289-4e18-bd45-d2bf74eaf7aa"), "СЕВМОРПУТЬ", 14.0 },
                    { new Guid("b9bc23cd-73fd-413c-9eba-d0e0c318b45e"), new Guid("3b224b81-766d-4d08-900f-73308c6df48b"), "YAMAL SPIRIT", 14.0 },
                    { new Guid("bc87cddd-e3a3-4163-84a5-7170a83a6a34"), new Guid("5c6c234e-912f-46b1-958b-ec35a3985e45"), "BORIS VILKITSKY", 19.0 },
                    { new Guid("be73c83c-3488-4bff-b074-39542d65b175"), new Guid("5c6c234e-912f-46b1-958b-ec35a3985e45"), "NIKOLAY YEVGENOV", 14.0 },
                    { new Guid("bed696aa-0244-440d-951e-a869a14bec97"), new Guid("5c6c234e-912f-46b1-958b-ec35a3985e45"), "RUDOLF SAMOYLOVICH", 15.0 },
                    { new Guid("bfe8a943-6ff1-4ef5-84b9-cacd75e6432b"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "ПРОГРЕСС", 18.0 },
                    { new Guid("c852cc2d-4fc0-4498-aa03-d3e379cd83c1"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "САБЕТТА", 16.0 },
                    { new Guid("ce939757-5d60-4e37-b937-2d2c675ca738"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "МЫС ДЕЖНЕВА", 16.0 },
                    { new Guid("d70dee56-7e16-4226-b4ba-766d882fae07"), new Guid("5c6c234e-912f-46b1-958b-ec35a3985e45"), "ШТУРМАН АЛЬБАНОВ", 19.0 },
                    { new Guid("da0883af-f9e4-4b46-9944-36474b9cf017"), new Guid("5c6c234e-912f-46b1-958b-ec35a3985e45"), "CHRISTOPHE DE MARGERIE", 14.0 },
                    { new Guid("da69fa8e-841c-433d-b19e-e6a75e72cd1f"), new Guid("5c6c234e-912f-46b1-958b-ec35a3985e45"), "GEORGIY USHAKOV", 15.0 },
                    { new Guid("dad6ecc5-2b53-43c7-8657-212a80c06f28"), new Guid("422087f6-9289-4e18-bd45-d2bf74eaf7aa"), "ДЮК II", 15.0 },
                    { new Guid("e2cf4fc8-9559-443a-9c88-c7aa5a47284a"), new Guid("5c6c234e-912f-46b1-958b-ec35a3985e45"), "НОРИЛЬСКИЙ НИКЕЛЬ", 14.0 },
                    { new Guid("e6a367cc-2ab5-42d4-add7-da527e109858"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "ФЕСКО ПАРИС", 18.0 },
                    { new Guid("e7274801-366f-4de8-9d39-b3a851222bc2"), new Guid("8743d95c-722f-429c-802d-67085fb46d0b"), "НИКИФОР БЕГИЧЕВ", 16.0 },
                    { new Guid("f3ecc5f0-93ae-418f-8433-2eb0af207231"), new Guid("5c6c234e-912f-46b1-958b-ec35a3985e45"), "ШТУРМАН ЩЕРБИНИН", 15.0 },
                    { new Guid("f6b7af0a-04f0-4284-a845-212b0ddb5907"), new Guid("422087f6-9289-4e18-bd45-d2bf74eaf7aa"), "АРКТИКА-2", 19.0 },
                    { new Guid("f7f08806-bc5c-4b72-9744-644ac97e4858"), new Guid("5c6c234e-912f-46b1-958b-ec35a3985e45"), "BORIS SOKOLOV", 14.0 },
                    { new Guid("febdc14f-7ec0-4d30-9ce3-27e5128f467d"), new Guid("5c6c234e-912f-46b1-958b-ec35a3985e45"), "EDUARD TOLL", 15.0 }
                });

            migrationBuilder.InsertData(
                table: "ShipClassIntegerClass",
                columns: new[] { "Id", "Debuff", "DebuffValue", "IntegerIceClassId", "IsCanHelpMove", "IsCanSoloMove", "ShipClassId" },
                values: new object[,]
                {
                    { new Guid("00ffe2a0-f22e-4b59-8034-bec1b75a728b"), false, 1.0, new Guid("9b833e38-03f3-455a-8c37-b19767a822e8"), false, true, new Guid("186215e1-6d55-4dba-8683-8d08e1167e3a") },
                    { new Guid("0a0b2f54-8a2f-4152-b1f7-62ede3d04c71"), false, 1.0, new Guid("6f4e129c-9295-4571-874a-a10fd5005272"), false, false, new Guid("c33d30c9-3c3a-48ca-9abf-ba5d4c5437b5") },
                    { new Guid("110ec852-be5d-4221-ae8a-963725a2997a"), false, 1.0, new Guid("a3bac6dd-3020-44ae-814d-34c5a6229997"), true, false, new Guid("c33d30c9-3c3a-48ca-9abf-ba5d4c5437b5") },
                    { new Guid("26b9790d-c670-4544-9701-fb2b32a0e44e"), false, 1.0, new Guid("9b833e38-03f3-455a-8c37-b19767a822e8"), false, true, new Guid("98423e8d-2e0c-4429-866e-13be3bbf93bb") },
                    { new Guid("2a3d9573-2c05-4c7f-be95-447329775f12"), false, 1.0, new Guid("9b833e38-03f3-455a-8c37-b19767a822e8"), false, true, new Guid("a2fdd3ba-4f18-418d-bbe4-890ee233cf49") },
                    { new Guid("2b89207f-1499-4290-919a-ab0c161b4641"), false, 1.0, new Guid("6f4e129c-9295-4571-874a-a10fd5005272"), false, false, new Guid("3b224b81-766d-4d08-900f-73308c6df48b") },
                    { new Guid("2c2fcabe-085b-4d4a-880a-9ca85939a3c7"), true, 0.69999999999999996, new Guid("6f4e129c-9295-4571-874a-a10fd5005272"), true, false, new Guid("422087f6-9289-4e18-bd45-d2bf74eaf7aa") },
                    { new Guid("3145bfa8-b500-4a47-886b-5c00d1900981"), true, 0.14999999999999999, new Guid("6f4e129c-9295-4571-874a-a10fd5005272"), true, false, new Guid("5c6c234e-912f-46b1-958b-ec35a3985e45") },
                    { new Guid("32205071-5336-4a7a-8e50-48ca4a21ec6b"), true, 0.90000000000000002, new Guid("a3bac6dd-3020-44ae-814d-34c5a6229997"), false, true, new Guid("98423e8d-2e0c-4429-866e-13be3bbf93bb") },
                    { new Guid("38d36cc4-42ff-4e72-92ae-c191d0d6f613"), false, 1.0, new Guid("a3bac6dd-3020-44ae-814d-34c5a6229997"), true, false, new Guid("578f810c-a3f7-4102-a53c-968b2d9aaa58") },
                    { new Guid("3d20bdc7-ed23-4c17-a57e-e3e41d2fa30f"), true, 0.59999999999999998, new Guid("a3bac6dd-3020-44ae-814d-34c5a6229997"), true, false, new Guid("5c6c234e-912f-46b1-958b-ec35a3985e45") },
                    { new Guid("5ba407cf-95b7-4c10-81e6-70f31889aedb"), false, 1.0, new Guid("9b833e38-03f3-455a-8c37-b19767a822e8"), false, true, new Guid("3b224b81-766d-4d08-900f-73308c6df48b") },
                    { new Guid("655fd27f-e43f-42ab-acf3-383732fdc567"), false, 1.0, new Guid("9b833e38-03f3-455a-8c37-b19767a822e8"), false, true, new Guid("c33d30c9-3c3a-48ca-9abf-ba5d4c5437b5") },
                    { new Guid("711ece98-d14a-4e51-b5d5-a8169d81e00c"), false, 1.0, new Guid("9b833e38-03f3-455a-8c37-b19767a822e8"), false, true, new Guid("422087f6-9289-4e18-bd45-d2bf74eaf7aa") },
                    { new Guid("72d46aed-5ece-4588-9b94-6d9a39a3b803"), false, 1.0, new Guid("9b833e38-03f3-455a-8c37-b19767a822e8"), false, true, new Guid("a6430f42-393b-4c8f-8844-047436c8fb6f") },
                    { new Guid("86b1fc5f-ab0e-4366-8e02-7fce59317243"), false, 1.0, new Guid("9b833e38-03f3-455a-8c37-b19767a822e8"), false, true, new Guid("5c6c234e-912f-46b1-958b-ec35a3985e45") },
                    { new Guid("9a4d6749-25d3-4367-af92-6e9d8604d4c4"), false, 1.0, new Guid("6f4e129c-9295-4571-874a-a10fd5005272"), false, true, new Guid("186215e1-6d55-4dba-8683-8d08e1167e3a") },
                    { new Guid("9e9c6a83-330b-43a8-b144-b975dcb002f3"), false, 1.0, new Guid("6f4e129c-9295-4571-874a-a10fd5005272"), false, false, new Guid("578f810c-a3f7-4102-a53c-968b2d9aaa58") },
                    { new Guid("ad255ecc-45e6-40ef-8471-c645e0772e3c"), true, 0.80000000000000004, new Guid("a3bac6dd-3020-44ae-814d-34c5a6229997"), true, false, new Guid("a2fdd3ba-4f18-418d-bbe4-890ee233cf49") },
                    { new Guid("c4986f02-453c-4bd0-9b6c-5d7db4ebb4ee"), false, 1.0, new Guid("6f4e129c-9295-4571-874a-a10fd5005272"), false, false, new Guid("a6430f42-393b-4c8f-8844-047436c8fb6f") },
                    { new Guid("cbc2fdf0-4d44-40b2-bd93-fb874eee718c"), true, 0.75, new Guid("6f4e129c-9295-4571-874a-a10fd5005272"), false, true, new Guid("98423e8d-2e0c-4429-866e-13be3bbf93bb") },
                    { new Guid("cd5117a1-6eee-4178-bc8d-42671df00306"), true, 0.69999999999999996, new Guid("6f4e129c-9295-4571-874a-a10fd5005272"), true, false, new Guid("a2fdd3ba-4f18-418d-bbe4-890ee233cf49") },
                    { new Guid("de00c554-ea33-4f2b-8d51-be31aeae4ff4"), false, 1.0, new Guid("9b833e38-03f3-455a-8c37-b19767a822e8"), false, true, new Guid("578f810c-a3f7-4102-a53c-968b2d9aaa58") },
                    { new Guid("e4901b07-5b2e-412d-ad9b-bb8660a0b5ef"), false, 1.0, new Guid("a3bac6dd-3020-44ae-814d-34c5a6229997"), true, false, new Guid("3b224b81-766d-4d08-900f-73308c6df48b") },
                    { new Guid("e51177cb-8f50-403d-a72f-a3efb07a28f0"), true, 0.69999999999999996, new Guid("6f4e129c-9295-4571-874a-a10fd5005272"), true, false, new Guid("8743d95c-722f-429c-802d-67085fb46d0b") },
                    { new Guid("e829202c-4dee-4b16-8e6b-24a3b5fd5e09"), false, 1.0, new Guid("a3bac6dd-3020-44ae-814d-34c5a6229997"), true, false, new Guid("a6430f42-393b-4c8f-8844-047436c8fb6f") },
                    { new Guid("ebd146ab-dcbe-4dd8-ab9e-410204cded88"), false, 1.0, new Guid("9b833e38-03f3-455a-8c37-b19767a822e8"), false, true, new Guid("8743d95c-722f-429c-802d-67085fb46d0b") },
                    { new Guid("f5e232a1-bf33-4970-9dd5-d699a8595f3c"), true, 0.80000000000000004, new Guid("a3bac6dd-3020-44ae-814d-34c5a6229997"), true, false, new Guid("8743d95c-722f-429c-802d-67085fb46d0b") },
                    { new Guid("f7bd368f-4add-4fd8-bec2-00620b191b24"), true, 0.80000000000000004, new Guid("a3bac6dd-3020-44ae-814d-34c5a6229997"), true, false, new Guid("422087f6-9289-4e18-bd45-d2bf74eaf7aa") },
                    { new Guid("fc0d05cd-210b-4ff2-8c7a-1f8bf1b61452"), false, 1.0, new Guid("a3bac6dd-3020-44ae-814d-34c5a6229997"), false, true, new Guid("186215e1-6d55-4dba-8683-8d08e1167e3a") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Routes_FinishId",
                table: "Routes",
                column: "FinishId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_StartId",
                table: "Routes",
                column: "StartId");

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
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Ship");

            migrationBuilder.DropTable(
                name: "ShipClassIntegerClass");

            migrationBuilder.DropTable(
                name: "GraphData");

            migrationBuilder.DropTable(
                name: "IntegerIceClass");

            migrationBuilder.DropTable(
                name: "ShipClass");
        }
    }
}
