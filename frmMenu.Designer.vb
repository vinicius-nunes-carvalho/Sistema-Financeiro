﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.lbl_categoria = New System.Windows.Forms.Label()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.cmb_pagamento = New System.Windows.Forms.ComboBox()
        Me.lbl_pagamento = New System.Windows.Forms.Label()
        Me.lbl_compra = New System.Windows.Forms.Label()
        Me.txt_compra = New System.Windows.Forms.TextBox()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.lbl_valor = New System.Windows.Forms.Label()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.dtp_data = New System.Windows.Forms.DateTimePicker()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiltrosToolMes = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.ColunaApagar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnFiltroCat = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_categoria
        '
        Me.lbl_categoria.AutoSize = True
        Me.lbl_categoria.Location = New System.Drawing.Point(26, 32)
        Me.lbl_categoria.Name = "lbl_categoria"
        Me.lbl_categoria.Size = New System.Drawing.Size(88, 18)
        Me.lbl_categoria.TabIndex = 0
        Me.lbl_categoria.Text = "Categoria:"
        '
        'cmb_categoria
        '
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Items.AddRange(New Object() {"Pessoais", "Alimentação", "Trabalho", "Lazer"})
        Me.cmb_categoria.Location = New System.Drawing.Point(29, 53)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(270, 26)
        Me.cmb_categoria.TabIndex = 1
        '
        'cmb_pagamento
        '
        Me.cmb_pagamento.FormattingEnabled = True
        Me.cmb_pagamento.Items.AddRange(New Object() {"Itaú", "Nubank", "American", "Dinheiro"})
        Me.cmb_pagamento.Location = New System.Drawing.Point(29, 113)
        Me.cmb_pagamento.Name = "cmb_pagamento"
        Me.cmb_pagamento.Size = New System.Drawing.Size(270, 26)
        Me.cmb_pagamento.TabIndex = 3
        '
        'lbl_pagamento
        '
        Me.lbl_pagamento.AutoSize = True
        Me.lbl_pagamento.Location = New System.Drawing.Point(26, 92)
        Me.lbl_pagamento.Name = "lbl_pagamento"
        Me.lbl_pagamento.Size = New System.Drawing.Size(96, 18)
        Me.lbl_pagamento.TabIndex = 2
        Me.lbl_pagamento.Text = "Forma pgt:"
        '
        'lbl_compra
        '
        Me.lbl_compra.AutoSize = True
        Me.lbl_compra.Location = New System.Drawing.Point(26, 154)
        Me.lbl_compra.Name = "lbl_compra"
        Me.lbl_compra.Size = New System.Drawing.Size(151, 18)
        Me.lbl_compra.TabIndex = 4
        Me.lbl_compra.Text = "Produto / Serviço:"
        '
        'txt_compra
        '
        Me.txt_compra.Location = New System.Drawing.Point(29, 175)
        Me.txt_compra.Name = "txt_compra"
        Me.txt_compra.Size = New System.Drawing.Size(270, 25)
        Me.txt_compra.TabIndex = 5
        '
        'txt_valor
        '
        Me.txt_valor.Location = New System.Drawing.Point(29, 238)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(124, 25)
        Me.txt_valor.TabIndex = 7
        '
        'lbl_valor
        '
        Me.lbl_valor.AutoSize = True
        Me.lbl_valor.Location = New System.Drawing.Point(26, 217)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(53, 18)
        Me.lbl_valor.TabIndex = 6
        Me.lbl_valor.Text = "Valor:"
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Location = New System.Drawing.Point(172, 217)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(49, 18)
        Me.lbl_data.TabIndex = 9
        Me.lbl_data.Text = "Data:"
        '
        'dtp_data
        '
        Me.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_data.Location = New System.Drawing.Point(175, 238)
        Me.dtp_data.Name = "dtp_data"
        Me.dtp_data.Size = New System.Drawing.Size(124, 25)
        Me.dtp_data.TabIndex = 10
        '
        'btn_gravar
        '
        Me.btn_gravar.Location = New System.Drawing.Point(29, 288)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(124, 30)
        Me.btn_gravar.TabIndex = 12
        Me.btn_gravar.Text = "Gravar"
        Me.btn_gravar.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(29, 358)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(124, 30)
        Me.btn_sair.TabIndex = 13
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(789, 26)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolMenu
        '
        Me.ToolMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiltrosToolMes})
        Me.ToolMenu.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolMenu.Name = "ToolMenu"
        Me.ToolMenu.Size = New System.Drawing.Size(69, 22)
        Me.ToolMenu.Text = "Filtros"
        '
        'FiltrosToolMes
        '
        Me.FiltrosToolMes.Name = "FiltrosToolMes"
        Me.FiltrosToolMes.Size = New System.Drawing.Size(222, 22)
        Me.FiltrosToolMes.Text = "Mês"
        '
        'dgvDados
        '
        Me.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColunaApagar})
        Me.dgvDados.Location = New System.Drawing.Point(339, 53)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(425, 335)
        Me.dgvDados.TabIndex = 16
        '
        'ColunaApagar
        '
        Me.ColunaApagar.HeaderText = "Apagar"
        Me.ColunaApagar.Name = "ColunaApagar"
        Me.ColunaApagar.Width = 73
        '
        'btnFiltroCat
        '
        Me.btnFiltroCat.Image = CType(resources.GetObject("btnFiltroCat.Image"), System.Drawing.Image)
        Me.btnFiltroCat.Location = New System.Drawing.Point(305, 53)
        Me.btnFiltroCat.Name = "btnFiltroCat"
        Me.btnFiltroCat.Size = New System.Drawing.Size(28, 26)
        Me.btnFiltroCat.TabIndex = 17
        Me.btnFiltroCat.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(789, 410)
        Me.Controls.Add(Me.btnFiltroCat)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.dtp_data)
        Me.Controls.Add(Me.lbl_data)
        Me.Controls.Add(Me.txt_valor)
        Me.Controls.Add(Me.lbl_valor)
        Me.Controls.Add(Me.txt_compra)
        Me.Controls.Add(Me.lbl_compra)
        Me.Controls.Add(Me.cmb_pagamento)
        Me.Controls.Add(Me.lbl_pagamento)
        Me.Controls.Add(Me.cmb_categoria)
        Me.Controls.Add(Me.lbl_categoria)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_categoria As Label
    Friend WithEvents cmb_categoria As ComboBox
    Friend WithEvents cmb_pagamento As ComboBox
    Friend WithEvents lbl_pagamento As Label
    Friend WithEvents lbl_compra As Label
    Friend WithEvents txt_compra As TextBox
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents lbl_valor As Label
    Friend WithEvents lbl_data As Label
    Friend WithEvents dtp_data As DateTimePicker
    Friend WithEvents btn_gravar As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolMenu As ToolStripMenuItem
    Friend WithEvents FiltrosToolMes As ToolStripMenuItem
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents ColunaApagar As DataGridViewImageColumn
    Friend WithEvents btnFiltroCat As Button
End Class
