Imports Npgsql
Module Module1
    Dim connectionString As String = "Server=localhost;Port=5432;Database=Banco_Gastos;User Id=postgres;Password=0609;"

    Public Sub ConectarBanco()
        Dim connection As New NpgsqlConnection(connectionString)
        Try
            connection.Open()
            MsgBox("Banco conectado!")
        Catch ex As Exception
            MsgBox("Banco não conectado!")
        End Try
    End Sub
End Module
