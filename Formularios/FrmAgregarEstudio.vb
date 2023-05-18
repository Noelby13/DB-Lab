Public Class FrmAgregarEstudio
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNombre.Clear()

        TxtValorTextoM.Clear()
        TxtValorInferiorM.Clear()
        TxtValorSuperiorH.Clear()

        TxtValorTextoH.Clear()
        TxtValorInferiorH.Clear()
        TxtValorSuperiorH.Clear()

    End Sub

    Private Sub llenarCombo()
        Dim dUnidad As New DUnidad
        Dim ds = dUnidad.listarUnidades()

        CbxUnidad1.Items.Clear()
        CbxUnidad2.Items.Clear()
        For Each u As DataRow In ds.Tables(0).Rows

            CbxUnidad1.Items.Add(u("nombre"))
            CbxUnidad2.Items.Add(u("nombre"))

        Next
        CbxUnidad1.Items.Add("Crear Nueva Unidad")
        CbxUnidad2.Items.Add("Crear Nueva Unidad")


        'CbxUnidad1.Items.Clear()
        'CbxUnidad2.Items.Clear()

        'CbxUnidad1.DropDownStyle = ComboBoxStyle.DropDownList
        'CbxUnidad2.DropDownStyle = ComboBoxStyle.DropDownList


        'CbxUnidad1.DataSource = ds.Tables(0)
        'CbxUnidad1.ValueMember = "idUnidad"
        'CbxUnidad1.DisplayMember = "nombre"
        'CbxUnidad2.DataSource = ds.Tables(0)
        'CbxUnidad2.ValueMember = "idUnidad"
        'CbxUnidad2.DisplayMember = "nombre"


    End Sub


    Private Sub FrmAgregarEstudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombo()
    End Sub

    Private Sub BtnGuardarIcon_Click(sender As Object, e As EventArgs) Handles BtnGuardarIcon.Click
        Dim id As Integer = CbxUnidad1.SelectedValue
        MsgBox(id)

    End Sub

    Private Sub BtnCancelarUnidad_Click(sender As Object, e As EventArgs) Handles BtnCancelarUnidad.Click
        GbCrearNuevaUnidad.Visible = False

    End Sub

    Private Sub CbxUnidad1_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxUnidad1.SelectedValueChanged
        If CbxUnidad1.SelectedItem = "Crear Nueva Unidad" Then
            GbCrearNuevaUnidad.Visible = True
        End If
    End Sub
End Class