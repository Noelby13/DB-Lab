Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Function validarCampos() As Boolean
        Dim resultado = False
        If TxbUsuario.Text <> "" Or TxbContraseña.Text <> "" Then
            resultado = True
        End If
        Return resultado
    End Function


    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        Try
            'If validarCampos() Then
            '    Dim user As New Usuario()
            '    Dim dUser As New DUsuario
            '    user.Username = TxbUsuario.Text
            '    user.Pwd = TxbContraseña.Text

            '    If dUser.validarUsuario(user) Then
            '        FrmPrincipal.Show()
            '        Me.Close()
            '    Else
            '        MsgBox("Datos incorrecto", MsgBoxStyle.Information, "Inicio de Sesión")
            '    End If
            'Else
            '    MsgBox("Datos incompletos mi rey")

            'End If


            If Not validarCampos() Then
                MsgBox("Datos incompletos mi rey")
                Return
            End If

            Dim user As New Usuario()
            Dim dUser As New DUsuario
            user.Username = TxbUsuario.Text
            user.Pwd = TxbContraseña.Text

            If Not dUser.validarUsuario(user) Then
                MsgBox("Datos incorrecto", MsgBoxStyle.Information, "Inicio de Sesión")
                Return
            End If

            FrmPrincipal.Show()
            Me.Close()






        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try


    End Sub

    Private Sub TxbUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles TxbUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxbContraseña.Focus()
        End If
    End Sub

    Private Sub TxbContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles TxbContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnEntrar.PerformClick()
        End If
    End Sub
End Class
