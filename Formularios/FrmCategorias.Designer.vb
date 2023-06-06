<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCategorias
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.PanelDatosCategoria = New System.Windows.Forms.Panel()
        Me.LblAdvertenciaCat = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelRegistros = New System.Windows.Forms.Panel()
        Me.DgvCategorias = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarEstudio = New System.Windows.Forms.Button()
        Me.TxtCategoria = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.PanelBotones.SuspendLayout()
        Me.PanelDatosCategoria.SuspendLayout()
        Me.PanelRegistros.SuspendLayout()
        CType(Me.DgvCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnSalir)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(651, 52)
        Me.Panel1.TabIndex = 0
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(573, 11)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(68, 32)
        Me.BtnSalir.TabIndex = 27
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
        Me.Label4.Size = New System.Drawing.Size(302, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gestion de Categorias de Examenes"
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
        Me.BtnBorrar.TabIndex = 8
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.Image = Global.DB_Lab.My.Resources.Resources.editButton
        Me.BtnEditar.Location = New System.Drawing.Point(451, 6)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(81, 46)
        Me.BtnEditar.TabIndex = 7
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.Image = Global.DB_Lab.My.Resources.Resources.saveButton
        Me.BtnGuardar.Location = New System.Drawing.Point(341, 6)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(81, 46)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpiar.Image = Global.DB_Lab.My.Resources.Resources.cleanButton
        Me.BtnLimpiar.Location = New System.Drawing.Point(232, 6)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(81, 46)
        Me.BtnLimpiar.TabIndex = 5
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'PanelDatosCategoria
        '
        Me.PanelDatosCategoria.BackColor = System.Drawing.Color.White
        Me.PanelDatosCategoria.Controls.Add(Me.LblAdvertenciaCat)
        Me.PanelDatosCategoria.Controls.Add(Me.TxtDescripcion)
        Me.PanelDatosCategoria.Controls.Add(Me.LblDescripcion)
        Me.PanelDatosCategoria.Controls.Add(Me.TxtNombre)
        Me.PanelDatosCategoria.Controls.Add(Me.Label1)
        Me.PanelDatosCategoria.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDatosCategoria.Location = New System.Drawing.Point(0, 112)
        Me.PanelDatosCategoria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelDatosCategoria.Name = "PanelDatosCategoria"
        Me.PanelDatosCategoria.Size = New System.Drawing.Size(651, 82)
        Me.PanelDatosCategoria.TabIndex = 2
        '
        'LblAdvertenciaCat
        '
        Me.LblAdvertenciaCat.AutoSize = True
        Me.LblAdvertenciaCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdvertenciaCat.Location = New System.Drawing.Point(95, 53)
        Me.LblAdvertenciaCat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblAdvertenciaCat.Name = "LblAdvertenciaCat"
        Me.LblAdvertenciaCat.Size = New System.Drawing.Size(45, 13)
        Me.LblAdvertenciaCat.TabIndex = 12
        Me.LblAdvertenciaCat.Text = "Label2"
        Me.LblAdvertenciaCat.Visible = False
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(403, 32)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(186, 20)
        Me.TxtDescripcion.TabIndex = 14
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.LblDescripcion.Location = New System.Drawing.Point(316, 30)
        Me.LblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(91, 18)
        Me.LblDescripcion.TabIndex = 13
        Me.LblDescripcion.Text = "Descripción:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(98, 29)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(186, 23)
        Me.TxtNombre.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre:"
        '
        'PanelRegistros
        '
        Me.PanelRegistros.Controls.Add(Me.DgvCategorias)
        Me.PanelRegistros.Controls.Add(Me.BtnBuscarEstudio)
        Me.PanelRegistros.Controls.Add(Me.TxtCategoria)
        Me.PanelRegistros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRegistros.Location = New System.Drawing.Point(0, 194)
        Me.PanelRegistros.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelRegistros.Name = "PanelRegistros"
        Me.PanelRegistros.Size = New System.Drawing.Size(651, 528)
        Me.PanelRegistros.TabIndex = 3
        '
        'DgvCategorias
        '
        Me.DgvCategorias.AllowUserToAddRows = False
        Me.DgvCategorias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCategorias.Location = New System.Drawing.Point(32, 84)
        Me.DgvCategorias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DgvCategorias.MultiSelect = False
        Me.DgvCategorias.Name = "DgvCategorias"
        Me.DgvCategorias.ReadOnly = True
        Me.DgvCategorias.RowHeadersWidth = 51
        Me.DgvCategorias.RowTemplate.Height = 24
        Me.DgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCategorias.Size = New System.Drawing.Size(582, 237)
        Me.DgvCategorias.TabIndex = 11
        '
        'BtnBuscarEstudio
        '
        Me.BtnBuscarEstudio.Image = Global.DB_Lab.My.Resources.Resources.searchButton
        Me.BtnBuscarEstudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarEstudio.Location = New System.Drawing.Point(533, 19)
        Me.BtnBuscarEstudio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnBuscarEstudio.Name = "BtnBuscarEstudio"
        Me.BtnBuscarEstudio.Size = New System.Drawing.Size(81, 46)
        Me.BtnBuscarEstudio.TabIndex = 10
        Me.BtnBuscarEstudio.Text = "Buscar"
        Me.BtnBuscarEstudio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarEstudio.UseVisualStyleBackColor = True
        '
        'TxtCategoria
        '
        Me.TxtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCategoria.Location = New System.Drawing.Point(32, 30)
        Me.TxtCategoria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.Size = New System.Drawing.Size(494, 23)
        Me.TxtCategoria.TabIndex = 9
        '
        'FrmCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 724)
        Me.Controls.Add(Me.PanelRegistros)
        Me.Controls.Add(Me.PanelDatosCategoria)
        Me.Controls.Add(Me.PanelBotones)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmCategorias"
        Me.Text = "FrmCategorias"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelBotones.ResumeLayout(False)
        Me.PanelDatosCategoria.ResumeLayout(False)
        Me.PanelDatosCategoria.PerformLayout()
        Me.PanelRegistros.ResumeLayout(False)
        Me.PanelRegistros.PerformLayout()
        CType(Me.DgvCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents PanelDatosCategoria As Panel
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelRegistros As Panel
    Friend WithEvents TxtCategoria As TextBox
    Friend WithEvents BtnBuscarEstudio As Button
    Friend WithEvents DgvCategorias As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents LblAdvertenciaCat As Label
End Class
