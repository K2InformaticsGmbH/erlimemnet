Imports System.Net.Sockets
Imports K2Informatics.Erlnet

Public Class Mpro
    Inherits Imem

    Protected Sub New(ByRef _stream As NetworkStream)
        MyBase.New(_stream)
    End Sub

    Public Overloads Shared Function Connect(ByVal host As String, ByVal port As Integer) As Mpro
        Dim client As TcpClient = New TcpClient(host, port)
        Dim s As NetworkStream = client.GetStream()
        Return New Mpro(s)
    End Function

    Public Function listDestinationChannels(ByVal AppId) As ArrayList
        Return CallMproMFASync("listDestinationChannels", AppId)
    End Function
    Public Function putSourcePeerName(ByRef AppId As String, ByRef Key As String, ByRef SpName As String) As ArrayList
        Return CallMproMFASync("putSourcePeerName", AppId, Key, SpName)
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
    Public Function putSourcePeer(ByRef AppId As String, ByRef Key As String, ByRef ChStr As String, ByRef OptStr As String) As ArrayList
        Return CallMproMFASync("putSourcePeer", AppId, Key, ChStr, OptStr)
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
        Return CallImemMFASync("mpro_dal_prov", fun, argsRest)
    End Function

End Class