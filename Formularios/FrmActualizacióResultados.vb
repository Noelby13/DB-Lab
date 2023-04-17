Public Class FrmActualizacióResultados
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmActualizacióResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'datos falsos XD
        Dim fila As Object() = {"18878", "10:00", "Juan", "Sin Iniciar"}

        'Agregar la fila al DataGridView
        DataGridView1.Rows.Add(fila)

        'Crear otra fila con datos falsos
        fila = {"24545", "11:00", "Maria", "Procesando"}

        'Agregar la segunda fila al DataGridView
        DataGridView1.Rows.Add(fila)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim orden As String = Nothing
        Dim nombre As String = Nothing
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            orden = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            nombre = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        End If


        Dim tabPage As TabPage = Nothing
        For Each tab As TabPage In TabControl1.TabPages
            If tab.Name = orden Then
                tabPage = tab
            End If

        Next

        Dim gestor As New GestorPestaña(TabControl1)
        If tabPage Is Nothing Then
            tabPage = gestor.crearPestaña(nombre, orden)
            TabControl1.Controls.Add(tabPage)
        End If

        TabControl1.SelectedTab = tabPage
    End Sub
End Class