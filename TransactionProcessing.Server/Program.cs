using Microsoft.EntityFrameworkCore;
using Serilog;
using TransactionProcessing.Server.Data;
using TransactionProcessing.Server.Services;


namespace TransactionProcessing
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Additional configuration is required to successfully run gRPC on macOS.
            // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

            // Add services to the container.
            builder.Services.AddGrpc();
            builder.Services.AddDbContext<TransactionProcessingContext>(
                option
                => {
                    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));
                }
                );
            builder.Host.UseSerilog((hostContext, configuration) =>
            {
                configuration
                    .ReadFrom.Configuration(hostContext.Configuration);
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.MapGrpcService<SpoolPendingtransactionsService>();
            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
            app.UseSerilogRequestLogging();
            app.Run();
        }
    }

}

