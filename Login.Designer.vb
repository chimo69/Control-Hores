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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_tancar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_GuardarCredencials = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.TB_Usuari = New System.Windows.Forms.TextBox()
        Me.PB_Mostrapassword = New System.Windows.Forms.PictureBox()
        Me.TB_Password = New System.Windows.Forms.TextBox()
        Me.Panel_Login = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PB_Mostrapassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Login.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(244, 324)
        Me.Panel2.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Control_Hores.My.Resources.Resources.LOGO_EMPRESA_SENSE_FONS_01
        Me.PictureBox1.Location = New System.Drawing.Point(21, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.CB_GuardarCredencials)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Btn_Login)
        Me.Panel3.Controls.Add(Me.TB_Usuari)
        Me.Panel3.Controls.Add(Me.PB_Mostrapassword)
        Me.Panel3.Controls.Add(Me.TB_Password)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(244, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(346, 324)
        Me.Panel3.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Btn_tancar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 56)
        Me.Panel1.TabIndex = 5
        '
        'Btn_tancar
        '
        Me.Btn_tancar.FlatAppearance.BorderSize = 0
        Me.Btn_tancar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_tancar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Btn_tancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_tancar.Image = Global.Control_Hores.My.Resources.Resources.icono_eliminar
        Me.Btn_tancar.Location = New System.Drawing.Point(302, 13)
        Me.Btn_tancar.Name = "Btn_tancar"
        Me.Btn_tancar.Size = New System.Drawing.Size(32, 32)
        Me.Btn_tancar.TabIndex = 7
        Me.Btn_tancar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(107, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Accés d'usuari"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(28, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuari"
        '
        'CB_GuardarCredencials
        '
        Me.CB_GuardarCredencials.AutoSize = True
        Me.CB_GuardarCredencials.Location = New System.Drawing.Point(28, 256)
        Me.CB_GuardarCredencials.Name = "CB_GuardarCredencials"
        Me.CB_GuardarCredencials.Size = New System.Drawing.Size(130, 19)
        Me.CB_GuardarCredencials.TabIndex = 4
        Me.CB_GuardarCredencials.Text = "Guardar credencials"
        Me.CB_GuardarCredencials.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(28, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Btn_Login
        '
        Me.Btn_Login.Location = New System.Drawing.Point(177, 231)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(145, 44)
        Me.Btn_Login.TabIndex = 3
        Me.Btn_Login.Text = "Login"
        Me.Btn_Login.UseVisualStyleBackColor = True
        '
        'TB_Usuari
        '
        Me.TB_Usuari.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Usuari.Location = New System.Drawing.Point(128, 104)
        Me.TB_Usuari.Name = "TB_Usuari"
        Me.TB_Usuari.PlaceholderText = "Usuari"
        Me.TB_Usuari.Size = New System.Drawing.Size(152, 30)
        Me.TB_Usuari.TabIndex = 1
        '
        'PB_Mostrapassword
        '
        Me.PB_Mostrapassword.Image = Global.Control_Hores.My.Resources.Resources.ojocerrado
        Me.PB_Mostrapassword.Location = New System.Drawing.Point(291, 160)
        Me.PB_Mostrapassword.Name = "PB_Mostrapassword"
        Me.PB_Mostrapassword.Size = New System.Drawing.Size(31, 30)
        Me.PB_Mostrapassword.TabIndex = 6
        Me.PB_Mostrapassword.TabStop = False
        '
        'TB_Password
        '
        Me.TB_Password.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Password.Location = New System.Drawing.Point(128, 160)
        Me.TB_Password.Name = "TB_Password"
        Me.TB_Password.PlaceholderText = "Password"
        Me.TB_Password.Size = New System.Drawing.Size(152, 30)
        Me.TB_Password.TabIndex = 2
        Me.TB_Password.UseSystemPasswordChar = True
        '
        'Panel_Login
        '
        Me.Panel_Login.Controls.Add(Me.Panel3)
        Me.Panel_Login.Controls.Add(Me.Panel2)
        Me.Panel_Login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Login.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Login.Name = "Panel_Login"
        Me.Panel_Login.Size = New System.Drawing.Size(590, 324)
        Me.Panel_Login.TabIndex = 9
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 324)
        Me.Controls.Add(Me.Panel_Login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accés d'usuari"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PB_Mostrapassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Login.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_GuardarCredencials As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Login As Button
    Friend WithEvents TB_Usuari As TextBox
    Friend WithEvents PB_Mostrapassword As PictureBox
    Friend WithEvents TB_Password As TextBox
    Friend WithEvents Panel_Login As Panel
    Friend WithEvents Btn_tancar As Button
End Class
