Imports System.Runtime.InteropServices

Public Class FrmUsuario
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardarIcon_Click(sender As Object, e As EventArgs) Handles BtnGuardarIcon.Click
        If (TxtNombres.Text = "") Then
            MsgBox("Debe ingresar un nombre al campo")
        End If

        If (TxtApellidos.Text = "") Then
            MsgBox("Debe ingresar un apellido al campo")
        End If

        If (TxtNombreUsuario.Text = "") Then
            MsgBox("Debe ingresar un nombre de usuario al campo")
        End If

        If (CbxRol.SelectedItem = "") Then
            MsgBox("Debe seleccionar un rol")
        End If

        If (TxtTelefono.Text = "") Then
            MsgBox("Debe ingresar un numero de teléfono al campo")
        End If

        If (TxtDireccion.Text = "") Then
            MsgBox("Debe ingresar una dirección de correo electrónico")
        End If

        If (TxtPw.Text = "") Then
            MsgBox("Debe ingresar una contraseña")
        End If

        ValidarContraseña()
    End Sub


    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Por favor digite un numero de telefono")
        End If
    End Sub

    Private Sub ValidarContraseña()
        If String.Equals(TxtPw.Text, TxtConfirmarPw.Text) Then
        Else
            MsgBox("Las contraseñas no coinciden")
        End If
    End Sub

    Private Sub BtnBuscarEstudio_Click(sender As Object, e As EventArgs) Handles BtnBuscarEstudio.Click
        If (TxtUsuario.Text = "") Then
            MsgBox("Ingrese un usuario para buscar")
        End If
    End Sub
End Class