﻿Imports System.Text
Imports K2Informatics.Erlimemnet

Module Console

    Sub Main()
        Dim mpro As MproVb = MproVb.Connect("127.0.0.1", 8081, True)
        'Dim mpro As Mpro = mpro.Connect("127.0.0.1", 8081, True)
        mpro.Authenticate("admin", "change_on_install")
        mpro.Login()
        ' mpro.Logout()
        ' mpro.Authenticate("admin", "change_on_install")
        ' mpro.Login()
        'Dim strTest As New StringBuilder
        'For i = 1 To 10000
        'strTest.Append("Schüpbach")
        'Next

        Debug.Print("Start Insert {0}", DateTime.Now())
        For i = 2 To 255
            mpro.putWhitelist("tpi", "4140", String.Format("127.0.0.{0}", i), "")
            mpro.putWhitelist("smpp", "4129", String.Format("127.0.0.{0}", i), "")
            mpro.putWhitelist("ucp", "4139", String.Format("127.0.0.{0}", i), "")
        Next
        Debug.Print("Start Remove {0}", DateTime.Now())
        For i = 2 To 255
            mpro.deleteWhitelist("tpi", "4140", String.Format("127.0.0.{0}", i))
            mpro.deleteWhitelist("smpp", "4129", String.Format("127.0.0.{0}", i))
            mpro.deleteWhitelist("ucp", "4139", String.Format("127.0.0.{0}", i))
        Next
        Debug.Print("Finished {0}", DateTime.Now())

        Dim l1 As Object() = mpro.getSourcePeer("ucp", "4139") ' works
        l1 = Nothing
        Dim l3 As Object() = mpro.putSourcePeer("tpi", "", "4140", "Läderach", "[]")
        l3 = Nothing
        'Dim l2 As ArrayList = mpro.getSourcePeer("smpp", "1234") ' fails
        'l2 = Nothing
        mpro = Nothing
    End Sub

End Module
