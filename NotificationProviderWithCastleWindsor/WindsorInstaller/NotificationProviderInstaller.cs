using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using NotificationProviderWithCastleWindsor.NotificationProvider;

namespace NotificationProviderWithCastleWindsor.WindsorInstaller
{
    public class NotificationProviderInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes.FromAssemblyInDirectory(new AssemblyFilter(""))
                    .BasedOn(typeof(INotificationProvider))
                    .WithService.AllInterfaces()
                    .LifestyleTransient());
        }
    }
}