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
End Class