Public Class inicio

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim resp As Integer
        resp = MessageBox.Show("¿Desea Salir?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If resp = 6 Then Close()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("DEBES PONER UN NICKNAME", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Timer1.Stop()
        Else
            Timer1.Start()
            Timer1.Enabled = True
            ProgressBar1.Visible = True
            Label2.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Juego.Show()
            Me.Hide()
            ProgressBar1.Value = 0
            Timer1.Stop()
        End If
        Label2.Text = ProgressBar1.Value & ("%")
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Estadisticas.Show()
    End Sub

    Private Sub Button2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseDown

        Button2.BackColor = Color.DarkRed
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.Goldenrod

    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.OliveDrab

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
    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown

        Button1.BackColor = Color.DarkRed
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Goldenrod

    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.OliveDrab

    End Sub

    Private Sub inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
