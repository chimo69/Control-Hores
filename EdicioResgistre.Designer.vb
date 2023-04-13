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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_Arxiu = New System.Windows.Forms.TextBox()
        Me.Btn_EditarRuta = New System.Windows.Forms.Button()
        Me.Btn_BorrarRuta = New System.Windows.Forms.Button()
        Me.PanelTipusTransaccio = New System.Windows.Forms.Panel()
        Me.Lbl_TipusTransaccio = New System.Windows.Forms.Label()
        Me.PanelTipusTransaccio.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_EliminaRegistre
        '
        Me.Btn_EliminaRegistre.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_EliminaRegistre.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_EliminaRegistre.Location = New System.Drawing.Point(142, 350)
        Me.Btn_EliminaRegistre.Name = "Btn_EliminaRegistre"
        Me.Btn_EliminaRegistre.Size = New System.Drawing.Size(116, 40)
        Me.Btn_EliminaRegistre.TabIndex = 23
        Me.Btn_EliminaRegistre.Text = "Eliminar registre"
        Me.Btn_EliminaRegistre.UseVisualStyleBackColor = False
        '
        'Btn_ActualitzaRegistre
        '
        Me.Btn_ActualitzaRegistre.Location = New System.Drawing.Point(265, 350)
        Me.Btn_ActualitzaRegistre.Name = "Btn_ActualitzaRegistre"
        Me.Btn_ActualitzaRegistre.Size = New System.Drawing.Size(116, 40)
        Me.Btn_ActualitzaRegistre.TabIndex = 22
        Me.Btn_ActualitzaRegistre.Text = "Actualitzar registre"
        Me.Btn_ActualitzaRegistre.UseVisualStyleBackColor = True
        '
        'TB_Import
        '
        Me.TB_Import.Enabled = False
        Me.TB_Import.Location = New System.Drawing.Point(281, 144)
        Me.TB_Import.Name = "TB_Import"
        Me.TB_Import.PlaceholderText = "0"
        Me.TB_Import.Size = New System.Drawing.Size(100, 23)
        Me.TB_Import.TabIndex = 21
        Me.TB_Import.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(313, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Import"
        '
        'TB_Observacions
        '
        Me.TB_Observacions.Location = New System.Drawing.Point(35, 270)
        Me.TB_Observacions.Multiline = True
        Me.TB_Observacions.Name = "TB_Observacions"
        Me.TB_Observacions.Size = New System.Drawing.Size(345, 65)
        Me.TB_Observacions.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Observacions"
        '
        'TB_PreuHora
        '
        Me.TB_PreuHora.Location = New System.Drawing.Point(142, 144)
        Me.TB_PreuHora.Name = "TB_PreuHora"
        Me.TB_PreuHora.PlaceholderText = "0"
        Me.TB_PreuHora.Size = New System.Drawing.Size(100, 23)
        Me.TB_PreuHora.TabIndex = 17
        Me.TB_PreuHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Preu / Hora"
        '
        'TB_Hores
        '
        Me.TB_Hores.Location = New System.Drawing.Point(142, 104)
        Me.TB_Hores.Name = "TB_Hores"
        Me.TB_Hores.PlaceholderText = "0"
        Me.TB_Hores.Size = New System.Drawing.Size(100, 23)
        Me.TB_Hores.TabIndex = 15
        Me.TB_Hores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Hores"
        '
        'TP_DataRegistre
        '
        Me.TP_DataRegistre.Location = New System.Drawing.Point(142, 66)
        Me.TP_DataRegistre.Name = "TP_DataRegistre"
        Me.TP_DataRegistre.Size = New System.Drawing.Size(239, 23)
        Me.TP_DataRegistre.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Data transacció"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Document adjunt"
        '
        'TB_Arxiu
        '
        Me.TB_Arxiu.Enabled = False
        Me.TB_Arxiu.Location = New System.Drawing.Point(35, 212)
        Me.TB_Arxiu.Name = "TB_Arxiu"
        Me.TB_Arxiu.Size = New System.Drawing.Size(267, 23)
        Me.TB_Arxiu.TabIndex = 25
        '
        'Btn_EditarRuta
        '
        Me.Btn_EditarRuta.BackgroundImage = Global.Control_Hores.My.Resources.Resources.editar
        Me.Btn_EditarRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_EditarRuta.Location = New System.Drawing.Point(347, 206)
        Me.Btn_EditarRuta.Name = "Btn_EditarRuta"
        Me.Btn_EditarRuta.Size = New System.Drawing.Size(33, 33)
        Me.Btn_EditarRuta.TabIndex = 27
        Me.Btn_EditarRuta.UseVisualStyleBackColor = True
        '
        'Btn_BorrarRuta
        '
        Me.Btn_BorrarRuta.Image = Global.Control_Hores.My.Resources.Resources.icono_eliminar
        Me.Btn_BorrarRuta.Location = New System.Drawing.Point(308, 206)
        Me.Btn_BorrarRuta.Name = "Btn_BorrarRuta"
        Me.Btn_BorrarRuta.Size = New System.Drawing.Size(33, 33)
        Me.Btn_BorrarRuta.TabIndex = 28
        Me.Btn_BorrarRuta.UseVisualStyleBackColor = True
        '
        'PanelTipusTransaccio
        '
        Me.PanelTipusTransaccio.Controls.Add(Me.Lbl_TipusTransaccio)
        Me.PanelTipusTransaccio.Location = New System.Drawing.Point(35, 12)
        Me.PanelTipusTransaccio.Name = "PanelTipusTransaccio"
        Me.PanelTipusTransaccio.Size = New System.Drawing.Size(345, 33)
        Me.PanelTipusTransaccio.TabIndex = 29
        '
        'Lbl_TipusTransaccio
        '
        Me.Lbl_TipusTransaccio.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_TipusTransaccio.Location = New System.Drawing.Point(3, 0)
        Me.Lbl_TipusTransaccio.Name = "Lbl_TipusTransaccio"
        Me.Lbl_TipusTransaccio.Size = New System.Drawing.Size(339, 30)
        Me.Lbl_TipusTransaccio.TabIndex = 0
        Me.Lbl_TipusTransaccio.Text = "Afegir hores"
        Me.Lbl_TipusTransaccio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EdicioResgistre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 406)
        Me.Controls.Add(Me.PanelTipusTransaccio)
        Me.Controls.Add(Me.Btn_BorrarRuta)
        Me.Controls.Add(Me.Btn_EditarRuta)
        Me.Controls.Add(Me.TB_Arxiu)
        Me.Controls.Add(Me.Label6)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "EdicioResgistre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edicio de Registre"
        Me.PanelTipusTransaccio.ResumeLayout(False)
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
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_Arxiu As TextBox
    Friend WithEvents Btn_EditarRuta As Button
    Friend WithEvents Btn_BorrarRuta As Button
    Friend WithEvents PanelTipusTransaccio As Panel
    Friend WithEvents Lbl_TipusTransaccio As Label
End Class
