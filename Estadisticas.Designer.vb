<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estadisticas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estadisticas))
        Me.dgv_ranking = New System.Windows.Forms.DataGridView()
        Me.NICK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VIDAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUNTAJE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIEMPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgv_ranking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_ranking
        '
        Me.dgv_ranking.AllowDrop = True
        Me.dgv_ranking.AllowUserToAddRows = False
        Me.dgv_ranking.AllowUserToDeleteRows = False
        Me.dgv_ranking.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_ranking.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv_ranking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ranking.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NICK, Me.VIDAS, Me.PUNTAJE, Me.TIEMPO})
        Me.dgv_ranking.Location = New System.Drawing.Point(107, 37)
        Me.dgv_ranking.Name = "dgv_ranking"
        Me.dgv_ranking.ReadOnly = True
        Me.dgv_ranking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ranking.Size = New System.Drawing.Size(519, 453)
        Me.dgv_ranking.TabIndex = 0
        '
        'NICK
        '
        Me.NICK.HeaderText = "NICK"
        Me.NICK.Name = "NICK"
        Me.NICK.ReadOnly = True
        Me.NICK.Width = 150
        '
        'VIDAS
        '
        Me.VIDAS.HeaderText = "VIDAS"
        Me.VIDAS.Name = "VIDAS"
        Me.VIDAS.ReadOnly = True
        '
        'PUNTAJE
        '
        Me.PUNTAJE.HeaderText = "PUNTAJE"
        Me.PUNTAJE.Name = "PUNTAJE"
        Me.PUNTAJE.ReadOnly = True
        '
        'TIEMPO
        '
        Me.TIEMPO.HeaderText = "TIEMPO"
        Me.TIEMPO.Name = "TIEMPO"
        Me.TIEMPO.ReadOnly = True
        Me.TIEMPO.Width = 125
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.OliveDrab
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(591, 496)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 44)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "<< VOLVER"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Estadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(753, 552)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgv_ranking)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Estadisticas"
        Me.Text = "Estadisticas"
        CType(Me.dgv_ranking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_ranking As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents NICK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VIDAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PUNTAJE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIEMPO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
