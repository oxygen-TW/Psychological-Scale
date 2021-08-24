Public Class BAI
    Private Sub StressForm2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Q(i)
    End Sub

    Dim ans(21) As Integer
    Dim total As Integer = 0
    Dim i As Integer = 1
    'Dim labelA As New Label

    Sub Reset()
        Btn0p.Enabled = True : Btn1p.Enabled = True : Btn2p.Enabled = True : Btn3p.Enabled = True
        BtnBack.Text = "上一題"
        BtnBack.Tag = "A"
        LabelA.ForeColor = Color.ForestGreen

        total = 0
        Array.Clear(ans, 0, UBound(ans))
        i = 1
        Call Q(i)
    End Sub


    Sub Q(ByVal i)
        If i > 21 Then
            Btn0p.Enabled = False : Btn1p.Enabled = False : Btn2p.Enabled = False : Btn3p.Enabled = False
            BtnBack.Text = "重測"

            BtnBack.Tag = "B"
            LabelA.ForeColor = Color.OrangeRed

            For j = 1 To 21
                total += ans(j)
            Next
            LabelA.Text = total.ToString & "/63分" & vbCrLf & vbCrLf

            If total <= 21 Then
                LabelA.Text += "輕微焦慮"
            ElseIf total >= 22 And total <= 35 Then
                LabelA.Text += "中度焦慮"
            ElseIf total >= 36 Then
                LabelA.Text += "重度焦慮，建議找身心科醫師協助"
            End If

            Dim _now = Now.ToLongDateString
            Dim _time = Now.ToLongTimeString
            FileOpen(1, "Stress-Adult.txt", OpenMode.Append)

            PrintLine(1, "***********一般壓力檢測**********")
            PrintLine(1, "*" & _now & " " & _time & "*")
            PrintLine(1, "*          " & total.ToString & "/12分          *")
            PrintLine(1, "*****************************" + vbNewLine)
            FileClose(1)

        Else
            Select Case i
                Case 1
                    LabelA.Text = "01. 噁心或身體刺痛"

                Case 2
                    LabelA.Text = "02. 身體感覺炎熱"

                Case 3
                    LabelA.Text = "03. 不自主抖腳"

                Case 4
                    LabelA.Text = "04. 感覺難以放鬆"

                Case 5
                    LabelA.Text = "05. 擔憂不好的事發生"

                Case 6
                    LabelA.Text = "06. 頭暈或站不穩"

                Case 7
                    LabelA.Text = "07. 心悸或心跳很快"

                Case 8
                    LabelA.Text = "08. 感覺坐立難安"

                Case 9
                    LabelA.Text = "09. 感覺恐懼或害怕"

                Case 10
                    LabelA.Text = "10. 感覺神經緊繃感/緊張"

                Case 11
                    LabelA.Text = "11. 覺得窒息"

                Case 12
                    LabelA.Text = "12. 不自主手抖"

                Case 13
                    LabelA.Text = "13. 感覺身體不穩(Shaky / unsteady)"


                Case 14
                    LabelA.Text = "14. 擔心失去控制"

                Case 15
                    LabelA.Text = "15. 呼吸困難"

                Case 16
                    LabelA.Text = "16. 擔心即將死亡"

                Case 17
                    LabelA.Text = "17. 感到害怕"

                Case 18
                    LabelA.Text = "18. 消化不良"

                Case 19
                    LabelA.Text = "19. 昏倒/站不穩"

                Case 20
                    LabelA.Text = "20. 面色潮紅"

                Case 21
                    LabelA.Text = "21. 出汗或冒冷汗"
            End Select
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        Dim r = 0
        If i <= 21 Then r = MsgBox("測驗尚未結束，確定離開?", 1 + 32, "提示")

        If r = 1 Then
            Reset()
            Hide()
            UserMenu.Show()
        ElseIf r = 2 Then
            Exit Sub
        End If

        Reset()
        Me.Hide()
        UserMenu.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        If BtnBack.Tag = "A" Then
            If i > 1 Then
                i -= 1
                Call Q(i)
            End If
        Else
            Reset()
        End If
    End Sub

    Private Sub StressForm2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        UserMenu.Close()
        Try
            StressForm1.Close()
            DepressionForm.Close()
        Catch ex As System.NullReferenceException

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn0p.Click
        ans(i) = 0
        i += 1
        Call Q(i)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn1p.Click
        ans(i) = 1
        i += 1
        Call Q(i)
    End Sub

    Private Sub Btn2p_Click(sender As Object, e As EventArgs) Handles Btn2p.Click
        ans(i) = 2
        i += 1
        Call Q(i)
    End Sub

    Private Sub Btn3p_Click(sender As Object, e As EventArgs) Handles Btn3p.Click
        ans(i) = 3
        i += 1
        Call Q(i)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        '開啟資料網頁
        System.Diagnostics.Process.Start（"https://res.cloudinary.com/dpmykpsih/image/upload/great-plains-health-site-358/media/1087/anxiety.pdf"）
    End Sub
End Class