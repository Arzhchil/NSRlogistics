using backend.Data;
using backend.Services.ConnectionService;
using Microsoft.EntityFrameworkCore;

namespace backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Data context
            builder.Services.AddDbContext<DataContext>(op =>
            {
                // òÿíåì íàñòðîéêó ïîäêëþ÷åíèÿ ê áä
                op.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            // connection service
            ConnectionService.ConnectService(builder);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // cors
            app.UseCors(op => op.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
