Public Class frmMenu
    Dim categoria, pagamento, compra, valor, data
    Public Sub nomearCampos()
        categoria = cmb_categoria
        pagamento = cmb_pagamento
        compra = txt_compra
        valor = txt_valor
        data = dtp_data
    End Sub
    Public Sub validarCammpos()

    End Sub
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Dim resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.YesNo, "Selecione uma resposta!")
        If resp = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click

    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nomearCampos()
    End Sub
End Class
