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

        TB_Hores.Text = Math.Abs(hores)
        TB_Observacions.Text = comentaris
        TP_DataRegistre.Value = dataRegistre
        TB_Arxiu.Text = rutaArxiu

        If tipusTransaccio = 1 Then
            TB_PreuHora.Text = Math.Abs(preuHora).ToString
            TB_Import.Text = (hores * preuHora).ToString
        End If
        If tipusTransaccio = 2 Then
            TB_PreuHora.Enabled = False
            TB_PreuHora.Text = "0"
            TB_Import.Text = "0"
        End If
    End Sub

    Private Sub Btn_EliminaRegistre_Click(sender As Object, e As EventArgs) Handles Btn_EliminaRegistre.Click
        Dim result = MsgBox("Estás segur que vols eliminar aquest registre?", vbYesNo, "Atencio!")

        If result = vbYes Then
            If EliminaRegistre(idHistorial) = True Then
                MsgBox("S'ha eliminat amb éxit el registre",, "Eliminar registre")
                Principal.SeleccionaEmpresa(idEmpresa)
                Me.Close()
            Else
                MsgBox("No s'ha pogut eliminar el registre",, "Eliminar registre")
                Me.Close()
            End If
        Else

        End If

    End Sub

    Private Sub Btn_ActualitzaRegistre_Click(sender As Object, e As EventArgs) Handles Btn_ActualitzaRegistre.Click
        Dim Hores As Double = CDbl(TB_Hores.Text)
        Dim PreuHora As Double = CDbl(TB_PreuHora.Text)
        Dim Data As Date = TP_DataRegistre.Value
        Dim Import As Double = CDbl(TB_Import.Text)
        Dim Observacions As String = TB_Observacions.Text
        Dim RutaArxiu As String = TB_Arxiu.Text

        If ActualitzaRegistre(idHistorial, Data, Hores, PreuHora, Import, Observacions, rutaArxiu) = True Then
            MsgBox("S'ha actualitzat amb éxit el registre",, "Actualitzar registre")
            Principal.SeleccionaEmpresa(idEmpresa)
            Me.Close()
        Else
            MsgBox("No s'ha pogut eliminar el registre",, "Actualitzar registre")
            Me.Close()
        End If
    End Sub

    Private Sub TB_Hores_TextChanged(sender As Object, e As EventArgs) Handles TB_Hores.TextChanged
        If TB_Hores.Text = "" Then TB_Hores.Text = "0"
        Dim valor1 As Double = 0
        Dim valor2 As Double = 0

        If Double.TryParse(TB_Hores.Text, valor1) AndAlso Double.TryParse(TB_PreuHora.Text, valor2) Then
            Dim resultado As Double = valor1 * valor2
            TB_Import.Text = resultado.ToString()
        End If
    End Sub

    Private Sub TB_PreuHora_TextChanged(sender As Object, e As EventArgs) Handles TB_PreuHora.TextChanged
        If TB_PreuHora.Text = "" Then TB_PreuHora.Text = "0"
        Dim valor1 As Double = 0
        Dim valor2 As Double = 0

        If Double.TryParse(TB_Hores.Text, valor1) AndAlso Double.TryParse(TB_PreuHora.Text, valor2) Then
            Dim resultado As Double = valor1 * valor2
            TB_Import.Text = resultado.ToString()
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
End Class