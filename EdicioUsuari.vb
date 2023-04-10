Public Class EdicioUsuari
    Dim mostraPasswordActual As Boolean = False
    Dim mostraPasswordNou As Boolean = False
    Dim mostraPasswordRep As Boolean = False
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Lbl_usuari.Text = usuariActual
        If idTipusUsuari = 0 Then
            Btn_restaurarContrasenyes.Visible = True
            PB_Admin.Visible = True
            PanelDreta.Visible = True
            Me.Width = 868
        Else
            Btn_restaurarContrasenyes.Visible = False
            PanelDreta.Visible = False
            Me.Width = 547
            PB_Admin.Visible = False
        End If

        DataUsuaris.DataSource = CarregaUsuaris()
    End Sub

    Private Sub PB_Mostrapassword1_Click(sender As Object, e As EventArgs) Handles PB_Mostrapassword1.Click
        If mostraPasswordActual = True Then
            mostraPasswordActual = False
            PB_Mostrapassword1.Image = My.Resources.ojocerrado
            TB_passwordActual.UseSystemPasswordChar = True
        Else
            mostraPasswordActual = True
            PB_Mostrapassword1.Image = My.Resources.ojoabierto
            TB_passwordActual.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub TB_MostraPassword2_Click(sender As Object, e As EventArgs) Handles PB_MostraPassword2.Click
        If mostraPasswordNou = True Then
            mostraPasswordNou = False
            PB_MostraPassword2.Image = My.Resources.ojocerrado
            TB_PasswordNou.UseSystemPasswordChar = True
        Else
            mostraPasswordNou = True
            PB_MostraPassword2.Image = My.Resources.ojoabierto
            TB_PasswordNou.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub TB_MostraPassword3_Click(sender As Object, e As EventArgs) Handles PB_MostraPassword3.Click
        If mostraPasswordRep = True Then
            mostraPasswordRep = False
            PB_MostraPassword3.Image = My.Resources.ojocerrado
            TB_RePassword.UseSystemPasswordChar = True
        Else
            mostraPasswordRep = True
            PB_MostraPassword3.Image = My.Resources.ojoabierto
            TB_RePassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Btn_actualitzar_Click(sender As Object, e As EventArgs) Handles Btn_actualitzar.Click

        If TB_PasswordNou.Text = TB_RePassword.Text Then
            If comprobaUsuari(usuariActual, TB_passwordActual.Text) = True Then
                If ActualitzarPassword(idUsuariActual, TB_PasswordNou.Text) = True Then
                    MsgBox("Password actualitzat correctament",, "Actualització de Password")
                    Me.Close()
                Else
                    MsgBox("Hi ha hagut un error actualitzant el password", vbCritical, "Actualització de Password")
                End If
            Else
                MsgBox("El password no es correcte", vbCritical, "Actualització de Password")
                TB_passwordActual.Focus()
            End If
        Else
            MsgBox("Els passwords no coincideixen", vbCritical, "Actualització de Password")
            TB_RePassword.Focus()
        End If


    End Sub

    Private Sub Btn_restaurarContrasenyes_Click(sender As Object, e As EventArgs) Handles Btn_restaurarContrasenyes.Click
        Dim idUsuari = DataUsuaris.CurrentRow.Cells("id").Value
        If ActualitzarPassword(idUsuari, TB_NouPassword.Text) = True Then
            MsgBox("Password actualitzat correctament",, "Actualització de Password")
        Else
            MsgBox("Hi ha hagut un error actualitzant el password", vbCritical, "Actualització de Password")
        End If
    End Sub


End Class