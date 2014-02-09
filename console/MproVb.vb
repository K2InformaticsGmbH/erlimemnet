Imports System.Net.Sockets
Imports K2Informatics.Erlimemnet
Imports K2Informatics.Erlnet

Public Class MproVb
    Inherits Imem

    Public Sub New(ByVal _stream As ErlStream)
        MyBase.New(_stream)
    End Sub

    Public Overloads Shared Function Connect(ByVal host As String, ByVal port As Integer, ByVal secure As Boolean) As MproVb
        Return Imem.Connect(host, port, secure, GetType(MproVb))
    End Function

    Public Function listDestinationChannels(ByVal AppId) As ArrayList
        Return CallMproMFASync("listDestinationChannels", AppId)
    End Function
    Public Function deleteSourcePeer(ByRef AppId As String, ByRef Key As String) As ArrayList
        Return CallMproMFASync("deleteSourcePeer", AppId, Key)
    End Function
    Public Function listSourcePeerKeys(ByRef AppId As String) As ArrayList
        Return CallMproMFASync("listSourcePeerKeys", AppId)
    End Function
    Public Function listSourcePeers(ByRef AppId As String) As ArrayList
        Return CallMproMFASync("listSourcePeers", AppId)
    End Function
    Public Function putSourcePeer(ByRef AppId As String, ByRef Key As String, ByRef ChStr As String, ByRef SpName As String, ByRef OptStr As String) As ArrayList
        Return CallMproMFASync("putSourcePeer", AppId, Key, ChStr, SpName, OptStr)
    End Function
    Public Function putWhitelist(ByRef AppId As String, ByRef Key As String, ByRef IpAddressStr As String, ByRef OptStr As String) As ArrayList
        Return CallMproMFASync("putWhitelist", AppId, Key, IpAddressStr, OptStr)
    End Function
    Public Function deleteWhitelist(ByRef AppId As String, ByRef Key As String, ByRef IpAddressStr As String) As ArrayList
        Return CallMproMFASync("deleteWhitelist", AppId, Key, IpAddressStr)
    End Function
    Public Function getSourcePeer(ByRef AppId As String, ByRef Key As String) As ArrayList
        Return CallMproMFASync("getSourcePeer", AppId, Key)
    End Function
    Public Function getWhitelist(ByRef AppId As String, ByRef Key As String) As ArrayList
        Return CallMproMFASync("getWhitelist", AppId, Key)
    End Function
    Private Function CallMproMFASync(ByVal fun As String, ByVal ParamArray argsRest() As Object) As ArrayList
        Return TranslateResult(UnwrapResult(CallImemMFASync("mpro_dal_prov", fun, argsRest)))
    End Function

End Class