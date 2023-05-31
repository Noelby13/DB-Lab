Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices


Public Class FrmCategorias


    'Llena el DataGridView del formulario con los registros de Tbl_Usuario'
    Sub llenarRegistros()
        Dim dCategorias As New DCategoria
        DgvCategorias.DataSource = dCategorias.mostrarRegistros().Tables(0)
        DgvCategorias.Refresh()

    End Sub
    'Instrucciones que ocurren cuando el formulario es cargado'
    Private Sub FrmCategorias_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenarRegistros()

    End Sub

    'Comprueba la validez de los campos al momento de realizar una accion en el formulario'
    Private Function validarCampo() As Boolean
        Dim resultado = False

        If TxtNombre.Text <> "" Then
            resultado = True
        End If
        Return resultado
    End Function
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNombre.Clear()
        TxtDescripcion.Clear()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If Not validarCampo() Then
                MsgBox("La información está incompleta", MsgBoxStyle.Exclamation, "ADVERTENCIA")
                Exit Sub
            End If

            Dim categoria As New Categoria()
            Dim dCategoria As New DCategoria

            categoria.Nombre = TxtNombre.Text
            categoria.Descripcion = TxtDescripcion.Text

            If dCategoria.comprobarCategoria(categoria) Then
                MsgBox("Ya existe una categoria con ese nombre", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            End If

            If dCategoria.guardarRegistro(categoria) Then
                MsgBox("Categoria registrada correctamente", MsgBoxStyle.Information, "Gestión de Categorias")
                llenarRegistros()
                BtnLimpiar.PerformClick()
            End If

        Catch ex As Exception
            MsgBox("No se pudo registrar la categoria", MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub


    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            Dim fila As Integer = DgvCategorias.CurrentRow.Index
            Dim categoriaActual As String = DgvCategorias.Rows(fila).Cells(1).Value

            If Not validarCampo() Then
                MsgBox("La información está incompleta", MsgBoxStyle.Exclamation, "ADVERTENCIA")
                Exit Sub
            End If

            Dim resp As VariantType
            resp = (MsgBox("Desea editar los datos y permisos de esta categoria? Categoria: " & categoriaActual, MsgBoxStyle.Question +
                       MsgBoxStyle.YesNo, "CONFIRMACIÓN"))
            If (resp = vbNo) Then
                MsgBox("Operación cancelada",
                       MsgBoxStyle.Information, "Gestión de Categorias")
                Exit Sub
            End If

            Dim categoria As New Categoria()
            Dim dCategoria As New DCategoria

            categoria.IdCategoria = DgvCategorias.Rows(fila).Cells(0).Value
            categoria.Nombre = TxtNombre.Text
            categoria.Descripcion = TxtDescripcion.Text


            If dCategoria.editarRegistro(categoria) Then
                MsgBox("Categoria editada correctamente", MsgBoxStyle.Information, "Gestión de Categorias")
                llenarRegistros()
                BtnLimpiar.PerformClick()
            End If

        Catch ex As Exception
            MsgBox("No se pudo editar la categoria", MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Try
            Dim categoria As New Categoria
            Dim dCategoria As New DCategoria

            If Not validarCampo() Then
                MsgBox("La información está incompleta", MsgBoxStyle.Exclamation, "ADVERTENCIA")
                Exit Sub
            End If

            categoria.Nombre = TxtNombre.Text

            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar esta categoria? Rol: " & categoria.Nombre, MsgBoxStyle.Question +
                           MsgBoxStyle.YesNo, "CONFIRMACION"))
            If (resp = vbNo) Then
                MsgBox("Operación cancelada",
                           MsgBoxStyle.Information, "Gestión de Categorias")
                Exit Sub
            End If

            Dim eliminado = dCategoria.eliminarRegistro(categoria.Nombre)
            If (eliminado) Then
                MsgBox("Rol eliminado correctamente", MsgBoxStyle.Information, "Gestión de Categorias")
                BtnLimpiar.PerformClick()
            End If

        Catch ex As Exception
            MsgBox("No se pudo eliminar la categoria",
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        llenarRegistros()
    End Sub

    Private Sub BtnBuscarEstudio_Click(sender As Object, e As EventArgs)
        Dim dCategoria As New DCategoria
        DgvCategorias.DataSource = dCategoria.buscarXNombre(TxtCategoria.Text.ToString()).Tables(0)
        DgvCategorias.Refresh()
    End Sub


    'En caso de recibir la advertencia de que un nombre de usuario ya existe'
    'Si se empieza a cambiar el nombre ingresado, la advertencia desaparecera'
    Private Sub TxtNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        LblAdvertenciaCat.Text = ""
    End Sub


    'Obtiene los datos de un registro del DataGridView e inserta los valores de los atributos en sus respectivos campos'
    'Tambien se inhabilita el boton de guardar registro, para evitar que se guarde un duplicado de cambios minimos'
    Private Sub DgvCategorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCategorias.CellClick
        Dim fila As Integer = DgvCategorias.CurrentRow.Index
        TxtNombre.Text = DgvCategorias.Rows(fila).Cells(1).Value
        TxtDescripcion.Text = DgvCategorias.Rows(fila).Cells(2).Value
        BtnGuardar.Enabled = False
    End Sub
End Class