Public Class FrmPaciente
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub PanelDatosPaciente_Paint(sender As Object, e As PaintEventArgs) Handles PanelDatosPaciente.Paint

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
    'Lo dejo como experimento porque las credenciales no me sirvieron y no lo pude probar, pi
    'Private Function validarCampos() As Boolean
        'Dim resultado = False
        'Select Case (resultado)
            'Case (TxtNombre.Text <> "")
                'resultado = True
            'Case (TxtApellido.Text <> "")
                'resultado = True
            'Case (TxtCedula.Text <> "")
                'resultado = True
            'Case (TxtDireccion.Text <> "")
                'resultado = True
            'Case (TxtTelefono.Text <> "")
                'resultado = True
            'Case (TxtCorreo.Text <> "")
                'resultado = True
        'End Select

    'End Function

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtCedula.Clear()
        TxtDireccion.Clear()
        TxtTelefono.Clear()
        TxtCorreo.Clear()
    End Sub
End Class


