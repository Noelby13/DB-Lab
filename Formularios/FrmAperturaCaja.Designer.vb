<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAperturaCaja
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
        Me.Lbl_Fecha = New System.Windows.Forms.Label()
        Me.Lbl_Hora = New System.Windows.Forms.Label()
        Me.Lbl_Usuario = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.Lbl_MontoInicial = New System.Windows.Forms.Label()
        Me.TxtMontoInicial = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.PanelLeyenda.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLeyenda
        '
        Me.PanelLeyenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PanelLeyenda.Controls.Add(Me.Label4)
        Me.PanelLeyenda.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLeyenda.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeyenda.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelLeyenda.Name = "PanelLeyenda"
        Me.PanelLeyenda.Size = New System.Drawing.Size(362, 52)
        Me.PanelLeyenda.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(85, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Comenzar nuevo turno"
        '
        'Lbl_Fecha
        '
        Me.Lbl_Fecha.AutoSize = True
        Me.Lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Fecha.Location = New System.Drawing.Point(79, 96)
        Me.Lbl_Fecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Fecha.Name = "Lbl_Fecha"
        Me.Lbl_Fecha.Size = New System.Drawing.Size(53, 18)
        Me.Lbl_Fecha.TabIndex = 1
        Me.Lbl_Fecha.Text = "Fecha:"
        '
        'Lbl_Hora
        '
        Me.Lbl_Hora.AutoSize = True
        Me.Lbl_Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Hora.Location = New System.Drawing.Point(34, 138)
        Me.Lbl_Hora.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Hora.Name = "Lbl_Hora"
        Me.Lbl_Hora.Size = New System.Drawing.Size(104, 18)
        Me.Lbl_Hora.TabIndex = 2
        Me.Lbl_Hora.Text = "Hora Apertura:"
        '
        'Lbl_Usuario
        '
        Me.Lbl_Usuario.AutoSize = True
        Me.Lbl_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Usuario.Location = New System.Drawing.Point(74, 186)
        Me.Lbl_Usuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Usuario.Name = "Lbl_Usuario"
        Me.Lbl_Usuario.Size = New System.Drawing.Size(64, 18)
        Me.Lbl_Usuario.TabIndex = 3
        Me.Lbl_Usuario.Text = "Usuario:"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(155, 96)
        Me.LblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(53, 18)
        Me.LblFecha.TabIndex = 4
        Me.LblFecha.Text = "Fecha:"
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.Location = New System.Drawing.Point(155, 138)
        Me.LblHora.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(45, 18)
        Me.LblHora.TabIndex = 5
        Me.LblHora.Text = "Hora:"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(155, 186)
        Me.LblUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(139, 18)
        Me.LblUsuario.TabIndex = 6
        Me.LblUsuario.Text = "Nombre de usuario:"
        '
        'Lbl_MontoInicial
        '
        Me.Lbl_MontoInicial.AutoSize = True
        Me.Lbl_MontoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_MontoInicial.Location = New System.Drawing.Point(20, 239)
        Me.Lbl_MontoInicial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_MontoInicial.Name = "Lbl_MontoInicial"
        Me.Lbl_MontoInicial.Size = New System.Drawing.Size(118, 18)
        Me.Lbl_MontoInicial.TabIndex = 7
        Me.Lbl_MontoInicial.Text = "Monto Inicial C$:"
        '
        'TxtMontoInicial
        '
        Me.TxtMontoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMontoInicial.Location = New System.Drawing.Point(158, 236)
        Me.TxtMontoInicial.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMontoInicial.Name = "TxtMontoInicial"
        Me.TxtMontoInicial.Size = New System.Drawing.Size(136, 23)
        Me.TxtMontoInicial.TabIndex = 8
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.Image = Global.DB_Lab.My.Resources.Resources.cancelarButton24
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(194, 308)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(81, 31)
        Me.BtnCancelar.TabIndex = 10
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAceptar.Image = Global.DB_Lab.My.Resources.Resources.okButton24
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(77, 308)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(81, 31)
        Me.BtnAceptar.TabIndex = 9
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'FrmAperturaCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 401)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtMontoInicial)
        Me.Controls.Add(Me.Lbl_MontoInicial)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.LblHora)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.Lbl_Usuario)
        Me.Controls.Add(Me.Lbl_Hora)
        Me.Controls.Add(Me.Lbl_Fecha)
        Me.Controls.Add(Me.PanelLeyenda)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAperturaCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAperturaCaja"
        Me.PanelLeyenda.ResumeLayout(False)
        Me.PanelLeyenda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelLeyenda As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbl_Fecha As Label
    Friend WithEvents Lbl_Hora As Label
    Friend WithEvents Lbl_Usuario As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents LblHora As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents Lbl_MontoInicial As Label
    Friend WithEvents TxtMontoInicial As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
End Class
