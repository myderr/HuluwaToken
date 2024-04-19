using System;
using System.Runtime.InteropServices;
namespace SunnyTest
{
    class Sunny64
    {
        const string DLLName = "Sunny64.dll";

        [DllImport(DLLName, EntryPoint = "CreateSunnyNet", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_CreateSunnyNet();

        [DllImport(DLLName, EntryPoint = "ReleaseSunnyNet", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_ReleaseSunnyNet(System.Int64 SunnyContext);

        [DllImport(DLLName, EntryPoint = "SunnyNetStart", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SunnyNetStart(System.Int64 SunnyContext);

        [DllImport(DLLName, EntryPoint = "SunnyNetSetPort", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SunnyNetSetPort(System.Int64 SunnyContext, System.Int64 Port);

        [DllImport(DLLName, EntryPoint = "SunnyNetClose", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SunnyNetClose(System.Int64 SunnyContext);

        [DllImport(DLLName, EntryPoint = "SunnyNetSetCert", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SunnyNetSetCert(System.Int64 SunnyContext, System.Int64 CertificateManagerId);

        [DllImport(DLLName, EntryPoint = "SunnyNetInstallCert", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_SunnyNetInstallCert(System.Int64 SunnyContext);

        [DllImport(DLLName, EntryPoint = "SunnyNetSetCallback", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SunnyNetSetCallback(System.Int64 SunnyContext, IntPtr httpCallback, IntPtr tcpCallback, IntPtr wsCallback, IntPtr udpCallback);

        [DllImport(DLLName, EntryPoint = "SunnyNetSocket5AddUser", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SunnyNetSocket5AddUser(System.Int64 SunnyContext, IntPtr User, IntPtr Pass);

        [DllImport(DLLName, EntryPoint = "SunnyNetVerifyUser", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SunnyNetVerifyUser(System.Int64 SunnyContext, bool open);

        [DllImport(DLLName, EntryPoint = "SunnyNetSocket5DelUser", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SunnyNetSocket5DelUser(System.Int64 SunnyContext, IntPtr User);

        [DllImport(DLLName, EntryPoint = "SunnyNetMustTcp", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SunnyNetMustTcp(System.Int64 SunnyContext, bool open);

        [DllImport(DLLName, EntryPoint = "HTTPSetCertManager", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_HTTPSetCertManager(System.Int64 Context, System.Int64 CertManagerContext);

        [DllImport(DLLName, EntryPoint = "CompileProxyRegexp", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_CompileProxyRegexp(System.Int64 SunnyContext, IntPtr Regexp);

        [DllImport(DLLName, EntryPoint = "SetMustTcpRegexp", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetMustTcpRegexp(System.Int64 SunnyContext, IntPtr Regexp);

        [DllImport(DLLName, EntryPoint = "SunnyNetError", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_SunnyNetError(System.Int64 SunnyContext);

        [DllImport(DLLName, EntryPoint = "SetRequestOutTime", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SetRequestOutTime(System.Int64 Context, System.Int64 times);

        [DllImport(DLLName, EntryPoint = "SetGlobalProxy", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetGlobalProxy(System.Int64 SunnyContext, IntPtr ProxyAddress);

        [DllImport(DLLName, EntryPoint = "ExportCert", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_ExportCert(System.Int64 SunnyContext);

        [DllImport(DLLName, EntryPoint = "SetIeProxy", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetIeProxy(System.Int64 SunnyContext, bool Off);

        [DllImport(DLLName, EntryPoint = "SetRequestCookie", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SetRequestCookie(System.Int64 MessageId, IntPtr name, IntPtr val);

        [DllImport(DLLName, EntryPoint = "SetRequestAllCookie", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SetRequestAllCookie(System.Int64 MessageId, IntPtr val);

        [DllImport(DLLName, EntryPoint = "GetRequestCookie", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetRequestCookie(System.Int64 MessageId, IntPtr name);

        [DllImport(DLLName, EntryPoint = "GetRequestALLCookie", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetRequestALLCookie(System.Int64 MessageId);

        [DllImport(DLLName, EntryPoint = "DelResponseHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_DelResponseHeader(System.Int64 MessageId, IntPtr name);

        [DllImport(DLLName, EntryPoint = "DelRequestHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_DelRequestHeader(System.Int64 MessageId, IntPtr name);

        [DllImport(DLLName, EntryPoint = "SetRequestHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SetRequestHeader(System.Int64 MessageId, IntPtr name, IntPtr val);

        [DllImport(DLLName, EntryPoint = "SetResponseHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SetResponseHeader(System.Int64 MessageId, IntPtr name, IntPtr val);

        [DllImport(DLLName, EntryPoint = "GetRequestHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetRequestHeader(System.Int64 MessageId, IntPtr name);

        [DllImport(DLLName, EntryPoint = "GetResponseHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetResponseHeader(System.Int64 MessageId, IntPtr name);

        [DllImport(DLLName, EntryPoint = "SetResponseAllHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SetResponseAllHeader(System.Int64 MessageId, IntPtr value);

        [DllImport(DLLName, EntryPoint = "GetResponseAllHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetResponseAllHeader(System.Int64 MessageId);

        [DllImport(DLLName, EntryPoint = "GetRequestAllHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetRequestAllHeader(System.Int64 MessageId);

        [DllImport(DLLName, EntryPoint = "SetRequestProxy", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetRequestProxy(System.Int64 MessageId, IntPtr ProxyUrl);

        [DllImport(DLLName, EntryPoint = "GetResponseStatusCode", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_GetResponseStatusCode(System.Int64 MessageId);

        [DllImport(DLLName, EntryPoint = "GetRequestClientIp", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetRequestClientIp(System.Int64 MessageId);

        [DllImport(DLLName, EntryPoint = "GetResponseStatus", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetResponseStatus(System.Int64 MessageId);

        [DllImport(DLLName, EntryPoint = "SetResponseStatus", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SetResponseStatus(System.Int64 MessageId, System.Int64 code);

        [DllImport(DLLName, EntryPoint = "SetRequestUrl", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetRequestUrl(System.Int64 MessageId, IntPtr URI);

        [DllImport(DLLName, EntryPoint = "GetRequestBodyLen", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_GetRequestBodyLen(System.Int64 MessageId);

        [DllImport(DLLName, EntryPoint = "GetResponseBodyLen", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_GetResponseBodyLen(System.Int64 MessageId);

        [DllImport(DLLName, EntryPoint = "SetResponseData", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetResponseData(System.Int64 MessageId, IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "SetRequestData", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_SetRequestData(System.Int64 MessageId, IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "GetRequestBody", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetRequestBody(System.Int64 MessageId);

        [DllImport(DLLName, EntryPoint = "GetResponseBody", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetResponseBody(System.Int64 MessageId);

        [DllImport(DLLName, EntryPoint = "GetWebsocketBodyLen", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_GetWebsocketBodyLen(System.Int64 MessageId);

        [DllImport(DLLName, EntryPoint = "GetWebsocketBody", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetWebsocketBody(System.Int64 MessageId);

        [DllImport(DLLName, EntryPoint = "SetWebsocketBody", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetWebsocketBody(System.Int64 MessageId, IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "SendWebsocketBody", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SendWebsocketBody(System.Int64 TheologyID, System.Int64 MessageType, IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "SendWebsocketClientBody", CallingConvention = CallingConvention.Cdecl)] 
        public extern static bool Sunny_SendWebsocketClientBody(System.Int64 TheologyID, System.Int64 MessageType, IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "CloseWebsocket", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_CloseWebsocket(System.Int64 theology);

        [DllImport(DLLName, EntryPoint = "SetTcpBody", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetTcpBody(System.Int64 MessageId, System.Int64 MsgType, IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "SetTcpAgent", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetTcpAgent(System.Int64 MessageId, IntPtr ProxyUrl);

        [DllImport(DLLName, EntryPoint = "TcpCloseClient", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_TcpCloseClient(System.Int64 theology);

        [DllImport(DLLName, EntryPoint = "SetTcpConnectionIP", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetTcpConnectionIP(System.Int64 MessageId, IntPtr address);

        [DllImport(DLLName, EntryPoint = "TcpSendMsg", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_TcpSendMsg(System.Int64 theology, IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "TcpSendMsgClient", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_TcpSendMsgClient(System.Int64 theology, IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "HexDump", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_HexDump(IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "BytesToInt", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_BytesToInt(IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "GzipUnCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GzipUnCompress(IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "BrUnCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_BrUnCompress(IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "BrCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_BrCompress(IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "BrotliCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_BrotliCompress(IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "GzipCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GzipCompress(IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "ZlibCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_ZlibCompress(IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "ZlibUnCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_ZlibUnCompress(IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "DeflateUnCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_DeflateUnCompress(IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "DeflateCompress", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_DeflateCompress(IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "WebpToJpegBytes", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_WebpToJpegBytes(IntPtr data, System.Int64 dataLen, System.Int64 SaveQuality);

        [DllImport(DLLName, EntryPoint = "WebpToPngBytes", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_WebpToPngBytes(IntPtr data, System.Int64 dataLen);

        [DllImport(DLLName, EntryPoint = "WebpToJpeg", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_WebpToJpeg(IntPtr webpPath, IntPtr savePath, System.Int64 SaveQuality);

        [DllImport(DLLName, EntryPoint = "WebpToPng", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_WebpToPng(IntPtr webpPath, IntPtr savePath);

        [DllImport(DLLName, EntryPoint = "GoCall", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_GoCall(System.Int64 address, System.Int64 a1, System.Int64 a2, System.Int64 a3, System.Int64 a4, System.Int64 a5, System.Int64 a6, System.Int64 a7, System.Int64 a8, System.Int64 a9);

        [DllImport(DLLName, EntryPoint = "ScriptCall", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_ScriptCall(System.Int64 i, IntPtr Request);

        [DllImport(DLLName, EntryPoint = "SetScript", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_SetScript(IntPtr Request);

        [DllImport(DLLName, EntryPoint = "SetScriptLogCallAddress", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SetScriptLogCallAddress(IntPtr i);

        [DllImport(DLLName, EntryPoint = "StartProcess", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_StartProcess(System.Int64 SunnyContext);

        [DllImport(DLLName, EntryPoint = "ProcessAddName", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_ProcessAddName(System.Int64 SunnyContext, IntPtr Name);

        [DllImport(DLLName, EntryPoint = "ProcessDelName", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_ProcessDelName(System.Int64 SunnyContext, IntPtr Name);

        [DllImport(DLLName, EntryPoint = "ProcessAddPid", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_ProcessAddPid(System.Int64 SunnyContext, System.Int64 pid);

        [DllImport(DLLName, EntryPoint = "ProcessDelPid", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_ProcessDelPid(System.Int64 SunnyContext, System.Int64 pid);

        [DllImport(DLLName, EntryPoint = "ProcessCancelAll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_ProcessCancelAll(System.Int64 SunnyContext);

        [DllImport(DLLName, EntryPoint = "ProcessALLName", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_ProcessALLName(System.Int64 SunnyContext, bool open);

        [DllImport(DLLName, EntryPoint = "GetCommonName", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetCommonName(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "ExportP12", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_ExportP12(System.Int64 Context, IntPtr path, IntPtr pass);

        [DllImport(DLLName, EntryPoint = "ExportPub", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_ExportPub(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "ExportKEY", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_ExportKEY(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "ExportCA", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_ExportCA(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "CreateCA", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_CreateCA(System.Int64 Context, IntPtr Country, IntPtr Organization, IntPtr OrganizationalUnit, IntPtr Province, IntPtr CommonName, IntPtr Locality, System.Int64 bits, System.Int64 NotAfter);

        [DllImport(DLLName, EntryPoint = "AddClientAuth", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_AddClientAuth(System.Int64 Context, System.Int64 val);

        [DllImport(DLLName, EntryPoint = "AddCertPoolText", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_AddCertPoolText(System.Int64 Context, IntPtr cer);

        [DllImport(DLLName, EntryPoint = "AddCertPoolPath", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_AddCertPoolPath(System.Int64 Context, IntPtr cer);

        [DllImport(DLLName, EntryPoint = "GetServerName", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetServerName(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "SetServerName", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetServerName(System.Int64 Context, IntPtr name);

        [DllImport(DLLName, EntryPoint = "SetInsecureSkipVerify", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetInsecureSkipVerify(System.Int64 Context, bool b);

        [DllImport(DLLName, EntryPoint = "LoadX509Certificate", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_LoadX509Certificate(System.Int64 Context, IntPtr Host, IntPtr CA, IntPtr KEY);

        [DllImport(DLLName, EntryPoint = "LoadX509KeyPair", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_LoadX509KeyPair(System.Int64 Context, IntPtr CaPath, IntPtr KeyPath);

        [DllImport(DLLName, EntryPoint = "LoadP12Certificate", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_LoadP12Certificate(System.Int64 Context, IntPtr Name, IntPtr Password);

        [DllImport(DLLName, EntryPoint = "RemoveCertificate", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RemoveCertificate(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "CreateCertificate", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_CreateCertificate();

        [DllImport(DLLName, EntryPoint = "KeysWriteStr", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_KeysWriteStr(System.Int64 KeysHandle, IntPtr name, IntPtr val, System.Int64 len);

        [DllImport(DLLName, EntryPoint = "KeysGetJson", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_KeysGetJson(System.Int64 KeysHandle);

        [DllImport(DLLName, EntryPoint = "KeysGetCount", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_KeysGetCount(System.Int64 KeysHandle);

        [DllImport(DLLName, EntryPoint = "KeysEmpty", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_KeysEmpty(System.Int64 KeysHandle);

        [DllImport(DLLName, EntryPoint = "KeysReadInt", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_KeysReadInt(System.Int64 KeysHandle, IntPtr name);

        [DllImport(DLLName, EntryPoint = "KeysWriteInt", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_KeysWriteInt(System.Int64 KeysHandle, IntPtr name, System.Int64 val);

        [DllImport(DLLName, EntryPoint = "KeysReadLong", CallingConvention = CallingConvention.Cdecl)]
        public extern static Int64 Sunny_KeysReadLong(System.Int64 KeysHandle, IntPtr name);

        [DllImport(DLLName, EntryPoint = "KeysWriteLong", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_KeysWriteLong(System.Int64 KeysHandle, IntPtr name, Int64 val);

        [DllImport(DLLName, EntryPoint = "KeysReadFloat", CallingConvention = CallingConvention.Cdecl)]
        public extern static Double Sunny_KeysReadFloat(System.Int64 KeysHandle, IntPtr name);

        [DllImport(DLLName, EntryPoint = "KeysWriteFloat", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_KeysWriteFloat(System.Int64 KeysHandle, IntPtr name, Double val);

        [DllImport(DLLName, EntryPoint = "KeysWrite", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_KeysWrite(System.Int64 KeysHandle, IntPtr name, IntPtr val, System.Int64 length);

        [DllImport(DLLName, EntryPoint = "KeysRead", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_KeysRead(System.Int64 KeysHandle, IntPtr name);

        [DllImport(DLLName, EntryPoint = "KeysDelete", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_KeysDelete(System.Int64 KeysHandle, IntPtr name);

        [DllImport(DLLName, EntryPoint = "RemoveKeys", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RemoveKeys(System.Int64 KeysHandle);

        [DllImport(DLLName, EntryPoint = "CreateKeys", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_CreateKeys();

        [DllImport(DLLName, EntryPoint = "HTTPSetRedirect", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_HTTPSetRedirect(System.Int64 Context, bool Redirect);

        [DllImport(DLLName, EntryPoint = "HTTPGetCode", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_HTTPGetCode(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "HTTPGetBody", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_HTTPGetBody(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "HTTPGetHeads", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_HTTPGetHeads(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "HTTPGetBodyLen", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_HTTPGetBodyLen(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "HTTPSendBin", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_HTTPSendBin(System.Int64 Context, IntPtr body, System.Int64 bodyLength);

        [DllImport(DLLName, EntryPoint = "HTTPSetTimeouts", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_HTTPSetTimeouts(System.Int64 Context, System.Int64 t1, System.Int64 t2, System.Int64 t3);

        [DllImport(DLLName, EntryPoint = "HTTPSetProxyIP", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_HTTPSetProxyIP(System.Int64 Context, IntPtr ProxyURL);

        [DllImport(DLLName, EntryPoint = "HTTPSetHeader", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_HTTPSetHeader(System.Int64 Context, IntPtr name, IntPtr value);

        [DllImport(DLLName, EntryPoint = "HTTPOpen", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_HTTPOpen(System.Int64 Context, IntPtr Method, IntPtr URL);

        [DllImport(DLLName, EntryPoint = "HTTPClientGetErr", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_HTTPClientGetErr(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "RemoveHTTPClient", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RemoveHTTPClient(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "CreateHTTPClient", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_CreateHTTPClient();

        [DllImport(DLLName, EntryPoint = "JsonToPB", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_JsonToPB(IntPtr bin, System.Int64 binLen);

        [DllImport(DLLName, EntryPoint = "PbToJson", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_PbToJson(IntPtr bin, System.Int64 binLen);

        [DllImport(DLLName, EntryPoint = "QueuePull", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_QueuePull(IntPtr name);

        [DllImport(DLLName, EntryPoint = "QueuePush", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_QueuePush(IntPtr name, IntPtr val, System.Int64 valLen);

        [DllImport(DLLName, EntryPoint = "QueueLength", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_QueueLength(IntPtr name);

        [DllImport(DLLName, EntryPoint = "QueueRelease", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_QueueRelease(IntPtr name);

        [DllImport(DLLName, EntryPoint = "QueueIsEmpty", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_QueueIsEmpty(IntPtr name);

        [DllImport(DLLName, EntryPoint = "CreateQueue", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_CreateQueue(IntPtr name);

        [DllImport(DLLName, EntryPoint = "SocketClientWrite", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_SocketClientWrite(System.Int64 Context, System.Int64 OutTimes, IntPtr val, System.Int64 valLen);

        [DllImport(DLLName, EntryPoint = "SocketClientClose", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_SocketClientClose(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "SocketClientReceive", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_SocketClientReceive(System.Int64 Context, System.Int64 OutTimes);

        [DllImport(DLLName, EntryPoint = "SocketClientDial", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SocketClientDial(System.Int64 Context, IntPtr addr, IntPtr call, bool isTls, bool synchronous, IntPtr ProxyUrl, System.Int64 CertificateConText);

        [DllImport(DLLName, EntryPoint = "SocketClientSetBufferSize", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SocketClientSetBufferSize(System.Int64 Context, System.Int64 BufferSize);

        [DllImport(DLLName, EntryPoint = "SocketClientGetErr", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_SocketClientGetErr(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "RemoveSocketClient", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RemoveSocketClient(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "CreateSocketClient", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_CreateSocketClient();

        [DllImport(DLLName, EntryPoint = "WebsocketClientReceive", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_WebsocketClientReceive(System.Int64 Context, System.Int64 OutTimes);

        [DllImport(DLLName, EntryPoint = "WebsocketReadWrite", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_WebsocketReadWrite(System.Int64 Context, IntPtr val, System.Int64 valLen, System.Int64 messageType);

        [DllImport(DLLName, EntryPoint = "WebsocketClose", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_WebsocketClose(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "WebsocketDial", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_WebsocketDial(System.Int64 Context, IntPtr URL, IntPtr Heads, IntPtr call, bool synchronous, IntPtr ProxyUrl, System.Int64 CertificateConText, System.Int64 outTime);

        [DllImport(DLLName, EntryPoint = "WebsocketGetErr", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_WebsocketGetErr(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "RemoveWebsocket", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RemoveWebsocket(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "CreateWebsocket", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_CreateWebsocket();

        [DllImport(DLLName, EntryPoint = "AddHttpCertificate", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_AddHttpCertificate(IntPtr host, System.Int64 CertManagerId, System.Int64 Rules);

        [DllImport(DLLName, EntryPoint = "DelHttpCertificate", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_DelHttpCertificate(IntPtr host);

        [DllImport(DLLName, EntryPoint = "RedisSubscribe", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RedisSubscribe(System.Int64 Context, IntPtr scribe, System.Int64 call, bool nc);

        [DllImport(DLLName, EntryPoint = "RedisDelete", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_RedisDelete(System.Int64 Context, IntPtr key);

        [DllImport(DLLName, EntryPoint = "RedisFlushDB", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RedisFlushDB(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "RedisFlushAll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RedisFlushAll(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "RedisClose", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RedisClose(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "RedisGetInt", CallingConvention = CallingConvention.Cdecl)]
        public extern static Int64 Sunny_RedisGetInt(System.Int64 Context, IntPtr key);

        [DllImport(DLLName, EntryPoint = "RedisGetKeys", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_RedisGetKeys(System.Int64 Context, IntPtr key);

        [DllImport(DLLName, EntryPoint = "RedisDo", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_RedisDo(System.Int64 Context, IntPtr args, IntPtr error);

        [DllImport(DLLName, EntryPoint = "RedisGetStr", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_RedisGetStr(System.Int64 Context, IntPtr key);

        [DllImport(DLLName, EntryPoint = "RedisGetBytes", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_RedisGetBytes(System.Int64 Context, IntPtr key);

        [DllImport(DLLName, EntryPoint = "RedisExists", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_RedisExists(System.Int64 Context, IntPtr key);

        [DllImport(DLLName, EntryPoint = "RedisSetNx", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_RedisSetNx(System.Int64 Context, IntPtr key, IntPtr val, System.Int64 expr);

        [DllImport(DLLName, EntryPoint = "RedisSet", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_RedisSet(System.Int64 Context, IntPtr key, IntPtr val, System.Int64 expr);

        [DllImport(DLLName, EntryPoint = "RedisSetBytes", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_RedisSetBytes(System.Int64 Context, IntPtr key, IntPtr val, System.Int64 valLen, System.Int64 expr);

        [DllImport(DLLName, EntryPoint = "RedisDial", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_RedisDial(System.Int64 Context, IntPtr host, IntPtr pass, System.Int64 db, System.Int64 PoolSize, System.Int64 MinIdleCons, System.Int64 DialTimeout, System.Int64 ReadTimeout, System.Int64 WriteTimeout, System.Int64 PoolTimeout, System.Int64 IdleCheckFrequency, System.Int64 IdleTimeout, IntPtr error);

        [DllImport(DLLName, EntryPoint = "RemoveRedis", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Sunny_RemoveRedis(System.Int64 Context);

        [DllImport(DLLName, EntryPoint = "CreateRedis", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Int64 Sunny_CreateRedis();

        [DllImport(DLLName, EntryPoint = "GetUdpData", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetUdpData(System.Int64 MessageId);

        [DllImport(DLLName, EntryPoint = "SetUdpData", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_SetUdpData(System.Int64 MessageId, IntPtr val, System.Int64 valLen);

        [DllImport(DLLName, EntryPoint = "UdpSendToClient", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_UdpSendToClient(System.Int64 MessageId, IntPtr val, System.Int64 valLen);

        [DllImport(DLLName, EntryPoint = "UdpSendToServer", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_UdpSendToServer(System.Int64 MessageId, IntPtr val, System.Int64 valLen);

        [DllImport(DLLName, EntryPoint = "Free", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool Sunny_Free(IntPtr Ptr); 

        [DllImport(DLLName, EntryPoint = "GetSunnyVersion", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_GetSunnyVersion();

        [DllImport(DLLName, EntryPoint = "SunnyNetGetSocket5User", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Sunny_SunnyNetGetSocket5User(System.Int64 WeiYiId);
    }
}
