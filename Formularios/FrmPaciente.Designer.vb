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
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.PanelDatosPaciente = New System.Windows.Forms.Panel()
        Me.LblSegApe = New System.Windows.Forms.Label()
        Me.LblPrimApe = New System.Windows.Forms.Label()
        Me.LblSegNom = New System.Windows.Forms.Label()
        Me.LblPrimNim = New System.Windows.Forms.Label()
        Me.TxtPrimApe = New System.Windows.Forms.TextBox()
        Me.TxtSegNom = New System.Windows.Forms.TextBox()
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
        Me.DtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSegApe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPrimNombre = New System.Windows.Forms.TextBox()
        Me.Lbl_nombre = New System.Windows.Forms.Label()
        Me.PanelRegistros = New System.Windows.Forms.Panel()
        Me.DgvPacientes = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarPaciente = New System.Windows.Forms.Button()
        Me.TxtPaciente = New System.Windows.Forms.TextBox()
        Me.PanelLeyenda.SuspendLayout()
        Me.PanelOpciones.SuspendLayout()
        Me.PanelDatosPaciente.SuspendLayout()
        Me.PanelRegistros.SuspendLayout()
        CType(Me.DgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelLeyenda.Size = New System.Drawing.Size(651, 51)
        Me.PanelLeyenda.TabIndex = 1
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(573, 11)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(68, 32)
        Me.BtnSalir.TabIndex = 19
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro Paciente"
        '
        'PanelOpciones
        '
        Me.PanelOpciones.Controls.Add(Me.BtnBorrar)
        Me.PanelOpciones.Controls.Add(Me.BtnEditar)
        Me.PanelOpciones.Controls.Add(Me.BtnLimpiar)
        Me.PanelOpciones.Controls.Add(Me.BtnGuardar)
        Me.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelOpciones.Location = New System.Drawing.Point(0, 51)
        Me.PanelOpciones.Name = "PanelOpciones"
        Me.PanelOpciones.Size = New System.Drawing.Size(651, 60)
        Me.PanelOpciones.TabIndex = 2
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBorrar.Image = Global.DB_Lab.My.Resources.Resources.deleteButton
        Me.BtnBorrar.Location = New System.Drawing.Point(560, 8)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(81, 46)
        Me.BtnBorrar.TabIndex = 4
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.Image = Global.DB_Lab.My.Resources.Resources.editButton
        Me.BtnEditar.Location = New System.Drawing.Point(451, 8)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(81, 46)
        Me.BtnEditar.TabIndex = 3
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpiar.Image = Global.DB_Lab.My.Resources.Resources.cleanButton
        Me.BtnLimpiar.Location = New System.Drawing.Point(232, 8)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(81, 46)
        Me.BtnLimpiar.TabIndex = 1
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.Image = Global.DB_Lab.My.Resources.Resources.saveButton
        Me.BtnGuardar.Location = New System.Drawing.Point(341, 6)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(81, 46)
        Me.BtnGuardar.TabIndex = 2
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'PanelDatosPaciente
        '
        Me.PanelDatosPaciente.BackColor = System.Drawing.Color.White
        Me.PanelDatosPaciente.Controls.Add(Me.LblSegApe)
        Me.PanelDatosPaciente.Controls.Add(Me.LblPrimApe)
        Me.PanelDatosPaciente.Controls.Add(Me.LblSegNom)
        Me.PanelDatosPaciente.Controls.Add(Me.LblPrimNim)
        Me.PanelDatosPaciente.Controls.Add(Me.TxtPrimApe)
        Me.PanelDatosPaciente.Controls.Add(Me.TxtSegNom)
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
        Me.PanelDatosPaciente.Controls.Add(Me.DtpFechaNac)
        Me.PanelDatosPaciente.Controls.Add(Me.Label6)
        Me.PanelDatosPaciente.Controls.Add(Me.Label3)
        Me.PanelDatosPaciente.Controls.Add(Me.TxtSegApe)
        Me.PanelDatosPaciente.Controls.Add(Me.Label2)
        Me.PanelDatosPaciente.Controls.Add(Me.TxtPrimNombre)
        Me.PanelDatosPaciente.Controls.Add(Me.Lbl_nombre)
        Me.PanelDatosPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDatosPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelDatosPaciente.Location = New System.Drawing.Point(0, 111)
        Me.PanelDatosPaciente.Name = "PanelDatosPaciente"
        Me.PanelDatosPaciente.Size = New System.Drawing.Size(651, 280)
        Me.PanelDatosPaciente.TabIndex = 3
        '
        'LblSegApe
        '
        Me.LblSegApe.AutoSize = True
        Me.LblSegApe.Location = New System.Drawing.Point(533, 40)
        Me.LblSegApe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSegApe.Name = "LblSegApe"
        Me.LblSegApe.Size = New System.Drawing.Size(57, 13)
        Me.LblSegApe.TabIndex = 28
        Me.LblSegApe.Text = "Segundo"
        '
        'LblPrimApe
        '
        Me.LblPrimApe.AutoSize = True
        Me.LblPrimApe.Location = New System.Drawing.Point(420, 40)
        Me.LblPrimApe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPrimApe.Name = "LblPrimApe"
        Me.LblPrimApe.Size = New System.Drawing.Size(42, 13)
        Me.LblPrimApe.TabIndex = 27
        Me.LblPrimApe.Text = "Primer"
        '
        'LblSegNom
        '
        Me.LblSegNom.AutoSize = True
        Me.LblSegNom.Location = New System.Drawing.Point(207, 40)
        Me.LblSegNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSegNom.Name = "LblSegNom"
        Me.LblSegNom.Size = New System.Drawing.Size(57, 13)
        Me.LblSegNom.TabIndex = 26
        Me.LblSegNom.Text = "Segundo"
        '
        'LblPrimNim
        '
        Me.LblPrimNim.AutoSize = True
        Me.LblPrimNim.Location = New System.Drawing.Point(88, 41)
        Me.LblPrimNim.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPrimNim.Name = "LblPrimNim"
        Me.LblPrimNim.Size = New System.Drawing.Size(42, 13)
        Me.LblPrimNim.TabIndex = 25
        Me.LblPrimNim.Text = "Primer"
        '
        'TxtPrimApe
        '
        Me.TxtPrimApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrimApe.Location = New System.Drawing.Point(420, 18)
        Me.TxtPrimApe.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtPrimApe.Name = "TxtPrimApe"
        Me.TxtPrimApe.Size = New System.Drawing.Size(109, 23)
        Me.TxtPrimApe.TabIndex = 7
        '
        'TxtSegNom
        '
        Me.TxtSegNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSegNom.Location = New System.Drawing.Point(207, 18)
        Me.TxtSegNom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtSegNom.Name = "TxtSegNom"
        Me.TxtSegNom.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSegNom.Size = New System.Drawing.Size(108, 23)
        Me.TxtSegNom.TabIndex = 6
        '
        'RbFemenino
        '
        Me.RbFemenino.AutoSize = True
        Me.RbFemenino.Location = New System.Drawing.Point(181, 69)
        Me.RbFemenino.Name = "RbFemenino"
        Me.RbFemenino.Size = New System.Drawing.Size(79, 17)
        Me.RbFemenino.TabIndex = 10
        Me.RbFemenino.TabStop = True
        Me.RbFemenino.Text = "Femenino"
        Me.RbFemenino.UseVisualStyleBackColor = True
        '
        'RbMasculino
        '
        Me.RbMasculino.AutoSize = True
        Me.RbMasculino.Location = New System.Drawing.Point(90, 69)
        Me.RbMasculino.Name = "RbMasculino"
        Me.RbMasculino.Size = New System.Drawing.Size(82, 17)
        Me.RbMasculino.TabIndex = 9
        Me.RbMasculino.TabStop = True
        Me.RbMasculino.Text = "Masculino"
        Me.RbMasculino.UseVisualStyleBackColor = True
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreo.Location = New System.Drawing.Point(90, 212)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(225, 23)
        Me.TxtCorreo.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 217)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 18)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Correo:"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(90, 160)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(225, 23)
        Me.TxtTelefono.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 164)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 18)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Telefono:"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(437, 109)
        Me.TxtDireccion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDireccion.Size = New System.Drawing.Size(191, 74)
        Me.TxtDireccion.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(338, 112)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Dirección:"
        '
        'TxtCedula
        '
        Me.TxtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCedula.Location = New System.Drawing.Point(90, 106)
        Me.TxtCedula.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(225, 23)
        Me.TxtCedula.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 109)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cedula:"
        '
        'DtpFechaNac
        '
        Me.DtpFechaNac.CustomFormat = "yyyy-MM-dd"
        Me.DtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFechaNac.Location = New System.Drawing.Point(437, 69)
        Me.DtpFechaNac.Name = "DtpFechaNac"
        Me.DtpFechaNac.Size = New System.Drawing.Size(194, 19)
        Me.DtpFechaNac.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(318, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fecha de Nac:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sexo:"
        '
        'TxtSegApe
        '
        Me.TxtSegApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSegApe.Location = New System.Drawing.Point(533, 18)
        Me.TxtSegApe.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtSegApe.Name = "TxtSegApe"
        Me.TxtSegApe.Size = New System.Drawing.Size(109, 23)
        Me.TxtSegApe.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(355, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apellido: "
        '
        'TxtPrimNombre
        '
        Me.TxtPrimNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrimNombre.Location = New System.Drawing.Point(90, 17)
        Me.TxtPrimNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtPrimNombre.Name = "TxtPrimNombre"
        Me.TxtPrimNombre.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPrimNombre.Size = New System.Drawing.Size(108, 23)
        Me.TxtPrimNombre.TabIndex = 5
        '
        'Lbl_nombre
        '
        Me.Lbl_nombre.AutoSize = True
        Me.Lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nombre.Location = New System.Drawing.Point(7, 22)
        Me.Lbl_nombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_nombre.Name = "Lbl_nombre"
        Me.Lbl_nombre.Size = New System.Drawing.Size(66, 18)
        Me.Lbl_nombre.TabIndex = 3
        Me.Lbl_nombre.Text = "Nombre:"
        '
        'PanelRegistros
        '
        Me.PanelRegistros.Controls.Add(Me.DgvPacientes)
        Me.PanelRegistros.Controls.Add(Me.BtnBuscarPaciente)
        Me.PanelRegistros.Controls.Add(Me.TxtPaciente)
        Me.PanelRegistros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRegistros.Location = New System.Drawing.Point(0, 391)
        Me.PanelRegistros.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelRegistros.Name = "PanelRegistros"
        Me.PanelRegistros.Size = New System.Drawing.Size(651, 332)
        Me.PanelRegistros.TabIndex = 4
        '
        'DgvPacientes
        '
        Me.DgvPacientes.AllowUserToAddRows = False
        Me.DgvPacientes.AllowUserToDeleteRows = False
        Me.DgvPacientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacientes.Location = New System.Drawing.Point(34, 84)
        Me.DgvPacientes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DgvPacientes.MultiSelect = False
        Me.DgvPacientes.Name = "DgvPacientes"
        Me.DgvPacientes.ReadOnly = True
        Me.DgvPacientes.RowHeadersWidth = 51
        Me.DgvPacientes.RowTemplate.Height = 24
        Me.DgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacientes.Size = New System.Drawing.Size(586, 220)
        Me.DgvPacientes.TabIndex = 18
        '
        'BtnBuscarPaciente
        '
        Me.BtnBuscarPaciente.Image = Global.DB_Lab.My.Resources.Resources.searchButton
        Me.BtnBuscarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarPaciente.Location = New System.Drawing.Point(542, 23)
        Me.BtnBuscarPaciente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnBuscarPaciente.Name = "BtnBuscarPaciente"
        Me.BtnBuscarPaciente.Size = New System.Drawing.Size(81, 46)
        Me.BtnBuscarPaciente.TabIndex = 17
        Me.BtnBuscarPaciente.Text = "Buscar"
        Me.BtnBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarPaciente.UseVisualStyleBackColor = True
        '
        'TxtPaciente
        '
        Me.TxtPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaciente.Location = New System.Drawing.Point(34, 34)
        Me.TxtPaciente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtPaciente.Name = "TxtPaciente"
        Me.TxtPaciente.Size = New System.Drawing.Size(495, 23)
        Me.TxtPaciente.TabIndex = 16
        '
        'FrmPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(651, 724)
        Me.Controls.Add(Me.PanelRegistros)
        Me.Controls.Add(Me.PanelDatosPaciente)
        Me.Controls.Add(Me.PanelOpciones)
        Me.Controls.Add(Me.PanelLeyenda)
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
        CType(Me.DgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLeyenda As Panel
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelOpciones As Panel
    Friend WithEvents PanelDatosPaciente As Panel
    Friend WithEvents Lbl_nombre As Label
    Friend WithEvents TxtPrimNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSegApe As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpFechaNac As DateTimePicker
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents PanelRegistros As Panel
    Friend WithEvents TxtPaciente As TextBox
    Friend WithEvents BtnBuscarPaciente As Button
    Friend WithEvents DgvPacientes As DataGridView
    Friend WithEvents RbFemenino As RadioButton
    Friend WithEvents RbMasculino As RadioButton
    Friend WithEvents TxtPrimApe As TextBox
    Friend WithEvents TxtSegNom As TextBox
    Friend WithEvents LblPrimNim As Label
    Friend WithEvents LblSegNom As Label
    Friend WithEvents LblSegApe As Label
    Friend WithEvents LblPrimApe As Label
End Class
