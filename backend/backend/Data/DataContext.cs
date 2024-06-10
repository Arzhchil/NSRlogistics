using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    /// <summary>
    /// Контект базы данных
    /// </summary>
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<ShipClass> shipClasses = new List<ShipClass>()
            {
                new Models.ShipClass() {ShipType = "Without class" },
                new Models.ShipClass() {ShipType = "Ice1" },
                new Models.ShipClass() {ShipType = "Ice2" },
                new Models.ShipClass() {ShipType = "Ice3" },
                new Models.ShipClass() {ShipType = "Arc4" },
                new Models.ShipClass() {ShipType = "Arc5" },
                new Models.ShipClass() {ShipType = "Arc6" },
                new Models.ShipClass() {ShipType = "Arc7" },
                new Models.ShipClass() {ShipType = "Arc9-1" },
                new Models.ShipClass() {ShipType = "Arc9-2" },

            };

            List<IntegerIceClass> scic = new List<IntegerIceClass>()
            {
                new IntegerIceClass() { MaxSpeed = 21, MinSpeed = 20 },
                new IntegerIceClass() { MaxSpeed = 19, MinSpeed = 15 },
                new IntegerIceClass() { MaxSpeed = 14, MinSpeed = 10 }
            };
            modelBuilder.Entity<ShipClass>().HasData(
                shipClasses[0],
                shipClasses[1],
                shipClasses[2],
                shipClasses[3],
                shipClasses[4],
                shipClasses[5],
                shipClasses[6],
                shipClasses[7],
                shipClasses[8],
                shipClasses[9]
                );

            modelBuilder.Entity<Ship>().HasData(
                new Models.Ship() { ShipName = "ДЮК II", ShipClassId = shipClasses[5].Id, Speed = 15 },
                new Models.Ship() { ShipName = "САРМАТ", ShipClassId = shipClasses[4].Id, Speed = 15 },
                new Models.Ship() { ShipName = "EDUARD TOLL", ShipClassId = shipClasses[7].Id, Speed = 15 },
                new Models.Ship() { ShipName = "GEORGIY USHAKOV", ShipClassId = shipClasses[7].Id, Speed = 15 },
                new Models.Ship() { ShipName = "RUDOLF SAMOYLOVICH", ShipClassId = shipClasses[7].Id, Speed = 15 },
                new Models.Ship() { ShipName = "VLADIMIR VORONIN", ShipClassId = shipClasses[7].Id, Speed = 15 },
                new Models.Ship() { ShipName = "NIKOLAY YEVGENOV", ShipClassId = shipClasses[7].Id, Speed = 14 },
                new Models.Ship() { ShipName = "CHRISTOPHE DE MARGERIE", ShipClassId = shipClasses[7].Id, Speed = 14 },
                new Models.Ship() { ShipName = "BORIS VILKITSKY", ShipClassId = shipClasses[7].Id, Speed = 19 },
                new Models.Ship() { ShipName = "АРКТИКА-2", ShipClassId = shipClasses[5].Id, Speed = 19 },
                new Models.Ship() { ShipName = "ИНЖЕНЕР ВЕШНЯКОВ", ShipClassId = shipClasses[5].Id, Speed = 19 },
                new Models.Ship() { ShipName = "ТАМБЕЙ", ShipClassId = shipClasses[4].Id, Speed = 19 },
                new Models.Ship() { ShipName = "ШТУРМАН АЛЬБАНОВ", ShipClassId = shipClasses[7].Id, Speed = 19 },
                new Models.Ship() { ShipName = "НИКИФОР БЕГИЧЕВ", ShipClassId = shipClasses[4].Id, Speed = 16 },
                new Models.Ship() { ShipName = "НОРИЛЬСКИЙ НИКЕЛЬ", ShipClassId = shipClasses[7].Id, Speed = 14 },
                new Models.Ship() { ShipName = "АЙС ИГЛ", ShipClassId = shipClasses[5].Id, Speed = 14 },
                new Models.Ship() { ShipName = "ШТУРМАН КОШЕЛЕВ", ShipClassId = shipClasses[7].Id, Speed = 15 },
                new Models.Ship() { ShipName = "ШТУРМАН ЩЕРБИНИН", ShipClassId = shipClasses[7].Id, Speed = 15 },
                new Models.Ship() { ShipName = "ШТУРМАН СКУРАТОВ", ShipClassId = shipClasses[7].Id, Speed = 15 },
                new Models.Ship() { ShipName = "ИОГАНН МАХМАСТАЛЬ", ShipClassId = shipClasses[5].Id, Speed = 14 },
                new Models.Ship() { ShipName = "BORIS SOKOLOV", ShipClassId = shipClasses[7].Id, Speed = 14 },
                new Models.Ship() { ShipName = "ИНЖЕНЕР ТРУБИН", ShipClassId = shipClasses[5].Id, Speed = 12 },
                new Models.Ship() { ShipName = "БАРЕНЦ", ShipClassId = shipClasses[4].Id, Speed = 16 },
                new Models.Ship() { ShipName = "ПОЛАР КИНГ", ShipClassId = shipClasses[5].Id, Speed = 16 },
                new Models.Ship() { ShipName = "МЫС ДЕЖНЕВА", ShipClassId = shipClasses[4].Id, Speed = 16 },
                new Models.Ship() { ShipName = "СЕВМОРПУТЬ", ShipClassId = shipClasses[5].Id, Speed = 14 },
                new Models.Ship() { ShipName = "ГРИГОРИЙ ШЕЛИХОВ", ShipClassId = shipClasses[4].Id, Speed = 14 },
                new Models.Ship() { ShipName = "УРАРТУ", ShipClassId = shipClasses[4].Id, Speed = 18 },
                new Models.Ship() { ShipName = "ФЕСКО ПАРИС", ShipClassId = shipClasses[4].Id, Speed = 18 },
                new Models.Ship() { ShipName = "ПРОГРЕСС", ShipClassId = shipClasses[4].Id, Speed = 18 },
                new Models.Ship() { ShipName = "МИХАИЛ БРИТНЕВ", ShipClassId = shipClasses[4].Id, Speed = 18 },
                new Models.Ship() { ShipName = "САБЕТТА", ShipClassId = shipClasses[4].Id, Speed = 16 },
                new Models.Ship() { ShipName = "ГЕОРГИЙ УШАКОВ", ShipClassId = shipClasses[4].Id, Speed = 16 },
                new Models.Ship() { ShipName = "СЕВЕРНЫЙ ПРОЕКТ", ShipClassId = shipClasses[4].Id, Speed = 16 },

                new Models.Ship() { ShipName = "БЕРИНГ", ShipClassId = shipClasses[4].Id, Speed = 16 },
                new Models.Ship() { ShipName = "ТОЛБУХИН", ShipClassId = shipClasses[4].Id, Speed = 16 },
                new Models.Ship() { ShipName = "ЯМАЛ КРЕЧЕТ", ShipClassId = shipClasses[4].Id, Speed = 16 },
                new Models.Ship() { ShipName = "CLEAN VISION", ShipClassId = shipClasses[4].Id, Speed = 14 },

                new Models.Ship() { ShipName = "ТИКСИ", ShipClassId = shipClasses[4].Id, Speed = 16 },
                new Models.Ship() { ShipName = "ТАЙБОЛА", ShipClassId = shipClasses[4].Id, Speed = 16 },
                new Models.Ship() { ShipName = "YAMAL SPIRIT", ShipClassId = shipClasses[0].Id, Speed = 14 },
                new Models.Ship() { ShipName = "НИКОЛАЙ ЧУДОТВОРЕЦ", ShipClassId = shipClasses[0].Id, Speed = 16 }
                );

            var graphdata = new List<GraphData>()
            {
                new GraphData() { Latitude = 73.1, Longitude = 80, PointName = "Бухта Север и Диксон", RepId = 1010 },
                new GraphData() { Latitude = 69.4, Longitude = 86.15, PointName = "Дудинка", RepId = 1007 },
                new GraphData() { Latitude = 69.9, Longitude = 44.6, PointName = "кромка льда на Западе", RepId = 2002 },
                new GraphData() { Latitude = 69.15, Longitude = 57.68, PointName = "Варандей-Приразломное", RepId = 1015 },
                new GraphData() { Latitude = 73, Longitude = 44, PointName = "Штокман", RepId = 1012 },
                new GraphData() { Latitude = 71.5, Longitude = 22, PointName = "Окно в Европу", RepId = 2001 },
                new GraphData() { Latitude = 74.6, Longitude = 63.9, PointName = "Победа месторождение", RepId = 1011 },
                new GraphData() { Latitude = 76.4, Longitude = 86.4, PointName = "Карское - 3 (центр)", RepId = 2008 },
                new GraphData() { Latitude = 77.6, Longitude = 107.7, PointName = "пролив Вилькицкого - 3", RepId = 2013 },
                new GraphData() { Latitude = 74.9, Longitude = 116.7, PointName = "Лаптевых - 4 (юг)", RepId = 2018 },
                new GraphData() { Latitude = 73.1, Longitude = 72.7, PointName = "Вход в Обскую губу", RepId = 2009 },
                new GraphData() { Latitude = 68.5, Longitude = 73.7, PointName = "Новый порт", RepId = 1004 },
                new GraphData() { Latitude = 76.75, Longitude = 116, PointName = "Лаптевых - 1 (центр)", RepId = 2015 },
                new GraphData() { Latitude = 74, Longitude = 76.7, PointName = "Карское - 1 (сбор каравана)", RepId = 2006 },
                new GraphData() { Latitude = 72.35, Longitude = 79.6, PointName = "Лескинское м-е", RepId = 1014 },
                new GraphData() { Latitude = 70.3, Longitude = 57.8, PointName = "Карские ворота", RepId = 2005 },
                new GraphData() { Latitude = 77.3, Longitude = 67.7, PointName = "Мыс Желания", RepId = 2003 },
                new GraphData() { Latitude = 71.74, Longitude = 184.7, PointName = "остров Врангеля", RepId = 2026 },
                new GraphData() { Latitude = 70.7, Longitude = 170.5, PointName = "Восточно-Сибирское - 1 (восток)", RepId = 2023 },
                new GraphData() { Latitude = 77.8, Longitude = 104.1, PointName = "пролив Вилькицкого - восток", RepId = 2012 },
                new GraphData() { Latitude = 77.7, Longitude = 99.5, PointName = "пролив Вилькицкого - запад", RepId = 2011 },
                new GraphData() { Latitude = 76.2, Longitude = 58.3, PointName = "около Новой Земли", RepId = 2004 },
                new GraphData() { Latitude = 74.4, Longitude = 139, PointName = "Пролив Санникова - 1", RepId = 2020 },
                new GraphData() { Latitude = 74.3, Longitude = 146.7, PointName = "Пролив Санникова - 2", RepId = 2021 },
                new GraphData() { Latitude = 74, Longitude = 128.1, PointName = "устье Лены", RepId = 2019 },
                new GraphData() { Latitude = 71.3, Longitude = 72.15, PointName = "Сабетта", RepId = 1003 },
                new GraphData() { Latitude = 69.1, Longitude = 169.4, PointName = "мыс.Наглёйнын", RepId = 1009 },
                new GraphData() { Latitude = 69.9, Longitude = 179, PointName = "пролив Лонга", RepId = 2027 },
                new GraphData() { Latitude = 73.5, Longitude = 169.9, PointName = "Восточно-Сибирское - 3 (север)", RepId = 2025 },
                new GraphData() { Latitude = 64.95, Longitude = 40.05, PointName = "Архангельск", RepId = 1002 },
                new GraphData() { Latitude = 75.9, Longitude = 152.6, PointName = "Лаптевых - 3 (восток)", RepId = 2017 },
                new GraphData() { Latitude = 68.37, Longitude = 54.6, PointName = "МОТ Печора", RepId = 1017 },
                new GraphData() { Latitude = 73.7, Longitude = 109.26, PointName = "Хатангский залив", RepId = 1008 },
                new GraphData() { Latitude = 72, Longitude = 159.5, PointName = "Восточно-Сибирское - 2 (запад)", RepId = 2024 },
                new GraphData() { Latitude = 72.4, Longitude = 65.6, PointName = "Ленинградское-Русановское", RepId = 1013 },
                new GraphData() { Latitude = 71, Longitude = 73.73, PointName = "терминал Утренний", RepId = 1005 },
                new GraphData() { Latitude = 76.5, Longitude = 97.6, PointName = "Таймырский залив", RepId = 2010 },
                new GraphData() { Latitude = 64.2, Longitude = 188.2, PointName = "Берингово", RepId = 2029 },
                new GraphData() { Latitude = 60.7, Longitude = 175.3, PointName = "кромка льда на Востоке", RepId = 2030 },
                new GraphData() { Latitude = 69.75, Longitude = 169.9, PointName = "Рейд Певек", RepId = 1006 },
                new GraphData() { Latitude = 75.5, Longitude = 131.5, PointName = "Лаптевых - 2 (центр)", RepId = 2016 },
                new GraphData() { Latitude = 69.5, Longitude = 33.75, PointName = "Рейд Мурманска", RepId = 1001 },
                new GraphData() { Latitude = 76.7, Longitude = 140.8, PointName = "остров Котельный", RepId = 2022 },
                new GraphData() { Latitude = 74.8, Longitude = 84.2, PointName = "Карское - 2 (прибрежный)", RepId = 2007 },
                new GraphData() { Latitude = 67.58, Longitude = 47.82, PointName = "Индига", RepId = 1016 },
                new GraphData() { Latitude = 65.9, Longitude = -169.35, PointName = "Берингов пролив", RepId = 2028 },
                new GraphData() { Latitude = 55.7, Longitude = 164.25, PointName = "Окно в Азию", RepId = 2031 }
            };

            modelBuilder.Entity<GraphData>().HasData(
                graphdata[0],
                graphdata[1],
                graphdata[2],
                graphdata[3],
                graphdata[4],
                graphdata[5],
                graphdata[6],
                graphdata[7],
                graphdata[8],
                graphdata[9],
                graphdata[10],
                graphdata[11],
                graphdata[12],
                graphdata[13],
                graphdata[14],
                graphdata[15],
                graphdata[16],
                graphdata[17],
                graphdata[18],
                graphdata[19],
                graphdata[20],
                graphdata[21],
                graphdata[22],
                graphdata[23],
                graphdata[24],
                graphdata[25],
                graphdata[26],
                graphdata[27],
                graphdata[28],
                graphdata[29],
                graphdata[30],
                graphdata[31],
                graphdata[32],
                graphdata[33],
                graphdata[34],
                graphdata[35],
                graphdata[36],
                graphdata[37],
                graphdata[38],
                graphdata[39],
                graphdata[40],
                graphdata[41],
                graphdata[42],
                graphdata[43],
                graphdata[44],
                graphdata[45],
                graphdata[46]
                );

            modelBuilder.Entity<Models.Route>().HasData(
                new Models.Route() { StartId = graphdata[44].Id, FinishId = graphdata[15].Id, Length = 270.0166416, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[10].Id, FinishId = graphdata[11].Id, Length = 277.1898363, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[18].Id, FinishId = graphdata[39].Id, Length = 58.39035132, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[13].Id, FinishId = graphdata[16].Id, Length = 238.8589885, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[10].Id, FinishId = graphdata[13].Id, Length = 86.93004916, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[21].Id, FinishId = graphdata[5].Id, Length = 655.3557374, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[4].Id, FinishId = graphdata[5].Id, Length = 410.5701116, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[45].Id, FinishId = graphdata[37].Id, Length = 119.5634492, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[13].Id, FinishId = graphdata[7].Id, Length = 206.8821279, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[9].Id, FinishId = graphdata[24].Id, Length = 191.1526107, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[27].Id, FinishId = graphdata[18].Id, Length = 178.645412, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[28].Id, FinishId = graphdata[33].Id, Length = 205.7748943, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[40].Id, FinishId = graphdata[22].Id, Length = 134.3049847, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[42].Id, FinishId = graphdata[30].Id, Length = 174.3916815, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[31].Id, FinishId = graphdata[3].Id, Length = 81.8159608, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[0].Id, FinishId = graphdata[43].Id, Length = 123.6831421, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[12].Id, FinishId = graphdata[24].Id, Length = 246.2458649, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[12].Id, FinishId = graphdata[42].Id, Length = 339.778226, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[15].Id, FinishId = graphdata[2].Id, Length = 270.5921169, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[10].Id, FinishId = graphdata[35].Id, Length = 127.6546236, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[9].Id, FinishId = graphdata[32].Id, Length = 140.7360068, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[2].Id, FinishId = graphdata[3].Id, Length = 278.1227556, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[0].Id, FinishId = graphdata[1].Id, Length = 251.8626597, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[33].Id, FinishId = graphdata[18].Id, Length = 225.0238977, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[40].Id, FinishId = graphdata[42].Id, Length = 152.2019466, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[4].Id, FinishId = graphdata[41].Id, Length = 288.1919175, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[8].Id, FinishId = graphdata[12].Id, Length = 121.8205679, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[2].Id, FinishId = graphdata[29].Id, Length = 315.3047628, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[15].Id, FinishId = graphdata[3].Id, Length = 69.16861273, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[12].Id, FinishId = graphdata[40].Id, Length = 234.8941148, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[19].Id, FinishId = graphdata[8].Id, Length = 47.63018916, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[28].Id, FinishId = graphdata[30].Id, Length = 308.4151996, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[13].Id, FinishId = graphdata[0].Id, Length = 77.9639623, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[21].Id, FinishId = graphdata[2].Id, Length = 445.9281382, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[30].Id, FinishId = graphdata[18].Id, Length = 436.2716913, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[40].Id, FinishId = graphdata[9].Id, Length = 229.4577372, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[21].Id, FinishId = graphdata[4].Id, Length = 297.1508085, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[16].Id, FinishId = graphdata[34].Id, Length = 296.3206745, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[45].Id, FinishId = graphdata[17].Id, Length = 373.6308274, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[17].Id, FinishId = graphdata[18].Id, Length = 281.0870454, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[18].Id, FinishId = graphdata[26].Id, Length = 98.81552937, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[38].Id, FinishId = graphdata[46].Id, Length = 460.2848327, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[30].Id, FinishId = graphdata[33].Id, Length = 260.5701136, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[24].Id, FinishId = graphdata[22].Id, Length = 179.7422785, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[10].Id, FinishId = graphdata[16].Id, Length = 263.6393465, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[27].Id, FinishId = graphdata[45].Id, Length = 355.6231614, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[7].Id, FinishId = graphdata[36].Id, Length = 157.6035239, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[7].Id, FinishId = graphdata[20].Id, Length = 192.4522229, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[34].Id, FinishId = graphdata[13].Id, Length = 215.0532376, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[43].Id, FinishId = graphdata[36].Id, Length = 223.5714878, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[6].Id, FinishId = graphdata[7].Id, Length = 352.936821, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[10].Id, FinishId = graphdata[25].Id, Length = 108.6630553, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[37].Id, FinishId = graphdata[38].Id, Length = 414.6912251, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[13].Id, FinishId = graphdata[15].Id, Length = 410.4549185, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[7].Id, FinishId = graphdata[16].Id, Length = 260.1771091, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[6].Id, FinishId = graphdata[16].Id, Length = 171.4172136, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[36].Id, FinishId = graphdata[19].Id, Length = 116.7439955, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[33].Id, FinishId = graphdata[23].Id, Length = 261.600589, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[20].Id, FinishId = graphdata[16].Id, Length = 409.3111575, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[10].Id, FinishId = graphdata[15].Id, Length = 326.4328417, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[34].Id, FinishId = graphdata[15].Id, Length = 195.7328443, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[44].Id, FinishId = graphdata[2].Id, Length = 156.0644819, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[14].Id, FinishId = graphdata[0].Id, Length = 45.6421557, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[8].Id, FinishId = graphdata[9].Id, Length = 206.5979139, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[2].Id, FinishId = graphdata[5].Id, Length = 456.2676239, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[16].Id, FinishId = graphdata[21].Id, Length = 145.1826364, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[27].Id, FinishId = graphdata[28].Id, Length = 275.6604549, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[13].Id, FinishId = graphdata[43].Id, Length = 130.3081116, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[19].Id, FinishId = graphdata[20].Id, Length = 58.95750201, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[6].Id, FinishId = graphdata[15].Id, Length = 280.7806599, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[2].Id, FinishId = graphdata[41].Id, Length = 227.2269304, StatusRoute = (StatusRoute)1 },
                new Models.Route() { StartId = graphdata[22].Id, FinishId = graphdata[23].Id, Length = 124.9092209, StatusRoute = (StatusRoute)2 },
                new Models.Route() { StartId = graphdata[17].Id, FinishId = graphdata[28].Id, Length = 285.0795135, StatusRoute = (StatusRoute)2 }

                );

            modelBuilder.Entity<IntegerIceClass>().HasData(
                scic[0],
                scic[1],
                scic[2]
                );

            modelBuilder.Entity<ShipClassIntegerClass>().HasData(
                new ShipClassIntegerClass() { ShipClassId = shipClasses[0].Id, IntegerIceClassId = scic[0].Id, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[0].Id, IntegerIceClassId = scic[1].Id, Debuff = false, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 1 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[0].Id, IntegerIceClassId = scic[2].Id, Debuff = false, IsCanSoloMove = false, IsCanHelpMove = false, DebuffValue = 1 },

                new ShipClassIntegerClass() { ShipClassId = shipClasses[1].Id, IntegerIceClassId = scic[0].Id, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[1].Id, IntegerIceClassId = scic[1].Id, Debuff = false, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 1 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[1].Id, IntegerIceClassId = scic[2].Id, Debuff = false, IsCanSoloMove = false, IsCanHelpMove = false, DebuffValue = 1 },

                new ShipClassIntegerClass() { ShipClassId = shipClasses[2].Id, IntegerIceClassId = scic[0].Id, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[2].Id, IntegerIceClassId = scic[1].Id, Debuff = false, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 1 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[2].Id, IntegerIceClassId = scic[2].Id, Debuff = false, IsCanSoloMove = false, IsCanHelpMove = false, DebuffValue = 1 },

                new ShipClassIntegerClass() { ShipClassId = shipClasses[3].Id, IntegerIceClassId = scic[0].Id, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[3].Id, IntegerIceClassId = scic[1].Id, Debuff = false, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 1 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[3].Id, IntegerIceClassId = scic[2].Id, Debuff = false, IsCanSoloMove = false, IsCanHelpMove = false, DebuffValue = 1 },

                new ShipClassIntegerClass() { ShipClassId = shipClasses[4].Id, IntegerIceClassId = scic[0].Id, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[4].Id, IntegerIceClassId = scic[1].Id, Debuff = true, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 0.8 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[4].Id, IntegerIceClassId = scic[2].Id, Debuff = true, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 0.7 },

                new ShipClassIntegerClass() { ShipClassId = shipClasses[5].Id, IntegerIceClassId = scic[0].Id, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[5].Id, IntegerIceClassId = scic[1].Id, Debuff = true, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 0.8 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[5].Id, IntegerIceClassId = scic[2].Id, Debuff = true, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 0.7 },

                new ShipClassIntegerClass() { ShipClassId = shipClasses[6].Id, IntegerIceClassId = scic[0].Id, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[6].Id, IntegerIceClassId = scic[1].Id, Debuff = true, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 0.8 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[6].Id, IntegerIceClassId = scic[2].Id, Debuff = true, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 0.7 },

                new ShipClassIntegerClass() { ShipClassId = shipClasses[7].Id, IntegerIceClassId = scic[0].Id, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[7].Id, IntegerIceClassId = scic[1].Id, Debuff = true, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 0.6 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[7].Id, IntegerIceClassId = scic[2].Id, Debuff = true, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 0.15 },

                new ShipClassIntegerClass() { ShipClassId = shipClasses[8].Id, IntegerIceClassId = scic[0].Id, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[8].Id, IntegerIceClassId = scic[1].Id, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[8].Id, IntegerIceClassId = scic[2].Id, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },

                new ShipClassIntegerClass() { ShipClassId = shipClasses[9].Id, IntegerIceClassId = scic[0].Id, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[9].Id, IntegerIceClassId = scic[1].Id, Debuff = true, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 0.9 },
                new ShipClassIntegerClass() { ShipClassId = shipClasses[9].Id, IntegerIceClassId = scic[2].Id, Debuff = true, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 0.75 }
            );
        }

        public DbSet<Models.File> File { get; set; } = null!;
        public DbSet<GraphData> GraphData {  get; set; } = null!;
        public DbSet<Ship> Ship { get; set; } = null!;
        public DbSet<ShipClass> ShipClass { get; set; } = null!;
        public DbSet<IntegerIceClass> IntegerIceClass { get; set; } = null!;
        public DbSet<ShipClassIntegerClass> ShipClassIntegerClass { get; set; } = null!;

        public DbSet<Models.Route> Routes { get; set; } = null!;
    }
}
