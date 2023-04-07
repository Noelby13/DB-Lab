<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxbUsuario = New System.Windows.Forms.TextBox()
        Me.TxbContraseña = New System.Windows.Forms.TextBox()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Display", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label1.Location = New System.Drawing.Point(117, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DB-LAB"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label2.Location = New System.Drawing.Point(105, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(195, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Database Laboratory"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(51, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(51, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contraseña"
        '
        'TxbUsuario
        '
        Me.TxbUsuario.Location = New System.Drawing.Point(57, 227)
        Me.TxbUsuario.Multiline = True
        Me.TxbUsuario.Name = "TxbUsuario"
        Me.TxbUsuario.Size = New System.Drawing.Size(303, 28)
        Me.TxbUsuario.TabIndex = 4
        '
        'TxbContraseña
        '
        Me.TxbContraseña.Location = New System.Drawing.Point(57, 318)
        Me.TxbContraseña.Multiline = True
        Me.TxbContraseña.Name = "TxbContraseña"
        Me.TxbContraseña.Size = New System.Drawing.Size(303, 29)
        Me.TxbContraseña.TabIndex = 5
        Me.TxbContraseña.UseSystemPasswordChar = True
        '
        'BtnEntrar
        '
        Me.BtnEntrar.BackColor = System.Drawing.Color.DarkMagenta
        Me.BtnEntrar.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEntrar.Location = New System.Drawing.Point(57, 390)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(303, 43)
        Me.BtnEntrar.TabIndex = 6
        Me.BtnEntrar.Text = "Entrar"
        Me.BtnEntrar.UseVisualStyleBackColor = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(406, 579)
        Me.Controls.Add(Me.BtnEntrar)
        Me.Controls.Add(Me.TxbContraseña)
        Me.Controls.Add(Me.TxbUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbUsuario As TextBox
    Friend WithEvents TxbContraseña As TextBox
    Friend WithEvents BtnEntrar As Button
End Class
