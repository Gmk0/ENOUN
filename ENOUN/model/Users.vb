Imports System.Data.SqlClient
Imports System.Data
Public Class Users
    Private command As SqlCommand
    Private query As String
    Private table As DataTable
    Public adapter As SqlDataAdapter

    Public Function insertUsers(ByVal nameUser As String, ByVal phoneUser As String, ByVal posteUser As String, ByVal adressUser As String, ByVal MotPasseUser As String)
        Try
            query = "insertChild"
            command = New SqlCommand(query, getConnection)
            command.Parameters.AddWithValue("@nameUser", nameUser)
            command.Parameters.AddWithValue("@phoneUser", phoneUser)
            command.Parameters.AddWithValue("@posteUser", posteUser)
            command.Parameters.AddWithValue("@adressUser", adressUser)
            command.Parameters.AddWithValue("@MotPasseUser", MotPasseUser)

            openConnection()
            If command.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

            closeConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function UpdateUser(ByVal id As String, ByVal nameUser As String, ByVal phoneUser As String, ByVal posteUser As String, ByVal adressUser As String, ByVal MotPasseUser As String)
        Try
            query = "insertUser"
            command = New SqlCommand(query, getConnection)
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@nameUser", nameUser)
            command.Parameters.AddWithValue("@phoneUser", phoneUser)
            command.Parameters.AddWithValue("@posteUser", posteUser)
            command.Parameters.AddWithValue("@adressUser", adressUser)
            command.Parameters.AddWithValue("@MotPasseUser", MotPasseUser)
            openConnection()
            If command.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

            closeConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function DeleteUser(ByVal id As String)
        Try
            query = "delete from child where id=@id"
            command = New SqlCommand(query, getConnection)
            command.Parameters.AddWithValue("@id", id)

            openConnection()
            If command.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

            closeConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function ShowUser() As DataTable
        Try
            query = ""
            command = New SqlCommand(query, getConnection)
            adapter = New SqlDataAdapter(command)
            table = New DataTable()
            adapter.Fill(table)
            Return table
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        End Try
    End Function
End Class
