using System;
using System.Collections.Generic;
using System.Linq;
using NotificationProviderWithCastleWindsor.Enums;
using NotificationProviderWithCastleWindsor.SmsProvider;

namespace NotificationProviderWithCastleWindsor.SmsProviderFactory
{
    public class SmsProviderFactory : ISmsProviderFactory
    {
        public ISmsProviderTypedFactory SmsProviderTypedFactory;

        public SmsProviderFactory(ISmsProviderTypedFactory smsProviderTypedFactory)
        {
            SmsProviderTypedFactory = smsProviderTypedFactory;
        }
        public ISmsProvider GetSmsProvider(SmsSupplierType smsSupplierType)
       {
           //Get All Sms
            ICollection<ISmsProvider> smsProviders = SmsProviderTypedFactory.GetAllSmsProviders();

            //Search By Overriden Sms
            ICollection<ISmsProvider> filteredSmsProviders =
                smsProviders.Where(x => x.SmsSupplierType == smsSupplierType).ToList();

            if (filteredSmsProviders.Any())
            {
                if (filteredSmsProviders.Count > 1)
                {
                    throw new Exception(" This Sms Type Overriden More Than One For This Application");
                }
            }
            else
            {
                throw new Exception(" Sms Type Not Found");
            }
            return filteredSmsProviders.First();
       }
    }
}
