using NotificationProviderWithCastleWindsor.Enums;
using NotificationProviderWithCastleWindsor.SmsProvider;
using NotificationProviderWithCastleWindsor.SmsProviderFactory;

namespace NotificationProviderWithCastleWindsor.SmsProviderClientFactory
{
   public class SmsProviderClientFactory:ISmsProviderClientFactory
   {
       protected ISmsProviderFactory SmsProviderFactory;

       public SmsProviderClientFactory(ISmsProviderFactory smsProviderFactory)
       {
           SmsProviderFactory = smsProviderFactory;
       }
        public ISmsProvider GetSmsProvider(SmsSupplierType smsSupplierType)
        {
            return SmsProviderFactory.GetSmsProvider(smsSupplierType);
        }
    }
}
