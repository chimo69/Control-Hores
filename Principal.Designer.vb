﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Btn_DesarObservacions = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_ObservacionsCLient = New System.Windows.Forms.TextBox()
        Me.Lbl_NomEmpresa = New System.Windows.Forms.Label()
        Me.PanelEmpresas = New System.Windows.Forms.Panel()
        Me.PB_EliminaFiltre = New System.Windows.Forms.PictureBox()
        Me.TB_CercaEmpreses = New System.Windows.Forms.TextBox()
        Me.DataEmpreses = New System.Windows.Forms.DataGridView()
        Me.DataHistorial = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_HoresDisponibles = New System.Windows.Forms.TextBox()
        Me.TB_HoresGastades = New System.Windows.Forms.TextBox()
        Me.TB_HoresTotals = New System.Windows.Forms.TextBox()
        Me.Lbl_HoresDegudes = New System.Windows.Forms.Label()
        Me.TB_HoresDegudes = New System.Windows.Forms.TextBox()
        Me.PanelGestio = New System.Windows.Forms.Panel()
        Me.Panel_RestarHores = New System.Windows.Forms.Panel()
        Me.Btn_restarHores = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TB_HoresRestar = New System.Windows.Forms.TextBox()
        Me.Panel_AfegirHores = New System.Windows.Forms.Panel()
        Me.Btn_AfegirHores = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TB_HoresAfegir = New System.Windows.Forms.TextBox()
        Me.TB_Import = New System.Windows.Forms.TextBox()
        Me.TB_PreuHora = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel_ComentarisTransaccio = New System.Windows.Forms.Panel()
        Me.TB_Comentaris = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel_AfegirRestarHores = New System.Windows.Forms.Panel()
        Me.Btn_ObreRestarHores = New System.Windows.Forms.Button()
        Me.Btn_ObreAfegirHores = New System.Windows.Forms.Button()
        Me.PanelControlHoras = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSuperior.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEmpresas.SuspendLayout()
        CType(Me.PB_EliminaFiltre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataEmpreses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGestio.SuspendLayout()
        Me.Panel_RestarHores.SuspendLayout()
        Me.Panel_AfegirHores.SuspendLayout()
        Me.Panel_ComentarisTransaccio.SuspendLayout()
        Me.Panel_AfegirRestarHores.SuspendLayout()
        Me.PanelControlHoras.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Control_Hores.My.Resources.Resources.empresa
        Me.PictureBox1.Location = New System.Drawing.Point(353, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(174, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 58)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Control clients" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "packs d'hores"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Controls.Add(Me.Panel1)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(1539, 75)
        Me.PanelSuperior.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Btn_DesarObservacions)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TB_ObservacionsCLient)
        Me.Panel1.Controls.Add(Me.Lbl_NomEmpresa)
        Me.Panel1.Location = New System.Drawing.Point(12, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2597, 69)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Control_Hores.My.Resources.Resources.LOGO_EMPRESA_SENSE_FONS_01
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(140, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Btn_DesarObservacions
        '
        Me.Btn_DesarObservacions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_DesarObservacions.Location = New System.Drawing.Point(3611, 23)
        Me.Btn_DesarObservacions.Name = "Btn_DesarObservacions"
        Me.Btn_DesarObservacions.Size = New System.Drawing.Size(56, 39)
        Me.Btn_DesarObservacions.TabIndex = 3
        Me.Btn_DesarObservacions.Text = "Desar"
        Me.Btn_DesarObservacions.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3116, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Observacions sobre el client"
        '
        'TB_ObservacionsCLient
        '
        Me.TB_ObservacionsCLient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_ObservacionsCLient.Location = New System.Drawing.Point(3116, 25)
        Me.TB_ObservacionsCLient.Multiline = True
        Me.TB_ObservacionsCLient.Name = "TB_ObservacionsCLient"
        Me.TB_ObservacionsCLient.Size = New System.Drawing.Size(489, 37)
        Me.TB_ObservacionsCLient.TabIndex = 1
        '
        'Lbl_NomEmpresa
        '
        Me.Lbl_NomEmpresa.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_NomEmpresa.Location = New System.Drawing.Point(424, 17)
        Me.Lbl_NomEmpresa.Name = "Lbl_NomEmpresa"
        Me.Lbl_NomEmpresa.Size = New System.Drawing.Size(429, 37)
        Me.Lbl_NomEmpresa.TabIndex = 0
        Me.Lbl_NomEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelEmpresas
        '
        Me.PanelEmpresas.Controls.Add(Me.PB_EliminaFiltre)
        Me.PanelEmpresas.Controls.Add(Me.TB_CercaEmpreses)
        Me.PanelEmpresas.Controls.Add(Me.DataEmpreses)
        Me.PanelEmpresas.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEmpresas.Location = New System.Drawing.Point(0, 75)
        Me.PanelEmpresas.Name = "PanelEmpresas"
        Me.PanelEmpresas.Size = New System.Drawing.Size(303, 580)
        Me.PanelEmpresas.TabIndex = 3
        '
        'PB_EliminaFiltre
        '
        Me.PB_EliminaFiltre.Image = Global.Control_Hores.My.Resources.Resources.icono_eliminar
        Me.PB_EliminaFiltre.Location = New System.Drawing.Point(263, 26)
        Me.PB_EliminaFiltre.Name = "PB_EliminaFiltre"
        Me.PB_EliminaFiltre.Size = New System.Drawing.Size(25, 23)
        Me.PB_EliminaFiltre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_EliminaFiltre.TabIndex = 2
        Me.PB_EliminaFiltre.TabStop = False
        '
        'TB_CercaEmpreses
        '
        Me.TB_CercaEmpreses.Location = New System.Drawing.Point(12, 26)
        Me.TB_CercaEmpreses.Name = "TB_CercaEmpreses"
        Me.TB_CercaEmpreses.Size = New System.Drawing.Size(229, 23)
        Me.TB_CercaEmpreses.TabIndex = 1
        '
        'DataEmpreses
        '
        Me.DataEmpreses.AllowUserToAddRows = False
        Me.DataEmpreses.AllowUserToDeleteRows = False
        Me.DataEmpreses.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataEmpreses.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataEmpreses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataEmpreses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataEmpreses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataEmpreses.Location = New System.Drawing.Point(12, 55)
        Me.DataEmpreses.MultiSelect = False
        Me.DataEmpreses.Name = "DataEmpreses"
        Me.DataEmpreses.ReadOnly = True
        Me.DataEmpreses.RowHeadersVisible = False
        Me.DataEmpreses.RowTemplate.Height = 25
        Me.DataEmpreses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataEmpreses.ShowEditingIcon = False
        Me.DataEmpreses.Size = New System.Drawing.Size(276, 530)
        Me.DataEmpreses.TabIndex = 0
        '
        'DataHistorial
        '
        Me.DataHistorial.AllowUserToAddRows = False
        Me.DataHistorial.AllowUserToDeleteRows = False
        Me.DataHistorial.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataHistorial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataHistorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataHistorial.Location = New System.Drawing.Point(318, 190)
        Me.DataHistorial.MultiSelect = False
        Me.DataHistorial.Name = "DataHistorial"
        Me.DataHistorial.ReadOnly = True
        Me.DataHistorial.RowHeadersVisible = False
        Me.DataHistorial.RowTemplate.Height = 25
        Me.DataHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataHistorial.ShowEditingIcon = False
        Me.DataHistorial.Size = New System.Drawing.Size(1209, 453)
        Me.DataHistorial.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(318, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Historial d'hores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(231, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Disponibles"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(7, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Gastades"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(7, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Contractades"
        '
        'TB_HoresDisponibles
        '
        Me.TB_HoresDisponibles.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_HoresDisponibles.Location = New System.Drawing.Point(360, 8)
        Me.TB_HoresDisponibles.Name = "TB_HoresDisponibles"
        Me.TB_HoresDisponibles.ReadOnly = True
        Me.TB_HoresDisponibles.Size = New System.Drawing.Size(68, 30)
        Me.TB_HoresDisponibles.TabIndex = 9
        Me.TB_HoresDisponibles.Text = "0"
        Me.TB_HoresDisponibles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_HoresGastades
        '
        Me.TB_HoresGastades.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_HoresGastades.Location = New System.Drawing.Point(147, 7)
        Me.TB_HoresGastades.Name = "TB_HoresGastades"
        Me.TB_HoresGastades.ReadOnly = True
        Me.TB_HoresGastades.Size = New System.Drawing.Size(68, 30)
        Me.TB_HoresGastades.TabIndex = 10
        Me.TB_HoresGastades.Text = "0"
        Me.TB_HoresGastades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_HoresTotals
        '
        Me.TB_HoresTotals.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_HoresTotals.Location = New System.Drawing.Point(147, 36)
        Me.TB_HoresTotals.Name = "TB_HoresTotals"
        Me.TB_HoresTotals.ReadOnly = True
        Me.TB_HoresTotals.Size = New System.Drawing.Size(68, 30)
        Me.TB_HoresTotals.TabIndex = 11
        Me.TB_HoresTotals.Text = "0"
        Me.TB_HoresTotals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_HoresDegudes
        '
        Me.Lbl_HoresDegudes.AutoSize = True
        Me.Lbl_HoresDegudes.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_HoresDegudes.Location = New System.Drawing.Point(231, 37)
        Me.Lbl_HoresDegudes.Name = "Lbl_HoresDegudes"
        Me.Lbl_HoresDegudes.Size = New System.Drawing.Size(93, 29)
        Me.Lbl_HoresDegudes.TabIndex = 12
        Me.Lbl_HoresDegudes.Text = "Degudes"
        Me.Lbl_HoresDegudes.Visible = False
        '
        'TB_HoresDegudes
        '
        Me.TB_HoresDegudes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TB_HoresDegudes.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_HoresDegudes.Location = New System.Drawing.Point(360, 37)
        Me.TB_HoresDegudes.Name = "TB_HoresDegudes"
        Me.TB_HoresDegudes.ReadOnly = True
        Me.TB_HoresDegudes.Size = New System.Drawing.Size(68, 30)
        Me.TB_HoresDegudes.TabIndex = 13
        Me.TB_HoresDegudes.Text = "0"
        Me.TB_HoresDegudes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TB_HoresDegudes.Visible = False
        '
        'PanelGestio
        '
        Me.PanelGestio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelGestio.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PanelGestio.Controls.Add(Me.Panel_RestarHores)
        Me.PanelGestio.Controls.Add(Me.Panel_AfegirHores)
        Me.PanelGestio.Controls.Add(Me.Panel_ComentarisTransaccio)
        Me.PanelGestio.Controls.Add(Me.Panel_AfegirRestarHores)
        Me.PanelGestio.Location = New System.Drawing.Point(757, 82)
        Me.PanelGestio.Name = "PanelGestio"
        Me.PanelGestio.Size = New System.Drawing.Size(770, 100)
        Me.PanelGestio.TabIndex = 14
        Me.PanelGestio.Visible = False
        '
        'Panel_RestarHores
        '
        Me.Panel_RestarHores.Controls.Add(Me.Btn_restarHores)
        Me.Panel_RestarHores.Controls.Add(Me.Label11)
        Me.Panel_RestarHores.Controls.Add(Me.TB_HoresRestar)
        Me.Panel_RestarHores.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_RestarHores.Location = New System.Drawing.Point(348, 0)
        Me.Panel_RestarHores.Name = "Panel_RestarHores"
        Me.Panel_RestarHores.Size = New System.Drawing.Size(85, 100)
        Me.Panel_RestarHores.TabIndex = 12
        Me.Panel_RestarHores.Visible = False
        '
        'Btn_restarHores
        '
        Me.Btn_restarHores.Location = New System.Drawing.Point(6, 65)
        Me.Btn_restarHores.Name = "Btn_restarHores"
        Me.Btn_restarHores.Size = New System.Drawing.Size(69, 23)
        Me.Btn_restarHores.TabIndex = 13
        Me.Btn_restarHores.Text = "Restar"
        Me.Btn_restarHores.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 15)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Hores"
        '
        'TB_HoresRestar
        '
        Me.TB_HoresRestar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_HoresRestar.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_HoresRestar.Location = New System.Drawing.Point(6, 28)
        Me.TB_HoresRestar.Name = "TB_HoresRestar"
        Me.TB_HoresRestar.PlaceholderText = "0"
        Me.TB_HoresRestar.Size = New System.Drawing.Size(69, 30)
        Me.TB_HoresRestar.TabIndex = 3
        Me.TB_HoresRestar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel_AfegirHores
        '
        Me.Panel_AfegirHores.Controls.Add(Me.Btn_AfegirHores)
        Me.Panel_AfegirHores.Controls.Add(Me.Label10)
        Me.Panel_AfegirHores.Controls.Add(Me.Label9)
        Me.Panel_AfegirHores.Controls.Add(Me.TB_HoresAfegir)
        Me.Panel_AfegirHores.Controls.Add(Me.TB_Import)
        Me.Panel_AfegirHores.Controls.Add(Me.TB_PreuHora)
        Me.Panel_AfegirHores.Controls.Add(Me.Label8)
        Me.Panel_AfegirHores.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_AfegirHores.Location = New System.Drawing.Point(108, 0)
        Me.Panel_AfegirHores.Name = "Panel_AfegirHores"
        Me.Panel_AfegirHores.Size = New System.Drawing.Size(240, 100)
        Me.Panel_AfegirHores.TabIndex = 11
        Me.Panel_AfegirHores.Visible = False
        '
        'Btn_AfegirHores
        '
        Me.Btn_AfegirHores.Location = New System.Drawing.Point(10, 65)
        Me.Btn_AfegirHores.Name = "Btn_AfegirHores"
        Me.Btn_AfegirHores.Size = New System.Drawing.Size(219, 23)
        Me.Btn_AfegirHores.TabIndex = 12
        Me.Btn_AfegirHores.Text = "Afegir"
        Me.Btn_AfegirHores.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 15)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Hores"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(172, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Import"
        '
        'TB_HoresAfegir
        '
        Me.TB_HoresAfegir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_HoresAfegir.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_HoresAfegir.Location = New System.Drawing.Point(10, 28)
        Me.TB_HoresAfegir.Name = "TB_HoresAfegir"
        Me.TB_HoresAfegir.PlaceholderText = "0"
        Me.TB_HoresAfegir.Size = New System.Drawing.Size(69, 30)
        Me.TB_HoresAfegir.TabIndex = 1
        Me.TB_HoresAfegir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_Import
        '
        Me.TB_Import.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_Import.Enabled = False
        Me.TB_Import.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Import.Location = New System.Drawing.Point(160, 28)
        Me.TB_Import.Name = "TB_Import"
        Me.TB_Import.PlaceholderText = "0"
        Me.TB_Import.ReadOnly = True
        Me.TB_Import.Size = New System.Drawing.Size(69, 30)
        Me.TB_Import.TabIndex = 8
        Me.TB_Import.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_PreuHora
        '
        Me.TB_PreuHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_PreuHora.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_PreuHora.Location = New System.Drawing.Point(85, 28)
        Me.TB_PreuHora.Name = "TB_PreuHora"
        Me.TB_PreuHora.PlaceholderText = "0"
        Me.TB_PreuHora.Size = New System.Drawing.Size(69, 30)
        Me.TB_PreuHora.TabIndex = 6
        Me.TB_PreuHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(85, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Preu / Hora"
        '
        'Panel_ComentarisTransaccio
        '
        Me.Panel_ComentarisTransaccio.Controls.Add(Me.TB_Comentaris)
        Me.Panel_ComentarisTransaccio.Controls.Add(Me.Label6)
        Me.Panel_ComentarisTransaccio.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_ComentarisTransaccio.Location = New System.Drawing.Point(433, 0)
        Me.Panel_ComentarisTransaccio.Name = "Panel_ComentarisTransaccio"
        Me.Panel_ComentarisTransaccio.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Panel_ComentarisTransaccio.Size = New System.Drawing.Size(337, 100)
        Me.Panel_ComentarisTransaccio.TabIndex = 13
        Me.Panel_ComentarisTransaccio.Visible = False
        '
        'TB_Comentaris
        '
        Me.TB_Comentaris.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_Comentaris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_Comentaris.Location = New System.Drawing.Point(13, 29)
        Me.TB_Comentaris.Multiline = True
        Me.TB_Comentaris.Name = "TB_Comentaris"
        Me.TB_Comentaris.Size = New System.Drawing.Size(316, 57)
        Me.TB_Comentaris.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Comentaris de la transacció"
        '
        'Panel_AfegirRestarHores
        '
        Me.Panel_AfegirRestarHores.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel_AfegirRestarHores.Controls.Add(Me.Btn_ObreRestarHores)
        Me.Panel_AfegirRestarHores.Controls.Add(Me.Btn_ObreAfegirHores)
        Me.Panel_AfegirRestarHores.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_AfegirRestarHores.Location = New System.Drawing.Point(0, 0)
        Me.Panel_AfegirRestarHores.Name = "Panel_AfegirRestarHores"
        Me.Panel_AfegirRestarHores.Size = New System.Drawing.Size(108, 100)
        Me.Panel_AfegirRestarHores.TabIndex = 10
        '
        'Btn_ObreRestarHores
        '
        Me.Btn_ObreRestarHores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_ObreRestarHores.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_ObreRestarHores.Location = New System.Drawing.Point(7, 54)
        Me.Btn_ObreRestarHores.Name = "Btn_ObreRestarHores"
        Me.Btn_ObreRestarHores.Size = New System.Drawing.Size(94, 31)
        Me.Btn_ObreRestarHores.TabIndex = 2
        Me.Btn_ObreRestarHores.Text = "Restar hores"
        Me.Btn_ObreRestarHores.UseVisualStyleBackColor = True
        '
        'Btn_ObreAfegirHores
        '
        Me.Btn_ObreAfegirHores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_ObreAfegirHores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ObreAfegirHores.Location = New System.Drawing.Point(7, 17)
        Me.Btn_ObreAfegirHores.Name = "Btn_ObreAfegirHores"
        Me.Btn_ObreAfegirHores.Size = New System.Drawing.Size(94, 31)
        Me.Btn_ObreAfegirHores.TabIndex = 0
        Me.Btn_ObreAfegirHores.Text = "Afegir hores"
        Me.Btn_ObreAfegirHores.UseVisualStyleBackColor = True
        '
        'PanelControlHoras
        '
        Me.PanelControlHoras.Controls.Add(Me.TB_HoresGastades)
        Me.PanelControlHoras.Controls.Add(Me.TB_HoresDegudes)
        Me.PanelControlHoras.Controls.Add(Me.Label3)
        Me.PanelControlHoras.Controls.Add(Me.Lbl_HoresDegudes)
        Me.PanelControlHoras.Controls.Add(Me.Label4)
        Me.PanelControlHoras.Controls.Add(Me.TB_HoresTotals)
        Me.PanelControlHoras.Controls.Add(Me.Label5)
        Me.PanelControlHoras.Controls.Add(Me.TB_HoresDisponibles)
        Me.PanelControlHoras.Location = New System.Drawing.Point(318, 110)
        Me.PanelControlHoras.Name = "PanelControlHoras"
        Me.PanelControlHoras.Size = New System.Drawing.Size(433, 74)
        Me.PanelControlHoras.TabIndex = 15
        Me.PanelControlHoras.Visible = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1539, 655)
        Me.Controls.Add(Me.PanelControlHoras)
        Me.Controls.Add(Me.PanelGestio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataHistorial)
        Me.Controls.Add(Me.PanelEmpresas)
        Me.Controls.Add(Me.PanelSuperior)
        Me.MinimumSize = New System.Drawing.Size(1470, 694)
        Me.Name = "Principal"
        Me.Text = "Control Pack d'hores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSuperior.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEmpresas.ResumeLayout(False)
        Me.PanelEmpresas.PerformLayout()
        CType(Me.PB_EliminaFiltre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataEmpreses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGestio.ResumeLayout(False)
        Me.Panel_RestarHores.ResumeLayout(False)
        Me.Panel_RestarHores.PerformLayout()
        Me.Panel_AfegirHores.ResumeLayout(False)
        Me.Panel_AfegirHores.PerformLayout()
        Me.Panel_ComentarisTransaccio.ResumeLayout(False)
        Me.Panel_ComentarisTransaccio.PerformLayout()
        Me.Panel_AfegirRestarHores.ResumeLayout(False)
        Me.PanelControlHoras.ResumeLayout(False)
        Me.PanelControlHoras.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PanelEmpresas As Panel
    Friend WithEvents PB_EliminaFiltre As PictureBox
    Friend WithEvents TB_CercaEmpreses As TextBox
    Friend WithEvents DataEmpreses As DataGridView
    Friend WithEvents DataHistorial As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_HoresDisponibles As TextBox
    Friend WithEvents TB_HoresGastades As TextBox
    Friend WithEvents TB_HoresTotals As TextBox
    Friend WithEvents Lbl_HoresDegudes As Label
    Friend WithEvents TB_HoresDegudes As TextBox
    Friend WithEvents PanelGestio As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_HoresRestar As TextBox
    Friend WithEvents Btn_ObreRestarHores As Button
    Friend WithEvents TB_HoresAfegir As TextBox
    Friend WithEvents Btn_ObreAfegirHores As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_DesarObservacions As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TB_ObservacionsCLient As TextBox
    Friend WithEvents Lbl_NomEmpresa As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PanelControlHoras As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TB_Import As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TB_PreuHora As TextBox
    Friend WithEvents Panel_ComentarisTransaccio As Panel
    Friend WithEvents Panel_RestarHores As Panel
    Friend WithEvents Btn_restarHores As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel_AfegirHores As Panel
    Friend WithEvents Btn_AfegirHores As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel_AfegirRestarHores As Panel
    Friend WithEvents TB_Comentaris As TextBox
End Class