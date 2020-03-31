Public Class DepressionForm
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Q(i)
    End Sub

    Dim ans(20) As Integer
    Dim total As Integer = 0
    Dim i As Integer = 1
    'Dim labelA As New Label

    Sub reset()
        Button1.Enabled = True : Button2.Enabled = True
        Button7.Text = "上一題"
        Button7.Tag = "A"
        LabelA.ForeColor = Color.ForestGreen

        total = 0
        Array.Clear(ans, 0, UBound(ans))
        i = 1
        Call Q(i)
    End Sub


    Sub Q(ByVal i)
        If i > 20 Then
            Button1.Enabled = False : Button2.Enabled = False
            Button7.Text = "重測"

            Button7.Tag = "B"
            LabelA.ForeColor = Color.OrangeRed

            For j = 1 To 20
                total += ans(j)
            Next
            LabelA.Text = total.ToString & "/20分" & vbCrLf & vbCrLf

            If total < 6 Then
                LabelA.Text += "最近心情狀態很好，是否過得輕鬆自在呢? 續保持這種好心情吧!"
            ElseIf total >= 6 And total <= 12 Then
                LabelA.Text += "最近情緒起伏不定，多多做些自己喜歡的事，多運動和深呼吸，來維持自己的好心情!"
            ElseIf total > 12 Then
                LabelA.Text += "憂鬱程度頗高喔，是不是有什麼事困擾著你(妳)? 可以找朋友聊天或尋求專業協助來解決這個問題。"
            End If

            Dim _now = Now.ToLongDateString
            Dim _time = Now.ToLongTimeString
            FileOpen(1, "Depression.txt", OpenMode.Append)

            PrintLine(1, "***********憂鬱檢測**********")
            PrintLine(1, "*" & _now & " " & _time & "*")
            PrintLine(1, "*          " & total.ToString & "/20分          *")
            PrintLine(1, "*****************************" + vbNewLine)
            FileClose(1)

            '準備將檔案上傳資料庫
            Dim stress_url As String = UrlMaker("depression", GetUserName(), MakeJson(ans), total)
            '呼叫上傳函式
            Try
                HTTP_Upload(stress_url)
            Catch ex As Exception

            End Try
        Else
            Select Case i
                Case 1
                    LabelA.Text = "01. 我覺得現在比以前容易失去耐心"
                Case 2
                    LabelA.Text = "02. 我比平常更容易煩躁"
                Case 3
                    LabelA.Text = "03. 我想離開目前的生活環境"

                Case 4
                    LabelA.Text = "04. 我變得比以前容易生氣"

                Case 5
                    LabelA.Text = "05. 我心情變得很不好"

                Case 6
                    LabelA.Text = "06. 我變得整天懶洋洋、無精打采"

                Case 7
                    LabelA.Text = "07. 我覺得身體不舒服"

                Case 8
                    LabelA.Text = "08. 我常覺得胸悶"

                Case 9
                    LabelA.Text = "09. 最近大多數時候我覺得全身無力"

                Case 10
                    LabelA.Text = "10. 我變得睡眠不安寧，很容易失眠或驚醒"

                Case 11
                    LabelA.Text = "11. 我變得很不想上學"

                Case 12
                    LabelA.Text = "12. 我變得對許多事都失去興趣"

                Case 13
                    LabelA.Text = "13. 我變得坐立不安，靜不下來"

                Case 14
                    LabelA.Text = "14. 我變得只想一個人獨處"

                Case 15
                    LabelA.Text = "15. 我變得什麼事都不想做"

                Case 16
                    LabelA.Text = "16. 無論我做什麼都不會讓我變得更好"

                Case 17
                    LabelA.Text = "17. 我覺得自己很差勁"

                Case 18
                    LabelA.Text = "18. 我變得沒有辦法集中注意力"

                Case 19
                    LabelA.Text = "19. 我對自己很失望"

                Case 20
                    LabelA.Text = "20. 我想要消失不見"
            End Select


        End If
    End Sub





    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim r = 0
        If i <= 20 Then r = MsgBox("測驗尚未結束，確定離開?", 1 + 32, "提示")

        If r = 1 Then
            reset()
            Hide()
            UserMenu.Show()
        ElseIf r = 2 Then
            Exit Sub
        End If

        reset()
        Me.Hide()
        UserMenu.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.Tag = "A" Then
            If i > 1 Then
                i -= 1
                Call Q(i)
            End If
        Else
            reset()
        End If
    End Sub

    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        UserMenu.Close()
        Try
            StressForm1.Close()
            StressForm2.Close()
        Catch ex As System.NullReferenceException

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ans(i) = 1
        i += 1
        Call Q(i)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ans(i) = 0
        i += 1
        Call Q(i)
    End Sub
End Class
