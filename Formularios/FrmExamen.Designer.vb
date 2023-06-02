<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmExamen
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelLeyenda = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelFunciones = New System.Windows.Forms.Panel()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnGuardarIcon = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelDatos = New System.Windows.Forms.Panel()
        Me.GrbDatosEstudios = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvDetalleExamen = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbxCategoria = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtBuscarEstudio = New System.Windows.Forms.TextBox()
        Me.DgvEstudios = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnQuitarD = New System.Windows.Forms.Button()
        Me.BtnAñadirD = New System.Windows.Forms.Button()
        Me.PanelBuscar = New System.Windows.Forms.Panel()
        Me.GbxDatos = New System.Windows.Forms.GroupBox()
        Me.DgvExamenes = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.PanelLeyenda.SuspendLayout()
        Me.PanelFunciones.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelDatos.SuspendLayout()
        Me.GrbDatosEstudios.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvDetalleExamen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelBuscar.SuspendLayout()
        Me.GbxDatos.SuspendLayout()
        CType(Me.DgvExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLeyenda
        '
        Me.PanelLeyenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PanelLeyenda.Controls.Add(Me.BtnSalir)
        Me.PanelLeyenda.Controls.Add(Me.Label1)
        Me.PanelLeyenda.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLeyenda.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeyenda.Name = "PanelLeyenda"
        Me.PanelLeyenda.Size = New System.Drawing.Size(964, 51)
        Me.PanelLeyenda.TabIndex = 3
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(886, 11)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(68, 32)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro Examenes"
        '
        'PanelFunciones
        '
        Me.PanelFunciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PanelFunciones.Controls.Add(Me.BtnBorrar)
        Me.PanelFunciones.Controls.Add(Me.BtnEditar)
        Me.PanelFunciones.Controls.Add(Me.BtnLimpiar)
        Me.PanelFunciones.Controls.Add(Me.BtnGuardarIcon)
        Me.PanelFunciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFunciones.Location = New System.Drawing.Point(0, 51)
        Me.PanelFunciones.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelFunciones.Name = "PanelFunciones"
        Me.PanelFunciones.Size = New System.Drawing.Size(964, 60)
        Me.PanelFunciones.TabIndex = 4
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBorrar.Image = Global.DB_Lab.My.Resources.Resources.deleteButton
        Me.BtnBorrar.Location = New System.Drawing.Point(873, 6)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(81, 46)
        Me.BtnBorrar.TabIndex = 5
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.Image = Global.DB_Lab.My.Resources.Resources.editButton
        Me.BtnEditar.Location = New System.Drawing.Point(763, 6)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(81, 46)
        Me.BtnEditar.TabIndex = 4
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpiar.Image = Global.DB_Lab.My.Resources.Resources.cleanButton
        Me.BtnLimpiar.Location = New System.Drawing.Point(544, 6)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(81, 46)
        Me.BtnLimpiar.TabIndex = 2
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnGuardarIcon
        '
        Me.BtnGuardarIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardarIcon.Image = Global.DB_Lab.My.Resources.Resources.saveButton
        Me.BtnGuardarIcon.Location = New System.Drawing.Point(654, 6)
        Me.BtnGuardarIcon.Name = "BtnGuardarIcon"
        Me.BtnGuardarIcon.Size = New System.Drawing.Size(81, 46)
        Me.BtnGuardarIcon.TabIndex = 3
        Me.BtnGuardarIcon.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.63637!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.25253!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelDatos, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelBuscar, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 111)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(964, 704)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'PanelDatos
        '
        Me.PanelDatos.BackColor = System.Drawing.Color.White
        Me.PanelDatos.Controls.Add(Me.GrbDatosEstudios)
        Me.PanelDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDatos.Location = New System.Drawing.Point(2, 2)
        Me.PanelDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Size = New System.Drawing.Size(609, 380)
        Me.PanelDatos.TabIndex = 5
        '
        'GrbDatosEstudios
        '
        Me.GrbDatosEstudios.Controls.Add(Me.GroupBox2)
        Me.GrbDatosEstudios.Controls.Add(Me.TxtDescripcion)
        Me.GrbDatosEstudios.Controls.Add(Me.Label11)
        Me.GrbDatosEstudios.Controls.Add(Me.TxtPrecio)
        Me.GrbDatosEstudios.Controls.Add(Me.Label7)
        Me.GrbDatosEstudios.Controls.Add(Me.CbxCategoria)
        Me.GrbDatosEstudios.Controls.Add(Me.Label4)
        Me.GrbDatosEstudios.Controls.Add(Me.TxtNombre)
        Me.GrbDatosEstudios.Controls.Add(Me.Label3)
        Me.GrbDatosEstudios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrbDatosEstudios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbDatosEstudios.Location = New System.Drawing.Point(0, 0)
        Me.GrbDatosEstudios.Margin = New System.Windows.Forms.Padding(2)
        Me.GrbDatosEstudios.Name = "GrbDatosEstudios"
        Me.GrbDatosEstudios.Padding = New System.Windows.Forms.Padding(2)
        Me.GrbDatosEstudios.Size = New System.Drawing.Size(609, 380)
        Me.GrbDatosEstudios.TabIndex = 0
        Me.GrbDatosEstudios.TabStop = False
        Me.GrbDatosEstudios.Text = "Datos del examen"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DgvDetalleExamen)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(590, 195)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Estudios dentro del examen"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(418, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 25)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(174, 204)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(181, 25)
        Me.ComboBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Seleccionar prueba:"
        '
        'DgvDetalleExamen
        '
        Me.DgvDetalleExamen.AllowUserToAddRows = False
        Me.DgvDetalleExamen.AllowUserToDeleteRows = False
        Me.DgvDetalleExamen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDetalleExamen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDetalleExamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalleExamen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre})
        Me.DgvDetalleExamen.Location = New System.Drawing.Point(9, 37)
        Me.DgvDetalleExamen.MultiSelect = False
        Me.DgvDetalleExamen.Name = "DgvDetalleExamen"
        Me.DgvDetalleExamen.ReadOnly = True
        Me.DgvDetalleExamen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDetalleExamen.Size = New System.Drawing.Size(575, 152)
        Me.DgvDetalleExamen.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(99, 72)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescripcion.Size = New System.Drawing.Size(215, 64)
        Me.TxtDescripcion.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 18)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Descripción:"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(416, 67)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(77, 24)
        Me.TxtPrecio.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(361, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Precio:"
        '
        'CbxCategoria
        '
        Me.CbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCategoria.FormattingEnabled = True
        Me.CbxCategoria.Location = New System.Drawing.Point(416, 26)
        Me.CbxCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.CbxCategoria.Name = "CbxCategoria"
        Me.CbxCategoria.Size = New System.Drawing.Size(153, 25)
        Me.CbxCategoria.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(341, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Categoría:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(99, 26)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(215, 24)
        Me.TxtNombre.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.TxtBuscarEstudio)
        Me.GroupBox1.Controls.Add(Me.DgvEstudios)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(722, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(240, 380)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Estudios"
        '
        'TxtBuscarEstudio
        '
        Me.TxtBuscarEstudio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscarEstudio.Location = New System.Drawing.Point(5, 22)
        Me.TxtBuscarEstudio.Name = "TxtBuscarEstudio"
        Me.TxtBuscarEstudio.Size = New System.Drawing.Size(231, 24)
        Me.TxtBuscarEstudio.TabIndex = 13
        '
        'DgvEstudios
        '
        Me.DgvEstudios.AllowUserToAddRows = False
        Me.DgvEstudios.AllowUserToDeleteRows = False
        Me.DgvEstudios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvEstudios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEstudios.Location = New System.Drawing.Point(4, 72)
        Me.DgvEstudios.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvEstudios.MultiSelect = False
        Me.DgvEstudios.Name = "DgvEstudios"
        Me.DgvEstudios.ReadOnly = True
        Me.DgvEstudios.RowHeadersWidth = 51
        Me.DgvEstudios.RowTemplate.Height = 24
        Me.DgvEstudios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEstudios.Size = New System.Drawing.Size(231, 304)
        Me.DgvEstudios.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BtnQuitarD)
        Me.Panel1.Controls.Add(Me.BtnAñadirD)
        Me.Panel1.Location = New System.Drawing.Point(616, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(101, 378)
        Me.Panel1.TabIndex = 8
        '
        'BtnQuitarD
        '
        Me.BtnQuitarD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.BtnQuitarD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitarD.Image = Global.DB_Lab.My.Resources.Resources.rightButton26
        Me.BtnQuitarD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnQuitarD.Location = New System.Drawing.Point(0, 275)
        Me.BtnQuitarD.Name = "BtnQuitarD"
        Me.BtnQuitarD.Size = New System.Drawing.Size(98, 45)
        Me.BtnQuitarD.TabIndex = 1
        Me.BtnQuitarD.Text = "Quitar"
        Me.BtnQuitarD.UseVisualStyleBackColor = True
        '
        'BtnAñadirD
        '
        Me.BtnAñadirD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.BtnAñadirD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAñadirD.Image = Global.DB_Lab.My.Resources.Resources.leftButton26
        Me.BtnAñadirD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAñadirD.Location = New System.Drawing.Point(3, 204)
        Me.BtnAñadirD.Name = "BtnAñadirD"
        Me.BtnAñadirD.Size = New System.Drawing.Size(98, 45)
        Me.BtnAñadirD.TabIndex = 0
        Me.BtnAñadirD.Text = "Añadir"
        Me.BtnAñadirD.UseVisualStyleBackColor = True
        '
        'PanelBuscar
        '
        Me.PanelBuscar.AutoScroll = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.PanelBuscar, 3)
        Me.PanelBuscar.Controls.Add(Me.GbxDatos)
        Me.PanelBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBuscar.Location = New System.Drawing.Point(3, 387)
        Me.PanelBuscar.Name = "PanelBuscar"
        Me.PanelBuscar.Size = New System.Drawing.Size(958, 314)
        Me.PanelBuscar.TabIndex = 9
        '
        'GbxDatos
        '
        Me.GbxDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbxDatos.Controls.Add(Me.DgvExamenes)
        Me.GbxDatos.Controls.Add(Me.BtnBuscar)
        Me.GbxDatos.Controls.Add(Me.TxtBuscar)
        Me.GbxDatos.Location = New System.Drawing.Point(0, 0)
        Me.GbxDatos.Name = "GbxDatos"
        Me.GbxDatos.Size = New System.Drawing.Size(958, 317)
        Me.GbxDatos.TabIndex = 0
        Me.GbxDatos.TabStop = False
        Me.GbxDatos.Text = "Buscar examen"
        '
        'DgvExamenes
        '
        Me.DgvExamenes.AllowUserToAddRows = False
        Me.DgvExamenes.AllowUserToDeleteRows = False
        Me.DgvExamenes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvExamenes.Location = New System.Drawing.Point(11, 72)
        Me.DgvExamenes.MultiSelect = False
        Me.DgvExamenes.Name = "DgvExamenes"
        Me.DgvExamenes.ReadOnly = True
        Me.DgvExamenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvExamenes.Size = New System.Drawing.Size(938, 207)
        Me.DgvExamenes.TabIndex = 35
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Image = Global.DB_Lab.My.Resources.Resources.searchButton
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(427, 16)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(81, 46)
        Me.BtnBuscar.TabIndex = 34
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(9, 30)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(386, 20)
        Me.TxtBuscar.TabIndex = 0
        '
        'FrmExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 815)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PanelFunciones)
        Me.Controls.Add(Me.PanelLeyenda)
        Me.Name = "FrmExamen"
        Me.Text = "FrmExamen"
        Me.PanelLeyenda.ResumeLayout(False)
        Me.PanelLeyenda.PerformLayout()
        Me.PanelFunciones.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanelDatos.ResumeLayout(False)
        Me.GrbDatosEstudios.ResumeLayout(False)
        Me.GrbDatosEstudios.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvDetalleExamen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.PanelBuscar.ResumeLayout(False)
        Me.GbxDatos.ResumeLayout(False)
        Me.GbxDatos.PerformLayout()
        CType(Me.DgvExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLeyenda As Panel
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelFunciones As Panel
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnGuardarIcon As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelDatos As Panel
    Friend WithEvents GrbDatosEstudios As GroupBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CbxCategoria As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvEstudios As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DgvDetalleExamen As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnQuitarD As Button
    Friend WithEvents BtnAñadirD As Button
    Friend WithEvents PanelBuscar As Panel
    Friend WithEvents GbxDatos As GroupBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents DgvExamenes As DataGridView
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBuscarEstudio As TextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
End Class
