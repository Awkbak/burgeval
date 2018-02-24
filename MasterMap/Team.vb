Public Class Team
    Private Coach As String
    Private Players As ArrayList
    Private TotalScore As Integer

    Public Sub New(coach As String)
        Me.Coach1 = coach
        Players = New ArrayList
    End Sub

    Public Property Coach1 As String
        Get
            Return Coach
        End Get
        Set(value As String)
            Coach = value
        End Set
    End Property

    Public Property TotalScore1 As Integer
        Get
            Return TotalScore
        End Get
        Set(value As Integer)
            TotalScore = value
        End Set
    End Property

    Public Sub AddPlayer(ByVal P As Player)
        Players.Add(P)
        TotalScore = TotalScore + P.Totalscore1
    End Sub

    Public Function GetPlayerList() As ArrayList
        Return Players
    End Function

End Class
