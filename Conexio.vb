Imports System.Data.SQLite
Imports System.Security.Cryptography
Imports System.Text

Module Conexio
    Public cadena As String = "Data Source=" & Application.StartupPath & "\DBControlHores.db;Version=3;UseUTF8Encoding=True;"
    Public controlHores As Form = New Principal
    Public usuariActual As String
    Public idClientActual As Integer
    Public idUsuariActual As Integer
    Public idTipusUsuari As Integer


    Public Function comprobaUsuari(usuari As String, password As String) As Boolean

        Dim hashString As String = ""
        Using sha256 As SHA256 = SHA256.Create()
            Dim hashBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            hashString = Convert.ToBase64String(hashBytes)
        End Using

        Dim resultat As Boolean = False
        Using conexio As New SQLiteConnection(cadena)
            conexio.Open()
            Dim consulta As String = "SELECT id, Tipus FROM Usuaris WHERE Usuari=@usuari AND Password=@password"
            Using CMD As New SQLiteCommand(consulta, conexio)
                CMD.Parameters.Add("@usuari", DbType.String).Value = usuari
                CMD.Parameters.Add("@password", DbType.String).Value = hashString
                Using reader As SQLiteDataReader = CMD.ExecuteReader()
                    If reader.Read() Then
                        idTipusUsuari = reader.GetValue(1)
                        idUsuariActual = reader.GetValue(0)
                        resultat = True
                    End If
                End Using
            End Using
        End Using

        If resultat = True Then
            guardaResgistreUsuari(usuari, "LOGIN")
            Return True
        Else
            guardaResgistreUsuari(usuari, "ERROR D'ACCES")
            Return False
        End If

    End Function


    Public Sub guardaResgistreUsuari(Usuari As String, Accio As String)
        Try
            Using conexio As New SQLiteConnection(cadena)
                conexio.Open()
                Dim Query As String = "INSERT INTO Registre_usuaris (Usuari,Event,Data) VALUES (@usuari, @accio, @data) "
                Dim CMD As New SQLiteCommand(Query, conexio)
                CMD.Parameters.AddWithValue("@usuari", Usuari)
                CMD.Parameters.AddWithValue("@accio", Accio)
                CMD.Parameters.AddWithValue("@data", DateTime.Now)
                CMD.ExecuteNonQuery()

            End Using
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub


    Public Sub CreaBaseDades()

        Try
            Using conexio As New SQLiteConnection(cadena)

                conexio.Open()

                Using CMD As New SQLiteCommand(cadena, conexio)

                    CMD.CommandText = "CREATE TABLE IF NOT EXISTS Clients (
                                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                 Nom TEXT NOT NULL,
                                 Observacions TEXT,
                                 IdExit TEXT NOT NULL UNIQUE);

                           CREATE TABLE IF NOT EXISTS Historial (
                                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                 Usuari TEXT NOT NULL,
                                 Client INTEGER NOT NULL,
                                 Transaccio INTEGER NOT NULL,
                                 Data TEXT NOT NULL DEFAULT '',
                                 Hores REAL NOT NULL DEFAULT 0,
                                 PreuHora REAL NOT NULL DEFAULT 0,
                                 Import REAL NOT NULL DEFAULT 0,
                                 Arxiu TEXT,
                                 Observacions TEXT,
                                 FOREIGN KEY(Client) REFERENCES Clients(Id) ON DELETE CASCADE);

                           CREATE TABLE IF NOT EXISTS Transaccions (
                                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                 Nom TEXT);

                           CREATE TABLE IF NOT EXISTS Registre_usuaris (
	                             Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                             Usuari TEXT NOT NULL,
	                             Event TEXT NOT NULL,
	                             Data TEXT NOT NULL);

                           CREATE TABLE IF NOT EXISTS Usuaris (
	                             Id	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                             Usuari	TEXT NOT NULL,
	                             Password TEXT NOT NULL,
	                             Tipus INTEGER NOT NULL DEFAULT 0);"

                    CMD.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error obrint o creant la base de dades", vbCritical, "Error fatal")
            Application.Exit()
        End Try



    End Sub

    Public Function CarregaClients() As DataTable
        Dim DT As New DataTable

        Dim Query As String = "SELECT printf('%05d',Clients.IdExit) as IdExit,
                                      Clients.Id,
                                      Clients.Nom,
                                      Clients.Observacions,                                      
                                      SUM(Historial.hores) as Hores
                               FROM Clients
                               LEFT JOIN Historial ON Clients.ID = Historial.Client
                               GROUP BY Clients.ID;"

        Using conexio As New SQLiteConnection(cadena)
            conexio.Open()

            Using CMD As New SQLiteCommand(Query, conexio)
                Using DA As New SQLiteDataAdapter(CMD)
                    DA.Fill(DT)
                    Debug.WriteLine("Actualitzant clients")
                End Using
            End Using
        End Using

        Return DT
    End Function
    Public Function CarregaClients(Text As String, idBuscar As String) As DataTable
        Dim DT As New DataTable

        Dim Query As String = "SELECT printf('%05d',Clients.IdExit) as IdExit,
                                      Clients.Id,
                                      Clients.Nom,
                                      Clients.Observacions,                                      
                                      SUM(Historial.hores) as Hores
                               FROM Clients
                               LEFT JOIN Historial ON Clients.ID = Historial.Client
                               WHERE Clients.Nom LIKE '%' || @textBuscar || '%' AND Clients.IdExit LIKE '%' || @idBuscar || '%'
                               GROUP BY Clients.ID "

        Using conexio As New SQLiteConnection(cadena)
            conexio.Open()
            Using CMD As New SQLiteCommand(Query, conexio)
                CMD.Parameters.AddWithValue("@textBuscar", Text)
                CMD.Parameters.AddWithValue("@idBuscar", idBuscar)
                Using DA As New SQLiteDataAdapter(CMD)
                    DA.Fill(DT)
                End Using
            End Using
        End Using

        Return DT

    End Function
    Public Function CarregaHistorial() As DataTable
        Dim DT As New DataTable
        Dim Query As String = "Select Historial.Id,
                                      Historial.client,
                                      Historial.Usuari,  
                                      Strftime('%d-%m-%Y  %H:%M' , Historial.Data) as 'Data transacció',
                                      Clients.Nom,                        
                                      Transaccions.id as idTransaccio,
                                      Transaccions.Nom as 'Transacció',
                                      Historial.Hores,
                                      Historial.PreuHora as 'Preu/Hora',
                                      Historial.Import,
                                      Historial.Arxiu,
                                      Historial.Observacions
                                      FROM Historial
                                      INNER JOIN Transaccions on Transaccions.id = Historial.Transaccio
					                  INNER JOIN Clients on Clients.id = Historial.Client
                                      ORDER BY Historial.Data DESC"
        Using conexio As New SQLiteConnection(cadena)
            conexio.Open()
            Using CMD As New SQLiteCommand(Query, conexio)
                Using DA As New SQLiteDataAdapter(CMD)
                    DA.Fill(DT)
                End Using
            End Using
        End Using

        Return DT
    End Function
    Public Function CarregaHistorial(IdEmpresa As Integer) As DataTable
        Dim DT As New DataTable
        Dim Query As String = "Select Historial.Id,
                               Historial.Client,
                               Historial.Usuari,  
                               Strftime('%d-%m-%Y  %H:%M', Historial.Data) as 'Data transacció',
                               Clients.Nom,
                               Transaccions.id as idTransaccio,
                               Transaccions.Nom as 'Transacció',
                               Historial.Hores,
                               Historial.PreuHora as 'Preu/hora',
                               Historial.Import,
                               Historial.Arxiu,
                               Historial.Observacions
                               FROM Historial
                               INNER JOIN Transaccions on Transaccions.id = Historial.Transaccio
					           INNER JOIN Clients on Clients.id = Historial.Client
                               WHERE Historial.Client= @IdEmpresa
                               ORDER BY Historial.Data DESC"
        Using conexio As New SQLiteConnection(cadena)
            conexio.Open()
            Using CMD As New SQLiteCommand(Query, conexio)
                CMD.Parameters.AddWithValue("@IdEmpresa", IdEmpresa)
                Using DA As New SQLiteDataAdapter(CMD)
                    DA.Fill(DT)
                End Using
            End Using
        End Using
        Return DT
    End Function

    Public Function AfegirTransacció(IdClient As Integer, TipusTransaccio As Integer, Import As Double, Observacions As String, Hores As Double, PreuHora As Double, RutaArxiu As String) As Boolean
        Dim Query As String = "INSERT INTO Historial (Usuari, Client, Transaccio, Data, Hores, PreuHora, Import, Arxiu, Observacions) VALUES (@Usuari,@IdClient, @Transaccio, @Data, @Hores, @PreuHora, @Import, @RutaArxiu,@Observacions)"

        Try
            Using conexio As New SQLiteConnection(cadena)
                conexio.Open()

                Using cmd As New SQLiteCommand(Query, conexio)
                    With cmd
                        .Parameters.AddWithValue("@IdClient", IdClient)
                        .Parameters.AddWithValue("@Transaccio", TipusTransaccio)
                        .Parameters.AddWithValue("@Import", Import)
                        .Parameters.AddWithValue("@Observacions", Observacions)
                        .Parameters.AddWithValue("@Hores", Hores)
                        .Parameters.AddWithValue("@Data", Date.Now)
                        .Parameters.AddWithValue("@PreuHora", PreuHora)
                        .Parameters.AddWithValue("@RutaArxiu", RutaArxiu)
                        .Parameters.AddWithValue("@Usuari", usuariActual)
                    End With

                    cmd.ExecuteNonQuery()
                End Using

            End Using

            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try

    End Function

    Public Function ActualitzaObservacionsClient(IdClient As Integer, Observacions As String) As Boolean
        Dim Query As String = "UPDATE Clients SET Observacions= @observacions WHERE ID=@idclient"

        Try
            Using conexio As New SQLiteConnection(cadena)
                conexio.Open()
                Using CMD As New SQLiteCommand(Query, conexio)
                    CMD.Parameters.AddWithValue("@observacions", Observacions)
                    CMD.Parameters.AddWithValue("@idclient", IdClient)
                    CMD.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function EliminaRegistre(idRegistre As Integer) As Boolean
        Dim Query As String = "DELETE FROM Historial WHERE ID=@IdRegistre"

        Try
            Using conexio As New SQLiteConnection(cadena)
                conexio.Open()
                Using CMD As New SQLiteCommand(Query, conexio)
                    CMD.Parameters.AddWithValue("@IdRegistre", idRegistre)
                    CMD.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function ActualitzaRegistre(idRegistre As Integer, Data As Date, Hores As Double, PreuHora As Double, Import As Double, Observacions As String, RutaArxiu As String) As Boolean
        Dim Query As String = "UPDATE Historial SET Data=@Data, Hores=@Hores, PreuHora=@PreuHora, Import=@Import, Arxiu=@RutaArxiu,Observacions=@Observacions WHERE ID=@IdRegistre"

        Try
            Using conexio As New SQLiteConnection(cadena)
                conexio.Open()
                Using CMD As New SQLiteCommand(Query, conexio)
                    With CMD
                        .Parameters.AddWithValue("@IdRegistre", idRegistre)
                        .Parameters.AddWithValue("@Data", Data)
                        .Parameters.AddWithValue("@Hores", Hores)
                        .Parameters.AddWithValue("@Import", Import)
                        .Parameters.AddWithValue("@Observacions", Observacions)
                        .Parameters.AddWithValue("@PreuHora", PreuHora)
                        .Parameters.AddWithValue("@RutaArxiu", RutaArxiu)
                    End With
                    CMD.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function EliminaClient(idClient As Integer) As Boolean
        Dim Query As String = "DELETE FROM Clients WHERE ID=@IdClient"

        Try
            Using conexio As New SQLiteConnection(cadena)
                conexio.Open()
                Using CMD As New SQLiteCommand(Query, conexio)
                    CMD.Parameters.AddWithValue("@IdClient", idClient)
                    CMD.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function AfegirClient(RaoSocial As String, IdExit As String) As Boolean
        Dim Query As String = "INSERT INTO Clients (Nom, IdExit) VALUES (@RaoSocial,@IdExit)"

        Try
            Using conexio As New SQLiteConnection(cadena)
                conexio.Open()
                Using CMD As New SQLiteCommand(Query, conexio)
                    With CMD
                        .Parameters.AddWithValue("@RaoSocial", RaoSocial)
                        .Parameters.AddWithValue("@IdExit", IdExit)
                    End With
                    CMD.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try

    End Function

    Public Function ActualitzarClient(Id As Integer, nom As String, IdExit As String) As Boolean
        Dim Query As String = "UPDATE Clients SET nom=@Nom, IdExit=@IdExit WHERE Id= @Id"

        Try
            Using conexio As New SQLiteConnection(cadena)
                conexio.Open()
                Using CMD As New SQLiteCommand(Query, conexio)
                    With CMD
                        .Parameters.AddWithValue("@nom", nom)
                        .Parameters.AddWithValue("@IdExit", IdExit)
                        .Parameters.AddWithValue("@Id", Id)
                    End With

                    CMD.ExecuteNonQuery()

                End Using
            End Using

            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try

    End Function

    Public Function ActualitzarPassword(IdUsuari As Integer, Password As String) As Boolean

        Dim Query As String = "UPDATE Usuaris SET Password=@password WHERE Id= @IdUsuari"
        Dim sha256 As SHA256 = SHA256.Create
        Dim hashBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(Password))
        Dim hashstring As String = Convert.ToBase64String(hashBytes)

        Try
            Using conexio As New SQLiteConnection(cadena)
                conexio.Open()
                Using CMD As New SQLiteCommand(Query, conexio)
                    With CMD
                        .Parameters.AddWithValue("@password", hashstring)
                        .Parameters.AddWithValue("@IdUsuari", IdUsuari)
                    End With
                    CMD.ExecuteNonQuery()
                End Using
            End Using

            Return True

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try

    End Function

    Public Function CarregaUsuaris() As DataTable
        Dim DT As New DataTable
        Dim Query As String = "SELECT Id,Usuari FROM Usuaris "
        Using conexio As New SQLiteConnection(cadena)
            conexio.Open()
            Using CMD As New SQLiteCommand(Query, conexio)
                Using DA As New SQLiteDataAdapter(CMD)
                    DA.Fill(DT)
                End Using
            End Using
        End Using
        Return DT
    End Function
    Public Function GenerarContrasenaSegura() As String
        Dim caracteresPermitidos As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_-+={}[]|\:;""'<>,.?/"
        Dim longitudContrasena As Integer = 12
        Dim random As New Random()
        Dim contrasena As String = New String(Enumerable.Repeat(caracteresPermitidos, longitudContrasena).Select(Function(s) s(random.Next(s.Length))).ToArray())
        Return contrasena
    End Function


End Module
