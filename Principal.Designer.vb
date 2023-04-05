<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_IdExit = New System.Windows.Forms.Label()
        Me.Btn_DesarObservacions = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_ObservacionsCLient = New System.Windows.Forms.TextBox()
        Me.Lbl_NomEmpresa = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelEmpresas = New System.Windows.Forms.Panel()
        Me.BT_HistorialComplet = New System.Windows.Forms.Button()
        Me.Btn_EditarClient = New System.Windows.Forms.Button()
        Me.Btn_EliminarClient = New System.Windows.Forms.Button()
        Me.Btn_afegirClient = New System.Windows.Forms.Button()
        Me.PB_EliminaFiltreId = New System.Windows.Forms.PictureBox()
        Me.TB_CercaId = New System.Windows.Forms.TextBox()
        Me.PB_EliminaFiltre = New System.Windows.Forms.PictureBox()
        Me.TB_CercaEmpreses = New System.Windows.Forms.TextBox()
        Me.DataEmpreses = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ExportarCSV = New System.Windows.Forms.Button()
        Me.Btn_exportExcel = New System.Windows.Forms.Button()
        Me.PanelControlHoras = New System.Windows.Forms.Panel()
        Me.TB_HoresGastades = New System.Windows.Forms.TextBox()
        Me.TB_HoresDegudes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_HoresDegudes = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_HoresTotals = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_HoresDisponibles = New System.Windows.Forms.TextBox()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataHistorial = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSuperior.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEmpresas.SuspendLayout()
        CType(Me.PB_EliminaFiltreId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_EliminaFiltre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataEmpreses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PanelControlHoras.SuspendLayout()
        Me.PanelGestio.SuspendLayout()
        Me.Panel_RestarHores.SuspendLayout()
        Me.Panel_AfegirHores.SuspendLayout()
        Me.Panel_ComentarisTransaccio.SuspendLayout()
        Me.Panel_AfegirRestarHores.SuspendLayout()
        CType(Me.DataHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelSuperior.Size = New System.Drawing.Size(1507, 88)
        Me.PanelSuperior.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Lbl_IdExit)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Btn_DesarObservacions)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TB_ObservacionsCLient)
        Me.Panel1.Controls.Add(Me.Lbl_NomEmpresa)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(11, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1483, 69)
        Me.Panel1.TabIndex = 2
        '
        'Lbl_IdExit
        '
        Me.Lbl_IdExit.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_IdExit.Location = New System.Drawing.Point(424, 36)
        Me.Lbl_IdExit.Name = "Lbl_IdExit"
        Me.Lbl_IdExit.Size = New System.Drawing.Size(429, 28)
        Me.Lbl_IdExit.TabIndex = 5
        Me.Lbl_IdExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_DesarObservacions
        '
        Me.Btn_DesarObservacions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_DesarObservacions.Location = New System.Drawing.Point(1419, 22)
        Me.Btn_DesarObservacions.Name = "Btn_DesarObservacions"
        Me.Btn_DesarObservacions.Size = New System.Drawing.Size(56, 37)
        Me.Btn_DesarObservacions.TabIndex = 3
        Me.Btn_DesarObservacions.Text = "Desar"
        Me.Btn_DesarObservacions.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(869, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Observacions sobre el client"
        '
        'TB_ObservacionsCLient
        '
        Me.TB_ObservacionsCLient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_ObservacionsCLient.Location = New System.Drawing.Point(869, 22)
        Me.TB_ObservacionsCLient.Multiline = True
        Me.TB_ObservacionsCLient.Name = "TB_ObservacionsCLient"
        Me.TB_ObservacionsCLient.PlaceholderText = "Introdueix observacions"
        Me.TB_ObservacionsCLient.Size = New System.Drawing.Size(544, 37)
        Me.TB_ObservacionsCLient.TabIndex = 1
        '
        'Lbl_NomEmpresa
        '
        Me.Lbl_NomEmpresa.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_NomEmpresa.Location = New System.Drawing.Point(424, 4)
        Me.Lbl_NomEmpresa.Name = "Lbl_NomEmpresa"
        Me.Lbl_NomEmpresa.Size = New System.Drawing.Size(429, 32)
        Me.Lbl_NomEmpresa.TabIndex = 0
        Me.Lbl_NomEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'PanelEmpresas
        '
        Me.PanelEmpresas.Controls.Add(Me.BT_HistorialComplet)
        Me.PanelEmpresas.Controls.Add(Me.Btn_EditarClient)
        Me.PanelEmpresas.Controls.Add(Me.Btn_EliminarClient)
        Me.PanelEmpresas.Controls.Add(Me.Btn_afegirClient)
        Me.PanelEmpresas.Controls.Add(Me.PB_EliminaFiltreId)
        Me.PanelEmpresas.Controls.Add(Me.TB_CercaId)
        Me.PanelEmpresas.Controls.Add(Me.PB_EliminaFiltre)
        Me.PanelEmpresas.Controls.Add(Me.TB_CercaEmpreses)
        Me.PanelEmpresas.Controls.Add(Me.DataEmpreses)
        Me.PanelEmpresas.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEmpresas.Location = New System.Drawing.Point(0, 88)
        Me.PanelEmpresas.Name = "PanelEmpresas"
        Me.PanelEmpresas.Size = New System.Drawing.Size(361, 567)
        Me.PanelEmpresas.TabIndex = 3
        '
        'BT_HistorialComplet
        '
        Me.BT_HistorialComplet.Location = New System.Drawing.Point(240, 6)
        Me.BT_HistorialComplet.Name = "BT_HistorialComplet"
        Me.BT_HistorialComplet.Size = New System.Drawing.Size(110, 33)
        Me.BT_HistorialComplet.TabIndex = 8
        Me.BT_HistorialComplet.Text = "Historial complet"
        Me.BT_HistorialComplet.UseVisualStyleBackColor = True
        '
        'Btn_EditarClient
        '
        Me.Btn_EditarClient.BackgroundImage = Global.Control_Hores.My.Resources.Resources.editar
        Me.Btn_EditarClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_EditarClient.Location = New System.Drawing.Point(92, 6)
        Me.Btn_EditarClient.Name = "Btn_EditarClient"
        Me.Btn_EditarClient.Size = New System.Drawing.Size(33, 33)
        Me.Btn_EditarClient.TabIndex = 7
        Me.Btn_EditarClient.UseVisualStyleBackColor = True
        '
        'Btn_EliminarClient
        '
        Me.Btn_EliminarClient.Image = Global.Control_Hores.My.Resources.Resources.menos
        Me.Btn_EliminarClient.Location = New System.Drawing.Point(53, 6)
        Me.Btn_EliminarClient.Name = "Btn_EliminarClient"
        Me.Btn_EliminarClient.Size = New System.Drawing.Size(33, 33)
        Me.Btn_EliminarClient.TabIndex = 6
        Me.Btn_EliminarClient.UseVisualStyleBackColor = True
        '
        'Btn_afegirClient
        '
        Me.Btn_afegirClient.Image = Global.Control_Hores.My.Resources.Resources.mas
        Me.Btn_afegirClient.Location = New System.Drawing.Point(14, 6)
        Me.Btn_afegirClient.Name = "Btn_afegirClient"
        Me.Btn_afegirClient.Size = New System.Drawing.Size(33, 33)
        Me.Btn_afegirClient.TabIndex = 5
        Me.Btn_afegirClient.UseVisualStyleBackColor = True
        '
        'PB_EliminaFiltreId
        '
        Me.PB_EliminaFiltreId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PB_EliminaFiltreId.Image = Global.Control_Hores.My.Resources.Resources.icono_eliminar
        Me.PB_EliminaFiltreId.Location = New System.Drawing.Point(325, 48)
        Me.PB_EliminaFiltreId.Name = "PB_EliminaFiltreId"
        Me.PB_EliminaFiltreId.Size = New System.Drawing.Size(25, 23)
        Me.PB_EliminaFiltreId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_EliminaFiltreId.TabIndex = 4
        Me.PB_EliminaFiltreId.TabStop = False
        '
        'TB_CercaId
        '
        Me.TB_CercaId.Location = New System.Drawing.Point(201, 48)
        Me.TB_CercaId.Name = "TB_CercaId"
        Me.TB_CercaId.PlaceholderText = "Cerca per ID"
        Me.TB_CercaId.Size = New System.Drawing.Size(125, 23)
        Me.TB_CercaId.TabIndex = 3
        '
        'PB_EliminaFiltre
        '
        Me.PB_EliminaFiltre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PB_EliminaFiltre.Image = Global.Control_Hores.My.Resources.Resources.icono_eliminar
        Me.PB_EliminaFiltre.Location = New System.Drawing.Point(156, 47)
        Me.PB_EliminaFiltre.Name = "PB_EliminaFiltre"
        Me.PB_EliminaFiltre.Size = New System.Drawing.Size(25, 23)
        Me.PB_EliminaFiltre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_EliminaFiltre.TabIndex = 2
        Me.PB_EliminaFiltre.TabStop = False
        '
        'TB_CercaEmpreses
        '
        Me.TB_CercaEmpreses.Location = New System.Drawing.Point(14, 47)
        Me.TB_CercaEmpreses.Name = "TB_CercaEmpreses"
        Me.TB_CercaEmpreses.PlaceholderText = "Cerca per empresa"
        Me.TB_CercaEmpreses.Size = New System.Drawing.Size(143, 23)
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataEmpreses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataEmpreses.ColumnHeadersHeight = 30
        Me.DataEmpreses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataEmpreses.EnableHeadersVisualStyles = False
        Me.DataEmpreses.Location = New System.Drawing.Point(14, 78)
        Me.DataEmpreses.MultiSelect = False
        Me.DataEmpreses.Name = "DataEmpreses"
        Me.DataEmpreses.ReadOnly = True
        Me.DataEmpreses.RowHeadersVisible = False
        Me.DataEmpreses.RowTemplate.Height = 25
        Me.DataEmpreses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataEmpreses.ShowEditingIcon = False
        Me.DataEmpreses.Size = New System.Drawing.Size(336, 477)
        Me.DataEmpreses.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ExportarCSV)
        Me.Panel2.Controls.Add(Me.Btn_exportExcel)
        Me.Panel2.Controls.Add(Me.PanelControlHoras)
        Me.Panel2.Controls.Add(Me.PanelGestio)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.DataHistorial)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(361, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(1146, 567)
        Me.Panel2.TabIndex = 4
        '
        'ExportarCSV
        '
        Me.ExportarCSV.BackgroundImage = Global.Control_Hores.My.Resources.Resources.csv
        Me.ExportarCSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ExportarCSV.Location = New System.Drawing.Point(62, 2)
        Me.ExportarCSV.Name = "ExportarCSV"
        Me.ExportarCSV.Size = New System.Drawing.Size(40, 40)
        Me.ExportarCSV.TabIndex = 21
        Me.ExportarCSV.UseVisualStyleBackColor = True
        '
        'Btn_exportExcel
        '
        Me.Btn_exportExcel.BackgroundImage = Global.Control_Hores.My.Resources.Resources.excel1
        Me.Btn_exportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_exportExcel.Location = New System.Drawing.Point(16, 2)
        Me.Btn_exportExcel.Name = "Btn_exportExcel"
        Me.Btn_exportExcel.Size = New System.Drawing.Size(40, 40)
        Me.Btn_exportExcel.TabIndex = 20
        Me.Btn_exportExcel.UseVisualStyleBackColor = True
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
        Me.PanelControlHoras.Location = New System.Drawing.Point(15, 41)
        Me.PanelControlHoras.Name = "PanelControlHoras"
        Me.PanelControlHoras.Size = New System.Drawing.Size(433, 74)
        Me.PanelControlHoras.TabIndex = 19
        Me.PanelControlHoras.Visible = False
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(-2, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Gastades"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(-2, 35)
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
        'PanelGestio
        '
        Me.PanelGestio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelGestio.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PanelGestio.Controls.Add(Me.Panel_RestarHores)
        Me.PanelGestio.Controls.Add(Me.Panel_AfegirHores)
        Me.PanelGestio.Controls.Add(Me.Panel_ComentarisTransaccio)
        Me.PanelGestio.Controls.Add(Me.Panel_AfegirRestarHores)
        Me.PanelGestio.Location = New System.Drawing.Point(454, 19)
        Me.PanelGestio.Name = "PanelGestio"
        Me.PanelGestio.Size = New System.Drawing.Size(679, 96)
        Me.PanelGestio.TabIndex = 18
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
        Me.Panel_RestarHores.Size = New System.Drawing.Size(85, 96)
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
        Me.Panel_AfegirHores.Size = New System.Drawing.Size(240, 96)
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
        Me.Panel_ComentarisTransaccio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_ComentarisTransaccio.Controls.Add(Me.TB_Comentaris)
        Me.Panel_ComentarisTransaccio.Controls.Add(Me.Label6)
        Me.Panel_ComentarisTransaccio.Location = New System.Drawing.Point(439, 0)
        Me.Panel_ComentarisTransaccio.Name = "Panel_ComentarisTransaccio"
        Me.Panel_ComentarisTransaccio.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Panel_ComentarisTransaccio.Size = New System.Drawing.Size(240, 96)
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
        Me.TB_Comentaris.Size = New System.Drawing.Size(220, 59)
        Me.TB_Comentaris.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 11)
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
        Me.Panel_AfegirRestarHores.Size = New System.Drawing.Size(108, 96)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(108, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 29)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Historial d'hores"
        '
        'DataHistorial
        '
        Me.DataHistorial.AllowUserToAddRows = False
        Me.DataHistorial.AllowUserToDeleteRows = False
        Me.DataHistorial.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataHistorial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataHistorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataHistorial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataHistorial.ColumnHeadersHeight = 30
        Me.DataHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataHistorial.EnableHeadersVisualStyles = False
        Me.DataHistorial.Location = New System.Drawing.Point(15, 121)
        Me.DataHistorial.MultiSelect = False
        Me.DataHistorial.Name = "DataHistorial"
        Me.DataHistorial.ReadOnly = True
        Me.DataHistorial.RowHeadersVisible = False
        Me.DataHistorial.RowTemplate.Height = 25
        Me.DataHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataHistorial.ShowEditingIcon = False
        Me.DataHistorial.Size = New System.Drawing.Size(1118, 434)
        Me.DataHistorial.TabIndex = 16
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1507, 655)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelEmpresas)
        Me.Controls.Add(Me.PanelSuperior)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
        CType(Me.PB_EliminaFiltreId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_EliminaFiltre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataEmpreses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelControlHoras.ResumeLayout(False)
        Me.PanelControlHoras.PerformLayout()
        Me.PanelGestio.ResumeLayout(False)
        Me.Panel_RestarHores.ResumeLayout(False)
        Me.Panel_RestarHores.PerformLayout()
        Me.Panel_AfegirHores.ResumeLayout(False)
        Me.Panel_AfegirHores.PerformLayout()
        Me.Panel_ComentarisTransaccio.ResumeLayout(False)
        Me.Panel_ComentarisTransaccio.PerformLayout()
        Me.Panel_AfegirRestarHores.ResumeLayout(False)
        CType(Me.DataHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PanelEmpresas As Panel
    Friend WithEvents PB_EliminaFiltre As PictureBox
    Friend WithEvents TB_CercaEmpreses As TextBox
    Friend WithEvents DataEmpreses As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_DesarObservacions As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TB_ObservacionsCLient As TextBox
    Friend WithEvents Lbl_NomEmpresa As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PB_EliminaFiltreId As PictureBox
    Friend WithEvents TB_CercaId As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelControlHoras As Panel
    Friend WithEvents TB_HoresGastades As TextBox
    Friend WithEvents TB_HoresDegudes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Lbl_HoresDegudes As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_HoresTotals As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_HoresDisponibles As TextBox
    Friend WithEvents PanelGestio As Panel
    Friend WithEvents Panel_RestarHores As Panel
    Friend WithEvents Btn_restarHores As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TB_HoresRestar As TextBox
    Friend WithEvents Panel_AfegirHores As Panel
    Friend WithEvents Btn_AfegirHores As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TB_HoresAfegir As TextBox
    Friend WithEvents TB_Import As TextBox
    Friend WithEvents TB_PreuHora As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel_ComentarisTransaccio As Panel
    Friend WithEvents TB_Comentaris As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel_AfegirRestarHores As Panel
    Friend WithEvents Btn_ObreRestarHores As Button
    Friend WithEvents Btn_ObreAfegirHores As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DataHistorial As DataGridView
    Friend WithEvents Lbl_IdExit As Label
    Friend WithEvents Btn_EditarClient As Button
    Friend WithEvents Btn_EliminarClient As Button
    Friend WithEvents Btn_afegirClient As Button
    Friend WithEvents BT_HistorialComplet As Button
    Friend WithEvents Btn_exportExcel As Button
    Friend WithEvents ExportarCSV As Button
End Class
