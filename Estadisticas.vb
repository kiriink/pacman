Imports System.Data.OleDb
Public Class Estadisticas
    Dim a As Integer


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        inicio.Show()
        inicio.ProgressBar1.Visible = False
        inicio.Label2.Visible = False
    End Sub
    Private Sub Button3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseDown

        Button3.BackColor = Color.DarkRed
    End Sub

    Private Sub Button3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter
        Button3.BackColor = Color.Goldenrod

    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.OliveDrab

    End Sub
    Private Sub dgv_ranking_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_ranking.CellContentClick

    End Sub

    Private Sub dgv_ranking_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgv_ranking.RowPostPaint
        Try
            Dim NumeroFila As String = (e.RowIndex + 1).ToString 'Obtiene el número de filas
            While NumeroFila.Length < dgv_ranking.RowCount.ToString.Length
                NumeroFila = "0" & NumeroFila 'Agrega un cero a los que tienen un dígito menos
            End While
            Dim size As SizeF = e.Graphics.MeasureString(NumeroFila, Me.Font)
            If dgv_ranking.RowHeadersWidth < CInt(size.Width + 20) Then
                dgv_ranking.RowHeadersWidth = CInt(size.Width + 20)
            End If
            Dim Obj As Brush = SystemBrushes.ControlText
            'Dibuja el número dentro del controltext
            e.Graphics.DrawString(NumeroFila, Me.Font, Obj, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub Estadisticas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class