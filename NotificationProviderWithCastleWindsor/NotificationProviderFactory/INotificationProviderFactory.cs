using NotificationProviderWithCastleWindsor.Enums;
using NotificationProviderWithCastleWindsor.NotificationProvider;

namespace NotificationProviderWithCastleWindsor.NotificationProviderFactory
{
    public interface INotificationProviderFactory
    {
        INotificationProvider GetNotificationType(NotificationType notificationType);
    }
}