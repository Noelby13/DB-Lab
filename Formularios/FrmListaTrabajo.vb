Public Class FrmListaTrabajo


    Private Function crearPestaña(nombre As String, orden As String) As TabPage
        Dim tabPage As New TabPage With {
            .Name = $"{orden}",
            .Text = $"Resultados {nombre}",
            .Size = New Size(627, 659)
        }

        Dim btnGuardarResultados As New Button With {
            .Anchor = AnchorStyles.None,
            .BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer)),
            .Font = New Font("Microsoft Sans Serif", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte)),
            .Location = New Point(239, 11),
            .Name = "btnGuardarResultados",
            .Size = New Size(155, 30),
            .TabIndex = 4,
            .Text = "Guardar Resultados",
            .UseVisualStyleBackColor = False
        }

        Dim BtnCerrarPestaña As New Button With {
            .Anchor = AnchorStyles.Right,
            .BackColor = System.Drawing.Color.IndianRed,
            .Font = New Font("Microsoft Sans Serif", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte)),
            .Location = New Point(473, 13),
            .Name = "BtnCerrarPestaña",
            .Size = New Size(146, 26),
            .TabIndex = 3,
            .Text = "Cerrar Pestaña",
            .UseVisualStyleBackColor = False
        }
        AddHandler BtnCerrarPestaña.Click, AddressOf BtnCerrarPestaña_Click


        Dim btnImprimir As New Button With {
            .BackColor = System.Drawing.Color.Green,
            .Font = New Font("Microsoft Sans Serif", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte)),
            .ForeColor = System.Drawing.Color.Black,
            .Location = New Point(11, 11),
            .Name = "BtnImprimir",
            .Size = New Size(130, 30),
            .TabIndex = 5,
            .Text = "ImprimirReporte",
            .UseVisualStyleBackColor = False
        }

        Dim txtOrden As New System.Windows.Forms.TextBox With {
            .Location = New System.Drawing.Point(86, 104),
            .Name = "TextBox5",
            .Size = New System.Drawing.Size(109, 24),
            .TabIndex = 7,
            .Text = $"{orden}",
            .ReadOnly = True
        }
        Dim LblOrden As New System.Windows.Forms.Label With {
            .AutoSize = True,
            .Location = New System.Drawing.Point(7, 104),
            .Name = "Label6",
            .Size = New System.Drawing.Size(57, 18),
            .TabIndex = 6,
            .Text = "Orden: "
        }

        Dim TxtEdad As New System.Windows.Forms.TextBox With {
            .Location = New System.Drawing.Point(201, 66),
            .Name = "TextBox4",
            .Size = New System.Drawing.Size(100, 24),
            .TabIndex = 5
        }

        Dim LblEdad As New System.Windows.Forms.Label With {
            .AutoSize = True,
            .Location = New System.Drawing.Point(149, 69),
            .Name = "Label5",
            .Size = New System.Drawing.Size(46, 18),
            .TabIndex = 4,
            .Text = "Edad:"
        }

        Dim TxtSexo As New System.Windows.Forms.TextBox With {
            .Location = New System.Drawing.Point(86, 66),
            .Name = "TextBox3",
            .Size = New System.Drawing.Size(43, 24),
            .TabIndex = 3
        }

        Dim LblSexo As New System.Windows.Forms.Label With {
            .AutoSize = True,
            .Location = New System.Drawing.Point(22, 69),
            .Name = "Label4",
            .Size = New System.Drawing.Size(46, 18),
            .TabIndex = 2,
            .Text = "Sexo:"
        }

        Dim TxtNombre As New System.Windows.Forms.TextBox With {
            .Location = New System.Drawing.Point(86, 30),
            .Name = "TextBox2",
            .Size = New System.Drawing.Size(354, 24),
            .TabIndex = 1,
            .Text = nombre,
            .ReadOnly = True
        }

        Dim LblNombre As New System.Windows.Forms.Label With {
            .AutoSize = True,
            .Location = New System.Drawing.Point(7, 33),
            .Name = "Label3",
            .Size = New System.Drawing.Size(66, 18),
            .TabIndex = 0,
            .Text = "Nombre:"
        }

        Dim GrbDatos As New GroupBox With {
            .Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
            .Location = New System.Drawing.Point(1, 19),
            .Name = "GroupBox Datos",
            .Size = New System.Drawing.Size(623, 140),
            .TabIndex = 2,
            .TabStop = False,
            .Text = "Datos de la orden"
        }

        GrbDatos.Controls.Add(txtOrden)
        GrbDatos.Controls.Add(LblOrden)
        GrbDatos.Controls.Add(TxtEdad)
        GrbDatos.Controls.Add(LblEdad)
        GrbDatos.Controls.Add(TxtSexo)
        GrbDatos.Controls.Add(LblSexo)
        GrbDatos.Controls.Add(TxtNombre)
        GrbDatos.Controls.Add(LblNombre)

        Dim DgvResultados As New DataGridView With {
            .ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize,
            .Dock = System.Windows.Forms.DockStyle.Top,
            .Location = New System.Drawing.Point(0, 223),
            .Size = New System.Drawing.Size(627, 176)
        }

        ' Crear un nuevo Panel dentro del TabPage
        Dim PanelFunciones As New Panel With {
            .Size = New Size(627, 51),
            .Dock = DockStyle.Top,
            .BackColor = System.Drawing.Color.Transparent
        }
        Dim PanelDatos As New Panel With {
            .Dock = DockStyle.Top,
            .Location = New System.Drawing.Point(0, 51),
            .Size = New System.Drawing.Size(627, 172)
        }

        ' Añadir los botones a los Panel
        PanelFunciones.Controls.Add(btnGuardarResultados)
        PanelFunciones.Controls.Add(BtnCerrarPestaña)
        PanelFunciones.Controls.Add(btnImprimir)
        PanelDatos.Controls.Add(GrbDatos)

        ' Añadir principales controles al tabPage
        tabPage.Controls.Add(DgvResultados)
        tabPage.Controls.Add(PanelFunciones)
        tabPage.Controls.Add(PanelDatos)


        Return tabPage

    End Function
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmListaTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'datos falsos XD
        Dim fila As Object() = {"18878", "10:00", "Juan", "Sin Iniciar"}

        'Agregar la fila al DataGridView
        DataGridView1.Rows.Add(fila)

        'Crear otra fila con datos falsos
        fila = {"24545", "11:00", "Maria", "Procesando"}

        'Agregar la segunda fila al DataGridView
        DataGridView1.Rows.Add(fila)

    End Sub

    Private Sub BtnCerrarPestaña_Click(sender As Object, e As EventArgs)
        TabControl1.TabPages.Remove(TabControl1.SelectedTab
                                    )
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim orden As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        Dim nombre As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()

        Dim tabPage As TabPage = Nothing
        For Each tab As TabPage In TabControl1.TabPages
            If tab.Name = orden Then
                tabPage = tab
            End If

        Next

        If tabPage Is Nothing Then
            tabPage = crearPestaña(nombre, orden)
            TabControl1.Controls.Add(tabPage)
        End If

        TabControl1.SelectedTab = tabPage
    End Sub
End Class