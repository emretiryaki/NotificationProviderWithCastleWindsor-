using NotificationProviderWithCastleWindsor.Enums;
using NotificationProviderWithCastleWindsor.SmsProvider;

namespace NotificationProviderWithCastleWindsor.SmsProviderClientFactory
{
    public interface ISmsProviderClientFactory
    {
        ISmsProvider GetSmsProvider(SmsSupplierType smsSupplierType);
    }
}
