using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Infrastructure.Constants;
using Realty_Management_System_Infrastructure.Data.Contexts;
using Realty_Management_System_Infrastructure.Exceptions;

namespace Realty_Management_System_API
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

            // Infrastructure services layer

            // Identity configuration
            builder.Services.AddIdentity<User, IdentityRole<Guid>>(
                options =>
                {
                    options.Password.RequireDigit = true;
                    options.Password.RequireLowercase = true;
                    options.Password.RequireUppercase = true;
                    options.Password.RequireNonAlphanumeric = true;
                    options.Password.RequiredUniqueChars = 0;
                }
            ).AddEntityFrameworkStores<ApplicationDbContext>();

            // ApplicationDbContext configuration
            builder.Services.AddDbContext<ApplicationDbContext>(
                options =>
                {
                    string? connectionString = builder.Configuration.GetConnectionString(
                     AppSettingsConstants.AppSettingsKeys.ConnectionStrings.DefaultConnection
                    );
                    if (connectionString.IsNullOrEmpty())
                    {
                        throw AppSettingException.ConnectionStrings.DefaultConnectionStringNotFound;
                    }
                    options.UseSqlServer(connectionString);
                }
            );


            var app = builder.Build();

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
