<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgregarEstudio
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
        Me.PanelLeyenda = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelFunciones = New System.Windows.Forms.Panel()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnGuardarIcon = New System.Windows.Forms.Button()
        Me.PanelDatos = New System.Windows.Forms.Panel()
        Me.GrbDatosEstudios = New System.Windows.Forms.GroupBox()
        Me.CbxUnidad1 = New System.Windows.Forms.ComboBox()
        Me.TxtValorTextoM = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CbxUnidad2 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtValorSuperiorM = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtValorInferiorM = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtValorTextoH = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtValorSuperiorH = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtValorInferiorH = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DgvEstudio = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarEstudio = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.PanelLeyenda.SuspendLayout()
        Me.PanelFunciones.SuspendLayout()
        Me.PanelDatos.SuspendLayout()
        Me.GrbDatosEstudios.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvEstudio, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelLeyenda.Size = New System.Drawing.Size(930, 51)
        Me.PanelLeyenda.TabIndex = 1
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(850, 7)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(68, 32)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro Estudios "
        '
        'PanelFunciones
        '
        Me.PanelFunciones.Controls.Add(Me.BtnBorrar)
        Me.PanelFunciones.Controls.Add(Me.BtnEditar)
        Me.PanelFunciones.Controls.Add(Me.BtnLimpiar)
        Me.PanelFunciones.Controls.Add(Me.BtnGuardarIcon)
        Me.PanelFunciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFunciones.Location = New System.Drawing.Point(0, 51)
        Me.PanelFunciones.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelFunciones.Name = "PanelFunciones"
        Me.PanelFunciones.Size = New System.Drawing.Size(930, 60)
        Me.PanelFunciones.TabIndex = 2
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBorrar.Enabled = False
        Me.BtnBorrar.Image = Global.DB_Lab.My.Resources.Resources.deleteButton
        Me.BtnBorrar.Location = New System.Drawing.Point(837, 9)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(81, 46)
        Me.BtnBorrar.TabIndex = 4
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.Enabled = False
        Me.BtnEditar.Image = Global.DB_Lab.My.Resources.Resources.editButton
        Me.BtnEditar.Location = New System.Drawing.Point(728, 9)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(81, 46)
        Me.BtnEditar.TabIndex = 3
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpiar.Image = Global.DB_Lab.My.Resources.Resources.cleanButton
        Me.BtnLimpiar.Location = New System.Drawing.Point(510, 9)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(81, 46)
        Me.BtnLimpiar.TabIndex = 1
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnGuardarIcon
        '
        Me.BtnGuardarIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardarIcon.Image = Global.DB_Lab.My.Resources.Resources.saveButton
        Me.BtnGuardarIcon.Location = New System.Drawing.Point(619, 9)
        Me.BtnGuardarIcon.Name = "BtnGuardarIcon"
        Me.BtnGuardarIcon.Size = New System.Drawing.Size(81, 46)
        Me.BtnGuardarIcon.TabIndex = 2
        Me.BtnGuardarIcon.UseVisualStyleBackColor = True
        '
        'PanelDatos
        '
        Me.PanelDatos.Controls.Add(Me.GrbDatosEstudios)
        Me.PanelDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDatos.Location = New System.Drawing.Point(0, 111)
        Me.PanelDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Size = New System.Drawing.Size(930, 307)
        Me.PanelDatos.TabIndex = 3
        '
        'GrbDatosEstudios
        '
        Me.GrbDatosEstudios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrbDatosEstudios.Controls.Add(Me.CbxUnidad1)
        Me.GrbDatosEstudios.Controls.Add(Me.TxtValorTextoM)
        Me.GrbDatosEstudios.Controls.Add(Me.Label12)
        Me.GrbDatosEstudios.Controls.Add(Me.CbxUnidad2)
        Me.GrbDatosEstudios.Controls.Add(Me.Label11)
        Me.GrbDatosEstudios.Controls.Add(Me.TxtValorSuperiorM)
        Me.GrbDatosEstudios.Controls.Add(Me.Label10)
        Me.GrbDatosEstudios.Controls.Add(Me.TxtValorInferiorM)
        Me.GrbDatosEstudios.Controls.Add(Me.Label9)
        Me.GrbDatosEstudios.Controls.Add(Me.Label8)
        Me.GrbDatosEstudios.Controls.Add(Me.TxtValorTextoH)
        Me.GrbDatosEstudios.Controls.Add(Me.Label7)
        Me.GrbDatosEstudios.Controls.Add(Me.Label6)
        Me.GrbDatosEstudios.Controls.Add(Me.TxtValorSuperiorH)
        Me.GrbDatosEstudios.Controls.Add(Me.Label5)
        Me.GrbDatosEstudios.Controls.Add(Me.TxtValorInferiorH)
        Me.GrbDatosEstudios.Controls.Add(Me.Label4)
        Me.GrbDatosEstudios.Controls.Add(Me.Label2)
        Me.GrbDatosEstudios.Controls.Add(Me.TxtNombre)
        Me.GrbDatosEstudios.Controls.Add(Me.Label3)
        Me.GrbDatosEstudios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbDatosEstudios.Location = New System.Drawing.Point(14, 17)
        Me.GrbDatosEstudios.Margin = New System.Windows.Forms.Padding(2)
        Me.GrbDatosEstudios.Name = "GrbDatosEstudios"
        Me.GrbDatosEstudios.Padding = New System.Windows.Forms.Padding(2)
        Me.GrbDatosEstudios.Size = New System.Drawing.Size(891, 273)
        Me.GrbDatosEstudios.TabIndex = 0
        Me.GrbDatosEstudios.TabStop = False
        Me.GrbDatosEstudios.Text = "Datos del estudio"
        '
        'CbxUnidad1
        '
        Me.CbxUnidad1.FormattingEnabled = True
        Me.CbxUnidad1.Location = New System.Drawing.Point(452, 95)
        Me.CbxUnidad1.Margin = New System.Windows.Forms.Padding(2)
        Me.CbxUnidad1.Name = "CbxUnidad1"
        Me.CbxUnidad1.Size = New System.Drawing.Size(156, 25)
        Me.CbxUnidad1.TabIndex = 21
        '
        'TxtValorTextoM
        '
        Me.TxtValorTextoM.Location = New System.Drawing.Point(99, 241)
        Me.TxtValorTextoM.Name = "TxtValorTextoM"
        Me.TxtValorTextoM.Size = New System.Drawing.Size(65, 24)
        Me.TxtValorTextoM.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 246)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 18)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Valor texto:"
        '
        'CbxUnidad2
        '
        Me.CbxUnidad2.FormattingEnabled = True
        Me.CbxUnidad2.Location = New System.Drawing.Point(452, 203)
        Me.CbxUnidad2.Margin = New System.Windows.Forms.Padding(2)
        Me.CbxUnidad2.Name = "CbxUnidad2"
        Me.CbxUnidad2.Size = New System.Drawing.Size(156, 25)
        Me.CbxUnidad2.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(392, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 18)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Unidad:"
        '
        'TxtValorSuperiorM
        '
        Me.TxtValorSuperiorM.Location = New System.Drawing.Point(307, 203)
        Me.TxtValorSuperiorM.Name = "TxtValorSuperiorM"
        Me.TxtValorSuperiorM.Size = New System.Drawing.Size(65, 24)
        Me.TxtValorSuperiorM.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(203, 206)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 18)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Valor superior:"
        '
        'TxtValorInferiorM
        '
        Me.TxtValorInferiorM.Location = New System.Drawing.Point(99, 202)
        Me.TxtValorInferiorM.Name = "TxtValorInferiorM"
        Me.TxtValorInferiorM.Size = New System.Drawing.Size(65, 24)
        Me.TxtValorInferiorM.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 18)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Valor inferior:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(214, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Valores normales para mujeres"
        '
        'TxtValorTextoH
        '
        Me.TxtValorTextoH.Location = New System.Drawing.Point(99, 136)
        Me.TxtValorTextoH.Name = "TxtValorTextoH"
        Me.TxtValorTextoH.Size = New System.Drawing.Size(65, 24)
        Me.TxtValorTextoH.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Valor texto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(392, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Unidad:"
        '
        'TxtValorSuperiorH
        '
        Me.TxtValorSuperiorH.Location = New System.Drawing.Point(307, 95)
        Me.TxtValorSuperiorH.Name = "TxtValorSuperiorH"
        Me.TxtValorSuperiorH.Size = New System.Drawing.Size(65, 24)
        Me.TxtValorSuperiorH.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Valor superior:"
        '
        'TxtValorInferiorH
        '
        Me.TxtValorInferiorH.Location = New System.Drawing.Point(99, 98)
        Me.TxtValorInferiorH.Name = "TxtValorInferiorH"
        Me.TxtValorInferiorH.Size = New System.Drawing.Size(65, 24)
        Me.TxtValorInferiorH.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Valor inferior:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valores normales para hombres"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(70, 28)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(215, 24)
        Me.TxtNombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.DgvEstudio)
        Me.Panel1.Controls.Add(Me.BtnBuscarEstudio)
        Me.Panel1.Controls.Add(Me.TxtBuscar)
        Me.Panel1.Location = New System.Drawing.Point(0, 418)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(930, 303)
        Me.Panel1.TabIndex = 4
        '
        'DgvEstudio
        '
        Me.DgvEstudio.AllowUserToAddRows = False
        Me.DgvEstudio.AllowUserToDeleteRows = False
        Me.DgvEstudio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvEstudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEstudio.Location = New System.Drawing.Point(14, 71)
        Me.DgvEstudio.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvEstudio.MultiSelect = False
        Me.DgvEstudio.Name = "DgvEstudio"
        Me.DgvEstudio.ReadOnly = True
        Me.DgvEstudio.RowHeadersWidth = 51
        Me.DgvEstudio.RowTemplate.Height = 24
        Me.DgvEstudio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEstudio.Size = New System.Drawing.Size(891, 218)
        Me.DgvEstudio.TabIndex = 5
        '
        'BtnBuscarEstudio
        '
        Me.BtnBuscarEstudio.Image = Global.DB_Lab.My.Resources.Resources.searchButton
        Me.BtnBuscarEstudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarEstudio.Location = New System.Drawing.Point(305, 11)
        Me.BtnBuscarEstudio.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscarEstudio.Name = "BtnBuscarEstudio"
        Me.BtnBuscarEstudio.Size = New System.Drawing.Size(81, 46)
        Me.BtnBuscarEstudio.TabIndex = 4
        Me.BtnBuscarEstudio.Text = "Buscar"
        Me.BtnBuscarEstudio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarEstudio.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(22, 23)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(277, 22)
        Me.TxtBuscar.TabIndex = 3
        '
        'FrmAgregarEstudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 724)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelDatos)
        Me.Controls.Add(Me.PanelFunciones)
        Me.Controls.Add(Me.PanelLeyenda)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmAgregarEstudio"
        Me.Text = "FrmAgregarEstudio"
        Me.PanelLeyenda.ResumeLayout(False)
        Me.PanelLeyenda.PerformLayout()
        Me.PanelFunciones.ResumeLayout(False)
        Me.PanelDatos.ResumeLayout(False)
        Me.GrbDatosEstudios.ResumeLayout(False)
        Me.GrbDatosEstudios.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvEstudio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLeyenda As Panel
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelFunciones As Panel
    Friend WithEvents PanelDatos As Panel
    Friend WithEvents GrbDatosEstudios As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtValorTextoM As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CbxUnidad2 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtValorSuperiorM As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtValorInferiorM As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtValorTextoH As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtValorSuperiorH As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtValorInferiorH As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnGuardarIcon As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnBuscarEstudio As Button
    Friend WithEvents DgvEstudio As DataGridView
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents CbxUnidad1 As ComboBox
End Class
