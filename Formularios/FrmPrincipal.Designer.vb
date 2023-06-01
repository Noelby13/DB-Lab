<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelSubReportes = New System.Windows.Forms.Panel()
        Me.BtnMostrarDoctores = New System.Windows.Forms.Button()
        Me.BtnReporteExamenes = New System.Windows.Forms.Button()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.BtnDoctor = New System.Windows.Forms.Button()
        Me.PanelSubDoctor = New System.Windows.Forms.Panel()
        Me.BtnAbrirDr = New System.Windows.Forms.Button()
        Me.PanelSubResultado = New System.Windows.Forms.Panel()
        Me.BtnActualizacionResultado = New System.Windows.Forms.Button()
        Me.BtnListaTrabajo = New System.Windows.Forms.Button()
        Me.BtnResultados = New System.Windows.Forms.Button()
        Me.PanelSubOrdenes = New System.Windows.Forms.Panel()
        Me.BtnCancelarFactura = New System.Windows.Forms.Button()
        Me.BtnFacturar = New System.Windows.Forms.Button()
        Me.BtnOrdenes = New System.Windows.Forms.Button()
        Me.PanelSubPaciente = New System.Windows.Forms.Panel()
        Me.BtnAgregarPaciente = New System.Windows.Forms.Button()
        Me.BtnPaciente = New System.Windows.Forms.Button()
        Me.PanelSubExamenes = New System.Windows.Forms.Panel()
        Me.BtnAgregarEstudio = New System.Windows.Forms.Button()
        Me.BtnAgregarExamen = New System.Windows.Forms.Button()
        Me.BtnGestionarUnidad = New System.Windows.Forms.Button()
        Me.BtnCrearCategoria = New System.Windows.Forms.Button()
        Me.PanelSubUsuario = New System.Windows.Forms.Panel()
        Me.BtnCrearRol = New System.Windows.Forms.Button()
        Me.BtnCrearUsuario = New System.Windows.Forms.Button()
        Me.BtnUsuario = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnExamenes = New System.Windows.Forms.Button()
        Me.PanelFrmHijo = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelSubReportes.SuspendLayout()
        Me.PanelSubDoctor.SuspendLayout()
        Me.PanelSubResultado.SuspendLayout()
        Me.PanelSubOrdenes.SuspendLayout()
        Me.PanelSubPaciente.SuspendLayout()
        Me.PanelSubExamenes.SuspendLayout()
        Me.PanelSubUsuario.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelSubReportes, 0, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnReportes, 0, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnDoctor, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelSubDoctor, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelSubResultado, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnResultados, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelSubOrdenes, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnOrdenes, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelSubPaciente, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnPaciente, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelSubExamenes, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelSubUsuario, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnUsuario, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnExamenes, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 16
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 847)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'PanelSubReportes
        '
        Me.PanelSubReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSubReportes.Controls.Add(Me.BtnMostrarDoctores)
        Me.PanelSubReportes.Controls.Add(Me.BtnReporteExamenes)
        Me.PanelSubReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubReportes.Location = New System.Drawing.Point(2, 742)
        Me.PanelSubReportes.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSubReportes.Name = "PanelSubReportes"
        Me.PanelSubReportes.Size = New System.Drawing.Size(196, 49)
        Me.PanelSubReportes.TabIndex = 18
        '
        'BtnMostrarDoctores
        '
        Me.BtnMostrarDoctores.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMostrarDoctores.FlatAppearance.BorderSize = 0
        Me.BtnMostrarDoctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMostrarDoctores.ForeColor = System.Drawing.Color.White
        Me.BtnMostrarDoctores.Location = New System.Drawing.Point(0, 24)
        Me.BtnMostrarDoctores.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMostrarDoctores.Name = "BtnMostrarDoctores"
        Me.BtnMostrarDoctores.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnMostrarDoctores.Size = New System.Drawing.Size(196, 24)
        Me.BtnMostrarDoctores.TabIndex = 2
        Me.BtnMostrarDoctores.Text = "Doctores"
        Me.BtnMostrarDoctores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMostrarDoctores.UseVisualStyleBackColor = True
        '
        'BtnReporteExamenes
        '
        Me.BtnReporteExamenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReporteExamenes.FlatAppearance.BorderSize = 0
        Me.BtnReporteExamenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReporteExamenes.ForeColor = System.Drawing.Color.White
        Me.BtnReporteExamenes.Location = New System.Drawing.Point(0, 0)
        Me.BtnReporteExamenes.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnReporteExamenes.Name = "BtnReporteExamenes"
        Me.BtnReporteExamenes.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnReporteExamenes.Size = New System.Drawing.Size(196, 24)
        Me.BtnReporteExamenes.TabIndex = 0
        Me.BtnReporteExamenes.Text = "Examenes"
        Me.BtnReporteExamenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReporteExamenes.UseVisualStyleBackColor = True
        '
        'BtnReportes
        '
        Me.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReportes.FlatAppearance.BorderSize = 0
        Me.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReportes.ForeColor = System.Drawing.Color.White
        Me.BtnReportes.Location = New System.Drawing.Point(2, 701)
        Me.BtnReportes.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnReportes.Size = New System.Drawing.Size(196, 37)
        Me.BtnReportes.TabIndex = 17
        Me.BtnReportes.Text = "Reportes"
        Me.BtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReportes.UseVisualStyleBackColor = True
        '
        'BtnDoctor
        '
        Me.BtnDoctor.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDoctor.FlatAppearance.BorderSize = 0
        Me.BtnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDoctor.ForeColor = System.Drawing.Color.White
        Me.BtnDoctor.Location = New System.Drawing.Point(2, 435)
        Me.BtnDoctor.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDoctor.Name = "BtnDoctor"
        Me.BtnDoctor.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnDoctor.Size = New System.Drawing.Size(196, 27)
        Me.BtnDoctor.TabIndex = 15
        Me.BtnDoctor.Text = "Doctor"
        Me.BtnDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDoctor.UseVisualStyleBackColor = True
        '
        'PanelSubDoctor
        '
        Me.PanelSubDoctor.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSubDoctor.Controls.Add(Me.BtnAbrirDr)
        Me.PanelSubDoctor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubDoctor.Location = New System.Drawing.Point(2, 466)
        Me.PanelSubDoctor.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSubDoctor.Name = "PanelSubDoctor"
        Me.PanelSubDoctor.Size = New System.Drawing.Size(196, 30)
        Me.PanelSubDoctor.TabIndex = 16
        '
        'BtnAbrirDr
        '
        Me.BtnAbrirDr.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAbrirDr.FlatAppearance.BorderSize = 0
        Me.BtnAbrirDr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbrirDr.ForeColor = System.Drawing.Color.White
        Me.BtnAbrirDr.Location = New System.Drawing.Point(0, 0)
        Me.BtnAbrirDr.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAbrirDr.Name = "BtnAbrirDr"
        Me.BtnAbrirDr.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnAbrirDr.Size = New System.Drawing.Size(196, 24)
        Me.BtnAbrirDr.TabIndex = 0
        Me.BtnAbrirDr.Text = "Gestion de Doctores"
        Me.BtnAbrirDr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAbrirDr.UseVisualStyleBackColor = True
        '
        'PanelSubResultado
        '
        Me.PanelSubResultado.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSubResultado.Controls.Add(Me.BtnActualizacionResultado)
        Me.PanelSubResultado.Controls.Add(Me.BtnListaTrabajo)
        Me.PanelSubResultado.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubResultado.Location = New System.Drawing.Point(2, 642)
        Me.PanelSubResultado.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSubResultado.Name = "PanelSubResultado"
        Me.PanelSubResultado.Size = New System.Drawing.Size(196, 55)
        Me.PanelSubResultado.TabIndex = 14
        '
        'BtnActualizacionResultado
        '
        Me.BtnActualizacionResultado.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnActualizacionResultado.FlatAppearance.BorderSize = 0
        Me.BtnActualizacionResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizacionResultado.ForeColor = System.Drawing.Color.White
        Me.BtnActualizacionResultado.Location = New System.Drawing.Point(0, 24)
        Me.BtnActualizacionResultado.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnActualizacionResultado.Name = "BtnActualizacionResultado"
        Me.BtnActualizacionResultado.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnActualizacionResultado.Size = New System.Drawing.Size(196, 24)
        Me.BtnActualizacionResultado.TabIndex = 2
        Me.BtnActualizacionResultado.Text = "Actualización de resultado"
        Me.BtnActualizacionResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizacionResultado.UseVisualStyleBackColor = True
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
        Me.BtnListaTrabajo.Size = New System.Drawing.Size(196, 24)
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
        Me.BtnResultados.Location = New System.Drawing.Point(2, 601)
        Me.BtnResultados.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnResultados.Name = "BtnResultados"
        Me.BtnResultados.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnResultados.Size = New System.Drawing.Size(196, 37)
        Me.BtnResultados.TabIndex = 13
        Me.BtnResultados.Text = "Resultados"
        Me.BtnResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnResultados.UseVisualStyleBackColor = True
        '
        'PanelSubOrdenes
        '
        Me.PanelSubOrdenes.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSubOrdenes.Controls.Add(Me.BtnCancelarFactura)
        Me.PanelSubOrdenes.Controls.Add(Me.BtnFacturar)
        Me.PanelSubOrdenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubOrdenes.Location = New System.Drawing.Point(2, 541)
        Me.PanelSubOrdenes.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSubOrdenes.Name = "PanelSubOrdenes"
        Me.PanelSubOrdenes.Size = New System.Drawing.Size(196, 56)
        Me.PanelSubOrdenes.TabIndex = 12
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
        Me.BtnCancelarFactura.Size = New System.Drawing.Size(196, 24)
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
        Me.BtnFacturar.Size = New System.Drawing.Size(196, 24)
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
        Me.BtnOrdenes.Location = New System.Drawing.Point(2, 500)
        Me.BtnOrdenes.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnOrdenes.Name = "BtnOrdenes"
        Me.BtnOrdenes.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnOrdenes.Size = New System.Drawing.Size(196, 37)
        Me.BtnOrdenes.TabIndex = 11
        Me.BtnOrdenes.Text = "Ordenes"
        Me.BtnOrdenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOrdenes.UseVisualStyleBackColor = True
        '
        'PanelSubPaciente
        '
        Me.PanelSubPaciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSubPaciente.Controls.Add(Me.BtnAgregarPaciente)
        Me.PanelSubPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubPaciente.Location = New System.Drawing.Point(2, 402)
        Me.PanelSubPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSubPaciente.Name = "PanelSubPaciente"
        Me.PanelSubPaciente.Size = New System.Drawing.Size(196, 29)
        Me.PanelSubPaciente.TabIndex = 10
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
        Me.BtnAgregarPaciente.Size = New System.Drawing.Size(196, 24)
        Me.BtnAgregarPaciente.TabIndex = 0
        Me.BtnAgregarPaciente.Text = "Gestion de Pacientes"
        Me.BtnAgregarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarPaciente.UseVisualStyleBackColor = True
        '
        'BtnPaciente
        '
        Me.BtnPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPaciente.FlatAppearance.BorderSize = 0
        Me.BtnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPaciente.ForeColor = System.Drawing.Color.White
        Me.BtnPaciente.Location = New System.Drawing.Point(2, 364)
        Me.BtnPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPaciente.Name = "BtnPaciente"
        Me.BtnPaciente.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnPaciente.Size = New System.Drawing.Size(196, 34)
        Me.BtnPaciente.TabIndex = 9
        Me.BtnPaciente.Text = "Pacientes"
        Me.BtnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPaciente.UseVisualStyleBackColor = True
        '
        'PanelSubExamenes
        '
        Me.PanelSubExamenes.AutoSize = True
        Me.PanelSubExamenes.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSubExamenes.Controls.Add(Me.BtnAgregarEstudio)
        Me.PanelSubExamenes.Controls.Add(Me.BtnAgregarExamen)
        Me.PanelSubExamenes.Controls.Add(Me.BtnGestionarUnidad)
        Me.PanelSubExamenes.Controls.Add(Me.BtnCrearCategoria)
        Me.PanelSubExamenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubExamenes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelSubExamenes.Location = New System.Drawing.Point(2, 264)
        Me.PanelSubExamenes.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSubExamenes.Name = "PanelSubExamenes"
        Me.PanelSubExamenes.Size = New System.Drawing.Size(196, 96)
        Me.PanelSubExamenes.TabIndex = 8
        '
        'BtnAgregarEstudio
        '
        Me.BtnAgregarEstudio.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAgregarEstudio.FlatAppearance.BorderSize = 0
        Me.BtnAgregarEstudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarEstudio.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarEstudio.Location = New System.Drawing.Point(0, 72)
        Me.BtnAgregarEstudio.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregarEstudio.Name = "BtnAgregarEstudio"
        Me.BtnAgregarEstudio.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnAgregarEstudio.Size = New System.Drawing.Size(196, 24)
        Me.BtnAgregarEstudio.TabIndex = 2
        Me.BtnAgregarEstudio.Text = "Gestion de Estudios"
        Me.BtnAgregarEstudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarEstudio.UseVisualStyleBackColor = True
        '
        'BtnAgregarExamen
        '
        Me.BtnAgregarExamen.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAgregarExamen.FlatAppearance.BorderSize = 0
        Me.BtnAgregarExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarExamen.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarExamen.Location = New System.Drawing.Point(0, 48)
        Me.BtnAgregarExamen.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregarExamen.Name = "BtnAgregarExamen"
        Me.BtnAgregarExamen.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnAgregarExamen.Size = New System.Drawing.Size(196, 24)
        Me.BtnAgregarExamen.TabIndex = 1
        Me.BtnAgregarExamen.Text = "Gestion de Examenes"
        Me.BtnAgregarExamen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarExamen.UseVisualStyleBackColor = True
        '
        'BtnGestionarUnidad
        '
        Me.BtnGestionarUnidad.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnGestionarUnidad.FlatAppearance.BorderSize = 0
        Me.BtnGestionarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGestionarUnidad.ForeColor = System.Drawing.Color.White
        Me.BtnGestionarUnidad.Location = New System.Drawing.Point(0, 24)
        Me.BtnGestionarUnidad.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGestionarUnidad.Name = "BtnGestionarUnidad"
        Me.BtnGestionarUnidad.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnGestionarUnidad.Size = New System.Drawing.Size(196, 24)
        Me.BtnGestionarUnidad.TabIndex = 15
        Me.BtnGestionarUnidad.Text = "Gestion de Unidad"
        Me.BtnGestionarUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGestionarUnidad.UseVisualStyleBackColor = True
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
        Me.BtnCrearCategoria.Size = New System.Drawing.Size(196, 24)
        Me.BtnCrearCategoria.TabIndex = 0
        Me.BtnCrearCategoria.Text = "Gestion de Categorias"
        Me.BtnCrearCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrearCategoria.UseVisualStyleBackColor = True
        '
        'PanelSubUsuario
        '
        Me.PanelSubUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelSubUsuario.Controls.Add(Me.BtnCrearRol)
        Me.PanelSubUsuario.Controls.Add(Me.BtnCrearUsuario)
        Me.PanelSubUsuario.Location = New System.Drawing.Point(2, 165)
        Me.PanelSubUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSubUsuario.Name = "PanelSubUsuario"
        Me.PanelSubUsuario.Size = New System.Drawing.Size(196, 54)
        Me.PanelSubUsuario.TabIndex = 6
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
        Me.BtnCrearRol.Size = New System.Drawing.Size(196, 24)
        Me.BtnCrearRol.TabIndex = 1
        Me.BtnCrearRol.Text = "Gestion de Roles"
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
        Me.BtnCrearUsuario.Size = New System.Drawing.Size(196, 24)
        Me.BtnCrearUsuario.TabIndex = 0
        Me.BtnCrearUsuario.Text = "Gestion de Usuarios"
        Me.BtnCrearUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrearUsuario.UseVisualStyleBackColor = True
        '
        'BtnUsuario
        '
        Me.BtnUsuario.FlatAppearance.BorderSize = 0
        Me.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuario.ForeColor = System.Drawing.Color.White
        Me.BtnUsuario.Location = New System.Drawing.Point(2, 124)
        Me.BtnUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUsuario.Name = "BtnUsuario"
        Me.BtnUsuario.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnUsuario.Size = New System.Drawing.Size(196, 37)
        Me.BtnUsuario.TabIndex = 5
        Me.BtnUsuario.Text = "Usuarios"
        Me.BtnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUsuario.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.PictureBox2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(194, 116)
        Me.Panel7.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(82, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DB-LAB"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 19)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 82)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'BtnExamenes
        '
        Me.BtnExamenes.AutoSize = True
        Me.BtnExamenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnExamenes.FlatAppearance.BorderSize = 0
        Me.BtnExamenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExamenes.ForeColor = System.Drawing.Color.White
        Me.BtnExamenes.Location = New System.Drawing.Point(2, 223)
        Me.BtnExamenes.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnExamenes.Name = "BtnExamenes"
        Me.BtnExamenes.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnExamenes.Size = New System.Drawing.Size(196, 37)
        Me.BtnExamenes.TabIndex = 7
        Me.BtnExamenes.Text = "Examenes"
        Me.BtnExamenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExamenes.UseVisualStyleBackColor = True
        '
        'PanelFrmHijo
        '
        Me.PanelFrmHijo.BackColor = System.Drawing.SystemColors.Control
        Me.PanelFrmHijo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFrmHijo.Location = New System.Drawing.Point(2, 2)
        Me.PanelFrmHijo.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelFrmHijo.Name = "PanelFrmHijo"
        Me.PanelFrmHijo.Size = New System.Drawing.Size(614, 845)
        Me.PanelFrmHijo.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PanelFrmHijo, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(200, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(618, 847)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 847)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(834, 771)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Laboratory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.PanelSubReportes.ResumeLayout(False)
        Me.PanelSubDoctor.ResumeLayout(False)
        Me.PanelSubResultado.ResumeLayout(False)
        Me.PanelSubOrdenes.ResumeLayout(False)
        Me.PanelSubPaciente.ResumeLayout(False)
        Me.PanelSubExamenes.ResumeLayout(False)
        Me.PanelSubUsuario.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelSubResultado As Panel
    Friend WithEvents BtnActualizacionResultado As Button
    Friend WithEvents BtnListaTrabajo As Button
    Friend WithEvents BtnResultados As Button
    Friend WithEvents PanelSubOrdenes As Panel
    Friend WithEvents BtnCancelarFactura As Button
    Friend WithEvents BtnFacturar As Button
    Friend WithEvents BtnOrdenes As Button
    Friend WithEvents PanelSubPaciente As Panel
    Friend WithEvents BtnAgregarPaciente As Button
    Friend WithEvents BtnPaciente As Button
    Friend WithEvents PanelSubExamenes As Panel
    Friend WithEvents BtnAgregarExamen As Button
    Friend WithEvents BtnCrearCategoria As Button
    Friend WithEvents PanelSubUsuario As Panel
    Friend WithEvents BtnCrearRol As Button
    Friend WithEvents BtnCrearUsuario As Button
    Friend WithEvents BtnUsuario As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnExamenes As Button
    Friend WithEvents PanelFrmHijo As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnGestionarUnidad As Button
    Friend WithEvents BtnAgregarEstudio As Button
    Friend WithEvents BtnDoctor As Button
    Friend WithEvents PanelSubDoctor As Panel
    Friend WithEvents BtnAbrirDr As Button
    Friend WithEvents BtnReportes As Button
    Friend WithEvents PanelSubReportes As Panel
    Friend WithEvents BtnMostrarDoctores As Button
    Friend WithEvents BtnReporteExamenes As Button
End Class
