Public Class FrmCategorias
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Function validarCampos() As Boolean
        Dim resultado = False
        If TxtNombre.Text <> "" Or TxtIdentificador.Text <> "" Then
            resultado = True
        End If
        Return resultado
    End Function

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNombre.Clear()
        TxtIdentificador.Clear()
        TxtIdentificador.Clear()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If Not validarCampos() Then
                MsgBox("Rellene el campo con los datos requeridos")
                Return
            End If
        Catch ex As Exception

        End Try
    End Sub


End Class