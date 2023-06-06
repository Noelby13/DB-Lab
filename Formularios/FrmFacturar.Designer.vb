<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturar
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
        Me.TabPaciente = New System.Windows.Forms.TabControl()
        Me.Paciente = New System.Windows.Forms.TabPage()
        Me.DgvPacientes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbxFiltro = New System.Windows.Forms.ComboBox()
        Me.BtnBuscarPaciente = New System.Windows.Forms.Button()
        Me.TxtPaciente = New System.Windows.Forms.TextBox()
        Me.Examenes = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbxMetodoPago = New System.Windows.Forms.ComboBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DgvExamen = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtExamen = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CmbDoctor = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelLeyendaFactura = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.TabPaciente.SuspendLayout()
        Me.Paciente.SuspendLayout()
        CType(Me.DgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Examenes.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DgvExamen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.PanelLeyendaFactura.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPaciente
        '
        Me.TabPaciente.Controls.Add(Me.Paciente)
        Me.TabPaciente.Controls.Add(Me.Examenes)
        Me.TabPaciente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPaciente.Location = New System.Drawing.Point(0, 0)
        Me.TabPaciente.Name = "TabPaciente"
        Me.TabPaciente.SelectedIndex = 0
        Me.TabPaciente.Size = New System.Drawing.Size(800, 450)
        Me.TabPaciente.TabIndex = 0
        '
        'Paciente
        '
        Me.Paciente.Controls.Add(Me.DgvPacientes)
        Me.Paciente.Controls.Add(Me.GroupBox1)
        Me.Paciente.Location = New System.Drawing.Point(4, 22)
        Me.Paciente.Name = "Paciente"
        Me.Paciente.Padding = New System.Windows.Forms.Padding(3)
        Me.Paciente.Size = New System.Drawing.Size(792, 424)
        Me.Paciente.TabIndex = 0
        Me.Paciente.Text = "Paciente"
        Me.Paciente.UseVisualStyleBackColor = True
        '
        'DgvPacientes
        '
        Me.DgvPacientes.AllowUserToAddRows = False
        Me.DgvPacientes.AllowUserToDeleteRows = False
        Me.DgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacientes.Location = New System.Drawing.Point(3, 86)
        Me.DgvPacientes.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvPacientes.MultiSelect = False
        Me.DgvPacientes.Name = "DgvPacientes"
        Me.DgvPacientes.ReadOnly = True
        Me.DgvPacientes.RowHeadersWidth = 51
        Me.DgvPacientes.RowTemplate.Height = 24
        Me.DgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacientes.Size = New System.Drawing.Size(786, 335)
        Me.DgvPacientes.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CbxFiltro)
        Me.GroupBox1.Controls.Add(Me.BtnBuscarPaciente)
        Me.GroupBox1.Controls.Add(Me.TxtPaciente)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(786, 83)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar paciente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Filtrar por: "
        '
        'CbxFiltro
        '
        Me.CbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxFiltro.FormattingEnabled = True
        Me.CbxFiltro.Items.AddRange(New Object() {"Cedula", "Nombre"})
        Me.CbxFiltro.Location = New System.Drawing.Point(82, 35)
        Me.CbxFiltro.Name = "CbxFiltro"
        Me.CbxFiltro.Size = New System.Drawing.Size(121, 21)
        Me.CbxFiltro.TabIndex = 19
        '
        'BtnBuscarPaciente
        '
        Me.BtnBuscarPaciente.Image = Global.DB_Lab.My.Resources.Resources.searchButton
        Me.BtnBuscarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarPaciente.Location = New System.Drawing.Point(596, 21)
        Me.BtnBuscarPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscarPaciente.Name = "BtnBuscarPaciente"
        Me.BtnBuscarPaciente.Size = New System.Drawing.Size(81, 46)
        Me.BtnBuscarPaciente.TabIndex = 18
        Me.BtnBuscarPaciente.Text = "Buscar"
        Me.BtnBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarPaciente.UseVisualStyleBackColor = True
        '
        'TxtPaciente
        '
        Me.TxtPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaciente.Location = New System.Drawing.Point(225, 35)
        Me.TxtPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPaciente.Name = "TxtPaciente"
        Me.TxtPaciente.Size = New System.Drawing.Size(357, 23)
        Me.TxtPaciente.TabIndex = 17
        '
        'Examenes
        '
        Me.Examenes.Controls.Add(Me.Panel4)
        Me.Examenes.Controls.Add(Me.PanelLeyendaFactura)
        Me.Examenes.Location = New System.Drawing.Point(4, 22)
        Me.Examenes.Name = "Examenes"
        Me.Examenes.Padding = New System.Windows.Forms.Padding(3)
        Me.Examenes.Size = New System.Drawing.Size(792, 424)
        Me.Examenes.TabIndex = 1
        Me.Examenes.Text = "Examenes"
        Me.Examenes.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.CbxMetodoPago)
        Me.Panel4.Controls.Add(Me.BtnCancelar)
        Me.Panel4.Controls.Add(Me.BtnAceptar)
        Me.Panel4.Controls.Add(Me.TxtMonto)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.DgvExamen)
        Me.Panel4.Controls.Add(Me.GroupBox4)
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 54)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(786, 350)
        Me.Panel4.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Metodo de pago:"
        '
        'CbxMetodoPago
        '
        Me.CbxMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxMetodoPago.FormattingEnabled = True
        Me.CbxMetodoPago.Items.AddRange(New Object() {"Efectivo", "Tarjeta"})
        Me.CbxMetodoPago.Location = New System.Drawing.Point(105, 313)
        Me.CbxMetodoPago.Name = "CbxMetodoPago"
        Me.CbxMetodoPago.Size = New System.Drawing.Size(135, 21)
        Me.CbxMetodoPago.TabIndex = 9
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCancelar.Location = New System.Drawing.Point(569, 310)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(84, 24)
        Me.BtnCancelar.TabIndex = 8
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAceptar.Location = New System.Drawing.Point(479, 311)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(84, 24)
        Me.BtnAceptar.TabIndex = 7
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(373, 314)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.ReadOnly = True
        Me.TxtMonto.Size = New System.Drawing.Size(100, 20)
        Me.TxtMonto.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(282, 321)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Total a pagar: "
        '
        'DgvExamen
        '
        Me.DgvExamen.AllowUserToAddRows = False
        Me.DgvExamen.AllowUserToDeleteRows = False
        Me.DgvExamen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvExamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvExamen.Location = New System.Drawing.Point(16, 202)
        Me.DgvExamen.MultiSelect = False
        Me.DgvExamen.Name = "DgvExamen"
        Me.DgvExamen.ReadOnly = True
        Me.DgvExamen.RowHeadersWidth = 51
        Me.DgvExamen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvExamen.Size = New System.Drawing.Size(759, 84)
        Me.DgvExamen.TabIndex = 5
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
        Me.GroupBox4.Location = New System.Drawing.Point(15, 108)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(759, 88)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Examenes de la orden"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(540, 39)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(95, 26)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(439, 39)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(95, 26)
        Me.BtnAgregar.TabIndex = 3
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtExamen
        '
        Me.TxtExamen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtExamen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtExamen.Location = New System.Drawing.Point(151, 41)
        Me.TxtExamen.Name = "TxtExamen"
        Me.TxtExamen.Size = New System.Drawing.Size(282, 24)
        Me.TxtExamen.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 18)
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
        Me.GroupBox3.Location = New System.Drawing.Point(12, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(762, 89)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del doctor"
        '
        'CmbDoctor
        '
        Me.CmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDoctor.FormattingEnabled = True
        Me.CmbDoctor.Location = New System.Drawing.Point(103, 31)
        Me.CmbDoctor.Name = "CmbDoctor"
        Me.CmbDoctor.Size = New System.Drawing.Size(467, 26)
        Me.CmbDoctor.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nombre:"
        '
        'PanelLeyendaFactura
        '
        Me.PanelLeyendaFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PanelLeyendaFactura.Controls.Add(Me.BtnSalir)
        Me.PanelLeyendaFactura.Controls.Add(Me.LblTitulo)
        Me.PanelLeyendaFactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLeyendaFactura.Location = New System.Drawing.Point(3, 3)
        Me.PanelLeyendaFactura.Name = "PanelLeyendaFactura"
        Me.PanelLeyendaFactura.Size = New System.Drawing.Size(786, 51)
        Me.PanelLeyendaFactura.TabIndex = 1
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(706, 7)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(68, 32)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(11, 19)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(165, 20)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Facturar Examenes"
        '
        'FrmFacturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabPaciente)
        Me.Name = "FrmFacturar"
        Me.Text = "FrmFacturar"
        Me.TabPaciente.ResumeLayout(False)
        Me.Paciente.ResumeLayout(False)
        CType(Me.DgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Examenes.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DgvExamen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.PanelLeyendaFactura.ResumeLayout(False)
        Me.PanelLeyendaFactura.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPaciente As TabControl
    Friend WithEvents Paciente As TabPage
    Friend WithEvents Examenes As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtPaciente As TextBox
    Friend WithEvents BtnBuscarPaciente As Button
    Friend WithEvents DgvPacientes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CbxFiltro As ComboBox
    Friend WithEvents PanelLeyendaFactura As Panel
    Friend WithEvents BtnSalir As Button
    Friend WithEvents LblTitulo As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CbxMetodoPago As ComboBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TxtMonto As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DgvExamen As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtExamen As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CmbDoctor As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
End Class
