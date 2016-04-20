namespace LightInject.Wcf.SampleApplication
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        int GetValue(int value);
    }

    public class Service : IService
    {
        public int GetValue(int value)
        {
            return value;
        }
    }
}