Public Class Form1
    Dim ans(30) As Integer
    Dim total As Integer = 0
    Dim i As Integer = 1

    Sub reset()
        Button1.Enabled = True : Button2.Enabled = True : Button3.Enabled = True
        Button4.Enabled = True : Button5.Enabled = True : Button7.Text = "上一題"
        Button7.Tag = "A"
        Label1.ForeColor = Color.Blue

        total = 0
        Array.Clear(ans, 0, UBound(ans))
        i = 1
        Call Q()
    End Sub

    Sub Q()
        If i > 30 Then
            Button1.Enabled = False : Button2.Enabled = False : Button3.Enabled = False
            Button4.Enabled = False : Button5.Enabled = False : Button7.Text = "重測"
            Button7.Tag = "B"
            Label1.ForeColor = Color.OrangeRed

            For j = 1 To 30
                total += ans(j)
            Next


            Label1.Text = total & "/150 分" & vbCrLf
            If total >= 30 And total <= 45 Then
                Label1.Text += "你正承受到適度的壓力，所需要的是情緒上無條件的支持。只要沒有出現異於往常的行為或情緒反應，父母應該可以放心。"
            ElseIf total >= 46 And total <= 60 Then
                Label1.Text += "你正承受到略大的壓力，應該找個疏發情緒的環境。找個人傾訴心裡的話，或是安排一趟開心的旅遊，都是可以考慮的方式"
            ElseIf total >= 61 And total <= 75 Then
                Label1.Text += "你正承受到強大的壓力，並可能已經出現異於往常的行為或情緒反應。你應該考慮帶立即尋求專業的心理諮商服務，以維護身心健全發展。"
            ElseIf total >= 76 Then
                Label1.Text += "你正承受到強大的壓力，內心壓抑強烈的情緒與不安。你應該立即尋求專業的心理諮商服務，以維護你身心健全發展。"
            End If

            Dim _now = Now.ToLongDateString
            Dim _time = Now.ToLongTimeString
            FileOpen(1, "Stress.txt", OpenMode.Append)

            PrintLine(1, "***********壓力檢測**********")
            PrintLine(1, "*" & _now & " " & _time & "*")
            If total < 100 Then
                PrintLine(1, "*          " & total.ToString & "/150分         *")
            Else
                PrintLine(1, "*          " & total.ToString & "/150分        *")
            End If

            PrintLine(1, "*****************************" + vbNewLine)
            FileClose(1)

            '準備將檔案上傳資料庫
            Dim stress_url As String = UrlMaker("stress", GetUserName(), MakeJson(ans), total)
            '呼叫上傳函式
            Try
                HTTP_Upload(stress_url)
            Catch ex As Exception

            End Try
        Else
            Select Case i
                Case 1
                    Label1.Text = "1.某個特定的老師"
                Case 2
                    Label1.Text = "2.學校中的幫派人物"
                Case 3
                    Label1.Text = "3.某個特定的科目"
                Case 4
                    Label1.Text = "4.覺得自己沒有其他同學聰明"
                Case 5
                    Label1.Text = "5.害怕失敗"
                Case 6
                    Label1.Text = "6.沒能入選某個校隊或團體"
                Case 7
                    Label1.Text = "7.擔心被同學愚弄或欺負"
                Case 8
                    Label1.Text = "8.無法達成父母或師長的期望"
                Case 9
                    Label1.Text = "9.擔心將來無法進入好的學校"
                Case 10
                    Label1.Text = "10.擔心自己以後不知從事哪個工作"
                Case 11
                    Label1.Text = "11.擔心父母會離婚或再婚"
                Case 12
                    Label1.Text = "12.被姐妹或兄弟傷害"
                Case 13
                    Label1.Text = "13.其他家庭成員傷害"
                Case 14
                    Label1.Text = "14.沒有足夠的零用錢或生活費"
                Case 15
                    Label1.Text = "15.沒有得到應有的注意"
                Case 16
                    Label1.Text = "16.因缺乏管教而易惹麻煩"
                Case 17
                    Label1.Text = "17.沒有得到充分的關懷與愛"
                Case 18
                    Label1.Text = "18.父母親吵架或打架"
                Case 19
                    Label1.Text = "19.家庭成員的健康狀況欠佳"
                Case 20
                    Label1.Text = "20.自己的健康狀況欠佳"
                Case 21
                    Label1.Text = "21.失去某個要好的朋友"
                Case 22
                    Label1.Text = "22.沒有足夠的朋友"
                Case 23
                    Label1.Text = "23.遭到某個朋友的拒絕"
                Case 24
                    Label1.Text = "24.受到某個朋友的欺騙或背叛"
                Case 25
                    Label1.Text = "25.某個朋友在背後說我壞話"
                Case 26
                    Label1.Text = "26.感覺不被接受或不受歡迎"
                Case 27
                    Label1.Text = "27.父母不喜歡我的某個朋友"
                Case 28
                    Label1.Text = "28.我擔心自己沒有男(女)朋友"
                Case 29
                    Label1.Text = "29.不知如何結交朋友"
                Case 30
                    Label1.Text = "30.不知該如何維護自己的權利"
            End Select
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Q()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ans(i) = 1
        i += 1
        Call Q()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ans(i) = 2
        i += 1
        Call Q()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ans(i) = 3
        i += 1
        Call Q()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ans(i) = 4
        i += 1
        Call Q()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ans(i) = 5
        i += 1
        Call Q()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim r = 0
        If i <= 30 Then r = MsgBox("測驗尚未結束，確定離開?", 1 + 32, "提示")

        If r = 1 Then

            reset()
            Me.Hide()
            Form2.Show()
        ElseIf r = 2 Then
            Exit Sub
        End If

        reset()
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.Tag = "A" Then
            If i > 1 Then
                i -= 1
                Call Q()
            End If
        Else
            reset()
        End If
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form2.Close()
        Try
            Form3.Close()
        Catch ex As System.NullReferenceException

        End Try
    End Sub
End Class
