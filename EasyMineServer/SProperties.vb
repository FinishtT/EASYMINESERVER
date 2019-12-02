Imports System.IO

Public Class SProperties

    Private Sub SProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (File.Exists("server.properties")) Then


            Try

                TextBox1.Text = File.ReadAllLines("server.properties").ElementAt(2).ToString
                TextBox2.Text = File.ReadAllLines("server.properties").ElementAt(3).ToString
                TextBox3.Text = File.ReadAllLines("server.properties").ElementAt(4).ToString
                TextBox4.Text = File.ReadAllLines("server.properties").ElementAt(5).ToString
                TextBox5.Text = File.ReadAllLines("server.properties").ElementAt(6).ToString
                TextBox6.Text = File.ReadAllLines("server.properties").ElementAt(7).ToString
                TextBox7.Text = File.ReadAllLines("server.properties").ElementAt(8).ToString
                TextBox8.Text = File.ReadAllLines("server.properties").ElementAt(9).ToString
                TextBox9.Text = File.ReadAllLines("server.properties").ElementAt(10).ToString
                TextBox10.Text = File.ReadAllLines("server.properties").ElementAt(11).ToString
                TextBox11.Text = File.ReadAllLines("server.properties").ElementAt(12).ToString
                TextBox12.Text = File.ReadAllLines("server.properties").ElementAt(13).ToString
                TextBox13.Text = File.ReadAllLines("server.properties").ElementAt(14).ToString
                TextBox14.Text = File.ReadAllLines("server.properties").ElementAt(15).ToString
                TextBox15.Text = File.ReadAllLines("server.properties").ElementAt(16).ToString
                TextBox16.Text = File.ReadAllLines("server.properties").ElementAt(17).ToString
                TextBox17.Text = File.ReadAllLines("server.properties").ElementAt(18).ToString
                TextBox18.Text = File.ReadAllLines("server.properties").ElementAt(19).ToString
                TextBox19.Text = File.ReadAllLines("server.properties").ElementAt(20).ToString
                TextBox20.Text = File.ReadAllLines("server.properties").ElementAt(21).ToString
                TextBox21.Text = File.ReadAllLines("server.properties").ElementAt(22).ToString
                TextBox22.Text = File.ReadAllLines("server.properties").ElementAt(23).ToString
                TextBox23.Text = File.ReadAllLines("server.properties").ElementAt(24).ToString
                TextBox24.Text = File.ReadAllLines("server.properties").ElementAt(25).ToString
                TextBox25.Text = File.ReadAllLines("server.properties").ElementAt(26).ToString
                TextBox26.Text = File.ReadAllLines("server.properties").ElementAt(27).ToString
                TextBox27.Text = File.ReadAllLines("server.properties").ElementAt(28).ToString
                TextBox28.Text = File.ReadAllLines("server.properties").ElementAt(29).ToString
                TextBox29.Text = File.ReadAllLines("server.properties").ElementAt(30).ToString
                TextBox30.Text = File.ReadAllLines("server.properties").ElementAt(31).ToString
                TextBox31.Text = File.ReadAllLines("server.properties").ElementAt(32).ToString
                TextBox32.Text = File.ReadAllLines("server.properties").ElementAt(33).ToString
                TextBox33.Text = File.ReadAllLines("server.properties").ElementAt(34).ToString
                TextBox34.Text = File.ReadAllLines("server.properties").ElementAt(35).ToString
                TextBox36.Text = File.ReadAllLines("server.properties").ElementAt(36).ToString
                TextBox37.Text = File.ReadAllLines("server.properties").ElementAt(37).ToString

            Catch ex As Exception



            End Try

        Else

            File.WriteAllBytes("server.properties", My.Resources.server)

            Refresh()

        End If

    End Sub

    Private Sub SETTINGS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.Background)
        FormEasyMineServer.Show()
        Me.Hide()
        e.Cancel = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim fileReader01 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(2).ToString, TextBox1.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader01, False)

        Dim fileReader02 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(3).ToString, TextBox2.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader02, False)

        Dim fileReader03 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(4).ToString, TextBox3.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader03, False)

        Dim fileReader04 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(5).ToString, TextBox4.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader04, False)

        Dim fileReader05 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(6).ToString, TextBox5.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader05, False)

        Dim fileReader06 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(7).ToString, TextBox6.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader06, False)

        Dim fileReader07 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(8).ToString, TextBox7.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader07, False)

        Dim fileReader08 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(9).ToString, TextBox8.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader08, False)

        Dim fileReader09 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(10).ToString, TextBox9.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader09, False)

        Dim fileReader10 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(11).ToString, TextBox10.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader10, False)

        Dim fileReader11 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(12).ToString, TextBox11.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader11, False)

        Dim fileReader12 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(13).ToString, TextBox12.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader12, False)

        Dim fileReader13 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(14).ToString, TextBox13.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader13, False)

        Dim fileReader14 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(15).ToString, TextBox14.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader14, False)

        Dim fileReader15 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(16).ToString, TextBox15.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader15, False)

        Dim fileReader16 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(17).ToString, TextBox16.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader16, False)

        Dim fileReader17 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(18).ToString, TextBox17.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader17, False)

        Dim fileReader18 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(19).ToString, TextBox18.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader18, False)

        Dim fileReader19 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(20).ToString, TextBox19.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader19, False)

        Dim fileReader20 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(21).ToString, TextBox20.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader20, False)

        Dim fileReader21 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(22).ToString, TextBox21.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader21, False)

        Dim fileReader22 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(23).ToString, TextBox22.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader22, False)

        Dim fileReader23 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(24).ToString, TextBox23.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader23, False)

        Dim fileReader24 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(25).ToString, TextBox24.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader24, False)

        Dim fileReader25 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(26).ToString, TextBox25.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader25, False)

        Dim fileReader26 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(27).ToString, TextBox26.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader26, False)

        Dim fileReader27 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(28).ToString, TextBox27.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader27, False)

        Dim fileReader28 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(29).ToString, TextBox28.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader28, False)

        Dim fileReader29 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(30).ToString, TextBox29.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader29, False)

        Dim fileReader30 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(31).ToString, TextBox30.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader30, False)

        Dim fileReader31 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(32).ToString, TextBox31.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader31, False)

        Dim fileReader32 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(33).ToString, TextBox32.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader32, False)

        Dim fileReader33 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(34).ToString, TextBox33.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader33, False)

        Dim fileReader34 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(35).ToString, TextBox34.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader34, False)

        Dim fileReader35 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(36).ToString, TextBox36.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader35, False)

        Dim fileReader36 As String = My.Computer.FileSystem.ReadAllText("server.properties").Replace(File.ReadAllLines("server.properties").ElementAt(37).ToString, TextBox37.Text)
        My.Computer.FileSystem.WriteAllText("server.properties", fileReader36, False)

        My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.Background)

    End Sub

End Class
