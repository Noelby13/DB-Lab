Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class FrmUsuario

    'Llena el DataGridView del formulario con los registros de Tbl_Usuario'
    Sub llenarRegistros()
        Dim dUsuario As New DUsuario
        DgvRegistrosUsuario.DataSource = dUsuario.mostrarRegistros().Tables(0)
        DgvRegistrosUsuario.Refresh()
    End Sub


    'Instrucciones que ocurren cuando el formulario es cargado'
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rellenarComboBox()
        llenarRegistros()
        LblAdvertencia.Text = ""
    End Sub


    'Comprueba la validez de los campos al momento de realizar una accion en el formulario'
    Private Function validarCampos() As Boolean
        Dim B = False

        If (TxtPrimerNombre.Text <> "" And TxtPrimerApellido.Text <> "" And TxtNombreUsuario.Text <> "" And CbxRol.SelectedIndex <> -1 And TxtTelefono.Text <> "" And TxtCedula.Text <> "" And TxtPw.Text <> "" And TxtConfirmarPw.Text <> "") Then
            If Not (TxtPw.Text.Equals(TxtConfirmarPw.Text) = True) Then
                MsgBox("Las claves no coinciden", MsgBoxStyle.Exclamation, "ADVERTENCIA")
                Return False
            End If
            B = True
        End If

        Return B
    End Function


    'Boton Salir: Cierra el formulario cargado'
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


    'Boton Limpiar: Borra todo lo escrito/seleccionado en los campos del formulario, dejandolos vacios
    'Tambien habilita el boton Guardar en caso de que estuviese inabilitado anteriormente'
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtPrimerNombre.Clear()
        TxtSegundoNombre.Clear()
        TxtPrimerApellido.Clear()
        TxtSegundoApellido.Clear()
        TxtNombreUsuario.Clear()
        LblAdvertencia.Text = ""
        TxtTelefono.Clear()
        TxtCorreo.Clear()
        DtpFechaIngreso.ResetText()
        TxtCedula.Clear()
        TxtPw.Clear()
        TxtConfirmarPw.Clear()
        BtnGuardar.Enabled = True
    End Sub


    'Boton Guardar: Guarda un nuevo registro de usuario en la tabla Tbl_Usuario'
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If Not validarCampos() Then
                MsgBox("La información está incompleta", MsgBoxStyle.Exclamation, "ADVERTENCIA")
                Exit Sub
            End If

            Dim usuario As New Usuario()
            Dim dUsuario As New DUsuario()

            usuario.PrimerNombre = TxtPrimerNombre.Text
            usuario.SegundoNombre = comprobarNull(usuario.SegundoNombre, TxtSegundoNombre)
            usuario.PrimerApellido = TxtPrimerApellido.Text
            usuario.SegundoApellido = comprobarNull(usuario.SegundoApellido, TxtSegundoApellido)
            usuario.Username = TxtNombreUsuario.Text
            'SelectedValue permite obtener el id correcto del item(el rol) seleccionado en el combobox'
            usuario.IdRol = CbxRol.SelectedValue
            usuario.Telefono = TxtTelefono.Text
            usuario.Correo = comprobarNull(usuario.Correo, TxtCorreo)
            usuario.FechaIngreso = DtpFechaIngreso.Text
            usuario.Cedula = TxtCedula.Text
            usuario.Pwd = TxtPw.Text
            usuario.Estado = True

            If dUsuario.comprobarUsuario(usuario) Then
                LblAdvertencia.Text = "Este usuario ya existe"
                Exit Sub
            End If

            If dUsuario.guardarRegistro(usuario) Then
                MsgBox("Registro guardado correctamente", MsgBoxStyle.Information, "Gestión de Usuarios")
                llenarRegistros()
            End If
        Catch ex As Exception
            MsgBox("No se pudo guardar el registro", MsgBoxStyle.Critical, "ERROR")
        End Try
        BtnLimpiar.PerformClick()
    End Sub


    'Boton Editar: Modifica un registro existente dentro de la tabla'
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            Dim fila As Integer = DgvRegistrosUsuario.CurrentRow.Index
            If Not validarCampos() Then
                MsgBox("La información está incompleta", MsgBoxStyle.Exclamation, "ADVERTENCIA")
                Exit Sub
            End If

            Dim usuario As New Usuario()
            Dim dUsuario As New DUsuario()

            usuario.IdUsuario = DgvRegistrosUsuario.Rows(fila).Cells(0).Value
            usuario.PrimerNombre = TxtPrimerNombre.Text
            usuario.SegundoNombre = comprobarNull(usuario.SegundoNombre, TxtSegundoNombre)
            usuario.PrimerApellido = TxtPrimerApellido.Text
            usuario.SegundoApellido = comprobarNull(usuario.SegundoApellido, TxtSegundoApellido)
            usuario.Username = TxtNombreUsuario.Text
            usuario.IdRol = CbxRol.SelectedValue
            usuario.Telefono = TxtTelefono.Text
            usuario.Correo = comprobarNull(usuario.Correo, TxtCorreo)
            usuario.FechaIngreso = DtpFechaIngreso.Text
            usuario.Cedula = TxtCedula.Text
            usuario.Pwd = TxtPw.Text

            'Pregunta al usuario si esta seguro de realizar la accion'
            Dim resp As VariantType
            resp = (MsgBox("Desea editar los datos de este usuario? Usuario: " & usuario.Username, MsgBoxStyle.Question +
                       MsgBoxStyle.YesNo, "CONFIRMACIÓN"))
            If (resp = vbNo) Then
                MsgBox("Operación cancelada",
                       MsgBoxStyle.Information, "Gestión de Usuarios")
                Exit Sub
            End If

            If dUsuario.editarRegistro(usuario) Then
                MsgBox("Usuario editado correctamente", MsgBoxStyle.Information, "Gestión de Usuarios")

            End If

        Catch ex As Exception
            MsgBox("No se pudo editar al usuario", MsgBoxStyle.Critical, "ERROR")
        End Try
        llenarRegistros()
        BtnLimpiar.PerformClick()
    End Sub


    'Boton Borrar: Se borra un registro (En este caso de manera logica) dentro de la tabla'
    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Dim usuario As New Usuario
        Dim dUsuario As New DUsuario

        If Not validarCampos() Then
            MsgBox("La información está incompleta", MsgBoxStyle.Exclamation, "ADVERTENCIA")
            Exit Sub
        End If

        usuario.Username = TxtNombreUsuario.Text

        Dim resp As VariantType
        resp = (MsgBox("Desea eliminar este usuario? Usuario: " & usuario.Username, MsgBoxStyle.Question +
                       MsgBoxStyle.YesNo, "CONFIRMACION"))
        If (resp = vbNo) Then
            MsgBox("Operación cancelada",
                       MsgBoxStyle.Information, "Gestión de Usuarios")
            Exit Sub
        End If

        Dim eliminado = dUsuario.eliminarRegistro(usuario.Username)
        If (eliminado) Then
            MsgBox("Usuario eliminado exitosamente",
                       MsgBoxStyle.Information, "Gestión de Usuarios")
        Else
            MsgBox("No se pudo eliminar al usuario",
                   MsgBoxStyle.Critical, "ERROR")
        End If
        llenarRegistros()
        BtnLimpiar.PerformClick()
    End Sub



    'Boton Buscar: Muestra los registros que coincidan parcialmente o totalmente al usuario ingresado
    'en la barra de buscar
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim dUsuario As New DUsuario
        DgvRegistrosUsuario.DataSource = dUsuario.buscarXNombre(TxtBuscar.Text.ToString()).Tables(0)
        DgvRegistrosUsuario.Refresh()
    End Sub

    'Funcion para rellenar el ComboBox de Roles a elegir'
    Sub rellenarComboBox()
        Dim dRol As New DRol

        CbxRol.DataSource = dRol.listarRoles.Tables(0)
        CbxRol.DisplayMember = "nombre"
        CbxRol.ValueMember = "idRol"
    End Sub


    'En caso de recibir la advertencia de que un nombre de usuario ya existe'
    'Si se empieza a cambiar el nombre ingresado, la advertencia desaparecera'
    Private Sub TxtNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtNombreUsuario.TextChanged
        LblAdvertencia.Text = ""
    End Sub


    'Obtiene los datos de un registro del DataGridView e inserta los valores de los atributos en sus respectivos campos'
    'Tambien se inhabilita el boton de guardar registro, para evitar que se guarde un duplicado de cambios minimos'
    Private Sub DgvRegistrosUsuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRegistrosUsuario.CellClick
        Dim fila As Integer = DgvRegistrosUsuario.CurrentRow.Index
        TxtPrimerNombre.Text = DgvRegistrosUsuario.Rows(fila).Cells(1).Value
        TxtSegundoNombre.Text = DgvRegistrosUsuario.Rows(fila).Cells(2).Value.ToString()
        TxtPrimerApellido.Text = DgvRegistrosUsuario.Rows(fila).Cells(3).Value
        TxtSegundoApellido.Text = DgvRegistrosUsuario.Rows(fila).Cells(4).Value.ToString()
        TxtNombreUsuario.Text = DgvRegistrosUsuario.Rows(fila).Cells(5).Value
        CbxRol.Text = DgvRegistrosUsuario.Rows(fila).Cells(11).Value
        TxtTelefono.Text = DgvRegistrosUsuario.Rows(fila).Cells(6).Value
        TxtCorreo.Text = DgvRegistrosUsuario.Rows(fila).Cells(7).Value.ToString()
        DtpFechaIngreso.Value = DgvRegistrosUsuario.Rows(fila).Cells(8).Value
        TxtCedula.Text = DgvRegistrosUsuario.Rows(fila).Cells(9).Value
        TxtPw.Text = DgvRegistrosUsuario.Rows(fila).Cells(10).Value
        TxtConfirmarPw.Text = DgvRegistrosUsuario.Rows(fila).Cells(10).Value
        BtnGuardar.Enabled = False
    End Sub


    'Funcion para comprobar si un campo que puede estar vacio, lo esta o no'
    Private Function comprobarNull(ByVal campo As String, txt As TextBox) As String
        'Si el campo del atributo esta vacio, el objeto creado recibe un valor Nothing(Null) en ese atributo'
        'De lo contrario, el objeto asigna al atributo correspondiente el valor del campo'
        If String.IsNullOrEmpty(txt.Text.ToString().Trim) = True Then
            campo = Nothing
        Else
            campo = txt.Text
        End If
        Return campo
    End Function

End Class