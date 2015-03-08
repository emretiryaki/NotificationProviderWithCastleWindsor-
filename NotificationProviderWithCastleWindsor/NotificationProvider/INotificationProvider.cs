using NotificationProviderWithCastleWindsor.Enums;

namespace NotificationProviderWithCastleWindsor.NotificationProvider
{
    public interface INotificationProvider
    {
        void Send(string notificationType, string applicationName, SmsSupplierType supplierType, ActivationType activationType, string activationCode);
        NotificationType NotificationType { get; }
    }
}