Public Class StressForm2
    Private Sub StressForm2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Q(i)
    End Sub

    Dim ans(12) As Integer
    Dim total As Integer = 0
    Dim i As Integer = 1
    'Dim labelA As New Label

    Sub Reset()
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
        If i > 12 Then
            Button1.Enabled = False : Button2.Enabled = False
            Button7.Text = "重測"

            Button7.Tag = "B"
            LabelA.ForeColor = Color.OrangeRed

            For j = 1 To 12
                total += ans(j)
            Next
            LabelA.Text = total.ToString & "/12分" & vbCrLf & vbCrLf

            If total <= 3 Then
                LabelA.Text += "您的壓力指數還在能負荷的範圍"
            ElseIf total >= 4 And total <= 5 Then
                LabelA.Text += "壓力滿困擾您，雖能勉強應付，但必需認真學習壓力管理了，同時多與良師益友聊一聊。"
            ElseIf total >= 6 And total <= 8 Then
                LabelA.Text += "您的壓力很大，趕快去看心理衛生專業人員，接受系統性的心理治療。"
            ElseIf total >= 9 Then
                LabelA.Text += "您的壓力已很嚴重，應該看精神專科醫師，依醫師處方用藥物治療與心理治療，幫忙您的生活趕快恢復正常軌道。"
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
                    LabelA.Text = "01. 您最近是否經常感到緊張，覺得工作總是做不完？"
                Case 2
                    LabelA.Text = "02. 您最近是否老是睡不好，常常失眠或睡眠品質不佳？"
                Case 3
                    LabelA.Text = "03. 您最近是否經常有情緒低落、焦慮、煩躁的情況？"

                Case 4
                    LabelA.Text = "04. 您最近是否經常忘東忘西、變得很健忘？"

                Case 5
                    LabelA.Text = "05. 您最近是否經常覺得胃口不好？或胃口特別好？"

                Case 6
                    LabelA.Text = "06. 您最近六個月內是否生病不只一次了？"

                Case 7
                    LabelA.Text = "07. 您最近是否經常覺得很累，假日都在睡覺？"

                Case 8
                    LabelA.Text = "08. 您最近是否經常覺得頭痛、腰痠背痛？"

                Case 9
                    LabelA.Text = "09. 您最近是否經常意見和別人不同？"

                Case 10
                    LabelA.Text = "10. 您最近是否注意力經常難以集中？"

                Case 11
                    LabelA.Text = "11. 您最近是否經常覺得未來充滿不確定感？恐懼感？"

                Case 12
                    LabelA.Text = "12. 有人說您最近氣色不太好嗎？"

            End Select


        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim r = 0
        If i <= 12 Then r = MsgBox("測驗尚未結束，確定離開?", 1 + 32, "提示")

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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.Tag = "A" Then
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