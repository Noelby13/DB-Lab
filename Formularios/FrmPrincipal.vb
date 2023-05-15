Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class FrmPrincipal
    Friend Property usuario As Usuario
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultarBotones()
        ocultarSubMenu()
        cargarMenuSegunPermisos()
        cargarBotones()
        ocultarSubMenu()

        Size = Screen.PrimaryScreen.WorkingArea.Size
        Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If Not MsgBox("Estas seguro de salir?", vbYesNo + vbQuestion, "Salir") = vbYes Then
            e.Cancel = True
        End If

        If FrmActual IsNot Nothing AndAlso Not FrmActual.IsDisposed Then
            FrmActual.Close()
        End If

    End Sub

    'Todos los paneles y botonos estan ocultos por defecto.
    'Establece que panel y boton se muestran segun los permisos del usuario.
    'La logica es que si un boton esta visible, entonces el panel que lo contiene tambien lo esta.
    'Es importante primero mostrar el panel orrespondiente y luego el boton, ya que el boton esta contenido en el panel
    ' y de lo contrario el boton no se mostrara.
    Private Sub cargarMenuSegunPermisos()
        Dim dUsuario As New DUsuario
        Dim funciones = dUsuario.obtenerListaPermisos(usuario)
        For Each funcion In funciones
            Select Case funcion
                Case 1
                    'PanelSubOrdenes.Visible = True
                    'BtnFacturar.Visible = True
                Case 3
                    PanelSubUsuario.Show()
                    BtnCrearUsuario.Show()

                Case 4
                    PanelSubUsuario.Show()
                    BtnCrearRol.Show()
                Case 5
                    PanelSubExamenes.Show()
                    BtnCrearCategoria.Show()

                Case 6
                    PanelSubExamenes.Show()
                    BtnAgregarExamen.Show()
                Case 7
                    PanelSubExamenes.Show()
                    BtnAgregarEstudio.Show()
                Case 8
                    PanelSubPaciente.Show()
                    BtnPaciente.Show()
                Case 9
                    PanelSubOrdenes.Show()
                    BtnFacturar.Show()


                Case 10
                    PanelSubOrdenes.Show()
                    BtnCancelarFactura.Show()
                Case 11
                    PanelSubResultado.Show()
                    BtnListaTrabajo.Show()
                Case 12
                    PanelSubResultado.Show()
                    BtnActualizacionResultado.Show()
            End Select
        Next


    End Sub
    'Chequea si un panel esta visible y muestra el boton correspondiente.
    'De lo contrario, el boton no se mostrara.
    'Supongase que si los botonos del subpanel no estan visibles, él boton que llama ese subpanel estaría de adorno XD
    Private Sub cargarBotones()



        If PanelSubUsuario.Visible = True Then
            BtnUsuario.Visible = True
        End If
        If PanelSubPaciente.Visible = True Then
            BtnPaciente.Visible = True
        End If
        If PanelSubExamenes.Visible = True Then
            BtnExamenes.Visible = True
        End If
        If PanelSubOrdenes.Visible = True Then
            BtnOrdenes.Visible = True
        End If
        If PanelSubResultado.Visible = True Then
            BtnResultados.Visible = True
        End If


    End Sub
    Private Sub ocultarBotones()
        'BtnUsuario.Visible = False
        'BtnPaciente.Visible = False
        'BtnExamenes.Visible = False
        'BtnOrdenes.Visible = False
        'BtnResultados.Visible = False
        BtnUsuario.Hide()
        BtnPaciente.Hide()
        BtnExamenes.Hide()
        BtnOrdenes.Hide()
        BtnResultados.Hide()
        BtnFacturar.Hide()
        BtnListaTrabajo.Hide()
        BtnCrearRol.Hide()
        BtnCrearCategoria.Hide()
        BtnAgregarExamen.Hide()
        BtnAgregarEstudio.Hide()
        BtnCancelarFactura.Hide()
        BtnActualizacionResultado.Hide()
        BtnListaTrabajo.Hide()
        BtnCrearUsuario.Hide()





    End Sub

    Private Sub ocultarSubMenu()
        'PanelSubUsuario.Visible = False
        'PanelSubPaciente.Visible = False
        'PanelSubExamenes.Visible = False
        'PanelSubOrdenes.Visible = False
        'PanelSubResultado.Visible = False
        PanelSubUsuario.Hide()
        PanelSubPaciente.Hide()
        PanelSubExamenes.Hide()
        PanelSubOrdenes.Hide()
        PanelSubResultado.Hide()

    End Sub


    Private Sub mostrarSubMenu(subMenu As Panel)
        Dim fila As Integer = TableLayoutPanel1.GetRow(subMenu)
        If subMenu.Visible = False Then
            ocultarSubMenu()
            subMenu.Visible = True

        Else
            subMenu.Visible = False
        End If


    End Sub
    'Private Sub mostrarSubMenu(subMenu As Panel)
    '    Dim fila As Integer = TableLayoutPanel1.GetRow(subMenu)

    '    If subMenu.Visible = True Then
    '        ocultarSubMenu()
    '        subMenu.Visible = True
    '        TableLayoutPanel1.RowStyles(fila).SizeType = SizeType.AutoSize
    '    Else
    '        subMenu.Visible = False
    '        TableLayoutPanel1.RowStyles(fila).SizeType = SizeType.Absolute
    '        TableLayoutPanel1.RowStyles(fila).Height = subMenu.Height
    '    End If
    'End Sub

    'genera un metodo llamado mostrarSubMenu para cada boton del menu
    'Private Sub mostrarSubMenu(subMenu As Panel)
    '    Dim fila As Integer = TableLayoutPanel1.GetRow(subMenu)
    '    If subMenu.Visible = True Then
    '        ocultarSubMenu()
    '        subMenu.Visible = True
    '        TableLayoutPanel1.RowStyles(fila).SizeType = SizeType.AutoSize
    '        MsgBox(fila)
    '    Else
    '        subMenu.Visible = False
    '        TableLayoutPanel1.RowStyles(fila).SizeType = SizeType.Absolute
    '        TableLayoutPanel1.RowStyles(fila).Height = subMenu.Height
    '    End If
    'End Sub

    Private Sub BtnUsuario_Click(sender As Object, e As EventArgs) Handles BtnUsuario.Click
        mostrarSubMenu(PanelSubUsuario)
        'Dim panelSeleccionado As Panel = PanelSubUsuario ' Reemplaza "Panel1" por el nombre del panel que deseas mostrar

        '' Oculta todos los paneles del TableLayoutPanel
        'For Each panel As Panel In TableLayoutPanel1.Controls
        '    panel.Visible = False
        'Next

        '' Muestra el panel seleccionado
        'panelSeleccionado.Visible = True
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
        'Me.Size = New Size(1106, 940)

        abrirFrmHijo(New FrmUsuario())
    End Sub

    Private Sub BtnFacturar_Click(sender As Object, e As EventArgs) Handles BtnFacturar.Click
        'Me.Size = New Size(1106, 940)

        abrirFrmHijo(New FrmFacturarOrdenes())
    End Sub

    Private Sub BtnCrearRol_Click(sender As Object, e As EventArgs) Handles BtnCrearRol.Click
        'Me.Size = New Size(1106, 940)

        abrirFrmHijo(New FrmRol())
    End Sub

    Private Sub BtnCrearCategoria_Click(sender As Object, e As EventArgs) Handles BtnCrearCategoria.Click
        abrirFrmHijo(New FrmCategorias())
    End Sub

    Private Sub BtnListaTrabajo_Click(sender As Object, e As EventArgs) Handles BtnListaTrabajo.Click

        abrirFrmHijo(New FrmListaTrabajo())
    End Sub

    Private Sub BtnAgregarPaciente_Click(sender As Object, e As EventArgs) Handles BtnAgregarPaciente.Click
        'Me.Size = New Size(1106, 940)

        abrirFrmHijo(New FrmPaciente())
    End Sub

    Private Sub BtnAgregarEstudio_Click(sender As Object, e As EventArgs) Handles BtnAgregarEstudio.Click
        abrirFrmHijo(New FrmAgregarEstudio())
    End Sub

    Private Sub BtnAgregarExamen_Click(sender As Object, e As EventArgs) Handles BtnAgregarExamen.Click
        abrirFrmHijo(New FrmAgregarExamen())
    End Sub

    Private Sub BtnCancelarFactura_Click(sender As Object, e As EventArgs) Handles BtnCancelarFactura.Click
        abrirFrmHijo(New FrmCancelarFactura())
    End Sub

    Private Sub BtnActualizacionResultado_Click(sender As Object, e As EventArgs) Handles BtnActualizacionResultado.Click
        abrirFrmHijo(New FrmActualizacióResultados())
    End Sub


End Class