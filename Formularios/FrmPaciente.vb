Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class FrmPaciente

    'Llena el DataGridView del formulario con los registros de Tbl_Usuario'
    Public Sub llenarRegistros()
        Dim dPaciente As New DPaciente
        DgvPacientes.DataSource = dPaciente.mostrarRegistros().Tables(0)
        DgvPacientes.Refresh()
        DgvPacientes.Columns(6).Visible = False
    End Sub
    'Instrucciones que ocurren cuando el formulario es cargado'
    Private Sub FrmPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarRegistros()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
    Private Function validarSexo() As Boolean
        Dim resultado = False
        If (RbMasculino.Checked = True Or RbFemenino.Checked = True) Then
            resultado = True
        End If
        Return resultado
    End Function
    Private Function validarCampos() As Boolean
        Dim resultado = False

        If (TxtPrimNombre.Text <> "" And TxtPrimApe.Text <> "" And TxtCedula.Text <> "") Then
            resultado = True
        End If
        Return resultado
    End Function

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtPrimNombre.Clear()
        TxtSegNom.Clear()
        TxtPrimApe.Clear()
        TxtSegApe.Clear()
        TxtCedula.Clear()
        TxtDireccion.Clear()
        TxtTelefono.Clear()
        TxtCorreo.Clear()
        BtnGuardar.Enabled = True
    End Sub
    Private Function comprobarValorNull(ByVal campo As String, txt As TextBox) As String
        'Si el campo del atributo esta vacio, el objeto creado recibe un valor Nothing(Null) en ese atributo'
        'De lo contrario, el objeto asigna al atributo correspondiente el valor del campo'
        If String.IsNullOrEmpty(txt.Text.ToString().Trim) = True Then
            campo = Nothing
        Else
            campo = txt.Text
        End If
        Return campo
    End Function

    'Boton Editar: Modifica un registro existente dentro de la tabla'
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            Dim fila As Integer = DgvPacientes.CurrentRow.Index
            If Not validarCampos() Then
                MsgBox("La información está incompleta", MsgBoxStyle.Exclamation, "ADVERTENCIA")
                Exit Sub
            End If

            Dim paciente As New Paciente()
            Dim dPaciente As New DPaciente()

            paciente.IdPaciente = DgvPacientes.Rows(fila).Cells(0).Value
            paciente.PrimerNombre = TxtPrimNombre.Text
            paciente.SegundoNombre = comprobarValorNull(paciente.SegundoNombre, TxtSegNom)
            paciente.PrimerApellido = TxtPrimApe.Text
            paciente.SegundoApellido = comprobarValorNull(paciente.SegundoApellido, TxtSegApe)
            paciente.Telefono = TxtTelefono.Text
            paciente.Correo = comprobarValorNull(paciente.Correo, TxtCorreo)
            paciente.Direccion = comprobarValorNull(paciente.Direccion, TxtDireccion)
            paciente.Cedula = comprobarValorNull(paciente.Cedula, TxtCedula)
            paciente.FechaNac = DtpFechaNac.Text

            If RbMasculino.Checked = True Then
                paciente.Sexo = True
            End If

            If RbFemenino.Checked = True Then
                paciente.Sexo = False
            End If

            'Pregunta al usuario si esta seguro de realizar la accion'
            Dim resp As VariantType
            resp = (MsgBox("Desea editar los datos de este paciente? Cedula del paciente: " & paciente.Cedula, MsgBoxStyle.Question +
                       MsgBoxStyle.YesNo, "CONFIRMACIÓN"))
            If (resp = vbNo) Then
                MsgBox("Operación cancelada",
                       MsgBoxStyle.Information, "Gestión de Pacientes")
                Exit Sub
            End If

            If dPaciente.editarRegistro(paciente) Then
                MsgBox("Paciente editado correctamente", MsgBoxStyle.Information, "Gestión de Pacientes")

            End If

        Catch ex As Exception
            MsgBox(("Paciente editado correctamente", MsgBoxStyle.Information, "Gestión de Pacientes"))
        End Try
        llenarRegistros()
        BtnLimpiar.PerformClick()


    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Try
            Dim paciente As New Paciente
            Dim dPaciente As New DPaciente
            Dim fila As Integer = DgvPacientes.CurrentRow.Index

            If Not validarCampos() Then
                MsgBox("La información está incompleta", MsgBoxStyle.Exclamation, "ADVERTENCIA")
                Exit Sub
            End If

            paciente.IdPaciente = DgvPacientes.Rows(fila).Cells(0).Value
            paciente.PrimerNombre = TxtPrimNombre.Text
            paciente.PrimerApellido = TxtPrimApe.Text
            paciente.Cedula = TxtCedula.Text

            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar este paciente? Paciente: " & paciente.PrimerNombre & " " & paciente.PrimerApellido, MsgBoxStyle.Question +
                           MsgBoxStyle.YesNo, "CONFIRMACION"))
            If (resp = vbNo) Then
                MsgBox("Operación cancelada",
                           MsgBoxStyle.Information, "Gestión de Pacientes")
                Exit Sub
            End If

            Dim eliminado = dPaciente.eliminarRegistro(paciente.Cedula)
            If (eliminado) Then
                MsgBox("Paciente eliminado correctamente", MsgBoxStyle.Information, "Gestión de Pacientes")
                BtnLimpiar.PerformClick()
            End If

        Catch ex As Exception
            MsgBox("No se pudo eliminar el paciente" & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
        llenarRegistros()
    End Sub
    Private Sub BtnBuscarPaciente_Click(sender As Object, e As EventArgs) Handles BtnBuscarPaciente.Click
        Dim dPaciente As New DPaciente
        DgvPacientes.DataSource = dPaciente.buscarXNombre(TxtPaciente.Text.ToString()).Tables(0)
        DgvPacientes.Refresh()
    End Sub

    Private Sub DgvPacientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPacientes.CellClick
        Dim fila As Integer = DgvPacientes.CurrentRow.Index
        Dim sexoBiologico As Boolean = DgvPacientes.Rows(fila).Cells(6).Value

        If sexoBiologico = True Then
            RbMasculino.Checked = True
        End If

        If sexoBiologico = False Then
            RbFemenino.Checked = True
        End If

        TxtPrimNombre.Text = DgvPacientes.Rows(fila).Cells(1).Value
        TxtSegNom.Text = DgvPacientes.Rows(fila).Cells(2).Value.ToString()
        TxtPrimApe.Text = DgvPacientes.Rows(fila).Cells(3).Value
        TxtSegApe.Text = DgvPacientes.Rows(fila).Cells(4).Value.ToString()
        TxtCedula.Text = DgvPacientes.Rows(fila).Cells(11).Value
        TxtCorreo.Text = DgvPacientes.Rows(fila).Cells(9).Value.ToString()
        TxtTelefono.Text = DgvPacientes.Rows(fila).Cells(8).Value
        TxtDireccion.Text = DgvPacientes.Rows(fila).Cells(10).Value
        DtpFechaNac.Value = DgvPacientes.Rows(fila).Cells(7).Value
        BtnGuardar.Enabled = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            Dim paciente As New Paciente()
            Dim dPaciente As New DPaciente

            paciente.PrimerNombre = TxtPrimNombre.Text
            paciente.SegundoNombre = comprobarValorNull(paciente.SegundoNombre, TxtSegNom)
            paciente.PrimerApellido = TxtPrimApe.Text
            paciente.SegundoApellido = comprobarValorNull(paciente.SegundoApellido, TxtSegApe)
            paciente.Telefono = comprobarValorNull(paciente.Telefono, TxtTelefono)
            paciente.Correo = comprobarValorNull(paciente.Correo, TxtCorreo)
            paciente.Direccion = comprobarValorNull(paciente.Direccion, TxtDireccion)
            paciente.Cedula = TxtCedula.Text
            paciente.FechaNac = DtpFechaNac.Text

            If RbMasculino.Checked = True Then
                paciente.Sexo = True
            End If

            If RbFemenino.Checked = True Then
                paciente.Sexo = False
            End If

            If dPaciente.comprobarPaciente(paciente) Then
                MsgBox("Ya existe un paciente con ese nombre", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            End If

            If dPaciente.guardarRegistro(paciente) Then
                MsgBox("Paciente registrado correctamente", MsgBoxStyle.Information, "Gestión de Pacientes")
                llenarRegistros()
                BtnLimpiar.PerformClick()
            End If

        Catch ex As Exception
            MsgBox("No se pudo registrar el paciente" & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub


End Class


