
Imports System.Collections.ObjectModel
Imports System.Data.SQLite
Imports System.Net.Sockets

Module Conexio
    Public cadena As String = "Data Source=" & Application.StartupPath & "\Database\DBControlHores.db;Version=3;UseUTF8Encoding=True;"
    Public conexion As New SQLiteConnection(cadena)

    Public Function CreaBaseDades()
        conexion.Open()
        Dim CMD As New SQLiteCommand(cadena)
        Dim createDatabaseCommand As New SQLiteCommand("CREATE DATABASE IF NOT EXISTS mydatabase", conexion)
        createDatabaseCommand.ExecuteNonQuery()
        conexion.Close()
    End Function
    Public Function CarregaClients()
        Dim DT As New DataTable
        Dim Query As String = "SELECT printf('%05d',Clients.IdExit) as IdExit,
                                      Clients.Id,
                                      Clients.Nom,
                                      Clients.Observacions,                                      
                                      SUM(Historial.hores) as Hores
                               FROM Clients
                               LEFT JOIN Historial ON Clients.ID = Historial.Client
                               GROUP BY Clients.ID"
        Dim CMD As New SQLiteCommand(Query, conexion)
        Dim DA As New SQLiteDataAdapter(CMD)
        DA.Fill(DT)
        conexion.Close()
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

        Dim CMD As New SQLiteCommand(Query, conexion)
        CMD.Parameters.AddWithValue("@textBuscar", Text)
        CMD.Parameters.AddWithValue("@idBuscar", idBuscar)
        Dim DA As New SQLiteDataAdapter(CMD)
        DA.Fill(DT)
        conexion.Close()
        Return DT

    End Function
    Public Function CarregaHistorial() As DataTable
        Dim DT As New DataTable
        Dim Query As String = "Select Historial.Id,
                                      Historial.client,
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
        Dim CMD As New SQLiteCommand(Query, conexion)
        Dim DA As New SQLiteDataAdapter(CMD)
        DA.Fill(DT)
        conexion.Close()
        Return DT
    End Function
    Public Function CarregaHistorial(IdEmpresa As Integer) As DataTable
        Dim DT As New DataTable
        Dim Query As String = "Select Historial.Id,
                               Historial.Client,
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
        Dim CMD As New SQLiteCommand(Query, conexion)
        CMD.Parameters.AddWithValue("@IdEmpresa", IdEmpresa)
        Dim DA As New SQLiteDataAdapter(CMD)
        DA.Fill(DT)
        conexion.Close()
        Return DT
    End Function

    Public Function AfegirTransacció(IdClient As Integer, TipusTransaccio As Integer, Import As Double, Observacions As String, Hores As Double, PreuHora As Double, RutaArxiu As String) As Boolean
        Dim Query As String = "INSERT INTO Historial (Client, Transaccio, Data, Hores, PreuHora, Import, Arxiu, Observacions) VALUES (@IdClient, @Transaccio, @Data, @Hores, @PreuHora, @Import, @RutaArxiu,@Observacions)"
        Dim CMD As New SQLiteCommand(Query, conexion)

        Try
            conexion.Open()

            With CMD
                .Parameters.AddWithValue("@IdClient", IdClient)
                .Parameters.AddWithValue("@Transaccio", TipusTransaccio)
                .Parameters.AddWithValue("@Import", Import)
                .Parameters.AddWithValue("@Observacions", Observacions)
                .Parameters.AddWithValue("@Hores", Hores)
                .Parameters.AddWithValue("@Data", Date.Now)
                .Parameters.AddWithValue("@PreuHora", PreuHora)
                .Parameters.AddWithValue("@RutaArxiu", RutaArxiu)
            End With

            If conexion.State = ConnectionState.Open Then
                CMD.ExecuteNonQuery()
            End If
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
        conexion.Close()

    End Function

    Public Function ActualitzaObservacionsClient(IdClient As Integer, Observacions As String)
        Dim Query As String = "UPDATE Clients SET Observacions= @observacions WHERE ID=@idclient"
        Dim CMD As New SQLiteCommand(Query, conexion)

        Try
            conexion.Open()
            CMD.Parameters.AddWithValue("@observacions", Observacions)
            CMD.Parameters.AddWithValue("@idclient", IdClient)

            If conexion.State = ConnectionState.Open Then
                CMD.ExecuteNonQuery()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
        conexion.Close()

    End Function
    Public Function EliminaRegistre(idRegistre As Integer)
        Dim Query As String = "DELETE FROM Historial WHERE ID=@IdRegistre"
        Dim CMD As New SQLiteCommand(Query, conexion)

        Try
            conexion.Open()
            CMD.Parameters.AddWithValue("@IdRegistre", idRegistre)

            If conexion.State = ConnectionState.Open Then
                CMD.ExecuteNonQuery()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
        conexion.Close()
    End Function
    Public Function ActualitzaRegistre(idRegistre As Integer, Data As Date, Hores As Double, PreuHora As Double, Import As Double, Observacions As String, RutaArxiu As String)
        Dim Query As String = "UPDATE Historial SET Data=@Data, Hores=@Hores, PreuHora=@PreuHora, Import=@Import, Arxiu=@RutaArxiu,Observacions=@Observacions WHERE ID=@IdRegistre"
        Dim CMD As New SQLiteCommand(Query, conexion)

        Try
            conexion.Open()
            With CMD
                .Parameters.AddWithValue("@IdRegistre", idRegistre)
                .Parameters.AddWithValue("@Data", Data)
                .Parameters.AddWithValue("@Hores", Hores)
                .Parameters.AddWithValue("@Import", Import)
                .Parameters.AddWithValue("@Observacions", Observacions)
                .Parameters.AddWithValue("@PreuHora", PreuHora)
                .Parameters.AddWithValue("@RutaArxiu", RutaArxiu)
            End With

            If conexion.State = ConnectionState.Open Then
                CMD.ExecuteNonQuery()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
        conexion.Close()
    End Function
    Public Function EliminaClient(idClient As Integer)
        Dim Query As String = "DELETE FROM Clients WHERE ID=@IdClient"
        Dim CMD As New SQLiteCommand(Query, conexion)

        Try
            conexion.Open()
            CMD.Parameters.AddWithValue("@IdClient", idClient)

            If conexion.State = ConnectionState.Open Then
                CMD.ExecuteNonQuery()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
        conexion.Close()
    End Function
    Public Function AfegirClient(RaoSocial As String, IdExit As String)
        Dim Query As String = "INSERT INTO Clients (Nom, IdExit) VALUES (@RaoSocial,@IdExit)"
        Dim CMD As New SQLiteCommand(Query, conexion)

        Try
            conexion.Open()

            With CMD
                .Parameters.AddWithValue("@RaoSocial", RaoSocial)
                .Parameters.AddWithValue("@IdExit", IdExit)
            End With

            If conexion.State = ConnectionState.Open Then
                CMD.ExecuteNonQuery()
            End If
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
        conexion.Close()
    End Function

    Public Function ActualitzarClient(Id As Integer, nom As String, IdExit As String)
        Dim Query As String = "UPDATE Clients SET nom=@Nom, IdExit=@IdExit WHERE Id= @Id"
        Dim CMD As New SQLiteCommand(Query, conexion)

        Try
            conexion.Open()

            With CMD
                .Parameters.AddWithValue("@nom", nom)
                .Parameters.AddWithValue("@IdExit", IdExit)
                .Parameters.AddWithValue("@Id", Id)
            End With

            If conexion.State = ConnectionState.Open Then
                CMD.ExecuteNonQuery()
            End If
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
        conexion.Close()
    End Function


End Module
