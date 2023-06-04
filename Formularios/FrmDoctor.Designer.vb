<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDoctor
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.PanelDatosCategoria = New System.Windows.Forms.Panel()
        Me.TxtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.TxtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.TxtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelRegistros = New System.Windows.Forms.Panel()
        Me.BtnBuscarEstudio = New System.Windows.Forms.Button()
        Me.DgvDoctor = New System.Windows.Forms.DataGridView()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.CbxEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.PanelBotones.SuspendLayout()
        Me.PanelDatosCategoria.SuspendLayout()
        Me.PanelRegistros.SuspendLayout()
        CType(Me.DgvDoctor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnSalir)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 64)
        Me.Panel1.TabIndex = 2
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(888, 14)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(91, 39)
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
        Me.Label4.Location = New System.Drawing.Point(13, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gestion de Doctores"
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
        Me.PanelBotones.Size = New System.Drawing.Size(992, 74)
        Me.PanelBotones.TabIndex = 3
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBorrar.Image = Global.DB_Lab.My.Resources.Resources.deleteButton
        Me.BtnBorrar.Location = New System.Drawing.Point(871, 7)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(108, 57)
        Me.BtnBorrar.TabIndex = 8
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.Image = Global.DB_Lab.My.Resources.Resources.editButton
        Me.BtnEditar.Location = New System.Drawing.Point(725, 7)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(108, 57)
        Me.BtnEditar.TabIndex = 7
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.Image = Global.DB_Lab.My.Resources.Resources.saveButton
        Me.BtnGuardar.Location = New System.Drawing.Point(579, 7)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(108, 57)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpiar.Image = Global.DB_Lab.My.Resources.Resources.cleanButton
        Me.BtnLimpiar.Location = New System.Drawing.Point(433, 7)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(108, 57)
        Me.BtnLimpiar.TabIndex = 5
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'PanelDatosCategoria
        '
        Me.PanelDatosCategoria.BackColor = System.Drawing.Color.White
        Me.PanelDatosCategoria.Controls.Add(Me.TxtSegundoNombre)
        Me.PanelDatosCategoria.Controls.Add(Me.TxtPrimerApellido)
        Me.PanelDatosCategoria.Controls.Add(Me.TxtSegundoApellido)
        Me.PanelDatosCategoria.Controls.Add(Me.lbl)
        Me.PanelDatosCategoria.Controls.Add(Me.Label6)
        Me.PanelDatosCategoria.Controls.Add(Me.Label3)
        Me.PanelDatosCategoria.Controls.Add(Me.CbxEspecialidad)
        Me.PanelDatosCategoria.Controls.Add(Me.Label1)
        Me.PanelDatosCategoria.Controls.Add(Me.TxtPrimerNombre)
        Me.PanelDatosCategoria.Controls.Add(Me.Label2)
        Me.PanelDatosCategoria.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDatosCategoria.Location = New System.Drawing.Point(0, 138)
        Me.PanelDatosCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelDatosCategoria.Name = "PanelDatosCategoria"
        Me.PanelDatosCategoria.Size = New System.Drawing.Size(992, 292)
        Me.PanelDatosCategoria.TabIndex = 4
        '
        'TxtSegundoNombre
        '
        Me.TxtSegundoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSegundoNombre.Location = New System.Drawing.Point(654, 27)
        Me.TxtSegundoNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSegundoNombre.Name = "TxtSegundoNombre"
        Me.TxtSegundoNombre.Size = New System.Drawing.Size(315, 27)
        Me.TxtSegundoNombre.TabIndex = 21
        '
        'TxtPrimerApellido
        '
        Me.TxtPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrimerApellido.Location = New System.Drawing.Point(172, 123)
        Me.TxtPrimerApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPrimerApellido.Name = "TxtPrimerApellido"
        Me.TxtPrimerApellido.Size = New System.Drawing.Size(298, 27)
        Me.TxtPrimerApellido.TabIndex = 20
        '
        'TxtSegundoApellido
        '
        Me.TxtSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSegundoApellido.Location = New System.Drawing.Point(654, 127)
        Me.TxtSegundoApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSegundoApellido.Name = "TxtSegundoApellido"
        Me.TxtSegundoApellido.Size = New System.Drawing.Size(313, 27)
        Me.TxtSegundoApellido.TabIndex = 19
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(496, 32)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(152, 22)
        Me.lbl.TabIndex = 18
        Me.lbl.Text = "Segundo nombre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 22)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Primer apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(494, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 22)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Segundo apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 22)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Especialidad:"
        '
        'TxtPrimerNombre
        '
        Me.TxtPrimerNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrimerNombre.Location = New System.Drawing.Point(170, 32)
        Me.TxtPrimerNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPrimerNombre.Name = "TxtPrimerNombre"
        Me.TxtPrimerNombre.Size = New System.Drawing.Size(300, 27)
        Me.TxtPrimerNombre.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Primer nombre:"
        '
        'PanelRegistros
        '
        Me.PanelRegistros.Controls.Add(Me.BtnBuscarEstudio)
        Me.PanelRegistros.Controls.Add(Me.DgvDoctor)
        Me.PanelRegistros.Controls.Add(Me.TxtBuscar)
        Me.PanelRegistros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRegistros.Location = New System.Drawing.Point(0, 430)
        Me.PanelRegistros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelRegistros.Name = "PanelRegistros"
        Me.PanelRegistros.Size = New System.Drawing.Size(992, 481)
        Me.PanelRegistros.TabIndex = 5
        '
        'BtnBuscarEstudio
        '
        Me.BtnBuscarEstudio.Image = Global.DB_Lab.My.Resources.Resources.searchButton
        Me.BtnBuscarEstudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarEstudio.Location = New System.Drawing.Point(579, 19)
        Me.BtnBuscarEstudio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBuscarEstudio.Name = "BtnBuscarEstudio"
        Me.BtnBuscarEstudio.Size = New System.Drawing.Size(108, 57)
        Me.BtnBuscarEstudio.TabIndex = 14
        Me.BtnBuscarEstudio.Text = "Buscar"
        Me.BtnBuscarEstudio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarEstudio.UseVisualStyleBackColor = True
        '
        'DgvDoctor
        '
        Me.DgvDoctor.AllowUserToAddRows = False
        Me.DgvDoctor.AllowUserToDeleteRows = False
        Me.DgvDoctor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDoctor.Location = New System.Drawing.Point(12, 96)
        Me.DgvDoctor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvDoctor.MultiSelect = False
        Me.DgvDoctor.Name = "DgvDoctor"
        Me.DgvDoctor.RowHeadersWidth = 51
        Me.DgvDoctor.RowTemplate.Height = 24
        Me.DgvDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDoctor.Size = New System.Drawing.Size(968, 263)
        Me.DgvDoctor.TabIndex = 13
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(18, 33)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(540, 27)
        Me.TxtBuscar.TabIndex = 9
        '
        'CbxEspecialidad
        '
        Me.CbxEspecialidad.FormattingEnabled = True
        Me.CbxEspecialidad.Items.AddRange(New Object() {"Cardiología", "Dermatología", "Endocrinología", "Gastroenterología", "Ginecología", "Hematología", "Medicina familiar", "Medicina interna", "Nefrología", "Neurología", "Oncología", "Oftalmología", "Ortopedia", "Otorrinolaringología", "Psiquiatría"})
        Me.CbxEspecialidad.Location = New System.Drawing.Point(170, 216)
        Me.CbxEspecialidad.Margin = New System.Windows.Forms.Padding(4)
        Me.CbxEspecialidad.Name = "CbxEspecialidad"
        Me.CbxEspecialidad.Size = New System.Drawing.Size(396, 24)
        Me.CbxEspecialidad.TabIndex = 14
        '
        'FrmDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 821)
        Me.Controls.Add(Me.PanelRegistros)
        Me.Controls.Add(Me.PanelDatosCategoria)
        Me.Controls.Add(Me.PanelBotones)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmDoctor"
        Me.Text = "FrmDoctor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelBotones.ResumeLayout(False)
        Me.PanelDatosCategoria.ResumeLayout(False)
        Me.PanelDatosCategoria.PerformLayout()
        Me.PanelRegistros.ResumeLayout(False)
        Me.PanelRegistros.PerformLayout()
        CType(Me.DgvDoctor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents PanelDatosCategoria As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPrimerNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelRegistros As Panel
    Friend WithEvents BtnBuscarEstudio As Button
    Friend WithEvents DgvDoctor As DataGridView
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents lbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSegundoNombre As TextBox
    Friend WithEvents TxtPrimerApellido As TextBox
    Friend WithEvents TxtSegundoApellido As TextBox
    Friend WithEvents CbxEspecialidad As ComboBox
End Class
