Public Class FrmDoctor

    Dim d As New Doctor

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub llenarRegistro()
        Dim dDoctor As New DDoctor
        DgvDoctor.DataSource = dDoctor.mostrarRegistro.Tables(0)
        DgvDoctor.Refresh()

        DgvDoctor.Columns("idDoctor").Visible = False
    End Sub

    Private Sub rellenarComboBox()

    End Sub

    Private Sub FrmDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarRegistro()
    End Sub

    Private Function validarCampos() As Boolean
        Dim B = False
        If (TxtPrimerNombre.Text <> "" And TxtPrimerApellido.Text <> "") Then
            B = True
        End If
        Return B
    End Function



    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtPrimerNombre.Clear()
        TxtSegundoNombre.Clear()
        TxtPrimerApellido.Clear()
        TxtSegundoApellido.Clear()
        TxtBuscar.Clear()
        CbxEspecialidad.SelectedIndex = -1
        'DgvDoctor.DataSource = Nothing
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If Not validarCampos() Then
                MsgBox("La información está incompleta", MsgBoxStyle.Information, "Doctor")
                Exit Sub
            End If

            Dim doctor As New Doctor
            Dim dDoctor As New DDoctor
            doctor.PrimerNombre = TxtPrimerNombre.Text
            doctor.SegundoNombre = comprobarNull(doctor.SegundoNombre, TxtSegundoNombre)
            doctor.PrimerApellido = TxtPrimerApellido.Text
            doctor.SegundoApellido = comprobarNull(doctor.SegundoApellido, TxtSegundoApellido)
            'doctor.Especialidad = CbxEspecialidad.SelectedItem.ToString()
            'dDoctor.insertarDoctor(doctor)

            If dDoctor.guardarDoctor(doctor) Then
                MsgBox("Doctor registrado con éxito", MsgBoxStyle.Information, "Doctor")
            Else
                MsgBox("Ocurrio un error", MsgBoxStyle.Information, "Doctor")
            End If

            llenarRegistro()
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar registrar el doctor", MsgBoxStyle.Information, "Doctor")
        End Try
    End Sub

    Private Function comprobarNull(ByVal campo As String, txt As TextBox) As String
        If String.IsNullOrEmpty(txt.Text.ToString().Trim) = True Then
            campo = Nothing
        Else
            campo = txt.Text
        End If
        Return campo
    End Function

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim dDoctor As New DDoctor

        If Not validarCampos() Then
            MsgBox("Debe seleccionar un elemento")
            Exit Sub
        End If

        d.PrimerNombre = TxtPrimerNombre.Text
        d.SegundoNombre = TxtSegundoNombre.Text
        d.PrimerApellido = TxtPrimerApellido.Text
        d.SegundoApellido = TxtSegundoApellido.Text
        'd.Especialidad = CbxEspecialidad.SelectedItem.ToString()

        Dim resp As VariantType
        resp = (MsgBox("¿Desea editar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CONFIRMACION"))

        If (resp = vbNo) Then
            MsgBox("Operación cancelada",
                       MsgBoxStyle.Information, "Gestión de Doctores")
            Exit Sub
        End If

        Dim editado = dDoctor.editarDoctor(d)
        If (editado) Then
            MsgBox("Registro editado exitosamente",
                       MsgBoxStyle.Information, "Gestión de Doctores")
        End If

        If Not editado Then
            MsgBox("No se pudo editar el registro",
                   MsgBoxStyle.Critical, "ERROR")
        End If
        BtnLimpiar.PerformClick()
        llenarRegistro()

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Dim dDoctor As New DDoctor

        If Not validarCampos() Then
            MsgBox("Debe seleccionar un elemento")
            Exit Sub
        End If



        Dim resp As VariantType
        resp = (MsgBox("¿Desea eliminar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CONFIRMACION"))

        If (resp = vbNo) Then
            MsgBox("Operación cancelada",
                       MsgBoxStyle.Information, "Gestión de Doctores")
            Exit Sub
        End If

        Dim eliminado = dDoctor.eliminarDoctor(d.IdDoctor)
        If (eliminado) Then
            MsgBox("Registro eliminado exitosamente",
                       MsgBoxStyle.Information, "Gestión de Doctores")
        End If

        If Not eliminado Then
            MsgBox("No se pudo eliminar el registro",
                   MsgBoxStyle.Critical, "ERROR")
        End If
        BtnLimpiar.PerformClick()
        llenarRegistro()

    End Sub

    Private Sub DgvDoctor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDoctor.CellClick
        Dim fila As Integer = DgvDoctor.CurrentRow.Index

        d.IdDoctor = DgvDoctor.Rows(fila).Cells(0).Value
        TxtPrimerNombre.Text = DgvDoctor.Rows(fila).Cells(1).Value
        TxtSegundoNombre.Text = DgvDoctor.Rows(fila).Cells(2).Value.ToString()
        TxtPrimerApellido.Text = DgvDoctor.Rows(fila).Cells(3).Value
        TxtSegundoApellido.Text = DgvDoctor.Rows(fila).Cells(4).Value.ToString()
        'CbxEspecialidad.SelectedItem = DgvDoctor.Rows(fila).Cells(5).Value.ToString()

        BtnGuardar.Enabled = False
    End Sub

    Private Sub BtnBuscarEstudio_Click(sender As Object, e As EventArgs) Handles BtnBuscarEstudio.Click
        Dim dDoctor As New DDoctor
        DgvDoctor.DataSource = dDoctor.buscarPorDoctor(TxtBuscar.Text.ToString()).Tables(0)
        DgvDoctor.Refresh()
    End Sub
End Class