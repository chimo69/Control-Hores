Public Class EdicioResgistre
    Private idHistorial As Integer
    Private comentaris As String
    Private hores As Double
    Private preuHora As Double
    Private dataRegistre As Date

    Public Sub New(idTransaccio As Integer, dataRegistre As Date, comentaris As String, hores As Double, preuHora As Double)
        InitializeComponent()
        Me.idHistorial = idTransaccio
        Me.comentaris = comentaris
        Me.hores = hores
        Me.preuHora = preuHora
        Me.dataRegistre = dataRegistre
    End Sub


    Private Sub EdicioResgistre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_Hores.Text = hores
        TB_PreuHora.Text = preuHora.ToString
        TB_Import.Text = (hores * preuHora).ToString
        TB_Observacions.Text = comentaris
        Data.Value = dataRegistre
    End Sub

    Private Sub Btn_EliminaRegistre_Click(sender As Object, e As EventArgs) Handles Btn_EliminaRegistre.Click
        Dim result = MsgBox("Estás segur que vols eliminar aquest registre?", vbYesNo, "Atencio!")

        If result = vbYes Then
            If EliminaRegistre(idHistorial) = True Then
                MsgBox("S'ha eliminat amb éxit el registre",, "Eliminar registre")
                Principal.ActualitzaHistorial()
                Me.Close()
            Else
                MsgBox("No s'ha pogut eliminar el registre",, "Eliminar registre")
                Me.Close()
            End If
        Else

        End If

    End Sub

    Private Sub Btn_ActualitzaRegistre_Click(sender As Object, e As EventArgs) Handles Btn_ActualitzaRegistre.Click

    End Sub
End Class