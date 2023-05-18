Imports System.IO
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

    Public Function validar() As Boolean
        If cmb_categoria.SelectedIndex = -1 Or
                 cmb_pagamento.SelectedIndex = -1 Or
                 txt_compra.Text = "" Or
                 txt_valor.Text = "" Or
                 Not dtp_data.Checked Then
            MsgBox("Complete todos os campos para realizar alguma ação.", MessageBoxIcon.Warning, "Aviso!")
            Return True
        Else
            Return False
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
        If validar() = False Then
            PopUpCentro("Os dados foram gravados!")
        End If
    End Sub

    Private Sub btn_apagar_Click(sender As Object, e As EventArgs) Handles btn_apagar.Click
        If validar() = False Then
            PopUpCentro("Os dados foram apagados!")
        End If
    End Sub
End Class
