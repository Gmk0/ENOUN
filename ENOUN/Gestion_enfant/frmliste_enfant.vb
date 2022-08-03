Public Class frmliste_enfant
    Public managerActe As New ActeNaissance
    Private table As DataTable
    Private Sub frmliste_enfant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub showAll()
        table = managerActe.showAllActe()
        guna2DataGridView1.DataSource = table
    End Sub

    Public Sub showBysearch()
        table = managerActe.showAllBySearch(txtrecherche.Text)
        guna2DataGridView1.DataSource = table
    End Sub
    Sub showBtDate()

    End Sub


    Private Sub txtrecherche_TextChanged(sender As Object, e As EventArgs) Handles txtrecherche.TextChanged
        showBysearch()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dateDu.ValueChanged

    End Sub
End Class