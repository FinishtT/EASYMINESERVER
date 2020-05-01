Imports System.IO

Module MOthers

    Public Sub sound_click()

        My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.Background)

    End Sub

    Public Sub DisableAll()

        FormEasyMineServer.TextBox1.ReadOnly = False
        FormEasyMineServer.Button2.Enabled = True
        FormEasyMineServer.Button1.Enabled = False
        FormEasyMineServer.ComboBox2.Enabled = False
        FormEasyMineServer.ComboBox1.Enabled = False

    End Sub

    Public Sub downloadServer()

        Try

            FormEasyMineServer.Timer3.Start()

            If (IO.Directory.Exists(FormEasyMineServer.ComboBox2.Text)) Then



            Else

                IO.Directory.Exists(FormEasyMineServer.ComboBox2.Text)

                IO.Directory.CreateDirectory(FormEasyMineServer.ComboBox2.Text)

            End If

            FormEasyMineServer.DownloadFile.DownloadFileAsync(New Uri(FormEasyMineServer.vServerMinecraft), FormEasyMineServer.ComboBox2.Text & "/minecraft_server." & FormEasyMineServer.ComboBox2.Text & ".jar")

        Catch ex As Exception

            MsgBox("Error with the download LINK !")

            FormEasyMineServer.TextBox1.ReadOnly = True
            FormEasyMineServer.TextBox1.Clear()
            FormEasyMineServer.Button2.Enabled = False
            FormEasyMineServer.Button1.Enabled = True
            FormEasyMineServer.ComboBox2.Enabled = True
            FormEasyMineServer.ComboBox1.Enabled = True

        End Try

    End Sub

    Public Sub launchServer()

        If (File.Exists(FormEasyMineServer.ComboBox2.Text & "/minecraft_server." & FormEasyMineServer.ComboBox2.Text & ".jar")) Then

            If (File.Exists(FormEasyMineServer.ComboBox2.Text & "/eula.txt")) Then

                Dim cc As New StreamReader(FormEasyMineServer.ComboBox2.Text & "/eula.txt")

                If (cc.ReadToEnd = "eula=true" = False) Then

                    cc.Close()
                    File.WriteAllText(FormEasyMineServer.ComboBox2.Text & "/eula.txt", "eula=true")
                End If

            Else

                File.WriteAllText(FormEasyMineServer.ComboBox2.Text & "/eula.txt", "eula=true")

            End If




            Dim thisserv As New FileInfo(FormEasyMineServer.ComboBox2.Text & "/minecraft_server." & FormEasyMineServer.ComboBox2.Text & ".jar")

            FormEasyMineServer.p.StartInfo.CreateNoWindow = True
            FormEasyMineServer.p.StartInfo.UseShellExecute = False
            FormEasyMineServer.p.StartInfo.RedirectStandardInput = True
            FormEasyMineServer.p.StartInfo.RedirectStandardOutput = True
            FormEasyMineServer.p.StartInfo.RedirectStandardError = True
            FormEasyMineServer.p.StartInfo.FileName = "cmd"
            FormEasyMineServer.p.StartInfo.Arguments = "/c @echo off & title SERVEUR MINECRAFT & cd " & thisserv.DirectoryName & " & java -Xms1024M -Xmx" & FormEasyMineServer.ComboBox1.Text & "M -jar " & "minecraft_server." & FormEasyMineServer.ComboBox2.Text & ".jar" & " nogui"

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
                FormEasyMineServer.ComboBox2.Enabled = True
                FormEasyMineServer.ComboBox1.Enabled = True

            End If

        End If

    End Sub

    Public Async Sub startserver()

        FormEasyMineServer.RichTextBox1.Select(FormEasyMineServer.RichTextBox1.TextLength, 0)
        FormEasyMineServer.RichTextBox1.SelectionColor = Color.Black
        FormEasyMineServer.RichTextBox1.AppendText(vbCrLf & "Download Finished")
        Await Task.Delay(2000)
        FormEasyMineServer.RichTextBox1.Clear()

        FormEasyMineServer.Button1.Enabled = False
        FormEasyMineServer.ComboBox2.Enabled = False
        FormEasyMineServer.ComboBox1.Enabled = False

        launchServer()

    End Sub

End Module
