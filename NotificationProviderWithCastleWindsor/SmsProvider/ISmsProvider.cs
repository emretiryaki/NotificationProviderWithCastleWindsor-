using NotificationProviderWithCastleWindsor.Enums;

namespace NotificationProviderWithCastleWindsor.SmsProvider
{
    public interface ISmsProvider
    {
        void SendSms(string gsm, string appplicationName, ActivationType activationType, string messagePart, string notificationType);

        SmsSupplierType SmsSupplierType { get; }

    }
}