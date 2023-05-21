Public Class FrmRol

    Sub llenarRegistros()
        Dim dRol As New DRol
        DgvRegistrosRol.DataSource = dRol.mostrarRegistros().Tables(0)
        DgvRegistrosRol.Refresh()
    End Sub


    Private Sub FrmRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarRegistros()
        rellenarCheckedListItem()
        LblAdvertencia.Text = ""
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


    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNombre.Clear()
        LblAdvertencia.Text = ""
        ClbPermisosRol.ClearSelected()
        TxtDescripcion.Clear()
        BtnGuardar.Enabled = True
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If Not validarCampo() Then
                MsgBox("La información está incompleta", MsgBoxStyle.Exclamation, "ADVERTENCIA")
                Exit Sub
            End If

            Dim rol As New Rol()
            Dim dRol As New DRol

            rol.Nombre = TxtNombre.Text
            rol.Descripcion = comprobarNull(rol.Descripcion, TxtDescripcion)

            If dRol.comprobarRol(rol) Then
                LblAdvertencia.Text = "Ya existe un rol con ese nombre"
                Exit Sub
            End If

            If dRol.guardarRegistro(rol) Then
                MsgBox("Rol registrado correctamente", MsgBoxStyle.Information, "Gestión de Roles")
                llenarRegistros()
                BtnLimpiar.PerformClick()
            End If

        Catch ex As Exception
            MsgBox("No se pudo registrar el rol", MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub


    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            Dim fila As Integer = DgvRegistrosRol.CurrentRow.Index
            Dim rolActual As String = DgvRegistrosRol.Rows(fila).Cells(1).Value

            If Not validarCampo() Then
                MsgBox("La información está incompleta", MsgBoxStyle.Exclamation, "ADVERTENCIA")
                Exit Sub
            End If

            Dim resp As VariantType
            resp = (MsgBox("Desea editar los datos y permisos de este rol? Rol: " & rolActual, MsgBoxStyle.Question +
                       MsgBoxStyle.YesNo, "CONFIRMACIÓN"))
            If (resp = vbNo) Then
                MsgBox("Operación cancelada",
                       MsgBoxStyle.Information, "Gestión de Roles")
                Exit Sub
            End If

            Dim rol As New Rol()
            Dim dRol As New DRol

            rol.IdRol = DgvRegistrosRol.Rows(fila).Cells(0).Value
            rol.Nombre = TxtNombre.Text
            rol.Descripcion = comprobarNull(rol.Descripcion, TxtDescripcion)


            If dRol.editarRegistro(rol) Then
                MsgBox("Rol editado correctamente", MsgBoxStyle.Information, "Gestión de Roles")
                llenarRegistros()
                BtnLimpiar.PerformClick()
            End If

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
        Dim fila As Integer = DgvRegistrosRol.CurrentRow.Index
        TxtNombre.Text = DgvRegistrosRol.Rows(fila).Cells(1).Value
        TxtDescripcion.Text = DgvRegistrosRol.Rows(fila).Cells(2).Value.ToString()
        BtnGuardar.Enabled = False
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