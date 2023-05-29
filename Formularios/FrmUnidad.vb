Public Class FrmUnidad
    Public Property resultado As Boolean
    Dim unidad As New Unidad
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxtNombre.Text = "" Or TxtDescripción.Text = "" Then
            MsgBox("Debe ingresar un nombre para la nueva unidad", MsgBoxStyle.Information, "Nueva Unidad")
            Exit Sub
        End If

        Dim unidad As New Unidad
        Dim dUnidad As New DUnidad
        unidad.Nombre = TxtNombre.Text
        unidad.Descripcion = TxtDescripción.Text
        If Not dUnidad.insertarUnidad(unidad) Then
            MsgBox("Ocurrio un error al guardar la unidad de medida", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        resultado = True
        MsgBox("Unidad guardada correctamente", MsgBoxStyle.Information, "Nueva Unidad")

    End Sub

    Private Sub FrmUnidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTabla()
    End Sub

    Private Sub cargarTabla()
        Dim dUnidad As New DUnidad
        Dim ds As New DataSet
        ds = dUnidad.listarUnidades()
        DgvUnidad.DataSource = ds.Tables(0)
        DgvUnidad.Refresh()

        DgvUnidad.Columns("idUnidad").Visible = False
        DgvUnidad.Columns("descripcion").Visible = False

    End Sub



    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtBuscar.Text = ""
        TxtDescripción.Text = ""
        BtnGuardar.Enabled = True
        BtnEditar.Enabled = False
        BtnBorrar.Enabled = False
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If TxtBuscar.Text = "" Then
            Dim dUnidad As New DUnidad
            Dim ds As New DataSet
            ds = dUnidad.buscarUnidad(TxtBuscar.Text())
            DgvUnidad.DataSource = ds.Tables(0)
            DgvUnidad.Refresh()
        End If
    End Sub

    Private Sub DgvUnidad_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUnidad.CellClick
        Dim i As Integer
        i = DgvUnidad.CurrentRow.Index
        unidad.IdUnidad = DgvUnidad.Rows(i).Cells(0).Value
        unidad.Nombre = DgvUnidad.Rows(i).Cells(1).Value
        unidad.Descripcion = DgvUnidad.Rows(i).Cells(2).Value


        TxtNombre.Text = unidad.Nombre
        TxtDescripción.Text = unidad.Descripcion

        BtnGuardar.Enabled = False
        BtnEditar.Enabled = True
        BtnBorrar.Enabled = True

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If unidad.Nombre = TxtNombre.Text And TxtDescripción.Text = unidad.Descripcion Then
            MsgBox("No se han realizado cambios", MsgBoxStyle.Information, "Editar Unidad")
            Exit Sub
        End If

        Dim dUnidad As New DUnidad
        unidad.Nombre = TxtNombre.Text
        unidad.Descripcion = TxtDescripción.Text
        If Not dUnidad.modificarUnidad(unidad) Then
            MsgBox("Ocurrio un error al editar la unidad de medida", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        resultado = True
        cargarTabla()
        MsgBox("Unidad editada correctamente", MsgBoxStyle.Information, "Editar Unidad")
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        'pregunta que si deseas borrar la unidad seleccionada, dependiendo de esta respuesta la borarremos o no
        Dim respuesta As Integer
        respuesta = MsgBox("¿Desea borrar la unidad seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Borrar Unidad")
        If Not respuesta = MsgBoxResult.Yes Then
            Exit Sub
        End If

        Dim dUnidad As New DUnidad
        If Not dUnidad.eliminarUnidad(unidad.IdUnidad) Then
            MsgBox("Ocurrio un error al borrar la unidad de medida", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        resultado = True
        cargarTabla()
        MsgBox("Unidad borrada correctamente", MsgBoxStyle.Information, "Borrar Unidad")




    End Sub

    Private Sub BtnBuscarEstudio_Click(sender As Object, e As EventArgs) Handles BtnBuscarEstudio.Click
        Dim dUnidad As New DUnidad
        Dim ds As New DataSet
        ds = dUnidad.buscarUnidad(TxtBuscar.Text())
        DgvUnidad.DataSource = ds.Tables(0)
        DgvUnidad.Refresh()
    End Sub
End Class