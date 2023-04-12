Imports System.Data.SQLite
Imports System.Dynamic
Imports System.Linq.Expressions
Imports System.IO
Imports OfficeOpenXml
Imports OfficeOpenXml.Style

Public Class Principal
    Public taronja As Color = Color.FromArgb(255, 197, 128)
    Public vermell As Color = Color.FromArgb(255, 128, 128)
    Public verd As Color = Color.FromArgb(164, 255, 150)
    Public verdClar As Color = Color.FromArgb(192, 255, 192)
    Public groc As Color = Color.FromArgb(252, 255, 168)
    Public telematic As Color = Color.FromArgb(72, 101, 174)
    Public telematic_oscur As Color = Color.FromArgb(37, 46, 59)

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataEmpreses.DataSource = CarregaClients()
        DataHistorial.DataSource = CarregaHistorial()

    End Sub

    Private Sub DataEmpreses_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataEmpreses.DataBindingComplete
        Debug.WriteLine("Clientes completado")
        Dim Dgv As DataGridView = sender
        Dgv.Columns("Id").Visible = False
        Dgv.Columns("Observacions").Visible = False
        Dgv.Columns("Hores").Width = 40
        Dgv.Columns("Hores").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Dgv.Columns("IdExit").Width = 50
        Dgv.Columns("IdExit").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Dgv.ClearSelection()
        ColorejaClients()
    End Sub

    Private Sub TB_CercaEmpreses_TextChanged(sender As Object, e As EventArgs) Handles TB_CercaEmpreses.TextChanged
        DataEmpreses.DataSource = Conexio.CarregaClients(TB_CercaEmpreses.Text, TB_CercaId.Text)
    End Sub

    Private Sub PB_EliminaFiltre_Click(sender As Object, e As EventArgs) Handles PB_EliminaFiltre.Click
        If TB_CercaEmpreses.Text <> "" Then
            TB_CercaEmpreses.Clear()
            DataEmpreses.DataSource = Conexio.CarregaClients(TB_CercaEmpreses.Text, TB_CercaId.Text)
        End If
    End Sub

    Private Sub DataEmpreses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataEmpreses.CellClick
        idClientActual = DataEmpreses.CurrentRow.Cells("Id").Value
        TB_ObservacionsCLient.Enabled = True
        Btn_DesarObservacions.Enabled = True
        SeleccionaEmpresa()
    End Sub

    Private Sub DataHistorial_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataHistorial.DataBindingComplete
        Dim dgv As DataGridView = sender
        With dgv
            .Columns("IdTransaccio").Visible = False
            .Columns("Client").Visible = False
            .Columns("Data transacció").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Data transacció").Width = 100
            .Columns("Usuari").Width = 75
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
            .ClearSelection()
        End With
        ColorejaTransaccions()
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
            row.Cells("Arxiu").Style.ForeColor = Color.Blue
            If row.Cells("Arxiu").Value <> "" Then
                row.Cells("Data transacció").Style.BackColor = Color.LightSkyBlue
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
        If idClientActual <> 0 Then
            DataHistorial.DataSource = CarregaHistorial(idClientActual)
        Else
            DataHistorial.DataSource = CarregaHistorial()
        End If

        ActualitzaClients()

        If idClientActual <> 0 Then
            For Each row As DataGridViewRow In DataEmpreses.Rows
                If row.Cells("Id").Value = idClientActual Then
                    row.Selected = True
                End If
            Next
        End If

        CalculaHores()
        TB_HoresAfegir.Clear()
        TB_Comentaris.Clear()
        TB_HoresRestar.Clear()
        TB_PreuHora.Clear()
        TB_HoresDisponibles.Clear()

        Panel_AfegirHores.Visible = False
        Panel_RestarHores.Visible = False
        Panel_ComentarisTransaccio.Visible = False
    End Sub

    Public Sub ActualitzaClients()
        DataEmpreses.DataSource = CarregaClients()
        ColorejaClients()
    End Sub

    Private Sub Btn_DesarObservacions_Click(sender As Object, e As EventArgs) Handles Btn_DesarObservacions.Click
        If ActualitzaObservacionsClient(idClientActual, TB_ObservacionsCLient.Text) = True Then
            MsgBox("Observacions actualitzades",, "Actualització de dades")
            ActualitzaClients()
        Else
            MsgBox("No s'han pogut actualitzar les observacions ",, "Actualització de dades")
        End If
    End Sub

    Private Sub TB_HoresAfegir_TextChanged(sender As Object, e As EventArgs) Handles TB_HoresAfegir.TextChanged
        ' If TB_HoresAfegir.Text = "" Then TB_HoresAfegir.Text = "0"
        Dim valor1 As Double = 0
        Dim valor2 As Double = 0

        If Double.TryParse(TB_HoresAfegir.Text, valor1) AndAlso Double.TryParse(TB_PreuHora.Text, valor2) Then
            Dim resultado As Double = valor1 * valor2
            TB_Import.Text = resultado.ToString()
        End If

    End Sub

    Private Sub TB_PreuHora_TextChanged(sender As Object, e As EventArgs) Handles TB_PreuHora.TextChanged
        If TB_PreuHora.Text = "" Then TB_PreuHora.Text = "0"
        Dim valor1 As Double = 0
        Dim valor2 As Double = 0

        If Double.TryParse(TB_HoresAfegir.Text, valor1) AndAlso Double.TryParse(TB_PreuHora.Text, valor2) Then
            Dim resultado As Double = valor1 * valor2
            TB_Import.Text = resultado.ToString()

        End If
    End Sub

    Private Sub Btn_AfegirHores_Click(sender As Object, e As EventArgs) Handles Btn_AfegirHores.Click
        'If TB_HoresAfegir.Text <> "" Then
        Dim dgv As DataGridView = DataHistorial
        Dim import As Double
        Dim Comentaris As String = TB_Comentaris.Text
        Dim Hores As Double
        Dim PreuHora As Double
        Dim rutaArxiu As String = ""

        If TB_HoresAfegir.Text = "" Then
            Hores = 0
        Else
            Hores = CDbl(TB_HoresAfegir.Text)
        End If
        If TB_PreuHora.Text = 0 Then
            PreuHora = 0
        Else
            PreuHora = CDbl(TB_PreuHora.Text)
        End If
        If TB_Import.Text = "" Then
            import = 0
        Else
            import = CDbl(TB_Import.Text)
        End If

        Dim result = MsgBox("Vols adjuntar un document?", vbYesNo, "Afegir transacció")
            If result = vbYes Then
                Dim openFileDialog As New OpenFileDialog
                openFileDialog.Filter = "Arxius de text (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*"
                openFileDialog.FilterIndex = 1
                openFileDialog.RestoreDirectory = True

                If openFileDialog.ShowDialog() = DialogResult.OK Then
                    rutaArxiu = openFileDialog.FileName
                End If
            End If
            AfegirTransacció(idClientActual, 1, import, Comentaris, Hores, PreuHora, rutaArxiu)
            guardaResgistreUsuari(usuariActual, "AFEGEIX " & Hores & " HORES A (" & Lbl_NomEmpresa.Text & ")")

        ActualitzaClients()
        ActualitzaHistorial()
        CalculaHores()
            TB_HoresAfegir.Clear()
            TB_Comentaris.Clear()
            TB_HoresRestar.Clear()
            TB_PreuHora.Clear()
            Panel_AfegirHores.Visible = False
            Panel_RestarHores.Visible = False
            Panel_ComentarisTransaccio.Visible = False
        'End If
    End Sub

    Private Sub Btn_restarHores_Click(sender As Object, e As EventArgs) Handles Btn_restarHores.Click
        '        If TB_HoresRestar.Text <> "" Then

        Dim dgv As DataGridView = DataHistorial
        Dim Comentaris As String = TB_Comentaris.Text
        Dim Hores As Double
        Dim rutaArxiu As String = ""

        If TB_HoresRestar.Text = "" Then
            Hores = 0
        Else
            Hores = CDbl(TB_HoresRestar.Text) * -1
        End If

        Dim result = MsgBox("Vols adjuntar un document?", vbYesNo, "Afegir transacció")
        If result = vbYes Then
                Dim openFileDialog As New OpenFileDialog
                openFileDialog.Filter = "Arxius de text (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*"
                openFileDialog.FilterIndex = 1
                openFileDialog.RestoreDirectory = True

                If openFileDialog.ShowDialog() = DialogResult.OK Then
                    rutaArxiu = openFileDialog.FileName
                End If
            End If
            AfegirTransacció(idClientActual, 2, 0, Comentaris, Hores, 0, rutaArxiu)
            guardaResgistreUsuari(usuariActual, "RESTA " & Hores & " HORES A (" & Lbl_NomEmpresa.Text & ")")

            ActualitzaClients()
        ActualitzaHistorial()
        CalculaHores()
        TB_HoresAfegir.Clear()
            TB_Comentaris.Clear()
            TB_HoresRestar.Clear()
            TB_PreuHora.Clear()
            Panel_AfegirHores.Visible = False
            Panel_RestarHores.Visible = False
            Panel_ComentarisTransaccio.Visible = False
        'End If
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
            Dim RutaArxiu As String = dgv.Rows(e.RowIndex).Cells("Arxiu").Value
            Dim tipusTransaccio As Integer = dgv.Rows(e.RowIndex).Cells("IdTransaccio").Value
            Dim editaRegistre As New EdicioResgistre(idEmpresa, idHistorial, Data, comentaris, Hores, PreuHora, RutaArxiu, tipusTransaccio)
            Dim resposta As Boolean = editaRegistre.ShowDialog()
            If resposta = True Then
                ActualitzaClients()
                ActualitzaHistorial()
            End If
        End If
    End Sub
    Public Sub SeleccionaEmpresa()
        Dim rowSelected As DataGridViewRow = Nothing

        For Each row As DataGridViewRow In DataEmpreses.Rows
            If row.Cells("Id").Value = idClientActual Then
                rowSelected = row
            End If
        Next

        DataHistorial.DataSource = Conexio.CarregaHistorial(idClientActual)

        If Not IsDBNull(rowSelected.Cells("Observacions").Value) Then
            TB_ObservacionsCLient.Text = rowSelected.Cells("Observacions").Value
        Else
            TB_ObservacionsCLient.Text = ""
        End If

        PanelControlHoras.Visible = True
        PanelGestio.Visible = True

        Lbl_NomEmpresa.Text = rowSelected.Cells("Nom").Value
        If Not IsDBNull(rowSelected.Cells("IdExit").Value) Then
            Lbl_IdExit.Text = rowSelected.Cells("IdExit").Value
        Else
            Lbl_IdExit.Text = ""
        End If

        CalculaHores()

    End Sub

    Private Sub TB_CercaId_TextChanged(sender As Object, e As EventArgs) Handles TB_CercaId.TextChanged
        DataEmpreses.DataSource = Conexio.CarregaClients(TB_CercaEmpreses.Text, TB_CercaId.Text)
    End Sub

    Private Sub PB_EliminaFiltreId_Click(sender As Object, e As EventArgs) Handles PB_EliminaFiltreId.Click
        If TB_CercaId.Text <> "" Then
            TB_CercaId.Clear()
            DataEmpreses.DataSource = Conexio.CarregaClients(TB_CercaEmpreses.Text, TB_CercaId.Text)
        End If
    End Sub

    Private Sub Btn_afegirClient_Click(sender As Object, e As EventArgs) Handles Btn_afegirClient.Click
        Dim nouClient As Form = New EdicioClient()

        Dim resultat As DialogResult = nouClient.ShowDialog
        If resultat = DialogResult.OK Then
            ActualitzaClients()
        End If
    End Sub

    Private Sub Btn_EliminarClient_Click(sender As Object, e As EventArgs) Handles Btn_EliminarClient.Click
        If DataEmpreses.SelectedRows.Count > 0 Then
            Dim result = MsgBox("Estás segur que vols eliminar aquest client? Això borrarà també els seus registres", vbYesNo, "Atencio!")
            If result = vbYes Then
                If EliminaClient(DataEmpreses.CurrentRow.Cells("Id").Value) = True Then
                    MsgBox("S'ha eliminat amb éxit el client",, "Eliminar registre")
                    guardaResgistreUsuari(usuariActual, "CLIENT (" & DataEmpreses.CurrentRow.Cells("Nom").Value & ") BORRAT")
                    ActualitzaClients()
                    idClientActual = 0
                    ActualitzaHistorial()
                    AmagaPanelGestio()
                Else
                    MsgBox("No s'ha pogut eliminar el client",, "Eliminar registre")
                End If
            Else

            End If
        End If
    End Sub

    Private Sub Btn_EditarClient_Click(sender As Object, e As EventArgs) Handles Btn_EditarClient.Click

        If DataEmpreses.SelectedRows.Count > 0 Then
            Dim id As Integer = DataEmpreses.CurrentRow.Cells("Id").Value
            Dim idExit As String = DataEmpreses.CurrentRow.Cells("IdExit").Value
            Dim nom As String = DataEmpreses.CurrentRow.Cells("Nom").Value
            Dim nouClient As Form = New EdicioClient(id, idExit, nom)
            If nouClient.ShowDialog() = True Then
                ActualitzaClients()
            End If
        End If
    End Sub

    Private Sub BT_HistorialComplet_Click(sender As Object, e As EventArgs) Handles BT_HistorialComplet.Click
        MostraHistorialComplet()
    End Sub

    Public Sub MostraHistorialComplet()
        DataHistorial.DataSource = CarregaHistorial()
        DataEmpreses.ClearSelection()
        PanelGestio.Visible = False
        PanelControlHoras.Visible = False
        Panel_AfegirHores.Visible = False
        Panel_RestarHores.Visible = False
        Lbl_NomEmpresa.Text = ""
        Lbl_IdExit.Text = ""
        TB_ObservacionsCLient.Clear()
        TB_ObservacionsCLient.Enabled = False
        Btn_DesarObservacions.Enabled = False
        idClientActual = 0
    End Sub

    Public Sub AmagaPanelGestio()
        PanelGestio.Visible = False
        PanelControlHoras.Visible = False
        Panel_AfegirHores.Visible = False
        Panel_RestarHores.Visible = False
        idClientActual = 0
    End Sub

    Private Sub ImpedeixLletres(sender As Object, e As KeyPressEventArgs) Handles TB_HoresAfegir.KeyPress, TB_PreuHora.KeyPress, TB_HoresRestar.KeyPress, TB_CercaId.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataHistorial_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataHistorial.CellContentClick
        If e.ColumnIndex = DataHistorial.Columns("Arxiu").Index Then
            Dim ruta As String = DataHistorial.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            If Not String.IsNullOrEmpty(ruta) AndAlso File.Exists(ruta) Then
                Process.Start("Explorer.exe", ruta)
            Else
                MsgBox("No s'ha trobat l'arxiu a la ruta indicada", vbInformation, "Obrir arxiu")
            End If
        End If
    End Sub

    Private Sub Btn_exportExcel_Click(sender As Object, e As EventArgs) Handles Btn_exportExcel.Click
        If Lbl_NomEmpresa.Text = "" Then
            ExportarDadesExcel(DataHistorial, "Historial Complet Pack d'hores")
        Else
            ExportarDadesExcel(DataHistorial, "Historial Pack d'hores ( " & Lbl_NomEmpresa.Text & " )")
        End If

    End Sub


    Public Sub ExportarDadesExcel(ByVal dataGridView As DataGridView, ByVal textEncabezado As String)

        If DataHistorial.RowCount > 0 Then
            Try
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial
                Dim arxiuExcel As New ExcelPackage()

                Dim hoja As ExcelWorksheet = arxiuExcel.Workbook.Worksheets.Add("Pack Hores")

                ' Personalizar el encabezado
                Dim encabezado As ExcelRange = hoja.Cells("A1:" & ConvertToLetter(dataGridView.Columns.Count) & "1")
                encabezado.Merge = True
                encabezado.Value = textEncabezado
                encabezado.Style.Font.Bold = True
                encabezado.Style.Font.Size = 14
                encabezado.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center


                For i As Integer = 0 To dataGridView.Columns.Count - 1
                    hoja.Cells(2, i + 1).Value = dataGridView.Columns(i).HeaderText
                    hoja.Cells(1, i + 1).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                    hoja.Cells(1, i + 1).Style.Fill.BackgroundColor.SetColor(telematic)
                    hoja.Cells(2, i + 1).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                    hoja.Cells(2, i + 1).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                Next

                For i As Integer = 0 To dataGridView.Rows.Count - 1
                    For j As Integer = 0 To dataGridView.Columns.Count - 1
                        hoja.Cells(i + 3, j + 1).Value = dataGridView.Rows(i).Cells(j).Value
                    Next
                Next

                hoja.Cells.AutoFitColumns()

                Dim saveDialog As New SaveFileDialog
                saveDialog.Filter = "Arxius de Excel (*.xlsx)|*.xlsx"
                saveDialog.FilterIndex = 1
                saveDialog.RestoreDirectory = True

                If saveDialog.ShowDialog = DialogResult.OK Then
                    arxiuExcel.SaveAs(saveDialog.FileName)
                    arxiuExcel.Dispose()
                End If

                MsgBox("Arxiu guardat amb éxit",, "Exportar arxiu Excel")
            Catch ex As Exception
                MsgBox("No s'ha pogut exportar l'arxiu",, "Exportar arxiu Excel")
            End Try
        Else
            MsgBox("No hi ha resultats que exportar", vbInformation, "Exportar arxiu Excel")
        End If

    End Sub

    ' Función auxiliar para convertir un número de columna a una letra de columna en Excel
    Private Function ConvertToLetter(ByVal iCol As Integer) As String
        If iCol <= 26 Then
            Return Chr(iCol + 64)
        Else
            Dim iMod As Integer = iCol Mod 26
            Dim iDiv As Integer = iCol \ 26
            If iMod = 0 Then
                iDiv -= 1
                iMod = 26
            End If
            Return ConvertToLetter(iDiv) & ConvertToLetter(iMod)
        End If
    End Function

    Private Sub ExportarCSV_Click(sender As Object, e As EventArgs) Handles ExportarCSV.Click
        ExportarDadesCSV(DataHistorial)
    End Sub
    Public Sub ExportarDadesCSV(ByVal dataGridView As DataGridView)
        If DataHistorial.RowCount > 0 Then
            Try
                Dim csv As String = ""
                ' Encabezados de las columnas
                For Each column As DataGridViewColumn In dataGridView.Columns
                    csv += column.HeaderText & ","
                Next
                csv = csv.Substring(0, csv.Length - 1) & Environment.NewLine

                ' Datos
                For Each row As DataGridViewRow In dataGridView.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        csv += cell.FormattedValue.ToString().Replace(",", ";") & ","
                    Next
                    csv = csv.Substring(0, csv.Length - 1) & Environment.NewLine
                Next

                ' Guardar el archivo
                Dim saveDialog As New SaveFileDialog
                saveDialog.Filter = "Arxius CSV (*.csv)|*.csv"
                saveDialog.FilterIndex = 1
                saveDialog.RestoreDirectory = True

                If saveDialog.ShowDialog = DialogResult.OK Then
                    File.WriteAllText(saveDialog.FileName, csv)
                End If

                MsgBox("Arxiu guardat amb éxit", MsgBoxStyle.Information, "Exportar arxiu CSV")
            Catch ex As Exception
                MsgBox("No s'ha pogut exportar l'arxiu", MsgBoxStyle.Exclamation, "Exportar arxiu CSV")
            End Try
        Else
            MsgBox("No hi ha resultats que exportar", vbInformation, "Exportar arxiu CSV")
        End If

    End Sub

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            guardaResgistreUsuari(usuariActual, "SURT DE L'APLICACIÓ")
            Login.Close()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub PB_TancarSessio_Click(sender As Object, e As EventArgs) Handles PB_TancarSessio.Click
        guardaResgistreUsuari(usuariActual, "LOGOUT")
        usuariActual = ""
        idUsuariActual = 0
        My.Settings.Usuari = ""
        My.Settings.Password = ""
        My.Settings.GuardarCredencials = False
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Principal_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Lbl_usuari.Text = usuariActual
        Debug.WriteLine("Visible usuari actual: " & usuariActual)
    End Sub

    Private Sub PB_LaMevaConta_Click(sender As Object, e As EventArgs) Handles PB_LaMevaConta.Click
        Dim LaMevaConta As New EdicioUsuari()
        LaMevaConta.ShowDialog()
    End Sub

    Private Sub DataEmpreses_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataEmpreses.ColumnHeaderMouseClick
        MostraHistorialComplet()
    End Sub
End Class
