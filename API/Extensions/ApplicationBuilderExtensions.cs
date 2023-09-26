using Database;
using Services.NewsService;

namespace API.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void StartService(this WebApplicationBuilder builder)
        {
            builder.Services
                .AddDatabase<AvaTradeContext>(builder.Configuration)
                .AddTransient<INewsService, NewsService>()
                .AddSwaggerGen()
                .AddControllers();

            builder.WebHost.ConfigureKestrel(options =>
            {
                options.ListenAnyIP(80);
            });

            WebApplication application = builder.Build();

            application.UseRequestLocalization();

            if (application.Environment.IsDevelopment())
            {
                application
                    .UseSwagger()
                    .UseSwaggerUI(c =>
                    {
                        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
                        c.RoutePrefix = "swagger";
                    })
                    .UseDeveloperExceptionPage();
            }
            else
            {
                application.UseHsts();
            }

            application
                .UseRouting()
                .UseHttpsRedirection();

            application.MapControllers();

            application.Run();
        }
    }
}
