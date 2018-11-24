using Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO.Compression;
using wowapi.Contexts;
using wowapi.Contracts;
using wowapi.Contracts.Classic;
using wowapi.Contracts.Dbc;
using wowapi.Repository.Classic;
using wowapi.Services;

namespace wowapi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionStringClassic = config["mysqlconnection:connectionStringClassic"];
            var connectionStringDbc = config["mysqlconnection:connectionStringDbc"];
            services.AddDbContext<CRepositoryContext>(o => o.UseMySql(connectionStringClassic));
            services.AddDbContext<DbcRepositoryContext>(o => o.UseMySql(connectionStringDbc));

        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<ICRepositoryWrapper, CRepositoryWrapper>();
            services.AddScoped<IDbcRepositoryWrapper, DbcRepositoryWrapper>();
            services.AddScoped<IAggregatorService, AggregatorService>();
        }

        public static void ConfigureGzipCompression(this IServiceCollection services)
        {
            services.Configure<GzipCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Fastest;
            });
        }

        public static void ConfigureBrotliCompression(this IServiceCollection services) {
            services.AddResponseCompression(options =>
            {
                options.Providers.Add<BrotliCompressionProvider>();
            });
        }

        public static void ConfigureBrotliCompressionTLS(this IServiceCollection services) {
            services.AddResponseCompression(options => {
                options.Providers.Add<BrotliCompressionProvider>();
                options.EnableForHttps = true;
            });
    }
    }
}
