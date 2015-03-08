using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using NotificationProviderWithCastleWindsor.NotificationProviderClientFactory;

namespace NotificationProviderWithCastleWindsor.WindsorInstaller
{
    public class NotificationProviderClientFactoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container
                .Register
                (
                    Component.For<INotificationProviderClientFactory>().ImplementedBy<NotificationProviderClientFactory.NotificationProviderClientFactory>().LifeStyle.Transient
                );

        

        }
    }
}
