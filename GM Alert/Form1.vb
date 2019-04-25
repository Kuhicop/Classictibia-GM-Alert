Public Class Form1
    Private ID As Integer = 1

    Private Sub Checking_Tick(sender As Object, e As EventArgs) Handles Checking.Tick
        Try

            Select Case ID
                Case 1 'GM Rid
                    revisar("GM%20Rid", chkRid)
                    ID += 1
                Case 2 'Vassak
                    revisar("vassak", chkVassak)
                    ID += 1
                Case 3 'GM Angar
                    revisar("GM%20Angar", chkAngar)
                    ID += 1
                Case 4 'Admin
                    revisar("admin", chkadmin)
                    ID += 1
                Case 5 'CM Blackadder
                    revisar("CM%20Blackadder", chkBlackAdder)
                    ID += 1
                Case 6 'Zornak
                    revisar("zornak", chkZornak)
                    ID = 1
                Case Else
                    ID = 1
            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub revisar(ByVal name As String, ByRef checkboxname As CheckBox)
        Try
            Dim webstring As String = New System.Net.WebClient().DownloadString("http://classictibia.com/characterprofile.php?name=" + name)

            If Not checkboxname.Checked Then
                If webstring.Contains("<b>ONLINE</b>") Then
                    checkboxname.BackColor = Color.Green
                    loop_alerts()
                ElseIf webstring.Contains("Chill down") Then
                    MsgBox("RELAX!")
                Else
                    checkboxname.BackColor = Color.Red
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
