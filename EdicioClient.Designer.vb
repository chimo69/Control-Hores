<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EdicioClient
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
        Me.TB_RaoSocial = New System.Windows.Forms.TextBox()
        Me.TB_IdExit = New System.Windows.Forms.TextBox()
        Me.Lbl_tipusEdicio = New System.Windows.Forms.Label()
        Me.Btn_Desar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Id a ExitERP"
        '
        'TB_RaoSocial
        '
        Me.TB_RaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_RaoSocial.Location = New System.Drawing.Point(115, 61)
        Me.TB_RaoSocial.Name = "TB_RaoSocial"
        Me.TB_RaoSocial.PlaceholderText = "Raó social"
        Me.TB_RaoSocial.Size = New System.Drawing.Size(240, 23)
        Me.TB_RaoSocial.TabIndex = 2
        '
        'TB_IdExit
        '
        Me.TB_IdExit.Location = New System.Drawing.Point(115, 93)
        Me.TB_IdExit.Name = "TB_IdExit"
        Me.TB_IdExit.PlaceholderText = "00000"
        Me.TB_IdExit.Size = New System.Drawing.Size(80, 23)
        Me.TB_IdExit.TabIndex = 3
        Me.TB_IdExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_tipusEdicio
        '
        Me.Lbl_tipusEdicio.AutoSize = True
        Me.Lbl_tipusEdicio.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_tipusEdicio.Location = New System.Drawing.Point(22, 24)
        Me.Lbl_tipusEdicio.Name = "Lbl_tipusEdicio"
        Me.Lbl_tipusEdicio.Size = New System.Drawing.Size(83, 25)
        Me.Lbl_tipusEdicio.TabIndex = 4
        Me.Lbl_tipusEdicio.Text = "Nou Client"
        '
        'Btn_Desar
        '
        Me.Btn_Desar.Location = New System.Drawing.Point(259, 140)
        Me.Btn_Desar.Name = "Btn_Desar"
        Me.Btn_Desar.Size = New System.Drawing.Size(96, 26)
        Me.Btn_Desar.TabIndex = 5
        Me.Btn_Desar.Text = "Desar"
        Me.Btn_Desar.UseVisualStyleBackColor = True
        '
        'EdicioClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 187)
        Me.Controls.Add(Me.Btn_Desar)
        Me.Controls.Add(Me.Lbl_tipusEdicio)
        Me.Controls.Add(Me.TB_IdExit)
        Me.Controls.Add(Me.TB_RaoSocial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "EdicioClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edició Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_RaoSocial As TextBox
    Friend WithEvents TB_IdExit As TextBox
    Friend WithEvents Lbl_tipusEdicio As Label
    Friend WithEvents Btn_Desar As Button
End Class
