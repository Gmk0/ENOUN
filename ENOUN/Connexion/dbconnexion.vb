Imports System.Data.SqlClient
Module dbconnexion
    Dim connection As New SqlConnection("")

    ReadOnly Property getConnection() As SqlConnection
        Get
            Return connection
        End Get

    End Property
    Sub openConnection()
        If (connection.State = ConnectionState.Closed) Then
            connection.Open()
        End If
    End Sub
    Sub closeConnection()
        If (connection.State = ConnectionState.Open) Then
            connection.Close()
        End If
    End Sub

End Module
