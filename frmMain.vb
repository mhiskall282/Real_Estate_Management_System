Public Class frmMain
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub btnTenants_Click(sender As Object, e As EventArgs) Handles btnTenants.Click
        Me.Hide()
        frmtTenants.Show()
    End Sub

    Private Sub btnAccounting_Click(sender As Object, e As EventArgs) Handles btnAccounting.Click
        Me.Hide()
        frmAccounting.Show()
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        Me.Hide()
        frmMaintainance.Show()
    End Sub
    '
    ' Private Sub btnProperties_Click(sender As Object, e As EventArgs)
    'Me.'Hide()
    ' frmProperties.Show()
    ' End Sub '

    Private Sub btnProperties_Click_1(sender As Object, e As EventArgs) Handles btnProperties.Click
        frmNewProperty.Show()
        Me.Hide()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class