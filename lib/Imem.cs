﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

using K2Informatics.Erlnet;
using System.IO;

namespace K2Informatics.Erlimemnet
{
    public enum ErlType
    {
        EString = 1
    };

    public class ImemException : Exception
    {
        public ImemException() { }
        public ImemException(string message) : base(message) { }
        public ImemException(string message, Exception innerException): base(message, innerException) { }
    }

    public class Imem : Erlnet.Erlnet
    {
        protected ErlStream stream = null;
        protected OtpErlangLong seco = new OtpErlangLong(0);

        // instanciate through Connect
        protected Imem(ErlStream _stream) { stream = _stream; }

        public static bool ValidateServerCertificate(
              object sender,
              X509Certificate certificate,
              X509Chain chain,
              SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        public static object Connect(ref string host, int port, bool secure, Type type)
        {
            TcpClient client = new TcpClient(host, port);
            if (secure)
            {
                NetworkStream s = client.GetStream();
                SslStream ssl = new SslStream(s, false, new RemoteCertificateValidationCallback(ValidateServerCertificate), null);
                ssl.AuthenticateAsClient("");
                return Activator.CreateInstance(type, new object[] { new ErlStream(ssl) });
            }
            else
            {
                NetworkStream ns = client.GetStream();
                return Activator.CreateInstance(type, new object[] { new ErlStream(ns) });
            }
        }

        public void Authenticate(string user, string password)
        {
            OtpErlangObject[] mfaArgs = new OtpErlangObject[4];

            // args for fun
            mfaArgs[0] = new OtpErlangAtom("undefined");
            mfaArgs[1] = new OtpErlangAtom("adminSessionId");
            mfaArgs[2] = new OtpErlangBinary(Encoding.ASCII.GetBytes(user));

            OtpErlangObject[] pswdTuple = new OtpErlangObject[2];
            pswdTuple[0] = new OtpErlangAtom("pwdmd5");
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(inputBytes);
            pswdTuple[1] = new OtpErlangBinary(hash);

            mfaArgs[3] = new OtpErlangTuple(pswdTuple);

            seco = (OtpErlangLong)CallMFASync(stream, "imem_sec", "authenticate", mfaArgs);
        }

        public void Login()
        {
            OtpErlangObject[] mfaArgs = new OtpErlangObject[1];

            mfaArgs[0] = seco;

            if (seco.bigIntegerValue() !=
                ((OtpErlangLong)CallMFASync(stream, "imem_sec", "login", mfaArgs)).bigIntegerValue())
                throw new ImemException("imem login failed");
        }

        public void Logout()
        {
            OtpErlangObject[] mfaArgs = new OtpErlangObject[1];

            mfaArgs[0] = seco;
            CallMFASync(stream, "imem_sec", "logout", mfaArgs);
        }

        public void ChangeCred(string OldCredType, byte[] OldCredPayload, string NewCredType, byte[] NewCredPayload)
        {
            OtpErlangObject[] mfaArgs = new OtpErlangObject[3];

            mfaArgs[0] = seco;
            mfaArgs[1] = new OtpErlangTuple(new OtpErlangObject[] {
                new OtpErlangAtom(OldCredType),
                new OtpErlangBinary(OldCredPayload)
            });
            mfaArgs[2] = new OtpErlangTuple(new OtpErlangObject[] {
                new OtpErlangAtom(NewCredType),
                new OtpErlangBinary(NewCredPayload)
            });

            if (seco.bigIntegerValue() !=
                ((OtpErlangLong)CallMFASync(stream, "imem_sec", "change_credentials", mfaArgs)).bigIntegerValue())
                throw new ImemException("imem change_credentials failed");
        }

        protected OtpErlangObject GetOtpErlangObject(object o)
        {
            if(o.GetType() == typeof(int)) return new OtpErlangInt((int)o);
            if (o.GetType() == typeof(short)) return new OtpErlangShort((short)o);
            if (o.GetType() == typeof(ushort)) return new OtpErlangUShort((short)o);
            if (o.GetType() == typeof(uint)) return new OtpErlangUInt((int)o);
            if (o.GetType() == typeof(long)) return new OtpErlangLong((long)o);
            if (o.GetType() == typeof(float)) return new OtpErlangFloat((float)o);
            if (o.GetType() == typeof(double)) return new OtpErlangDouble((double)o);
            if (o.GetType() == typeof(char)) return new OtpErlangChar((char)o);
            if (o.GetType() == typeof(byte)) return new OtpErlangByte((byte)o);
            if (o.GetType() == typeof(bool)) return new OtpErlangBoolean((bool)o);
            if (o.GetType() == typeof(byte[])) return new OtpErlangBitstr((byte[])o);
            else return new OtpErlangString((string)o);
        }

        protected OtpErlangObject GetOtpErlangObject(int o) { return new OtpErlangInt(o); }
        protected OtpErlangObject GetOtpErlangObject(long o) { return new OtpErlangLong(o); }

        protected OtpErlangObject CallImemMFASync(string mod, string fun, params object[] argsRest)
        {
            return CallImemProxyMFASync("admin_exec", mod, fun, argsRest);
        }

        protected OtpErlangObject CallImemDalMFASync(string mod, string fun, params object[] argsRest)
        {
            return CallImemProxyMFASync("dal_exec", mod, fun, argsRest);
        }

        private OtpErlangObject CallImemProxyMFASync(string proxy, string mod, string fun, params object[] argsRest)
        {
            OtpErlangObject resObj = null;

            // if no module name is provided then
            // assumed intention being call functions of imem_seco
            if (mod.Length == 0)
            {
                OtpErlangObject[] innerMfaArgs = new OtpErlangObject[argsRest.Length + 1];

                innerMfaArgs[0] = seco;
                for (int i = 1; i < innerMfaArgs.Length; ++i)
                    innerMfaArgs[i] = GetOtpErlangObject(argsRest[i]);

                resObj = CallMFASync(stream, "imem_sec", fun, innerMfaArgs);
            }

            // when a module name is provided admin_exec is used for secure access
            else {
                OtpErlangObject[] innerMfaArgs = new OtpErlangObject[argsRest.Length];

                for (int i = 0; i < innerMfaArgs.Length; ++i)
                    innerMfaArgs[i] = GetOtpErlangObject(argsRest[i]);

                OtpErlangObject[] mfaArgs = new OtpErlangObject[4];
                mfaArgs[0] = seco;
                mfaArgs[1] = new OtpErlangAtom(mod);
                mfaArgs[2] = new OtpErlangAtom(fun);
                mfaArgs[3] = new OtpErlangList(innerMfaArgs);
                resObj = CallMFASync(stream, "imem_sec", proxy, mfaArgs);
            }

            if (resObj is OtpErlangTuple
                && ((OtpErlangTuple)resObj).elementAt(0) is OtpErlangAtom
                && ((OtpErlangAtom)((OtpErlangTuple)resObj).elementAt(0)).atomValue() == "error")
            {
                OtpErlangTuple excp = (OtpErlangTuple)((OtpErlangTuple)resObj).elementAt(1);
                throw new ImemException(excp.ToString());
            }
            return resObj;
        }

        protected static new OtpErlangObject CallMFASync(ErlStream stream,
            string module, string function, OtpErlangObject[] args)
        {
            OtpErlangObject resObj = Erlnet.Erlnet.CallMFASync(stream, module, function, args);
            if (resObj is OtpErlangTuple
                && ((OtpErlangTuple)resObj).elementAt(0) is OtpErlangAtom
                && ((OtpErlangAtom)((OtpErlangTuple)resObj).elementAt(0)).atomValue() == "error")
            {
                OtpErlangObject excp = ((OtpErlangTuple)resObj).elementAt(1);
                throw new ImemException(excp.ToString());
            }
            return resObj;
        }


        public static ArrayList TranslateResult(OtpErlangObject result)
        {
            ArrayList res = new ArrayList();

            if (result is OtpErlangTuple)
                TranslateToArray(res, ((OtpErlangTuple)result).elements());
            else if (result is OtpErlangList)
                TranslateToArray(res, ((OtpErlangList)result).elements());

            return res;
        }

        private static void TranslateToArray(ArrayList res, OtpErlangObject[] elements)
        {
            foreach (OtpErlangObject erlO in elements)
            {
                // Leaf node
                if ((erlO is OtpErlangTuple)
                  && (((OtpErlangTuple)erlO).arity() == 2)
                  && (((OtpErlangTuple)erlO).elementAt(0) is OtpErlangLong))
                {
                    ErlType mtyp = (ErlType)((OtpErlangLong)((OtpErlangTuple)erlO).elementAt(0)).intValue();
                    OtpErlangObject oeo = ((OtpErlangTuple)erlO).elementAt(1);
                    switch (mtyp)
                    {
                        case ErlType.EString:
                            if (oeo is OtpErlangString)
                                res.Add(((OtpErlangString)oeo).stringValue());
                            else if (oeo is OtpErlangBinary)
                                res.Add(((OtpErlangBinary)oeo).stringValue());
                            else if (oeo is OtpErlangList && ((OtpErlangList)oeo).arity() == 0)
                                res.Add("");
                            break;
                        default:
                            throw new Exception("Unknown type " + erlO.ToString());
                    }
                }
                else if (erlO is OtpErlangTuple || (erlO is OtpErlangList && ((OtpErlangList)erlO).arity() > 0))
                    res.Add(TranslateResult(erlO));
                else
                    res.Add(erlO.ToString());
            }
        }
    }
}