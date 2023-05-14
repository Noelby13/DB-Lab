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

            user = dUser.obtenerUsuario(user.Username)
            MsgBox("Bienvenido " + user.Username, MsgBoxStyle.Information, "Inicio de Sesión")


            Dim dArqueo As New DArqueo
            If Not dArqueo.chequearTurno() Then
                Me.Hide()
                'Le pasamos el usuario al formulario de apertura de caja
                FrmAperturaCaja.usuario = user
                'ShowDialog sirve para detener la ejecucion del codigo hasta que se cierre el formulario
                FrmAperturaCaja.ShowDialog()
                If FrmAperturaCaja.AperturaExitosa Then
                    FrmPrincipal.Show()
                End If
                'MsgBox("Ocurrio un error al abrir el turno. Contacta al Soporte 8888-8888", MsgBoxStyle.Critical)
            Else
                'Este codigo se ejecuta si ya hay un turno abierto
                FrmPrincipal.Show()
                Me.Close()
            End If


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
