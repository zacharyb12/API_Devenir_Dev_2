
using Application_Devenir_Dev_2.Services;
using Application_Devenir_Dev_2.Services.Interfaces;
using Domain_Devenir_Dev_2.Interfaces;
using Infrastructure.Devenir_Dev_2.Data;
using Infrastructure.Devenir_Dev_2.Repositories;
using Microsoft.EntityFrameworkCore;

namespace API_Devenir_Dev_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configuration----------------------------

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Configuration de Entity Framework Core avec SQL Server
            builder.Services.AddDbContext<MovieContext>(options =>
                // fournir la connectionString en paramètre
                options.UseSqlServer(builder.Configuration.GetConnectionString("myConnection"))
            );

            // Injection de dépendance
            builder.Services.AddScoped<IMovieService, MovieService>();
            builder.Services.AddScoped<IMovieRepository , MovieRepository>();



            // construction de l'application 
            var app = builder.Build();

            // Utilisation -----------------------------

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
