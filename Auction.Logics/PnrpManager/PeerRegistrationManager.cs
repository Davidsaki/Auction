using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auction.Contracts.Repository;

namespace Auction.Logics.PnrpManager
{
    public class PeerRegistrationManager : IPeerRegistrationRepository
    {
        private PeerNameRegistration _peerNameRegistration = null;
        public bool IsPeerRegistered => _peerNameRegistration != null && _peerNameRegistration.IsRegistered();

        public string PeerUri { get; }

        public PeerName PeerName { get; }

        public void StartPeerRegistration()
        {
            throw new NotImplementedException();
        }

        public void StopPeerRegistration()
        {
            throw new NotImplementedException();
        }
    }
}
