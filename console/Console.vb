Imports System.Text

Module Console

    Sub Main()
        Dim mpro As Mpro = mpro.Connect("localhost", 8125)
        mpro.Authenticate("admin", "change_on_install")
        mpro.Login()
        ' mpro.Logout()
        ' mpro.Authenticate("admin", "change_on_install")
        ' mpro.Login()
        Dim strTest As New StringBuilder
        For i = 1 To 10000
            strTest.Append("Schüpbach")
        Next
        Dim l As ArrayList = mpro.putSourcePeer("smpp", "1234", "3017", strTest.ToString, "[]")
        l = Nothing
        mpro = Nothing
    End Sub

End Module
