<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EdicioUsuari
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EdicioUsuari))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_usuari = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_passwordActual = New System.Windows.Forms.TextBox()
        Me.TB_RePassword = New System.Windows.Forms.TextBox()
        Me.TB_PasswordNou = New System.Windows.Forms.TextBox()
        Me.Btn_actualitzar = New System.Windows.Forms.Button()
        Me.PB_Mostrapassword1 = New System.Windows.Forms.PictureBox()
        Me.PB_MostraPassword2 = New System.Windows.Forms.PictureBox()
        Me.PB_MostraPassword3 = New System.Windows.Forms.PictureBox()
        Me.Btn_restaurarContrasenyes = New System.Windows.Forms.Button()
        Me.PanelDreta = New System.Windows.Forms.Panel()
        Me.TB_NouPassword = New System.Windows.Forms.TextBox()
        Me.DataUsuaris = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PB_Admin = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Mostrapassword1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_MostraPassword2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_MostraPassword3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDreta.SuspendLayout()
        CType(Me.DataUsuaris, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PB_Admin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Control_Hores.My.Resources.Resources.usuario
        Me.PictureBox1.Location = New System.Drawing.Point(8, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Lbl_usuari
        '
        Me.Lbl_usuari.AutoSize = True
        Me.Lbl_usuari.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_usuari.Location = New System.Drawing.Point(54, 12)
        Me.Lbl_usuari.Name = "Lbl_usuari"
        Me.Lbl_usuari.Size = New System.Drawing.Size(57, 23)
        Me.Lbl_usuari.TabIndex = 1
        Me.Lbl_usuari.Text = "Usuari"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(29, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Introdueix contrasenya actual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(29, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Repeteix la contrasenya"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(29, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Introdueix nova contrasenya"
        '
        'TB_passwordActual
        '
        Me.TB_passwordActual.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_passwordActual.Location = New System.Drawing.Point(246, 85)
        Me.TB_passwordActual.Name = "TB_passwordActual"
        Me.TB_passwordActual.Size = New System.Drawing.Size(221, 27)
        Me.TB_passwordActual.TabIndex = 1
        Me.TB_passwordActual.UseSystemPasswordChar = True
        '
        'TB_RePassword
        '
        Me.TB_RePassword.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_RePassword.Location = New System.Drawing.Point(246, 193)
        Me.TB_RePassword.Name = "TB_RePassword"
        Me.TB_RePassword.Size = New System.Drawing.Size(221, 27)
        Me.TB_RePassword.TabIndex = 3
        Me.TB_RePassword.UseSystemPasswordChar = True
        '
        'TB_PasswordNou
        '
        Me.TB_PasswordNou.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_PasswordNou.Location = New System.Drawing.Point(246, 139)
        Me.TB_PasswordNou.Name = "TB_PasswordNou"
        Me.TB_PasswordNou.Size = New System.Drawing.Size(221, 27)
        Me.TB_PasswordNou.TabIndex = 2
        Me.TB_PasswordNou.UseSystemPasswordChar = True
        '
        'Btn_actualitzar
        '
        Me.Btn_actualitzar.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_actualitzar.Location = New System.Drawing.Point(363, 267)
        Me.Btn_actualitzar.Name = "Btn_actualitzar"
        Me.Btn_actualitzar.Size = New System.Drawing.Size(141, 42)
        Me.Btn_actualitzar.TabIndex = 8
        Me.Btn_actualitzar.Text = "Actualitzar"
        Me.Btn_actualitzar.UseVisualStyleBackColor = True
        '
        'PB_Mostrapassword1
        '
        Me.PB_Mostrapassword1.Image = Global.Control_Hores.My.Resources.Resources.ojocerrado
        Me.PB_Mostrapassword1.Location = New System.Drawing.Point(473, 82)
        Me.PB_Mostrapassword1.Name = "PB_Mostrapassword1"
        Me.PB_Mostrapassword1.Size = New System.Drawing.Size(31, 30)
        Me.PB_Mostrapassword1.TabIndex = 9
        Me.PB_Mostrapassword1.TabStop = False
        '
        'PB_MostraPassword2
        '
        Me.PB_MostraPassword2.Image = Global.Control_Hores.My.Resources.Resources.ojocerrado
        Me.PB_MostraPassword2.Location = New System.Drawing.Point(473, 136)
        Me.PB_MostraPassword2.Name = "PB_MostraPassword2"
        Me.PB_MostraPassword2.Size = New System.Drawing.Size(31, 30)
        Me.PB_MostraPassword2.TabIndex = 10
        Me.PB_MostraPassword2.TabStop = False
        '
        'PB_MostraPassword3
        '
        Me.PB_MostraPassword3.Image = Global.Control_Hores.My.Resources.Resources.ojocerrado
        Me.PB_MostraPassword3.Location = New System.Drawing.Point(473, 190)
        Me.PB_MostraPassword3.Name = "PB_MostraPassword3"
        Me.PB_MostraPassword3.Size = New System.Drawing.Size(31, 30)
        Me.PB_MostraPassword3.TabIndex = 11
        Me.PB_MostraPassword3.TabStop = False
        '
        'Btn_restaurarContrasenyes
        '
        Me.Btn_restaurarContrasenyes.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_restaurarContrasenyes.Location = New System.Drawing.Point(10, 302)
        Me.Btn_restaurarContrasenyes.Name = "Btn_restaurarContrasenyes"
        Me.Btn_restaurarContrasenyes.Size = New System.Drawing.Size(137, 34)
        Me.Btn_restaurarContrasenyes.TabIndex = 12
        Me.Btn_restaurarContrasenyes.Text = "Actualitzar"
        Me.Btn_restaurarContrasenyes.UseVisualStyleBackColor = True
        Me.Btn_restaurarContrasenyes.Visible = False
        '
        'PanelDreta
        '
        Me.PanelDreta.Controls.Add(Me.TB_NouPassword)
        Me.PanelDreta.Controls.Add(Me.DataUsuaris)
        Me.PanelDreta.Controls.Add(Me.Btn_restaurarContrasenyes)
        Me.PanelDreta.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelDreta.Location = New System.Drawing.Point(516, 0)
        Me.PanelDreta.Name = "PanelDreta"
        Me.PanelDreta.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelDreta.Size = New System.Drawing.Size(327, 348)
        Me.PanelDreta.TabIndex = 13
        Me.PanelDreta.Visible = False
        '
        'TB_NouPassword
        '
        Me.TB_NouPassword.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_NouPassword.Location = New System.Drawing.Point(153, 302)
        Me.TB_NouPassword.Name = "TB_NouPassword"
        Me.TB_NouPassword.Size = New System.Drawing.Size(164, 33)
        Me.TB_NouPassword.TabIndex = 13
        '
        'DataUsuaris
        '
        Me.DataUsuaris.AllowUserToAddRows = False
        Me.DataUsuaris.AllowUserToDeleteRows = False
        Me.DataUsuaris.AllowUserToResizeColumns = False
        Me.DataUsuaris.AllowUserToResizeRows = False
        Me.DataUsuaris.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataUsuaris.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataUsuaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataUsuaris.Location = New System.Drawing.Point(10, 10)
        Me.DataUsuaris.MultiSelect = False
        Me.DataUsuaris.Name = "DataUsuaris"
        Me.DataUsuaris.ReadOnly = True
        Me.DataUsuaris.RowHeadersVisible = False
        Me.DataUsuaris.RowTemplate.Height = 25
        Me.DataUsuaris.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataUsuaris.ShowEditingIcon = False
        Me.DataUsuaris.Size = New System.Drawing.Size(307, 277)
        Me.DataUsuaris.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Controls.Add(Me.PB_Admin)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbl_usuari)
        Me.Panel1.Location = New System.Drawing.Point(29, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(475, 46)
        Me.Panel1.TabIndex = 14
        '
        'PB_Admin
        '
        Me.PB_Admin.Dock = System.Windows.Forms.DockStyle.Right
        Me.PB_Admin.Image = Global.Control_Hores.My.Resources.Resources.Admin
        Me.PB_Admin.Location = New System.Drawing.Point(427, 5)
        Me.PB_Admin.Name = "PB_Admin"
        Me.PB_Admin.Size = New System.Drawing.Size(43, 36)
        Me.PB_Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_Admin.TabIndex = 2
        Me.PB_Admin.TabStop = False
        Me.PB_Admin.Visible = False
        '
        'EdicioUsuari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(843, 348)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelDreta)
        Me.Controls.Add(Me.PB_MostraPassword3)
        Me.Controls.Add(Me.PB_MostraPassword2)
        Me.Controls.Add(Me.PB_Mostrapassword1)
        Me.Controls.Add(Me.Btn_actualitzar)
        Me.Controls.Add(Me.TB_PasswordNou)
        Me.Controls.Add(Me.TB_RePassword)
        Me.Controls.Add(Me.TB_passwordActual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EdicioUsuari"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edició usuari"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Mostrapassword1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_MostraPassword2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_MostraPassword3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDreta.ResumeLayout(False)
        Me.PanelDreta.PerformLayout()
        CType(Me.DataUsuaris, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PB_Admin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lbl_usuari As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_passwordActual As TextBox
    Friend WithEvents TB_RePassword As TextBox
    Friend WithEvents TB_PasswordNou As TextBox
    Friend WithEvents Btn_actualitzar As Button
    Friend WithEvents PB_Mostrapassword1 As PictureBox
    Friend WithEvents PB_MostraPassword2 As PictureBox
    Friend WithEvents PB_MostraPassword3 As PictureBox
    Friend WithEvents Btn_restaurarContrasenyes As Button
    Friend WithEvents PanelDreta As Panel
    Friend WithEvents DataUsuaris As DataGridView
    Friend WithEvents TB_NouPassword As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PB_Admin As PictureBox
End Class
