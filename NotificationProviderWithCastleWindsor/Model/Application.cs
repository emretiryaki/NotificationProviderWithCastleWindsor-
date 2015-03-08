using NotificationProviderWithCastleWindsor.Enums;

namespace NotificationProviderWithCastleWindsor.Model
{
    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public NotificationType NotificationType { get; set; }
        public SmsSupplierType SmsSupplierType { get; set; }
    }
}