using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using K2Informatics.Erlnet;
using K2Informatics.Erlimemnet;
using System.Collections;
using System.Diagnostics;

namespace ProvLoadApp
{
    class ImemInterface : Imem
    {
        private Random random = new Random();
        public ImemInterface(ErlStream _stream) : base(_stream) { }

        public static ImemInterface Connect(ref string host, int port, bool secure)
        {
            return (ImemInterface)Imem.Connect(ref host, port, secure, typeof(ImemInterface));
        }

        private string chn = "";
        public object[] read(string channel, string item, string key)
        {
            chn = channel;
            return CallMFASync("read", channel, item, key);
        }
        public object[] readGT(string channel, string item, string key, string limit)
        {
            chn = channel;
            return CallMFASync("readGT", channel, item, key, limit);
        }
        public object[] audit_readGT(string channel, string item, string key, string limit)
        {
            return CallMFASync("audit_readGT", channel, item, key, limit);
        }

        private object[] CallMFASync(string fun, params object[] argsRest)
        {
            return UnwrapResult(CallImemDalMFASync("imem_dal_skvh", fun, argsRest));
        }

        public string[] readValueRandomKey(string[] keys)
        {
            string key = keys[random.Next(keys.Length)];
            string value = ((OtpErlangBinary)(read(chn, "value", key)[0])).stringValue();
            return new string[] { key, value };
        }
    }
}