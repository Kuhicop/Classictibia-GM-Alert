Imports System.IO
Imports System.Net.Mail
Imports System.Threading
Imports System.Net

Module Alerts
    Public Sub loop_alerts()
        With Form1
            'Sound
            If .chksound.Checked Then
                My.Computer.Audio.Play(Directory.GetCurrentDirectory() + "\danger.wav", AudioPlayMode.WaitToComplete)
            End If

            'Send mail
            If .chkmail.Checked Then
                .chkmail.Checked = False
                SendMail()
            End If

            'Logout and close
            If .chkclose.Checked Then
                For Each process As Process In Process.GetProcessesByName("Classictibia")
                    AppActivate(process.Id)
                    Threading.Thread.Sleep(500)
                    SendKeys.Send("^{Q}")
                    Threading.Thread.Sleep(300)
                    process.Kill()
                    Threading.Thread.Sleep(200)
                Next
            End If
        End With
    End Sub

    Private Sub sendmail()
        Dim correos As New MailMessage
        Dim envios As New SmtpClient

        Thread.CurrentThread.IsBackground = True
        Try
            correos.Body = "STAFF IS ONLINE!!!"
            correos.Subject = "GM ALERT!"
            correos.IsBodyHtml = False
            correos.To.Add(Form1.txtmailaddr.Text)

            correos.From = New MailAddress("info@kuhiscripts.com")
            envios.Credentials = New NetworkCredential("info@kuhiscripts.com", "949594asD!")

            envios.Host = "smtp.1and1.es"
            envios.Port = 587
            envios.EnableSsl = True

            envios.Send(correos)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
