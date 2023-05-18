<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaciente
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
        Me.PanelLeyenda = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelOpciones = New System.Windows.Forms.Panel()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnGuardarIcon = New System.Windows.Forms.Button()
        Me.PanelDatosPaciente = New System.Windows.Forms.Panel()
        Me.RbFemenino = New System.Windows.Forms.RadioButton()
        Me.RbMasculino = New System.Windows.Forms.RadioButton()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Lbl_nombre = New System.Windows.Forms.Label()
        Me.PanelRegistros = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarEstudio = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.PanelLeyenda.SuspendLayout()
        Me.PanelOpciones.SuspendLayout()
        Me.PanelDatosPaciente.SuspendLayout()
        Me.PanelRegistros.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLeyenda
        '
        Me.PanelLeyenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PanelLeyenda.Controls.Add(Me.BtnSalir)
        Me.PanelLeyenda.Controls.Add(Me.Label1)
        Me.PanelLeyenda.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLeyenda.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeyenda.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelLeyenda.Name = "PanelLeyenda"
        Me.PanelLeyenda.Size = New System.Drawing.Size(868, 63)
        Me.PanelLeyenda.TabIndex = 1
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
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro Paciente"
        '
        'PanelOpciones
        '
        Me.PanelOpciones.Controls.Add(Me.BtnBorrar)
        Me.PanelOpciones.Controls.Add(Me.BtnEditar)
        Me.PanelOpciones.Controls.Add(Me.BtnLimpiar)
        Me.PanelOpciones.Controls.Add(Me.BtnGuardarIcon)
        Me.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelOpciones.Location = New System.Drawing.Point(0, 63)
        Me.PanelOpciones.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelOpciones.Name = "PanelOpciones"
        Me.PanelOpciones.Size = New System.Drawing.Size(868, 74)
        Me.PanelOpciones.TabIndex = 2
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBorrar.Image = Global.DB_Lab.My.Resources.Resources.deleteButton
        Me.BtnBorrar.Location = New System.Drawing.Point(747, 10)
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
        Me.BtnEditar.Location = New System.Drawing.Point(601, 10)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(108, 57)
        Me.BtnEditar.TabIndex = 3
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpiar.Image = Global.DB_Lab.My.Resources.Resources.cleanButton
        Me.BtnLimpiar.Location = New System.Drawing.Point(309, 10)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(108, 57)
        Me.BtnLimpiar.TabIndex = 1
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnGuardarIcon
        '
        Me.BtnGuardarIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardarIcon.Image = Global.DB_Lab.My.Resources.Resources.saveButton
        Me.BtnGuardarIcon.Location = New System.Drawing.Point(455, 7)
        Me.BtnGuardarIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardarIcon.Name = "BtnGuardarIcon"
        Me.BtnGuardarIcon.Size = New System.Drawing.Size(108, 57)
        Me.BtnGuardarIcon.TabIndex = 2
        Me.BtnGuardarIcon.UseVisualStyleBackColor = True
        '
        'PanelDatosPaciente
        '
        Me.PanelDatosPaciente.BackColor = System.Drawing.Color.White
        Me.PanelDatosPaciente.Controls.Add(Me.RbFemenino)
        Me.PanelDatosPaciente.Controls.Add(Me.RbMasculino)
        Me.PanelDatosPaciente.Controls.Add(Me.TxtCorreo)
        Me.PanelDatosPaciente.Controls.Add(Me.Label10)
        Me.PanelDatosPaciente.Controls.Add(Me.TxtTelefono)
        Me.PanelDatosPaciente.Controls.Add(Me.Label9)
        Me.PanelDatosPaciente.Controls.Add(Me.TxtDireccion)
        Me.PanelDatosPaciente.Controls.Add(Me.Label8)
        Me.PanelDatosPaciente.Controls.Add(Me.TxtCedula)
        Me.PanelDatosPaciente.Controls.Add(Me.Label7)
        Me.PanelDatosPaciente.Controls.Add(Me.DateTimePicker1)
        Me.PanelDatosPaciente.Controls.Add(Me.Label6)
        Me.PanelDatosPaciente.Controls.Add(Me.Label3)
        Me.PanelDatosPaciente.Controls.Add(Me.TxtApellido)
        Me.PanelDatosPaciente.Controls.Add(Me.Label2)
        Me.PanelDatosPaciente.Controls.Add(Me.TxtNombre)
        Me.PanelDatosPaciente.Controls.Add(Me.Lbl_nombre)
        Me.PanelDatosPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDatosPaciente.Location = New System.Drawing.Point(0, 137)
        Me.PanelDatosPaciente.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelDatosPaciente.Name = "PanelDatosPaciente"
        Me.PanelDatosPaciente.Size = New System.Drawing.Size(868, 345)
        Me.PanelDatosPaciente.TabIndex = 3
        '
        'RbFemenino
        '
        Me.RbFemenino.AutoSize = True
        Me.RbFemenino.Location = New System.Drawing.Point(241, 85)
        Me.RbFemenino.Margin = New System.Windows.Forms.Padding(4)
        Me.RbFemenino.Name = "RbFemenino"
        Me.RbFemenino.Size = New System.Drawing.Size(88, 20)
        Me.RbFemenino.TabIndex = 4
        Me.RbFemenino.TabStop = True
        Me.RbFemenino.Text = "Femenino"
        Me.RbFemenino.UseVisualStyleBackColor = True
        '
        'RbMasculino
        '
        Me.RbMasculino.AutoSize = True
        Me.RbMasculino.Location = New System.Drawing.Point(120, 85)
        Me.RbMasculino.Margin = New System.Windows.Forms.Padding(4)
        Me.RbMasculino.Name = "RbMasculino"
        Me.RbMasculino.Size = New System.Drawing.Size(89, 20)
        Me.RbMasculino.TabIndex = 3
        Me.RbMasculino.TabStop = True
        Me.RbMasculino.Text = "Masculino"
        Me.RbMasculino.UseVisualStyleBackColor = True
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreo.Location = New System.Drawing.Point(120, 261)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(299, 27)
        Me.TxtCorreo.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 22)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Correo:"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(120, 197)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(299, 27)
        Me.TxtTelefono.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 22)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Telefono:"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(583, 134)
        Me.TxtDireccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDireccion.Size = New System.Drawing.Size(253, 90)
        Me.TxtDireccion.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(451, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Dirección:"
        '
        'TxtCedula
        '
        Me.TxtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCedula.Location = New System.Drawing.Point(120, 130)
        Me.TxtCedula.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(299, 27)
        Me.TxtCedula.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 22)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cedula:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(583, 85)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(257, 22)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(424, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fecha de Nac:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sexo:"
        '
        'TxtApellido
        '
        Me.TxtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido.Location = New System.Drawing.Point(583, 21)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(215, 27)
        Me.TxtApellido.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(473, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apellido: "
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(120, 21)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(299, 27)
        Me.TxtNombre.TabIndex = 1
        '
        'Lbl_nombre
        '
        Me.Lbl_nombre.AutoSize = True
        Me.Lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nombre.Location = New System.Drawing.Point(9, 27)
        Me.Lbl_nombre.Name = "Lbl_nombre"
        Me.Lbl_nombre.Size = New System.Drawing.Size(78, 22)
        Me.Lbl_nombre.TabIndex = 3
        Me.Lbl_nombre.Text = "Nombre:"
        '
        'PanelRegistros
        '
        Me.PanelRegistros.Controls.Add(Me.DataGridView1)
        Me.PanelRegistros.Controls.Add(Me.BtnBuscarEstudio)
        Me.PanelRegistros.Controls.Add(Me.TextBox8)
        Me.PanelRegistros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRegistros.Location = New System.Drawing.Point(0, 482)
        Me.PanelRegistros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelRegistros.Name = "PanelRegistros"
        Me.PanelRegistros.Size = New System.Drawing.Size(868, 409)
        Me.PanelRegistros.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 103)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(781, 271)
        Me.DataGridView1.TabIndex = 3
        '
        'BtnBuscarEstudio
        '
        Me.BtnBuscarEstudio.Image = Global.DB_Lab.My.Resources.Resources.searchButton
        Me.BtnBuscarEstudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarEstudio.Location = New System.Drawing.Point(723, 28)
        Me.BtnBuscarEstudio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBuscarEstudio.Name = "BtnBuscarEstudio"
        Me.BtnBuscarEstudio.Size = New System.Drawing.Size(108, 57)
        Me.BtnBuscarEstudio.TabIndex = 2
        Me.BtnBuscarEstudio.Text = "Buscar"
        Me.BtnBuscarEstudio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarEstudio.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(45, 42)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(659, 27)
        Me.TextBox8.TabIndex = 1
        '
        'FrmPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(868, 891)
        Me.Controls.Add(Me.PanelRegistros)
        Me.Controls.Add(Me.PanelDatosPaciente)
        Me.Controls.Add(Me.PanelOpciones)
        Me.Controls.Add(Me.PanelLeyenda)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPaciente"
        Me.PanelLeyenda.ResumeLayout(False)
        Me.PanelLeyenda.PerformLayout()
        Me.PanelOpciones.ResumeLayout(False)
        Me.PanelDatosPaciente.ResumeLayout(False)
        Me.PanelDatosPaciente.PerformLayout()
        Me.PanelRegistros.ResumeLayout(False)
        Me.PanelRegistros.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLeyenda As Panel
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelOpciones As Panel
    Friend WithEvents PanelDatosPaciente As Panel
    Friend WithEvents Lbl_nombre As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnGuardarIcon As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents PanelRegistros As Panel
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents BtnBuscarEstudio As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RbFemenino As RadioButton
    Friend WithEvents RbMasculino As RadioButton
End Class
