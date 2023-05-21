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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelLeyenda = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.PanelDatosRol = New System.Windows.Forms.Panel()
        Me.LblAdvertencia = New System.Windows.Forms.Label()
        Me.ClbPermisosRol = New System.Windows.Forms.CheckedListBox()
        Me.LblPermisosRol = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblNombreRol = New System.Windows.Forms.Label()
        Me.PanelRegistros = New System.Windows.Forms.Panel()
        Me.LblAviso = New System.Windows.Forms.Label()
        Me.DgvRegistrosRol = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.PanelLeyenda.SuspendLayout()
        Me.PanelBotones.SuspendLayout()
        Me.PanelDatosRol.SuspendLayout()
        Me.PanelRegistros.SuspendLayout()
        CType(Me.DgvRegistrosRol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLeyenda
        '
        Me.PanelLeyenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PanelLeyenda.Controls.Add(Me.BtnSalir)
        Me.PanelLeyenda.Controls.Add(Me.Label4)
        Me.PanelLeyenda.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLeyenda.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeyenda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelLeyenda.Name = "PanelLeyenda"
        Me.PanelLeyenda.Size = New System.Drawing.Size(868, 64)
        Me.PanelLeyenda.TabIndex = 0
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(764, 14)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(91, 39)
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
        Me.Label4.Location = New System.Drawing.Point(13, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 25)
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
        Me.PanelBotones.Location = New System.Drawing.Point(0, 64)
        Me.PanelBotones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(868, 74)
        Me.PanelBotones.TabIndex = 1
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBorrar.Image = Global.DB_Lab.My.Resources.Resources.deleteButton
        Me.BtnBorrar.Location = New System.Drawing.Point(747, 7)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(108, 57)
        Me.BtnBorrar.TabIndex = 4
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.Image = Global.DB_Lab.My.Resources.Resources.editButton
        Me.BtnEditar.Location = New System.Drawing.Point(601, 7)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(108, 57)
        Me.BtnEditar.TabIndex = 3
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.Image = Global.DB_Lab.My.Resources.Resources.saveButton
        Me.BtnGuardar.Location = New System.Drawing.Point(455, 7)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(108, 57)
        Me.BtnGuardar.TabIndex = 2
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpiar.Image = Global.DB_Lab.My.Resources.Resources.cleanButton
        Me.BtnLimpiar.Location = New System.Drawing.Point(309, 7)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(108, 57)
        Me.BtnLimpiar.TabIndex = 1
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'PanelDatosRol
        '
        Me.PanelDatosRol.BackColor = System.Drawing.Color.White
        Me.PanelDatosRol.Controls.Add(Me.LblAdvertencia)
        Me.PanelDatosRol.Controls.Add(Me.ClbPermisosRol)
        Me.PanelDatosRol.Controls.Add(Me.LblPermisosRol)
        Me.PanelDatosRol.Controls.Add(Me.TxtDescripcion)
        Me.PanelDatosRol.Controls.Add(Me.LblDescripcion)
        Me.PanelDatosRol.Controls.Add(Me.TxtNombre)
        Me.PanelDatosRol.Controls.Add(Me.LblNombreRol)
        Me.PanelDatosRol.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDatosRol.Location = New System.Drawing.Point(0, 138)
        Me.PanelDatosRol.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelDatosRol.Name = "PanelDatosRol"
        Me.PanelDatosRol.Size = New System.Drawing.Size(868, 410)
        Me.PanelDatosRol.TabIndex = 2
        '
        'LblAdvertencia
        '
        Me.LblAdvertencia.AutoSize = True
        Me.LblAdvertencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdvertencia.ForeColor = System.Drawing.Color.Red
        Me.LblAdvertencia.Location = New System.Drawing.Point(131, 71)
        Me.LblAdvertencia.Name = "LblAdvertencia"
        Me.LblAdvertencia.Size = New System.Drawing.Size(228, 16)
        Me.LblAdvertencia.TabIndex = 7
        Me.LblAdvertencia.Text = "Ya existe un rol con ese nombre"
        '
        'ClbPermisosRol
        '
        Me.ClbPermisosRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClbPermisosRol.FormattingEnabled = True
        Me.ClbPermisosRol.Location = New System.Drawing.Point(489, 83)
        Me.ClbPermisosRol.Name = "ClbPermisosRol"
        Me.ClbPermisosRol.Size = New System.Drawing.Size(336, 280)
        Me.ClbPermisosRol.TabIndex = 12
        '
        'LblPermisosRol
        '
        Me.LblPermisosRol.AutoSize = True
        Me.LblPermisosRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPermisosRol.Location = New System.Drawing.Point(485, 42)
        Me.LblPermisosRol.Name = "LblPermisosRol"
        Me.LblPermisosRol.Size = New System.Drawing.Size(145, 22)
        Me.LblPermisosRol.TabIndex = 10
        Me.LblPermisosRol.Text = "Permisos del Rol"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(134, 102)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescripcion.Size = New System.Drawing.Size(310, 191)
        Me.TxtDescripcion.TabIndex = 9
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.Location = New System.Drawing.Point(14, 102)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(109, 22)
        Me.LblDescripcion.TabIndex = 8
        Me.LblDescripcion.Text = "Descripción:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(134, 42)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(310, 27)
        Me.TxtNombre.TabIndex = 6
        '
        'LblNombreRol
        '
        Me.LblNombreRol.AutoSize = True
        Me.LblNombreRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreRol.Location = New System.Drawing.Point(45, 42)
        Me.LblNombreRol.Name = "LblNombreRol"
        Me.LblNombreRol.Size = New System.Drawing.Size(78, 22)
        Me.LblNombreRol.TabIndex = 5
        Me.LblNombreRol.Text = "Nombre:"
        '
        'PanelRegistros
        '
        Me.PanelRegistros.Controls.Add(Me.LblAviso)
        Me.PanelRegistros.Controls.Add(Me.DgvRegistrosRol)
        Me.PanelRegistros.Controls.Add(Me.BtnBuscar)
        Me.PanelRegistros.Controls.Add(Me.TxtBuscar)
        Me.PanelRegistros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRegistros.Location = New System.Drawing.Point(0, 548)
        Me.PanelRegistros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelRegistros.Name = "PanelRegistros"
        Me.PanelRegistros.Size = New System.Drawing.Size(868, 553)
        Me.PanelRegistros.TabIndex = 3
        '
        'LblAviso
        '
        Me.LblAviso.AutoSize = True
        Me.LblAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAviso.Location = New System.Drawing.Point(46, 66)
        Me.LblAviso.Name = "LblAviso"
        Me.LblAviso.Size = New System.Drawing.Size(283, 16)
        Me.LblAviso.TabIndex = 36
        Me.LblAviso.Text = "Puede insertar el rol que esta buscando"
        '
        'DgvRegistrosRol
        '
        Me.DgvRegistrosRol.AllowUserToAddRows = False
        Me.DgvRegistrosRol.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue
        Me.DgvRegistrosRol.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvRegistrosRol.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvRegistrosRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRegistrosRol.Location = New System.Drawing.Point(45, 110)
        Me.DgvRegistrosRol.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvRegistrosRol.MultiSelect = False
        Me.DgvRegistrosRol.Name = "DgvRegistrosRol"
        Me.DgvRegistrosRol.ReadOnly = True
        Me.DgvRegistrosRol.RowHeadersWidth = 51
        Me.DgvRegistrosRol.RowTemplate.Height = 24
        Me.DgvRegistrosRol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRegistrosRol.Size = New System.Drawing.Size(781, 292)
        Me.DgvRegistrosRol.TabIndex = 15
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = Global.DB_Lab.My.Resources.Resources.searchButton
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(717, 23)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(108, 57)
        Me.BtnBuscar.TabIndex = 14
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(45, 37)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(663, 27)
        Me.TxtBuscar.TabIndex = 13
        '
        'FrmRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(868, 970)
        Me.Controls.Add(Me.PanelRegistros)
        Me.Controls.Add(Me.PanelDatosRol)
        Me.Controls.Add(Me.PanelBotones)
        Me.Controls.Add(Me.PanelLeyenda)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmRol"
        Me.Text = "Gestion de Roles"
        Me.PanelLeyenda.ResumeLayout(False)
        Me.PanelLeyenda.PerformLayout()
        Me.PanelBotones.ResumeLayout(False)
        Me.PanelDatosRol.ResumeLayout(False)
        Me.PanelDatosRol.PerformLayout()
        Me.PanelRegistros.ResumeLayout(False)
        Me.PanelRegistros.PerformLayout()
        CType(Me.DgvRegistrosRol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLeyenda As Panel
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents PanelDatosRol As Panel
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblNombreRol As Label
    Friend WithEvents PanelRegistros As Panel
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents DgvRegistrosRol As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents ClbPermisosRol As CheckedListBox
    Friend WithEvents LblPermisosRol As Label
    Friend WithEvents LblAdvertencia As Label
    Friend WithEvents LblAviso As Label
End Class
