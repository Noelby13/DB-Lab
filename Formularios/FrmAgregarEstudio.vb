Imports System.Windows.Forms.VisualStyles

Public Class FrmAgregarEstudio
    Dim dUnidad As New DUnidad
    Dim estudio As New Estudio
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNombre.Clear()

        TxtValorTextoM.Clear()
        TxtValorInferiorM.Clear()
        TxtValorSuperiorM.Clear()

        TxtValorTextoH.Clear()
        TxtValorInferiorH.Clear()
        TxtValorSuperiorH.Clear()

        CbxUnidad1.SelectedIndex = -1
        CbxUnidad2.SelectedIndex = -1
        BtnGuardarIcon.Enabled = True
        BtnEditar.Enabled = False
        BtnBorrar.Enabled = False


    End Sub

    Private Sub llenarCombo()

        Dim ds = dUnidad.listarUnidades()
        CbxUnidad1.Items.Clear()
        CbxUnidad2.Items.Clear()

        CbxUnidad1.DataSource = ds.Tables(0)
        CbxUnidad1.DisplayMember = "Nombre"
        CbxUnidad1.ValueMember = "idUnidad"

        CbxUnidad2.DataSource = ds.Tables(0)
        CbxUnidad2.DisplayMember = "Nombre"
        CbxUnidad2.ValueMember = "idUnidad"


        CbxUnidad1.DropDownStyle = ComboBoxStyle.DropDownList
        CbxUnidad2.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub


    Private Sub FrmAgregarEstudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombo()
        llenarTabla()
    End Sub


    Private Function validarCampos() As Boolean
        Dim resultado = True

        Dim texto As String = TxtValorTextoH.Text.Trim()
        Dim valorInferior As String = TxtValorInferiorH.Text.Trim()
        Dim valorSuperior As String = TxtValorSuperiorH.Text.Trim()

        If TxtNombre.Text = "" Then
            MsgBox("Debe ingresar un nombre para el estudio", MsgBoxStyle.Information, "Nuevo Estudio")
            resultado = False
        End If
        'validar campos de mujeres
        If Not texto = "" AndAlso valorInferior <> "" AndAlso valorSuperior <> "" Then
            resultado = False
        End If

        If Not texto <> "" AndAlso valorInferior = "" AndAlso valorSuperior = "" Then
            resultado = False
        End If
        'validar que no selecionen gestionar unidad
        'If CbxUnidad1.SelectedItem = "Gestionar Unidad" Or CbxUnidad2.SelectedItem = "Gestionar Unidad" Then
        '    MsgBox("Debe seleccionar una unidad de medida", MsgBoxStyle.Information, "Nueva Unidad")
        '    resultado = False
        'End If
        'validar que las unidades sean iguales
        If CbxUnidad1.SelectedValue <> CbxUnidad2.SelectedValue Then
            MsgBox("Las unidades de medida deben ser iguales", MsgBoxStyle.Information, "Nueva Unidad")
            resultado = False
        End If

        'validar campos de hombre
        texto = TxtValorTextoM.Text.Trim()
        valorInferior = TxtValorInferiorM.Text.Trim()
        valorSuperior = TxtValorSuperiorM.Text.Trim()

        If Not texto = "" AndAlso valorInferior <> "" AndAlso valorSuperior <> "" Then
            resultado = False
        End If

        If Not texto <> "" AndAlso valorInferior = "" AndAlso valorSuperior = "" Then
            resultado = False
        End If

        Return resultado


    End Function

    Private Sub BtnGuardarIcon_Click(sender As Object, e As EventArgs) Handles BtnGuardarIcon.Click
        'Dim prueba As New Unidad
        'prueba = Unidad(CbxUnidad1.Items(0))





        If Not validarCampos() Then
            Exit Sub
        End If

        Dim estudio As New Estudio()
        estudio.NombreEstudio = TxtNombre.Text
        estudio.IdUnidad = CbxUnidad1.SelectedValue
        estudio.ValorTextoH = TxtValorTextoH.Text
        estudio.ValorInferiorH = TxtValorInferiorH.Text
        estudio.ValorSuperiorH = TxtValorSuperiorH.Text
        estudio.ValorTextoM = TxtValorTextoM.Text
        estudio.ValorInferiorM = TxtValorInferiorM.Text
        estudio.ValorSuperiorM = TxtValorSuperiorM.Text

        Dim dEstuido As New DEstudio
        If Not dEstuido.insertarEstudio(estudio) Then
            MsgBox("Error al guardar el estudio", MsgBoxStyle.Critical, "Nuevo Estudio")
            Exit Sub
        End If
        BtnLimpiar.PerformClick()
        llenarTabla()
        MsgBox("Estudio guardado correctamente", MsgBoxStyle.Information, "Nuevo Estudio")


    End Sub

    Private Sub selecionarFila()
        Dim i As Integer
        i = DgvEstudio.CurrentRow.Index
        estudio.IdEstudio = DgvEstudio.Rows(i).Cells(0).Value
        estudio.NombreEstudio = DgvEstudio.Rows(i).Cells(1).Value
        estudio.ValorInferiorH = DgvEstudio.Rows(i).Cells(2).Value
        estudio.ValorSuperiorH = DgvEstudio.Rows(i).Cells(3).Value
        estudio.ValorTextoH = DgvEstudio.Rows(i).Cells(4).Value
        estudio.ValorInferiorM = DgvEstudio.Rows(i).Cells(5).Value
        estudio.ValorSuperiorM = DgvEstudio.Rows(i).Cells(6).Value
        estudio.ValorTextoM = DgvEstudio.Rows(i).Cells(7).Value
        estudio.IdUnidad = DgvEstudio.Rows(i).Cells(9).Value

        TxtNombre.Text = estudio.NombreEstudio
        TxtValorInferiorH.Text = estudio.ValorInferiorH
        TxtValorSuperiorH.Text = estudio.ValorSuperiorH
        TxtValorTextoH.Text = estudio.ValorTextoH
        TxtValorInferiorM.Text = estudio.ValorInferiorM
        TxtValorSuperiorM.Text = estudio.ValorSuperiorM
        TxtValorTextoM.Text = estudio.ValorTextoM
        CbxUnidad1.SelectedValue = estudio.IdUnidad
        CbxUnidad2.SelectedValue = estudio.IdUnidad

        BtnGuardarIcon.Enabled = False
        BtnBorrar.Enabled = True
        BtnEditar.Enabled = True
    End Sub

    Private Sub DgvEstudio_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEstudio.CellClick
        selecionarFila()
    End Sub


    Private Sub llenarTabla()
        Dim ds As New DataSet
        Dim dEstudio As New DEstudio
        ds = dEstudio.listarEstudios()
        DgvEstudio.DataSource = ds.Tables(0)
        DgvEstudio.Columns(0).Visible = False
        DgvEstudio.Columns(1).HeaderText = "Nombre"
        DgvEstudio.Columns(2).HeaderText = "Valor Inferior H"
        DgvEstudio.Columns(3).HeaderText = "Valor Superior H"
        DgvEstudio.Columns(4).HeaderText = "Valor Texto H"
        DgvEstudio.Columns(5).HeaderText = "Valor Inferior M"
        DgvEstudio.Columns(6).HeaderText = "Valor Superior M"
        DgvEstudio.Columns(7).HeaderText = "Valor Texto M"
        DgvEstudio.Columns(8).HeaderText = "Unidad"
        DgvEstudio.Columns(9).Visible = False

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim dEstudio As New DEstudio
        If Not validarCampos() Then
            Exit Sub
        End If

        estudio.NombreEstudio = TxtNombre.Text
        estudio.IdUnidad = CbxUnidad1.SelectedValue
        estudio.ValorTextoH = TxtValorTextoH.Text
        estudio.ValorInferiorH = TxtValorInferiorH.Text
        estudio.ValorSuperiorH = TxtValorSuperiorH.Text
        estudio.ValorTextoM = TxtValorTextoM.Text
        estudio.ValorInferiorM = TxtValorInferiorM.Text
        estudio.ValorSuperiorM = TxtValorSuperiorM.Text
        If Not dEstudio.actualizarEstudio(estudio) Then
            MsgBox("Error al actualizar el estudio", MsgBoxStyle.Critical, "Editar Estudio")
            Exit Sub
        End If
        BtnLimpiar.PerformClick()
        llenarTabla()
        MsgBox("Estudio actualizado correctamente", MsgBoxStyle.Information, "Editar Estudio")
    End Sub


    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Dim respuesta = MsgBox("¿Esta seguro de eliminar el estudio" & TxtNombre.Text & "?", MsgBoxStyle.YesNo, "Eliminar Estudio")
        If Not respuesta = MsgBoxResult.Yes Then
            Exit Sub
        End If

        Dim dEstudio As New DEstudio
        If Not dEstudio.eliminarEstudio(estudio) Then
            MsgBox("Error al eliminar el estudio", MsgBoxStyle.Critical, "Eliminar Estudio")
            Exit Sub
        End If
        BtnLimpiar.PerformClick()
        llenarTabla()

    End Sub

    Private Sub BtnBuscarEstudio_Click(sender As Object, e As EventArgs) Handles BtnBuscarEstudio.Click
        If TxtBuscar.Text = "" Then
            MsgBox("Ingrese el nombre del estudio a buscar", MsgBoxStyle.Information, "Buscar Estudio")
            Exit Sub
        End If

        Dim ds As New DataSet
        Dim dEstudio As New DEstudio
        ds = dEstudio.buscarEstudio(TxtBuscar.Text)
        DgvEstudio.DataSource = ds.Tables(0)
        DgvEstudio.Columns(0).Visible = False
        DgvEstudio.Columns(1).HeaderText = "Nombre"
        DgvEstudio.Columns(2).HeaderText = "Valor Inferior H"
        DgvEstudio.Columns(3).HeaderText = "Valor Superior H"
        DgvEstudio.Columns(4).HeaderText = "Valor Texto H"
        DgvEstudio.Columns(5).HeaderText = "Valor Inferior M"
        DgvEstudio.Columns(6).HeaderText = "Valor Superior M"
        DgvEstudio.Columns(7).HeaderText = "Valor Texto M"
        DgvEstudio.Columns(8).HeaderText = "Unidad"
        DgvEstudio.Columns(9).Visible = False

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If TxtBuscar.Text = "" Then
            llenarTabla()
        End If
    End Sub
End Class