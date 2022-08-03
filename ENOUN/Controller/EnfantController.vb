Public Class EnfantController
    Public Enfant As New ENFANT
    Private table As DataTable


    Public Sub insertEnfant(ByVal name As String, ByVal dateBirth As String, ByVal lieuNaiss As String, ByVal sexe As String, ByVal idParent As String)
        If name = "" Or dateBirth = "" Or lieuNaiss = "" Or sexe = "" Or idParent = "" Then
            MsgBox("veuillez remplir tous les champs", MsgBoxStyle.Critical)
        Else
            If Enfant.insertChild(name, dateBirth, lieuNaiss, sexe, idParent) Then
                MsgBox("le nouveau nee a ete enregistrer avec success")
            Else
                MsgBox("impossible d'enregistrer l'enfant ")
            End If
        End If

    End Sub

    Public Sub UpdateEnfant(ByVal name As String, ByVal dateBirth As String, ByVal lieuNaiss As String, ByVal sexe As String, ByVal idParent As String, ByVal idEnfant As String)
        If name = "" Or dateBirth = "" Or lieuNaiss = "" Or sexe = "" Or idParent = "" Then
            MsgBox("veuillez remplir tous les champs", MsgBoxStyle.Critical)
        Else
            If Enfant.updateChild(idEnfant, name, dateBirth, lieuNaiss, sexe, idParent) Then
                MsgBox("le nouveau nee a ete modifier avec success")
            Else
                MsgBox("impossible de modifier l'enfant ")
            End If
        End If

    End Sub

    Public Sub deleteEnfanr(ByVal id As String)
        If id = "" Then
            MsgBox("veuillez remplir tous les champs", MsgBoxStyle.Critical)
        Else
            If MsgBox("voulez vous supprimer l'enfant de la base de donnee", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                If Enfant.DeleteChild(id) Then
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
