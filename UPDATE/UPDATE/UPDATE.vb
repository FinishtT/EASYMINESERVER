Imports System.IO
Imports System.Net

Public Class UPDATE

    Dim maj As String = "1.9.4"

    Public Locationappdataroaming1 As String = Path.GetTempPath
    Public WithEvents download As New WebClient


    'DESIGN FORM'

    Private Sub RéduireButton_MouseEnter(sender As Object, e As EventArgs) Handles RéduireButton.MouseEnter

        RéduireButton.Image = My.Resources.Hide_leave

    End Sub

    Private Sub RéduireButton_MouseLeave(sender As Object, e As EventArgs) Handles RéduireButton.MouseLeave

        RéduireButton.Image = My.Resources.Hide_default

    End Sub

    Private Sub RéduireButton_Click(sender As Object, e As EventArgs) Handles RéduireButton.Click

        WindowState = FormWindowState.Minimized

    End Sub

    'DESIGN FORM'









    Private Sub UPDATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '(MISE A JOUR DU LOGICIEL)'
        Try


            If (download.DownloadString("https://raw.githubusercontent.com/XsplitS/EASYMINESERVER/master/VERSION/VERSION.conf") = maj) Then 'file.txt,file.ini,etc...'

                Close()

            Else

                Deletefile()
                Downloadfile()

            End If

            '(MISE A JOUR DU LOGICIEL)'

        Catch ex As Exception

            MsgBox(ex.Message)
            Application.Exit()

        End Try

    End Sub

    Private Async Sub Deletefile()

        If (File.Exists("EasyMineServer.exe")) Then

            ProgressBar.Value = 0

            NotesLabel.Text = "Deleting file 'EasyMineServer.exe'"

            ProgressBar.Value = 30

            Await Task.Delay(2000)

            File.Delete("EasyMineServer.exe")

            If (File.Exists("config.ini")) Then

                NotesLabel.Text = "Deleting file 'config.ini'"

                Await Task.Delay(2000)

                File.Delete("config.ini")

            End If

            ProgressBar.Value = 100

        Else

            ProgressBar.Value = 100

        End If

    End Sub

    Private Async Sub Downloadfile()

        ProgressBar.Value = 0

        If (Directory.Exists(Locationappdataroaming1 & "\Download")) Then



        Else

            Directory.CreateDirectory(Locationappdataroaming1 & "\Download")

        End If

        Await (Task.Delay(2000))

        Try

            download.DownloadFileAsync(New Uri("https://raw.githubusercontent.com/XsplitS/EASYMINESERVER/master/SOFTWARES/EasyMineServer.exe"), Locationappdataroaming1 & "\Download\EasyMineServer.exe")

        Catch ex As Exception

            MsgBox(ex.Message)
            Application.Exit()

        End Try

    End Sub

    Private Async Sub download_DownloadProgressChanged(sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged

        ProgressBar.Value = e.ProgressPercentage
        NotesLabel.Text = "Downloading (EASYMINESERVER.exe)" & e.ProgressPercentage & "%"

        If (ProgressBar.Value = 100) Then

            Await Task.Delay(2000)

            Try

                If (File.Exists(Locationappdataroaming1 & "\Download\UPDATE.exe")) Then



                Else

                    NotesLabel.Text = "Downloading (UPDATE.exe)" & e.ProgressPercentage & "%"

                    Await Task.Delay(2000)

                    ProgressBar.Value = 0

                    download.DownloadFileAsync(New Uri("https://raw.githubusercontent.com/XsplitS/EASYMINESERVER/master/SOFTWARES/UPDATE.exe"), Locationappdataroaming1 & "\Download\UPDATE.exe")

                End If

                NotesLabel.Text = "Copy files in progress"

                File.Copy(Locationappdataroaming1 & "\Download\EasyMineServer.exe", "EasyMineServer.exe", True)

                Await Task.Delay(3000)

                NotesLabel.Text = "Launching software EASYMINESERVER.exe"

                Await Task.Delay(2000)

                Process.Start("EasyMineServer.exe")

                Application.Exit()

            Catch ex As Exception

            End Try

        End If
    End Sub
End Class
