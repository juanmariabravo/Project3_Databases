Public Class Person

    Public Property PersonID As String
    Public Property PersonName As String
    Public ReadOnly Property PerDAO As PersonDAO

    Public Sub New()
        Me.PerDAO = New PersonDAO
    End Sub

    Public Sub New(id As String)
        Me.PerDAO = New PersonDAO
        Me.PersonID = id
    End Sub

    Public Sub ReadAllPersons()
        Me.PerDAO.ReadAll()
    End Sub
    Public Sub ReadPerson()
        Me.PerDAO.Read(Me)
    End Sub

    Public Function InsertPerson() As Integer
        Return Me.PerDAO.Insert(Me)
    End Function

    Public Function UpdatePerson() As Integer
        Return Me.PerDAO.Update(Me)
    End Function

    Public Function DeletePerson() As Integer
        Return Me.PerDAO.Delete(Me)
    End Function

End Class

