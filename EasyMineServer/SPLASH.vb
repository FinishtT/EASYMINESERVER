Imports System.IO
Imports System.Net

Public Class SPLASH

    Dim download As New WebClient

    Private Sub SPLASH_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Label3.Text = "V" & FormEasyMineServer.maj

        Timer1.Start()

        download.CachePolicy = New System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore)
        download.Headers.Clear()

    End Sub

    Private Async Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label1.Text = "LOADING."
        Await Task.Delay(100)
        Label1.Text = "LOADING.."
        Await Task.Delay(100)
        Label1.Text = "LOADING..."

    End Sub

    Private Sub SPLASH_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Timer1.Stop()

    End Sub

    Private Sub SPLASH_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Timer1.Stop()

    End Sub

End Class
