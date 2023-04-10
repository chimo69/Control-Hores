Imports System.Drawing.Text
Imports System.Runtime.InteropServices

Public Class Login
    Private mostraPassword As Boolean = False
    Private usuari As String
    Private password As String
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub
    Private Sub PB_Mostrapassword_Click(sender As Object, e As EventArgs) Handles PB_Mostrapassword.Click
        If mostraPassword = True Then
            mostraPassword = False
            PB_Mostrapassword.Image = My.Resources.ojocerrado
            TB_Password.UseSystemPasswordChar = True
        Else
            mostraPassword = True
            PB_Mostrapassword.Image = My.Resources.ojoabierto
            TB_Password.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        femLogin()
    End Sub

    Private Sub TB_Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_Password.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            femLogin()
            e.Handled = True ' Evita que el Enter se escriba en el TextBox
        End If
    End Sub

    Private Sub femLogin()

        If comprobaUsuari(TB_Usuari.Text, TB_Password.Text) = True Then
            usuariActual = TB_Usuari.Text
            Debug.WriteLine("Usuari: " & usuariActual)
            If CB_GuardarCredencials.Checked = True Then
                My.Settings.Usuari = TB_Usuari.Text
                My.Settings.Password = TB_Password.Text
                My.Settings.GuardarCredencials = True
            Else
                My.Settings.Usuari = ""
                My.Settings.Password = ""
                My.Settings.GuardarCredencials = False
            End If

            controlHores.Show()
            Me.Hide()
        Else
            MsgBox("Usuario o password incorrectes", vbCritical, "Error d'accés")
        End If

    End Sub

    Private Sub Login_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        TB_Usuari.Text = My.Settings.Usuari
        TB_Password.Text = My.Settings.Password
        CB_GuardarCredencials.Checked = My.Settings.GuardarCredencials
        mostraPassword = False
        PB_Mostrapassword.Image = My.Resources.ojocerrado
        TB_Password.UseSystemPasswordChar = True
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreaBaseDades()
    End Sub

    Private Sub Btn_tancar_Click(sender As Object, e As EventArgs) Handles Btn_tancar.Click
        Me.Close()
    End Sub

    Private Sub Panel_Login_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove, Panel2.MouseMove, Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class