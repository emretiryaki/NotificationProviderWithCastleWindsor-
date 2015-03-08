using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using NotificationProviderWithCastleWindsor.SmsProviderClientFactory;

namespace NotificationProviderWithCastleWindsor.WindsorInstaller
{
    public class SmsProviderClientFactoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container
                .Register
                (
                    Component.For<ISmsProviderClientFactory>().ImplementedBy<SmsProviderClientFactory.SmsProviderClientFactory>().LifeStyle.Transient
                );



        }
    }
}