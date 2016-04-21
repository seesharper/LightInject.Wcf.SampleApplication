namespace LightInject.Wcf.SampleApplication
{
    using System.ServiceModel.Description;

    public class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IService, Service>("LightInject-Wcf-SampleApplication-IService");
            serviceRegistry.Register<IServiceBehavior>(f => CreateServiceMetaBehavior());
        }

        private ServiceMetadataBehavior CreateServiceMetaBehavior()
        {
            var serviceMetaBehavior = new ServiceMetadataBehavior();
            serviceMetaBehavior.HttpGetEnabled = true;
            return serviceMetaBehavior;
        }
    }
}