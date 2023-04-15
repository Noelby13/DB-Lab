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
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnGuardarIcon = New System.Windows.Forms.Button()
        Me.PanelDatosPaciente = New System.Windows.Forms.Panel()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CkbF = New System.Windows.Forms.CheckBox()
        Me.CkbM = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Lbl_nombre = New System.Windows.Forms.Label()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.PanelRegistros = New System.Windows.Forms.Panel()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.BtnBuscarEstudio = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.PanelLeyenda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelLeyenda.Name = "PanelLeyenda"
        Me.PanelLeyenda.Size = New System.Drawing.Size(868, 63)
        Me.PanelLeyenda.TabIndex = 1
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(764, 13)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.PanelOpciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelOpciones.Name = "PanelOpciones"
        Me.PanelOpciones.Size = New System.Drawing.Size(868, 74)
        Me.PanelOpciones.TabIndex = 2
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpiar.Image = Global.DB_Lab.My.Resources.Resources.cleanButton
        Me.BtnLimpiar.Location = New System.Drawing.Point(309, 10)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(108, 56)
        Me.BtnLimpiar.TabIndex = 1
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnGuardarIcon
        '
        Me.BtnGuardarIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardarIcon.Image = Global.DB_Lab.My.Resources.Resources.saveButton
        Me.BtnGuardarIcon.Location = New System.Drawing.Point(455, 8)
        Me.BtnGuardarIcon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGuardarIcon.Name = "BtnGuardarIcon"
        Me.BtnGuardarIcon.Size = New System.Drawing.Size(108, 56)
        Me.BtnGuardarIcon.TabIndex = 0
        Me.BtnGuardarIcon.UseVisualStyleBackColor = True
        '
        'PanelDatosPaciente
        '
        Me.PanelDatosPaciente.BackColor = System.Drawing.Color.White
        Me.PanelDatosPaciente.Controls.Add(Me.TextBox7)
        Me.PanelDatosPaciente.Controls.Add(Me.Label10)
        Me.PanelDatosPaciente.Controls.Add(Me.TextBox6)
        Me.PanelDatosPaciente.Controls.Add(Me.Label9)
        Me.PanelDatosPaciente.Controls.Add(Me.TextBox5)
        Me.PanelDatosPaciente.Controls.Add(Me.Label8)
        Me.PanelDatosPaciente.Controls.Add(Me.TextBox4)
        Me.PanelDatosPaciente.Controls.Add(Me.Label7)
        Me.PanelDatosPaciente.Controls.Add(Me.DateTimePicker1)
        Me.PanelDatosPaciente.Controls.Add(Me.Label6)
        Me.PanelDatosPaciente.Controls.Add(Me.Label5)
        Me.PanelDatosPaciente.Controls.Add(Me.TextBox3)
        Me.PanelDatosPaciente.Controls.Add(Me.Label4)
        Me.PanelDatosPaciente.Controls.Add(Me.CkbF)
        Me.PanelDatosPaciente.Controls.Add(Me.CkbM)
        Me.PanelDatosPaciente.Controls.Add(Me.Label3)
        Me.PanelDatosPaciente.Controls.Add(Me.TextBox2)
        Me.PanelDatosPaciente.Controls.Add(Me.Label2)
        Me.PanelDatosPaciente.Controls.Add(Me.TextBox1)
        Me.PanelDatosPaciente.Controls.Add(Me.Lbl_nombre)
        Me.PanelDatosPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDatosPaciente.Location = New System.Drawing.Point(0, 137)
        Me.PanelDatosPaciente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelDatosPaciente.Name = "PanelDatosPaciente"
        Me.PanelDatosPaciente.Size = New System.Drawing.Size(868, 345)
        Me.PanelDatosPaciente.TabIndex = 3
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(120, 286)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(299, 27)
        Me.TextBox7.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 289)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 22)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Correo:"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(537, 198)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(215, 27)
        Me.TextBox6.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(422, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 22)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Telefono:"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(120, 199)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(299, 64)
        Me.TextBox5.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Dirección:"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(537, 144)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(215, 27)
        Me.TextBox4.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(438, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 22)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cedula:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(161, 145)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(257, 22)
        Me.DateTimePicker1.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fecha de Nac:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(626, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Año(s)"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(537, 81)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(68, 27)
        Me.TextBox3.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(454, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Edad:"
        '
        'CkbF
        '
        Me.CkbF.AutoSize = True
        Me.CkbF.Location = New System.Drawing.Point(227, 86)
        Me.CkbF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CkbF.Name = "CkbF"
        Me.CkbF.Size = New System.Drawing.Size(89, 20)
        Me.CkbF.TabIndex = 9
        Me.CkbF.Text = "Femenino"
        Me.CkbF.UseVisualStyleBackColor = True
        '
        'CkbM
        '
        Me.CkbM.AutoSize = True
        Me.CkbM.Location = New System.Drawing.Point(120, 86)
        Me.CkbM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CkbM.Name = "CkbM"
        Me.CkbM.Size = New System.Drawing.Size(90, 20)
        Me.CkbM.TabIndex = 8
        Me.CkbM.Text = "Masculino"
        Me.CkbM.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sexo:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(537, 21)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(215, 27)
        Me.TextBox2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(442, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apellido: "
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(120, 21)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(299, 27)
        Me.TextBox1.TabIndex = 4
        '
        'Lbl_nombre
        '
        Me.Lbl_nombre.AutoSize = True
        Me.Lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nombre.Location = New System.Drawing.Point(15, 27)
        Me.Lbl_nombre.Name = "Lbl_nombre"
        Me.Lbl_nombre.Size = New System.Drawing.Size(78, 22)
        Me.Lbl_nombre.TabIndex = 3
        Me.Lbl_nombre.Text = "Nombre:"
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.Image = Global.DB_Lab.My.Resources.Resources.editButton
        Me.BtnEditar.Location = New System.Drawing.Point(601, 10)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(108, 56)
        Me.BtnEditar.TabIndex = 6
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBorrar.Image = Global.DB_Lab.My.Resources.Resources.deleteButton
        Me.BtnBorrar.Location = New System.Drawing.Point(747, 10)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(108, 56)
        Me.BtnBorrar.TabIndex = 7
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'PanelRegistros
        '
        Me.PanelRegistros.Controls.Add(Me.DataGridView1)
        Me.PanelRegistros.Controls.Add(Me.BtnBuscarEstudio)
        Me.PanelRegistros.Controls.Add(Me.TextBox8)
        Me.PanelRegistros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRegistros.Location = New System.Drawing.Point(0, 482)
        Me.PanelRegistros.Name = "PanelRegistros"
        Me.PanelRegistros.Size = New System.Drawing.Size(868, 409)
        Me.PanelRegistros.TabIndex = 4
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(45, 42)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(659, 27)
        Me.TextBox8.TabIndex = 8
        '
        'BtnBuscarEstudio
        '
        Me.BtnBuscarEstudio.Image = Global.DB_Lab.My.Resources.Resources.searchButton
        Me.BtnBuscarEstudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarEstudio.Location = New System.Drawing.Point(722, 28)
        Me.BtnBuscarEstudio.Name = "BtnBuscarEstudio"
        Me.BtnBuscarEstudio.Size = New System.Drawing.Size(108, 56)
        Me.BtnBuscarEstudio.TabIndex = 9
        Me.BtnBuscarEstudio.Text = "Buscar"
        Me.BtnBuscarEstudio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarEstudio.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(781, 271)
        Me.DataGridView1.TabIndex = 10
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CkbF As CheckBox
    Friend WithEvents CkbM As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnGuardarIcon As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents PanelRegistros As Panel
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents BtnBuscarEstudio As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
