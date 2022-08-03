Public Class frmfiche_d_enregisttrement
    Private getActe As New GetActeNaissance
    Private managerActe As New ActeNaissance
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If verification() Then
            MsgBox("veuillez remplir tous les champs")
        Else

            getActe.getNomE = txtnomenf.Text
            getActe.getlieuNenfant = txtne1.Text
            getActe.Getsexe = cmbsexe.Text
            getActe.GetnomPere = txtnepere.Text
            getActe.getnomMere = txtnationmere.Text
            getActe.getlieuNaissP = txtnepere.Text
            getActe.getNationaliteP = txtnatio1.Text
            getActe.getnationaliteM = txtnationmere.Text
            getActe.getlieuM = txtnemere.Text
            getActe.GetadresseP = txtadresse2.Text
            getActe.getdateNaissE = datenaissen.Value.ToString()
            getActe.getdateNaissM = datenaissmere.Value.ToString()
            getActe.getdateNaissP = datenaisspere.Value.ToString()
            getActe.Getprov = txtprovince.Text
            getActe.getville = txtville.Text
            getActe.getterritoire = txtterritoire.Text
            getActe.getchefferie = txtsecteur.Text
            getActe.getBureauP = txtbureau.Text
            getActe.getBureauS = txtbureau1.Text
            getActe.getOfficier = txtoffice.Text
            getActe.getComparu = txtcomp.Text
            getActe.getqualite = txtquali.Text

            If managerActe.insertActeNaissance(getActe) Then
                MsgBox("insertion nouveau acte de naissance avec success", MsgBoxStyle.Information)
                clean()
            Else
                MsgBox("erreur lors de l'enregistrement", MsgBoxStyle.Critical)
            End If
        End If

    End Sub
    Public Function verification()
        If txtnomenf.Text = "" And
            txtne1.Text = "" And
            cmbsexe.Text = "" And
            txtnepere.Text = "" And
            txtnationmere.Text = "" And
            txtnepere.Text = "" And
            txtnatio1.Text = "" And
            txtnationmere.Text = "" And
            txtnemere.Text = "" And
            txtadresse2.Text = "" And
            datenaissmere.Value.ToString() = "" And
            datenaisspere.Value.ToString() = "" And
            txtprovince.Text = "" And
            txtville.Text = "" And
            txtterritoire.Text = "" And
            txtsecteur.Text = "" And
            txtbureau.Text = "" And
            txtbureau1.Text = "" And
            txtoffice.Text = "" And
            txtcomp.Text = "" And
            txtquali.Text Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Sub clean()
        txtnomenf.Clear()
        txtne1.Clear()
        cmbsexe.Text = ""
        txtnepere.Clear()
        txtnationmere.Clear()
        txtnepere.Clear()
        txtnatio1.Clear()
        txtnationmere.Clear()
        txtnemere.Clear()
        txtadresse2.Clear()
        datenaissmere.Value = Date.Now
        datenaisspere.Value = Date.Now
        txtprovince.Clear()
        txtville.Clear()
        txtterritoire.Clear()
        txtsecteur.Clear()
        txtbureau.Clear()
        txtbureau1.Clear()
        txtoffice.Clear()
        txtcomp.Clear()
        txtquali.Clear()
    End Sub

    Private Sub guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles guna2DataGridView1.CellContentClick

    End Sub
    Public Sub showActe()
        Dim table As DataTable
        table = managerActe.showAllActe
        guna2DataGridView1.DataSource = table
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        clean()
    End Sub

    Private Sub frmfiche_d_enregisttrement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showActe()
    End Sub
End Class