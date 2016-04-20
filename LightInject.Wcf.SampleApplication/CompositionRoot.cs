namespace LightInject.Wcf.SampleApplication
{
    public class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IService, Service>("LightInject-Wcf-SampleApplication-IService");
        }
    }
}