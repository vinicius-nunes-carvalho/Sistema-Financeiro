Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports Npgsql

Public Class frmMenu
    Public Sub CarregarDados()

        Try
            'Query ao banco para buscar todos os valores da tabela
            Dim query As String = "SELECT * FROM dadosgastos"

            Dim dataAdapter As New NpgsqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()

            'Preenche o dadaTable com a função Fill
            dataAdapter.Fill(dataTable)

            'Insere os dados no DataGrid
            dgvDados.DataSource = dataTable
        Catch
            MsgBox("Erro ao carregar dados do DataGrid")
        End Try
    End Sub
    Public Sub FiltroMes()
        Dim result As Boolean
        Do While result = False
            Dim numeroMes As String
            numeroMes = InputBox("Digite o mês desejado - formato númeral")
            Dim numero As Integer

            If numeroMes = "" Then
                Exit Sub
            ElseIf Integer.TryParse(numeroMes, numero) Then
                If numeroMes > 12 Or numeroMes < 1 Then
                    MsgBox("Digite um mês entre 1 e 12!")
                    result = False
                Else
                    Try
                        Dim query As String = "SELECT * FROM dadosgastos WHERE EXTRACT(MONTH FROM data_compra) = " & numeroMes
                        Dim dataAdapter As New NpgsqlDataAdapter(query, connection)
                        Dim dataTable As New DataTable()

                        'Preenche o dadaTable com a função Fill
                        dataAdapter.Fill(dataTable)

                        'Insere os dados no DataGrid
                        dgvDados.DataSource = dataTable
                        result = True
                    Catch
                        MsgBox("Erro ao carregar dados do DataGrid - Filtro Mês")
                        result = True
                    End Try
                End If
            Else
                MsgBox("Dentro desse campo só podem ser digitados números!", MsgBoxStyle.Critical, "Aviso!")
            End If
        Loop
    End Sub
    Public Function validar() As Boolean
        If cmb_categoria.SelectedIndex = -1 Or
                 cmb_pagamento.SelectedIndex = -1 Or
                 txt_compra.Text = "" Or
                 txt_valor.Text = "" Or
                 Not dtp_data.Checked Then
            MsgBox("Complete todos os campos para realizar alguma ação.", MessageBoxIcon.Warning, "Aviso!")
            Return False
        Else
            Return True
        End If
    End Function

    Public Function gravar() As Boolean
        If validar() = False Then
            Return False
        Else
            Try
                Dim query As String
                query = "INSERT INTO dadosgastos (categoria, pagamento, produto, valor, data_compra) 
                 VALUES (@cat, @pag, @prod, @valor, @data)"
                Dim command As New NpgsqlCommand(query, connection)

                'parametros da query
                command.Parameters.AddWithValue("@cat", cmb_categoria.SelectedItem)
                command.Parameters.AddWithValue("@pag", cmb_pagamento.SelectedItem)
                command.Parameters.AddWithValue("@prod", txt_compra.Text)
                command.Parameters.AddWithValue("@valor", CDec(txt_valor.Text))
                command.Parameters.AddWithValue("@data", dtp_data.Value)

                'Executar a query ao banco
                command.ExecuteNonQuery()
                PopUpCentro("Os dados foram gravados!")
                CarregarDados()
                Return True
            Catch ex As Exception
                MsgBox("Erro ao gravar dados!")
                Return False
            End Try
        End If
    End Function
    Public Sub PopUpCentro(mensagem As String)
        Dim tooltip As New ToolTip()
        tooltip.Show(mensagem, Me, 334, 175, 3000)
    End Sub
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Dim resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.YesNo, "Selecione uma resposta!")
        If resp = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarBanco()
        CarregarDados()
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        gravar()
    End Sub

    Private Sub btn_apagar_Click(sender As Object, e As EventArgs) 
        If validar() = False Then
            PopUpCentro("Os dados foram apagados!")
        End If
    End Sub
    Private Sub MêsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiltrosToolMes.Click
        FiltroMes()
    End Sub

    Private Sub txt_valor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor.KeyPress
        ' Verificar se a tecla pressionada não é um número ou backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso (e.KeyChar <> ",") Then
            ' Bloquear o caractere definindo Handled como True
            e.Handled = True
        End If
    End Sub

    Private Sub dgvDados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellContentClick
        Dim resp = MessageBox.Show("Gostaria de realmente apagar o registro?",
                        "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resp = vbYes Then
            ' Verifica se o clique ocorreu em uma célula válida (ignora o cabeçalho)
            If e.RowIndex > 0 AndAlso e.ColumnIndex > 0 Then
                ' Obtém a linha clicada
                Dim row As DataGridViewRow = dgvDados.Rows(e.RowIndex)
                ' Obtém os valores das células da linha clicada
                Dim categoria As String = row.Cells("Categoria").Value.ToString()
                Dim pagamento As String = row.Cells("Pagamento").Value.ToString()
                Dim produto As String = row.Cells("Produto").Value.ToString()
                Dim valor As Decimal = Convert.ToDecimal(row.Cells("Valor").Value)
                Dim data As DateTime = Convert.ToDateTime(row.Cells("data_compra").Value)

                Dim query As String = "DELETE FROM dadosgastos WHERE categoria = @cat AND pagamento = @pag AND produto = @prod AND valor = @valor AND data_compra = @data"
                Dim command As New NpgsqlCommand(query, connection)

                ' Parâmetros da query
                command.Parameters.AddWithValue("@cat", categoria)
                command.Parameters.AddWithValue("@pag", pagamento)
                command.Parameters.AddWithValue("@prod", produto)
                command.Parameters.AddWithValue("@valor", valor)
                command.Parameters.AddWithValue("@data", data)

                ' Executar a query no banco
                command.ExecuteNonQuery()
                CarregarDados()
            End If
        End If
    End Sub
End Class
