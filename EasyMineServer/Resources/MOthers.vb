Imports System.IO

Module MOthers

    Public VERSIONS_S As String = FormEasyMineServer.INIFILE.GetString("CONFIG", "VERSION_S", "").ToString()
    Public RAM_S As String = FormEasyMineServer.INIFILE.GetString("CONFIG", "RAM_S", "").ToString()

    Public Sub reload()

        VERSIONS_S = FormEasyMineServer.INIFILE.GetString("CONFIG", "VERSION_S", "").ToString()
        RAM_S = FormEasyMineServer.INIFILE.GetString("CONFIG", "RAM_S", "").ToString()

    End Sub

    Public Sub sound_click()

        My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.Background)

    End Sub

    Public Sub DisableAll()

        FormEasyMineServer.TextBox1.ReadOnly = False
        FormEasyMineServer.Button2.Enabled = True
        FormEasyMineServer.Button1.Enabled = False

    End Sub

    Public Sub downloadServer()

        Try

            If (IO.Directory.Exists(VERSIONS_S)) Then



            Else

                IO.Directory.CreateDirectory(VERSIONS_S)

            End If

            FormEasyMineServer.vServerMinecraft = FormEasyMineServer.Conflink.GetString("DOWNLOADSERVERLIST", VERSIONS_S, "")
            FormEasyMineServer.DownloadFile.DownloadFileAsync(New Uri(FormEasyMineServer.vServerMinecraft), VERSIONS_S & "/minecraft_server." & VERSIONS_S & ".jar")

        Catch ex As Exception

            MsgBox("Error with the download LINK !")

            FormEasyMineServer.TextBox1.ReadOnly = True
            FormEasyMineServer.TextBox1.Clear()
            FormEasyMineServer.Button2.Enabled = False
            FormEasyMineServer.Button1.Enabled = True

        End Try

    End Sub

    Public Sub launchServer()

        If (File.Exists(VERSIONS_S & "/minecraft_server." & VERSIONS_S & ".jar")) Then

            If (File.Exists(VERSIONS_S & "/eula.txt")) Then

                Dim cc As New StreamReader(VERSIONS_S & "/eula.txt")

                If (cc.ReadToEnd = "eula=true" = False) Then

                    cc.Close()
                    File.WriteAllText(VERSIONS_S & "/eula.txt", "eula=true")
                End If

            Else

                File.WriteAllText(VERSIONS_S & "/eula.txt", "eula=true")

            End If




            Dim thisserv As New FileInfo(VERSIONS_S & "/minecraft_server." & VERSIONS_S & ".jar")

            FormEasyMineServer.p.StartInfo.CreateNoWindow = True
            FormEasyMineServer.p.StartInfo.UseShellExecute = False
            FormEasyMineServer.p.StartInfo.RedirectStandardInput = True
            FormEasyMineServer.p.StartInfo.RedirectStandardOutput = True
            FormEasyMineServer.p.StartInfo.RedirectStandardError = True
            FormEasyMineServer.p.StartInfo.FileName = "cmd"
            FormEasyMineServer.p.StartInfo.Arguments = "/c @echo off & title SERVEUR MINECRAFT & cd " & thisserv.DirectoryName & " & java -Xms1024M -Xmx" & RAM_S & "M -jar " & "minecraft_server." & VERSIONS_S & ".jar" & " nogui"

            FormEasyMineServer.p.Start()
            FormEasyMineServer.Timer2.Start()
            FormEasyMineServer.RichTextBox1.Text = "The server is launching ! Loading." & vbCrLf

        Else

            If (FormEasyMineServer.vServerMinecraft = "") Then

                MsgBox("The server is not selected")
                FormEasyMineServer.TextBox1.ReadOnly = True
                FormEasyMineServer.TextBox1.Clear()
                FormEasyMineServer.Button2.Enabled = False
                FormEasyMineServer.Button1.Enabled = True

            End If

        End If

    End Sub

    Public Async Sub startserver()

        FormEasyMineServer.RichTextBox1.Select(FormEasyMineServer.RichTextBox1.TextLength, 0)
        Await Task.Delay(2000)
        FormEasyMineServer.RichTextBox1.Clear()

        FormEasyMineServer.Button1.Enabled = False

        launchServer()

    End Sub


    Public Sub checkconfigfile()

        Dim INIREAD01 As String = FormEasyMineServer.INIFILE.GetString("CONFIG", "PROCD", "").ToString
        Dim INIREAD02 As String = FormEasyMineServer.INIFILE.GetString("CONFIG", "SOUNDALERT", "").ToString



        If (INIREAD01 = "FALSE") Then

            SETTINGS.Button4.Text = "SHOW PROCESSOR: OFF"

            FormEasyMineServer.Label1.Visible = False
            FormEasyMineServer.Timer1.Stop()

        ElseIf (INIREAD01 = "TRUE") Then

            SETTINGS.Button4.Text = "SHOW PROCESSOR: ON"

            FormEasyMineServer.Label1.Visible = True
            FormEasyMineServer.Timer1.Start()

        End If

        If (INIREAD02 = "FALSE") Then

            SETTINGS.Button6.Text = "ACTIVE SOUND ALERT: OFF"

        ElseIf (INIREAD02 = True) Then

            SETTINGS.Button6.Text = "ACTIVE SOUND ALERT: ON"

        End If

    End Sub

End Module
