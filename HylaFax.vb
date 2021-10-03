Imports Atom8.Communications.Fax
Imports Atom8.Communications.Fax.HylafaxJob
Public Class Form1
  Public Function SendFax()
    Dim testServer As New Hylafax("VOTT-FOFS-SESN-TETH", "127.0.0.1", 4579, "fax.admin", "fax123456789")

        'Dim durum = test.IsConnected
        'MsgBox(test.ModemCount)
        Dim modemList As String
        Dim hm As HylafaxModems = test.Modems
        modemList += test.Host + vbCr & vbLf
        modemList += "----------------------------" & vbCr & vbLf
        If hm.Count = 0 Then
            modemList += "No modem found in " + test.Host + vbCr & vbLf
            modemList += "------------------------------------" & vbCr & vbLf
        Else
            For Each hfm As HylafaxModem In hm
                modemList += "Modem Name = " + hfm.ModemName
                modemList += ";Status=" + hfm.ModemStatus
                modemList += ";FaxNumber=" + hfm.PhoneNumber + vbCr & vbLf
            Next
        End If
        console.log(modemList)
        'MsgBox(hm(0).PhoneNumber)
        'MsgBox(hm(0).ModemName)
        'MsgBox(hm(0).ModemStatus)
        hm(0).IsActive = True
        Dim z As New HylafaxJobSettings
        z.FaxNumber = "00905556663322"
        z.FromCompany = "Fbasgul"
        z.ToCompany = "Cag"
        Dim faxid = test.SendFax("c:\temp\1.pdf", "", z)
      return  faxid
  End Sub
End class
