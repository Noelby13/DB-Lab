<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListaTrabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaTrabajo))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TpLista = New System.Windows.Forms.TabPage()
        Me.GbxDatos = New System.Windows.Forms.GroupBox()
        Me.DgvLista = New System.Windows.Forms.DataGridView()
        Me.PanelLeyendaFactura = New System.Windows.Forms.Panel()
        Me.BtnRecargar = New System.Windows.Forms.Button()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TpResultado = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GbxExamenes = New System.Windows.Forms.GroupBox()
        Me.DgvResultados = New System.Windows.Forms.DataGridView()
        Me.PanelDatosCliente = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtOrden = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSexo = New System.Windows.Forms.TextBox()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.BtnReporte = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TpLista.SuspendLayout()
        Me.GbxDatos.SuspendLayout()
        CType(Me.DgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLeyendaFactura.SuspendLayout()
        Me.TpResultado.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GbxExamenes.SuspendLayout()
        CType(Me.DgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatosCliente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelBotones.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TpLista)
        Me.TabControl1.Controls.Add(Me.TpResultado)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(970, 685)
        Me.TabControl1.TabIndex = 0
        '
        'TpLista
        '
        Me.TpLista.Controls.Add(Me.GbxDatos)
        Me.TpLista.Controls.Add(Me.PanelLeyendaFactura)
        Me.TpLista.Location = New System.Drawing.Point(4, 22)
        Me.TpLista.Name = "TpLista"
        Me.TpLista.Padding = New System.Windows.Forms.Padding(3)
        Me.TpLista.Size = New System.Drawing.Size(962, 659)
        Me.TpLista.TabIndex = 0
        Me.TpLista.Text = "Ordenes"
        Me.TpLista.UseVisualStyleBackColor = True
        '
        'GbxDatos
        '
        Me.GbxDatos.Controls.Add(Me.DgvLista)
        Me.GbxDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbxDatos.Location = New System.Drawing.Point(3, 54)
        Me.GbxDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.GbxDatos.Name = "GbxDatos"
        Me.GbxDatos.Padding = New System.Windows.Forms.Padding(2)
        Me.GbxDatos.Size = New System.Drawing.Size(956, 607)
        Me.GbxDatos.TabIndex = 3
        Me.GbxDatos.TabStop = False
        Me.GbxDatos.Text = "Elija una orden para trabajar"
        '
        'DgvLista
        '
        Me.DgvLista.AllowUserToAddRows = False
        Me.DgvLista.AllowUserToDeleteRows = False
        Me.DgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvLista.Location = New System.Drawing.Point(2, 15)
        Me.DgvLista.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvLista.MultiSelect = False
        Me.DgvLista.Name = "DgvLista"
        Me.DgvLista.ReadOnly = True
        Me.DgvLista.RowHeadersWidth = 51
        Me.DgvLista.RowTemplate.Height = 24
        Me.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvLista.Size = New System.Drawing.Size(952, 590)
        Me.DgvLista.TabIndex = 2
        '
        'PanelLeyendaFactura
        '
        Me.PanelLeyendaFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PanelLeyendaFactura.Controls.Add(Me.BtnRecargar)
        Me.PanelLeyendaFactura.Controls.Add(Me.LblHora)
        Me.PanelLeyendaFactura.Controls.Add(Me.BtnSalir)
        Me.PanelLeyendaFactura.Controls.Add(Me.Label1)
        Me.PanelLeyendaFactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLeyendaFactura.Location = New System.Drawing.Point(3, 3)
        Me.PanelLeyendaFactura.Name = "PanelLeyendaFactura"
        Me.PanelLeyendaFactura.Size = New System.Drawing.Size(956, 51)
        Me.PanelLeyendaFactura.TabIndex = 1
        '
        'BtnRecargar
        '
        Me.BtnRecargar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnRecargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecargar.ForeColor = System.Drawing.Color.White
        Me.BtnRecargar.Image = CType(resources.GetObject("BtnRecargar.Image"), System.Drawing.Image)
        Me.BtnRecargar.Location = New System.Drawing.Point(793, 7)
        Me.BtnRecargar.Name = "BtnRecargar"
        Me.BtnRecargar.Size = New System.Drawing.Size(68, 32)
        Me.BtnRecargar.TabIndex = 3
        Me.BtnRecargar.UseVisualStyleBackColor = False
        '
        'LblHora
        '
        Me.LblHora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblHora.AutoSize = True
        Me.LblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.ForeColor = System.Drawing.Color.White
        Me.LblHora.Location = New System.Drawing.Point(488, 11)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(54, 20)
        Me.LblHora.TabIndex = 2
        Me.LblHora.Text = "00:00"
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(876, 7)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(68, 32)
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
        Me.Label1.Location = New System.Drawing.Point(250, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "El tablero se actualizó a las : "
        '
        'TpResultado
        '
        Me.TpResultado.Controls.Add(Me.Panel2)
        Me.TpResultado.Controls.Add(Me.PanelDatosCliente)
        Me.TpResultado.Controls.Add(Me.PanelBotones)
        Me.TpResultado.Controls.Add(Me.Panel1)
        Me.TpResultado.Location = New System.Drawing.Point(4, 22)
        Me.TpResultado.Name = "TpResultado"
        Me.TpResultado.Size = New System.Drawing.Size(962, 659)
        Me.TpResultado.TabIndex = 1
        Me.TpResultado.Text = "Resultados"
        Me.TpResultado.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GbxExamenes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 318)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(962, 341)
        Me.Panel2.TabIndex = 6
        '
        'GbxExamenes
        '
        Me.GbxExamenes.Controls.Add(Me.DgvResultados)
        Me.GbxExamenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbxExamenes.Location = New System.Drawing.Point(0, 0)
        Me.GbxExamenes.Name = "GbxExamenes"
        Me.GbxExamenes.Size = New System.Drawing.Size(962, 341)
        Me.GbxExamenes.TabIndex = 0
        Me.GbxExamenes.TabStop = False
        Me.GbxExamenes.Text = "Estudios del paciente"
        '
        'DgvResultados
        '
        Me.DgvResultados.AllowUserToAddRows = False
        Me.DgvResultados.AllowUserToDeleteRows = False
        Me.DgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvResultados.Location = New System.Drawing.Point(3, 16)
        Me.DgvResultados.MultiSelect = False
        Me.DgvResultados.Name = "DgvResultados"
        Me.DgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvResultados.Size = New System.Drawing.Size(956, 322)
        Me.DgvResultados.TabIndex = 0
        '
        'PanelDatosCliente
        '
        Me.PanelDatosCliente.Controls.Add(Me.GroupBox1)
        Me.PanelDatosCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDatosCliente.Location = New System.Drawing.Point(0, 112)
        Me.PanelDatosCliente.Name = "PanelDatosCliente"
        Me.PanelDatosCliente.Size = New System.Drawing.Size(962, 206)
        Me.PanelDatosCliente.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtOrden)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtSexo)
        Me.GroupBox1.Controls.Add(Me.TxtEdad)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(962, 206)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del cliente"
        '
        'TxtOrden
        '
        Me.TxtOrden.Location = New System.Drawing.Point(81, 129)
        Me.TxtOrden.Name = "TxtOrden"
        Me.TxtOrden.ReadOnly = True
        Me.TxtOrden.Size = New System.Drawing.Size(77, 26)
        Me.TxtOrden.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Orden:"
        '
        'TxtSexo
        '
        Me.TxtSexo.Location = New System.Drawing.Point(247, 87)
        Me.TxtSexo.Name = "TxtSexo"
        Me.TxtSexo.ReadOnly = True
        Me.TxtSexo.Size = New System.Drawing.Size(77, 26)
        Me.TxtSexo.TabIndex = 5
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(81, 87)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.ReadOnly = True
        Me.TxtEdad.Size = New System.Drawing.Size(77, 26)
        Me.TxtEdad.TabIndex = 4
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(198, 37)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(398, 26)
        Me.TxtNombre.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(178, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Sexo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Edad: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre del paciente:"
        '
        'PanelBotones
        '
        Me.PanelBotones.Controls.Add(Me.BtnReporte)
        Me.PanelBotones.Controls.Add(Me.BtnGuardar)
        Me.PanelBotones.Controls.Add(Me.BtnLimpiar)
        Me.PanelBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBotones.Location = New System.Drawing.Point(0, 52)
        Me.PanelBotones.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(962, 60)
        Me.PanelBotones.TabIndex = 4
        '
        'BtnReporte
        '
        Me.BtnReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReporte.Image = Global.DB_Lab.My.Resources.Resources.pdf32
        Me.BtnReporte.Location = New System.Drawing.Point(871, 6)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(81, 46)
        Me.BtnReporte.TabIndex = 8
        Me.BtnReporte.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.Image = Global.DB_Lab.My.Resources.Resources.saveButton
        Me.BtnGuardar.Location = New System.Drawing.Point(762, 6)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(81, 46)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpiar.Image = Global.DB_Lab.My.Resources.Resources.cleanButton
        Me.BtnLimpiar.Location = New System.Drawing.Point(652, 6)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(81, 46)
        Me.BtnLimpiar.TabIndex = 5
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LblNombre)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(962, 52)
        Me.Panel1.TabIndex = 3
        '
        'LblNombre
        '
        Me.LblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.Color.White
        Me.LblNombre.Location = New System.Drawing.Point(243, 15)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(0, 20)
        Me.LblNombre.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(884, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 32)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Captura de resultados "
        '
        'FrmListaTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 685)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmListaTrabajo"
        Me.Text = "FrmListaTrabajo"
        Me.TabControl1.ResumeLayout(False)
        Me.TpLista.ResumeLayout(False)
        Me.GbxDatos.ResumeLayout(False)
        CType(Me.DgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLeyendaFactura.ResumeLayout(False)
        Me.PanelLeyendaFactura.PerformLayout()
        Me.TpResultado.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GbxExamenes.ResumeLayout(False)
        CType(Me.DgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDatosCliente.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelBotones.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpLista As TabPage
    Friend WithEvents PanelLeyendaFactura As Panel
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvLista As DataGridView
    Friend WithEvents BtnRecargar As Button
    Friend WithEvents LblHora As Label
    Friend WithEvents GbxDatos As GroupBox
    Friend WithEvents TpResultado As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnReporte As Button
    Friend WithEvents PanelDatosCliente As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtSexo As TextBox
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GbxExamenes As GroupBox
    Friend WithEvents DgvResultados As DataGridView
    Friend WithEvents TxtOrden As TextBox
    Friend WithEvents Label6 As Label
End Class
