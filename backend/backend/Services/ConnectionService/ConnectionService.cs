using backend.Interfaces;
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
            builder.Services.AddAutoMapper(typeof(Program).Assembly);
        }
    }
}
