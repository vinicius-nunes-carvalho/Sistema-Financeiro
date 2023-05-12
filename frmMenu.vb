Public Class frmMenu
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Dim resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.YesNo, "Selecione uma resposta!")
        If resp = vbYes Then
            Application.Exit()
        End If
    End Sub
End Class
