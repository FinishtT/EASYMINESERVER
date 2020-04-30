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
    Public Shared vServerMinecraft As String
    Dim maj As String = "1.8.2"

    Public Sub DownloadProgression(sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles DownloadFile.DownloadProgressChanged

        k = e.ProgressPercentage.ToString & "%"
        RichTextBox1.ForeColor = Color.Black
        RichTextBox1.Text = (k & vbCr)

    End Sub

    Private Sub FormEasyMineServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'JAVA VERIFICATION'
        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\JavaSoft", True)
        If (regKey Is Nothing) Then

            MsgBox("Install JAVA before launching this software", MsgBoxStyle.Information)
            Process.Start("https://java.com/en/download/manual.jsp")
            Close()
        End If
        'JAVA VERIFICATION'

        DownloadFile.CachePolicy = New System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore)
        DownloadFile.Headers.Clear()

        'MAJ'
        Try

            If (DownloadFile.DownloadString("https://raw.githubusercontent.com/XsplitS/EASYMINESERVER/master/VERSION/VERSION.conf").Remove(5, 1) = maj) Then

            Else

                Try
                    Dim msgyesno As Integer = MsgBox("Une mise à jour est disponible, voulez-vous la démarrer ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information)

                    If (msgyesno = vbYes) Then


                        Process.Start("UPDATE.exe")
                        Close()

                    End If

                Catch ex As Exception

                    MsgBox("UPDATE.exe not found", MsgBoxStyle.Critical)

                End Try

            End If

        Catch ex As Exception

            MsgBox(ex.Message & " No connection ?, Vous passer en mode hors ligne.", MsgBoxStyle.Information)

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

            Label3.Text = "Ip publique : ??"

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
                ComboBox2.Items.Add(sLine)

            End While

            readVersion.Close()

            DownloadFile.DownloadFile("https://raw.githubusercontent.com/XsplitS/EASYMINESERVER/master/VERSION/ConfLink.ini", LocationAppdata & "\EASYMINESERVER\CONFIG\ConfLink.ini")


        Catch ex As Exception

            MsgBox("Problem with your connection ?")
            Close()

        End Try



        DownloadFile.CachePolicy = New System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore)
        DownloadFile.Headers.Clear()

        ComboBox1.Text = "1024"
        ComboBox2.Text = "1.15.2"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sound_click()
        DisableAll()

        If (File.Exists(ComboBox2.Text & "/minecraft_server." & ComboBox2.Text & ".jar")) Then

            launchServer()

        Else

            downloadServer()

        End If

    End Sub

    Public Sub launchServer()

        If (File.Exists(ComboBox2.Text & "/minecraft_server." & ComboBox2.Text & ".jar")) Then

            If (File.Exists(ComboBox2.Text & "/eula.txt")) Then

                Dim cc As New StreamReader(ComboBox2.Text & "/eula.txt")

                If (cc.ReadToEnd = "eula=true" = False) Then

                    cc.Close()
                    File.WriteAllText(ComboBox2.Text & "/eula.txt", "eula=true")
                End If

            Else

                File.WriteAllText(ComboBox2.Text & "/eula.txt", "eula=true")

            End If




            Dim thisserv As New FileInfo(ComboBox2.Text & "/minecraft_server." & ComboBox2.Text & ".jar")

            p.StartInfo.CreateNoWindow = True
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardInput = True
            p.StartInfo.RedirectStandardOutput = True
            p.StartInfo.RedirectStandardError = True
            p.StartInfo.FileName = "cmd"
            p.StartInfo.Arguments = "/c @echo off & title SERVEUR MINECRAFT & cd " & thisserv.DirectoryName & " & java -Xms1024M -Xmx" & ComboBox1.Text & "M -jar " & "minecraft_server." & ComboBox2.Text & ".jar" & " nogui"

            p.Start()
            Timer2.Start()
            RichTextBox1.Text = "Le serveur se lance ! Merci de patienter." & vbCrLf

        Else

            If (vServerMinecraft = "") Then

                MsgBox("the server is not selected")
                TextBox1.ReadOnly = True
                TextBox1.Clear()
                Button2.Enabled = False
                Button1.Enabled = True
                ComboBox2.Enabled = True
                ComboBox1.Enabled = True

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

        sound_click()

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
            ComboBox2.Enabled = True
            ComboBox1.Enabled = True

        End If

        If (code = "/stop") Then

            Button2.Enabled = False
            TextBox1.ReadOnly = True
            TextBox1.Clear()

            Timer2.Stop()

            code = ""

            Button1.Enabled = True
            ComboBox2.Enabled = True
            ComboBox1.Enabled = True

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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        Try

            Dim ClsINIcombobox As New ClsINI(LocationAppdata & "\EASYMINESERVER\CONFIG\ConfLink.ini")

            Dim A As String = ComboBox2.Text
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

        sound_click()
        SETTINGS.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        sound_click()
        Process.Start("https://github.com/XsplitS/EASYMINESERVER/issues")

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

        sound_click()
        Try

            Process.Start(ComboBox2.Text & "\server.properties")

        Catch ex As Exception

            MsgBox("Fichier non trouvé, Installer et lancer le serveur en priorité.", MsgBoxStyle.Exclamation)

        End Try

    End Sub

End Class
