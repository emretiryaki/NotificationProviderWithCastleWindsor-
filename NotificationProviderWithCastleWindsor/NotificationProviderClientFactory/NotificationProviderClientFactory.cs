using NotificationProviderWithCastleWindsor.Enums;
using NotificationProviderWithCastleWindsor.NotificationProvider;
using NotificationProviderWithCastleWindsor.NotificationProviderFactory;

namespace NotificationProviderWithCastleWindsor.NotificationProviderClientFactory
{
    public class NotificationProviderClientFactory : INotificationProviderClientFactory
    {
        protected readonly INotificationProviderFactory NotificationProviderFactory;

        public NotificationProviderClientFactory(INotificationProviderFactory notificationProviderFactory)
        {
            NotificationProviderFactory = notificationProviderFactory;
        }

        public INotificationProvider GetNotificationType(NotificationType notificationType)
        {
            return NotificationProviderFactory.GetNotificationType(notificationType);
        }
    }
}