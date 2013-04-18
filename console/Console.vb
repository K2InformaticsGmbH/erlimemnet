Module Console

    Sub Main()
        Dim mpro As Mpro = mpro.Connect("localhost", 8125)
        mpro.Authenticate("admin", "change_on_install")
        mpro.Login()
        mpro.Logout()
        mpro.Authenticate("admin", "change_on_install")
        mpro.Login()

        Dim l As ArrayList = mpro.listDestinationChannels("smpp")
        l = Nothing
        mpro = Nothing
    End Sub

End Module
