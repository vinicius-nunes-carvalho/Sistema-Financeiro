Public Class frmMenu

    Public Sub validar()
        Do While cmb_categoria.SelectedIndex = -1 Or
                 cmb_pagamento.SelectedIndex = -1 Or
                 txt_compra.Text = "" Or
                 txt_valor.Text = "" Or
                 Not dtp_data.Checked
            MsgBox("Complete todos os campos para realizar alguma ação", MessageBoxIcon.Warning, "Aviso!")
            Exit Do
        Loop
    End Sub
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Dim resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.YesNo, "Selecione uma resposta!")
        If resp = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_categoria.Items.Add("teste")
        cmb_pagamento.Items.Add("teste")
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        validar()
    End Sub
End Class
