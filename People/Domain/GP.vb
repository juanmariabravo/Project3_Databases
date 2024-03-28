Public Class GP
    Public Property GPID As Integer
    Public Property GPName As String
    Public Property Countryid As Integer

    Public ReadOnly Property GpDAO As GPDAO

    Public Sub New()
        Me.GpDAO = New GPDAO
    End Sub

    Public Sub New(ByVal id As Integer, ByVal name As String, ByVal country As Integer)
        Me.GPID = id
        Me.GPName = name
        Me.Countryid = country

        Me.GpDAO = New GPDAO
    End Sub

    Public Sub ReadAllGPs()
        Me.GpDAO.ReadAll()
    End Sub

    Public Sub ReadGP()
        Me.GpDAO.Read(Me)
    End Sub

    Public Function InsertGP() As Integer
        Return Me.GpDAO.Insert(Me)
    End Function

    Public Function UpdateGP() As Integer
        Return Me.GpDAO.Update(Me)
    End Function

    Public Function DeleteGP() As Integer
        Return Me.GpDAO.Delete(Me)
    End Function
End Class
