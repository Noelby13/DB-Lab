<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturarOrdenes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelLeyendaFactura = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelBuscar = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSexo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAgregarPaciente = New System.Windows.Forms.Button()
        Me.TxtFiltro = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.PanelLeyendaExamen = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtExamen = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CmbDoctor = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelLeyendaFactura.SuspendLayout()
        Me.PanelBuscar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelLeyendaExamen.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLeyendaFactura
        '
        Me.PanelLeyendaFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PanelLeyendaFactura.Controls.Add(Me.BtnSalir)
        Me.PanelLeyendaFactura.Controls.Add(Me.Label1)
        Me.PanelLeyendaFactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLeyendaFactura.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeyendaFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelLeyendaFactura.Name = "PanelLeyendaFactura"
        Me.PanelLeyendaFactura.Size = New System.Drawing.Size(895, 63)
        Me.PanelLeyendaFactura.TabIndex = 0
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(788, 9)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(91, 39)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Facturar Examenes"
        '
        'PanelBuscar
        '
        Me.PanelBuscar.Controls.Add(Me.GroupBox2)
        Me.PanelBuscar.Controls.Add(Me.GroupBox1)
        Me.PanelBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBuscar.Location = New System.Drawing.Point(0, 63)
        Me.PanelBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelBuscar.Name = "PanelBuscar"
        Me.PanelBuscar.Size = New System.Drawing.Size(895, 367)
        Me.PanelBuscar.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TxtCedula)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtTelefono)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtEdad)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtSexo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtNombre)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 102)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(831, 247)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del paciente"
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(115, 135)
        Me.TxtCedula.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.ReadOnly = True
        Me.TxtCedula.Size = New System.Drawing.Size(192, 29)
        Me.TxtCedula.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 135)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 24)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Cedula:"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(115, 187)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.ReadOnly = True
        Me.TxtTelefono.Size = New System.Drawing.Size(192, 29)
        Me.TxtTelefono.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 194)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Telefono:"
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(268, 81)
        Me.TxtEdad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.ReadOnly = True
        Me.TxtEdad.Size = New System.Drawing.Size(132, 29)
        Me.TxtEdad.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(199, 85)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Edad:"
        '
        'TxtSexo
        '
        Me.TxtSexo.Location = New System.Drawing.Point(115, 81)
        Me.TxtSexo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSexo.Name = "TxtSexo"
        Me.TxtSexo.ReadOnly = True
        Me.TxtSexo.Size = New System.Drawing.Size(56, 29)
        Me.TxtSexo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 85)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sexo:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(115, 37)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(285, 29)
        Me.TxtNombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 41)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnAgregarPaciente)
        Me.GroupBox1.Controls.Add(Me.TxtFiltro)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtBuscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(831, 75)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Paciente"
        '
        'BtnAgregarPaciente
        '
        Me.BtnAgregarPaciente.Location = New System.Drawing.Point(684, 28)
        Me.BtnAgregarPaciente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAgregarPaciente.Name = "BtnAgregarPaciente"
        Me.BtnAgregarPaciente.Size = New System.Drawing.Size(119, 33)
        Me.BtnAgregarPaciente.TabIndex = 4
        Me.BtnAgregarPaciente.Text = "Agregar"
        Me.BtnAgregarPaciente.UseVisualStyleBackColor = True
        '
        'TxtFiltro
        '
        Me.TxtFiltro.FormattingEnabled = True
        Me.TxtFiltro.Items.AddRange(New Object() {"Cedula", "Telefono", "Nombre"})
        Me.TxtFiltro.Location = New System.Drawing.Point(115, 30)
        Me.TxtFiltro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(169, 32)
        Me.TxtFiltro.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Filtrar por: "
        '
        'TxtBuscar
        '
        Me.TxtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtBuscar.Location = New System.Drawing.Point(304, 30)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(345, 29)
        Me.TxtBuscar.TabIndex = 1
        '
        'PanelLeyendaExamen
        '
        Me.PanelLeyendaExamen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PanelLeyendaExamen.Controls.Add(Me.Label8)
        Me.PanelLeyendaExamen.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLeyendaExamen.ForeColor = System.Drawing.Color.White
        Me.PanelLeyendaExamen.Location = New System.Drawing.Point(0, 430)
        Me.PanelLeyendaExamen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelLeyendaExamen.Name = "PanelLeyendaExamen"
        Me.PanelLeyendaExamen.Size = New System.Drawing.Size(895, 31)
        Me.PanelLeyendaExamen.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(320, 4)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Datos Examenes"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.Controls.Add(Me.BtnCancelar)
        Me.Panel4.Controls.Add(Me.BtnAceptar)
        Me.Panel4.Controls.Add(Me.TextBox8)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Controls.Add(Me.GroupBox4)
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 461)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(895, 431)
        Me.Panel4.TabIndex = 3
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCancelar.Location = New System.Drawing.Point(605, 382)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(112, 30)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAceptar.Location = New System.Drawing.Point(485, 383)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(112, 30)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox8.Location = New System.Drawing.Point(344, 386)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(132, 22)
        Me.TextBox8.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(247, 390)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 16)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Total a pagar: "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Nombre, Me.Precio})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 249)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(858, 103)
        Me.DataGridView1.TabIndex = 2
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 125
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.Width = 125
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.BtnEliminar)
        Me.GroupBox4.Controls.Add(Me.BtnAgregar)
        Me.GroupBox4.Controls.Add(Me.TxtExamen)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(20, 133)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(859, 108)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Examenes de la orden"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(720, 48)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(127, 32)
        Me.BtnEliminar.TabIndex = 3
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(585, 48)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(127, 32)
        Me.BtnAgregar.TabIndex = 2
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtExamen
        '
        Me.TxtExamen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtExamen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtExamen.Location = New System.Drawing.Point(201, 50)
        Me.TxtExamen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtExamen.Name = "TxtExamen"
        Me.TxtExamen.Size = New System.Drawing.Size(375, 29)
        Me.TxtExamen.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 53)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(194, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Nombre del examen: "
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.CmbDoctor)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 22)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(863, 110)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del doctor"
        '
        'CmbDoctor
        '
        Me.CmbDoctor.FormattingEnabled = True
        Me.CmbDoctor.Location = New System.Drawing.Point(137, 38)
        Me.CmbDoctor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbDoctor.Name = "CmbDoctor"
        Me.CmbDoctor.Size = New System.Drawing.Size(371, 32)
        Me.CmbDoctor.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 42)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nombre:"
        '
        'FrmFacturarOrdenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 891)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PanelLeyendaExamen)
        Me.Controls.Add(Me.PanelBuscar)
        Me.Controls.Add(Me.PanelLeyendaFactura)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmFacturarOrdenes"
        Me.Text = "FrmFacturarOrdenes"
        Me.PanelLeyendaFactura.ResumeLayout(False)
        Me.PanelLeyendaFactura.PerformLayout()
        Me.PanelBuscar.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelLeyendaExamen.ResumeLayout(False)
        Me.PanelLeyendaExamen.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLeyendaFactura As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents PanelBuscar As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnAgregarPaciente As Button
    Friend WithEvents TxtFiltro As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtSexo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelLeyendaExamen As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CmbDoctor As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtExamen As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnEliminar As Button
End Class
