﻿Public Class TeamDAO
    Public ReadOnly Property Teams As Collection

    Public Sub New()
        Me.Teams = New Collection
    End Sub

    Public Sub ReadAll()
        Dim te As Team
        Dim col, contractsRead, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Teams ORDER BY TeamID;")
        If col.Count > 0 Then
            For Each aux In col
                'For each team, we read its contracts, and add them to the team
                contractsRead = DBBroker.GetBroker().Read("SELECT * FROM Contracts c WHERE c.TeamID = " & aux(1).ToString & ";")
                te = New Team(Integer.Parse(aux(1).ToString), aux(2).ToString, Integer.Parse(aux(3).ToString), Date.Parse(aux(4).ToString), contractsRead)
                te.ReadTeam()
                Me.Teams.Add(te)
            Next
        End If
    End Sub


    Public Sub Read(ByRef te As Team)
        Dim col As Collection
        Dim aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Teams WHERE TeamID='" & te.TeamID & "';")

        If col.Count > 0 Then
            For Each aux In col
                te.TeamName = aux(2).ToString
                te.TeamCountry = Integer.Parse(aux(3).ToString)
            Next

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