Public Class Player
    Private age As String
    Private firstname As String
    Private lastname As String
    Private Gender As String
    Private scores(5) As Integer
    Private totalscore As Integer
    Private positions As String
    Private evaluator As String
    Private Practicedays As String
    Private LastCoach As String
    Private Comments As String

    Public Sub New(age As String, firstname As String, lastname As String, scores() As Integer, totalscore As Integer, positions As String, evaluator As String, practicedays As String, comments As String)
        Me.SetAge(age)
        Me.Firstname1 = firstname
        Me.Lastname1 = lastname
        Me.Scores1 = scores
        Me.Totalscore1 = totalscore
        Me.Positions1 = positions
        Me.Evaluator1 = evaluator
        Me.Practicedays1 = practicedays
        Me.Comments1 = comments
    End Sub
    Public Sub New(age As String, firstname As String, lastname As String, totalscore As Integer, practice As String)
        Me.SetAge(age)
        Me.Firstname1 = firstname
        Me.Lastname1 = lastname
        Me.Totalscore1 = totalscore
        Me.Practicedays1 = Practicedays
    End Sub

    Public Sub New(age As String, gender As String, firstname As String, lastname As String, scores() As Integer, totalscore As Integer, positions As String, evaluator As String, practicedays As String, comments As String)
        Me.age = age
        Me.firstname = firstname
        Me.lastname = lastname
        Me.Gender = gender
        Me.scores = scores
        Me.totalscore = totalscore
        Me.positions = positions
        Me.evaluator = evaluator
        Me.Practicedays = practicedays
        Me.Comments = comments
    End Sub

    Public Function GetAge() As String
        Return age
    End Function

    Public Sub SetAge(value As String)
        age = value
    End Sub

    Public Property Firstname1 As String
        Get
            Return firstname
        End Get
        Set(value As String)
            firstname = value
        End Set
    End Property

    Public Property Lastname1 As String
        Get
            Return lastname
        End Get
        Set(value As String)
            lastname = value
        End Set
    End Property

    Public Property Scores1 As Integer()
        Get
            Return scores
        End Get
        Set(value As Integer())
            scores = value
        End Set
    End Property

    Public Property Totalscore1 As Integer
        Get
            Return totalscore
        End Get
        Set(value As Integer)
            totalscore = value
        End Set
    End Property

    Public Property Positions1 As String
        Get
            Return positions
        End Get
        Set(value As String)
            positions = value
        End Set
    End Property

    Public Property Evaluator1 As String
        Get
            Return evaluator
        End Get
        Set(value As String)
            evaluator = value
        End Set
    End Property

    Public Property Practicedays1 As String
        Get
            Return Practicedays
        End Get
        Set(value As String)
            Practicedays = value
        End Set
    End Property

    Public Property Comments1 As String
        Get
            Return Comments
        End Get
        Set(value As String)
            Comments = value
        End Set
    End Property

    Public Property LastCoach1 As String
        Get
            Return LastCoach
        End Get
        Set(value As String)
            LastCoach = value
        End Set
    End Property

    Public Property Gender1 As String
        Get
            Return Gender
        End Get
        Set(value As String)
            Gender = value
        End Set
    End Property
    Public Function ReturnU18() As ArrayList
        Dim alldata As ArrayList
        alldata = New ArrayList
        alldata.AddRange({age, Gender, lastname, firstname, totalscore, Practicedays, evaluator, Comments})
        Return alldata
    End Function
    Public Function ReturnAll() As ArrayList
        Dim alldata As ArrayList
        alldata = New ArrayList
        alldata.AddRange({age, lastname, firstname, totalscore, Practicedays, evaluator, Comments})
        Return alldata
    End Function
End Class
