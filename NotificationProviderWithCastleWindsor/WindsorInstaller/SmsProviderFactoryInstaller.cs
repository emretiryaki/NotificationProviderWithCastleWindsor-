using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using NotificationProviderWithCastleWindsor.SmsProviderFactory;

namespace NotificationProviderWithCastleWindsor.WindsorInstaller
{
    public class SmsProviderFactoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container
                .Register(Component.For<ISmsProviderTypedFactory>().AsFactory())
                .Register
                (
                    Component.For<ISmsProviderFactory>().ImplementedBy<SmsProviderFactory.SmsProviderFactory>().LifeStyle.Singleton
                );

        }
    }
}