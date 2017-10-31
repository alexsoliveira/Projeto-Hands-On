using TesteHandsonCurriculum.Application.Apps;
using TesteHandsonCurriculum.Application.Interfaces;
using TesteHandsonCurriculum.Domain.Interfaces.Repository;
using TesteHandsonCurriculum.Domain.Interfaces.Services;
using TesteHandsonCurriculum.Domain.Services;
using TesteHandsonCurriculum.Infra.Data.Context;
using TesteHandsonCurriculum.Infra.Data.IoW;
using TesteHandsonCurriculum.Infra.Data.Repository;
using SimpleInjector;

namespace TesteHandsonCurriculum.Infra.CC.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            // App
            container.Register<ISuspeitoAppService, SuspeitoAppService>(Lifestyle.Scoped);
            container.Register<ILocalAppService, LocalAppService>(Lifestyle.Scoped);
            container.Register<IArmaAppService, ArmaAppService>(Lifestyle.Scoped);            

            // Domain
            container.Register<ISuspeitoService, SuspeitoService>(Lifestyle.Scoped);
            container.Register<ILocalService, LocalService>(Lifestyle.Scoped);
            container.Register<IArmaService, ArmaService>(Lifestyle.Scoped);            

            // Infra
            container.Register<ISuspeitoRepository, SuspeitoRepository>(Lifestyle.Scoped);
            container.Register<ILocalRepository, LocalRepository>(Lifestyle.Scoped);
            container.Register<IArmaRepository, ArmaRepository>(Lifestyle.Scoped);            
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<HandsOnAspNETContext>(Lifestyle.Scoped);
        }
    }
}