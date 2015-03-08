using System;
using NotificationProviderWithCastleWindsor.Enums;

namespace NotificationProviderWithCastleWindsor.SmsProvider
{
    public  class  VodeFoneProvider : ISmsProvider
    {
        public void SendSms(string gsm, string applicationName, ActivationType activationType, string messagePart,string notificationType)
        {
            Console.WriteLine("Application  {1}  For : {4} Gsm : {0}  Activation Code : {2} SmsSupplier Type : {3}", gsm, applicationName, messagePart, SmsSupplierType, notificationType);
        }

        public SmsSupplierType SmsSupplierType
        {
            get
            {
                return SmsSupplierType.Vodefone;
            }
        }
    }
}