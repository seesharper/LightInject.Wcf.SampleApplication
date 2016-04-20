using LightInject.Wcf.SampleApplication;

[assembly: System.Web.PreApplicationStartMethod(typeof(Startup), "Initialize")]
namespace LightInject.Wcf.SampleApplication
{
    using LightInject;
    using LightInject.Wcf;

    public class Startup
    {
        public static void Initialize()
        {
            var container = new ServiceContainer();
            container.RegisterFrom<CompositionRoot>();
            LightInjectServiceHostFactory.Container = container;
        }
    }
}