Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Environment

Module Tools
    Public Function GetAppData()
        Return GetFolderPath(SpecialFolder.ApplicationData)
    End Function

    Public Function GetUserName()
        Dim appData As String = GetAppData()
        FileOpen(1, appData + "\Adolescent-Emotion-Scale\config.ini", OpenMode.Input)
        Dim UserName As String = LineInput(1)
        FileClose(1)
        Return UserName
    End Function

    Public Function HTTP_Upload(ByVal url)
        Dim webClient As New Net.WebClient
        Dim result As String = webClient.DownloadString(url)
        Return result
    End Function

    Public Function MakeJson(ByVal data)
        Dim json_data As String = JsonConvert.SerializeObject(data)
        'Console.WriteLine(json_data)
        Return json_data
    End Function

    Public Function UrlMaker(ByVal Mode, ByVal UserName, ByVal data, ByVal score)
        Dim url As String = "http://oxygenshome.ddns.net/tools/Emotion-Scale/api.php?"
        url += "key=appleisatypeoffruit"
        url += "&name='" & UserName & "'"
        url += "&mode=" & Mode
        url += "&score=" & score
        url += "&data='" & data & "'"
        'Console.WriteLine(url)
        Return url
    End Function
End Module
