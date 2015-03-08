using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using NotificationProviderWithCastleWindsor.SmsProvider;

namespace NotificationProviderWithCastleWindsor.WindsorInstaller
{
    public class SmsProviderInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes.FromAssemblyInDirectory(new AssemblyFilter(""))
                    .BasedOn(typeof(ISmsProvider))
                    .WithService.AllInterfaces()
                    .LifestyleTransient());
        }
    }
}