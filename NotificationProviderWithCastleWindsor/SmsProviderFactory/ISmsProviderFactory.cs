using NotificationProviderWithCastleWindsor.Enums;
using NotificationProviderWithCastleWindsor.SmsProvider;

namespace NotificationProviderWithCastleWindsor.SmsProviderFactory
{
    public interface ISmsProviderFactory
    {
        ISmsProvider GetSmsProvider(SmsSupplierType smsSupplierType);
    }
}