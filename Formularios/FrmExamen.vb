Public Class FrmExamen
    Private Sub FrmExamen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTablaEstudios()
    End Sub

    Private Sub cargarTablaEstudios()
        Dim dEstudio As New DEstudio
        Dim ds As New DataSet
        ds = dEstudio.listarEstudios()
        DgvEstudios.DataSource = ds.Tables(0)
        DgvEstudios.Refresh()
        DgvEstudios.Columns(0).Visible = False
        DgvEstudios.Columns(1).Visible = True
        DgvEstudios.Columns(2).Visible = False
        DgvEstudios.Columns(3).Visible = False
        DgvEstudios.Columns(4).Visible = False
        DgvEstudios.Columns(5).Visible = False
        DgvEstudios.Columns(6).Visible = False
        DgvEstudios.Columns(7).Visible = False

        DgvEstudios.Columns(8).Visible = False
        DgvEstudios.Columns(9).Visible = False

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class