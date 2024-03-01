using System;
using System.Net.PeerToPeer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Auction.Domain.Models
{
    public class Peer<T>
    {
        public string Username { get; set; }
        public PeerName PeerName { get; set; }
        public T Channel { get; set; }
        public T Host { get; set; }
    }
}
