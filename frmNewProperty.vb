Public Class frmNewProperty
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPBack.Click
        Me.Close()
        frmProperties.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPsave.Click
        Me.Close()
        frmProperties.Show()
    End Sub

    Private Sub frmNewProperty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        Dim selectionStart As Integer = txtPrice.SelectionStart
        txtPrice.Text = System.Text.RegularExpressions.Regex.Replace(txtPrice.Text, "[^\d]", "")
        txtPrice.SelectionStart = Math.Min(selectionStart, txtPrice.Text.Length)
    End Sub

    Private Sub txtPName_TextChanged(sender As Object, e As EventArgs) Handles txtPName.TextChanged
        Dim selectionStart As Integer = txtPName.SelectionStart
        txtPName.Text = System.Text.RegularExpressions.Regex.Replace(txtPName.Text, "[^a-zA-Z\s]", "")
        txtPName.SelectionStart = Math.Min(selectionStart, txtPName.Text.Length)
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frmProperties.Show()
        Me.Hide()
    End Sub
End Class