using System;
using System.Globalization;
using Castle.Facilities.TypedFactory;
using Castle.Windsor;
using Castle.Windsor.Installer;
using NotificationProviderWithCastleWindsor.Enums;
using NotificationProviderWithCastleWindsor.Model;
using NotificationProviderWithCastleWindsor.NotificationProviderClientFactory;

namespace NotificationProviderWithCastleWindsor
{
    class Program
    {
        private static INotificationProviderClientFactory _notificationProviderClientFactory;
        static void Main(string[] args)
        {

            var container = new WindsorContainer();
            var kernel = container.Kernel.AddFacility<TypedFactoryFacility>();
            container.Install(FromAssembly.This());
           
            _notificationProviderClientFactory = kernel.Resolve<INotificationProviderClientFactory>();

            var applicationFirst = new Application { Id = 1, Name = "Nike", NotificationType = NotificationType.Email };
            Activation("EnrollActivation Is Running", applicationFirst, ActivationType.EnrollActivation);
           
            
            var applicationSecond = new Application { Id = 2, Name = "Adidas", NotificationType = NotificationType.Sms, SmsSupplierType = SmsSupplierType.DataPort };
            Activation("Customer Password ChangeActivation Is Running", applicationSecond, ActivationType.CustomerPasswordChangeActivation);
            
            
            var applicationThird = new Application { Id = 3, Name = "Puma", NotificationType = NotificationType.Sms, SmsSupplierType = SmsSupplierType.Vodefone };
            Activation("Customer Password EnrollActivation Is Running", applicationThird, ActivationType.EnrollActivation);

        }

        public static void Activation(string notificationInfo, Application application, ActivationType activationType)
        {
            var notificationProvider = _notificationProviderClientFactory.GetNotificationType(application.NotificationType);
            var rnd = new Random();
            notificationProvider.Send(notificationInfo, application.Name, application.SmsSupplierType, activationType, rnd.Next(1, 101).ToString(CultureInfo.InvariantCulture));
        }
    }


}
