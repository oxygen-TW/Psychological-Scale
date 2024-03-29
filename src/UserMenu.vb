﻿

Public Class UserMenu

    Private Sub Registration()

        ' Get the path to the Application Data folder from <tools.GetAppData>
        Dim appData = GetAppData()
        '檢查組態路徑是否存在
        If (Not System.IO.Directory.Exists(appData + "\Emotion-Scale")) Then
            IO.Directory.CreateDirectory(appData + "\Emotion-Scale")
            'Console.WriteLine("Not Found")

            FileOpen(1, appData + "\Emotion-Scale\config.ini", OpenMode.Output)
            PrintLine(1, Nothing)
            FileClose(1)
        Else
            'Console.WriteLine("Found")
        End If

        '取得使用者組態
        Dim configText As String = GetUserName()

        If configText = "" Then
            Dim UserName As String = Nothing
            Do
                UserName = InputBox("請問你叫什麼名字呢?", "", "Your name")
                If UserName = "" Then
                    Application.Exit()
                End If
            Loop While UserName = "Your name"
            Call WriteConfigFile(UserName) '呼叫寫檔
        End If
    End Sub

    Shared Sub WriteConfigFile(ByVal UserName)
        Dim appData = GetAppData()
        If UserName Is Nothing Then
            Throw New ArgumentNullException(NameOf(UserName))
        End If

        FileOpen(1, appData + "\Adolescent-Emotion-Scale\config.ini", OpenMode.Output)
        PrintLine(1, UserName)
        FileClose(1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        StressForm1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        DepressionForm.Show()
    End Sub

    Private Sub ButtonStreess2_Click(sender As Object, e As EventArgs) Handles ButtonStreess2.Click
        Me.Hide()
        PHQ9.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        'MsgBox("青少年壓力量表為聯合心理諮商所、緯恩整合行銷版權所有!" & vbCrLf & "憂鬱量表為董氏基金會版權所有!" & vbCrLf & "氧氣工作室僅將他做成小程式，並不擁有量表版權 " _
        '   & vbCrLf & "一般壓力量表為衛生福利部國民健康署版權所有" & vbCrLf & vbCrLf & "使用本程式即同意我們收集數據進行分析!", 0 + 48, "版權聲明")

        'Call Registration()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        PHQ9.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        BAI.Show()
    End Sub
End Class