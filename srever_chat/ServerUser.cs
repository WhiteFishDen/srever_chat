using System.ServiceModel;

namespace srever_chat
{
    internal class ServerUser
    {
        public int ID { get; set; }
        public string  Name { get; set; }
        public OperationContext operationContext { get; set; }
    }
}
