Imports System.Net
Imports System.IO

Public Class About

    Dim download As New WebClient

    Private Sub About_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        sound_click()
        FormEasyMineServer.Show()
        Me.Hide()
        e.Cancel = True

    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label3.Text = FormEasyMineServer.maj

        download.CachePolicy = New System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore)
        download.Headers.Clear()

    End Sub
End Class