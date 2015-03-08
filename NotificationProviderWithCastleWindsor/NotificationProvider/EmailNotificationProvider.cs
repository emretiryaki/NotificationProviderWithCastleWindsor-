using System;
using NotificationProviderWithCastleWindsor.Enums;

namespace NotificationProviderWithCastleWindsor.NotificationProvider
{
    public class EmailNotificationProvider : INotificationProvider
    {
        public void Send(string notificationType, string applicationName, SmsSupplierType supplierType, ActivationType activationType,
            string activationCode)
        {
            Console.WriteLine("Application  {1} For : {0}  Activation Code : {2}", notificationType, applicationName, activationCode);
        }

        public NotificationType NotificationType
        {
            get
            {
                return NotificationType.Email;
            }
        }
    }
}