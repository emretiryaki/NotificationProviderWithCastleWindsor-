using System.Collections.Generic;
using NotificationProviderWithCastleWindsor.SmsProvider;

namespace NotificationProviderWithCastleWindsor
{
    public interface ISmsProviderTypedFactory
    {
        ICollection<ISmsProvider> GetAllSmsProviders();
    }
}