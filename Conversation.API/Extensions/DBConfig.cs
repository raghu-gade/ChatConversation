using VAMLibrary.Core;

namespace Conversation.API.Extensions
{
    public static class DBConfig
    {
        /// <summary>
        /// RegisterDatabaseProvider
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void RegisterDatabaseProvider(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DBConnection");
            //if (configuration.GetValue<bool>("ElasticPoolConfig:IsEnabled"))
            //{
            //    //]connectionString = DBProvider.GetTenantConnString(configuration.GetValue<int>("ElasticPoolConfig:TenantId"),
            //    //connectionString);
            //}

            services.AddScoped(dbc =>
            {

                return DBProvider.CreateDatabase(connectionString);
            });
        }
    }
}
