Public Class frmCountries
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        'Cerrar este formulario
        Me.Close()
        frmFormulaOne.Enabled = True
    End Sub
    Private Sub frmDrivers_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Reactivar el formulario original
        frmFormulaOne.Enabled = True
    End Sub
End Class