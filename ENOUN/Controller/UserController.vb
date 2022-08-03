Public Class UserController

    Public user As New Users
    Private table As DataTable


    Public Sub insertUser(ByVal name As String, ByVal phoneUser As String, ByVal posteUser As String, ByVal adressUser As String, ByVal MotPasseUser As String)
        If name = "" Or phoneUser = "" Or adressUser = "" Or posteUser = "" Or MotPasseUser = "" Then
            MsgBox("veuillez remplir tous les champs", MsgBoxStyle.Critical)
        Else
            If user.insertUsers(name, phoneUser, posteUser, adressUser, MotPasseUser) Then
                MsgBox("le nouveau utilisateur a ete enregistrer avec success"
            Else
                MsgBox("impossible d'enregistrer l'enfant ")
            End If
        End If

    End Sub

    Public Sub updateUser(ByVal id As String, ByVal name As String, ByVal phoneUser As String, ByVal posteUser As String, ByVal adressUser As String, ByVal MotPasseUser As String)
        If name = "" Or phoneUser = "" Or adressUser = "" Or posteUser = "" Or MotPasseUser = "" Then
            MsgBox("veuillez remplir tous les champs", MsgBoxStyle.Critical)
        Else
            If user.insertUsers(name, phoneUser, posteUser, adressUser, MotPasseUser) Then
                MsgBox("le nouveau utilisateur a ete enregistrer avec success"
            Else
                MsgBox("impossible d'enregistrer l'enfant ")
            End If
        End If

    End Sub

    Public Sub deleteUser(ByVal id As String)
        If id = "" Then
            MsgBox("veuillez remplir tous les champs", MsgBoxStyle.Critical)
        Else
            If MsgBox("voulez vous supprimer l'enfant de la base de donnee", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                If user.DeleteUser(id) Then
                    MsgBox("le nouveau nee a ete modifier avec success")
                Else
                    MsgBox("impossible de modifier l'enfant ")
                End If

            End If
        End If

    End Sub

    Public Sub chargementEnfant(ByVal datagrid As DataGridView)
        table = Enfant.ShowChild()
        datagrid.DataSource = table
    End Sub

    Public Sub chargementEnfant(ByVal datagrid As DataGridView, ByVal name As String)
        table = Enfant.ShowChildBySearch(name)
        datagrid.DataSource = table
    End Sub


End Class
