﻿using System;
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

        public ArrayList listDestinationChannels(ref string AppId)
        {
            return CallMproMFASync("listDestinationChannels", AppId);
        }

        public ArrayList deleteSourcePeer(ref string AppId, ref string Key)
        {
            return CallMproMFASync("deleteSourcePeer", AppId, Key);
        }

        public ArrayList listSourcePeerKeys(ref string AppId)
        {
            return CallMproMFASync("listSourcePeerKeys", AppId);
        }

        public ArrayList listSourcePeers(ref string AppId)
        {
            return CallMproMFASync("listSourcePeers", AppId);
        }

        public ArrayList putSourcePeer(ref string AppId, ref string Key, ref string ChStr, ref string SpName, ref string OptStr)
        {
            return CallMproMFASync("putSourcePeer", AppId, Key, ChStr, SpName, OptStr);
        }

        public ArrayList putWhitelist(ref string AppId, ref string Key, ref string IpAddressStr, ref string OptStr)
        {
            return CallMproMFASync("putWhitelist", AppId, Key, IpAddressStr, OptStr);
        }

        public ArrayList deleteWhitelist(ref string AppId, ref string Key, ref string IpAddressStr)
        {
            return CallMproMFASync("deleteWhitelist", AppId, Key, IpAddressStr);
        }

        public ArrayList getSourcePeer(ref string AppId, ref string Key)
        {
            return CallMproMFASync("getSourcePeer", AppId, Key);
        }

        public ArrayList getWhitelist(ref string AppId, ref string Key)
        {
            return CallMproMFASync("getWhitelist", AppId, Key);
        }

        private ArrayList CallMproMFASync(string fun, params object[] argsRest)
        {
            return TranslateResult(UnwrapResult(CallImemMFASync("mpro_dal_prov", fun, argsRest)));
        }
    }
}
