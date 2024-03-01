using System;
using System.Net.PeerToPeer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Contracts.Repository
{
    public interface IPeerRegistrationRepository
    {
        bool IsPeerRegistered { get;  }
        string PeerUri { get; }
        PeerName PeerUri { get; }

        void StartPeerRegistration();
        void StopPeerRegistration();
    }
}
 
