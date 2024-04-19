using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace SunnyTest
{

    class Sunny86
    {
        const string DLLName = "Sunny.dll";

        [DllImport(DLLName, EntryPoint = "CreateSunnyNet", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_CreateSunnyNet();

        [DllImport(DLLName, EntryPoint = "ReleaseSunnyNet", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_ReleaseSunnyNet(System.Int32 SunnyContext);

        [DllImport(DLLName, EntryPoint = "SunnyNetStart", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SunnyNetStart(System.Int32 SunnyContext);

        [DllImport(DLLName, EntryPoint = "SunnyNetSetPort", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SunnyNetSetPort(System.Int32 SunnyContext, System.Int32 Port);

        [DllImport(DLLName, EntryPoint = "SunnyNetClose", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SunnyNetClose(System.Int32 SunnyContext);

        [DllImport(DLLName, EntryPoint = "SunnyNetSetCert", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SunnyNetSetCert(System.Int32 SunnyContext, System.Int32 CertificateManagerId);

        [DllImport(DLLName, EntryPoint = "SunnyNetInstallCert", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_SunnyNetInstallCert(System.Int32 SunnyContext);

        [DllImport(DLLName, EntryPoint = "SunnyNetSetCallback", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SunnyNetSetCallback(System.Int32 SunnyContext, IntPtr httpCallback, IntPtr tcpCallback, IntPtr wsCallback, IntPtr udpCallback);

        [DllImport(DLLName, EntryPoint = "SunnyNetSocket5AddUser", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SunnyNetSocket5AddUser(System.Int32 SunnyContext, IntPtr User, IntPtr Pass);

        [DllImport(DLLName, EntryPoint = "SunnyNetVerifyUser", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SunnyNetVerifyUser(System.Int32 SunnyContext, bool open);

        [DllImport(DLLName, EntryPoint = "SunnyNetSocket5DelUser", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SunnyNetSocket5DelUser(System.Int32 SunnyContext, IntPtr User);

        [DllImport(DLLName, EntryPoint = "SunnyNetMustTcp", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SunnyNetMustTcp(System.Int32 SunnyContext, bool open);

        [DllImport(DLLName, EntryPoint = "CompileProxyRegexp", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_CompileProxyRegexp(System.Int32 SunnyContext, IntPtr Regexp);

        [DllImport(DLLName, EntryPoint = "SetMustTcpRegexp", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetMustTcpRegexp(System.Int32 SunnyContext, IntPtr Regexp);

        [DllImport(DLLName, EntryPoint = "SunnyNetError", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_SunnyNetError(System.Int32 SunnyContext);

        [DllImport(DLLName, EntryPoint = "SetGlobalProxy", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetGlobalProxy(System.Int32 SunnyContext, IntPtr ProxyAddress);

        [DllImport(DLLName, EntryPoint = "ExportCert", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_ExportCert(System.Int32 SunnyContext);

        [DllImport(DLLName, EntryPoint = "SetIeProxy", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetIeProxy(System.Int32 SunnyContext, bool Off);

        [DllImport(DLLName, EntryPoint = "SetRequestCookie", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SetRequestCookie(System.Int32 MessageId, IntPtr name, IntPtr val);

        [DllImport(DLLName, EntryPoint = "SetRequestAllCookie", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SetRequestAllCookie(System.Int32 MessageId, IntPtr val);

        [DllImport(DLLName, EntryPoint = "GetRequestCookie", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetRequestCookie(System.Int32 MessageId, IntPtr name);

        [DllImport(DLLName, EntryPoint = "GetRequestALLCookie", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetRequestALLCookie(System.Int32 MessageId);

        [DllImport(DLLName, EntryPoint = "DelResponseHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_DelResponseHeader(System.Int32 MessageId, IntPtr name);

        [DllImport(DLLName, EntryPoint = "DelRequestHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_DelRequestHeader(System.Int32 MessageId, IntPtr name);

        [DllImport(DLLName, EntryPoint = "SetRequestHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SetRequestHeader(System.Int32 MessageId, IntPtr name, IntPtr val);

        [DllImport(DLLName, EntryPoint = "SetResponseHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SetResponseHeader(System.Int32 MessageId, IntPtr name, IntPtr val);

        [DllImport(DLLName, EntryPoint = "GetRequestHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetRequestHeader(System.Int32 MessageId, IntPtr name);

        [DllImport(DLLName, EntryPoint = "GetResponseHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetResponseHeader(System.Int32 MessageId, IntPtr name);

        [DllImport(DLLName, EntryPoint = "SetResponseAllHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SetResponseAllHeader(System.Int32 MessageId, IntPtr value);

        [DllImport(DLLName, EntryPoint = "GetResponseAllHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetResponseAllHeader(System.Int32 MessageId);

        [DllImport(DLLName, EntryPoint = "GetRequestAllHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetRequestAllHeader(System.Int32 MessageId);

        [DllImport(DLLName, EntryPoint = "SetRequestProxy", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetRequestProxy(System.Int32 MessageId, IntPtr ProxyUrl);

        [DllImport(DLLName, EntryPoint = "GetResponseStatusCode", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_GetResponseStatusCode(System.Int32 MessageId);

        [DllImport(DLLName, EntryPoint = "GetRequestClientIp", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetRequestClientIp(System.Int32 MessageId);

        [DllImport(DLLName, EntryPoint = "GetResponseStatus", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetResponseStatus(System.Int32 MessageId);

        [DllImport(DLLName, EntryPoint = "SetResponseStatus", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SetResponseStatus(System.Int32 MessageId, System.Int32 code);

        [DllImport(DLLName, EntryPoint = "SetRequestUrl", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetRequestUrl(System.Int32 MessageId, IntPtr URI);

        [DllImport(DLLName, EntryPoint = "GetRequestBodyLen", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_GetRequestBodyLen(System.Int32 MessageId);

        [DllImport(DLLName, EntryPoint = "GetResponseBodyLen", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_GetResponseBodyLen(System.Int32 MessageId);

        [DllImport(DLLName, EntryPoint = "SetResponseData", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetResponseData(System.Int32 MessageId, IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "SetRequestData", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_SetRequestData(System.Int32 MessageId, IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "GetRequestBody", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetRequestBody(System.Int32 MessageId);

        [DllImport(DLLName, EntryPoint = "GetResponseBody", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetResponseBody(System.Int32 MessageId);

        [DllImport(DLLName, EntryPoint = "GetWebsocketBodyLen", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_GetWebsocketBodyLen(System.Int32 MessageId);

        [DllImport(DLLName, EntryPoint = "GetWebsocketBody", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetWebsocketBody(System.Int32 MessageId);

        [DllImport(DLLName, EntryPoint = "SetWebsocketBody", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetWebsocketBody(System.Int32 MessageId, IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "SendWebsocketBody", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SendWebsocketBody(System.Int32 TheologyID, System.Int32 MessageType, IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "SendWebsocketClientBody", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SendWebsocketClientBody(System.Int32 TheologyID, System.Int32 MessageType, IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "CloseWebsocket", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_CloseWebsocket(System.Int32 theology);

        [DllImport(DLLName, EntryPoint = "SetTcpBody", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetTcpBody(System.Int32 MessageId, System.Int32 MsgType, IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "SetTcpAgent", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetTcpAgent(System.Int32 MessageId, IntPtr ProxyUrl);

        [DllImport(DLLName, EntryPoint = "TcpCloseClient", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_TcpCloseClient(System.Int32 theology);

        [DllImport(DLLName, EntryPoint = "SetTcpConnectionIP", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetTcpConnectionIP(System.Int32 MessageId, IntPtr address);

        [DllImport(DLLName, EntryPoint = "TcpSendMsg", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_TcpSendMsg(System.Int32 theology, IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "TcpSendMsgClient", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_TcpSendMsgClient(System.Int32 theology, IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "HexDump", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_HexDump(IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "BytesToInt", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_BytesToInt(IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "GzipUnCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GzipUnCompress(IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "BrUnCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_BrUnCompress(IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "BrCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_BrCompress(IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "BrotliCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_BrotliCompress(IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "GzipCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GzipCompress(IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "ZlibCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_ZlibCompress(IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "ZlibUnCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_ZlibUnCompress(IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "DeflateUnCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_DeflateUnCompress(IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "DeflateCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_DeflateCompress(IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "WebpToJpegBytes", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_WebpToJpegBytes(IntPtr data, System.Int32 dataLen, System.Int32 SaveQuality);

        [DllImport(DLLName, EntryPoint = "WebpToPngBytes", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_WebpToPngBytes(IntPtr data, System.Int32 dataLen);

        [DllImport(DLLName, EntryPoint = "WebpToJpeg", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_WebpToJpeg(IntPtr webpPath, IntPtr savePath, System.Int32 SaveQuality);

        [DllImport(DLLName, EntryPoint = "WebpToPng", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_WebpToPng(IntPtr webpPath, IntPtr savePath);

        [DllImport(DLLName, EntryPoint = "GoCall", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_GoCall(System.Int32 address, System.Int32 a1, System.Int32 a2, System.Int32 a3, System.Int32 a4, System.Int32 a5, System.Int32 a6, System.Int32 a7, System.Int32 a8, System.Int32 a9);

        [DllImport(DLLName, EntryPoint = "ScriptCall", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_ScriptCall(System.Int32 i, IntPtr Request);

        [DllImport(DLLName, EntryPoint = "SetScript", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_SetScript(IntPtr Request);

        [DllImport(DLLName, EntryPoint = "SetScriptLogCallAddress", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SetScriptLogCallAddress(IntPtr i);

        [DllImport(DLLName, EntryPoint = "StartProcess", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_StartProcess(System.Int32 SunnyContext);

        [DllImport(DLLName, EntryPoint = "ProcessAddName", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_ProcessAddName(System.Int32 SunnyContext, IntPtr Name);

        [DllImport(DLLName, EntryPoint = "ProcessDelName", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_ProcessDelName(System.Int32 SunnyContext, IntPtr Name);

        [DllImport(DLLName, EntryPoint = "ProcessAddPid", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_ProcessAddPid(System.Int32 SunnyContext, System.Int32 pid);

        [DllImport(DLLName, EntryPoint = "ProcessDelPid", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_ProcessDelPid(System.Int32 SunnyContext, System.Int32 pid);

        [DllImport(DLLName, EntryPoint = "ProcessCancelAll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_ProcessCancelAll(System.Int32 SunnyContext);

        [DllImport(DLLName, EntryPoint = "ProcessALLName", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_ProcessALLName(System.Int32 SunnyContext, bool open);

        [DllImport(DLLName, EntryPoint = "GetCommonName", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetCommonName(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "ExportP12", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_ExportP12(System.Int32 Context, IntPtr path, IntPtr pass);

        [DllImport(DLLName, EntryPoint = "ExportPub", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_ExportPub(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "ExportKEY", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_ExportKEY(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "ExportCA", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_ExportCA(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "CreateCA", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_CreateCA(System.Int32 Context, IntPtr Country, IntPtr Organization, IntPtr OrganizationalUnit, IntPtr Province, IntPtr CommonName, IntPtr Locality, System.Int32 bits, System.Int32 NotAfter);

        [DllImport(DLLName, EntryPoint = "AddClientAuth", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_AddClientAuth(System.Int32 Context, System.Int32 val);

        [DllImport(DLLName, EntryPoint = "AddCertPoolText", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_AddCertPoolText(System.Int32 Context, IntPtr cer);

        [DllImport(DLLName, EntryPoint = "AddCertPoolPath", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_AddCertPoolPath(System.Int32 Context, IntPtr cer);

        [DllImport(DLLName, EntryPoint = "GetServerName", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetServerName(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "SetServerName", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetServerName(System.Int32 Context, IntPtr name);

        [DllImport(DLLName, EntryPoint = "SetInsecureSkipVerify", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetInsecureSkipVerify(System.Int32 Context, bool b);

        [DllImport(DLLName, EntryPoint = "LoadX509Certificate", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_LoadX509Certificate(System.Int32 Context, IntPtr Host, IntPtr CA, IntPtr KEY);

        [DllImport(DLLName, EntryPoint = "LoadX509KeyPair", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_LoadX509KeyPair(System.Int32 Context, IntPtr CaPath, IntPtr KeyPath);

        [DllImport(DLLName, EntryPoint = "LoadP12Certificate", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_LoadP12Certificate(System.Int32 Context, IntPtr Name, IntPtr Password);

        [DllImport(DLLName, EntryPoint = "RemoveCertificate", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RemoveCertificate(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "CreateCertificate", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_CreateCertificate();

        [DllImport(DLLName, EntryPoint = "KeysWriteStr", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_KeysWriteStr(System.Int32 KeysHandle, IntPtr name, IntPtr val, System.Int32 len);

        [DllImport(DLLName, EntryPoint = "KeysGetJson", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_KeysGetJson(System.Int32 KeysHandle);

        [DllImport(DLLName, EntryPoint = "KeysGetCount", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_KeysGetCount(System.Int32 KeysHandle);

        [DllImport(DLLName, EntryPoint = "KeysEmpty", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_KeysEmpty(System.Int32 KeysHandle);

        [DllImport(DLLName, EntryPoint = "KeysReadInt", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_KeysReadInt(System.Int32 KeysHandle, IntPtr name);

        [DllImport(DLLName, EntryPoint = "KeysWriteInt", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_KeysWriteInt(System.Int32 KeysHandle, IntPtr name, System.Int32 val);

        [DllImport(DLLName, EntryPoint = "KeysReadLong", CallingConvention = CallingConvention.Cdecl)]
        public extern static Int64 Sunny_KeysReadLong(System.Int32 KeysHandle, IntPtr name);

        [DllImport(DLLName, EntryPoint = "KeysWriteLong", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_KeysWriteLong(System.Int32 KeysHandle, IntPtr name, Int64 val);

        [DllImport(DLLName, EntryPoint = "KeysReadFloat", CallingConvention = CallingConvention.Cdecl)]
        public extern static Double Sunny_KeysReadFloat(System.Int32 KeysHandle, IntPtr name);

        [DllImport(DLLName, EntryPoint = "KeysWriteFloat", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_KeysWriteFloat(System.Int32 KeysHandle, IntPtr name, Double val);

        [DllImport(DLLName, EntryPoint = "KeysWrite", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_KeysWrite(System.Int32 KeysHandle, IntPtr name, IntPtr val, System.Int32 length);

        [DllImport(DLLName, EntryPoint = "KeysRead", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_KeysRead(System.Int32 KeysHandle, IntPtr name);

        [DllImport(DLLName, EntryPoint = "KeysDelete", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_KeysDelete(System.Int32 KeysHandle, IntPtr name);

        [DllImport(DLLName, EntryPoint = "RemoveKeys", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RemoveKeys(System.Int32 KeysHandle);

        [DllImport(DLLName, EntryPoint = "CreateKeys", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_CreateKeys();

        [DllImport(DLLName, EntryPoint = "HTTPSetRedirect", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_HTTPSetRedirect(System.Int32 Context, bool Redirect);

        [DllImport(DLLName, EntryPoint = "HTTPGetCode", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_HTTPGetCode(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "HTTPGetBody", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_HTTPGetBody(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "HTTPGetHeads", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_HTTPGetHeads(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "HTTPGetBodyLen", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_HTTPGetBodyLen(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "HTTPSendBin", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_HTTPSendBin(System.Int32 Context, IntPtr body, System.Int32 bodyLength);

        [DllImport(DLLName, EntryPoint = "HTTPSetTimeouts", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_HTTPSetTimeouts(System.Int32 Context, System.Int32 t1, System.Int32 t2, System.Int32 t3);

        [DllImport(DLLName, EntryPoint = "HTTPSetProxyIP", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_HTTPSetProxyIP(System.Int32 Context, IntPtr ProxyURL);

        [DllImport(DLLName, EntryPoint = "HTTPSetHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_HTTPSetHeader(System.Int32 Context, IntPtr name, IntPtr value);

        [DllImport(DLLName, EntryPoint = "HTTPSetCertManager", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_HTTPSetCertManager(System.Int32 Context, System.Int32 CertManagerContext);

        [DllImport(DLLName, EntryPoint = "HTTPOpen", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_HTTPOpen(System.Int32 Context, IntPtr Method, IntPtr URL);

        [DllImport(DLLName, EntryPoint = "SetRequestOutTime", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SetRequestOutTime(System.Int32 Context, System.Int32 times);

        [DllImport(DLLName, EntryPoint = "HTTPClientGetErr", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_HTTPClientGetErr(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "RemoveHTTPClient", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RemoveHTTPClient(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "CreateHTTPClient", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_CreateHTTPClient();

        [DllImport(DLLName, EntryPoint = "JsonToPB", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_JsonToPB(IntPtr bin, System.Int32 binLen);

        [DllImport(DLLName, EntryPoint = "PbToJson", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_PbToJson(IntPtr bin, System.Int32 binLen);

        [DllImport(DLLName, EntryPoint = "QueuePull", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_QueuePull(IntPtr name);

        [DllImport(DLLName, EntryPoint = "QueuePush", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_QueuePush(IntPtr name, IntPtr val, System.Int32 valLen);

        [DllImport(DLLName, EntryPoint = "QueueLength", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_QueueLength(IntPtr name);

        [DllImport(DLLName, EntryPoint = "QueueRelease", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_QueueRelease(IntPtr name);

        [DllImport(DLLName, EntryPoint = "QueueIsEmpty", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_QueueIsEmpty(IntPtr name);

        [DllImport(DLLName, EntryPoint = "CreateQueue", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_CreateQueue(IntPtr name);

        [DllImport(DLLName, EntryPoint = "SocketClientWrite", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_SocketClientWrite(System.Int32 Context, System.Int32 OutTimes, IntPtr val, System.Int32 valLen);

        [DllImport(DLLName, EntryPoint = "SocketClientClose", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SocketClientClose(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "SocketClientReceive", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_SocketClientReceive(System.Int32 Context, System.Int32 OutTimes);

        [DllImport(DLLName, EntryPoint = "SocketClientDial", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SocketClientDial(System.Int32 Context, IntPtr addr, IntPtr call, bool isTls, bool synchronous, IntPtr ProxyUrl, System.Int32 CertificateConText);

        [DllImport(DLLName, EntryPoint = "SocketClientSetBufferSize", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SocketClientSetBufferSize(System.Int32 Context, System.Int32 BufferSize);

        [DllImport(DLLName, EntryPoint = "SocketClientGetErr", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_SocketClientGetErr(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "RemoveSocketClient", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RemoveSocketClient(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "CreateSocketClient", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_CreateSocketClient();

        [DllImport(DLLName, EntryPoint = "WebsocketClientReceive", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_WebsocketClientReceive(System.Int32 Context, System.Int32 OutTimes);

        [DllImport(DLLName, EntryPoint = "WebsocketReadWrite", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_WebsocketReadWrite(System.Int32 Context, IntPtr val, System.Int32 valLen, System.Int32 messageType);

        [DllImport(DLLName, EntryPoint = "WebsocketClose", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_WebsocketClose(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "WebsocketDial", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_WebsocketDial(System.Int32 Context, IntPtr URL, IntPtr Heads, IntPtr call, bool synchronous, IntPtr ProxyUrl, System.Int32 CertificateConText, System.Int32 outTime);

        [DllImport(DLLName, EntryPoint = "WebsocketGetErr", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_WebsocketGetErr(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "RemoveWebsocket", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RemoveWebsocket(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "CreateWebsocket", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_CreateWebsocket();

        [DllImport(DLLName, EntryPoint = "AddHttpCertificate", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_AddHttpCertificate(IntPtr host, System.Int32 CertManagerId, System.Int32 Rules);

        [DllImport(DLLName, EntryPoint = "DelHttpCertificate", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_DelHttpCertificate(IntPtr host);

        [DllImport(DLLName, EntryPoint = "RedisSubscribe", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RedisSubscribe(System.Int32 Context, IntPtr scribe, System.Int32 call, bool nc);

        [DllImport(DLLName, EntryPoint = "RedisDelete", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_RedisDelete(System.Int32 Context, IntPtr key);

        [DllImport(DLLName, EntryPoint = "RedisFlushDB", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RedisFlushDB(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "RedisFlushAll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RedisFlushAll(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "RedisClose", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RedisClose(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "RedisGetInt", CallingConvention = CallingConvention.Cdecl)]
        public extern static Int64 Sunny_RedisGetInt(System.Int32 Context, IntPtr key);

        [DllImport(DLLName, EntryPoint = "RedisGetKeys", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_RedisGetKeys(System.Int32 Context, IntPtr key);

        [DllImport(DLLName, EntryPoint = "RedisDo", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_RedisDo(System.Int32 Context, IntPtr args, IntPtr error);

        [DllImport(DLLName, EntryPoint = "RedisGetStr", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_RedisGetStr(System.Int32 Context, IntPtr key);

        [DllImport(DLLName, EntryPoint = "RedisGetBytes", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_RedisGetBytes(System.Int32 Context, IntPtr key);

        [DllImport(DLLName, EntryPoint = "RedisExists", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_RedisExists(System.Int32 Context, IntPtr key);

        [DllImport(DLLName, EntryPoint = "RedisSetNx", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_RedisSetNx(System.Int32 Context, IntPtr key, IntPtr val, System.Int32 expr);

        [DllImport(DLLName, EntryPoint = "RedisSet", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_RedisSet(System.Int32 Context, IntPtr key, IntPtr val, System.Int32 expr);

        [DllImport(DLLName, EntryPoint = "RedisSetBytes", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_RedisSetBytes(System.Int32 Context, IntPtr key, IntPtr val, System.Int32 valLen, System.Int32 expr);

        [DllImport(DLLName, EntryPoint = "RedisDial", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_RedisDial(System.Int32 Context, IntPtr host, IntPtr pass, System.Int32 db, System.Int32 PoolSize, System.Int32 MinIdleCons, System.Int32 DialTimeout, System.Int32 ReadTimeout, System.Int32 WriteTimeout, System.Int32 PoolTimeout, System.Int32 IdleCheckFrequency, System.Int32 IdleTimeout, IntPtr error);

        [DllImport(DLLName, EntryPoint = "RemoveRedis", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RemoveRedis(System.Int32 Context);

        [DllImport(DLLName, EntryPoint = "CreateRedis", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int32 Sunny_CreateRedis(); 

        [DllImport(DLLName, EntryPoint = "GetUdpData", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetUdpData(System.Int32 MessageId);

        [DllImport(DLLName, EntryPoint = "SetUdpData", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetUdpData(System.Int32 MessageId, IntPtr val, System.Int32 valLen);

        [DllImport(DLLName, EntryPoint = "UdpSendToClient", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_UdpSendToClient(System.Int32 MessageId, IntPtr val, System.Int32 valLen);

        [DllImport(DLLName, EntryPoint = "UdpSendToServer", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_UdpSendToServer(System.Int32 MessageId, IntPtr val, System.Int32 valLen);

        [DllImport(DLLName, EntryPoint = "Free", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_Free(IntPtr Ptr);

        [DllImport(DLLName, EntryPoint = "GetSunnyVersion", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetSunnyVersion();

        [DllImport(DLLName, EntryPoint = "SunnyNetGetSocket5User", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_SunnyNetGetSocket5User(System.Int32 WeiYiId);
    }
}
