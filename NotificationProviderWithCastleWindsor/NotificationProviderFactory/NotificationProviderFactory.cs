using System;
using System.Collections.Generic;
using System.Linq;
using NotificationProviderWithCastleWindsor.Enums;
using NotificationProviderWithCastleWindsor.NotificationProvider;

namespace NotificationProviderWithCastleWindsor.NotificationProviderFactory
{
    public class NotificationProviderFactory : INotificationProviderFactory
    {
        public INotificationProviderTypedFactory NotificationProviderTypedFactory;

        public NotificationProviderFactory(INotificationProviderTypedFactory notificationProviderTypedFactory)
        {
            NotificationProviderTypedFactory = notificationProviderTypedFactory;
        }
        public INotificationProvider GetNotificationType(NotificationType notificationType)
        {
            //Get All Notifications
            ICollection<INotificationProvider> notificationProviders = NotificationProviderTypedFactory.GetAllNotificationProviders();

            //Search By Overriden Notification
            ICollection<INotificationProvider> filteredNotificationProviders = notificationProviders.Where(a => a.NotificationType == notificationType).ToList();

            if (filteredNotificationProviders.Any())
            {
                if (filteredNotificationProviders.Count > 1)
                {
                    throw new Exception(" This Notification Type Overriden More Than One For This Application");
                }
            }
            else
            {
                throw new Exception(" Notification Type Not Found");
            }

            return filteredNotificationProviders.First();
        }
    }
}