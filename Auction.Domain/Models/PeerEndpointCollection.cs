using System.Net;
using System.Net.PeerToPeer;

namespace Auction.Domain.Models
{
    public class PeerEndpointCollection
    {
        public PeerEndpointCollection(PeerName peer, IPEndPointCollection ipEndPoint)
        {
            PeerHostName = peer;
            PeerEndPoints = ipEndPoint;
        }

        public PeerName PeerHostName { get; }
        public IPEndPointCollection PeerEndPoints { get; }
    }
}
