Imports System.Data.SqlClient
Imports System.Data
Public Class ENFANT

    Private command As SqlCommand
    Private query As String
    Private table As DataTable
    Public adapter As SqlDataAdapter

    Public Function insertChild(ByVal name As String, ByVal dateBirth As String, ByVal lieuNaiss As String, ByVal sexe As String, ByVal idParent As String)
        Try
            query = "insertChild"
            command = New SqlCommand(query, getConnection)
            command.Parameters.AddWithValue("@name", name)
            command.Parameters.AddWithValue("@dateBirth", dateBirth)
            command.Parameters.AddWithValue("@lieuNaiss", lieuNaiss)
            command.Parameters.AddWithValue("@sexe", sexe)
            command.Parameters.AddWithValue("@sexe", idParent)
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
    Public Function updateChild(ByVal id As String, ByVal name As String, ByVal dateBirth As String, ByVal lieuNaiss As String, ByVal sexe As String, ByVal idparent As String)
        Try
            query = "insertChild"
            command = New SqlCommand(query, getConnection)
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@name", name)
            command.Parameters.AddWithValue("@dateBirth", dateBirth)
            command.Parameters.AddWithValue("@lieuNaiss", lieuNaiss)
            command.Parameters.AddWithValue("@sexe", sexe)
            command.Parameters.AddWithValue("@idparent", idparent)
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

    Public Function ShowChildByDate() As DataTable
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
    Public Function ShowChild() As DataTable
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
    Public Function ShowNumberAllChild() As DataTable
        Try
            query = "Select count(*) From child"
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
    Public Function DeleteChild(ByVal id As String)
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
    Public Function ShowChildBySearch(ByVal name As String) As DataTable
        Try
            query = "Select * From child where Name LIKE '%@name%'"
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
