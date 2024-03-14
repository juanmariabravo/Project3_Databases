Public Class Country

    Public Property CountryID As String
    Public Property CountryName As String
    Public ReadOnly Property CouDAO As CountryDAO

    Public Sub New()
        Me.CouDAO = New CountryDAO
    End Sub

    Public Sub New(id As String)
        Me.CouDAO = New CountryDAO
        Me.CountryID = id
    End Sub

    Public Sub ReadAllCountries()
        Me.CouDAO.ReadAll()
    End Sub
    Public Sub ReadCountry()
        Me.CouDAO.Read(Me)
    End Sub

    Public Function InsertCountry() As Integer
        Return Me.CouDAO.Insert(Me)
    End Function

    Public Function UpdateCountry() As Integer
        Return Me.CouDAO.Update(Me)
    End Function

    Public Function DeleteCountry() As Integer
        Return Me.CouDAO.Delete(Me)
    End Function

End Class

