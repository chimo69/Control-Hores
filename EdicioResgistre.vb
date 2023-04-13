Public Class EdicioResgistre
    Private idHistorial As Integer
    Private comentaris As String
    Private hores As Double
    Private preuHora As Double
    Private dataRegistre As Date
    Private idEmpresa As Integer
    Private rutaArxiu As String
    Private tipusTransaccio As Integer

    Public Sub New(idEmpresa As Integer, idTransaccio As Integer, dataRegistre As Date, comentaris As String, hores As Double, preuHora As Double, rutaArxiu As String, tipusTransaccio As Integer)
        InitializeComponent()
        Me.idEmpresa = idEmpresa
        Me.idHistorial = idTransaccio
        Me.comentaris = comentaris
        Me.hores = hores
        Me.preuHora = preuHora
        Me.dataRegistre = dataRegistre
        Me.rutaArxiu = rutaArxiu
        Me.tipusTransaccio = tipusTransaccio
    End Sub


    Private Sub EdicioResgistre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TB_Hores.Text = Math.Abs(hores).ToString("F2")
        TB_Observacions.Text = comentaris
        TP_DataRegistre.Value = dataRegistre
        TB_Arxiu.Text = rutaArxiu

        If tipusTransaccio = 1 Then
            TB_PreuHora.Text = Math.Abs(preuHora).ToString("F2")
            TB_Import.Text = (hores * preuHora).ToString("F2")
            PanelTipusTransaccio.BackColor = verd
            Lbl_TipusTransaccio.Text = "Afegir Hores"
        End If
        If tipusTransaccio = 2 Then
            TB_PreuHora.Enabled = False
            TB_PreuHora.Text = "0"
            TB_Import.Text = "0"
            PanelTipusTransaccio.BackColor = vermell
            Lbl_TipusTransaccio.Text = "Restar Hores"
        End If
    End Sub

    Private Sub Btn_EliminaRegistre_Click(sender As Object, e As EventArgs) Handles Btn_EliminaRegistre.Click
        Dim result = MsgBox("Estás segur que vols eliminar aquest registre?", vbYesNo, "Atencio!")

        If result = vbYes Then
            If EliminaRegistre(idHistorial) = True Then
                MsgBox("S'ha eliminat amb éxit el registre",, "Eliminar registre")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox("No s'ha pogut eliminar el registre",, "Eliminar registre")
                Me.DialogResult = DialogResult.None
                Me.Close()
            End If
        Else

        End If

    End Sub

    Private Sub Btn_ActualitzaRegistre_Click(sender As Object, e As EventArgs) Handles Btn_ActualitzaRegistre.Click
        Dim Hores As Double = CDbl(TB_Hores.Text) * (-1)
        Dim PreuHora As Double = CDbl(TB_PreuHora.Text)
        Dim Data As Date = TP_DataRegistre.Value
        Dim Import As Double = CDbl(TB_Import.Text)
        Dim Observacions As String = TB_Observacions.Text
        Dim RutaArxiu As String = TB_Arxiu.Text

        If TB_Hores.Text = "" Then
            Hores = 0
        Else
            If tipusTransaccio = 2 Then
                Hores = CDbl(TB_Hores.Text) * -1
            Else
                Hores = CDbl(TB_Hores.Text)
            End If
        End If

        If TB_PreuHora.Text = 0 Then
            PreuHora = 0
        Else
            PreuHora = CDbl(TB_PreuHora.Text)
        End If
        If TB_Import.Text = "" Then
            Import = 0
        Else
            Import = CDbl(TB_Import.Text)
        End If

        If ActualitzaRegistre(idHistorial, Data, Hores, PreuHora, Import, Observacions, RutaArxiu) = True Then
            MsgBox("S'ha actualitzat amb éxit el registre",, "Actualitzar registre")
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MsgBox("No s'ha pogut eliminar el registre",, "Actualitzar registre")
            Me.DialogResult = DialogResult.No
            Me.Close()
        End If
    End Sub

    Private Sub TB_Hores_TextChanged(sender As Object, e As EventArgs) Handles TB_Hores.TextChanged

        Dim valor1 As Double = 0
        Dim valor2 As Double = 0

        If Double.TryParse(TB_Hores.Text, valor1) AndAlso Double.TryParse(TB_PreuHora.Text, valor2) Then
            Dim resultado As Double = valor1 * valor2
            TB_Import.Text = resultado.ToString("F2")
        End If
    End Sub

    Private Sub TB_PreuHora_TextChanged(sender As Object, e As EventArgs) Handles TB_PreuHora.TextChanged

        Dim valor1 As Double = 0
        Dim valor2 As Double = 0

        If Double.TryParse(TB_Hores.Text, valor1) AndAlso Double.TryParse(TB_PreuHora.Text, valor2) Then
            Dim resultado As Double = valor1 * valor2
            TB_Import.Text = resultado.ToString("F2")
        End If
    End Sub
    Private Sub ImpedeixLletres(sender As Object, e As KeyPressEventArgs) Handles TB_Hores.KeyPress, TB_PreuHora.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Btn_BorrarRuta_Click(sender As Object, e As EventArgs) Handles Btn_BorrarRuta.Click
        TB_Arxiu.Clear()
    End Sub

    Private Sub Btn_EditarRuta_Click(sender As Object, e As EventArgs) Handles Btn_EditarRuta.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Arxius de text (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            TB_Arxiu.Text = openFileDialog.FileName
        End If
    End Sub

    Private Sub TB_Hores_Leave(sender As Object, e As EventArgs) Handles TB_Hores.Leave
        If TB_Hores.Text = "" Then TB_Hores.Text = "0"
    End Sub

    Private Sub TB_PreuHora_Leave(sender As Object, e As EventArgs) Handles TB_PreuHora.Leave
        If TB_PreuHora.Text = "" Then TB_PreuHora.Text = "0"
    End Sub

    Private Sub EdicioResgistre_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.DialogResult = DialogResult.No
    End Sub
End Class