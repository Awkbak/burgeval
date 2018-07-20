Imports Microsoft.VisualBasic.FileIO
Imports Microsoft.VisualBasic.ApplicationServices
Public Class Form1
    Dim U11GFile As String = Application.StartupPath & "\" & "U11G.csv"

    Dim U11GList As ArrayList
    Dim afile As TextFieldParser
    Dim CoachList1 As ArrayList

    Dim CoachList2 As ArrayList
    Dim CoachIndex As Integer
    Dim CoachCounter As Integer
    Private SavePath As String = Application.StartupPath & "\" & "U11GDone.csv"
    Dim CoachPickup As Dictionary(Of Integer, Integer)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Function Shuffle1(items As ArrayList) As ArrayList
        Dim rnd As New Random()
        Dim j As Int32
        Dim temp As String

        For n As Int32 = items.Count - 1 To 0 Step -1
            j = rnd.Next(0, n + 1)
            ' Swap them.
            temp = items(n)
            items(n) = items(j)
            items(j) = temp
        Next n

        Return items
    End Function
    Public Function Shuffle2(items As Dictionary(Of Integer, Integer)) As Dictionary(Of Integer, Integer)
        Dim rnd As New Random()
        Dim newdict As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)
        Dim j As Int32 = 0
        While items.Count > 0
            j = rnd.Next(0, items.Count)

            newdict.Add(items.Keys.ElementAt(j), items.Item(items.Keys.ElementAt(j)))
            items.Remove(items.Keys.ElementAt(j))
        End While
        Return newdict
    End Function
    Private Sub GetPlayers()
        afile = New TextFieldParser(U11GFile)
        afile.TextFieldType = FieldType.Delimited
        afile.Delimiters = New String() {","}
        afile.HasFieldsEnclosedInQuotes = True
        U11GList = New ArrayList()
        Dim CurrPlayer As Player
        Dim Curr(13) As String
        Dim ouch(5) As Integer
        Do While Not afile.EndOfData
            Try
                Curr = afile.ReadFields
                ouch = {Integer.Parse(Curr(3)), Integer.Parse(Curr(4)), Integer.Parse(Curr(5)), Integer.Parse(Curr(6)), Integer.Parse(Curr(7))}
                CurrPlayer = New Player(Curr(0), Curr(1), Curr(2), ouch, Integer.Parse(Curr(8)), Curr(9), Curr(10), Curr(11), Curr(12))
                U11GList.Add(CurrPlayer)
            Catch ex As FileIO.MalformedLineException
                MsgBox("Unexpected Error Occured, Contact Admin for support")
                Stop
            End Try
        Loop
        afile.Close()
    End Sub
    Private Sub GetPlayersU18()
        afile = New TextFieldParser(U11GFile)
        afile.TextFieldType = FieldType.Delimited
        afile.Delimiters = New String() {","}
        afile.HasFieldsEnclosedInQuotes = True
        U11GList = New ArrayList()
        Dim CurrPlayer As Player
        Dim Curr(14) As String
        Dim ouch(5) As Integer
        Do While Not afile.EndOfData
            Try
                Curr = afile.ReadFields
                ouch = {Integer.Parse(Curr(4)), Integer.Parse(Curr(5)), Integer.Parse(Curr(6)), Integer.Parse(Curr(7)), Integer.Parse(Curr(8))}
                CurrPlayer = New Player(Curr(0), Curr(1), Curr(2), Curr(3), ouch, Integer.Parse(Curr(9)), Curr(10), Curr(11), Curr(12), Curr(13))
                U11GList.Add(CurrPlayer)
            Catch ex As FileIO.MalformedLineException
                MsgBox("Unexpected Error Occured, Contact Admin for support")
                Stop
            End Try
        Loop
        afile.Close()
    End Sub
    Private Sub GetCoachList(ByVal s As String)
        afile = New TextFieldParser(s)
        afile.TextFieldType = FieldType.Delimited
        afile.Delimiters = New String() {","}
        afile.HasFieldsEnclosedInQuotes = True
        Dim read(1) As String
        Do While Not afile.EndOfData
            Try
                read = afile.ReadFields
                CoachList1.Add(read(0))
            Catch ex As Exception
                MsgBox("Unexpected Error Occured, Contact Admin for support")
                Stop
            End Try
        Loop
        afile.Close()
    End Sub
    Private Function ChooseNextCoach(ByVal ind As Integer) As Integer
        If ind + 1 = CoachList2.Count Then
            If CType(CoachList2(ind), Team).TotalScore1 >= CType(CoachList2(0), Team).TotalScore1 Then
                Return 0
            Else
                Return ChooseNextCoach(0)
            End If
        Else
            If CType(CoachList2(ind), Team).TotalScore1 >= CType(CoachList2(ind + 1), Team).TotalScore1 Then
                Return ind + 1
            Else
                Return ChooseNextCoach(ind + 1)
            End If
        End If
    End Function
    Private Function getAllScores() As Dictionary(Of Integer, Integer)
        Dim dicall As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)
        For x As Integer = 0 To CoachList2.Count - 1
            Dim T As Team = CoachList2(x)
            dicall.Add(x, T.TotalScore1)
        Next
        Dim sorted = From i In dicall Order By i.Value Ascending Select i
        Dim dicone As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)
        For Each n In sorted
            dicone.Add(n.Key, n.Value)
        Next
        Dim val As Integer = 0
        Dim onatrend As Boolean = False
        Dim dictemp As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)
        Dim dicdusto As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)

        Dim c As Integer = 0
        dicdusto.Add(dicone.ElementAt(0).Key, dicone.ElementAt(0).Value)
        For c = 1 To dicone.Count + 1
            Dim current As KeyValuePair(Of Integer, Integer)
            If (c < dicone.Count) Then
                current = dicone.ElementAt(c)
            End If
            If c >= dicone.Count OrElse dicdusto.ElementAt(0).Value <> current.Value Then
                dicdusto = Shuffle2(dicdusto)
                For Each m In dicdusto
                    dictemp.Add(m.Key, m.Value)
                Next
                dicdusto.Clear()
            End If
            If c < dicone.Count Then
                dicdusto.Add(current.Key, current.Value)
            End If
        Next c
        Return dictemp
    End Function

    Private Sub btn_lockin_Click(sender As Object, e As EventArgs) Handles btn_lockin.Click

        Dim filename As String = Application.StartupPath & "\" & CoachList1(CoachIndex) & ".csv"

        Dim selectnum As Integer = lst_players_available.SelectedIndices(0)
        Dim sumthisup As ListViewItem = lst_players_available.Items(selectnum)

        Dim a As String = ""
        Dim b As String = ""
        Dim c As String = ""
        Dim d As Integer = 0
        Dim ee As String = ""
        Dim thick As String
        If box_divisions.SelectedItem.ToString = "U18" Then
            a = sumthisup.SubItems(0).Text
            b = sumthisup.SubItems(2).Text
            c = sumthisup.SubItems(3).Text
            d = Integer.Parse(sumthisup.SubItems(4).Text)
            ee = sumthisup.SubItems(5).Text
            thick = MsgBox("Practice Days: " & ee & " Are you sure?", MsgBoxStyle.YesNo)
        Else
            a = sumthisup.SubItems(0).Text
            b = sumthisup.SubItems(1).Text
            c = sumthisup.SubItems(2).Text
            d = Integer.Parse(sumthisup.SubItems(3).Text)
            ee = sumthisup.SubItems(4).Text
            thick = MsgBox("Practice Days: " & ee & " Are you sure?", MsgBoxStyle.YesNo)
        End If
        If thick = vbYes Then
            lst_players_available.Items.RemoveAt(selectnum)
            Dim PL As Player = (New Player(a, b, c, d, ee))
            CreateCSVFile(filename, PL.ReturnAll())
            CType(CoachList2(CoachIndex), Team).AddPlayer(PL)

            If CoachCounter = CoachList2.Count - 1 Then
                CoachCounter = 0
                CoachPickup = getAllScores()
            Else
                CoachCounter = CoachCounter + 1
            End If
            CoachIndex = CoachPickup.Keys.ElementAt(CoachCounter)
            lbl_picking.Text = "Now Picking: " & CType(CoachList2(CoachIndex), Team).Coach1
            Dim Textne As String = ""
            Dim txt2 As String = ""
            For Each x As Team In CoachList2
                Textne = Textne & x.Coach1 & ": " & x.TotalScore1 & vbNewLine
                txt2 = txt2 & "Players: " & x.GetPlayerList.Count & vbNewLine
            Next
            lbl_scores.Text = Textne
            lbl_plycount.Text = txt2
        End If

    End Sub

    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        lst_players_available.Clear()
        U11GFile = Application.StartupPath & "\" & box_divisions.SelectedItem.ToString & ".csv"
        CoachList1 = New ArrayList
        CoachList2 = New ArrayList
        CoachIndex = 0
        CoachCounter = 0
        Dim Coachlistpath As String = Application.StartupPath & "\" & box_divisions.SelectedItem.ToString & "coachlist.csv"
        GetCoachList(Coachlistpath)
        CoachList1 = Shuffle1(CoachList1)
        For Each coach As String In CoachList1
            Dim tempteam As Team = New Team(coach)
            CoachList2.Add(tempteam)
        Next


        If box_divisions.SelectedItem.ToString = "U18" Then
            GetPlayersU18()
            lst_players_available.Columns.Add("Age", 60, HorizontalAlignment.Left)
            lst_players_available.Columns.Add("Gndr", 40, HorizontalAlignment.Left)
            lst_players_available.Columns.Add("First", 90, HorizontalAlignment.Left)
            lst_players_available.Columns.Add("Last", 90, HorizontalAlignment.Left)
            lst_players_available.Columns.Add("Total", 40, HorizontalAlignment.Left)
            lst_players_available.Columns.Add("Days", 100, HorizontalAlignment.Left)
            lst_players_available.Columns.Add("Last Season Coach", 90, HorizontalAlignment.Left)
            lst_players_available.Columns.Add("Comments", 150, HorizontalAlignment.Left)
        Else
            GetPlayers()
            lst_players_available.Columns.Add("Age", 60, HorizontalAlignment.Left)
            lst_players_available.Columns.Add("First", 90, HorizontalAlignment.Left)
            lst_players_available.Columns.Add("Last", 90, HorizontalAlignment.Left)
            lst_players_available.Columns.Add("Total", 40, HorizontalAlignment.Left)
            lst_players_available.Columns.Add("Days", 100, HorizontalAlignment.Left)
            lst_players_available.Columns.Add("Last Season Coach", 90, HorizontalAlignment.Left)
            lst_players_available.Columns.Add("Comments", 150, HorizontalAlignment.Left)
        End If
        Dim j As Integer = 0
        Dim masterlist(U11GList.Count - 1) As ListViewItem

        For j = 0 To U11GList.Count - 1
            Dim nameme As String = ""
            nameme = nameme & CType(U11GList(j), Player).Lastname1 & " " & CType(U11GList(j), Player).Firstname1
            ''lst_select.Items.Add(nameme)
            masterlist(j) = New ListViewItem
            Dim xx As Integer = 0
            If box_divisions.SelectedItem.ToString = "U18" Then
                For Each i As Object In CType(U11GList(j), Player).ReturnU18
                    If xx = 0 Then
                        masterlist(j).SubItems(0).Text = i
                        xx = xx + 1
                    Else
                        masterlist(j).SubItems.Add("" & i)
                    End If
                Next i
            Else
                For Each i As Object In CType(U11GList(j), Player).ReturnAll
                    If xx = 0 Then
                        masterlist(j).SubItems(0).Text = i
                        xx = xx + 1
                    Else
                        masterlist(j).SubItems.Add("" & i)
                    End If
                Next i
            End If

        Next j
        lst_players_available.Items.AddRange(masterlist)
        If box_divisions.SelectedItem.ToString = "U18" Then
            lst_players_available.ListViewItemSorter = New ListViewItemComparer(4, SortOrder.Descending)
            lst_players_available.ListViewItemSorter = New ListViewItemComparer(1, SortOrder.Ascending)
        Else
            lst_players_available.ListViewItemSorter = New ListViewItemComparer(3, SortOrder.Descending)
        End If
        lst_players_available.Sort()

        CoachPickup = getAllScores()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim Textne As String = ""
        Dim txt2 As String = ""
        For Each x As Team In CoachList2
            Textne = Textne & x.Coach1 & ": " & x.TotalScore1 & vbNewLine
            txt2 = txt2 & "Players: " & x.GetPlayerList.Count & vbNewLine
        Next
        lbl_scores.Text = Textne
        lbl_plycount.Text = txt2
        CoachIndex = CoachPickup.Keys.ElementAt(CoachCounter)
        lbl_picking.Text = "Now Picking: " & CType(CoachList2(CoachPickup.Keys.ElementAt(CoachCounter)), Team).Coach1
    End Sub

    Private Sub btn_Finish_Click(sender As Object, e As EventArgs) Handles btn_Finish.Click
        'Reminder for you to get name from Dropdown list'
        SavePath = Application.StartupPath & "\" & box_divisions.SelectedItem.ToString & "AllDone.csv"
        For Each x As Team In CoachList2
            Dim xx As ArrayList = New ArrayList
            xx.Add(x.Coach1)
            xx.Add(x.TotalScore1)
            xx.Add(x.GetPlayerList.Count)
            CreateCSVFile(SavePath, xx)
            For Each P As Player In x.GetPlayerList
                Dim tempVals As ArrayList = P.ReturnAll()
                CreateCSVFile(SavePath, P.ReturnAll())
            Next
        Next
    End Sub
    Private Sub CreateCSVFile(ByVal IDPath As String, ByVal Job As ArrayList)
        Try
            Dim stLIne As String = ""
            If IO.File.Exists(IDPath) Then
                Dim objWriter As IO.StreamWriter = IO.File.AppendText(IDPath)
                For Each z In Job
                    objWriter.Write(z & ",")
                Next
                objWriter.Write(stLIne)
                objWriter.Write(Environment.NewLine)
                objWriter.Close()
            Else
                Dim objWriter As New IO.StreamWriter(IDPath)
                For Each z In Job
                    objWriter.Write(z & ",")
                Next
                objWriter.Write(stLIne)
                objWriter.Write(Environment.NewLine)
                objWriter.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
