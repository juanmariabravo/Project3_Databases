Public Class TeamDAO
    Public ReadOnly Property Teams As Collection

    Public Sub New()
        Me.Teams = New Collection
    End Sub

    Public Sub ReadAll()
        Dim te As Team
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Teams ORDER BY TeamID;")
        If col.Count > 0 Then
            For Each aux In col
                te = New Team(Integer.Parse(aux(1).ToString))
                te.ReadTeam()
                Me.Teams.Add(te)
            Next
        End If
    End Sub


    Public Sub Read(ByRef te As Team)
        Dim col As Collection
        Dim colContracts As Collection
        Dim aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Teams WHERE TeamID='" & te.TeamID & "';")
        If col.Count > 0 Then
            For Each aux In col
                te.TeamID = Integer.Parse(aux(1).ToString)
                te.TeamName = aux(2).ToString
                te.TeamCountry = aux(3).ToString
            Next

            colContracts = DBBroker.GetBroker().Read("SELECT * FROM Contracts WHERE team = " & te.TeamID & ";")
            te.Contracts = colContracts

        End If

    End Sub



    Public Function Insert(ByVal te As Team) As Integer
        Return DBBroker.GetBroker().Change("INSERT INTO Teams (TeamID, TeamName, TeamCountry, CreationDate) VALUES ('" & te.TeamID & "', '" & te.TeamName & "', '" & te.TeamCountry & "', STR_TO_DATE('" & te.CreationDate & "','%d/%m/%Y'));")
    End Function

    Public Function Update(ByVal te As Team) As Integer
        Return DBBroker.GetBroker().Change("UPDATE Teams SET TeamName='" & te.TeamName & "', TeamCountry='" & te.TeamCountry & "' WHERE TeamID='" & te.TeamID & "';")
    End Function

    Public Function Delete(ByVal te As Team) As Integer
        Return DBBroker.GetBroker().Change("DELETE FROM Teams WHERE TeamID='" & te.TeamID & "';")
    End Function

    Public Sub Clear()
        Me.Teams.Clear()
    End Sub
End Class
