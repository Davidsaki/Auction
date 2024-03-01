using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Contracts.Services
{
    [ServiceContract(CallbackContract = typeof(iPingService))]
    public interface iPingService
    {
        [OperationContract(IsOneWay = true)]
        void Ping(int port, string peerUri);
    }
}
