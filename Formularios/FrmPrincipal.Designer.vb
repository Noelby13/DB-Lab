<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.PanelMenuLateral = New System.Windows.Forms.Panel()
        Me.PanelSubResultado = New System.Windows.Forms.Panel()
        Me.BtnActualizacionResultado = New System.Windows.Forms.Button()
        Me.BtnRegistroResultado = New System.Windows.Forms.Button()
        Me.BtnListaTrabajo = New System.Windows.Forms.Button()
        Me.BtnResultados = New System.Windows.Forms.Button()
        Me.PanelSubOrdenes = New System.Windows.Forms.Panel()
        Me.BtnBuscarFactura = New System.Windows.Forms.Button()
        Me.BtnCancelarFactura = New System.Windows.Forms.Button()
        Me.BtnFacturar = New System.Windows.Forms.Button()
        Me.BtnOrdenes = New System.Windows.Forms.Button()
        Me.PanelSubPaciente = New System.Windows.Forms.Panel()
        Me.BtnBuscarPaciente = New System.Windows.Forms.Button()
        Me.BtnActualizarPaciente = New System.Windows.Forms.Button()
        Me.BtnAgregarPaciente = New System.Windows.Forms.Button()
        Me.BtnPaciente = New System.Windows.Forms.Button()
        Me.PanelSubExamenes = New System.Windows.Forms.Panel()
        Me.BtnAgregarEstudio = New System.Windows.Forms.Button()
        Me.BtnAgregarExamen = New System.Windows.Forms.Button()
        Me.BtnCrearCategoria = New System.Windows.Forms.Button()
        Me.BtnExamenes = New System.Windows.Forms.Button()
        Me.PanelSubUsuario = New System.Windows.Forms.Panel()
        Me.BtnEliminarUsuario = New System.Windows.Forms.Button()
        Me.BtnActualizarUsuario = New System.Windows.Forms.Button()
        Me.BtnCrearRol = New System.Windows.Forms.Button()
        Me.BtnCrearUsuario = New System.Windows.Forms.Button()
        Me.BtnUsuario = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelFrmHijo = New System.Windows.Forms.Panel()
        Me.PanelMenuLateral.SuspendLayout()
        Me.PanelSubResultado.SuspendLayout()
        Me.PanelSubOrdenes.SuspendLayout()
        Me.PanelSubPaciente.SuspendLayout()
        Me.PanelSubExamenes.SuspendLayout()
        Me.PanelSubUsuario.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenuLateral
        '
        Me.PanelMenuLateral.AutoScroll = True
        Me.PanelMenuLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubResultado)
        Me.PanelMenuLateral.Controls.Add(Me.BtnResultados)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubOrdenes)
        Me.PanelMenuLateral.Controls.Add(Me.BtnOrdenes)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubPaciente)
        Me.PanelMenuLateral.Controls.Add(Me.BtnPaciente)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubExamenes)
        Me.PanelMenuLateral.Controls.Add(Me.BtnExamenes)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubUsuario)
        Me.PanelMenuLateral.Controls.Add(Me.BtnUsuario)
        Me.PanelMenuLateral.Controls.Add(Me.PanelLogo)
        Me.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuLateral.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuLateral.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMenuLateral.Name = "PanelMenuLateral"
        Me.PanelMenuLateral.Size = New System.Drawing.Size(165, 724)
        Me.PanelMenuLateral.TabIndex = 0
        '
        'PanelSubResultado
        '
        Me.PanelSubResultado.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSubResultado.Controls.Add(Me.BtnActualizacionResultado)
        Me.PanelSubResultado.Controls.Add(Me.BtnRegistroResultado)
        Me.PanelSubResultado.Controls.Add(Me.BtnListaTrabajo)
        Me.PanelSubResultado.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubResultado.Location = New System.Drawing.Point(0, 614)
        Me.PanelSubResultado.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSubResultado.Name = "PanelSubResultado"
        Me.PanelSubResultado.Size = New System.Drawing.Size(165, 80)
        Me.PanelSubResultado.TabIndex = 10
        '
        'BtnActualizacionResultado
        '
        Me.BtnActualizacionResultado.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnActualizacionResultado.FlatAppearance.BorderSize = 0
        Me.BtnActualizacionResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizacionResultado.ForeColor = System.Drawing.Color.White
        Me.BtnActualizacionResultado.Location = New System.Drawing.Point(0, 48)
        Me.BtnActualizacionResultado.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnActualizacionResultado.Name = "BtnActualizacionResultado"
        Me.BtnActualizacionResultado.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnActualizacionResultado.Size = New System.Drawing.Size(165, 24)
        Me.BtnActualizacionResultado.TabIndex = 2
        Me.BtnActualizacionResultado.Text = "Actualización de resultado"
        Me.BtnActualizacionResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizacionResultado.UseVisualStyleBackColor = True
        '
        'BtnRegistroResultado
        '
        Me.BtnRegistroResultado.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRegistroResultado.FlatAppearance.BorderSize = 0
        Me.BtnRegistroResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistroResultado.ForeColor = System.Drawing.Color.White
        Me.BtnRegistroResultado.Location = New System.Drawing.Point(0, 24)
        Me.BtnRegistroResultado.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRegistroResultado.Name = "BtnRegistroResultado"
        Me.BtnRegistroResultado.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnRegistroResultado.Size = New System.Drawing.Size(165, 24)
        Me.BtnRegistroResultado.TabIndex = 1
        Me.BtnRegistroResultado.Text = "Registro de Resultado"
        Me.BtnRegistroResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistroResultado.UseVisualStyleBackColor = True
        '
        'BtnListaTrabajo
        '
        Me.BtnListaTrabajo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnListaTrabajo.FlatAppearance.BorderSize = 0
        Me.BtnListaTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnListaTrabajo.ForeColor = System.Drawing.Color.White
        Me.BtnListaTrabajo.Location = New System.Drawing.Point(0, 0)
        Me.BtnListaTrabajo.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnListaTrabajo.Name = "BtnListaTrabajo"
        Me.BtnListaTrabajo.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnListaTrabajo.Size = New System.Drawing.Size(165, 24)
        Me.BtnListaTrabajo.TabIndex = 0
        Me.BtnListaTrabajo.Text = "Lista de Trabajo"
        Me.BtnListaTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnListaTrabajo.UseVisualStyleBackColor = True
        '
        'BtnResultados
        '
        Me.BtnResultados.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnResultados.FlatAppearance.BorderSize = 0
        Me.BtnResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResultados.ForeColor = System.Drawing.Color.White
        Me.BtnResultados.Location = New System.Drawing.Point(0, 577)
        Me.BtnResultados.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnResultados.Name = "BtnResultados"
        Me.BtnResultados.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnResultados.Size = New System.Drawing.Size(165, 37)
        Me.BtnResultados.TabIndex = 9
        Me.BtnResultados.Text = "Resultados"
        Me.BtnResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnResultados.UseVisualStyleBackColor = True
        '
        'PanelSubOrdenes
        '
        Me.PanelSubOrdenes.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSubOrdenes.Controls.Add(Me.BtnBuscarFactura)
        Me.PanelSubOrdenes.Controls.Add(Me.BtnCancelarFactura)
        Me.PanelSubOrdenes.Controls.Add(Me.BtnFacturar)
        Me.PanelSubOrdenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubOrdenes.Location = New System.Drawing.Point(0, 497)
        Me.PanelSubOrdenes.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSubOrdenes.Name = "PanelSubOrdenes"
        Me.PanelSubOrdenes.Size = New System.Drawing.Size(165, 80)
        Me.PanelSubOrdenes.TabIndex = 8
        '
        'BtnBuscarFactura
        '
        Me.BtnBuscarFactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBuscarFactura.FlatAppearance.BorderSize = 0
        Me.BtnBuscarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarFactura.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarFactura.Location = New System.Drawing.Point(0, 48)
        Me.BtnBuscarFactura.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscarFactura.Name = "BtnBuscarFactura"
        Me.BtnBuscarFactura.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnBuscarFactura.Size = New System.Drawing.Size(165, 24)
        Me.BtnBuscarFactura.TabIndex = 2
        Me.BtnBuscarFactura.Text = "Buscar Factura"
        Me.BtnBuscarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarFactura.UseVisualStyleBackColor = True
        '
        'BtnCancelarFactura
        '
        Me.BtnCancelarFactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCancelarFactura.FlatAppearance.BorderSize = 0
        Me.BtnCancelarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarFactura.ForeColor = System.Drawing.Color.White
        Me.BtnCancelarFactura.Location = New System.Drawing.Point(0, 24)
        Me.BtnCancelarFactura.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancelarFactura.Name = "BtnCancelarFactura"
        Me.BtnCancelarFactura.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnCancelarFactura.Size = New System.Drawing.Size(165, 24)
        Me.BtnCancelarFactura.TabIndex = 1
        Me.BtnCancelarFactura.Text = "Cancelación de Factura"
        Me.BtnCancelarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelarFactura.UseVisualStyleBackColor = True
        '
        'BtnFacturar
        '
        Me.BtnFacturar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnFacturar.FlatAppearance.BorderSize = 0
        Me.BtnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFacturar.ForeColor = System.Drawing.Color.White
        Me.BtnFacturar.Location = New System.Drawing.Point(0, 0)
        Me.BtnFacturar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnFacturar.Name = "BtnFacturar"
        Me.BtnFacturar.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnFacturar.Size = New System.Drawing.Size(165, 24)
        Me.BtnFacturar.TabIndex = 0
        Me.BtnFacturar.Text = "Facturar Orden"
        Me.BtnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFacturar.UseVisualStyleBackColor = True
        '
        'BtnOrdenes
        '
        Me.BtnOrdenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOrdenes.FlatAppearance.BorderSize = 0
        Me.BtnOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOrdenes.ForeColor = System.Drawing.Color.White
        Me.BtnOrdenes.Location = New System.Drawing.Point(0, 460)
        Me.BtnOrdenes.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnOrdenes.Name = "BtnOrdenes"
        Me.BtnOrdenes.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnOrdenes.Size = New System.Drawing.Size(165, 37)
        Me.BtnOrdenes.TabIndex = 7
        Me.BtnOrdenes.Text = "Ordenes"
        Me.BtnOrdenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOrdenes.UseVisualStyleBackColor = True
        '
        'PanelSubPaciente
        '
        Me.PanelSubPaciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSubPaciente.Controls.Add(Me.BtnBuscarPaciente)
        Me.PanelSubPaciente.Controls.Add(Me.BtnActualizarPaciente)
        Me.PanelSubPaciente.Controls.Add(Me.BtnAgregarPaciente)
        Me.PanelSubPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubPaciente.Location = New System.Drawing.Point(0, 380)
        Me.PanelSubPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSubPaciente.Name = "PanelSubPaciente"
        Me.PanelSubPaciente.Size = New System.Drawing.Size(165, 80)
        Me.PanelSubPaciente.TabIndex = 6
        '
        'BtnBuscarPaciente
        '
        Me.BtnBuscarPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBuscarPaciente.FlatAppearance.BorderSize = 0
        Me.BtnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarPaciente.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarPaciente.Location = New System.Drawing.Point(0, 48)
        Me.BtnBuscarPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscarPaciente.Name = "BtnBuscarPaciente"
        Me.BtnBuscarPaciente.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnBuscarPaciente.Size = New System.Drawing.Size(165, 24)
        Me.BtnBuscarPaciente.TabIndex = 2
        Me.BtnBuscarPaciente.Text = "Buscar Paciente"
        Me.BtnBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarPaciente.UseVisualStyleBackColor = True
        '
        'BtnActualizarPaciente
        '
        Me.BtnActualizarPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnActualizarPaciente.FlatAppearance.BorderSize = 0
        Me.BtnActualizarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizarPaciente.ForeColor = System.Drawing.Color.White
        Me.BtnActualizarPaciente.Location = New System.Drawing.Point(0, 24)
        Me.BtnActualizarPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnActualizarPaciente.Name = "BtnActualizarPaciente"
        Me.BtnActualizarPaciente.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnActualizarPaciente.Size = New System.Drawing.Size(165, 24)
        Me.BtnActualizarPaciente.TabIndex = 1
        Me.BtnActualizarPaciente.Text = "Actualizar Paciente"
        Me.BtnActualizarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizarPaciente.UseVisualStyleBackColor = True
        '
        'BtnAgregarPaciente
        '
        Me.BtnAgregarPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAgregarPaciente.FlatAppearance.BorderSize = 0
        Me.BtnAgregarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarPaciente.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarPaciente.Location = New System.Drawing.Point(0, 0)
        Me.BtnAgregarPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregarPaciente.Name = "BtnAgregarPaciente"
        Me.BtnAgregarPaciente.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnAgregarPaciente.Size = New System.Drawing.Size(165, 24)
        Me.BtnAgregarPaciente.TabIndex = 0
        Me.BtnAgregarPaciente.Text = "Agregar Paciente"
        Me.BtnAgregarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarPaciente.UseVisualStyleBackColor = True
        '
        'BtnPaciente
        '
        Me.BtnPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPaciente.FlatAppearance.BorderSize = 0
        Me.BtnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPaciente.ForeColor = System.Drawing.Color.White
        Me.BtnPaciente.Location = New System.Drawing.Point(0, 343)
        Me.BtnPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPaciente.Name = "BtnPaciente"
        Me.BtnPaciente.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnPaciente.Size = New System.Drawing.Size(165, 37)
        Me.BtnPaciente.TabIndex = 5
        Me.BtnPaciente.Text = "Pacientes"
        Me.BtnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPaciente.UseVisualStyleBackColor = True
        '
        'PanelSubExamenes
        '
        Me.PanelSubExamenes.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSubExamenes.Controls.Add(Me.BtnAgregarEstudio)
        Me.PanelSubExamenes.Controls.Add(Me.BtnAgregarExamen)
        Me.PanelSubExamenes.Controls.Add(Me.BtnCrearCategoria)
        Me.PanelSubExamenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubExamenes.Location = New System.Drawing.Point(0, 260)
        Me.PanelSubExamenes.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSubExamenes.Name = "PanelSubExamenes"
        Me.PanelSubExamenes.Size = New System.Drawing.Size(165, 83)
        Me.PanelSubExamenes.TabIndex = 4
        '
        'BtnAgregarEstudio
        '
        Me.BtnAgregarEstudio.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAgregarEstudio.FlatAppearance.BorderSize = 0
        Me.BtnAgregarEstudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarEstudio.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarEstudio.Location = New System.Drawing.Point(0, 48)
        Me.BtnAgregarEstudio.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregarEstudio.Name = "BtnAgregarEstudio"
        Me.BtnAgregarEstudio.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnAgregarEstudio.Size = New System.Drawing.Size(165, 24)
        Me.BtnAgregarEstudio.TabIndex = 2
        Me.BtnAgregarEstudio.Text = "Agregar Estudios"
        Me.BtnAgregarEstudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarEstudio.UseVisualStyleBackColor = True
        '
        'BtnAgregarExamen
        '
        Me.BtnAgregarExamen.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAgregarExamen.FlatAppearance.BorderSize = 0
        Me.BtnAgregarExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarExamen.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarExamen.Location = New System.Drawing.Point(0, 24)
        Me.BtnAgregarExamen.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregarExamen.Name = "BtnAgregarExamen"
        Me.BtnAgregarExamen.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnAgregarExamen.Size = New System.Drawing.Size(165, 24)
        Me.BtnAgregarExamen.TabIndex = 1
        Me.BtnAgregarExamen.Text = "Agregar Nuevo Examen"
        Me.BtnAgregarExamen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarExamen.UseVisualStyleBackColor = True
        '
        'BtnCrearCategoria
        '
        Me.BtnCrearCategoria.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCrearCategoria.FlatAppearance.BorderSize = 0
        Me.BtnCrearCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCrearCategoria.ForeColor = System.Drawing.Color.White
        Me.BtnCrearCategoria.Location = New System.Drawing.Point(0, 0)
        Me.BtnCrearCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCrearCategoria.Name = "BtnCrearCategoria"
        Me.BtnCrearCategoria.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnCrearCategoria.Size = New System.Drawing.Size(165, 24)
        Me.BtnCrearCategoria.TabIndex = 0
        Me.BtnCrearCategoria.Text = "Crear Categoria"
        Me.BtnCrearCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrearCategoria.UseVisualStyleBackColor = True
        '
        'BtnExamenes
        '
        Me.BtnExamenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnExamenes.FlatAppearance.BorderSize = 0
        Me.BtnExamenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExamenes.ForeColor = System.Drawing.Color.White
        Me.BtnExamenes.Location = New System.Drawing.Point(0, 223)
        Me.BtnExamenes.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnExamenes.Name = "BtnExamenes"
        Me.BtnExamenes.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnExamenes.Size = New System.Drawing.Size(165, 37)
        Me.BtnExamenes.TabIndex = 3
        Me.BtnExamenes.Text = "Examenes"
        Me.BtnExamenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExamenes.UseVisualStyleBackColor = True
        '
        'PanelSubUsuario
        '
        Me.PanelSubUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSubUsuario.Controls.Add(Me.BtnEliminarUsuario)
        Me.PanelSubUsuario.Controls.Add(Me.BtnActualizarUsuario)
        Me.PanelSubUsuario.Controls.Add(Me.BtnCrearRol)
        Me.PanelSubUsuario.Controls.Add(Me.BtnCrearUsuario)
        Me.PanelSubUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubUsuario.Location = New System.Drawing.Point(0, 118)
        Me.PanelSubUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSubUsuario.Name = "PanelSubUsuario"
        Me.PanelSubUsuario.Size = New System.Drawing.Size(165, 105)
        Me.PanelSubUsuario.TabIndex = 2
        '
        'BtnEliminarUsuario
        '
        Me.BtnEliminarUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEliminarUsuario.FlatAppearance.BorderSize = 0
        Me.BtnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarUsuario.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarUsuario.Location = New System.Drawing.Point(0, 72)
        Me.BtnEliminarUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminarUsuario.Name = "BtnEliminarUsuario"
        Me.BtnEliminarUsuario.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnEliminarUsuario.Size = New System.Drawing.Size(165, 24)
        Me.BtnEliminarUsuario.TabIndex = 3
        Me.BtnEliminarUsuario.Text = "Eliminar usuario"
        Me.BtnEliminarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarUsuario.UseVisualStyleBackColor = True
        '
        'BtnActualizarUsuario
        '
        Me.BtnActualizarUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnActualizarUsuario.FlatAppearance.BorderSize = 0
        Me.BtnActualizarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizarUsuario.ForeColor = System.Drawing.Color.White
        Me.BtnActualizarUsuario.Location = New System.Drawing.Point(0, 48)
        Me.BtnActualizarUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnActualizarUsuario.Name = "BtnActualizarUsuario"
        Me.BtnActualizarUsuario.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnActualizarUsuario.Size = New System.Drawing.Size(165, 24)
        Me.BtnActualizarUsuario.TabIndex = 2
        Me.BtnActualizarUsuario.Text = "Actualizar Usuario"
        Me.BtnActualizarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizarUsuario.UseVisualStyleBackColor = True
        '
        'BtnCrearRol
        '
        Me.BtnCrearRol.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCrearRol.FlatAppearance.BorderSize = 0
        Me.BtnCrearRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCrearRol.ForeColor = System.Drawing.Color.White
        Me.BtnCrearRol.Location = New System.Drawing.Point(0, 24)
        Me.BtnCrearRol.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCrearRol.Name = "BtnCrearRol"
        Me.BtnCrearRol.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnCrearRol.Size = New System.Drawing.Size(165, 24)
        Me.BtnCrearRol.TabIndex = 1
        Me.BtnCrearRol.Text = "Crear Roles "
        Me.BtnCrearRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrearRol.UseVisualStyleBackColor = True
        '
        'BtnCrearUsuario
        '
        Me.BtnCrearUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCrearUsuario.FlatAppearance.BorderSize = 0
        Me.BtnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCrearUsuario.ForeColor = System.Drawing.Color.White
        Me.BtnCrearUsuario.Location = New System.Drawing.Point(0, 0)
        Me.BtnCrearUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCrearUsuario.Name = "BtnCrearUsuario"
        Me.BtnCrearUsuario.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnCrearUsuario.Size = New System.Drawing.Size(165, 24)
        Me.BtnCrearUsuario.TabIndex = 0
        Me.BtnCrearUsuario.Text = "Crear Usuario"
        Me.BtnCrearUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrearUsuario.UseVisualStyleBackColor = True
        '
        'BtnUsuario
        '
        Me.BtnUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnUsuario.FlatAppearance.BorderSize = 0
        Me.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuario.ForeColor = System.Drawing.Color.White
        Me.BtnUsuario.Location = New System.Drawing.Point(0, 81)
        Me.BtnUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUsuario.Name = "BtnUsuario"
        Me.BtnUsuario.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnUsuario.Size = New System.Drawing.Size(165, 37)
        Me.BtnUsuario.TabIndex = 1
        Me.BtnUsuario.Text = "Usuarios"
        Me.BtnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUsuario.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.Label1)
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(165, 81)
        Me.PanelLogo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(76, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DB-LAB"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelFrmHijo
        '
        Me.PanelFrmHijo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelFrmHijo.Location = New System.Drawing.Point(165, 0)
        Me.PanelFrmHijo.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelFrmHijo.Name = "PanelFrmHijo"
        Me.PanelFrmHijo.Size = New System.Drawing.Size(651, 724)
        Me.PanelFrmHijo.TabIndex = 1
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 724)
        Me.Controls.Add(Me.PanelFrmHijo)
        Me.Controls.Add(Me.PanelMenuLateral)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPrincipal"
        Me.PanelMenuLateral.ResumeLayout(False)
        Me.PanelSubResultado.ResumeLayout(False)
        Me.PanelSubOrdenes.ResumeLayout(False)
        Me.PanelSubPaciente.ResumeLayout(False)
        Me.PanelSubExamenes.ResumeLayout(False)
        Me.PanelSubUsuario.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents BtnUsuario As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelSubUsuario As Panel
    Friend WithEvents BtnEliminarUsuario As Button
    Friend WithEvents BtnActualizarUsuario As Button
    Friend WithEvents BtnCrearRol As Button
    Friend WithEvents BtnCrearUsuario As Button
    Friend WithEvents BtnPaciente As Button
    Friend WithEvents PanelSubExamenes As Panel
    Friend WithEvents BtnAgregarEstudio As Button
    Friend WithEvents BtnAgregarExamen As Button
    Friend WithEvents BtnCrearCategoria As Button
    Friend WithEvents BtnExamenes As Button
    Friend WithEvents PanelSubOrdenes As Panel
    Friend WithEvents BtnBuscarFactura As Button
    Friend WithEvents BtnCancelarFactura As Button
    Friend WithEvents BtnFacturar As Button
    Friend WithEvents BtnOrdenes As Button
    Friend WithEvents PanelSubPaciente As Panel
    Friend WithEvents BtnBuscarPaciente As Button
    Friend WithEvents BtnActualizarPaciente As Button
    Friend WithEvents BtnAgregarPaciente As Button
    Friend WithEvents PanelSubResultado As Panel
    Friend WithEvents BtnActualizacionResultado As Button
    Friend WithEvents BtnRegistroResultado As Button
    Friend WithEvents BtnListaTrabajo As Button
    Friend WithEvents BtnResultados As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelFrmHijo As Panel
End Class
