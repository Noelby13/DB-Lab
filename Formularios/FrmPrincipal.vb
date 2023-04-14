Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultarSubMenu()
    End Sub

    Private Sub ocultarSubMenu()
        PanelSubUsuario.Visible = False
        PanelSubPaciente.Visible = False
        PanelSubExamenes.Visible = False
        PanelSubOrdenes.Visible = False
        PanelSubResultado.Visible = False
    End Sub

    Private Sub mostrarSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            ocultarSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If

    End Sub

    Private Sub BtnUsuario_Click(sender As Object, e As EventArgs) Handles BtnUsuario.Click
        mostrarSubMenu(PanelSubUsuario)
    End Sub

    Private Sub BtnExamenes_Click(sender As Object, e As EventArgs) Handles BtnExamenes.Click
        mostrarSubMenu(PanelSubExamenes)
    End Sub

    Private Sub BtnPaciente_Click(sender As Object, e As EventArgs) Handles BtnPaciente.Click
        mostrarSubMenu(PanelSubPaciente)
    End Sub

    Private Sub BtnOrdenes_Click(sender As Object, e As EventArgs) Handles BtnOrdenes.Click
        mostrarSubMenu(PanelSubOrdenes)
    End Sub

    Private Sub BtnResultados_Click(sender As Object, e As EventArgs) Handles BtnResultados.Click
        mostrarSubMenu(PanelSubResultado)
    End Sub

    Private FrmActual As Form = Nothing
    Private Sub abrirFrmHijo(FrmHijo As Form)
        If FrmActual IsNot Nothing Then FrmActual.Close()
        FrmActual = FrmHijo
        FrmHijo.TopLevel = False
        FrmHijo.FormBorderStyle = FormBorderStyle.None
        FrmHijo.Dock = DockStyle.Fill
        PanelFrmHijo.Controls.Add(FrmHijo)
        PanelFrmHijo.Tag = FrmHijo
        FrmHijo.Show()
    End Sub

    Private Sub BtnCrearUsuario_Click(sender As Object, e As EventArgs) Handles BtnCrearUsuario.Click
        abrirFrmHijo(New FrmCrearUsuario())
    End Sub

    Private Sub BtnFacturar_Click(sender As Object, e As EventArgs) Handles BtnFacturar.Click
        abrirFrmHijo(New FrmFacturarOrdenes())
    End Sub

    Private Sub BtnCrearRol_Click(sender As Object, e As EventArgs) Handles BtnCrearRol.Click
        abrirFrmHijo(New FrmCrearRol())
    End Sub

    Private Sub BtnCrearCategoria_Click(sender As Object, e As EventArgs) Handles BtnCrearCategoria.Click
        abrirFrmHijo(New FrmCategorias())
    End Sub

    Private Sub BtnListaTrabajo_Click(sender As Object, e As EventArgs) Handles BtnListaTrabajo.Click
        abrirFrmHijo(New FrmListaTrabajo())
    End Sub
End Class