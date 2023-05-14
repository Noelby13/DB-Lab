Public Class FrmRol
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If (TxtNombres.Text = "") Then
            MsgBox("Debe ingresar un nombre al campo")
        End If

        If (TbxDescripcion.Text = "") Then
            MsgBox("Debe ingresar una descripción al campo")
        End If
    End Sub

    Private Sub BtnBuscarRol_Click(sender As Object, e As EventArgs) Handles BtnBuscarRol.Click
        If (TxtRol.Text = "") Then
            MsgBox("Debe ingresar datos en el campo")
        End If
    End Sub
End Class