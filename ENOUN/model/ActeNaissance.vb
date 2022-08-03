Imports System.Data.SqlClient
Imports System.Data
Public Class ActeNaissance
    Private command As SqlCommand
    Private query As String
    Private table As DataTable
    Public adapter As SqlDataAdapter

    Public Function insertActeNaissance(ByVal getActe As GetActeNaissance)
        Try
            query = "insertActe"
            command = New SqlCommand(query, getConnection)
            command.Parameters.AddWithValue("@nameEnfant", getActe.getNomE)
            command.Parameters.AddWithValue("@dateNaissE", getActe.getdateNaissP)
            command.Parameters.AddWithValue("@lieu", getActe.getlieuNenfant)
            command.Parameters.AddWithValue("@sexe", getActe.Getsexe)
            command.Parameters.AddWithValue("@nomPere", getActe.GetnomPere)
            command.Parameters.AddWithValue("@dateNaissLieuP", getActe.getdateNaissP)
            command.Parameters.AddWithValue("@LieuP", getActe.getlieuNaissP)
            command.Parameters.AddWithValue("@nationaliteP", getActe.getNationaliteP)
            command.Parameters.AddWithValue("@nomMere", getActe.getnomMere)
            command.Parameters.AddWithValue("@dateNaissLieuM", getActe.getdateNaissM)
            command.Parameters.AddWithValue("@LieuM", getActe.getlieuM)
            command.Parameters.AddWithValue("@nationaliteM", getActe.getnationaliteM)
            command.Parameters.AddWithValue("@adresseParent", getActe.GetadresseP)
            command.Parameters.AddWithValue("@Province", getActe.Getprov)
            command.Parameters.AddWithValue("@ville", getActe.getville)
            command.Parameters.AddWithValue("@territoire", getActe.getterritoire)
            command.Parameters.AddWithValue("@chefferie", getActe.getchefferie)
            command.Parameters.AddWithValue("@bureauP", getActe.getBureauP)
            command.Parameters.AddWithValue("@BureauS", getActe.getBureauS)
            command.Parameters.AddWithValue("@officier", getActe.getOfficier)
            command.Parameters.AddWithValue("@comparu", getActe.getComparu)
            command.Parameters.AddWithValue("@qualite", getActe.getqualite)
            command.Parameters.AddWithValue("@date", Date.Now)
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
    Public Function updateActe(ByVal getActe As GetActeNaissance)
        Try
            query = "insertActe"
            command = New SqlCommand(query, getConnection)
            command.Parameters.AddWithValue("@idActe", getActe.getActeNAISS)
            command.Parameters.AddWithValue("@nameEnfant", getActe.getNomE)
            command.Parameters.AddWithValue("@dateNaissE", getActe.getdateNaissP)
            command.Parameters.AddWithValue("@lieu", getActe.getlieuNenfant)
            command.Parameters.AddWithValue("@sexe", getActe.Getsexe)
            command.Parameters.AddWithValue("@nomPere", getActe.GetnomPere)
            command.Parameters.AddWithValue("@dateNaissLieuP", getActe.getdateNaissP)
            command.Parameters.AddWithValue("@LieuP", getActe.getlieuNaissP)
            command.Parameters.AddWithValue("@nationaliteP", getActe.getNationaliteP)
            command.Parameters.AddWithValue("@nomMere", getActe.getnomMere)
            command.Parameters.AddWithValue("@dateNaissLieuM", getActe.getdateNaissM)
            command.Parameters.AddWithValue("@LieuM", getActe.getlieuM)
            command.Parameters.AddWithValue("@nationaliteM", getActe.getnationaliteM)
            command.Parameters.AddWithValue("@adresseParent", getActe.GetadresseP)
            command.Parameters.AddWithValue("@Province", getActe.Getprov)
            command.Parameters.AddWithValue("@ville", getActe.getville)
            command.Parameters.AddWithValue("@territoire", getActe.getterritoire)
            command.Parameters.AddWithValue("@chefferie", getActe.getchefferie)
            command.Parameters.AddWithValue("@bureauP", getActe.getBureauP)
            command.Parameters.AddWithValue("@BureauS", getActe.getBureauS)
            command.Parameters.AddWithValue("@officier", getActe.getOfficier)
            command.Parameters.AddWithValue("@comparu", getActe.getComparu)
            command.Parameters.AddWithValue("@qualite", getActe.getqualite)
            command.Parameters.AddWithValue("@date", Date.Now)
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
    Public Function showAllActe() As DataTable
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
    Public Function showAllBySearch(ByVal name As String) As DataTable
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

    Public Function showAllBySearchDate(ByVal name As String) As DataTable
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
    Public Function CountAllActe() As DataTable
        Try
            query = "Select count(*) From acte_naissance"
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
    Public Sub DeleteActeNaissance(ByVal id As String)
        Try
            query = "delete from acte_naissance where id=@id"
            command = New SqlCommand(query, getConnection)
            command.Parameters.AddWithValue("@id", id)

            openConnection()
            command.ExecuteNonQuery()

            closeConnection()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


End Class
