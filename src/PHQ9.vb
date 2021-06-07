Public Class PHQ9
    Private Sub StressForm2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Q(i)
    End Sub

    Dim ans(9) As Integer
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
        If i > 9 Then
            Btn0p.Enabled = False : Btn1p.Enabled = False : Btn2p.Enabled = False : Btn3p.Enabled = False
            BtnBack.Text = "重測"

            BtnBack.Tag = "B"
            LabelA.ForeColor = Color.OrangeRed

            For j = 1 To 9
                total += ans(j)
            Next
            LabelA.Text = total.ToString & "/27分" & vbCrLf & vbCrLf

            If total <= 4 Then
                LabelA.Text += "極輕微焦慮"
            ElseIf total >= 5 And total <= 9 Then
                LabelA.Text += "輕度焦慮，建議找親友分享，解除心中的焦慮"
            ElseIf total >= 10 And total <= 14 Then
                LabelA.Text += "中度焦慮，建議找身心科醫師協助"
            ElseIf total >= 15 And total <= 19 Then
                LabelA.Text += "中重度焦慮，建議找身心科醫師協助"
            ElseIf total >= 20 Then
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
                    LabelA.Text = "01. 作任何事都覺得沉悶或者根本不想做任何事"
                Case 2
                    LabelA.Text = "02. 情緒低落、抑鬱或絕望"
                Case 3
                    LabelA.Text = "03. 難於入睡；半夜會醒或相反地睡覺時間過多"

                Case 4
                    LabelA.Text = "04. 覺得疲倦或活力不足"

                Case 5
                    LabelA.Text = "05. 胃口極差或進食過量"

                Case 6
                    LabelA.Text = "06. 不喜歡自己，覺得自己做的不好、對自己失望或有負家人的期望"

                Case 7
                    LabelA.Text = "07. 難於集中精神做事，例如看報紙或看電視"

                Case 8
                    LabelA.Text = "08. 其他人反映你行動或說話遲緩；或者相反地，你比平常活動更多，坐立不安、停不下來"

                Case 9
                    LabelA.Text = "09. 想到自己最好去死或自殘"
            End Select
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        Dim r = 0
        If i <= 9 Then r = MsgBox("測驗尚未結束，確定離開?", 1 + 32, "提示")

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
End Class