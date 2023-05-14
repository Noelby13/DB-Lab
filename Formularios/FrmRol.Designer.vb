<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRol
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelLeyenda = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.PanelDatosRol = New System.Windows.Forms.Panel()
        Me.TbxDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.Lbl_nombres = New System.Windows.Forms.Label()
        Me.PanelRegistros = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarRol = New System.Windows.Forms.Button()
        Me.TxtRol = New System.Windows.Forms.TextBox()
        Me.PanelLeyenda.SuspendLayout()
        Me.PanelBotones.SuspendLayout()
        Me.PanelDatosRol.SuspendLayout()
        Me.PanelRegistros.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLeyenda
        '
        Me.PanelLeyenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PanelLeyenda.Controls.Add(Me.BtnSalir)
        Me.PanelLeyenda.Controls.Add(Me.Label4)
        Me.PanelLeyenda.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLeyenda.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeyenda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelLeyenda.Name = "PanelLeyenda"
        Me.PanelLeyenda.Size = New System.Drawing.Size(651, 52)
        Me.PanelLeyenda.TabIndex = 0
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(573, 11)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(68, 32)
        Me.BtnSalir.TabIndex = 26
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Gestion de Roles"
        '
        'PanelBotones
        '
        Me.PanelBotones.Controls.Add(Me.BtnBorrar)
        Me.PanelBotones.Controls.Add(Me.BtnEditar)
        Me.PanelBotones.Controls.Add(Me.BtnGuardar)
        Me.PanelBotones.Controls.Add(Me.BtnLimpiar)
        Me.PanelBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBotones.Location = New System.Drawing.Point(0, 52)
        Me.PanelBotones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(651, 60)
        Me.PanelBotones.TabIndex = 1
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBorrar.Image = Global.DB_Lab.My.Resources.Resources.deleteButton
        Me.BtnBorrar.Location = New System.Drawing.Point(560, 6)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(81, 46)
        Me.BtnBorrar.TabIndex = 7
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.Image = Global.DB_Lab.My.Resources.Resources.editButton
        Me.BtnEditar.Location = New System.Drawing.Point(451, 6)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(81, 46)
        Me.BtnEditar.TabIndex = 6
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.Image = Global.DB_Lab.My.Resources.Resources.saveButton
        Me.BtnGuardar.Location = New System.Drawing.Point(341, 6)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(81, 46)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpiar.Image = Global.DB_Lab.My.Resources.Resources.cleanButton
        Me.BtnLimpiar.Location = New System.Drawing.Point(232, 6)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(81, 46)
        Me.BtnLimpiar.TabIndex = 4
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'PanelDatosRol
        '
        Me.PanelDatosRol.BackColor = System.Drawing.Color.White
        Me.PanelDatosRol.Controls.Add(Me.TbxDescripcion)
        Me.PanelDatosRol.Controls.Add(Me.Label1)
        Me.PanelDatosRol.Controls.Add(Me.TxtNombres)
        Me.PanelDatosRol.Controls.Add(Me.Lbl_nombres)
        Me.PanelDatosRol.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDatosRol.Location = New System.Drawing.Point(0, 112)
        Me.PanelDatosRol.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelDatosRol.Name = "PanelDatosRol"
        Me.PanelDatosRol.Size = New System.Drawing.Size(651, 162)
        Me.PanelDatosRol.TabIndex = 2
        '
        'TbxDescripcion
        '
        Me.TbxDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxDescripcion.Location = New System.Drawing.Point(407, 30)
        Me.TbxDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbxDescripcion.Multiline = True
        Me.TbxDescripcion.Name = "TbxDescripcion"
        Me.TbxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TbxDescripcion.Size = New System.Drawing.Size(227, 114)
        Me.TbxDescripcion.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(317, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Descripción:"
        '
        'TxtNombres
        '
        Me.TxtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombres.Location = New System.Drawing.Point(84, 27)
        Me.TxtNombres.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(186, 23)
        Me.TxtNombres.TabIndex = 8
        '
        'Lbl_nombres
        '
        Me.Lbl_nombres.AutoSize = True
        Me.Lbl_nombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nombres.Location = New System.Drawing.Point(17, 31)
        Me.Lbl_nombres.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_nombres.Name = "Lbl_nombres"
        Me.Lbl_nombres.Size = New System.Drawing.Size(66, 18)
        Me.Lbl_nombres.TabIndex = 7
        Me.Lbl_nombres.Text = "Nombre:"
        '
        'PanelRegistros
        '
        Me.PanelRegistros.Controls.Add(Me.DataGridView1)
        Me.PanelRegistros.Controls.Add(Me.BtnBuscarRol)
        Me.PanelRegistros.Controls.Add(Me.TxtRol)
        Me.PanelRegistros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRegistros.Location = New System.Drawing.Point(0, 274)
        Me.PanelRegistros.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelRegistros.Name = "PanelRegistros"
        Me.PanelRegistros.Size = New System.Drawing.Size(651, 449)
        Me.PanelRegistros.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 89)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(586, 237)
        Me.DataGridView1.TabIndex = 10
        '
        'BtnBuscarRol
        '
        Me.BtnBuscarRol.Image = Global.DB_Lab.My.Resources.Resources.searchButton
        Me.BtnBuscarRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarRol.Location = New System.Drawing.Point(538, 19)
        Me.BtnBuscarRol.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnBuscarRol.Name = "BtnBuscarRol"
        Me.BtnBuscarRol.Size = New System.Drawing.Size(81, 46)
        Me.BtnBuscarRol.TabIndex = 9
        Me.BtnBuscarRol.Text = "Buscar"
        Me.BtnBuscarRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarRol.UseVisualStyleBackColor = True
        '
        'TxtRol
        '
        Me.TxtRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRol.Location = New System.Drawing.Point(34, 30)
        Me.TxtRol.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtRol.Name = "TxtRol"
        Me.TxtRol.Size = New System.Drawing.Size(498, 23)
        Me.TxtRol.TabIndex = 8
        '
        'FrmRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(651, 724)
        Me.Controls.Add(Me.PanelRegistros)
        Me.Controls.Add(Me.PanelDatosRol)
        Me.Controls.Add(Me.PanelBotones)
        Me.Controls.Add(Me.PanelLeyenda)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmRol"
        Me.Text = "Gestion de Roles"
        Me.PanelLeyenda.ResumeLayout(False)
        Me.PanelLeyenda.PerformLayout()
        Me.PanelBotones.ResumeLayout(False)
        Me.PanelDatosRol.ResumeLayout(False)
        Me.PanelDatosRol.PerformLayout()
        Me.PanelRegistros.ResumeLayout(False)
        Me.PanelRegistros.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLeyenda As Panel
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents PanelDatosRol As Panel
    Friend WithEvents TbxDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents Lbl_nombres As Label
    Friend WithEvents PanelRegistros As Panel
    Friend WithEvents TxtRol As TextBox
    Friend WithEvents BtnBuscarRol As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSalir As Button
End Class
