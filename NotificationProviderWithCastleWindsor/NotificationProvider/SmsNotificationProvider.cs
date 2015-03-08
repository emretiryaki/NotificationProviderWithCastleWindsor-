using NotificationProviderWithCastleWindsor.Enums;
using NotificationProviderWithCastleWindsor.SmsProviderClientFactory;

namespace NotificationProviderWithCastleWindsor.NotificationProvider
{
    public class SmsNotificationProvider : INotificationProvider
    {
        protected ISmsProviderClientFactory SmsProviderClientFactory;

        public SmsNotificationProvider(ISmsProviderClientFactory smsProviderClientFactory)
        {
            SmsProviderClientFactory = smsProviderClientFactory;
        }

        public void Send(string notificationType, string applicationName, SmsSupplierType supplierType, ActivationType activationType, string activationCode)
        {
          var smsprovider=  SmsProviderClientFactory.GetSmsProvider(supplierType);
          smsprovider.SendSms("111111111", applicationName, activationType, activationCode, notificationType);
        }
        

        public NotificationType NotificationType
        {
            get
            {
                return NotificationType.Sms;
            }
        }
    }
}