using System.Collections.Generic;
using NotificationProviderWithCastleWindsor.NotificationProvider;

namespace NotificationProviderWithCastleWindsor
{
    public interface INotificationProviderTypedFactory
    {
        ICollection<INotificationProvider> GetAllNotificationProviders();
    }
}