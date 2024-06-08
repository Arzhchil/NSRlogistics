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
                new Models.ShipClass() { Id = 1, ShipType = "Without class" },
                new Models.ShipClass() { Id = 2, ShipType = "Ice1" },
                new Models.ShipClass() { Id = 3, ShipType = "Ice2" },
                new Models.ShipClass() { Id = 4, ShipType = "Ice3" },
                new Models.ShipClass() { Id = 5, ShipType = "Arc4" },
                new Models.ShipClass() { Id = 6, ShipType = "Arc5" },
                new Models.ShipClass() { Id = 7, ShipType = "Arc6" },
                new Models.ShipClass() { Id = 8, ShipType = "Arc7" },
                new Models.ShipClass() { Id = 9, ShipType = "Arc9-1" },
                new Models.ShipClass() { Id = 10, ShipType = "Arc9-2" },
                
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
                new Models.Ship() { Id = 1, ShipName = "ДЮК II",  ShipClassId = 6, Speed = 15 },
                new Models.Ship() { Id = 2, ShipName = "САРМАТ",  ShipClassId = 5, Speed = 15 },
                new Models.Ship() { Id = 3, ShipName = "EDUARD TOLL",  ShipClassId = 8, Speed = 15 },
                new Models.Ship() { Id = 4, ShipName = "GEORGIY USHAKOV",  ShipClassId = 8, Speed = 15 },
                new Models.Ship() { Id = 5, ShipName = "RUDOLF SAMOYLOVICH",  ShipClassId = 8, Speed = 15 },
                new Models.Ship() { Id = 6, ShipName = "VLADIMIR VORONIN",  ShipClassId = 8, Speed = 15 },
                new Models.Ship() { Id = 7, ShipName = "NIKOLAY YEVGENOV",  ShipClassId = 8, Speed = 14 },
                new Models.Ship() { Id = 8, ShipName = "CHRISTOPHE DE MARGERIE",  ShipClassId = 8, Speed = 14 },
                new Models.Ship() { Id = 9, ShipName = "BORIS VILKITSKY",  ShipClassId = 8, Speed = 19 },
                new Models.Ship() { Id = 10, ShipName = "АРКТИКА-2",  ShipClassId = 6, Speed = 19 },
                new Models.Ship() { Id = 11, ShipName = "ИНЖЕНЕР ВЕШНЯКОВ",  ShipClassId = 6, Speed = 19 },
                new Models.Ship() { Id = 12, ShipName = "ТАМБЕЙ",  ShipClassId = 5, Speed = 19 },
                new Models.Ship() { Id = 13, ShipName = "ШТУРМАН АЛЬБАНОВ",  ShipClassId = 8, Speed = 19 },
                new Models.Ship() { Id = 14, ShipName = "НИКИФОР БЕГИЧЕВ",  ShipClassId = 5, Speed = 16 },
                new Models.Ship() { Id = 15, ShipName = "НОРИЛЬСКИЙ НИКЕЛЬ",  ShipClassId = 8, Speed = 14 },
                new Models.Ship() { Id = 16, ShipName = "АЙС ИГЛ",  ShipClassId = 6, Speed = 14 },
                new Models.Ship() { Id = 17, ShipName = "ШТУРМАН КОШЕЛЕВ",  ShipClassId = 8, Speed = 15 },
                new Models.Ship() { Id = 18, ShipName = "ШТУРМАН ЩЕРБИНИН",  ShipClassId = 8, Speed = 15 },
                new Models.Ship() { Id = 19, ShipName = "ШТУРМАН СКУРАТОВ",  ShipClassId = 8, Speed = 15 },
                new Models.Ship() { Id = 20, ShipName = "ИОГАНН МАХМАСТАЛЬ",  ShipClassId = 6, Speed = 14 },
                new Models.Ship() { Id = 21, ShipName = "BORIS SOKOLOV",  ShipClassId = 8, Speed = 14 },
                new Models.Ship() { Id = 22, ShipName = "ИНЖЕНЕР ТРУБИН",  ShipClassId = 6, Speed = 12 },
                new Models.Ship() { Id = 23, ShipName = "БАРЕНЦ",  ShipClassId = 5, Speed = 16 },
                new Models.Ship() { Id = 24, ShipName = "ПОЛАР КИНГ",  ShipClassId = 6, Speed = 16 },
                new Models.Ship() { Id = 25, ShipName = "МЫС ДЕЖНЕВА",  ShipClassId = 5, Speed = 16 },
                new Models.Ship() { Id = 26, ShipName = "СЕВМОРПУТЬ",  ShipClassId = 6, Speed = 14 },
                new Models.Ship() { Id = 27, ShipName = "ГРИГОРИЙ ШЕЛИХОВ",  ShipClassId = 5, Speed = 14 },
                new Models.Ship() { Id = 28, ShipName = "УРАРТУ",  ShipClassId = 5, Speed = 18 },
                new Models.Ship() { Id = 29, ShipName = "ФЕСКО ПАРИС",  ShipClassId = 5, Speed = 18 },
                new Models.Ship() { Id = 30, ShipName = "ПРОГРЕСС",  ShipClassId = 5, Speed = 18 },
                new Models.Ship() { Id = 31, ShipName = "МИХАИЛ БРИТНЕВ",  ShipClassId = 5, Speed = 18 },
                new Models.Ship() { Id = 32, ShipName = "САБЕТТА",  ShipClassId = 5, Speed = 16 },
                new Models.Ship() { Id = 33, ShipName = "ГЕОРГИЙ УШАКОВ",  ShipClassId = 5, Speed = 16 },
                new Models.Ship() { Id = 34, ShipName = "СЕВЕРНЫЙ ПРОЕКТ",  ShipClassId = 5, Speed = 16 },
                
                new Models.Ship() { Id = 36, ShipName = "БЕРИНГ",  ShipClassId = 5, Speed = 16 },
                new Models.Ship() { Id = 37, ShipName = "ТОЛБУХИН",  ShipClassId = 5, Speed = 16 },
                new Models.Ship() { Id = 38, ShipName = "ЯМАЛ КРЕЧЕТ",  ShipClassId = 5, Speed = 16 },
                new Models.Ship() { Id = 39, ShipName = "CLEAN VISION",  ShipClassId = 5, Speed = 14 },
                
                new Models.Ship() { Id = 41, ShipName = "ТИКСИ",  ShipClassId = 5, Speed = 16 },
                new Models.Ship() { Id = 42, ShipName = "ТАЙБОЛА",  ShipClassId = 5, Speed = 16 },
                new Models.Ship() { Id = 40, ShipName = "YAMAL SPIRIT", ShipClassId = 1, Speed = 14 },
                new Models.Ship() { Id = 35, ShipName = "НИКОЛАЙ ЧУДОТВОРЕЦ", ShipClassId = 1, Speed = 16 }
                );

            modelBuilder.Entity<GraphData>().HasData(
                new GraphData() { Id = 1, Latitude = 73.1, Longitude = 80, PointName = "Бухта Север и Диксон", RepId = 1010 },
                new GraphData() { Id = 2, Latitude = 69.4, Longitude = 86.15, PointName = "Дудинка", RepId = 1007 },
                new GraphData() { Id = 3, Latitude = 69.9, Longitude = 44.6, PointName = "кромка льда на Западе", RepId = 2002 },
                new GraphData() { Id = 4, Latitude = 69.15, Longitude = 57.68, PointName = "Варандей-Приразломное", RepId = 1015 },
                new GraphData() { Id = 5, Latitude = 73, Longitude = 44, PointName = "Штокман", RepId = 1012 },
                new GraphData() { Id = 6, Latitude = 71.5, Longitude = 22, PointName = "Окно в Европу", RepId = 2001 },
                new GraphData() { Id = 7, Latitude = 74.6, Longitude = 63.9, PointName = "Победа месторождение", RepId = 1011 },
                new GraphData() { Id = 8, Latitude = 76.4, Longitude = 86.4, PointName = "Карское - 3 (центр)", RepId = 2008 },
                new GraphData() { Id = 9, Latitude = 77.6, Longitude = 107.7, PointName = "пролив Вилькицкого - 3", RepId = 2013 },
                new GraphData() { Id = 10, Latitude = 74.9, Longitude = 116.7, PointName = "Лаптевых - 4 (юг)", RepId = 2018 },
                new GraphData() { Id = 11, Latitude = 73.1, Longitude = 72.7, PointName = "Вход в Обскую губу", RepId = 2009 },
                new GraphData() { Id = 12, Latitude = 68.5, Longitude = 73.7, PointName = "Новый порт", RepId = 1004 },
                new GraphData() { Id = 13, Latitude = 76.75, Longitude = 116, PointName = "Лаптевых - 1 (центр)", RepId = 2015 },
                new GraphData() { Id = 14, Latitude = 74, Longitude = 76.7, PointName = "Карское - 1 (сбор каравана)", RepId = 2006 },
                new GraphData() { Id = 15, Latitude = 72.35, Longitude = 79.6, PointName = "Лескинское м-е", RepId = 1014 },
                new GraphData() { Id = 16, Latitude = 70.3, Longitude = 57.8, PointName = "Карские ворота", RepId = 2005 },
                new GraphData() { Id = 17, Latitude = 77.3, Longitude = 67.7, PointName = "Мыс Желания", RepId = 2003 },
                new GraphData() { Id = 18, Latitude = 71.74, Longitude = 184.7, PointName = "остров Врангеля", RepId = 2026 },
                new GraphData() { Id = 19, Latitude = 70.7, Longitude = 170.5, PointName = "Восточно-Сибирское - 1 (восток)", RepId = 2023 },
                new GraphData() { Id = 20, Latitude = 77.8, Longitude = 104.1, PointName = "пролив Вилькицкого - восток", RepId = 2012 },
                new GraphData() { Id = 21, Latitude = 77.7, Longitude = 99.5, PointName = "пролив Вилькицкого - запад", RepId = 2011 },
                new GraphData() { Id = 22, Latitude = 76.2, Longitude = 58.3, PointName = "около Новой Земли", RepId = 2004 },
                new GraphData() { Id = 23, Latitude = 74.4, Longitude = 139, PointName = "Пролив Санникова - 1", RepId = 2020 },
                new GraphData() { Id = 24, Latitude = 74.3, Longitude = 146.7, PointName = "Пролив Санникова - 2", RepId = 2021 },
                new GraphData() { Id = 25, Latitude = 74, Longitude = 128.1, PointName = "устье Лены", RepId = 2019 },
                new GraphData() { Id = 26, Latitude = 71.3, Longitude = 72.15, PointName = "Сабетта", RepId = 1003 },
                new GraphData() { Id = 27, Latitude = 69.1, Longitude = 169.4, PointName = "мыс.Наглёйнын", RepId = 1009 },
                new GraphData() { Id = 28, Latitude = 69.9, Longitude = 179, PointName = "пролив Лонга", RepId = 2027 },
                new GraphData() { Id = 29, Latitude = 73.5, Longitude = 169.9, PointName = "Восточно-Сибирское - 3 (север)", RepId = 2025 },
                new GraphData() { Id = 30, Latitude = 64.95, Longitude = 40.05, PointName = "Архангельск", RepId = 1002 },
                new GraphData() { Id = 31, Latitude = 75.9, Longitude = 152.6, PointName = "Лаптевых - 3 (восток)", RepId = 2017 },
                new GraphData() { Id = 32, Latitude = 68.37, Longitude = 54.6, PointName = "МОТ Печора", RepId = 1017 },
                new GraphData() { Id = 33, Latitude = 73.7, Longitude = 109.26, PointName = "Хатангский залив", RepId = 1008 },
                new GraphData() { Id = 34, Latitude = 72, Longitude = 159.5, PointName = "Восточно-Сибирское - 2 (запад)", RepId = 2024 },
                new GraphData() { Id = 35, Latitude = 72.4, Longitude = 65.6, PointName = "Ленинградское-Русановское", RepId = 1013 },
                new GraphData() { Id = 36, Latitude = 71, Longitude = 73.73, PointName = "терминал Утренний", RepId = 1005 },
                new GraphData() { Id = 37, Latitude = 76.5, Longitude = 97.6, PointName = "Таймырский залив", RepId = 2010 },
                new GraphData() { Id = 38, Latitude = 64.2, Longitude = 188.2, PointName = "Берингово", RepId = 2029 },
                new GraphData() { Id = 39, Latitude = 60.7, Longitude = 175.3, PointName = "кромка льда на Востоке", RepId = 2030 },
                new GraphData() { Id = 40, Latitude = 69.75, Longitude = 169.9, PointName = "Рейд Певек", RepId = 1006 },
                new GraphData() { Id = 41, Latitude = 75.5, Longitude = 131.5, PointName = "Лаптевых - 2 (центр)", RepId = 2016 },
                new GraphData() { Id = 42, Latitude = 69.5, Longitude = 33.75, PointName = "Рейд Мурманска", RepId = 1001 },
                new GraphData() { Id = 43, Latitude = 76.7, Longitude = 140.8, PointName = "остров Котельный", RepId = 2022 },
                new GraphData() { Id = 44, Latitude = 74.8, Longitude = 84.2, PointName = "Карское - 2 (прибрежный)", RepId = 2007 },
                new GraphData() { Id = 45, Latitude = 67.58, Longitude = 47.82, PointName = "Индига", RepId = 1016 },
                new GraphData() { Id = 46, Latitude = 65.9, Longitude = -169.35, PointName = "Берингов пролив", RepId = 2028 },
                new GraphData() { Id = 47, Latitude = 55.7, Longitude = 164.25, PointName = "Окно в Азию", RepId = 2031 }
                );

            modelBuilder.Entity<IntegerIceClass>().HasData(
                new IntegerIceClass() { Id = 1, MaxSpeed = 21, MinSpeed = 20},
                new IntegerIceClass() { Id = 2, MaxSpeed = 19, MinSpeed = 15 },
                new IntegerIceClass() { Id = 3, MaxSpeed = 14, MinSpeed = 10 }
                );

            modelBuilder.Entity<ShipClassIntegerClass>().HasData(
                new ShipClassIntegerClass() { Id = 1, ShipClassId = 1, IntegerIceClassId = 1, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { Id = 2, ShipClassId = 1, IntegerIceClassId = 2, Debuff = false, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 1 },
                new ShipClassIntegerClass() { Id = 3, ShipClassId = 1, IntegerIceClassId = 3, Debuff = false, IsCanSoloMove = false, IsCanHelpMove = false, DebuffValue = 1 },

                new ShipClassIntegerClass() { Id = 4, ShipClassId = 2, IntegerIceClassId = 1, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { Id = 5, ShipClassId = 2, IntegerIceClassId = 2, Debuff = false, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 1 },
                new ShipClassIntegerClass() { Id = 6, ShipClassId = 2, IntegerIceClassId = 3, Debuff = false, IsCanSoloMove = false, IsCanHelpMove = false, DebuffValue = 1 },

                new ShipClassIntegerClass() { Id = 7, ShipClassId = 3, IntegerIceClassId = 1, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { Id = 8, ShipClassId = 3, IntegerIceClassId = 2, Debuff = false, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 1 },
                new ShipClassIntegerClass() { Id = 9, ShipClassId = 3, IntegerIceClassId = 3, Debuff = false, IsCanSoloMove = false, IsCanHelpMove = false, DebuffValue = 1 },

                new ShipClassIntegerClass() { Id = 10, ShipClassId = 4, IntegerIceClassId = 1, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { Id = 11, ShipClassId = 4, IntegerIceClassId = 2, Debuff = false, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 1 },
                new ShipClassIntegerClass() { Id = 12, ShipClassId = 4, IntegerIceClassId = 3, Debuff = false, IsCanSoloMove = false, IsCanHelpMove = false, DebuffValue = 1 },

                new ShipClassIntegerClass() { Id = 13, ShipClassId = 5, IntegerIceClassId = 1, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { Id = 14, ShipClassId = 5, IntegerIceClassId = 2, Debuff = true, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 0.8 },
                new ShipClassIntegerClass() { Id = 15, ShipClassId = 5, IntegerIceClassId = 3, Debuff = true, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 0.7 },

                new ShipClassIntegerClass() { Id = 16, ShipClassId = 6, IntegerIceClassId = 1, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { Id = 17, ShipClassId = 6, IntegerIceClassId = 2, Debuff = true, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 0.8 },
                new ShipClassIntegerClass() { Id = 18, ShipClassId = 6, IntegerIceClassId = 3, Debuff = true, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 0.7 },

                new ShipClassIntegerClass() { Id = 22, ShipClassId = 7, IntegerIceClassId = 1, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { Id = 23, ShipClassId = 7, IntegerIceClassId = 2, Debuff = true, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 0.8 },
                new ShipClassIntegerClass() { Id = 24, ShipClassId = 7, IntegerIceClassId = 3, Debuff = true, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 0.7 },

                new ShipClassIntegerClass() { Id = 25, ShipClassId = 8, IntegerIceClassId = 1, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { Id = 26, ShipClassId = 8, IntegerIceClassId = 2, Debuff = true, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 0.6 },
                new ShipClassIntegerClass() { Id = 27, ShipClassId = 8, IntegerIceClassId = 3, Debuff = true, IsCanSoloMove = false, IsCanHelpMove = true, DebuffValue = 0.15 },

                new ShipClassIntegerClass() { Id = 28, ShipClassId = 9, IntegerIceClassId = 1, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { Id = 29, ShipClassId = 9, IntegerIceClassId = 2, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { Id = 30, ShipClassId = 9, IntegerIceClassId = 3, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },

                new ShipClassIntegerClass() { Id = 31, ShipClassId = 10, IntegerIceClassId = 1, Debuff = false, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 1 },
                new ShipClassIntegerClass() { Id = 32, ShipClassId = 10, IntegerIceClassId = 2, Debuff = true, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 0.9 },
                new ShipClassIntegerClass() { Id = 33, ShipClassId = 10, IntegerIceClassId = 3, Debuff = true, IsCanSoloMove = true, IsCanHelpMove = false, DebuffValue = 0.75 }
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
