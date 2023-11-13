
using ConversationAPI.DataAccess.EntityPlatform;
using VAMLibrary.Core;

namespace Conversation.API.Extensions
{
    public static class LocalServiceExtention
    {
        public static void RegisterLocalServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<DataAccessHelper>();
            serviceCollection.AddScoped<IEntityHandler, EntityHandler>();
        }
        }
}
