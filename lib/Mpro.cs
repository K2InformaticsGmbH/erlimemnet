using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Collections;
using K2Informatics.Erlnet;

namespace K2Informatics.Erlimemnet
{
    public class Mpro : Imem
    {
        public Mpro(ErlStream _stream) : base(_stream) { }

        public static Mpro Connect(ref string host, int port, bool secure)
        {
            return (Mpro)Imem.Connect(ref host, port, secure, typeof(Mpro));
        }

        public object[] listDestinationChannels(ref string AppId)
        {
            return CallMproMFASync("listDestinationChannels", AppId);
        }

        public object[] deleteSourcePeer(ref string AppId, ref string Key)
        {
            return CallMproMFASync("deleteSourcePeer", AppId, Key);
        }

        public object[] listSourcePeerKeys(ref string AppId)
        {
            return CallMproMFASync("listSourcePeerKeys", AppId);
        }

        public object[] listSourcePeers(ref string AppId)
        {
            return CallMproMFASync("listSourcePeers", AppId);
        }

        public object[] putSourcePeer(ref string AppId, ref string Key, ref string ChStr, ref string SpName, ref string OptStr)
        {
            return CallMproMFASync("putSourcePeer", AppId, Key, ChStr, SpName, OptStr);
        }

        public object[] putWhitelist(ref string AppId, ref string Key, ref string IpAddressStr, ref string OptStr)
        {
            return CallMproMFASync("putWhitelist", AppId, Key, IpAddressStr, OptStr);
        }

        public object[] deleteWhitelist(ref string AppId, ref string Key, ref string IpAddressStr)
        {
            return CallMproMFASync("deleteWhitelist", AppId, Key, IpAddressStr);
        }

        public object[] getSourcePeer(ref string AppId, ref string Key)
        {
            return CallMproMFASync("getSourcePeer", AppId, Key);
        }

        public object[] getWhitelist(ref string AppId, ref string Key)
        {
            return CallMproMFASync("getWhitelist", AppId, Key);
        }

        private object[] CallMproMFASync(string fun, params object[] argsRest)
        {
            return UnwrapResult(CallImemMFASync("mpro_dal_prov", fun, argsRest));
        }
    }
}
