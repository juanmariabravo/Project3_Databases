Public Class DBBroker
    ' Singleton pattern. We can use this class in other projects so that we only need to change the database name and password
    Private Shared _Instance As DBBroker ' DBBroker instance
    Private Shared connection As MySql.Data.MySqlClient.MySqlConnection ' connection object
    Private Shared connectionString As String

    Private Sub New()
        DBBroker.connectionString = "server=localhost;database=countries;uid=root;pwd=root"
        DBBroker.connection = New MySql.Data.MySqlClient.MySqlConnection(DBBroker.connectionString)
    End Sub

    ' Shared means that the method is called on the class itself, not on an instance of the class.
    ' It is similar to the Java static method.
    Public Shared Function GetBroker() As DBBroker
        If DBBroker._Instance Is Nothing Then
            DBBroker._Instance = New DBBroker
        End If
        Return DBBroker._Instance
    End Function

    Public Function Read(sql As String) As Collection
        Dim result As New Collection
        Dim row As Collection
        Dim i As Integer
        Dim reader As MySql.Data.MySqlClient.MySqlDataReader
        Dim com As New MySql.Data.MySqlClient.MySqlCommand(sql, DBBroker.connection)
        Connect()
        'Console.WriteLine("Connected")
        reader = com.ExecuteReader
        ' ExecuteReader returns a DataReader object, which is a forward-only, read-only cursor
        While reader.Read ' while I have rows, read... Read method advances the DataReader to the next record (row)
            row = New Collection ' Collection is a hashtable
            For i = 0 To reader.FieldCount - 1 ' for each column in the row...
                row.Add(reader(i).ToString)
            Next
            result.Add(row) ' in result we are storing a collection of collections (rows)
        End While
        Disconnect()
        Return result
    End Function

    Public Function Change(sql As String) As Integer
        Dim com As New MySql.Data.MySqlClient.MySqlCommand(sql, DBBroker.connection)
        Dim result As Integer
        Connect()
        result = com.ExecuteNonQuery
        Disconnect()
        Return result
    End Function

    Private Sub Connect()
        If DBBroker.connection.State = ConnectionState.Closed Then
            DBBroker.connection.Open()
        End If
    End Sub

    Private Sub Disconnect()
        If DBBroker.connection.State = ConnectionState.Open Then
            DBBroker.connection.Close()
        End If
    End Sub

End Class
