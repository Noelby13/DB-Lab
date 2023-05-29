<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuario
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
        Me.LblEncabezado = New System.Windows.Forms.Label()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.PanelDatosUsuario = New System.Windows.Forms.Panel()
        Me.LblAdvertencia = New System.Windows.Forms.Label()
        Me.LblConfirmarPw2 = New System.Windows.Forms.Label()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.LblSegundoApellido = New System.Windows.Forms.Label()
        Me.TxtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.TxtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.LblPrimerApellido = New System.Windows.Forms.Label()
        Me.LblSegundoNombre = New System.Windows.Forms.Label()
        Me.TxtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.LblNombres = New System.Windows.Forms.Label()
        Me.CbxRol = New System.Windows.Forms.ComboBox()
        Me.LblRol = New System.Windows.Forms.Label()
        Me.LblConfirmarPw1 = New System.Windows.Forms.Label()
        Me.TxtConfirmarPw = New System.Windows.Forms.TextBox()
        Me.TxtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.LblNombreUsuario = New System.Windows.Forms.Label()
        Me.TxtPw = New System.Windows.Forms.TextBox()
        Me.LblPw = New System.Windows.Forms.Label()
        Me.DtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaIngreso = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblApellidos = New System.Windows.Forms.Label()
        Me.TxtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.LblPrimerNombre = New System.Windows.Forms.Label()
        Me.PanelRegistros = New System.Windows.Forms.Panel()
        Me.LblAviso = New System.Windows.Forms.Label()
        Me.DgvRegistrosUsuario = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.PanelLeyenda.SuspendLayout()
        Me.PanelBotones.SuspendLayout()
        Me.PanelDatosUsuario.SuspendLayout()
        Me.PanelRegistros.SuspendLayout()
        CType(Me.DgvRegistrosUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLeyenda
        '
        Me.PanelLeyenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PanelLeyenda.Controls.Add(Me.BtnSalir)
        Me.PanelLeyenda.Controls.Add(Me.LblEncabezado)
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
        Me.BtnSalir.TabIndex = 35
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'LblEncabezado
        '
        Me.LblEncabezado.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblEncabezado.AutoSize = True
        Me.LblEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEncabezado.ForeColor = System.Drawing.Color.White
        Me.LblEncabezado.Location = New System.Drawing.Point(10, 16)
        Me.LblEncabezado.Name = "LblEncabezado"
        Me.LblEncabezado.Size = New System.Drawing.Size(173, 20)
        Me.LblEncabezado.TabIndex = 1
        Me.LblEncabezado.Text = "Gestión de Usuarios"
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
        Me.BtnBorrar.Location = New System.Drawing.Point(560, 7)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(81, 46)
        Me.BtnBorrar.TabIndex = 4
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.Image = Global.DB_Lab.My.Resources.Resources.editButton
        Me.BtnEditar.Location = New System.Drawing.Point(451, 7)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(81, 46)
        Me.BtnEditar.TabIndex = 3
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.Image = Global.DB_Lab.My.Resources.Resources.saveButton
        Me.BtnGuardar.Location = New System.Drawing.Point(341, 7)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(81, 46)
        Me.BtnGuardar.TabIndex = 2
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpiar.Image = Global.DB_Lab.My.Resources.Resources.cleanButton
        Me.BtnLimpiar.Location = New System.Drawing.Point(232, 7)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(81, 46)
        Me.BtnLimpiar.TabIndex = 1
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'PanelDatosUsuario
        '
        Me.PanelDatosUsuario.BackColor = System.Drawing.Color.White
        Me.PanelDatosUsuario.Controls.Add(Me.LblAdvertencia)
        Me.PanelDatosUsuario.Controls.Add(Me.LblConfirmarPw2)
        Me.PanelDatosUsuario.Controls.Add(Me.TxtCedula)
        Me.PanelDatosUsuario.Controls.Add(Me.LblCedula)
        Me.PanelDatosUsuario.Controls.Add(Me.LblSegundoApellido)
        Me.PanelDatosUsuario.Controls.Add(Me.TxtSegundoApellido)
        Me.PanelDatosUsuario.Controls.Add(Me.TxtPrimerApellido)
        Me.PanelDatosUsuario.Controls.Add(Me.LblPrimerApellido)
        Me.PanelDatosUsuario.Controls.Add(Me.LblSegundoNombre)
        Me.PanelDatosUsuario.Controls.Add(Me.TxtSegundoNombre)
        Me.PanelDatosUsuario.Controls.Add(Me.LblNombres)
        Me.PanelDatosUsuario.Controls.Add(Me.CbxRol)
        Me.PanelDatosUsuario.Controls.Add(Me.LblRol)
        Me.PanelDatosUsuario.Controls.Add(Me.LblConfirmarPw1)
        Me.PanelDatosUsuario.Controls.Add(Me.TxtConfirmarPw)
        Me.PanelDatosUsuario.Controls.Add(Me.TxtNombreUsuario)
        Me.PanelDatosUsuario.Controls.Add(Me.LblNombreUsuario)
        Me.PanelDatosUsuario.Controls.Add(Me.TxtPw)
        Me.PanelDatosUsuario.Controls.Add(Me.LblPw)
        Me.PanelDatosUsuario.Controls.Add(Me.DtpFechaIngreso)
        Me.PanelDatosUsuario.Controls.Add(Me.LblFechaIngreso)
        Me.PanelDatosUsuario.Controls.Add(Me.TxtCorreo)
        Me.PanelDatosUsuario.Controls.Add(Me.LblCorreo)
        Me.PanelDatosUsuario.Controls.Add(Me.TxtTelefono)
        Me.PanelDatosUsuario.Controls.Add(Me.LblTelefono)
        Me.PanelDatosUsuario.Controls.Add(Me.LblApellidos)
        Me.PanelDatosUsuario.Controls.Add(Me.TxtPrimerNombre)
        Me.PanelDatosUsuario.Controls.Add(Me.LblPrimerNombre)
        Me.PanelDatosUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDatosUsuario.Location = New System.Drawing.Point(0, 112)
        Me.PanelDatosUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelDatosUsuario.Name = "PanelDatosUsuario"
        Me.PanelDatosUsuario.Size = New System.Drawing.Size(651, 305)
        Me.PanelDatosUsuario.TabIndex = 2
        '
        'LblAdvertencia
        '
        Me.LblAdvertencia.AutoSize = True
        Me.LblAdvertencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdvertencia.ForeColor = System.Drawing.Color.Red
        Me.LblAdvertencia.Location = New System.Drawing.Point(151, 110)
        Me.LblAdvertencia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblAdvertencia.Name = "LblAdvertencia"
        Me.LblAdvertencia.Size = New System.Drawing.Size(161, 13)
        Me.LblAdvertencia.TabIndex = 32
        Me.LblAdvertencia.Text = "El nombre ya esta ocupado"
        '
        'LblConfirmarPw2
        '
        Me.LblConfirmarPw2.AutoSize = True
        Me.LblConfirmarPw2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConfirmarPw2.Location = New System.Drawing.Point(325, 261)
        Me.LblConfirmarPw2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblConfirmarPw2.Name = "LblConfirmarPw2"
        Me.LblConfirmarPw2.Size = New System.Drawing.Size(85, 18)
        Me.LblConfirmarPw2.TabIndex = 30
        Me.LblConfirmarPw2.Text = "Contraseña"
        '
        'TxtCedula
        '
        Me.TxtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCedula.Location = New System.Drawing.Point(409, 188)
        Me.TxtCedula.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(147, 23)
        Me.TxtCedula.TabIndex = 26
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCedula.Location = New System.Drawing.Point(348, 188)
        Me.LblCedula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(58, 18)
        Me.LblCedula.TabIndex = 25
        Me.LblCedula.Text = "Cédula:"
        '
        'LblSegundoApellido
        '
        Me.LblSegundoApellido.AutoSize = True
        Me.LblSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSegundoApellido.Location = New System.Drawing.Point(526, 55)
        Me.LblSegundoApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSegundoApellido.Name = "LblSegundoApellido"
        Me.LblSegundoApellido.Size = New System.Drawing.Size(57, 13)
        Me.LblSegundoApellido.TabIndex = 13
        Me.LblSegundoApellido.Text = "Segundo"
        '
        'TxtSegundoApellido
        '
        Me.TxtSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSegundoApellido.Location = New System.Drawing.Point(528, 32)
        Me.TxtSegundoApellido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtSegundoApellido.Name = "TxtSegundoApellido"
        Me.TxtSegundoApellido.Size = New System.Drawing.Size(108, 23)
        Me.TxtSegundoApellido.TabIndex = 14
        '
        'TxtPrimerApellido
        '
        Me.TxtPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrimerApellido.Location = New System.Drawing.Point(409, 32)
        Me.TxtPrimerApellido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtPrimerApellido.Name = "TxtPrimerApellido"
        Me.TxtPrimerApellido.Size = New System.Drawing.Size(108, 23)
        Me.TxtPrimerApellido.TabIndex = 12
        '
        'LblPrimerApellido
        '
        Me.LblPrimerApellido.AutoSize = True
        Me.LblPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrimerApellido.Location = New System.Drawing.Point(406, 55)
        Me.LblPrimerApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPrimerApellido.Name = "LblPrimerApellido"
        Me.LblPrimerApellido.Size = New System.Drawing.Size(42, 13)
        Me.LblPrimerApellido.TabIndex = 11
        Me.LblPrimerApellido.Text = "Primer"
        '
        'LblSegundoNombre
        '
        Me.LblSegundoNombre.AutoSize = True
        Me.LblSegundoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSegundoNombre.Location = New System.Drawing.Point(210, 55)
        Me.LblSegundoNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSegundoNombre.Name = "LblSegundoNombre"
        Me.LblSegundoNombre.Size = New System.Drawing.Size(57, 13)
        Me.LblSegundoNombre.TabIndex = 8
        Me.LblSegundoNombre.Text = "Segundo"
        '
        'TxtSegundoNombre
        '
        Me.TxtSegundoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSegundoNombre.Location = New System.Drawing.Point(212, 32)
        Me.TxtSegundoNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtSegundoNombre.Name = "TxtSegundoNombre"
        Me.TxtSegundoNombre.Size = New System.Drawing.Size(108, 23)
        Me.TxtSegundoNombre.TabIndex = 9
        '
        'LblNombres
        '
        Me.LblNombres.AutoSize = True
        Me.LblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombres.Location = New System.Drawing.Point(19, 32)
        Me.LblNombres.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombres.Name = "LblNombres"
        Me.LblNombres.Size = New System.Drawing.Size(74, 18)
        Me.LblNombres.TabIndex = 5
        Me.LblNombres.Tag = ""
        Me.LblNombres.Text = "Nombres:"
        '
        'CbxRol
        '
        Me.CbxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxRol.FormattingEnabled = True
        Me.CbxRol.Items.AddRange(New Object() {"Seleccione el rol..."})
        Me.CbxRol.Location = New System.Drawing.Point(409, 87)
        Me.CbxRol.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CbxRol.Name = "CbxRol"
        Me.CbxRol.Size = New System.Drawing.Size(228, 25)
        Me.CbxRol.TabIndex = 18
        '
        'LblRol
        '
        Me.LblRol.AutoSize = True
        Me.LblRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRol.Location = New System.Drawing.Point(370, 88)
        Me.LblRol.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblRol.Name = "LblRol"
        Me.LblRol.Size = New System.Drawing.Size(35, 18)
        Me.LblRol.TabIndex = 17
        Me.LblRol.Text = "Rol:"
        '
        'LblConfirmarPw1
        '
        Me.LblConfirmarPw1.AutoSize = True
        Me.LblConfirmarPw1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConfirmarPw1.Location = New System.Drawing.Point(336, 243)
        Me.LblConfirmarPw1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblConfirmarPw1.Name = "LblConfirmarPw1"
        Me.LblConfirmarPw1.Size = New System.Drawing.Size(74, 18)
        Me.LblConfirmarPw1.TabIndex = 29
        Me.LblConfirmarPw1.Text = "Confirmar"
        '
        'TxtConfirmarPw
        '
        Me.TxtConfirmarPw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConfirmarPw.Location = New System.Drawing.Point(409, 239)
        Me.TxtConfirmarPw.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtConfirmarPw.Name = "TxtConfirmarPw"
        Me.TxtConfirmarPw.Size = New System.Drawing.Size(182, 23)
        Me.TxtConfirmarPw.TabIndex = 31
        Me.TxtConfirmarPw.UseSystemPasswordChar = True
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(153, 87)
        Me.TxtNombreUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(168, 23)
        Me.TxtNombreUsuario.TabIndex = 16
        '
        'LblNombreUsuario
        '
        Me.LblNombreUsuario.AutoSize = True
        Me.LblNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreUsuario.Location = New System.Drawing.Point(11, 88)
        Me.LblNombreUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombreUsuario.Name = "LblNombreUsuario"
        Me.LblNombreUsuario.Size = New System.Drawing.Size(145, 18)
        Me.LblNombreUsuario.TabIndex = 15
        Me.LblNombreUsuario.Text = "Nombre del Usuario:"
        '
        'TxtPw
        '
        Me.TxtPw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPw.Location = New System.Drawing.Point(93, 239)
        Me.TxtPw.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtPw.Name = "TxtPw"
        Me.TxtPw.Size = New System.Drawing.Size(182, 23)
        Me.TxtPw.TabIndex = 28
        Me.TxtPw.UseSystemPasswordChar = True
        '
        'LblPw
        '
        Me.LblPw.AutoSize = True
        Me.LblPw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPw.Location = New System.Drawing.Point(3, 239)
        Me.LblPw.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPw.Name = "LblPw"
        Me.LblPw.Size = New System.Drawing.Size(89, 18)
        Me.LblPw.TabIndex = 27
        Me.LblPw.Text = "Contraseña:"
        '
        'DtpFechaIngreso
        '
        Me.DtpFechaIngreso.CustomFormat = "yyyy-MM-dd"
        Me.DtpFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFechaIngreso.Location = New System.Drawing.Point(93, 188)
        Me.DtpFechaIngreso.Name = "DtpFechaIngreso"
        Me.DtpFechaIngreso.Size = New System.Drawing.Size(119, 23)
        Me.DtpFechaIngreso.TabIndex = 24
        '
        'LblFechaIngreso
        '
        Me.LblFechaIngreso.AutoSize = True
        Me.LblFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaIngreso.Location = New System.Drawing.Point(28, 188)
        Me.LblFechaIngreso.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFechaIngreso.Name = "LblFechaIngreso"
        Me.LblFechaIngreso.Size = New System.Drawing.Size(61, 18)
        Me.LblFechaIngreso.TabIndex = 23
        Me.LblFechaIngreso.Text = "Ingreso:"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreo.Location = New System.Drawing.Point(409, 142)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(215, 23)
        Me.TxtCorreo.TabIndex = 22
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorreo.Location = New System.Drawing.Point(350, 142)
        Me.LblCorreo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(59, 18)
        Me.LblCorreo.TabIndex = 21
        Me.LblCorreo.Text = "Correo:"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(92, 138)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(120, 23)
        Me.TxtTelefono.TabIndex = 20
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefono.Location = New System.Drawing.Point(20, 138)
        Me.LblTelefono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(70, 18)
        Me.LblTelefono.TabIndex = 19
        Me.LblTelefono.Text = "Teléfono:"
        '
        'LblApellidos
        '
        Me.LblApellidos.AutoSize = True
        Me.LblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellidos.Location = New System.Drawing.Point(336, 32)
        Me.LblApellidos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblApellidos.Name = "LblApellidos"
        Me.LblApellidos.Size = New System.Drawing.Size(71, 18)
        Me.LblApellidos.TabIndex = 10
        Me.LblApellidos.Text = "Apellidos:"
        '
        'TxtPrimerNombre
        '
        Me.TxtPrimerNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrimerNombre.Location = New System.Drawing.Point(93, 32)
        Me.TxtPrimerNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtPrimerNombre.Name = "TxtPrimerNombre"
        Me.TxtPrimerNombre.Size = New System.Drawing.Size(108, 23)
        Me.TxtPrimerNombre.TabIndex = 7
        '
        'LblPrimerNombre
        '
        Me.LblPrimerNombre.AutoSize = True
        Me.LblPrimerNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrimerNombre.Location = New System.Drawing.Point(91, 55)
        Me.LblPrimerNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPrimerNombre.Name = "LblPrimerNombre"
        Me.LblPrimerNombre.Size = New System.Drawing.Size(42, 13)
        Me.LblPrimerNombre.TabIndex = 6
        Me.LblPrimerNombre.Text = "Primer"
        '
        'PanelRegistros
        '
        Me.PanelRegistros.Controls.Add(Me.LblAviso)
        Me.PanelRegistros.Controls.Add(Me.DgvRegistrosUsuario)
        Me.PanelRegistros.Controls.Add(Me.BtnBuscar)
        Me.PanelRegistros.Controls.Add(Me.TxtBuscar)
        Me.PanelRegistros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRegistros.Location = New System.Drawing.Point(0, 417)
        Me.PanelRegistros.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelRegistros.Name = "PanelRegistros"
        Me.PanelRegistros.Size = New System.Drawing.Size(651, 384)
        Me.PanelRegistros.TabIndex = 3
        '
        'LblAviso
        '
        Me.LblAviso.AutoSize = True
        Me.LblAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAviso.Location = New System.Drawing.Point(20, 56)
        Me.LblAviso.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblAviso.Name = "LblAviso"
        Me.LblAviso.Size = New System.Drawing.Size(326, 13)
        Me.LblAviso.TabIndex = 35
        Me.LblAviso.Text = "Puede insertar el nombre del usuario que esta buscando"
        '
        'DgvRegistrosUsuario
        '
        Me.DgvRegistrosUsuario.AllowUserToAddRows = False
        Me.DgvRegistrosUsuario.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DgvRegistrosUsuario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvRegistrosUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvRegistrosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRegistrosUsuario.Location = New System.Drawing.Point(22, 75)
        Me.DgvRegistrosUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DgvRegistrosUsuario.MultiSelect = False
        Me.DgvRegistrosUsuario.Name = "DgvRegistrosUsuario"
        Me.DgvRegistrosUsuario.ReadOnly = True
        Me.DgvRegistrosUsuario.RowHeadersWidth = 51
        Me.DgvRegistrosUsuario.RowTemplate.Height = 24
        Me.DgvRegistrosUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRegistrosUsuario.Size = New System.Drawing.Size(601, 268)
        Me.DgvRegistrosUsuario.StandardTab = True
        Me.DgvRegistrosUsuario.TabIndex = 34
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Image = Global.DB_Lab.My.Resources.Resources.searchButton
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(542, 19)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(81, 46)
        Me.BtnBuscar.TabIndex = 33
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(22, 30)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(511, 23)
        Me.TxtBuscar.TabIndex = 32
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(651, 769)
        Me.Controls.Add(Me.PanelRegistros)
        Me.Controls.Add(Me.PanelDatosUsuario)
        Me.Controls.Add(Me.PanelBotones)
        Me.Controls.Add(Me.PanelLeyenda)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmUsuario"
        Me.Text = "Gestion de Usuarios"
        Me.PanelLeyenda.ResumeLayout(False)
        Me.PanelLeyenda.PerformLayout()
        Me.PanelBotones.ResumeLayout(False)
        Me.PanelDatosUsuario.ResumeLayout(False)
        Me.PanelDatosUsuario.PerformLayout()
        Me.PanelRegistros.ResumeLayout(False)
        Me.PanelRegistros.PerformLayout()
        CType(Me.DgvRegistrosUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLeyenda As Panel
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents PanelDatosUsuario As Panel
    Friend WithEvents LblApellidos As Label
    Friend WithEvents TxtPrimerNombre As TextBox
    Friend WithEvents LblPrimerNombre As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents LblTelefono As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents LblCorreo As Label
    Friend WithEvents DtpFechaIngreso As DateTimePicker
    Friend WithEvents LblFechaIngreso As Label
    Friend WithEvents TxtPw As TextBox
    Friend WithEvents LblPw As Label
    Friend WithEvents PanelRegistros As Panel
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents DgvRegistrosUsuario As DataGridView
    Friend WithEvents LblEncabezado As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents TxtNombreUsuario As TextBox
    Friend WithEvents LblNombreUsuario As Label
    Friend WithEvents LblConfirmarPw1 As Label
    Friend WithEvents TxtConfirmarPw As TextBox
    Friend WithEvents CbxRol As ComboBox
    Friend WithEvents LblRol As Label
    Friend WithEvents LblNombres As Label
    Friend WithEvents TxtSegundoNombre As TextBox
    Friend WithEvents LblSegundoNombre As Label
    Friend WithEvents LblSegundoApellido As Label
    Friend WithEvents TxtSegundoApellido As TextBox
    Friend WithEvents TxtPrimerApellido As TextBox
    Friend WithEvents LblPrimerApellido As Label
    Friend WithEvents LblConfirmarPw2 As Label
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents LblCedula As Label
    Friend WithEvents LblAdvertencia As Label
    Friend WithEvents LblAviso As Label
End Class
