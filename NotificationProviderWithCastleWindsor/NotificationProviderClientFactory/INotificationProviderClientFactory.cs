using NotificationProviderWithCastleWindsor.Enums;
using NotificationProviderWithCastleWindsor.NotificationProvider;

namespace NotificationProviderWithCastleWindsor.NotificationProviderClientFactory
{
    public interface INotificationProviderClientFactory
    {
        INotificationProvider GetNotificationType(NotificationType notificationType);
    }
}