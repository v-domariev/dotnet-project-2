
using HotelSystem2.Server.Context;
using HotelSystem2.Server.Services;
using Microsoft.EntityFrameworkCore;

namespace HotelSystem2.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddDbContext<HotelContext>(opt => opt.UseSqlServer("Server=DESKTOP-QBPEBIC\\DEVELOPERDB;Database=HotelSystem1;User Id=hoteladmin;Password=1;TrustServerCertificate=True;"));
            //builder.Services.AddDbContext<HotelContext>(opt => opt.UseSqlServer("Server=DESKTOP-QBPEBIC\\DEVELOPERDB;Database=HotelSystem1;"));
            builder.Services.AddScoped<IHotelContext, HotelContext>();
            builder.Services.AddScoped<IHotelService, HotelService>();
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.MapFallbackToFile("/index.html");

            //services.AddScoped<IDbContext, HotelContext>();
            //services.AddDbContext<HotelContext>(opt => opt.UseSqlServer("Server=DESKTOP-QBPEBIC\\DEVELOPERDB;Database=HotelSystem1;IntegratedSecurity=true;"));

            //services.AddScoped<IDbContext, HotelContext>();
            //services.AddDbContext<HotelContext>(opt => opt.UseSqlServer("connection string"));

            app.Run();
        }
    }
}
