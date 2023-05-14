Public Class FrmCerrarTurno
    Friend Property cierreExitoso As Boolean = False
    Friend Property usuario As Usuario

    Private Sub FrmCerrarTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dArqueo As New DArqueo
        Dim turno = dArqueo.obtenerTurno()
        LblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        'LblUsuario.Text = usuario.Username
        TxtMontoInicial.Text = turno.MontoInicial.ToString()

    End Sub

    Private Function calcularMontoFinal() As Decimal


    End Function

End Class