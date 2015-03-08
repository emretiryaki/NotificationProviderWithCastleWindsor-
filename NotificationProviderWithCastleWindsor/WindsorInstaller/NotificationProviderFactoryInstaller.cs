using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using NotificationProviderWithCastleWindsor.NotificationProviderFactory;

namespace NotificationProviderWithCastleWindsor.WindsorInstaller
{
    public class NotificationProviderFactoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container
                .Register(Component.For<INotificationProviderTypedFactory>().AsFactory())
                .Register
                (
                    Component.For<INotificationProviderFactory>().ImplementedBy<NotificationProviderFactory.NotificationProviderFactory>().LifeStyle.Singleton
                );

        }
    }
}