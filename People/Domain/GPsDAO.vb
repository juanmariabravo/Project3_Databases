Public Class GPDAO
    Public ReadOnly Property GPs As Collection

    Public Sub New()
        Me.GPs = New Collection
    End Sub

    Public Sub ReadAll()
        Dim gp As GP
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM GPs ORDER BY GPID;")



        If col.Count > 0 Then
            For Each aux In col
                gp = New GP(Integer.Parse(aux(1).ToString), aux(2).ToString, Integer.Parse(aux(3).ToString))
                gp.ReadGP()
                Me.GPs.Add(gp)
            Next
        End If
    End Sub


    Public Sub Read(ByRef gp As GP)
        Dim col As Collection
        Dim aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM GPs WHERE GPID='" & gp.GPID & "';")

        If col.Count > 0 Then
            For Each aux In col
                gp.GPName = aux(2).ToString
                gp.Countryid = Integer.Parse(aux(3).ToString)
            Next

        End If
    End Sub


    Public Function Insert(ByVal gp As GP) As Integer
        Return DBBroker.GetBroker().Change("INSERT INTO GPs (GPID, GPName, GPCountry) VALUES ('" & gp.GPID & "', '" & gp.GPName & "', '" & gp.Countryid & "');")
    End Function

    Public Function Update(ByVal gp As GP) As Integer
        Return DBBroker.GetBroker().Change("UPDATE GPs SET GPName='" & gp.GPName & "', GPCountry='" & gp.Countryid & "' WHERE GPID='" & gp.GPID & "';")
    End Function

    Public Function Delete(ByVal gp As GP) As Integer
        Return DBBroker.GetBroker().Change("DELETE FROM GPs WHERE GPID='" & gp.GPID & "';")
    End Function

    Public Sub Clear()
        Me.GPs.Clear()
    End Sub
End Class
