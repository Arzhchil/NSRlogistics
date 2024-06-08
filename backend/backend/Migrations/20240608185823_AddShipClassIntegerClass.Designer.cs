﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using backend.Data;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240608185823_AddShipClassIntegerClass")]
    partial class AddShipClassIntegerClass
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("backend.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameExtension")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("File");
                });

            modelBuilder.Entity("backend.Models.GraphData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("PointName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RepId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("GraphData");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Latitude = 73.099999999999994,
                            Longitude = 80.0,
                            PointName = "Бухта Север и Диксон",
                            RepId = 1010
                        },
                        new
                        {
                            Id = 2,
                            Latitude = 69.400000000000006,
                            Longitude = 86.150000000000006,
                            PointName = "Дудинка",
                            RepId = 1007
                        },
                        new
                        {
                            Id = 3,
                            Latitude = 69.900000000000006,
                            Longitude = 44.600000000000001,
                            PointName = "кромка льда на Западе",
                            RepId = 2002
                        },
                        new
                        {
                            Id = 4,
                            Latitude = 69.150000000000006,
                            Longitude = 57.68,
                            PointName = "Варандей-Приразломное",
                            RepId = 1015
                        },
                        new
                        {
                            Id = 5,
                            Latitude = 73.0,
                            Longitude = 44.0,
                            PointName = "Штокман",
                            RepId = 1012
                        },
                        new
                        {
                            Id = 6,
                            Latitude = 71.5,
                            Longitude = 22.0,
                            PointName = "Окно в Европу",
                            RepId = 2001
                        },
                        new
                        {
                            Id = 7,
                            Latitude = 74.599999999999994,
                            Longitude = 63.899999999999999,
                            PointName = "Победа месторождение",
                            RepId = 1011
                        },
                        new
                        {
                            Id = 8,
                            Latitude = 76.400000000000006,
                            Longitude = 86.400000000000006,
                            PointName = "Карское - 3 (центр)",
                            RepId = 2008
                        },
                        new
                        {
                            Id = 9,
                            Latitude = 77.599999999999994,
                            Longitude = 107.7,
                            PointName = "пролив Вилькицкого - 3",
                            RepId = 2013
                        },
                        new
                        {
                            Id = 10,
                            Latitude = 74.900000000000006,
                            Longitude = 116.7,
                            PointName = "Лаптевых - 4 (юг)",
                            RepId = 2018
                        },
                        new
                        {
                            Id = 11,
                            Latitude = 73.099999999999994,
                            Longitude = 72.700000000000003,
                            PointName = "Вход в Обскую губу",
                            RepId = 2009
                        },
                        new
                        {
                            Id = 12,
                            Latitude = 68.5,
                            Longitude = 73.700000000000003,
                            PointName = "Новый порт",
                            RepId = 1004
                        },
                        new
                        {
                            Id = 13,
                            Latitude = 76.75,
                            Longitude = 116.0,
                            PointName = "Лаптевых - 1 (центр)",
                            RepId = 2015
                        },
                        new
                        {
                            Id = 14,
                            Latitude = 74.0,
                            Longitude = 76.700000000000003,
                            PointName = "Карское - 1 (сбор каравана)",
                            RepId = 2006
                        },
                        new
                        {
                            Id = 15,
                            Latitude = 72.349999999999994,
                            Longitude = 79.599999999999994,
                            PointName = "Лескинское м-е",
                            RepId = 1014
                        },
                        new
                        {
                            Id = 16,
                            Latitude = 70.299999999999997,
                            Longitude = 57.799999999999997,
                            PointName = "Карские ворота",
                            RepId = 2005
                        },
                        new
                        {
                            Id = 17,
                            Latitude = 77.299999999999997,
                            Longitude = 67.700000000000003,
                            PointName = "Мыс Желания",
                            RepId = 2003
                        },
                        new
                        {
                            Id = 18,
                            Latitude = 71.739999999999995,
                            Longitude = 184.69999999999999,
                            PointName = "остров Врангеля",
                            RepId = 2026
                        },
                        new
                        {
                            Id = 19,
                            Latitude = 70.700000000000003,
                            Longitude = 170.5,
                            PointName = "Восточно-Сибирское - 1 (восток)",
                            RepId = 2023
                        },
                        new
                        {
                            Id = 20,
                            Latitude = 77.799999999999997,
                            Longitude = 104.09999999999999,
                            PointName = "пролив Вилькицкого - восток",
                            RepId = 2012
                        },
                        new
                        {
                            Id = 21,
                            Latitude = 77.700000000000003,
                            Longitude = 99.5,
                            PointName = "пролив Вилькицкого - запад",
                            RepId = 2011
                        },
                        new
                        {
                            Id = 22,
                            Latitude = 76.200000000000003,
                            Longitude = 58.299999999999997,
                            PointName = "около Новой Земли",
                            RepId = 2004
                        },
                        new
                        {
                            Id = 23,
                            Latitude = 74.400000000000006,
                            Longitude = 139.0,
                            PointName = "Пролив Санникова - 1",
                            RepId = 2020
                        },
                        new
                        {
                            Id = 24,
                            Latitude = 74.299999999999997,
                            Longitude = 146.69999999999999,
                            PointName = "Пролив Санникова - 2",
                            RepId = 2021
                        },
                        new
                        {
                            Id = 25,
                            Latitude = 74.0,
                            Longitude = 128.09999999999999,
                            PointName = "устье Лены",
                            RepId = 2019
                        },
                        new
                        {
                            Id = 26,
                            Latitude = 71.299999999999997,
                            Longitude = 72.150000000000006,
                            PointName = "Сабетта",
                            RepId = 1003
                        },
                        new
                        {
                            Id = 27,
                            Latitude = 69.099999999999994,
                            Longitude = 169.40000000000001,
                            PointName = "мыс.Наглёйнын",
                            RepId = 1009
                        },
                        new
                        {
                            Id = 28,
                            Latitude = 69.900000000000006,
                            Longitude = 179.0,
                            PointName = "пролив Лонга",
                            RepId = 2027
                        },
                        new
                        {
                            Id = 29,
                            Latitude = 73.5,
                            Longitude = 169.90000000000001,
                            PointName = "Восточно-Сибирское - 3 (север)",
                            RepId = 2025
                        },
                        new
                        {
                            Id = 30,
                            Latitude = 64.950000000000003,
                            Longitude = 40.049999999999997,
                            PointName = "Архангельск",
                            RepId = 1002
                        },
                        new
                        {
                            Id = 31,
                            Latitude = 75.900000000000006,
                            Longitude = 152.59999999999999,
                            PointName = "Лаптевых - 3 (восток)",
                            RepId = 2017
                        },
                        new
                        {
                            Id = 32,
                            Latitude = 68.370000000000005,
                            Longitude = 54.600000000000001,
                            PointName = "МОТ Печора",
                            RepId = 1017
                        },
                        new
                        {
                            Id = 33,
                            Latitude = 73.700000000000003,
                            Longitude = 109.26000000000001,
                            PointName = "Хатангский залив",
                            RepId = 1008
                        },
                        new
                        {
                            Id = 34,
                            Latitude = 72.0,
                            Longitude = 159.5,
                            PointName = "Восточно-Сибирское - 2 (запад)",
                            RepId = 2024
                        },
                        new
                        {
                            Id = 35,
                            Latitude = 72.400000000000006,
                            Longitude = 65.599999999999994,
                            PointName = "Ленинградское-Русановское",
                            RepId = 1013
                        },
                        new
                        {
                            Id = 36,
                            Latitude = 71.0,
                            Longitude = 73.730000000000004,
                            PointName = "терминал Утренний",
                            RepId = 1005
                        },
                        new
                        {
                            Id = 37,
                            Latitude = 76.5,
                            Longitude = 97.599999999999994,
                            PointName = "Таймырский залив",
                            RepId = 2010
                        },
                        new
                        {
                            Id = 38,
                            Latitude = 64.200000000000003,
                            Longitude = 188.19999999999999,
                            PointName = "Берингово",
                            RepId = 2029
                        },
                        new
                        {
                            Id = 39,
                            Latitude = 60.700000000000003,
                            Longitude = 175.30000000000001,
                            PointName = "кромка льда на Востоке",
                            RepId = 2030
                        },
                        new
                        {
                            Id = 40,
                            Latitude = 69.75,
                            Longitude = 169.90000000000001,
                            PointName = "Рейд Певек",
                            RepId = 1006
                        },
                        new
                        {
                            Id = 41,
                            Latitude = 75.5,
                            Longitude = 131.5,
                            PointName = "Лаптевых - 2 (центр)",
                            RepId = 2016
                        },
                        new
                        {
                            Id = 42,
                            Latitude = 69.5,
                            Longitude = 33.75,
                            PointName = "Рейд Мурманска",
                            RepId = 1001
                        },
                        new
                        {
                            Id = 43,
                            Latitude = 76.700000000000003,
                            Longitude = 140.80000000000001,
                            PointName = "остров Котельный",
                            RepId = 2022
                        },
                        new
                        {
                            Id = 44,
                            Latitude = 74.799999999999997,
                            Longitude = 84.200000000000003,
                            PointName = "Карское - 2 (прибрежный)",
                            RepId = 2007
                        },
                        new
                        {
                            Id = 45,
                            Latitude = 67.579999999999998,
                            Longitude = 47.82,
                            PointName = "Индига",
                            RepId = 1016
                        },
                        new
                        {
                            Id = 46,
                            Latitude = 65.900000000000006,
                            Longitude = -169.34999999999999,
                            PointName = "Берингов пролив",
                            RepId = 2028
                        },
                        new
                        {
                            Id = 47,
                            Latitude = 55.700000000000003,
                            Longitude = 164.25,
                            PointName = "Окно в Азию",
                            RepId = 2031
                        });
                });

            modelBuilder.Entity("backend.Models.IntegerIceClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("MaxSpeed")
                        .HasColumnType("integer");

                    b.Property<int>("MinSpeed")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("IntegerIceClass");
                });

            modelBuilder.Entity("backend.Models.Ship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ShipClassId")
                        .HasColumnType("integer");

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Speed")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("ShipClassId");

                    b.ToTable("Ship");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ShipClassId = 6,
                            ShipName = "ДЮК II",
                            Speed = 15.0
                        },
                        new
                        {
                            Id = 2,
                            ShipClassId = 5,
                            ShipName = "САРМАТ",
                            Speed = 15.0
                        },
                        new
                        {
                            Id = 3,
                            ShipClassId = 8,
                            ShipName = "EDUARD TOLL",
                            Speed = 15.0
                        },
                        new
                        {
                            Id = 4,
                            ShipClassId = 8,
                            ShipName = "GEORGIY USHAKOV",
                            Speed = 15.0
                        },
                        new
                        {
                            Id = 5,
                            ShipClassId = 8,
                            ShipName = "RUDOLF SAMOYLOVICH",
                            Speed = 15.0
                        },
                        new
                        {
                            Id = 6,
                            ShipClassId = 8,
                            ShipName = "VLADIMIR VORONIN",
                            Speed = 15.0
                        },
                        new
                        {
                            Id = 7,
                            ShipClassId = 8,
                            ShipName = "NIKOLAY YEVGENOV",
                            Speed = 14.0
                        },
                        new
                        {
                            Id = 8,
                            ShipClassId = 8,
                            ShipName = "CHRISTOPHE DE MARGERIE",
                            Speed = 14.0
                        },
                        new
                        {
                            Id = 9,
                            ShipClassId = 8,
                            ShipName = "BORIS VILKITSKY",
                            Speed = 19.0
                        },
                        new
                        {
                            Id = 10,
                            ShipClassId = 6,
                            ShipName = "АРКТИКА-2",
                            Speed = 19.0
                        },
                        new
                        {
                            Id = 11,
                            ShipClassId = 6,
                            ShipName = "ИНЖЕНЕР ВЕШНЯКОВ",
                            Speed = 19.0
                        },
                        new
                        {
                            Id = 12,
                            ShipClassId = 5,
                            ShipName = "ТАМБЕЙ",
                            Speed = 19.0
                        },
                        new
                        {
                            Id = 13,
                            ShipClassId = 8,
                            ShipName = "ШТУРМАН АЛЬБАНОВ",
                            Speed = 19.0
                        },
                        new
                        {
                            Id = 14,
                            ShipClassId = 5,
                            ShipName = "НИКИФОР БЕГИЧЕВ",
                            Speed = 16.0
                        },
                        new
                        {
                            Id = 15,
                            ShipClassId = 8,
                            ShipName = "НОРИЛЬСКИЙ НИКЕЛЬ",
                            Speed = 14.0
                        },
                        new
                        {
                            Id = 16,
                            ShipClassId = 6,
                            ShipName = "АЙС ИГЛ",
                            Speed = 14.0
                        },
                        new
                        {
                            Id = 17,
                            ShipClassId = 8,
                            ShipName = "ШТУРМАН КОШЕЛЕВ",
                            Speed = 15.0
                        },
                        new
                        {
                            Id = 18,
                            ShipClassId = 8,
                            ShipName = "ШТУРМАН ЩЕРБИНИН",
                            Speed = 15.0
                        },
                        new
                        {
                            Id = 19,
                            ShipClassId = 8,
                            ShipName = "ШТУРМАН СКУРАТОВ",
                            Speed = 15.0
                        },
                        new
                        {
                            Id = 20,
                            ShipClassId = 6,
                            ShipName = "ИОГАНН МАХМАСТАЛЬ",
                            Speed = 14.0
                        },
                        new
                        {
                            Id = 21,
                            ShipClassId = 8,
                            ShipName = "BORIS SOKOLOV",
                            Speed = 14.0
                        },
                        new
                        {
                            Id = 22,
                            ShipClassId = 6,
                            ShipName = "ИНЖЕНЕР ТРУБИН",
                            Speed = 12.0
                        },
                        new
                        {
                            Id = 23,
                            ShipClassId = 5,
                            ShipName = "БАРЕНЦ",
                            Speed = 16.0
                        },
                        new
                        {
                            Id = 24,
                            ShipClassId = 6,
                            ShipName = "ПОЛАР КИНГ",
                            Speed = 16.0
                        },
                        new
                        {
                            Id = 25,
                            ShipClassId = 5,
                            ShipName = "МЫС ДЕЖНЕВА",
                            Speed = 16.0
                        },
                        new
                        {
                            Id = 26,
                            ShipClassId = 6,
                            ShipName = "СЕВМОРПУТЬ",
                            Speed = 14.0
                        },
                        new
                        {
                            Id = 27,
                            ShipClassId = 5,
                            ShipName = "ГРИГОРИЙ ШЕЛИХОВ",
                            Speed = 14.0
                        },
                        new
                        {
                            Id = 28,
                            ShipClassId = 5,
                            ShipName = "УРАРТУ",
                            Speed = 18.0
                        },
                        new
                        {
                            Id = 29,
                            ShipClassId = 5,
                            ShipName = "ФЕСКО ПАРИС",
                            Speed = 18.0
                        },
                        new
                        {
                            Id = 30,
                            ShipClassId = 5,
                            ShipName = "ПРОГРЕСС",
                            Speed = 18.0
                        },
                        new
                        {
                            Id = 31,
                            ShipClassId = 5,
                            ShipName = "МИХАИЛ БРИТНЕВ",
                            Speed = 18.0
                        },
                        new
                        {
                            Id = 32,
                            ShipClassId = 5,
                            ShipName = "САБЕТТА",
                            Speed = 16.0
                        },
                        new
                        {
                            Id = 33,
                            ShipClassId = 5,
                            ShipName = "ГЕОРГИЙ УШАКОВ",
                            Speed = 16.0
                        },
                        new
                        {
                            Id = 34,
                            ShipClassId = 5,
                            ShipName = "СЕВЕРНЫЙ ПРОЕКТ",
                            Speed = 16.0
                        },
                        new
                        {
                            Id = 36,
                            ShipClassId = 5,
                            ShipName = "БЕРИНГ",
                            Speed = 16.0
                        },
                        new
                        {
                            Id = 37,
                            ShipClassId = 5,
                            ShipName = "ТОЛБУХИН",
                            Speed = 16.0
                        },
                        new
                        {
                            Id = 38,
                            ShipClassId = 5,
                            ShipName = "ЯМАЛ КРЕЧЕТ",
                            Speed = 16.0
                        },
                        new
                        {
                            Id = 39,
                            ShipClassId = 5,
                            ShipName = "CLEAN VISION",
                            Speed = 14.0
                        },
                        new
                        {
                            Id = 41,
                            ShipClassId = 5,
                            ShipName = "ТИКСИ",
                            Speed = 16.0
                        },
                        new
                        {
                            Id = 42,
                            ShipClassId = 5,
                            ShipName = "ТАЙБОЛА",
                            Speed = 16.0
                        },
                        new
                        {
                            Id = 40,
                            ShipClassId = 1,
                            ShipName = "YAMAL SPIRIT",
                            Speed = 14.0
                        },
                        new
                        {
                            Id = 35,
                            ShipClassId = 1,
                            ShipName = "НИКОЛАЙ ЧУДОТВОРЕЦ",
                            Speed = 16.0
                        });
                });

            modelBuilder.Entity("backend.Models.ShipClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ShipType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ShipClass");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ShipType = "Without class"
                        },
                        new
                        {
                            Id = 2,
                            ShipType = "Ice1"
                        },
                        new
                        {
                            Id = 3,
                            ShipType = "Ice2"
                        },
                        new
                        {
                            Id = 4,
                            ShipType = "Ice3"
                        },
                        new
                        {
                            Id = 5,
                            ShipType = "Arc4"
                        },
                        new
                        {
                            Id = 6,
                            ShipType = "Arc5"
                        },
                        new
                        {
                            Id = 7,
                            ShipType = "Arc6"
                        },
                        new
                        {
                            Id = 8,
                            ShipType = "Arc7"
                        },
                        new
                        {
                            Id = 9,
                            ShipType = "Arc9-1"
                        },
                        new
                        {
                            Id = 10,
                            ShipType = "Arc9-2"
                        });
                });

            modelBuilder.Entity("backend.Models.ShipClassIntegerClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Debuff")
                        .HasColumnType("boolean");

                    b.Property<double?>("DebuffValue")
                        .HasColumnType("double precision");

                    b.Property<int>("IntegerIceClassId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsCanMove")
                        .HasColumnType("boolean");

                    b.Property<int>("ShipClassId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IntegerIceClassId");

                    b.HasIndex("ShipClassId");

                    b.ToTable("ShipClassIntegerClass");
                });

            modelBuilder.Entity("backend.Models.Ship", b =>
                {
                    b.HasOne("backend.Models.ShipClass", "ShipClass")
                        .WithMany("Ship")
                        .HasForeignKey("ShipClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShipClass");
                });

            modelBuilder.Entity("backend.Models.ShipClassIntegerClass", b =>
                {
                    b.HasOne("backend.Models.IntegerIceClass", "IntegerIceClass")
                        .WithMany("ShipClassIntegerClasses")
                        .HasForeignKey("IntegerIceClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.ShipClass", "ShipClass")
                        .WithMany("ShipClassIntegerClasses")
                        .HasForeignKey("ShipClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IntegerIceClass");

                    b.Navigation("ShipClass");
                });

            modelBuilder.Entity("backend.Models.IntegerIceClass", b =>
                {
                    b.Navigation("ShipClassIntegerClasses");
                });

            modelBuilder.Entity("backend.Models.ShipClass", b =>
                {
                    b.Navigation("Ship");

                    b.Navigation("ShipClassIntegerClasses");
                });
#pragma warning restore 612, 618
        }
    }
}
