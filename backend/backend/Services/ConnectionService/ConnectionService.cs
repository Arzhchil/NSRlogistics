using backend.Interfaces;
using backend.Services.CRUDService;
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
            builder.Services.AddAutoMapper(typeof(Program).Assembly);
        }
    }
}
