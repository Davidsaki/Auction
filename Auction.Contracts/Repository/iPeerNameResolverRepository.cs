using Auction.Domain.Models;
using System;
using System.Net.PeerToPeer;

namespace Auction.Contracts.Repository
{
    public interface iPeerNameResolverRepository
    { 
        void ResolvePeerName();
        PeerEndpointCollection PeerEndpointCollection { get; set; }
    }
}
 