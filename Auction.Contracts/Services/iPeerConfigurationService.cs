using Auction.Domain.Models;

namespace Auction.Contracts.Services
{
    public interface iPeerConfigurationService 
    { 
        int port { get; }
        Peer<iPingService> Peer { get; }
        bool StartPeerService();
        bool StopPeerService();
    }
}

