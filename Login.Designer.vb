<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.TB_Usuari = New System.Windows.Forms.TextBox()
        Me.TB_Password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PB_Mostrapassword = New System.Windows.Forms.PictureBox()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.CB_GuardarCredencials = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PB_Mostrapassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(30, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuari"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(30, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'TB_Usuari
        '
        Me.TB_Usuari.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Usuari.Location = New System.Drawing.Point(130, 109)
        Me.TB_Usuari.Name = "TB_Usuari"
        Me.TB_Usuari.PlaceholderText = "Usuari"
        Me.TB_Usuari.Size = New System.Drawing.Size(152, 30)
        Me.TB_Usuari.TabIndex = 2
        '
        'TB_Password
        '
        Me.TB_Password.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Password.Location = New System.Drawing.Point(130, 155)
        Me.TB_Password.Name = "TB_Password"
        Me.TB_Password.PlaceholderText = "Password"
        Me.TB_Password.Size = New System.Drawing.Size(152, 30)
        Me.TB_Password.TabIndex = 3
        Me.TB_Password.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(89, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Accés d'usuari"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(30, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 56)
        Me.Panel1.TabIndex = 5
        '
        'PB_Mostrapassword
        '
        Me.PB_Mostrapassword.Image = Global.Control_Hores.My.Resources.Resources.ojocerrado
        Me.PB_Mostrapassword.Location = New System.Drawing.Point(293, 155)
        Me.PB_Mostrapassword.Name = "PB_Mostrapassword"
        Me.PB_Mostrapassword.Size = New System.Drawing.Size(31, 30)
        Me.PB_Mostrapassword.TabIndex = 6
        Me.PB_Mostrapassword.TabStop = False
        '
        'Btn_Login
        '
        Me.Btn_Login.Location = New System.Drawing.Point(179, 209)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(145, 44)
        Me.Btn_Login.TabIndex = 7
        Me.Btn_Login.Text = "Login"
        Me.Btn_Login.UseVisualStyleBackColor = True
        '
        'CB_GuardarCredencials
        '
        Me.CB_GuardarCredencials.AutoSize = True
        Me.CB_GuardarCredencials.Location = New System.Drawing.Point(30, 234)
        Me.CB_GuardarCredencials.Name = "CB_GuardarCredencials"
        Me.CB_GuardarCredencials.Size = New System.Drawing.Size(130, 19)
        Me.CB_GuardarCredencials.TabIndex = 8
        Me.CB_GuardarCredencials.Text = "Guardar credencials"
        Me.CB_GuardarCredencials.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 287)
        Me.Controls.Add(Me.CB_GuardarCredencials)
        Me.Controls.Add(Me.Btn_Login)
        Me.Controls.Add(Me.PB_Mostrapassword)
        Me.Controls.Add(Me.TB_Password)
        Me.Controls.Add(Me.TB_Usuari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accés d'usuari"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PB_Mostrapassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_Usuari As TextBox
    Friend WithEvents TB_Password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PB_Mostrapassword As PictureBox
    Friend WithEvents Btn_Login As Button
    Friend WithEvents CB_GuardarCredencials As CheckBox
End Class
