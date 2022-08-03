Imports System.Data.SqlClient
Imports System.Data
Public Class PARENT
    Private command As SqlCommand
    Private query As String
    Private table As DataTable
    Public adapter As SqlDataAdapter

    Public Sub insertParent(ByVal namePere As String, ByVal nameMere As String, ByVal dateBirthPere As String, ByVal dateBirthMere As String, ByVal lieuNaissPere As String, ByVal lieuNaissMere As String, ByVal adresseParent As String, ByVal nationalitePere As String, ByVal nationaliteMere As String, ByVal profPere As String, ByVal profMere As String)
        Try
            query = "insertChild"
            command = New SqlCommand(query, getConnection)
            command.Parameters.AddWithValue("@namePere", namePere)
            command.Parameters.AddWithValue("@dateBirth", dateBirthPere)
            command.Parameters.AddWithValue("@lieuNaiss", lieuNaissPere)
            command.Parameters.AddWithValue("@proffesion", profPere)
            command.Parameters.AddWithValue("@nationalite", nationalitePere)
            command.Parameters.AddWithValue("@namePere", nameMere)
            command.Parameters.AddWithValue("@dateBirth", dateBirthMere)
            command.Parameters.AddWithValue("@lieuNaiss", lieuNaissMere)
            command.Parameters.AddWithValue("@proffesion", profMere)
            command.Parameters.AddWithValue("@nationalite", nationaliteMere)
            openConnection()
            command.ExecuteNonQuery()

            closeConnection()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub upadateParent(ByVal id As String, ByVal namePere As String, ByVal nameMere As String, ByVal dateBirthPere As String, ByVal dateBirthMere As String, ByVal lieuNaissPere As String, ByVal lieuNaissMere As String, ByVal adresseParent As String, ByVal nationalitePere As String, ByVal nationaliteMere As String, ByVal profPere As String, ByVal profMere As String)
        Try
            query = "insertChild"
            command = New SqlCommand(query, getConnection)
            command.Parameters.AddWithValue("@namePere", namePere)
            command.Parameters.AddWithValue("@dateBirth", dateBirthPere)
            command.Parameters.AddWithValue("@lieuNaiss", lieuNaissPere)
            command.Parameters.AddWithValue("@proffesion", profPere)
            command.Parameters.AddWithValue("@nationalite", nationalitePere)
            command.Parameters.AddWithValue("@namePere", nameMere)
            command.Parameters.AddWithValue("@dateBirth", dateBirthMere)
            command.Parameters.AddWithValue("@lieuNaiss", lieuNaissMere)
            command.Parameters.AddWithValue("@proffesion", profMere)
            command.Parameters.AddWithValue("@nationalite", nationaliteMere)
            openConnection()
            command.ExecuteNonQuery()

            closeConnection()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Public Function ShowParent() As DataTable
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
    Public Function ShowParentByName(ByVal name As String) As DataTable
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
    Public Function ShowNumberParent() As DataTable
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
    Public Sub DeleteParent(ByVal id As String)
        Try
            query = "delete from child where id=@id"
            command = New SqlCommand(query, getConnection)
            command.Parameters.AddWithValue("@id", id)

            openConnection()
            command.ExecuteNonQuery()

            closeConnection()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
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
