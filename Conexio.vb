
Imports System.Data.SQLite
Imports System.Net.Sockets

Module Conexio
    Public cadena As String = "Data Source=" & Application.StartupPath & "\Database\DBControlHores.db;Version=3;UseUTF8Encoding=True;"
    Public conexion As New SQLiteConnection(cadena)

    Public Function CarregaClients()
        Dim DT As New DataTable
        Dim Query As String = "SELECT Clients.*, SUM(Historial.hores) as Hores
                               FROM Clients
                               LEFT JOIN Historial ON Clients.ID = Historial.Client
                               GROUP BY Clients.ID"
        Dim CMD As New SQLiteCommand(Query, conexion)
        Dim DA As New SQLiteDataAdapter(CMD)
        DA.Fill(DT)
        conexion.Close()
        Return DT
    End Function
    Public Function CarregaClients(Text As String) As DataTable
        Dim DT As New DataTable
        Dim Query As String = "SELECT * FROM Clients WHERE Nom LIKE '%' || @textBuscar || '%'"
        Dim CMD As New SQLiteCommand(Query, conexion)
        CMD.Parameters.AddWithValue("@textBuscar", Text)
        Dim DA As New SQLiteDataAdapter(CMD)
        DA.Fill(DT)
        conexion.Close()
        Return DT
    End Function
    Public Function CarregaHistorial() As DataTable
        Dim DT As New DataTable
        Dim Query As String = "Select Historial.Id,
                                      Strftime('%d-%m-%Y  %H:%M' , Historial.Data) as 'Data transacció',
                                      Clients.Nom,
                                      Transaccions.id as idTransaccio,
                                      Transaccions.Nom as 'Transacció',
                                      Historial.Hores,
                                      Historial.PreuHora as 'Preu/Hora',
                                      Historial.Import,
                                      Historial.Observacions
                                      FROM Historial
                                      INNER JOIN Transaccions on Transaccions.id = Historial.Transaccio
					                  INNER JOIN Clients on Clients.id = Historial.Client"
        Dim CMD As New SQLiteCommand(Query, conexion)
        Dim DA As New SQLiteDataAdapter(CMD)
        DA.Fill(DT)
        conexion.Close()
        Return DT
    End Function
    Public Function CarregaHistorial(IdEmpresa As Integer) As DataTable
        Dim DT As New DataTable
        Dim Query As String = "Select Historial.Id,
                               Strftime('%d-%m-%Y  %H:%M', Historial.Data) as 'Data transacció',
                               Clients.Nom,
                               Transaccions.id as idTransaccio,
                               Transaccions.Nom as 'Transacció',
                               Historial.Hores,
                               Historial.PreuHora as 'Preu/hora',
                               Historial.Import,
                               Historial.Observacions
                               FROM Historial
                               INNER JOIN Transaccions on Transaccions.id = Historial.Transaccio
					           INNER JOIN Clients on Clients.id = Historial.Client
                               WHERE Historial.Client= @IdEmpresa"
        Dim CMD As New SQLiteCommand(Query, conexion)
        CMD.Parameters.AddWithValue("@IdEmpresa", IdEmpresa)
        Dim DA As New SQLiteDataAdapter(CMD)
        DA.Fill(DT)
        conexion.Close()
        Return DT
    End Function

    Public Function AfegirTransacció(IdClient As Integer, TipusTransaccio As Integer, Import As Double, Observacions As String, Hores As Double, PreuHora As Double) As Boolean
        Dim Query As String = "INSERT INTO Historial (Client, Transaccio, Data, Hores, PreuHora, Import, Observacions) VALUES (@IdClient, @Transaccio, @Data, @Hores, @PreuHora, @Import, @Observacions)"
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


End Module
