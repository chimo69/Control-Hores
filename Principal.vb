Imports System.Data.SQLite
Public Class Principal
    Public taronja As Color = Color.FromArgb(255, 197, 128)
    Public vermell As Color = Color.FromArgb(255, 128, 128)
    Public verd As Color = Color.FromArgb(164, 255, 150)
    Public verdClar As Color = Color.FromArgb(192, 255, 192)
    Public groc As Color = Color.FromArgb(252, 255, 168)
    Public telematic As Color = Color.FromArgb(72, 101, 174)
    Public telematic_oscur As Color = Color.FromArgb(37, 46, 59)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataEmpreses.DataSource = Conexio.CarregaClients()
        DataHistorial.DataSource = Conexio.CarregaHistorial
        ColorejaTransaccions()
        ColorejaClients()
    End Sub

    Private Sub DataEmpreses_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataEmpreses.DataBindingComplete
        Debug.WriteLine("Clientes completado")
        Dim Dgv As DataGridView = sender
        Dgv.Columns("Id").Visible = False
        Dgv.Columns("Observacions").Visible = False
        Dgv.Columns("Hores").Width = 40
        Dgv.Columns("Hores").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Dgv.Columns("IdExit").Width = 50
        Dgv.ClearSelection()
    End Sub

    Private Sub TB_CercaEmpreses_TextChanged(sender As Object, e As EventArgs) Handles TB_CercaEmpreses.TextChanged
        DataEmpreses.DataSource = Conexio.CarregaClients(TB_CercaEmpreses.Text, TB_CercaId.Text)
    End Sub

    Private Sub PB_EliminaFiltre_Click(sender As Object, e As EventArgs) Handles PB_EliminaFiltre.Click
        TB_CercaEmpreses.Clear()
        ResetejaTot()
        DataEmpreses.ClearSelection()
        Lbl_NomEmpresa.Text = ""
        PanelGestio.Visible = False
        PanelControlHoras.Visible = False
    End Sub

    Private Sub DataEmpreses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataEmpreses.CellClick
        SeleccionaEmpresa(DataEmpreses.CurrentRow.Cells("Id").Value)
    End Sub

    Private Sub DataHistorial_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataHistorial.DataBindingComplete
        Dim dgv As DataGridView = sender
        With dgv
            .Columns("IdTransaccio").Visible = False
            .Columns("Client").Visible = False
            .Columns("Data transacció").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Data transacció").Width = 100
            .Columns("Hores").Width = 50
            .Columns("hores").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Preu/Hora").Width = 70
            .Columns("Preu/Hora").DefaultCellStyle.Format = "C"
            .Columns("Preu/Hora").DefaultCellStyle.FormatProvider = New System.Globalization.CultureInfo("es-ES")
            .Columns("Preu/Hora").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Import").DefaultCellStyle.Format = "C"
            .Columns("Import").DefaultCellStyle.FormatProvider = New System.Globalization.CultureInfo("es-ES")
            .Columns("Import").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Import").Width = 70
            .Columns("Id").Width = 50
            '.AutoResizeColumns()
            .ClearSelection()
        End With
    End Sub

    Private Sub ResetejaTot()
        DataHistorial.DataSource = Conexio.CarregaHistorial
        TB_Comentaris.Clear()
        ColorejaTransaccions()
        PanelControlHoras.Visible = False
    End Sub
    Private Sub CalculaHores()
        Dim HoresRestades, HoresSumades, HoresDisponibles As Double
        For Each row As DataGridViewRow In DataHistorial.Rows
            If row.Cells("IdTransaccio").Value = 2 Then
                HoresRestades += row.Cells("Hores").Value

            End If
            If row.Cells("IdTransaccio").Value = 1 Then
                HoresSumades += row.Cells("Hores").Value
            End If
        Next

        HoresDisponibles = HoresSumades + HoresRestades

        TB_HoresGastades.Text = Math.Abs(HoresRestades).ToString
        TB_HoresTotals.Text = HoresSumades.ToString

        If HoresDisponibles < 0 Then
            TB_HoresDegudes.Visible = True
            Lbl_HoresDegudes.Visible = True
            TB_HoresDisponibles.Text = 0
            TB_HoresDegudes.Text = Math.Abs(HoresDisponibles).ToString

        Else
            TB_HoresDegudes.Visible = False
            Lbl_HoresDegudes.Visible = False
            TB_HoresDisponibles.Text = HoresDisponibles.ToString
        End If

    End Sub
    Private Sub ColorejaTransaccions()
        For Each row As DataGridViewRow In DataHistorial.Rows
            If row.Cells("IdTransaccio").Value = 2 Then
                row.Cells("Transacció").Style.BackColor = vermell
            End If
            If row.Cells("IdTransaccio").Value = 1 Then
                row.Cells("Transacció").Style.BackColor = verd
            End If
        Next
    End Sub
    Private Sub ColorejaClients()
        For Each row As DataGridViewRow In DataEmpreses.Rows
            If Not IsDBNull(row.Cells("hores").Value) Then
                If row.Cells("hores").Value < 0 Then
                    row.DefaultCellStyle.BackColor = vermell
                End If
            End If
        Next
    End Sub

    Private Sub Btn_ObreAfegirHores_Click(sender As Object, e As EventArgs) Handles Btn_ObreAfegirHores.Click
        Panel_AfegirHores.Visible = True
        Panel_RestarHores.Visible = False
        Panel_ComentarisTransaccio.Visible = True
    End Sub

    Private Sub Btn_ObreRestarHores_Click(sender As Object, e As EventArgs) Handles Btn_ObreRestarHores.Click
        Panel_RestarHores.Visible = True
        Panel_AfegirHores.Visible = False
        Panel_ComentarisTransaccio.Visible = True
    End Sub

    Public Sub ActualitzaHistorial()
        Dim IdEmpresaSeleccionada = DataEmpreses.CurrentRow.Cells("Id").Value
        DataHistorial.DataSource = CarregaHistorial(IdEmpresaSeleccionada)
        DataEmpreses.DataSource = CarregaClients()

        CalculaHores()
        ColorejaTransaccions()
        ColorejaClients()
        TB_HoresAfegir.Clear()
        TB_Comentaris.Clear()
        TB_HoresRestar.Clear()
        TB_PreuHora.Clear()
        TB_HoresDisponibles.Clear()
        Panel_AfegirHores.Visible = False
        Panel_RestarHores.Visible = False
        Panel_ComentarisTransaccio.Visible = False
    End Sub

    Private Sub Btn_DesarObservacions_Click(sender As Object, e As EventArgs) Handles Btn_DesarObservacions.Click
        If ActualitzaObservacionsClient(DataEmpreses.CurrentRow.Cells("Id").Value, TB_ObservacionsCLient.Text) = True Then
            MsgBox("Observacions actualitzades",, "Actualització de dades")
        Else
            MsgBox("No s'han pogut actualitzar les observacions ",, "Actualització de dades")
        End If
    End Sub

    Private Sub TB_HoresAfegir_TextChanged(sender As Object, e As EventArgs)
        If TB_HoresAfegir.Text = "" Then TB_HoresAfegir.Text = "0"
        Dim valor1 As Double = 0
        Dim valor2 As Double = 0

        If Double.TryParse(TB_HoresAfegir.Text, valor1) AndAlso Double.TryParse(TB_PreuHora.Text, valor2) Then
            Dim resultado As Double = valor1 * valor2
            TB_Import.Text = resultado.ToString()
            'Else
            'TB_Resultat.Text = "Error: el valor introducido no es un número válido."
        End If

    End Sub

    Private Sub TB_PreuHora_TextChanged(sender As Object, e As EventArgs)
        If TB_PreuHora.Text = "" Then TB_PreuHora.Text = "0"
        Dim valor1 As Double = 0
        Dim valor2 As Double = 0

        If Double.TryParse(TB_HoresAfegir.Text, valor1) AndAlso Double.TryParse(TB_PreuHora.Text, valor2) Then
            Dim resultado As Double = valor1 * valor2
            TB_Import.Text = resultado.ToString()
            'Else
            'TB_Resultat.Text = "Error: el valor introducido no es un número válido."
        End If
    End Sub

    Private Sub Btn_AfegirHores_Click(sender As Object, e As EventArgs) Handles Btn_AfegirHores.Click
        If TB_HoresAfegir.Text <> "" Then
            Dim dgv As DataGridView = DataHistorial
            Dim idClient As Integer = DataEmpreses.CurrentRow.Cells("Id").Value
            Dim import As Double = CDbl(TB_Import.Text)
            Dim Comentaris As String = TB_Comentaris.Text
            Dim Hores As Double = CDbl(TB_HoresAfegir.Text)
            Dim PreuHora As Double = CDbl(TB_PreuHora.Text)
            AfegirTransacció(idClient, 1, import, Comentaris, Hores, PreuHora)
            DataHistorial.DataSource = CarregaHistorial(DataEmpreses.CurrentRow.Cells("Id").Value)
            ActualitzaHistorial()
        End If
    End Sub

    Private Sub Btn_restarHores_Click(sender As Object, e As EventArgs) Handles Btn_restarHores.Click
        If TB_HoresRestar.Text <> "" Then
            Dim dgv As DataGridView = DataHistorial
            Dim idClient As Integer = DataEmpreses.CurrentRow.Cells("Id").Value
            Dim Comentaris As String = TB_Comentaris.Text
            Dim Hores As Double = CDbl(TB_HoresRestar.Text) * -1
            AfegirTransacció(idClient, 2, 0, Comentaris, Hores, 0)
            ActualitzaHistorial()
        End If
    End Sub

    Private Sub DataHistorial_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataHistorial.CellMouseClick
        If e.Button = MouseButtons.Right Then
            Dim dgv As DataGridView = DataHistorial
            Dim idEmpresa As Integer = dgv.Rows(e.RowIndex).Cells("Client").Value
            Dim idHistorial As Integer = dgv.Rows(e.RowIndex).Cells("Id").Value
            Dim comentaris As String = dgv.Rows(e.RowIndex).Cells("Observacions").Value
            Dim Hores As Double = dgv.Rows(e.RowIndex).Cells("Hores").Value
            Dim PreuHora As Double = dgv.Rows(e.RowIndex).Cells("Preu/Hora").Value
            Dim Data As Date = dgv.Rows(e.RowIndex).Cells("Data Transacció").Value

            Dim editaRegistre As New EdicioResgistre(idEmpresa, idHistorial, Data, comentaris, Hores, PreuHora)
            editaRegistre.ShowDialog()

        End If
    End Sub
    Public Sub SeleccionaEmpresa(IdEmpresa As Integer)
        For Each row As DataGridViewRow In DataEmpreses.Rows
            If row.Cells("Id").Value = IdEmpresa Then row.Selected = True
        Next

        DataHistorial.DataSource = Conexio.CarregaHistorial(IdEmpresa)
        If Not IsDBNull(DataEmpreses.CurrentRow.Cells("Observacions").Value) Then
            TB_ObservacionsCLient.Text = DataEmpreses.CurrentRow.Cells("Observacions").Value
        Else
            TB_ObservacionsCLient.Text = ""
        End If
        PanelControlHoras.Visible = True
        Lbl_NomEmpresa.Text = DataEmpreses.CurrentRow.Cells("Nom").Value
        If Not IsDBNull(DataEmpreses.CurrentRow.Cells("IdExit").Value) Then
            Lbl_IdExit.Text = DataEmpreses.CurrentRow.Cells("IdExit").Value
        Else
            Lbl_IdExit.Text = ""
        End If
        CalculaHores()
        ColorejaTransaccions()
        PanelGestio.Visible = True
    End Sub

    Private Sub TB_CercaId_TextChanged(sender As Object, e As EventArgs) Handles TB_CercaId.TextChanged
        DataEmpreses.DataSource = Conexio.CarregaClients(TB_CercaEmpreses.Text, TB_CercaId.Text)
    End Sub
End Class
