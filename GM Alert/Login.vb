Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Management
Imports System.Web

Public Class Login
    Private cnx As New MySqlConnection
    Private cmd As New MySqlCommand
    Private da As New MySqlDataAdapter
    Private dr As MySqlDataReader
    Private ds As New DataSet
    Private soloUnaTabla As DataTable
    Private dtRow As DataRow
    Private disk As ManagementObject

    Private dbversion As String
    Private filereader As String
    Private HWID As String
    Private Origen As String

    Private Sub checkTime_Tick(sender As Object, e As EventArgs) Handles checkTime.Tick
        Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkTime.Enabled = True
        Try
            cmd.Connection = cnx
            cmd.CommandText = "SELECT versionnum FROM version"
            cnx.ConnectionString = "Server=localhost;Port=3306;Database=gmalert;Uid=root;Pwd=gtl929t8a54kj2r9xykpzy55p2tp"
            cnx.Open()
            dbversion = cmd.ExecuteScalar()
            cnx.Close()

            filereader = My.Computer.FileSystem.ReadAllText(Directory.GetCurrentDirectory + "\version.txt")

            If dbversion = filereader Then
                'msg verde
                labupdatedok.Visible = True
            Else
                'msg rojo
                labversionmsg.Visible = True
                MsgBox("Update needed!" + vbCrLf + "Download from: https://www.kuhiscripts.com/downloads")
                Application.Exit()
            End If

            disk = New ManagementObject(String.Format("win32_logicaldisk.deviceid=""{0}:""", "C"))
            disk.Get()
            HWID = disk("VolumeSerialNumber").ToString()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            If txtpass.Text <> "" And txtuser.Text <> "" Then
                cmd.CommandText = "SELECT * FROM accounts WHERE passwd='" + txtpass.Text + "' AND name='" + txtuser.Text + "'"
                da = New MySqlDataAdapter(cmd)
                da.Fill(ds, "account")

                soloUnaTabla = ds.Tables("account")
                dtRow = soloUnaTabla.Rows.Item(0)

                If CInt(dtRow("premdays")) = 0 Then
                    MsgBox("Out of days!")
                    Application.Exit()
                Else MsgBox(dtRow("premdays").ToString + " days left!")
                End If

                'Tengo dtRow("campo") para sacar cualquier valor :D
                If txtuser.Text = dtRow("name") And txtpass.Text = dtRow("passwd") And HWID = dtRow("HWID") Then
                    checkTime.Stop()
                    Form1.Show()
                    Me.Hide()
                ElseIf dtRow("HWID") = "ADMIN" Then
                    checkTime.Stop()
                    Form1.Show()
                    Me.Hide()
                Else
                    MsgBox("Login failed!")
                End If
            Else
                MsgBox("Please, write username and password!")
            End If
        Catch ex As Exception
            Application.Exit()
        End Try

    End Sub

    Private Sub txtpass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            PictureBox1_Click(sender, e)
        End If
    End Sub

    Private Sub txtuser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtuser.KeyDown
        If e.KeyCode = Keys.Enter Then
            PictureBox1_Click(sender, e)
        End If
    End Sub
End Class