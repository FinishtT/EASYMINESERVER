Imports System.Diagnostics.Eventing.Reader
Imports System.IO

Public Class SETTINGS

    Private Sub SETTINGS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        sound_click()
        FormEasyMineServer.Show()
        Me.Hide()
        e.Cancel = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If (Button4.Text = "SHOW PROCESSOR: OFF") Then

            sound_click()
            FormEasyMineServer.INIFILE.WriteString("CONFIG", "PROCD", "TRUE")

            Button4.Text = "SHOW PROCESSOR: ON" 'ENABLE'
            FormEasyMineServer.Label1.Visible = True
            FormEasyMineServer.Timer1.Start()

        Else

            sound_click()
            FormEasyMineServer.INIFILE.WriteString("CONFIG", "PROCD", "FALSE")

            Button4.Text = "SHOW PROCESSOR: OFF" 'DISABLE'
            FormEasyMineServer.Label1.Visible = False
            FormEasyMineServer.Timer1.Stop()

        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If (Button6.Text = "ACTIVE SOUND ALERT: OFF") Then

            sound_click()
            FormEasyMineServer.INIFILE.WriteString("CONFIG", "SOUNDALERT", "TRUE")
            Button6.Text = "ACTIVE SOUND ALERT: ON" 'ENABLE'

        Else

            sound_click()
            FormEasyMineServer.INIFILE.WriteString("CONFIG", "SOUNDALERT", "FALSE")
            Button6.Text = "ACTIVE SOUND ALERT: OFF" 'DISABLE'

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        sound_click()
        Dim input1 As String = InputBox("Enter server version here (ex: 1.7.2)", "Insert your version server")

        If (input1 = Nothing) Then

            Exit Sub

        End If

        Dim readVersion As StreamReader = New StreamReader(FormEasyMineServer.LocationAppdata & "\EASYMINESERVER\CONFIG\VersionSM.txt")

        While Not readVersion.EndOfStream

            If (input1 = readVersion.ReadLine) Then

                readVersion.Close()

                FormEasyMineServer.INIFILE.WriteString("CONFIG", "VERSION_S", input1)
                SETTINGS_Load()
                Exit Sub

            End If

        End While

        Dim msgbox1 As Integer = MsgBox("The entering version is not correct, do you want open file for views all version available here ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)

        If (msgbox1 = vbYes) Then

            Process.Start(FormEasyMineServer.LocationAppdata & "\EASYMINESERVER\CONFIG\VersionSM.txt")

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        sound_click()
        Dim input As String = InputBox("Enter your RAM server here (ex: For 4 GB = Write the number 4)", "Insert your RAM server")

        If (input = Nothing) Then

            Exit Sub

        End If

        Dim result As String = input * 1024
        FormEasyMineServer.INIFILE.WriteString("CONFIG", "RAM_S", result)
        SETTINGS_Load()

    End Sub

    Public Sub SETTINGS_Load()

        reload()
        Label3.Text = VERSIONS_S
        Label4.Text = RAM_S

    End Sub

End Class
