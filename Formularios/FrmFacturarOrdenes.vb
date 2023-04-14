Public Class FrmFacturarOrdenes
    Private Sub FrmFacturarOrdenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Size = Screen.PrimaryScreen.WorkingArea.Size
        ' Location = Screen.PrimaryScreen.WorkingArea.Location
        Dim datosEjemplos As New AutoCompleteStringCollection()
        datosEjemplos.AddRange(
            {"Ana García",
            "Ana Rodríguez",
            "Ana Fernández",
            "Juan Pérez",
            "Juan Gómez",
            "Juan Hernández",
            "María López",
            "María Martínez",
            "María Sánchez",
            "Pedro Ramírez",
            "Pedro Ruiz",
            "Pedro Castro",
            "Luisa Díaz",
            "Luisa Ortiz1",
            "Luisa Moreno90"
            }
            )
        TxtBuscar.AutoCompleteCustomSource = datosEjemplos
        Dim examenesEjemplo As New AutoCompleteStringCollection()
        examenesEjemplo.AddRange(
            {"Análisis de sangre completo",
             "Análisis de orina",
             "Prueba de Papanicolaou",
             "Prueba de VIH"
            })
        TxtExamen.AutoCompleteCustomSource = examenesEjemplo
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtExamen.Text = "" Then
            MsgBox("Agrega un examen")
            Return
        End If
        DataGridView1.Rows.Add("1", TxtExamen.Text, 127)
        TxtExamen.Clear()


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.Button = MouseButtons.Right Then
            MsgBox("Di click derecho")
        End If
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            TxtExamen.Text = DataGridView1.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'For Each fila As DataGridViewRow In DataGridView1.Rows
        '    If fila.Cells("Nombre").Value.ToString() = TxtExamen.Text Then
        '        DataGridView1.Rows.Remove(fila)
        '    End If
        'Next
        'DataGridView1.Refresh()
        For i As Integer = DataGridView1.Rows.Count - 1 To 0 Step -1
            Dim fila As DataGridViewRow = DataGridView1.Rows(i)
            If fila.Cells("Nombre").Value.ToString() = TxtExamen.Text Then
                DataGridView1.Rows.Remove(fila)
            End If
        Next

        DataGridView1.Refresh() ' Actualizar el control DataGridView
        TxtExamen.Clear()
    End Sub

    Private Sub BtnAgregarPaciente_Click(sender As Object, e As EventArgs) Handles BtnAgregarPaciente.Click

    End Sub
End Class