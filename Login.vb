Imports System.Drawing.Text

Public Class Login
    Private mostraPassword As Boolean = False
    Private usuari As String
    Private password As String
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ' comprobaCredencials()
    End Sub
    Private Sub comprobaCredencials()
        usuari = My.Settings.Usuari
        password = My.Settings.Password

        If My.Settings.GuardarCredencials = True Then
            If comprobaUsuari(usuari, password) = True Then
                Dim controlHores As Form = New Principal
                controlHores.Show()
                Me.Hide()
            End If
        End If
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

        If comprobaUsuari(TB_Usuari.Text, TB_Password.Text) = True Then

            If CB_GuardarCredencials.Checked = True Then
                My.Settings.Usuari = TB_Usuari.Text
                My.Settings.Password = TB_Password.Text
                My.Settings.Save()
            End If

            Dim controlHores As Form = New Principal
            controlHores.Show()
            Me.Hide()
        Else
            MsgBox("Usuari o contrasenya incorrectes", vbCritical, "Login")
        End If
    End Sub

    Private Sub CB_GuardarCredencials_CheckedChanged(sender As Object, e As EventArgs) Handles CB_GuardarCredencials.CheckedChanged
        My.Settings.GuardarCredencials = CB_GuardarCredencials.Checked
    End Sub

End Class