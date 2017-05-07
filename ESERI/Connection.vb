Imports MySql.Data.MySqlClient
Module Connection
    Public Conn As MySqlConnection
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public CMD As MySqlCommand
    Public DS As DataSet
    Public insert, update, delete As String

    Public Sub openConnection()
        Dim sqlConn As String
        sqlConn = "server=localhost;Uid=root;Password=;Database=kalkulator"

        Conn = New MySqlConnection(sqlConn)

        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If

    End Sub


End Module
