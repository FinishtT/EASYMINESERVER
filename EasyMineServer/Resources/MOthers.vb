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

    Public Async Sub startserver()

        FormEasyMineServer.RichTextBox1.Select(FormEasyMineServer.RichTextBox1.TextLength, 0)
        FormEasyMineServer.RichTextBox1.SelectionColor = Color.Black
        FormEasyMineServer.RichTextBox1.AppendText(vbCrLf & "Download Finished")
        Await Task.Delay(2000)
        FormEasyMineServer.RichTextBox1.Clear()

        FormEasyMineServer.Button1.Enabled = False
        FormEasyMineServer.ComboBox2.Enabled = False
        FormEasyMineServer.ComboBox1.Enabled = False

        FormEasyMineServer.launchServer()

    End Sub

End Module
