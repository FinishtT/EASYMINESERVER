Imports System.IO
Imports System.Net
Imports System.Drawing.Text

Public Class FormEasyMineServer

    Public Locationappdataroaming1 As String = Path.GetTempPath.ToString
    Public WithEvents DownloadFile As New WebClient
    Dim cpu As New PerformanceCounter("Processor information", "% processor time", "_Total")
    Dim p As New Process()
    Dim code As String
    Dim k As String
    Dim LocationAppdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)

    Dim vServerMinecraft As String

    Public Sub DownloadProgression(sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles DownloadFile.DownloadProgressChanged

        k = e.ProgressPercentage.ToString & "%"
        RichTextBox1.ForeColor = Color.Black
        RichTextBox1.Text = (k & vbCr)

    End Sub

    Public Async Sub startserver()

        RichTextBox1.Select(RichTextBox1.TextLength, 0)
        RichTextBox1.SelectionColor = Color.Black
        RichTextBox1.AppendText(vbCrLf & "Download Finished")
        Await Task.Delay(2000)
        RichTextBox1.Clear()

        Button1.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False

        launchServer()

    End Sub

    Private Sub FormEasyMineServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim regKey As Microsoft.Win32.RegistryKey

        regKey = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\JavaSoft", True)

        If (regKey Is Nothing) Then

            MsgBox("Install JAVA before launching this software", MsgBoxStyle.Information)
            Process.Start("https://java.com/en/download/manual.jsp")
            Close()

        Else


        End If

        DownloadFile.CachePolicy = New System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore)
        DownloadFile.Headers.Clear()

        Try

            If (DownloadFile.DownloadString("https://raw.githubusercontent.com/XsplitS/EASYMINESERVER/master/VERSION/VERSION.conf") = "1.8") Then



            Else

                Try

                    Process.Start("UPDATE.exe")
                    Close()

                Catch ex As Exception

                    MsgBox("Cannot launch UPDATE.exe", MsgBoxStyle.Critical)

                End Try

            End If

        Catch ex As Exception

            MsgBox(ex.Message & " No connection ?", MsgBoxStyle.Information)

        End Try

        If (File.Exists(Locationappdataroaming1 & "\Download\UPDATE.exe")) Then

            File.Copy(Locationappdataroaming1 & "\Download\UPDATE.exe", "UPDATE.exe", True)
            Directory.Delete(Locationappdataroaming1 & "\Download", True)

        Else



        End If

        Try

            Label5.Text = Dns.GetHostByName(Dns.GetHostName).AddressList(0).ToString()
            Label4.Text = DownloadFile.DownloadString("https://api.ipify.org/")

        Catch ex As Exception

            Label3.Text = "Ip public : ??"

        End Try

        If (My.Computer.FileSystem.FileExists("Config.conf")) Then

            Try


                Dim aa As String = File.ReadAllLines("Config.conf").ElementAt(1).ToString
                Dim ff As String = File.ReadAllLines("Config.conf").ElementAt(0).ToString

                If (aa = "Procd = False") Then

                    SETTINGS.CheckBox3.Checked = False

                    Label1.Visible = False
                    Timer1.Stop()

                ElseIf (aa = "Procd = True") Then

                    SETTINGS.CheckBox3.Checked = True

                    Label1.Visible = True
                    Timer1.Start()

                Else

                    MsgBox("Le fichier 'CONFIG.CONF' est endommagé !", MsgBoxStyle.Exclamation)

                    File.Delete("Config.conf")

                    File.WriteAllText("Config.conf", "Sound = True" & vbCrLf & "Procd = True")

                    SETTINGS.CheckBox1.Checked = False
                    SETTINGS.CheckBox3.Checked = False

                End If

                If (ff = "Sound = False") Then

                    SETTINGS.CheckBox1.Checked = False

                ElseIf (ff = "Sound = True") Then

                    SETTINGS.CheckBox1.Checked = True

                Else

                    MsgBox("Le fichier 'CONFIG.CONF' est endommagé !", MsgBoxStyle.Exclamation)

                    File.Delete("Config.conf")

                    File.WriteAllText("Config.conf", "Sound = True" & vbCrLf & "Procd = True")

                    SETTINGS.CheckBox1.Checked = False
                    SETTINGS.CheckBox3.Checked = False

                End If

            Catch ex As Exception

                MsgBox("Le fichier 'CONFIG.CONF' est endommagé !", MsgBoxStyle.Exclamation)

                File.Delete("Config.conf")

                File.WriteAllText("Config.conf", "Sound = True" & vbCrLf & "Procd = True")

                SETTINGS.CheckBox1.Checked = False
                SETTINGS.CheckBox3.Checked = False

            End Try


        Else

            My.Computer.FileSystem.WriteAllText("Config.conf", "Sound = True" & vbCrLf & "Procd = True", True)

        End If

        If (File.Exists("server.properties")) Then



        Else

            File.WriteAllBytes("server.properties", My.Resources.server)

        End If

        System.IO.Directory.CreateDirectory(LocationAppdata & "\EASYMINESERVER\CONFIG")

        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        Dim readVersion As StreamReader = New StreamReader(DownloadFile.OpenRead("https://raw.githubusercontent.com/XsplitS/EASYMINESERVER/master/VERSION/VersionSM.txt"))

        Try

            While Not readVersion.EndOfStream

                Dim sLine As String = readVersion.ReadLine
                ComboBox1.Items.Add(sLine)

                If Not readVersion.EndOfStream Then

                    sLine = readVersion.ReadLine
                    ComboBox1.Items.Add(sLine)

                End If

            End While

            readVersion.Close()

            DownloadFile.DownloadFile("https://raw.githubusercontent.com/XsplitS/EASYMINESERVER/master/VERSION/ConfLink.ini", LocationAppdata & "\EASYMINESERVER\CONFIG\ConfLink.ini")


        Catch ex As Exception

            MsgBox("Problem with your connection ?")
            Close()

        End Try



        DownloadFile.CachePolicy = New System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore)
        DownloadFile.Headers.Clear()

        ComboBox2.Text = "1024"
        ComboBox1.Text = "1.13.2"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.Background)

        TextBox1.ReadOnly = False
        Button2.Enabled = True
        Button1.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False

        If (ComboBox1.Text = "") Then

            MsgBox("Choose a version of minecraft server", MsgBoxStyle.Information)
            TextBox1.ReadOnly = True
            TextBox1.Clear()
            Button2.Enabled = False
            Button1.Enabled = True
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
            Exit Sub

        End If

        If (ComboBox2.Text = "") Then

            MsgBox("Choose a Allocation memory for the server", MsgBoxStyle.Information)
            TextBox1.ReadOnly = True
            TextBox1.Clear()
            Button2.Enabled = False
            Button1.Enabled = True
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
            Exit Sub

        End If

        If (File.Exists(ComboBox1.Text & "/minecraft_server." & ComboBox1.Text & ".jar")) Then

            launchServer()

        Else

            downloadServer()

        End If

    End Sub

    Public Sub downloadServer()

        Try

            Timer3.Start()

            If (IO.Directory.Exists(ComboBox1.Text)) Then



            Else

                IO.Directory.Exists(ComboBox1.Text)

                IO.Directory.CreateDirectory(ComboBox1.Text)

            End If

            DownloadFile.DownloadFileAsync(New Uri(vServerMinecraft), ComboBox1.Text & "/minecraft_server." & ComboBox1.Text & ".jar")

        Catch ex As Exception

            MsgBox("Error with the download LINK !")

            TextBox1.ReadOnly = True
            TextBox1.Clear()
            Button2.Enabled = False
            Button1.Enabled = True
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True

        End Try

    End Sub

    Public Sub launchServer()

        If (File.Exists(ComboBox1.Text & "/minecraft_server." & ComboBox1.Text & ".jar")) Then

            If (File.Exists(ComboBox1.Text & "/eula.txt")) Then

                Dim cc As New StreamReader(ComboBox1.Text & "/eula.txt")

                If (cc.ReadToEnd = "eula=true" = False) Then

                    cc.Close()
                    File.WriteAllText(ComboBox1.Text & "/eula.txt", "eula=true")

                End If

            Else

                File.WriteAllText(ComboBox1.Text & "/eula.txt", "eula=true")

            End If




            Dim thisserv As New FileInfo(ComboBox1.Text & "/minecraft_server." & ComboBox1.Text & ".jar")

            p.StartInfo.CreateNoWindow = True
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardInput = True
            p.StartInfo.RedirectStandardOutput = True
            p.StartInfo.RedirectStandardError = True
            p.StartInfo.FileName = "cmd"
            p.StartInfo.Arguments = "/c @echo off & title SERVEUR MINECRAFT & cd " & thisserv.DirectoryName & " & java -Xms1024M -Xmx" & ComboBox2.Text & "M -jar " & "minecraft_server." & ComboBox1.Text & ".jar" & " nogui"

            p.Start()
            Timer2.Start()

        Else

            If (vServerMinecraft = "") Then

                MsgBox("the server is not selected")
                TextBox1.ReadOnly = True
                TextBox1.Clear()
                Button2.Enabled = False
                Button1.Enabled = True
                ComboBox1.Enabled = True
                ComboBox2.Enabled = True

            End If

        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


        Try

            BWSTARTSERVER.RunWorkerAsync()

            RichTextBox1.SelectionStart = RichTextBox1.TextLength - -1
            RichTextBox1.ScrollToCaret()

        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.Background)

        Try

            p.StandardInput.WriteLine(TextBox1.Text)
            code = TextBox1.Text

        Catch ex As Exception

        End Try

    End Sub

    Private Sub BWSTARTSERVER_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWSTARTSERVER.DoWork

        If (code = "stop") Then

            Button2.Enabled = False
            TextBox1.ReadOnly = True
            TextBox1.Clear()

            Timer2.Stop()

            code = ""

            Button1.Enabled = True
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True

        End If

        If (code = "/stop") Then

            Button2.Enabled = False
            TextBox1.ReadOnly = True
            TextBox1.Clear()

            Timer2.Stop()

            code = ""

            Button1.Enabled = True
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True

        End If

        If (RichTextBox1.Lines.Count > 40) Then

            Dim richtxt As String = RichTextBox1.Text
            Dim pos As Integer = richtxt.IndexOf(vbLf)
            RichTextBox1.Text = richtxt.Substring(pos + 1, richtxt.Length - pos - 1)

        End If

        Try

            Dim ll As String = p.StandardOutput.ReadLine & vbCrLf
            RichTextBox1.AppendText(ll)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub FormEasyMineServer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Try

            p.StandardInput.WriteLine("stop")
            p.StandardInput.WriteLine("/stop")
            p.Kill()
            p.Close()

            Button2.Enabled = False
            TextBox1.ReadOnly = True
            TextBox1.Clear()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Try

            Dim ClsINIcombobox As New ClsINI(LocationAppdata & "\EASYMINESERVER\CONFIG\ConfLink.ini")

            Dim A As String = ComboBox1.Text
            vServerMinecraft = ClsINIcombobox.GetString("DOWNLOADSERVERLIST", A, "")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If (k = "100%") Then

            Timer3.Stop()
            startserver()
            k = ""
            Timer3.Stop()

        End If

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        If (e.KeyCode = Keys.Enter) Then

            Try

                p.StandardInput.WriteLine(TextBox1.Text)
                code = TextBox1.Text

            Catch ex As Exception

            End Try

        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Try

            Dim cpuload As Integer = CDec(cpu.NextValue.ToString())
            Label1.Text = "Processor : " & cpuload & "%"

            If (cpuload >= 80) Then

                Label1.ForeColor = Color.Red

                If (SETTINGS.CheckBox1.Checked = True) Then



                Else

                    My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)

                End If

            Else

                Label1.ForeColor = Color.White

            End If

        Catch ex As Exception



        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.Background)
        SETTINGS.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.Background)

        MsgBox("Not available for moment", MsgBoxStyle.Information)

    End Sub

    Private Sub Label4_MouseClick(sender As Object, e As MouseEventArgs) Handles Label4.MouseClick

        If (e.Button = MouseButtons.Right) Then

            Clipboard.SetText(Label4.Text)
            MsgBox("Copied " & "(" & Label4.Text & ")", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub Label5_MouseClick(sender As Object, e As MouseEventArgs) Handles Label5.MouseClick

        If (e.Button = MouseButtons.Right) Then

            Clipboard.SetText(Label5.Text)
            MsgBox("Copied " & "(" & Label5.Text & ")", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        My.Computer.Audio.Play(My.Resources.Button, AudioPlayMode.Background)
        SProperties.Show()
        Me.Hide()

    End Sub

End Class
