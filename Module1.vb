Imports Npgsql
Module Module1
    Public connectionString As String = "Server=localhost;Port=5432;Database=Banco_Gastos;User Id=postgres;Password=0609;"
    Public connection As New NpgsqlConnection(connectionString)
    Public Sub ConectarBanco()
        Try
            connection.Open()
            MsgBox("Banco conectado!")
        Catch ex As Exception
            MsgBox("Banco não conectado!")
        End Try
    End Sub
End Module
