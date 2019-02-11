using SimpleInjector;
using T4WSystem.Application.AppServices;
using T4WSystem.Application.Interfaces;
using T4WSystem.Domain.Interfaces;
using T4WSystem.Domain.Services;

namespace T4WSystem.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe
            // Lifestyle.Scoped => Uma instancia unica para o request
            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>), Lifestyle.Scoped);
            container.Register<ICangoorooBookingService, CangoorooBookingService>(Lifestyle.Scoped);

            container.Register<ICangoorooBookingAppService, CangoorooBookingAppService>(Lifestyle.Scoped);
        }
    }
}
