<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrearRol
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_salir = New System.Windows.Forms.Button()
        Me.Lbl_crearRol = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbl_nombre = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Lbl_descripcion = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Btn_crear = New System.Windows.Forms.Button()
        Me.Btn_limpiar = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Btn_buscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Lbl_crearRol)
        Me.Panel1.Controls.Add(Me.Btn_salir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(868, 64)
        Me.Panel1.TabIndex = 0
        '
        'Btn_salir
        '
        Me.Btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_salir.ForeColor = System.Drawing.Color.White
        Me.Btn_salir.Location = New System.Drawing.Point(766, 12)
        Me.Btn_salir.Name = "Btn_salir"
        Me.Btn_salir.Size = New System.Drawing.Size(90, 40)
        Me.Btn_salir.TabIndex = 4
        Me.Btn_salir.Text = "Salir"
        Me.Btn_salir.UseVisualStyleBackColor = False
        '
        'Lbl_crearRol
        '
        Me.Lbl_crearRol.AutoSize = True
        Me.Lbl_crearRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_crearRol.ForeColor = System.Drawing.Color.White
        Me.Lbl_crearRol.Location = New System.Drawing.Point(12, 17)
        Me.Lbl_crearRol.Name = "Lbl_crearRol"
        Me.Lbl_crearRol.Size = New System.Drawing.Size(103, 25)
        Me.Lbl_crearRol.TabIndex = 5
        Me.Lbl_crearRol.Text = "Crear Rol"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Btn_crear)
        Me.Panel2.Controls.Add(Me.Btn_limpiar)
        Me.Panel2.Controls.Add(Me.Lbl_descripcion)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Lbl_nombre)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(872, 346)
        Me.Panel2.TabIndex = 1
        '
        'Lbl_nombre
        '
        Me.Lbl_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_nombre.AutoSize = True
        Me.Lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nombre.Location = New System.Drawing.Point(40, 41)
        Me.Lbl_nombre.Name = "Lbl_nombre"
        Me.Lbl_nombre.Size = New System.Drawing.Size(78, 22)
        Me.Lbl_nombre.TabIndex = 4
        Me.Lbl_nombre.Text = "Nombre:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(124, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 27)
        Me.TextBox1.TabIndex = 3
        '
        'Lbl_descripcion
        '
        Me.Lbl_descripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_descripcion.AutoSize = True
        Me.Lbl_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_descripcion.Location = New System.Drawing.Point(11, 85)
        Me.Lbl_descripcion.Name = "Lbl_descripcion"
        Me.Lbl_descripcion.Size = New System.Drawing.Size(109, 22)
        Me.Lbl_descripcion.TabIndex = 6
        Me.Lbl_descripcion.Text = "Descripción:"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(124, 84)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(309, 165)
        Me.TextBox2.TabIndex = 5
        '
        'Btn_crear
        '
        Me.Btn_crear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_crear.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Btn_crear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_crear.ForeColor = System.Drawing.Color.White
        Me.Btn_crear.Location = New System.Drawing.Point(456, 281)
        Me.Btn_crear.Name = "Btn_crear"
        Me.Btn_crear.Size = New System.Drawing.Size(141, 43)
        Me.Btn_crear.TabIndex = 22
        Me.Btn_crear.Text = "Crear"
        Me.Btn_crear.UseVisualStyleBackColor = False
        '
        'Btn_limpiar
        '
        Me.Btn_limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Btn_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_limpiar.ForeColor = System.Drawing.Color.White
        Me.Btn_limpiar.Location = New System.Drawing.Point(272, 281)
        Me.Btn_limpiar.Name = "Btn_limpiar"
        Me.Btn_limpiar.Size = New System.Drawing.Size(141, 43)
        Me.Btn_limpiar.TabIndex = 21
        Me.Btn_limpiar.Text = "Limpiar"
        Me.Btn_limpiar.UseVisualStyleBackColor = False
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(113, 466)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(725, 27)
        Me.TextBox9.TabIndex = 6
        '
        'Btn_buscar
        '
        Me.Btn_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_buscar.BackColor = System.Drawing.Color.White
        Me.Btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_buscar.ForeColor = System.Drawing.Color.Black
        Me.Btn_buscar.Location = New System.Drawing.Point(17, 459)
        Me.Btn_buscar.Name = "Btn_buscar"
        Me.Btn_buscar.Size = New System.Drawing.Size(90, 40)
        Me.Btn_buscar.TabIndex = 4
        Me.Btn_buscar.Text = "Buscar"
        Me.Btn_buscar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 516)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(821, 280)
        Me.DataGridView1.TabIndex = 5
        '
        'FrmCrearRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(868, 891)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Btn_buscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCrearRol"
        Me.Text = "FrmCrearRol"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_salir As Button
    Friend WithEvents Lbl_crearRol As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Lbl_nombre As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Lbl_descripcion As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Btn_crear As Button
    Friend WithEvents Btn_limpiar As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Btn_buscar As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
