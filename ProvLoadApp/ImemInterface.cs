using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using K2Informatics.Erlnet;
using K2Informatics.Erlimemnet;
using System.Collections;

namespace WindowsFormsApplication1
{
    class ImemInterface : Imem
    {
        public ImemInterface(ErlStream _stream) : base(_stream) { }

        public static ImemInterface Connect(ref string host, int port, bool secure)
        {
            return (ImemInterface)Imem.Connect(ref host, port, secure, typeof(ImemInterface));
        }

        private ArrayList CallMFASync(string fun, params object[] argsRest)
        {
            return TranslateResult(UnwrapResult(CallImemMFASync("imem_dal_skvh", fun, argsRest)));
        }
    }
}