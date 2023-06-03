Public Class FrmListaTrabajo

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmListaTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'datos falsos XD
        'Dim fila As Object() = {"18878", "10:00", "Juan", "Sin Iniciar"}

        ''Agregar la fila al DataGridView
        'DataGridView1.Rows.Add(fila)

        ''Crear otra fila con datos falsos
        'fila = {"24545", "11:00", "Maria", "Procesando"}

        ''Agregar la segunda fila al DataGridView
        'DataGridView1.Rows.Add(fila)
        cargarTabla()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLista.CellClick
        'Dim orden As String = Nothing
        'Dim nombre As String = Nothing
        'If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
        '    orden = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        '    nombre = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        'End If



        'Dim tabPage As TabPage = Nothing
        'For Each tab As TabPage In TabControl1.TabPages
        '    If tab.Name = orden Then
        '        tabPage = tab
        '    End If

        'Next

        'Dim gestor As New GestorPestaña(TabControl1)
        'If tabPage Is Nothing Then
        '    tabPage = gestor.crearPestaña(nombre, orden)
        '    TabControl1.Controls.Add(tabPage)
        'End If

        'TabControl1.SelectedTab = tabPage
    End Sub

    Private Sub cargarTabla()
        Try
            Dim dFactura As New DFactura
            Dim ds = dFactura.obtenerListaTrabajo()
            DgvLista.DataSource = ds.Tables(0)
            DgvLista.Columns(0).HeaderText = "Orden"
            DgvLista.Columns(1).HeaderText = "Hora"
            DgvLista.Columns(2).HeaderText = "Nombre"
            DgvLista.Columns(3).HeaderText = "Estado"

            LblHora.Text = DateTime.Now.ToString("hh:mm:ss")

            DgvLista.Refresh()
        Catch ex As Exception
            MsgBox("Ocurrio un error mientras se cargaban los datos")
        End Try

    End Sub
    Private Sub DgvLista_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DgvLista.DataBindingComplete
        For Each fila As DataGridViewRow In DgvLista.Rows
            Dim estado As String = fila.Cells("Estado").Value.ToString()

            ' Comparar el valor de Estado y aplicar el color a la fila correspondiente
            Select Case estado.Trim()
                Case "Sin iniciar"
                    fila.Cells("Estado").Style.BackColor = Color.Red
                    fila.Cells("Estado").Style.ForeColor = Color.White
                Case "En desarrollo"
                    fila.Cells("Estado").Style.BackColor = Color.Yellow
                    fila.Cells("Estado").Style.ForeColor = Color.Black
                Case "Terminado"
                    fila.Cells("Estado").Style.BackColor = Color.Green
                    fila.Cells("Estado").Style.ForeColor = Color.White
            End Select
        Next
        DgvLista.ClearSelection()

    End Sub

    Private Sub BtnRecargar_Click(sender As Object, e As EventArgs) Handles BtnRecargar.Click
        cargarTabla()
    End Sub
End Class