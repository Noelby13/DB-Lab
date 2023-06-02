Public Class FrmExamen
    'Dataset que se utilizan para cargar las tablas
    Dim dataEstudio As New DataSet
    Dim dataExamen As New DataSet
    Dim dataDetalles As New DataSet
    Dim dataNueva As New DataSet ' Cuando estemos editando un examen, se guardaran los detalles nuevos en este dataset
    Dim dataEliminada As New DataSet 'Cuando estemos editando un examen, se guardaran los detalles eliminados en este dataset
    'Entidad que se utiliza para empaquetar la información y mandarla al dao 
    Dim examen As New Examen
    'Datos
    Dim dEstudio As New DEstudio
    Dim dExamen As New DExamen
    Dim dExamenEstudio As New DExamenEstudio
    Dim modoEdicion As Boolean = False


    Private Sub FrmExamen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataEstudio = dEstudio.listarEstudios() 'Sirve para cargar la tabla de estudios
        dataExamen = dExamen.listarExamenes() ' S funcion es cargar la tabla de examenes
        cargarTablaEstudios()
        cargarCombobox()
        cargarTablaExamenes()

    End Sub



    Private Sub cargarTablaEstudios()
        'La logica es que se cargue la tabla de estudios con todos los estudios que estan en el atributos llamado DATA
        'cada que vez que necesitas recargar la tabla, asignas el nuevo valor al dataset y refrescas la tabla

        DgvEstudios.DataSource = dataEstudio.Tables(0)
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

    Private Sub cargarTablaExamenes()
        DgvExamenes.DataSource = dataExamen.Tables(0)
        DgvExamenes.Refresh()


    End Sub

    Private Sub cargarDetalles()

        'DgvDetalleExamen.DataSource = dataDetalles.Tables(0)

        'DgvDetalleExamen.Refresh()

        'rellena el datagridview con los detalles del examen con un for
        DgvDetalleExamen.Rows.Clear()
        For Each row As DataRow In dataDetalles.Tables(0).Rows
            DgvDetalleExamen.Rows.Add(row(0), row(1))
        Next
        DgvDetalleExamen.Refresh()
    End Sub

    Private Sub DgvExamenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvExamenes.CellClick
        Dim i As Integer
        'validar que la fila no este vacia
        If DgvExamenes.CurrentRow Is Nothing Then
            Return
        End If

        i = DgvExamenes.CurrentRow.Index
        examen.IdExamen = DgvExamenes.Rows(i).Cells(0).Value
        examen.Nombre = DgvExamenes.Rows(i).Cells(1).Value
        examen.Descripcion = DgvExamenes.Rows(i).Cells(2).Value
        examen.Precio = DgvExamenes.Rows(i).Cells(3).Value

        TxtNombre.Text = examen.Nombre
        TxtDescripcion.Text = examen.Descripcion
        TxtPrecio.Text = examen.Precio
        CbxCategoria.Text = DgvExamenes.Rows(i).Cells(4).Value
        BtnGuardarIcon.Enabled = False
        BtnEditar.Enabled = True
        BtnBorrar.Enabled = True
        modoEdicion = True
        dataDetalles = dExamenEstudio.mostrarDetalles(examen.IdExamen)
        cargarDetalles()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub cargarCombobox()
        Dim dCategoria As New DCategoria
        Dim ds As New DataSet
        ds = dCategoria.mostrarRegistros()
        CbxCategoria.DataSource = ds.Tables(0)
        CbxCategoria.DisplayMember = "Nombre"
        CbxCategoria.ValueMember = "Código"
    End Sub


    Private Sub BtnAñadirD_Click(sender As Object, e As EventArgs) Handles BtnAñadirD.Click
        Try
            Dim fila As Integer
            Dim estudio As New Estudio

            'valida en el caso que no se seleccione ninguna fila
            If DgvEstudios.CurrentRow Is Nothing Then
                MsgBox("Seleccione un estudio", MsgBoxStyle.Information, "Añadir Estudio")
                Exit Sub
            End If

            fila = DgvEstudios.CurrentRow.Index
            estudio.IdEstudio = DgvEstudios.Rows(fila).Cells(0).Value
            estudio.NombreEstudio = DgvEstudios.Rows(fila).Cells(1).Value

            'Verificar si ya existe el estudio en la lista
            For Each r As DataGridViewRow In DgvDetalleExamen.Rows
                If r.Cells(0).Value = estudio.IdEstudio Then
                    MsgBox("El estudio ya existe en la lista", MsgBoxStyle.Information, "Añadir Estudio")
                    Exit Sub
                End If
            Next

            'DgvDetalleExamen.Rows.Add(estudio.IdEstudio, estudio.NombreEstudio)
            'DgvDetalleExamen.Refresh()

            'Agregamos solo visualmente los datos a la tabla. Para guardarlo de verdad, se debe guardar mediante btnGuardar
            If modoEdicion Then
                If dataNueva.Tables.Count = 0 Then
                    'Creamos la tabla
                    Dim dt As New DataTable
                    dt.Columns.Add("ID", GetType(Integer))
                    dt.Columns.Add("Nombre", GetType(String))
                    dataNueva.Tables.Add(dt)
                End If

                Dim r As DataRow
                    r = dataNueva.Tables(0).NewRow()
                    r("ID") = estudio.IdEstudio
                    r("Nombre") = estudio.NombreEstudio
                dataNueva.Tables(0).Rows.Add(r)
            End If


            'Agregamos los datos a la tabla. Si no existe la tabla, la creamos
            If dataDetalles.Tables.Count = 0 Then
                'Creamos la tabla
                Dim dt As New DataTable
                dt.Columns.Add("ID", GetType(Integer))
                dt.Columns.Add("Nombre", GetType(String))
                dataDetalles.Tables.Add(dt)

            End If

            Dim row As DataRow
                row = dataDetalles.Tables(0).NewRow()
                row("ID") = estudio.IdEstudio
                row("Nombre") = estudio.NombreEstudio
                dataDetalles.Tables(0).Rows.Add(row)




            'AcceptChanges es para que se guarden los cambios en el dataset, solo se guardan en el dataset, no en la base de datos
            'Esto luego lo vamos a ocupar para ver si elimino o agrego un nuevo registro al  Dataset

            'dataDetalles.AcceptChanges()
            'DgvDetalleExamen.DataSource = dataDetalles.Tables(0)

            cargarDetalles()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Ocurrio un error al añadir el estudio", MsgBoxStyle.Critical, "Añadir Estudio")
        End Try


    End Sub

    Private Sub BtnQuitarD_Click(sender As Object, e As EventArgs) Handles BtnQuitarD.Click
        Dim fila As Integer
        'validar en caso que no se seleccione ninguna fila
        If DgvDetalleExamen.CurrentRow Is Nothing Then
            'MsgBox("Seleccione un estudio", MsgBoxStyle.Information, "Quitar Estudio")
            Exit Sub
        End If

        'validar si esta en modo edicion, si es asi, solo lo elimina visualmente, pero no de la base de datos. 
        'se guarda en una dataset para luego eliminarlo

        If modoEdicion Then
            If dataEliminada.Tables.Count = 0 Then
                Dim dTable As New DataTable
                dTable.Columns.Add("ID", GetType(Integer))
                dTable.Columns.Add("Nombre", GetType(String))
                dataEliminada.Tables.Add(dTable)
            End If

            Dim row As DataRow
            row = dataEliminada.Tables(0).NewRow()
            row("ID") = DgvDetalleExamen.Rows(fila).Cells(0).Value
            row("Nombre") = DgvDetalleExamen.Rows(fila).Cells(1).Value
            dataEliminada.Tables(0).Rows.Add(row)

        End If

        'solo elimina del datagridview, no del dataset, por lo que no es necesario darle acceptchanges
        fila = DgvDetalleExamen.CurrentRow.Index
        'Eliminalo del dataset
        dataDetalles.Tables(0).Rows(fila).Delete()
        dataDetalles.AcceptChanges()

        cargarDetalles()
    End Sub

    Private Sub TxtBuscarEstudio_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarEstudio.TextChanged
        Dim cadena = TxtBuscarEstudio.Text
        dataEstudio = dEstudio.buscarEstudio(cadena)
        cargarTablaEstudios()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNombre.Clear()
        TxtDescripcion.Clear()
        TxtPrecio.Clear()
        CbxCategoria.SelectedIndex = -1
        'DgvDetalleExamen.Rows.Clear()

        dataDetalles.Clear()
        dataNueva.Clear()
        cargarDetalles()
        BtnGuardarIcon.Enabled = True
        BtnEditar.Enabled = False
        BtnBorrar.Enabled = False
        modoEdicion = False
    End Sub

    Private Sub BtnGuardarIcon_Click(sender As Object, e As EventArgs) Handles BtnGuardarIcon.Click
        If TxtNombre.Text = "" Or TxtPrecio.Text = "" Or CbxCategoria.SelectedIndex = -1 Then
            MsgBox("Ingrese todos los datos", MsgBoxStyle.Information, "Guardar")
            Exit Sub
        End If

        If DgvDetalleExamen.Rows.Count = 0 Then
            MsgBox("Ingrese al menos un estudio", MsgBoxStyle.Information, "Guardar")
            Exit Sub
        End If

        Dim examen As New Examen
        examen.Nombre = TxtNombre.Text
        examen.Descripcion = TxtDescripcion.Text
        examen.Precio = Convert.ToDecimal(TxtPrecio.Text())
        examen.IdCategoria = CbxCategoria.SelectedValue
        If dExamen.existeExamen(examen.Nombre) Then
            MsgBox("El examen ya existe", MsgBoxStyle.Information, "Guardar")
            Exit Sub
        End If

        Dim idExamen As Integer
        idExamen = dExamen.guardarExamen(examen)

        If idExamen = -1 Then
            MsgBox("Error al guardar el examen", MsgBoxStyle.Information, "Guardar")
            Exit Sub
        End If

        Dim res As Boolean
        For Each row As DataGridViewRow In DgvDetalleExamen.Rows
            Dim detalleExamen As New ExamenEstudio
            detalleExamen.IdExamen = idExamen
            detalleExamen.IdEstudio = row.Cells(0).Value
            res = dExamenEstudio.guardarExamenEstudio(detalleExamen)
            If Not res Then
                MsgBox("Error al guardar el estudio: " & row.Cells(1).Value, MsgBoxStyle.Information, "Guardar")
            End If
        Next

        MsgBox("Examen registrado correctamente", MsgBoxStyle.Information, "Guardar")
        dataExamen = dExamen.listarExamenes()
        cargarTablaExamenes()
        BtnLimpiar.PerformClick()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        'validamos que se hayan ingresado todos los datos
        If TxtNombre.Text = "" Or TxtPrecio.Text = "" Or CbxCategoria.SelectedIndex = -1 Then
            MsgBox("Ingrese todos los datos", MsgBoxStyle.Information, "Guardar")
            Exit Sub
        End If

        Dim existeCambios = False
        If Not TxtNombre.Text = examen.Nombre And Convert.ToDecimal(TxtPrecio.Text()) = examen.Precio And TxtDescripcion.Text = examen.Descripcion And CbxCategoria.SelectedValue = examen.IdCategoria Then
            existeCambios = True
        End If

        Dim datos = dataExamen.Tables()

        If Not datos Is Nothing Then
            existeCambios = True
        End If

        If Not existeCambios Then
            MsgBox("No se han realizado cambios", MsgBoxStyle.Information, "Guardar")
            Exit Sub
        End If


        Dim res As Boolean
        examen.Nombre = TxtNombre.Text
        examen.Descripcion = TxtDescripcion.Text
        examen.Precio = Convert.ToDecimal(TxtPrecio.Text())
        examen.IdCategoria = CbxCategoria.SelectedValue

        If Not dExamen.actualizarExamen(examen) Then
            MsgBox("Error al actualizar los datos del examen", MsgBoxStyle.Information, "Editar")
        End If

        'valida que dataEliminada contenga datos


        If dataEliminada IsNot Nothing AndAlso dataEliminada.Tables.Count > 0 AndAlso dataEliminada.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In dataEliminada.Tables(0).Rows
                Dim detalleExamen As New ExamenEstudio
                detalleExamen.IdExamen = examen.IdExamen
                detalleExamen.IdEstudio = row("ID")

                res = dExamenEstudio.borrarEstudio(detalleExamen)

                If Not res Then
                    MsgBox("Error al eliminar los estudios de la prueba", MsgBoxStyle.Information, "Guardar")
                    Exit Sub
                End If
            Next
        End If


        'If dataEliminada.Tables(0).Rows.Count > 0 Then
        '    'recorre el dataset y elimina los estudios que se hayan eliminado

        'End If

        'recorre el dataNueva y guarda los estudios que se hayan agregado   
        If dataNueva IsNot Nothing AndAlso dataNueva.Tables.Count > 0 AndAlso dataNueva.Tables(0).Rows.Count > 0 Then
            'recorre el dataset y elimina los estudios que se hayan eliminado
            For Each row As DataRow In dataNueva.Tables(0).Rows
                Dim detalleExamen As New ExamenEstudio
                detalleExamen.IdExamen = examen.IdExamen
                detalleExamen.IdEstudio = row("ID")

                res = dExamenEstudio.guardarExamenEstudio(detalleExamen)

                If Not res Then
                    MsgBox("Error al agregar nuevos estudios al examen", MsgBoxStyle.Information, "Guardar")
                    Exit Sub
                End If
            Next
        End If

        'If Not dExamenEstudio.borrarDetalles(examen.IdExamen) Then
        '    MsgBox("Error al actualizar el examen", MsgBoxStyle.Information, "Guardar")
        '    Exit Sub
        'End If

        ''recorre el datagridview y guarda los detalles
        'For Each row As DataGridViewRow In DgvDetalleExamen.Rows
        '    Dim detalleExamen As New ExamenEstudio
        '    detalleExamen.IdExamen = examen.IdExamen
        '    detalleExamen.IdEstudio = row.Cells(0).Value
        '    res = dExamenEstudio.guardarExamenEstudio(detalleExamen)
        '    If Not res Then
        '        MsgBox("Error al guardar el estudio: " & row.Cells(1).Value, MsgBoxStyle.Information, "Guardar")
        '    End If

        BtnLimpiar.PerformClick()
        MsgBox("Examen actualizado correctamente", MsgBoxStyle.Information, "Guardar")
        dataExamen = dExamen.listarExamenes()
        cargarTablaExamenes()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        'pregunta si desea eliminar el examen
        Dim res As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar el examen?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            If Not dExamen.eliminarExamen(examen.IdExamen) Then
                MsgBox("Error al eliminar el examen", MsgBoxStyle.Information, "Eliminar")
                Exit Sub
            End If
            MsgBox("Examen eliminado correctamente", MsgBoxStyle.Information, "Eliminar")
            dataExamen = dExamen.listarExamenes()
            cargarTablaExamenes()
            BtnLimpiar.PerformClick()
        End If
    End Sub

End Class