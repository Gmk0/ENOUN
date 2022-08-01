﻿Imports System.Data.SqlClient
Imports System.Data
Public Class PARENT
    Private command As SqlCommand
    Private query As String
    Private table As DataTable
    Public adapter As SqlDataAdapter

    Public Sub insertChild(ByVal namePere As String, ByVal nameMere As String, ByVal dateBirthPere As String, ByVal dateBirthMere As String, ByVal lieuNaissPere As String, ByVal lieuNaissMere As String, ByVal adresseParent As String, ByVal nationalitePere As String, ByVal nationaliteMere As String)
        Try
            query = "insertChild"
            command = New SqlCommand(query, getConnection)
            command.Parameters.AddWithValue("@name", namePere)
            command.Parameters.AddWithValue("@dateBirth", dateBirthPere)
            command.Parameters.AddWithValue("@lieuNaiss", lieuNaiss)
            command.Parameters.AddWithValue("@sexe", sexe)
            openConnection()
            command.ExecuteNonQuery()

            closeConnection()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub updateChild(ByVal id As String, ByVal name As String, ByVal dateBirth As String, ByVal lieuNaiss As String, ByVal sexe As String)
        Try
            query = "insertChild"
            command = New SqlCommand(query, getConnection)
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@name", name)
            command.Parameters.AddWithValue("@dateBirth", dateBirth)
            command.Parameters.AddWithValue("@lieuNaiss", lieuNaiss)
            command.Parameters.AddWithValue("@sexe", sexe)
            openConnection()
            command.ExecuteNonQuery()

            closeConnection()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

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
    Public Sub DeleteChild(ByVal id As String)
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
