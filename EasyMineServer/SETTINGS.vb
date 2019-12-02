Imports System.IO

Public Class SETTINGS

    Private Sub SETTINGS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.Background)
        FormEasyMineServer.Show()
        Me.Hide()
        e.Cancel = True

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If (CheckBox1.Checked = True) Then

            My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.Background)
            File.WriteAllText("Config.conf", File.ReadAllText("Config.conf").Replace("Sound = False", "Sound = True"))

        Else

            My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.Background)
            File.WriteAllText("Config.conf", File.ReadAllText("Config.conf").Replace("Sound = True", "Sound = False"))

        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

        If (CheckBox3.Checked = True) Then

            My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.Background)
            File.WriteAllText("Config.conf", File.ReadAllText("Config.conf").Replace("Procd = False", "Procd = True"))

            FormEasyMineServer.Label1.Visible = True
            FormEasyMineServer.Timer1.Start()

        Else

            My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.Background)
            File.WriteAllText("Config.conf", File.ReadAllText("Config.conf").Replace("Procd = True", "Procd = False"))

            FormEasyMineServer.Label1.Visible = False
            FormEasyMineServer.Timer1.Stop()

        End If

    End Sub

    Private Sub SETTINGS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
