﻿Public Class FrmRol
    Dim cantidadFunciones As Integer 'sirve para recorrer los checkbox
    Dim marcadosAhora As New List(Of Object)
    Dim noMarcadosAhora As New List(Of Object)
    Dim recienMarcados As New List(Of Object)
    Dim recienDesmarcados As New List(Of Object)
    Dim estadoAnterior As New Dictionary(Of Object, Boolean)

    Sub llenarRegistros()
        Dim dRol As New DRol
        DgvRegistrosRol.DataSource = dRol.mostrarRegistros().Tables(0)
        DgvRegistrosRol.Refresh()
    End Sub


    Private Sub FrmRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarRegistros()
        rellenarCheckedListItem()
        rellenarPanel()
        LblAdvertencia.Text = ""
    End Sub

    Public Sub obtenerCambios()


        ' Llenamos el estado anterior con los valores actuales
        For i As Integer = 0 To ClbPermisosRol.Items.Count - 1
            estadoAnterior(ClbPermisosRol.Items(i)) = ClbPermisosRol.GetItemChecked(i)
        Next

        ' Luego, después de que las marcas hayan cambiado, puedes usar código similar al siguiente para determinar qué cambió:


        For i As Integer = 0 To ClbPermisosRol.Items.Count - 1
            Dim item = ClbPermisosRol.Items(i)
            Dim marcadoAhora = ClbPermisosRol.GetItemChecked(i)
            If marcadoAhora Then
                marcadosAhora.Add(item)
                If Not estadoAnterior(item) Then
                    recienMarcados.Add(item)
                End If
            Else
                noMarcadosAhora.Add(item)
                If estadoAnterior(item) Then
                    recienDesmarcados.Add(item)
                End If
            End If
        Next

    End Sub
    Public Sub rellenarPanel()
        'Me.Ckb1.AutoSize = True
        'Me.Ckb1.Location = New System.Drawing.Point(16, 16)
        'Me.Ckb1.Name = "Ckb1"
        'Me.Ckb1.Size = New System.Drawing.Size(81, 17)
        'Me.Ckb1.TabIndex = 0
        'Me.Ckb1.Text = "CheckBox1"
        'Me.Ckb1.UseVisualStyleBackColor = True


        Dim dFuncion As New DFuncion

        Dim ds = dFuncion.listarFunciones()

        Dim i As Integer = 0
        cantidadFunciones = ds.Tables(0).Rows.Count
        For Each fila As DataRow In ds.Tables(0).Rows
            Dim ckb As New CheckBox
            ckb.AutoSize = True
            ckb.Location = New System.Drawing.Point(16, 16 + i)
            ckb.Name = fila(0).ToString()
            ckb.Size = New System.Drawing.Size(81, 17)
            ckb.TabIndex = 0
            ckb.Text = fila(1).ToString().ToUpper()
            ckb.UseVisualStyleBackColor = True
            PanelPermisos.Controls.Add(ckb)
            i = i + 20
        Next

    End Sub


    Private Function validarCampo() As Boolean
        Dim resultado = False

        If TxtNombre.Text <> "" Then
            resultado = True
        End If
        Return resultado
    End Function


    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub borrarChecked()
        For i As Integer = 0 To ClbPermisosRol.Items.Count - 1
            ClbPermisosRol.SetItemChecked(i, False)
        Next

    End Sub


    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNombre.Clear()
        LblAdvertencia.Text = ""
        ClbPermisosRol.ClearSelected()
        TxtDescripcion.Clear()
        BtnGuardar.Enabled = True
        borrarChecked()


    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If Not validarCampo() Then
                MsgBox("La información está incompleta", MsgBoxStyle.Exclamation, "ADVERTENCIA")
                Exit Sub
            End If

            Dim rol As New Rol()
            Dim dRol As New DRol
            Dim rolFuncion As New RolFuncion
            Dim dRolFuncion As New DRolFuncion

            rol.Nombre = TxtNombre.Text
            rol.Descripcion = comprobarNull(rol.Descripcion, TxtDescripcion)

            If dRol.comprobarRol(rol) Then
                LblAdvertencia.Text = "Ya existe un rol con ese nombre"
                Exit Sub
            End If

            If dRol.guardarRegistro(rol) Then
                MsgBox("Rol registrado correctamente", MsgBoxStyle.Information, "Gestión de Roles")

                rolFuncion.IdRol = dRol.obtenerIdCreado()
                For Each item As Object In ClbPermisosRol.CheckedItems
                    rolFuncion.IdFuncion = item(0)
                    dRolFuncion.guardarPermiso(rolFuncion)
                Next
                llenarRegistros()
                BtnLimpiar.PerformClick()
            End If

        Catch ex As Exception
            MsgBox("No se pudo registrar el rol", MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub


    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            'Dim fila As Integer = DgvRegistrosRol.CurrentRow.Index
            'Dim rolActual As String = DgvRegistrosRol.Rows(fila).Cells(1).Value

            'If Not validarCampo() Then
            '    MsgBox("La información está incompleta", MsgBoxStyle.Exclamation, "ADVERTENCIA")
            '    Exit Sub
            'End If

            'Dim resp As VariantType
            'resp = (MsgBox("Desea editar los datos y permisos de este rol? Rol: " & rolActual, MsgBoxStyle.Question +
            '           MsgBoxStyle.YesNo, "CONFIRMACIÓN"))
            'If (resp = vbNo) Then
            '    MsgBox("Operación cancelada",
            '           MsgBoxStyle.Information, "Gestión de Roles")
            '    Exit Sub
            'End If

            'Dim rol As New Rol()
            'Dim dRol As New DRol

            'rol.IdRol = DgvRegistrosRol.Rows(fila).Cells(0).Value
            'rol.Nombre = TxtNombre.Text
            'rol.Descripcion = comprobarNull(rol.Descripcion, TxtDescripcion)


            'If dRol.editarRegistro(rol) Then
            '    MsgBox("Rol editado correctamente", MsgBoxStyle.Information, "Gestión de Roles")
            '    llenarRegistros()
            '    BtnLimpiar.PerformClick()
            'End If

            obtenerCambios()
            For Each linea As Object In recienMarcados
                MsgBox(linea.ToString())
            Next

        Catch ex As Exception
            MsgBox("No se pudo editar el rol", MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub


    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Try
            Dim rol As New Rol
            Dim dRol As New DRol

            If Not validarCampo() Then
                MsgBox("La información está incompleta", MsgBoxStyle.Exclamation, "ADVERTENCIA")
                Exit Sub
            End If

            rol.Nombre = TxtNombre.Text

            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar este rol? Rol: " & rol.Nombre, MsgBoxStyle.Question +
                           MsgBoxStyle.YesNo, "CONFIRMACION"))
            If (resp = vbNo) Then
                MsgBox("Operación cancelada",
                           MsgBoxStyle.Information, "Gestión de Roles")
                Exit Sub
            End If

            Dim eliminado = dRol.eliminarRegistro(rol.Nombre)
            If (eliminado) Then
                MsgBox("Rol eliminado correctamente", MsgBoxStyle.Information, "Gestión de Roles")
                BtnLimpiar.PerformClick()
            End If

        Catch ex As Exception
            MsgBox("No se pudo eliminar al usuario",
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        llenarRegistros()
    End Sub


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim dRol As New DRol
        DgvRegistrosRol.DataSource = dRol.buscarXNombre(TxtBuscar.Text.ToString()).Tables(0)
        DgvRegistrosRol.Refresh()
    End Sub


    Sub rellenarCheckedListItem()
        Dim dFuncion As New DFuncion

        ClbPermisosRol.DataSource = dFuncion.listarFunciones().Tables(0)
        ClbPermisosRol.DisplayMember = "nombreFuncion"
        ClbPermisosRol.ValueMember = "idFuncion"
    End Sub


    Private Sub DgvRegistrosRol_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRegistrosRol.CellClick
        'verifa que se seleccione una fila correcta
        If e.RowIndex < 0 Then Exit Sub
        Dim fila As Integer = DgvRegistrosRol.CurrentRow.Index
        TxtNombre.Text = DgvRegistrosRol.Rows(fila).Cells(1).Value
        TxtDescripcion.Text = DgvRegistrosRol.Rows(fila).Cells(2).Value.ToString()
        BtnGuardar.Enabled = False
        Dim dRol As New DRol
        Dim idRol = CInt(DgvRegistrosRol.Rows(fila).Cells(0).Value)
        Dim listaPermisos = dRol.obtenerListaFunciones(idRol)


        'For Each item As Integer In listaPermisos
        '    MsgBox(item.ToString())
        'Next



        'For Each control As Control In PanelPermisos.Controls
        '    If TypeOf control Is CheckBox Then
        '        Dim checkbox = CType(control, CheckBox)
        '        checkbox.Checked = False
        '    End If
        'Next


        'For Each control As Control In PanelPermisos.Controls

        '    MsgBox(listaPermisos.ToString())
        '    If TypeOf control Is CheckBox Then
        '        Dim checkbox As CheckBox = CType(control, CheckBox)
        '        If listaPermisos.Contains(CInt(checkbox.Name)) Then
        '            checkbox.Checked = True
        '        End If
        '    End If
        'Next
        ' Desmarcar todos los items

        borrarChecked()

        ' Preparar una lista para guardar los indices de los elementos a marcar
        Dim indicesAMarcar As New List(Of Integer)

        ' Recorrer la lista y guardar los indices
        For i As Integer = 0 To ClbPermisosRol.Items.Count - 1
            Dim item As DataRowView = DirectCast(ClbPermisosRol.Items(i), DataRowView)
            Dim idFuncion As Integer = CInt(item("idFuncion"))
            If listaPermisos.Contains(idFuncion) Then
                indicesAMarcar.Add(i)
            End If
        Next

        ' Marcar los items usando los indices guardados
        For Each indice As Integer In indicesAMarcar
            ClbPermisosRol.SetItemChecked(indice, True)
        Next





    End Sub


    Private Function comprobarNull(ByVal campo As String, txt As TextBox) As String
        If String.IsNullOrEmpty(txt.Text.ToString().Trim) = True Then
            campo = Nothing
        Else
            campo = txt.Text
        End If
        Return campo
    End Function


End Class