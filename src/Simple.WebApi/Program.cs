using Simple.WebApi.Middleware;

namespace Simple.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            AddServices(builder.Services);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseRequestTrackware();
            app.UseAuthorization();
            app.MapControllers();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Simple Api Project");
                    c.RoutePrefix = string.Empty;
                });
            }

            app.Run();
        }

        // Add services to the container.
        public static void AddServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
    }
}