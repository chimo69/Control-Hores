<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EdicioResgistre
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
        Me.Btn_EliminaRegistre = New System.Windows.Forms.Button()
        Me.Btn_ActualitzaRegistre = New System.Windows.Forms.Button()
        Me.TB_Import = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_Observacions = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_PreuHora = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Hores = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TP_DataRegistre = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_EliminaRegistre
        '
        Me.Btn_EliminaRegistre.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_EliminaRegistre.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_EliminaRegistre.Location = New System.Drawing.Point(128, 237)
        Me.Btn_EliminaRegistre.Name = "Btn_EliminaRegistre"
        Me.Btn_EliminaRegistre.Size = New System.Drawing.Size(116, 40)
        Me.Btn_EliminaRegistre.TabIndex = 23
        Me.Btn_EliminaRegistre.Text = "Eliminar registre"
        Me.Btn_EliminaRegistre.UseVisualStyleBackColor = False
        '
        'Btn_ActualitzaRegistre
        '
        Me.Btn_ActualitzaRegistre.Location = New System.Drawing.Point(251, 237)
        Me.Btn_ActualitzaRegistre.Name = "Btn_ActualitzaRegistre"
        Me.Btn_ActualitzaRegistre.Size = New System.Drawing.Size(116, 40)
        Me.Btn_ActualitzaRegistre.TabIndex = 22
        Me.Btn_ActualitzaRegistre.Text = "Actualitzar registre"
        Me.Btn_ActualitzaRegistre.UseVisualStyleBackColor = True
        '
        'TB_Import
        '
        Me.TB_Import.Enabled = False
        Me.TB_Import.Location = New System.Drawing.Point(267, 99)
        Me.TB_Import.Name = "TB_Import"
        Me.TB_Import.Size = New System.Drawing.Size(100, 23)
        Me.TB_Import.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(299, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Import"
        '
        'TB_Observacions
        '
        Me.TB_Observacions.Location = New System.Drawing.Point(128, 143)
        Me.TB_Observacions.Multiline = True
        Me.TB_Observacions.Name = "TB_Observacions"
        Me.TB_Observacions.Size = New System.Drawing.Size(239, 65)
        Me.TB_Observacions.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Observacions"
        '
        'TB_PreuHora
        '
        Me.TB_PreuHora.Location = New System.Drawing.Point(128, 99)
        Me.TB_PreuHora.Name = "TB_PreuHora"
        Me.TB_PreuHora.Size = New System.Drawing.Size(100, 23)
        Me.TB_PreuHora.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Preu / Hora"
        '
        'TB_Hores
        '
        Me.TB_Hores.Location = New System.Drawing.Point(128, 59)
        Me.TB_Hores.Name = "TB_Hores"
        Me.TB_Hores.Size = New System.Drawing.Size(100, 23)
        Me.TB_Hores.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Hores"
        '
        'TP_DataRegistre
        '
        Me.TP_DataRegistre.Location = New System.Drawing.Point(128, 21)
        Me.TP_DataRegistre.Name = "TP_DataRegistre"
        Me.TP_DataRegistre.Size = New System.Drawing.Size(239, 23)
        Me.TP_DataRegistre.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Data transacció"
        '
        'EdicioResgistre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 308)
        Me.Controls.Add(Me.Btn_EliminaRegistre)
        Me.Controls.Add(Me.Btn_ActualitzaRegistre)
        Me.Controls.Add(Me.TB_Import)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_Observacions)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_PreuHora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_Hores)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TP_DataRegistre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EdicioResgistre"
        Me.Text = "Edicio de Registre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_EliminaRegistre As Button
    Friend WithEvents Btn_ActualitzaRegistre As Button
    Friend WithEvents TB_Import As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_Observacions As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_PreuHora As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_Hores As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TP_DataRegistre As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
