﻿Public Class TeamDAO
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
        Dim colContracts As New Collection
        Dim objContracts As New List(Of Contract)
        Dim aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Teams WHERE TeamID='" & te.TeamID & "';")
        If col.Count > 0 Then
            For Each aux In col
                te.TeamID = Integer.Parse(aux(1).ToString)
                te.TeamName = aux(2).ToString
                te.TeamCountry = aux(3).ToString
                te.CreationDate = Date.Parse(aux(4).ToString)
            Next

            colContracts = DBBroker.GetBroker().Read("SELECT * FROM Contracts WHERE team = " & te.TeamID & ";")
            'Meter en objContacts los contratos
            For Each aux In colContracts
                Dim c As New Contract()
                c.Team = Integer.Parse(aux(1).ToString)
                c.Season = Integer.Parse(aux(2).ToString)
                c.Driver1 = Integer.Parse(aux(3).ToString)
                c.Driver2 = Integer.Parse(aux(4).ToString)
                objContracts.Add(c)
            Next

            te.Contracts = objContracts

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
