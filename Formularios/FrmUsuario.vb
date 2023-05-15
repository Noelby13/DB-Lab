Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class FrmUsuario

    'Rutina para llenar el DataGridView del formulario con los registros de Tbl_Usuario'
    Sub llenarRegistros()
        Dim dUsuario As New DUsuario
        DgvRegistrosUsuario.DataSource = dUsuario.mostrarRegistros().Tables(0)
        DgvRegistrosUsuario.Refresh()
    End Sub


    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Prueba para rellenar combobox'
        rellenarComboBox()
        llenarRegistros()
        CbxRol.Text = "Seleccione el rol..."
        LblAdvertencia.Text = ""
    End Sub


    ''
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    'Boton Limpiar: Borra todo lo escrito/seleccionado en los campos del formulario, dejandolos vacios'
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtPrimerNombre.Clear()
        TxtSegundoNombre.Clear()
        TxtPrimerApellido.Clear()
        TxtSegundoApellido.Clear()
        TxtNombreUsuario.Clear()
        LblAdvertencia.Text = ""
        CbxRol.Text = "Seleccione el rol..."
        TxtTelefono.Clear()
        TxtCorreo.Clear()
        DtpFechaIngreso.ResetText()
        TxtCedula.Clear()
        TxtPw.Clear()
        TxtConfirmarPw.Clear()
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

        Catch ex As Exception

        End Try
    End Sub



    'Private Sub BtnGuardarIcon_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
    '    If (TxtPrimerNombre.Text = "") Then
    '        MsgBox("Debe ingresar un nombre al campo")
    '    End If

    '    If (TxtApellidos.Text = "") Then
    '        MsgBox("Debe ingresar un apellido al campo")
    '    End If

    '    If (TxtNombreUsuario.Text = "") Then
    '        MsgBox("Debe ingresar un nombre de usuario al campo")
    '    End If

    '    If (CbxRol.SelectedItem = "") Then
    '        MsgBox("Debe seleccionar un rol")
    '    End If

    '    If (TxtTelefono.Text = "") Then
    '        MsgBox("Debe ingresar un numero de teléfono al campo")
    '    End If

    '    If (TxtCorreo.Text = "") Then
    '        MsgBox("Debe ingresar una dirección de correo electrónico")
    '    End If

    '    If (TxtPw.Text = "") Then
    '        MsgBox("Debe ingresar una contraseña")
    '    End If

    '    ValidarContraseña()
    'End Sub


    'Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
    '    e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    '    If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
    '        MsgBox("Por favor digite un numero de telefono")
    '    End If
    'End Sub

    'Private Sub ValidarContraseña()
    '    If String.Equals(TxtPw.Text, TxtConfirmarPw.Text) Then
    '    Else
    '        MsgBox("Las contraseñas no coinciden")
    '    End If
    'End Sub

    'Private Sub BtnBuscarEstudio_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
    '    If (TxtBuscar.Text = "") Then
    '        MsgBox("Ingrese un usuario para buscar")
    '    End If
    'End Sub


    Sub rellenarComboBox()
        'REFINAR CODIGO'
        Dim conn As New SqlConnection("Data Source=localhost;Initial Catalog=DBLab;Persist Security Info=True;User ID=sa;Password=1234")
        Dim tsql As String = "SELECT * FROM Tbl_Rol"
        Dim cmd As New SqlCommand(tsql, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)

        CbxRol.DataSource = ds
        CbxRol.DisplayMember = "nombre"
        CbxRol.ValueMember = "idRol"
    End Sub

    Private Sub TxtNombreUsuario_ParentChanged(sender As Object, e As EventArgs) Handles TxtNombreUsuario.ParentChanged
        LblAdvertencia.Text = ""
    End Sub
End Class