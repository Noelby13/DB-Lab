<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCerrarTurno
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_MontoInicial = New System.Windows.Forms.Label()
        Me.Lbl_Usuario = New System.Windows.Forms.Label()
        Me.Lbl_Fecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.TxtMontoInicial = New System.Windows.Forms.TextBox()
        Me.TxtMontoFinal = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDiferencia = New System.Windows.Forms.TextBox()
        Me.PanelLeyenda.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLeyenda
        '
        Me.PanelLeyenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelLeyenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PanelLeyenda.Controls.Add(Me.Label4)
        Me.PanelLeyenda.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeyenda.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelLeyenda.Name = "PanelLeyenda"
        Me.PanelLeyenda.Size = New System.Drawing.Size(362, 52)
        Me.PanelLeyenda.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(127, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Cerrar Turno"
        '
        'Lbl_MontoInicial
        '
        Me.Lbl_MontoInicial.AutoSize = True
        Me.Lbl_MontoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_MontoInicial.Location = New System.Drawing.Point(25, 163)
        Me.Lbl_MontoInicial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_MontoInicial.Name = "Lbl_MontoInicial"
        Me.Lbl_MontoInicial.Size = New System.Drawing.Size(118, 18)
        Me.Lbl_MontoInicial.TabIndex = 11
        Me.Lbl_MontoInicial.Text = "Monto Inicial C$:"
        '
        'Lbl_Usuario
        '
        Me.Lbl_Usuario.AutoSize = True
        Me.Lbl_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Usuario.Location = New System.Drawing.Point(74, 122)
        Me.Lbl_Usuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Usuario.Name = "Lbl_Usuario"
        Me.Lbl_Usuario.Size = New System.Drawing.Size(64, 18)
        Me.Lbl_Usuario.TabIndex = 10
        Me.Lbl_Usuario.Text = "Usuario:"
        '
        'Lbl_Fecha
        '
        Me.Lbl_Fecha.AutoSize = True
        Me.Lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Fecha.Location = New System.Drawing.Point(90, 82)
        Me.Lbl_Fecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Fecha.Name = "Lbl_Fecha"
        Me.Lbl_Fecha.Size = New System.Drawing.Size(53, 18)
        Me.Lbl_Fecha.TabIndex = 8
        Me.Lbl_Fecha.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 206)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Monto Final C$:"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(172, 82)
        Me.LblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(53, 18)
        Me.LblFecha.TabIndex = 13
        Me.LblFecha.Text = "Fecha:"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(172, 122)
        Me.LblUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(53, 18)
        Me.LblUsuario.TabIndex = 14
        Me.LblUsuario.Text = "Fecha:"
        '
        'TxtMontoInicial
        '
        Me.TxtMontoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMontoInicial.Location = New System.Drawing.Point(175, 160)
        Me.TxtMontoInicial.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMontoInicial.Name = "TxtMontoInicial"
        Me.TxtMontoInicial.ReadOnly = True
        Me.TxtMontoInicial.Size = New System.Drawing.Size(136, 23)
        Me.TxtMontoInicial.TabIndex = 15
        '
        'TxtMontoFinal
        '
        Me.TxtMontoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMontoFinal.Location = New System.Drawing.Point(175, 206)
        Me.TxtMontoFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMontoFinal.Name = "TxtMontoFinal"
        Me.TxtMontoFinal.Size = New System.Drawing.Size(136, 23)
        Me.TxtMontoFinal.TabIndex = 16
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Image = Global.DB_Lab.My.Resources.Resources.okButton24
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(62, 289)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(81, 31)
        Me.BtnAceptar.TabIndex = 17
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.DB_Lab.My.Resources.Resources.cancelarButton24
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(197, 289)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(81, 31)
        Me.BtnCancelar.TabIndex = 18
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 249)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 18)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Diferencia C$:"
        '
        'TxtDiferencia
        '
        Me.TxtDiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiferencia.Location = New System.Drawing.Point(175, 246)
        Me.TxtDiferencia.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDiferencia.Name = "TxtDiferencia"
        Me.TxtDiferencia.ReadOnly = True
        Me.TxtDiferencia.Size = New System.Drawing.Size(136, 23)
        Me.TxtDiferencia.TabIndex = 20
        '
        'FrmCerrarTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 401)
        Me.Controls.Add(Me.TxtDiferencia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtMontoFinal)
        Me.Controls.Add(Me.TxtMontoInicial)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_MontoInicial)
        Me.Controls.Add(Me.Lbl_Usuario)
        Me.Controls.Add(Me.Lbl_Fecha)
        Me.Controls.Add(Me.PanelLeyenda)
        Me.Name = "FrmCerrarTurno"
        Me.Text = "FrmCerrarTurno"
        Me.PanelLeyenda.ResumeLayout(False)
        Me.PanelLeyenda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelLeyenda As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbl_MontoInicial As Label
    Friend WithEvents Lbl_Usuario As Label
    Friend WithEvents Lbl_Fecha As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents TxtMontoInicial As TextBox
    Friend WithEvents TxtMontoFinal As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDiferencia As TextBox
End Class
