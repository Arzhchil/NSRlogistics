using backend.DTOs;
using backend.Interfaces;
using backend.Services.CRUDService;
using backend.Services.FindPathService;
using backend.Services.LoadService;
using backend.Services.Parser;
using System.Collections.Generic;

namespace backend.Services.ConnectionService
{
    public class ConnectionService
    {
        /// <summary>
        /// Создание сервисов
        /// </summary>
        /// <param name="builder"></param>
        public static void ConnectService(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IFileUpload, LoadFileService>();
            builder.Services.AddScoped<IFileParser, ParseFileService>();
            builder.Services.AddScoped<ICRUD<Models.Route>, RouteService>();
            builder.Services.AddScoped<ICRUD<ShipCrudDTO>, ShipService>();
            builder.Services.AddScoped<ICRUD<GraphDataDTO>, GraphDataService>();
            builder.Services.AddScoped<IFindPoints, FindPointsService>();
            builder.Services.AddAutoMapper(typeof(Program).Assembly);
        }
    }
}
