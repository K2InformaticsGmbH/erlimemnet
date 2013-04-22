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
        Dim l1 As ArrayList = mpro.getSourcePeer("ucp", "80018") ' works
        Dim l3 As ArrayList = mpro.putSourcePeer("smpp", "1234", "3017", strTest.ToString, "[]")
        Dim l2 As ArrayList = mpro.getSourcePeer("smpp", "1234") ' fails
        l1 = Nothing
        l2 = Nothing
        l3 = Nothing
        mpro = Nothing
    End Sub

End Module
