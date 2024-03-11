Public Class Country

    Public Property PersonID As String
    Public Property PersonName As String
    Public ReadOnly Property PerDAO As CountryDAO

    Public Sub New()
        Me.PerDAO = New CountryDAO
    End Sub

    Public Sub New(id As String)
        Me.PerDAO = New CountryDAO
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

