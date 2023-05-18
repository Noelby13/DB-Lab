Public Class FrmPaciente
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub PanelDatosPaciente_Paint(sender As Object, e As PaintEventArgs) Handles PanelDatosPaciente.Paint

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Function validarSexo() As Boolean
        Dim resultado = False
        If (RbMasculino.Checked = True Or RbFemenino.Checked = True) Then
            resultado = True
        End If
        Return resultado
    End Function


    Private Function validarCampos() As Boolean
        Dim resultado = False
        If (TxtNombre.Text <> "" And TxtApellido.Text <> "" And TxtCedula.Text <> "" And TxtDireccion.Text <> "" And TxtTelefono.Text <> "" And TxtCorreo.Text <> "") Then
            resultado = True
        End If
        Return resultado
    End Function

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtCedula.Clear()
        TxtDireccion.Clear()
        TxtTelefono.Clear()
        TxtCorreo.Clear()
    End Sub

    Private Sub BtnGuardarIcon_Click(sender As Object, e As EventArgs) Handles BtnGuardarIcon.Click
        If Not validarCampos() And Not validarSexo() Then
            MsgBox("Datos incompletos")
            Return
        End If
    End Sub

End Class


