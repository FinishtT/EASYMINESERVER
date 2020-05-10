Imports System.IO

Imports System.Net

Imports System.Threading

Public Class UPDATE

    Dim maj As String = "1.9.1"

    Public Locationappdataroaming1 As String = Path.GetTempPath
    Public WithEvents download As New WebClient


    'DESIGN FORM'

    Private Sub RéduireButton_MouseEnter(sender As Object, e As EventArgs) Handles RéduireButton.MouseEnter

        RéduireButton.Image = My.Resources.Hide_leave

    End Sub

    Private Sub RéduireButton_MouseLeave(sender As Object, e As EventArgs) Handles RéduireButton.MouseLeave

        RéduireButton.Image = My.Resources.Hide_default

    End Sub

    'DESIGN FORM'









    Private Sub UPDATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '(MISE A JOUR DU LOGICIEL)'
        Try


            If (download.DownloadString("https://raw.githubusercontent.com/XsplitS/EASYMINESERVER/master/VERSION/VERSION.conf") = maj) Then 'file.txt,file.ini,etc...'

                Close()

            Else

                Deletefile()

            End If

            '(MISE A JOUR DU LOGICIEL)'

        Catch ex As Exception

            MsgBox(ex.Message)
            Close()

        End Try

    End Sub

    Private Async Sub Deletefile()

        If (File.Exists("EasyMineServer.exe")) Then

            ProgressBar.Value = 0

            NotesLabel.Text = "Suppression du fichier 'EasyMineServer.exe'"

            Await Task.Delay(2000)

            ProgressBar.Value = 30


            File.Delete("EasyMineServer.exe")

            ProgressBar.Value = 100

            Downloadfile()

        Else

            ProgressBar.Value = 100

            Downloadfile()

        End If

    End Sub

    Private Async Sub Downloadfile()

        ProgressBar.Value = 0

        NotesLabel.Text = "Téléchargement des fichiers en cours"

        If (Directory.Exists(Locationappdataroaming1 & "\Download")) Then



        Else

            Directory.CreateDirectory(Locationappdataroaming1 & "\Download")

        End If

        Await (Task.Delay(1000))


        Try

            download.DownloadFileAsync(New Uri("https://raw.githubusercontent.com/XsplitS/EASYMINESERVER/master/SOFTWARES/EasyMineServer.exe"), Locationappdataroaming1 & "\Download\EasyMineServer.exe")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Async Sub download_DownloadProgressChanged(sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged

        ProgressBar.Value = e.ProgressPercentage

        If (ProgressBar.Value = 100) Then

            Try



                If (File.Exists(Locationappdataroaming1 & "\Download\UPDATE.exe")) Then



                Else

                    Await Task.Delay(1000)

                    ProgressBar.Value = 0

                    download.DownloadFileAsync(New Uri("https://raw.githubusercontent.com/XsplitS/EASYMINESERVER/master/SOFTWARES/UPDATE.exe"), Locationappdataroaming1 & "\Download\UPDATE.exe")

                    Exit Sub

                End If

                MsgBox("Le logiciel a terminé de télécharger les fichiers.")

                File.Copy(Locationappdataroaming1 & "\Download\EasyMineServer.exe", "EasyMineServer.exe", True)

                Process.Start("EasyMineServer.exe")

                Close()

            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub RéduireButton_Click(sender As Object, e As EventArgs) Handles RéduireButton.Click

        WindowState = FormWindowState.Minimized

    End Sub
End Class
