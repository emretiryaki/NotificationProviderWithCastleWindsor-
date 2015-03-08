using System.ComponentModel;

namespace NotificationProviderWithCastleWindsor.Enums
{
    public enum NotificationType
    {
        [Description("Sms")]
        Sms = 1,
        [Description("Email")]
        Email = 2
    }
}