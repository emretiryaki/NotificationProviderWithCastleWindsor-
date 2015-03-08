using System.ComponentModel;

namespace NotificationProviderWithCastleWindsor.Enums
{
    public enum SmsSupplierType
    {
        [Description("Applications which doesnt have sms integration")]
        None = 1,
        [Description("DataPort")]
        DataPort = 2,
          [Description("Vodefone")]
        Vodefone
    }
}