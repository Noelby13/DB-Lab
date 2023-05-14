Public Class FrmAperturaCaja
    Friend Property AperturaExitosa As Boolean = False
    Friend Property usuario As Usuario
    Private Sub FrmAperturaCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        LblHora.Text = DateTime.Now.ToString("HH:mm")
        LblUsuario.Text = usuario.Username


    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim dArqueo As New DArqueo
        Dim turno As New ArqueoCaja
        turno.IdUsuario = usuario.IdUsuario
        turno.MontoInicial = Convert.ToDecimal(TxtMontoInicial.Text)

        If Not dArqueo.abrirTurno(turno) Then
            MsgBox("Error al abrir caja", MsgBoxStyle.Information, "Apertura de Caja")
            Return
        End If

        AperturaExitosa = True
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        MsgBox("Si cancelas no podras usar el sistema", MsgBoxStyle.Information, "Apertura de Caja")
        Me.Close()
    End Sub
End Class