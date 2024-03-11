Public Class Country

    Public Property CountryID As String
    Public Property CountryName As String
    Public Property CountryPopulation As Integer
    Public ReadOnly Property CouDAO As CountryDAO

    Public Sub New()
        Me.CouDAO = New CountryDAO
    End Sub

    Public Sub New(id As String)
        Me.CouDAO = New CountryDAO
        Me.CountryID = id
    End Sub

    Public Sub New(id As String, name As String, population As Integer)
        Me.CouDAO = New CountryDAO
        Me.CountryID = id
        Me.CountryName = name
        Me.CountryPopulation = population
    End Sub

    Public Sub ReadAllPersons()
        Me.CouDAO.ReadAll()
    End Sub
    Public Sub ReadPerson()
        Me.CouDAO.Read(Me)
    End Sub

    Public Function InsertPerson() As Integer
        Return Me.CouDAO.Insert(Me)
    End Function

    Public Function UpdatePerson() As Integer
        Return Me.CouDAO.Update(Me)
    End Function

    Public Function DeletePerson() As Integer
        Return Me.CouDAO.Delete(Me)
    End Function

End Class

