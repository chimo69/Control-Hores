Public Class EdicioClient
    Private id As Object
    Private idExit As String
    Private nom As String
    Private Origen As Integer
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Lbl_tipusEdicio.Text = "Nou Client"
        Origen = 0
    End Sub

    Public Sub New(id As Integer, idExit As String, nom As String)
        InitializeComponent()
        Me.id = id
        Me.idExit = idExit
        Me.nom = nom
        Lbl_tipusEdicio.Text = "Editant Client"
        TB_IdExit.Text = idExit
        TB_RaoSocial.Text = nom
        Origen = 1
    End Sub

    Private Sub Btn_Desar_Click(sender As Object, e As EventArgs) Handles Btn_Desar.Click
        If Origen = 0 Then
            If AfegirClient(TB_RaoSocial.Text, TB_IdExit.Text) = True Then
                Me.Close()
                MsgBox("Client afegit amb éxit",, "Edició client")
                Principal.MostraTotComplet()
            Else
                MsgBox("No s'ha pogut afegir al client ",, "Edició client")
            End If

        Else
            If ActualitzarClient(id, TB_RaoSocial.Text, TB_IdExit.Text) = True Then
                Me.Close()
                MsgBox("Client modificat amb éxit",, "Edició client")
                Principal.MostraTotComplet()
            Else
                MsgBox("No s'ha pogut modificar el client ",, "Edició client")
            End If

        End If
    End Sub
    Private Sub ImpedeixLletres(sender As Object, e As KeyPressEventArgs) Handles TB_IdExit.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class