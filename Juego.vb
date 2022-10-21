Public Class Juego
    Dim contador As Integer
    Dim contador2 As Integer
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer


    Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        
        If e.KeyCode = Keys.Right Then

            pb1.Left = pb1.Left + 7
            pb2.Left = pb2.Left + 7
            pb3.Left = pb3.Left + 7
            pb4.Left = pb4.Left + 7
            pb1.Visible = True
            pb2.Visible = False
            pb3.Visible = False
            pb4.Visible = False
            If Label21.Bounds.IntersectsWith(pb1.Bounds) And Label21.Bounds.IntersectsWith(pb2.Bounds) And Label21.Bounds.IntersectsWith(pb3.Bounds) And Label21.Bounds.IntersectsWith(pb4.Bounds) Or lbl1.Bounds.IntersectsWith(pb1.Bounds) And lbl1.Bounds.IntersectsWith(pb2.Bounds) And lbl1.Bounds.IntersectsWith(pb3.Bounds) And lbl1.Bounds.IntersectsWith(pb4.Bounds) Or lbl2.Bounds.IntersectsWith(pb1.Bounds) And lbl2.Bounds.IntersectsWith(pb2.Bounds) And lbl2.Bounds.IntersectsWith(pb3.Bounds) And lbl2.Bounds.IntersectsWith(pb4.Bounds) Or lbl1.Bounds.IntersectsWith(pb1.Bounds) And lbl1.Bounds.IntersectsWith(pb2.Bounds) And lbl1.Bounds.IntersectsWith(pb3.Bounds) And lbl1.Bounds.IntersectsWith(pb4.Bounds) Or Label22.Bounds.IntersectsWith(pb1.Bounds) And Label22.Bounds.IntersectsWith(pb2.Bounds) And Label22.Bounds.IntersectsWith(pb3.Bounds) And Label22.Bounds.IntersectsWith(pb4.Bounds) Or lbl3.Bounds.IntersectsWith(pb1.Bounds) And lbl3.Bounds.IntersectsWith(pb2.Bounds) And lbl3.Bounds.IntersectsWith(pb3.Bounds) And lbl3.Bounds.IntersectsWith(pb4.Bounds) Or lbl3.Bounds.IntersectsWith(pb1.Bounds) And lbl3.Bounds.IntersectsWith(pb2.Bounds) And lbl3.Bounds.IntersectsWith(pb3.Bounds) And lbl3.Bounds.IntersectsWith(pb4.Bounds) Or lbl4.Bounds.IntersectsWith(pb1.Bounds) And lbl4.Bounds.IntersectsWith(pb2.Bounds) And lbl4.Bounds.IntersectsWith(pb3.Bounds) And lbl4.Bounds.IntersectsWith(pb4.Bounds) Or lbl7.Bounds.IntersectsWith(pb1.Bounds) And lbl7.Bounds.IntersectsWith(pb2.Bounds) And lbl7.Bounds.IntersectsWith(pb3.Bounds) And lbl7.Bounds.IntersectsWith(pb4.Bounds) Or Label1.Bounds.IntersectsWith(pb1.Bounds) And Label1.Bounds.IntersectsWith(pb2.Bounds) And Label1.Bounds.IntersectsWith(pb3.Bounds) And Label1.Bounds.IntersectsWith(pb4.Bounds) Or Label2.Bounds.IntersectsWith(pb1.Bounds) And Label2.Bounds.IntersectsWith(pb2.Bounds) And Label2.Bounds.IntersectsWith(pb3.Bounds) And Label2.Bounds.IntersectsWith(pb4.Bounds) Or Label3.Bounds.IntersectsWith(pb1.Bounds) And Label3.Bounds.IntersectsWith(pb2.Bounds) And Label3.Bounds.IntersectsWith(pb3.Bounds) And Label3.Bounds.IntersectsWith(pb4.Bounds) Or Label4.Bounds.IntersectsWith(pb1.Bounds) And Label4.Bounds.IntersectsWith(pb2.Bounds) And Label4.Bounds.IntersectsWith(pb3.Bounds) And Label4.Bounds.IntersectsWith(pb4.Bounds) Or Label5.Bounds.IntersectsWith(pb1.Bounds) And Label5.Bounds.IntersectsWith(pb2.Bounds) And Label5.Bounds.IntersectsWith(pb3.Bounds) And Label5.Bounds.IntersectsWith(pb4.Bounds) Or Label6.Bounds.IntersectsWith(pb1.Bounds) And Label6.Bounds.IntersectsWith(pb2.Bounds) And Label6.Bounds.IntersectsWith(pb3.Bounds) And Label6.Bounds.IntersectsWith(pb4.Bounds) Or Label7.Bounds.IntersectsWith(pb1.Bounds) And Label7.Bounds.IntersectsWith(pb2.Bounds) And Label7.Bounds.IntersectsWith(pb3.Bounds) And Label7.Bounds.IntersectsWith(pb4.Bounds) Or Label8.Bounds.IntersectsWith(pb1.Bounds) And Label8.Bounds.IntersectsWith(pb2.Bounds) And Label8.Bounds.IntersectsWith(pb3.Bounds) And Label8.Bounds.IntersectsWith(pb4.Bounds) Or Label9.Bounds.IntersectsWith(pb1.Bounds) And Label9.Bounds.IntersectsWith(pb2.Bounds) And Label9.Bounds.IntersectsWith(pb3.Bounds) And Label9.Bounds.IntersectsWith(pb4.Bounds) Or Label10.Bounds.IntersectsWith(pb1.Bounds) And Label10.Bounds.IntersectsWith(pb2.Bounds) And Label10.Bounds.IntersectsWith(pb3.Bounds) And Label10.Bounds.IntersectsWith(pb4.Bounds) Or Label11.Bounds.IntersectsWith(pb1.Bounds) And Label11.Bounds.IntersectsWith(pb2.Bounds) And Label11.Bounds.IntersectsWith(pb3.Bounds) And Label11.Bounds.IntersectsWith(pb4.Bounds) Or Label12.Bounds.IntersectsWith(pb1.Bounds) And Label12.Bounds.IntersectsWith(pb2.Bounds) And Label12.Bounds.IntersectsWith(pb3.Bounds) And Label12.Bounds.IntersectsWith(pb4.Bounds) Or Label13.Bounds.IntersectsWith(pb1.Bounds) And Label13.Bounds.IntersectsWith(pb2.Bounds) And Label13.Bounds.IntersectsWith(pb3.Bounds) And Label13.Bounds.IntersectsWith(pb4.Bounds) Or Label14.Bounds.IntersectsWith(pb1.Bounds) And Label14.Bounds.IntersectsWith(pb2.Bounds) And Label14.Bounds.IntersectsWith(pb3.Bounds) And Label14.Bounds.IntersectsWith(pb4.Bounds) Or Label15.Bounds.IntersectsWith(pb1.Bounds) And Label15.Bounds.IntersectsWith(pb2.Bounds) And Label15.Bounds.IntersectsWith(pb3.Bounds) And Label15.Bounds.IntersectsWith(pb4.Bounds) Or Label16.Bounds.IntersectsWith(pb1.Bounds) And Label16.Bounds.IntersectsWith(pb2.Bounds) And Label16.Bounds.IntersectsWith(pb3.Bounds) And Label16.Bounds.IntersectsWith(pb4.Bounds) Or Label17.Bounds.IntersectsWith(pb1.Bounds) And Label17.Bounds.IntersectsWith(pb2.Bounds) And Label17.Bounds.IntersectsWith(pb3.Bounds) And Label17.Bounds.IntersectsWith(pb4.Bounds) Or Label18.Bounds.IntersectsWith(pb1.Bounds) And Label18.Bounds.IntersectsWith(pb2.Bounds) And Label18.Bounds.IntersectsWith(pb3.Bounds) And Label18.Bounds.IntersectsWith(pb4.Bounds) Or Label23.Bounds.IntersectsWith(pb1.Bounds) And Label23.Bounds.IntersectsWith(pb2.Bounds) And Label23.Bounds.IntersectsWith(pb3.Bounds) And Label23.Bounds.IntersectsWith(pb4.Bounds) Or Label24.Bounds.IntersectsWith(pb1.Bounds) And Label24.Bounds.IntersectsWith(pb2.Bounds) And Label24.Bounds.IntersectsWith(pb3.Bounds) And Label24.Bounds.IntersectsWith(pb4.Bounds) Or Label25.Bounds.IntersectsWith(pb1.Bounds) And Label25.Bounds.IntersectsWith(pb2.Bounds) And Label25.Bounds.IntersectsWith(pb3.Bounds) And Label25.Bounds.IntersectsWith(pb4.Bounds) Or Label26.Bounds.IntersectsWith(pb1.Bounds) And Label26.Bounds.IntersectsWith(pb2.Bounds) And Label26.Bounds.IntersectsWith(pb3.Bounds) And Label26.Bounds.IntersectsWith(pb4.Bounds) Then

                pb1.Left = pb1.Left - 7
                pb2.Left = pb2.Left - 7
                pb3.Left = pb3.Left - 7
                pb4.Left = pb4.Left - 7

            End If
        End If
        If e.KeyCode = Keys.Left Then

            pb1.Left = pb1.Left - 7
            pb2.Left = pb2.Left - 7
            pb3.Left = pb3.Left - 7
            pb4.Left = pb4.Left - 7
            pb1.Visible = False
            pb2.Visible = False
            pb3.Visible = False
            pb4.Visible = True
            If Label21.Bounds.IntersectsWith(pb1.Bounds) And Label21.Bounds.IntersectsWith(pb2.Bounds) And Label21.Bounds.IntersectsWith(pb3.Bounds) And Label21.Bounds.IntersectsWith(pb4.Bounds) Or lbl1.Bounds.IntersectsWith(pb1.Bounds) And lbl1.Bounds.IntersectsWith(pb2.Bounds) And lbl1.Bounds.IntersectsWith(pb3.Bounds) And lbl1.Bounds.IntersectsWith(pb4.Bounds) Or lbl2.Bounds.IntersectsWith(pb1.Bounds) And lbl2.Bounds.IntersectsWith(pb2.Bounds) And lbl2.Bounds.IntersectsWith(pb3.Bounds) And lbl2.Bounds.IntersectsWith(pb4.Bounds) Or lbl1.Bounds.IntersectsWith(pb1.Bounds) And lbl1.Bounds.IntersectsWith(pb2.Bounds) And lbl1.Bounds.IntersectsWith(pb3.Bounds) And lbl1.Bounds.IntersectsWith(pb4.Bounds) Or Label22.Bounds.IntersectsWith(pb1.Bounds) And Label22.Bounds.IntersectsWith(pb2.Bounds) And Label22.Bounds.IntersectsWith(pb3.Bounds) And Label22.Bounds.IntersectsWith(pb4.Bounds) Or lbl3.Bounds.IntersectsWith(pb1.Bounds) And lbl3.Bounds.IntersectsWith(pb2.Bounds) And lbl3.Bounds.IntersectsWith(pb3.Bounds) And lbl3.Bounds.IntersectsWith(pb4.Bounds) Or lbl3.Bounds.IntersectsWith(pb1.Bounds) And lbl3.Bounds.IntersectsWith(pb2.Bounds) And lbl3.Bounds.IntersectsWith(pb3.Bounds) And lbl3.Bounds.IntersectsWith(pb4.Bounds) Or lbl4.Bounds.IntersectsWith(pb1.Bounds) And lbl4.Bounds.IntersectsWith(pb2.Bounds) And lbl4.Bounds.IntersectsWith(pb3.Bounds) And lbl4.Bounds.IntersectsWith(pb4.Bounds) Or lbl7.Bounds.IntersectsWith(pb1.Bounds) And lbl7.Bounds.IntersectsWith(pb2.Bounds) And lbl7.Bounds.IntersectsWith(pb3.Bounds) And lbl7.Bounds.IntersectsWith(pb4.Bounds) Or Label1.Bounds.IntersectsWith(pb1.Bounds) And Label1.Bounds.IntersectsWith(pb2.Bounds) And Label1.Bounds.IntersectsWith(pb3.Bounds) And Label1.Bounds.IntersectsWith(pb4.Bounds) Or Label2.Bounds.IntersectsWith(pb1.Bounds) And Label2.Bounds.IntersectsWith(pb2.Bounds) And Label2.Bounds.IntersectsWith(pb3.Bounds) And Label2.Bounds.IntersectsWith(pb4.Bounds) Or Label3.Bounds.IntersectsWith(pb1.Bounds) And Label3.Bounds.IntersectsWith(pb2.Bounds) And Label3.Bounds.IntersectsWith(pb3.Bounds) And Label3.Bounds.IntersectsWith(pb4.Bounds) Or Label4.Bounds.IntersectsWith(pb1.Bounds) And Label4.Bounds.IntersectsWith(pb2.Bounds) And Label4.Bounds.IntersectsWith(pb3.Bounds) And Label4.Bounds.IntersectsWith(pb4.Bounds) Or Label5.Bounds.IntersectsWith(pb1.Bounds) And Label5.Bounds.IntersectsWith(pb2.Bounds) And Label5.Bounds.IntersectsWith(pb3.Bounds) And Label5.Bounds.IntersectsWith(pb4.Bounds) Or Label6.Bounds.IntersectsWith(pb1.Bounds) And Label6.Bounds.IntersectsWith(pb2.Bounds) And Label6.Bounds.IntersectsWith(pb3.Bounds) And Label6.Bounds.IntersectsWith(pb4.Bounds) Or Label7.Bounds.IntersectsWith(pb1.Bounds) And Label7.Bounds.IntersectsWith(pb2.Bounds) And Label7.Bounds.IntersectsWith(pb3.Bounds) And Label7.Bounds.IntersectsWith(pb4.Bounds) Or Label8.Bounds.IntersectsWith(pb1.Bounds) And Label8.Bounds.IntersectsWith(pb2.Bounds) And Label8.Bounds.IntersectsWith(pb3.Bounds) And Label8.Bounds.IntersectsWith(pb4.Bounds) Or Label9.Bounds.IntersectsWith(pb1.Bounds) And Label9.Bounds.IntersectsWith(pb2.Bounds) And Label9.Bounds.IntersectsWith(pb3.Bounds) And Label9.Bounds.IntersectsWith(pb4.Bounds) Or Label10.Bounds.IntersectsWith(pb1.Bounds) And Label10.Bounds.IntersectsWith(pb2.Bounds) And Label10.Bounds.IntersectsWith(pb3.Bounds) And Label10.Bounds.IntersectsWith(pb4.Bounds) Or Label11.Bounds.IntersectsWith(pb1.Bounds) And Label11.Bounds.IntersectsWith(pb2.Bounds) And Label11.Bounds.IntersectsWith(pb3.Bounds) And Label11.Bounds.IntersectsWith(pb4.Bounds) Or Label12.Bounds.IntersectsWith(pb1.Bounds) And Label12.Bounds.IntersectsWith(pb2.Bounds) And Label12.Bounds.IntersectsWith(pb3.Bounds) And Label12.Bounds.IntersectsWith(pb4.Bounds) Or Label13.Bounds.IntersectsWith(pb1.Bounds) And Label13.Bounds.IntersectsWith(pb2.Bounds) And Label13.Bounds.IntersectsWith(pb3.Bounds) And Label13.Bounds.IntersectsWith(pb4.Bounds) Or Label14.Bounds.IntersectsWith(pb1.Bounds) And Label14.Bounds.IntersectsWith(pb2.Bounds) And Label14.Bounds.IntersectsWith(pb3.Bounds) And Label14.Bounds.IntersectsWith(pb4.Bounds) Or Label15.Bounds.IntersectsWith(pb1.Bounds) And Label15.Bounds.IntersectsWith(pb2.Bounds) And Label15.Bounds.IntersectsWith(pb3.Bounds) And Label15.Bounds.IntersectsWith(pb4.Bounds) Or Label16.Bounds.IntersectsWith(pb1.Bounds) And Label16.Bounds.IntersectsWith(pb2.Bounds) And Label16.Bounds.IntersectsWith(pb3.Bounds) And Label16.Bounds.IntersectsWith(pb4.Bounds) Or Label17.Bounds.IntersectsWith(pb1.Bounds) And Label17.Bounds.IntersectsWith(pb2.Bounds) And Label17.Bounds.IntersectsWith(pb3.Bounds) And Label17.Bounds.IntersectsWith(pb4.Bounds) Or Label18.Bounds.IntersectsWith(pb1.Bounds) And Label18.Bounds.IntersectsWith(pb2.Bounds) And Label18.Bounds.IntersectsWith(pb3.Bounds) And Label18.Bounds.IntersectsWith(pb4.Bounds) Or Label23.Bounds.IntersectsWith(pb1.Bounds) And Label23.Bounds.IntersectsWith(pb2.Bounds) And Label23.Bounds.IntersectsWith(pb3.Bounds) And Label23.Bounds.IntersectsWith(pb4.Bounds) Or Label24.Bounds.IntersectsWith(pb1.Bounds) And Label24.Bounds.IntersectsWith(pb2.Bounds) And Label24.Bounds.IntersectsWith(pb3.Bounds) And Label24.Bounds.IntersectsWith(pb4.Bounds) Or Label25.Bounds.IntersectsWith(pb1.Bounds) And Label25.Bounds.IntersectsWith(pb2.Bounds) And Label25.Bounds.IntersectsWith(pb3.Bounds) And Label25.Bounds.IntersectsWith(pb4.Bounds) Or Label26.Bounds.IntersectsWith(pb1.Bounds) And Label26.Bounds.IntersectsWith(pb2.Bounds) And Label26.Bounds.IntersectsWith(pb3.Bounds) And Label26.Bounds.IntersectsWith(pb4.Bounds) Then
                pb1.Left = pb1.Left + 7
                pb2.Left = pb2.Left + 7
                pb3.Left = pb3.Left + 7
                pb4.Left = pb4.Left + 7

            End If
        End If
        If e.KeyCode = Keys.Up Then
            pb1.Top = pb1.Top - 7
            pb2.Top = pb2.Top - 7
            pb3.Top = pb3.Top - 7
            pb4.Top = pb4.Top - 7
            pb1.Visible = False
            pb2.Visible = False
            pb3.Visible = True
            pb4.Visible = False
            If Label21.Bounds.IntersectsWith(pb1.Bounds) And Label21.Bounds.IntersectsWith(pb2.Bounds) And Label21.Bounds.IntersectsWith(pb3.Bounds) And Label21.Bounds.IntersectsWith(pb4.Bounds) Or lbl1.Bounds.IntersectsWith(pb1.Bounds) And lbl1.Bounds.IntersectsWith(pb2.Bounds) And lbl1.Bounds.IntersectsWith(pb3.Bounds) And lbl1.Bounds.IntersectsWith(pb4.Bounds) Or lbl2.Bounds.IntersectsWith(pb1.Bounds) And lbl2.Bounds.IntersectsWith(pb2.Bounds) And lbl2.Bounds.IntersectsWith(pb3.Bounds) And lbl2.Bounds.IntersectsWith(pb4.Bounds) Or lbl1.Bounds.IntersectsWith(pb1.Bounds) And lbl1.Bounds.IntersectsWith(pb2.Bounds) And lbl1.Bounds.IntersectsWith(pb3.Bounds) And lbl1.Bounds.IntersectsWith(pb4.Bounds) Or Label22.Bounds.IntersectsWith(pb1.Bounds) And Label22.Bounds.IntersectsWith(pb2.Bounds) And Label22.Bounds.IntersectsWith(pb3.Bounds) And Label22.Bounds.IntersectsWith(pb4.Bounds) Or lbl3.Bounds.IntersectsWith(pb1.Bounds) And lbl3.Bounds.IntersectsWith(pb2.Bounds) And lbl3.Bounds.IntersectsWith(pb3.Bounds) And lbl3.Bounds.IntersectsWith(pb4.Bounds) Or lbl3.Bounds.IntersectsWith(pb1.Bounds) And lbl3.Bounds.IntersectsWith(pb2.Bounds) And lbl3.Bounds.IntersectsWith(pb3.Bounds) And lbl3.Bounds.IntersectsWith(pb4.Bounds) Or lbl4.Bounds.IntersectsWith(pb1.Bounds) And lbl4.Bounds.IntersectsWith(pb2.Bounds) And lbl4.Bounds.IntersectsWith(pb3.Bounds) And lbl4.Bounds.IntersectsWith(pb4.Bounds) Or lbl7.Bounds.IntersectsWith(pb1.Bounds) And lbl7.Bounds.IntersectsWith(pb2.Bounds) And lbl7.Bounds.IntersectsWith(pb3.Bounds) And lbl7.Bounds.IntersectsWith(pb4.Bounds) Or Label1.Bounds.IntersectsWith(pb1.Bounds) And Label1.Bounds.IntersectsWith(pb2.Bounds) And Label1.Bounds.IntersectsWith(pb3.Bounds) And Label1.Bounds.IntersectsWith(pb4.Bounds) Or Label2.Bounds.IntersectsWith(pb1.Bounds) And Label2.Bounds.IntersectsWith(pb2.Bounds) And Label2.Bounds.IntersectsWith(pb3.Bounds) And Label2.Bounds.IntersectsWith(pb4.Bounds) Or Label3.Bounds.IntersectsWith(pb1.Bounds) And Label3.Bounds.IntersectsWith(pb2.Bounds) And Label3.Bounds.IntersectsWith(pb3.Bounds) And Label3.Bounds.IntersectsWith(pb4.Bounds) Or Label4.Bounds.IntersectsWith(pb1.Bounds) And Label4.Bounds.IntersectsWith(pb2.Bounds) And Label4.Bounds.IntersectsWith(pb3.Bounds) And Label4.Bounds.IntersectsWith(pb4.Bounds) Or Label5.Bounds.IntersectsWith(pb1.Bounds) And Label5.Bounds.IntersectsWith(pb2.Bounds) And Label5.Bounds.IntersectsWith(pb3.Bounds) And Label5.Bounds.IntersectsWith(pb4.Bounds) Or Label6.Bounds.IntersectsWith(pb1.Bounds) And Label6.Bounds.IntersectsWith(pb2.Bounds) And Label6.Bounds.IntersectsWith(pb3.Bounds) And Label6.Bounds.IntersectsWith(pb4.Bounds) Or Label7.Bounds.IntersectsWith(pb1.Bounds) And Label7.Bounds.IntersectsWith(pb2.Bounds) And Label7.Bounds.IntersectsWith(pb3.Bounds) And Label7.Bounds.IntersectsWith(pb4.Bounds) Or Label8.Bounds.IntersectsWith(pb1.Bounds) And Label8.Bounds.IntersectsWith(pb2.Bounds) And Label8.Bounds.IntersectsWith(pb3.Bounds) And Label8.Bounds.IntersectsWith(pb4.Bounds) Or Label9.Bounds.IntersectsWith(pb1.Bounds) And Label9.Bounds.IntersectsWith(pb2.Bounds) And Label9.Bounds.IntersectsWith(pb3.Bounds) And Label9.Bounds.IntersectsWith(pb4.Bounds) Or Label10.Bounds.IntersectsWith(pb1.Bounds) And Label10.Bounds.IntersectsWith(pb2.Bounds) And Label10.Bounds.IntersectsWith(pb3.Bounds) And Label10.Bounds.IntersectsWith(pb4.Bounds) Or Label11.Bounds.IntersectsWith(pb1.Bounds) And Label11.Bounds.IntersectsWith(pb2.Bounds) And Label11.Bounds.IntersectsWith(pb3.Bounds) And Label11.Bounds.IntersectsWith(pb4.Bounds) Or Label12.Bounds.IntersectsWith(pb1.Bounds) And Label12.Bounds.IntersectsWith(pb2.Bounds) And Label12.Bounds.IntersectsWith(pb3.Bounds) And Label12.Bounds.IntersectsWith(pb4.Bounds) Or Label13.Bounds.IntersectsWith(pb1.Bounds) And Label13.Bounds.IntersectsWith(pb2.Bounds) And Label13.Bounds.IntersectsWith(pb3.Bounds) And Label13.Bounds.IntersectsWith(pb4.Bounds) Or Label14.Bounds.IntersectsWith(pb1.Bounds) And Label14.Bounds.IntersectsWith(pb2.Bounds) And Label14.Bounds.IntersectsWith(pb3.Bounds) And Label14.Bounds.IntersectsWith(pb4.Bounds) Or Label15.Bounds.IntersectsWith(pb1.Bounds) And Label15.Bounds.IntersectsWith(pb2.Bounds) And Label15.Bounds.IntersectsWith(pb3.Bounds) And Label15.Bounds.IntersectsWith(pb4.Bounds) Or Label16.Bounds.IntersectsWith(pb1.Bounds) And Label16.Bounds.IntersectsWith(pb2.Bounds) And Label16.Bounds.IntersectsWith(pb3.Bounds) And Label16.Bounds.IntersectsWith(pb4.Bounds) Or Label17.Bounds.IntersectsWith(pb1.Bounds) And Label17.Bounds.IntersectsWith(pb2.Bounds) And Label17.Bounds.IntersectsWith(pb3.Bounds) And Label17.Bounds.IntersectsWith(pb4.Bounds) Or Label18.Bounds.IntersectsWith(pb1.Bounds) And Label18.Bounds.IntersectsWith(pb2.Bounds) And Label18.Bounds.IntersectsWith(pb3.Bounds) And Label18.Bounds.IntersectsWith(pb4.Bounds) Or Label23.Bounds.IntersectsWith(pb1.Bounds) And Label23.Bounds.IntersectsWith(pb2.Bounds) And Label23.Bounds.IntersectsWith(pb3.Bounds) And Label23.Bounds.IntersectsWith(pb4.Bounds) Or Label24.Bounds.IntersectsWith(pb1.Bounds) And Label24.Bounds.IntersectsWith(pb2.Bounds) And Label24.Bounds.IntersectsWith(pb3.Bounds) And Label24.Bounds.IntersectsWith(pb4.Bounds) Or Label25.Bounds.IntersectsWith(pb1.Bounds) And Label25.Bounds.IntersectsWith(pb2.Bounds) And Label25.Bounds.IntersectsWith(pb3.Bounds) And Label25.Bounds.IntersectsWith(pb4.Bounds) Or Label26.Bounds.IntersectsWith(pb1.Bounds) And Label26.Bounds.IntersectsWith(pb2.Bounds) And Label26.Bounds.IntersectsWith(pb3.Bounds) And Label26.Bounds.IntersectsWith(pb4.Bounds) Then
                pb1.Top = pb1.Top + 7
                pb2.Top = pb2.Top + 7
                pb3.Top = pb3.Top + 7
                pb4.Top = pb4.Top + 7

            End If
        End If
        If e.KeyCode = Keys.Down Then
            pb1.Top = pb1.Top + 7
            pb2.Top = pb2.Top + 7
            pb3.Top = pb3.Top + 7
            pb4.Top = pb4.Top + 7
            pb1.Visible = False
            pb2.Visible = True
            pb3.Visible = False
            pb4.Visible = False
            If Label21.Bounds.IntersectsWith(pb1.Bounds) And Label21.Bounds.IntersectsWith(pb2.Bounds) And Label21.Bounds.IntersectsWith(pb3.Bounds) And Label21.Bounds.IntersectsWith(pb4.Bounds) Or lbl1.Bounds.IntersectsWith(pb1.Bounds) And lbl1.Bounds.IntersectsWith(pb2.Bounds) And lbl1.Bounds.IntersectsWith(pb3.Bounds) And lbl1.Bounds.IntersectsWith(pb4.Bounds) Or lbl2.Bounds.IntersectsWith(pb1.Bounds) And lbl2.Bounds.IntersectsWith(pb2.Bounds) And lbl2.Bounds.IntersectsWith(pb3.Bounds) And lbl2.Bounds.IntersectsWith(pb4.Bounds) Or lbl1.Bounds.IntersectsWith(pb1.Bounds) And lbl1.Bounds.IntersectsWith(pb2.Bounds) And lbl1.Bounds.IntersectsWith(pb3.Bounds) And lbl1.Bounds.IntersectsWith(pb4.Bounds) Or Label22.Bounds.IntersectsWith(pb1.Bounds) And Label22.Bounds.IntersectsWith(pb2.Bounds) And Label22.Bounds.IntersectsWith(pb3.Bounds) And Label22.Bounds.IntersectsWith(pb4.Bounds) Or lbl3.Bounds.IntersectsWith(pb1.Bounds) And lbl3.Bounds.IntersectsWith(pb2.Bounds) And lbl3.Bounds.IntersectsWith(pb3.Bounds) And lbl3.Bounds.IntersectsWith(pb4.Bounds) Or lbl3.Bounds.IntersectsWith(pb1.Bounds) And lbl3.Bounds.IntersectsWith(pb2.Bounds) And lbl3.Bounds.IntersectsWith(pb3.Bounds) And lbl3.Bounds.IntersectsWith(pb4.Bounds) Or lbl4.Bounds.IntersectsWith(pb1.Bounds) And lbl4.Bounds.IntersectsWith(pb2.Bounds) And lbl4.Bounds.IntersectsWith(pb3.Bounds) And lbl4.Bounds.IntersectsWith(pb4.Bounds) Or lbl7.Bounds.IntersectsWith(pb1.Bounds) And lbl7.Bounds.IntersectsWith(pb2.Bounds) And lbl7.Bounds.IntersectsWith(pb3.Bounds) And lbl7.Bounds.IntersectsWith(pb4.Bounds) Or Label1.Bounds.IntersectsWith(pb1.Bounds) And Label1.Bounds.IntersectsWith(pb2.Bounds) And Label1.Bounds.IntersectsWith(pb3.Bounds) And Label1.Bounds.IntersectsWith(pb4.Bounds) Or Label2.Bounds.IntersectsWith(pb1.Bounds) And Label2.Bounds.IntersectsWith(pb2.Bounds) And Label2.Bounds.IntersectsWith(pb3.Bounds) And Label2.Bounds.IntersectsWith(pb4.Bounds) Or Label3.Bounds.IntersectsWith(pb1.Bounds) And Label3.Bounds.IntersectsWith(pb2.Bounds) And Label3.Bounds.IntersectsWith(pb3.Bounds) And Label3.Bounds.IntersectsWith(pb4.Bounds) Or Label4.Bounds.IntersectsWith(pb1.Bounds) And Label4.Bounds.IntersectsWith(pb2.Bounds) And Label4.Bounds.IntersectsWith(pb3.Bounds) And Label4.Bounds.IntersectsWith(pb4.Bounds) Or Label5.Bounds.IntersectsWith(pb1.Bounds) And Label5.Bounds.IntersectsWith(pb2.Bounds) And Label5.Bounds.IntersectsWith(pb3.Bounds) And Label5.Bounds.IntersectsWith(pb4.Bounds) Or Label6.Bounds.IntersectsWith(pb1.Bounds) And Label6.Bounds.IntersectsWith(pb2.Bounds) And Label6.Bounds.IntersectsWith(pb3.Bounds) And Label6.Bounds.IntersectsWith(pb4.Bounds) Or Label7.Bounds.IntersectsWith(pb1.Bounds) And Label7.Bounds.IntersectsWith(pb2.Bounds) And Label7.Bounds.IntersectsWith(pb3.Bounds) And Label7.Bounds.IntersectsWith(pb4.Bounds) Or Label8.Bounds.IntersectsWith(pb1.Bounds) And Label8.Bounds.IntersectsWith(pb2.Bounds) And Label8.Bounds.IntersectsWith(pb3.Bounds) And Label8.Bounds.IntersectsWith(pb4.Bounds) Or Label9.Bounds.IntersectsWith(pb1.Bounds) And Label9.Bounds.IntersectsWith(pb2.Bounds) And Label9.Bounds.IntersectsWith(pb3.Bounds) And Label9.Bounds.IntersectsWith(pb4.Bounds) Or Label10.Bounds.IntersectsWith(pb1.Bounds) And Label10.Bounds.IntersectsWith(pb2.Bounds) And Label10.Bounds.IntersectsWith(pb3.Bounds) And Label10.Bounds.IntersectsWith(pb4.Bounds) Or Label11.Bounds.IntersectsWith(pb1.Bounds) And Label11.Bounds.IntersectsWith(pb2.Bounds) And Label11.Bounds.IntersectsWith(pb3.Bounds) And Label11.Bounds.IntersectsWith(pb4.Bounds) Or Label12.Bounds.IntersectsWith(pb1.Bounds) And Label12.Bounds.IntersectsWith(pb2.Bounds) And Label12.Bounds.IntersectsWith(pb3.Bounds) And Label12.Bounds.IntersectsWith(pb4.Bounds) Or Label13.Bounds.IntersectsWith(pb1.Bounds) And Label13.Bounds.IntersectsWith(pb2.Bounds) And Label13.Bounds.IntersectsWith(pb3.Bounds) And Label13.Bounds.IntersectsWith(pb4.Bounds) Or Label14.Bounds.IntersectsWith(pb1.Bounds) And Label14.Bounds.IntersectsWith(pb2.Bounds) And Label14.Bounds.IntersectsWith(pb3.Bounds) And Label14.Bounds.IntersectsWith(pb4.Bounds) Or Label15.Bounds.IntersectsWith(pb1.Bounds) And Label15.Bounds.IntersectsWith(pb2.Bounds) And Label15.Bounds.IntersectsWith(pb3.Bounds) And Label15.Bounds.IntersectsWith(pb4.Bounds) Or Label16.Bounds.IntersectsWith(pb1.Bounds) And Label16.Bounds.IntersectsWith(pb2.Bounds) And Label16.Bounds.IntersectsWith(pb3.Bounds) And Label16.Bounds.IntersectsWith(pb4.Bounds) Or Label17.Bounds.IntersectsWith(pb1.Bounds) And Label17.Bounds.IntersectsWith(pb2.Bounds) And Label17.Bounds.IntersectsWith(pb3.Bounds) And Label17.Bounds.IntersectsWith(pb4.Bounds) Or Label18.Bounds.IntersectsWith(pb1.Bounds) And Label18.Bounds.IntersectsWith(pb2.Bounds) And Label18.Bounds.IntersectsWith(pb3.Bounds) And Label18.Bounds.IntersectsWith(pb4.Bounds) Or Label23.Bounds.IntersectsWith(pb1.Bounds) And Label23.Bounds.IntersectsWith(pb2.Bounds) And Label23.Bounds.IntersectsWith(pb3.Bounds) And Label23.Bounds.IntersectsWith(pb4.Bounds) Or Label24.Bounds.IntersectsWith(pb1.Bounds) And Label24.Bounds.IntersectsWith(pb2.Bounds) And Label24.Bounds.IntersectsWith(pb3.Bounds) And Label24.Bounds.IntersectsWith(pb4.Bounds) Or Label25.Bounds.IntersectsWith(pb1.Bounds) And Label25.Bounds.IntersectsWith(pb2.Bounds) And Label25.Bounds.IntersectsWith(pb3.Bounds) And Label25.Bounds.IntersectsWith(pb4.Bounds) Or Label26.Bounds.IntersectsWith(pb1.Bounds) And Label26.Bounds.IntersectsWith(pb2.Bounds) And Label26.Bounds.IntersectsWith(pb3.Bounds) And Label26.Bounds.IntersectsWith(pb4.Bounds) Then
                pb1.Top = pb1.Top - 7
                pb2.Top = pb2.Top - 7
                pb3.Top = pb3.Top - 7
                pb4.Top = pb4.Top - 7

            End If
        End If
        If pb1.Bounds.IntersectsWith(Label28.Bounds) And pb2.Bounds.IntersectsWith(Label28.Bounds) And pb3.Bounds.IntersectsWith(Label28.Bounds) And pb4.Bounds.IntersectsWith(Label28.Bounds) Then
            pb1.Location = New Point(720, 269)
            pb2.Location = New Point(720, 269)
            pb3.Location = New Point(720, 269)
            pb4.Location = New Point(720, 269)

        End If

        If pb1.Bounds.IntersectsWith(Label27.Bounds) And pb2.Bounds.IntersectsWith(Label27.Bounds) And pb3.Bounds.IntersectsWith(Label27.Bounds) And pb4.Bounds.IntersectsWith(Label27.Bounds) Then
            pb1.Location = New Point(26, 269)
            pb2.Location = New Point(26, 269)
            pb3.Location = New Point(26, 269)
            pb4.Location = New Point(26, 269)
        End If
        If PictureBox3.Bounds.IntersectsWith(pb1.Bounds) Or PictureBox4.Bounds.IntersectsWith(pb1.Bounds) Or PictureBox5.Bounds.IntersectsWith(pb1.Bounds) Or PictureBox6.Bounds.IntersectsWith(pb1.Bounds) Then
            rojo.Visible = False
            casi_rojo.Visible = False
            peligro_rojo.Visible = True

            amarillo.Visible = False
            peligro_amarillo.Visible = True
            casi_amarillo.Visible = False

            rosado.Visible = False
            peligro_rosado.Visible = True
            casi_rosado.Visible = False

            Timer4.Enabled = False
            Timer4.Enabled = True
            Timer4.Stop()
            Timer4.Start()
            contador = 75
            contador2 = 25
            Timer5.Stop()
        End If

        If PictureBox3.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox3.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox3.Visible = False

        End If
        If PictureBox4.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox4.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox4.Visible = False

        End If
        If PictureBox5.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox5.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox5.Visible = False

        End If
        If PictureBox6.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox6.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox6.Visible = False

        End If
        If PictureBox7.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox7.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox7.Visible = False

        End If
        If PictureBox8.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox8.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox8.Visible = False

        End If
        If PictureBox9.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox9.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox9.Visible = False

        End If
        If PictureBox10.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox10.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox10.Visible = False

        End If
        If PictureBox11.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox11.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox11.Visible = False

        End If
        If PictureBox12.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox12.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox12.Visible = False

        End If
        If PictureBox13.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox13.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox13.Visible = False

        End If
        If PictureBox14.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox14.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox14.Visible = False

        End If
        If PictureBox15.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox15.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox15.Visible = False

        End If
        If PictureBox16.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox16.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox16.Visible = False

        End If
        If PictureBox17.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox17.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox17.Visible = False

        End If
        If PictureBox18.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox18.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox18.Visible = False

        End If
        If PictureBox19.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox19.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox19.Visible = False

        End If
        If PictureBox20.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox20.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox20.Visible = False

        End If
        If PictureBox21.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox21.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox21.Visible = False

        End If
        If PictureBox22.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox22.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox22.Visible = False

        End If
        If PictureBox23.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox23.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox23.Visible = False

        End If
        If PictureBox24.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox24.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox24.Visible = False

        End If
        If PictureBox25.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox25.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox25.Visible = False

        End If
        If PictureBox26.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox26.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox26.Visible = False

        End If
        If PictureBox27.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox27.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox27.Visible = False

        End If
        If PictureBox28.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox28.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox28.Visible = False

        End If
        If PictureBox29.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox29.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox29.Visible = False

        End If
        If PictureBox30.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox30.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox30.Visible = False
        End If
        If PictureBox31.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox31.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox31.Visible = False

        End If
        If PictureBox32.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox32.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox32.Visible = False

        End If
        If PictureBox33.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox33.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox33.Visible = False

        End If
        If PictureBox34.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox34.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox34.Visible = False
        End If
        If PictureBox35.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox35.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox35.Visible = False

        End If
        If PictureBox36.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox36.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox36.Visible = False

        End If
        If PictureBox37.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox37.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox37.Visible = False

        End If
        If PictureBox38.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox38.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox38.Visible = False

        End If
        If PictureBox39.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox39.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox39.Visible = False

        End If
        If PictureBox40.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox40.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox40.Visible = False

        End If
        If PictureBox41.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox41.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox41.Visible = False

        End If
        If PictureBox42.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox42.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox42.Visible = False

        End If
        If PictureBox43.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox43.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox43.Visible = False

        End If
        If PictureBox44.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox44.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox44.Visible = False

        End If
        If PictureBox45.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox45.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox45.Visible = False

        End If
        If PictureBox46.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox46.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox46.Visible = False

        End If
        If PictureBox47.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox47.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox47.Visible = False

        End If
        If PictureBox48.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox48.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox48.Visible = False

        End If
        If PictureBox49.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox49.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox49.Visible = False

        End If
        If PictureBox50.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox50.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox50.Visible = False
        End If
        If PictureBox51.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox51.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox51.Visible = False
        End If
        If PictureBox52.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox52.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox52.Visible = False
        End If
        If PictureBox53.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox53.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox53.Visible = False
        End If
        If PictureBox54.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox54.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox54.Visible = False
        End If
        If PictureBox55.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox55.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox55.Visible = False
        End If
        If PictureBox56.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox56.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox56.Visible = False
        End If
        If PictureBox57.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox57.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox57.Visible = False
        End If
        If PictureBox58.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox58.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox58.Visible = False
        End If
        If PictureBox59.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox59.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox59.Visible = False
        End If
        If PictureBox60.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox60.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox60.Visible = False
        End If
        If PictureBox61.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox61.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox61.Visible = False
        End If
        If PictureBox62.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox62.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox62.Visible = False
        End If
        If PictureBox63.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox63.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox63.Visible = False
        End If
        If PictureBox64.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox64.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox64.Visible = False
        End If
        If PictureBox65.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox65.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox65.Visible = False
        End If
        If PictureBox66.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox66.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox66.Visible = False
        End If
        If PictureBox67.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox67.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox67.Visible = False
        End If
        If PictureBox68.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox68.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox68.Visible = False
        End If
        If PictureBox69.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox69.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox69.Visible = False
        End If
        If PictureBox70.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox70.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox70.Visible = False
        End If
        If PictureBox71.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox71.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox71.Visible = False
        End If
        If PictureBox72.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox72.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox72.Visible = False
        End If
        If PictureBox73.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox73.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox73.Visible = False
        End If
        If PictureBox74.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox74.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox74.Visible = False
        End If
        If PictureBox75.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox75.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox75.Visible = False
        End If
        If PictureBox76.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox76.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox76.Visible = False
        End If
        If PictureBox77.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox77.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox77.Visible = False
        End If
        If PictureBox78.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox78.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox78.Visible = False
        End If
        If PictureBox79.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox79.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox79.Visible = False
        End If
        If PictureBox80.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox80.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox80.Visible = False
        End If
        If PictureBox81.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox81.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox81.Visible = False
        End If
        If PictureBox82.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox82.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox82.Visible = False
        End If
        If PictureBox83.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox83.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox83.Visible = False
        End If
        If PictureBox84.Bounds.IntersectsWith(pb1.Bounds) Then
            PictureBox84.Location = New Point(1000, 1000)
            Label20.Text = Val(Label20.Text) + 10
            PictureBox84.Visible = False
        End If

        If Val(Label39.Text) = 0 Then
            MessageBox.Show("perdiste todas tus vidas, lo siento", "PACMAN")
            Estadisticas.dgv_ranking.Rows.Add()

            Estadisticas.dgv_ranking.Rows(Estadisticas.dgv_ranking.Rows.Count - 1).Cells(0).Value = inicio.TextBox1.Text
            Estadisticas.dgv_ranking.Rows(Estadisticas.dgv_ranking.Rows.Count - 1).Cells(1).Value = Label39.Text
            Estadisticas.dgv_ranking.Rows(Estadisticas.dgv_ranking.Rows.Count - 1).Cells(2).Value = Label20.Text
            Estadisticas.dgv_ranking.Rows(Estadisticas.dgv_ranking.Rows.Count - 1).Cells(3).Value = lbl_minutero.Text + ":" + lbl_secundero.Text + ":" + lbl_decimal.Text
            Timer6.Stop()
            Me.Close()
            inicio.Show()
            inicio.ProgressBar1.Visible = False
            inicio.Label2.Visible = False
            inicio.TextBox1.Text = ""
        End If
        If PictureBox3.Visible = False And PictureBox4.Visible = False And PictureBox5.Visible = False And PictureBox6.Visible = False And PictureBox7.Visible = False And PictureBox8.Visible = False And PictureBox9.Visible = False And PictureBox10.Visible = False And PictureBox11.Visible = False And PictureBox12.Visible = False And PictureBox13.Visible = False And PictureBox14.Visible = False And PictureBox15.Visible = False And PictureBox16.Visible = False And PictureBox17.Visible = False And PictureBox18.Visible = False And PictureBox19.Visible = False And PictureBox20.Visible = False And PictureBox21.Visible = False And PictureBox22.Visible = False And PictureBox23.Visible = False And PictureBox24.Visible = False And PictureBox25.Visible = False And PictureBox26.Visible = False And PictureBox27.Visible = False And PictureBox28.Visible = False And PictureBox29.Visible = False And PictureBox30.Visible = False And PictureBox31.Visible = False And PictureBox32.Visible = False And PictureBox33.Visible = False And PictureBox34.Visible = False And PictureBox35.Visible = False And PictureBox36.Visible = False And PictureBox37.Visible = False And PictureBox38.Visible = False And PictureBox39.Visible = False And PictureBox40.Visible = False And PictureBox41.Visible = False And PictureBox42.Visible = False And PictureBox43.Visible = False And PictureBox44.Visible = False And PictureBox45.Visible = False And PictureBox46.Visible = False And PictureBox47.Visible = False And PictureBox48.Visible = False And PictureBox49.Visible = False And PictureBox50.Visible = False And PictureBox51.Visible = False And PictureBox52.Visible = False And PictureBox53.Visible = False And PictureBox54.Visible = False And PictureBox55.Visible = False And PictureBox56.Visible = False And PictureBox57.Visible = False And PictureBox58.Visible = False And PictureBox59.Visible = False And PictureBox60.Visible = False And PictureBox61.Visible = False And PictureBox62.Visible = False And PictureBox63.Visible = False And PictureBox64.Visible = False And PictureBox65.Visible = False And PictureBox66.Visible = False And PictureBox67.Visible = False And PictureBox68.Visible = False And PictureBox69.Visible = False And PictureBox70.Visible = False And PictureBox71.Visible = False And PictureBox72.Visible = False And PictureBox73.Visible = False And PictureBox74.Visible = False And PictureBox75.Visible = False And PictureBox76.Visible = False And PictureBox77.Visible = False And PictureBox78.Visible = False And PictureBox79.Visible = False And PictureBox80.Visible = False And PictureBox81.Visible = False And PictureBox82.Visible = False And PictureBox83.Visible = False And PictureBox84.Visible = False Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            MessageBox.Show("¡ganaste " + inicio.TextBox1.Text + "!", "PACMAN")
            Estadisticas.dgv_ranking.Rows.Add()

            Estadisticas.dgv_ranking.Rows(Estadisticas.dgv_ranking.Rows.Count - 1).Cells(0).Value = inicio.TextBox1.Text
            Estadisticas.dgv_ranking.Rows(Estadisticas.dgv_ranking.Rows.Count - 1).Cells(1).Value = Label39.Text
            Estadisticas.dgv_ranking.Rows(Estadisticas.dgv_ranking.Rows.Count - 1).Cells(2).Value = Label20.Text
            Estadisticas.dgv_ranking.Rows(Estadisticas.dgv_ranking.Rows.Count - 1).Cells(3).Value = lbl_minutero.Text + ":" + lbl_secundero.Text + ":" + lbl_decimal.Text
            Timer6.Stop()
            Me.Close()
            inicio.Show()
            inicio.ProgressBar1.Visible = False
            inicio.Label2.Visible = False
            inicio.TextBox1.Text = ""
        End If
        'inicio de amarillo'
        If pb1.Bounds.IntersectsWith(amarillo.Bounds) And peligro_amarillo.Visible = False And casi_amarillo.Visible = False Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()

            rojo.Location = New Point(455, 315)
            peligro_rojo.Location = New Point(455, 315)
            casi_rojo.Location = New Point(455, 315)

            amarillo.Location = New Point(378, 315)
            peligro_amarillo.Location = New Point(378, 315)
            casi_amarillo.Location = New Point(378, 315)

            rosado.Location = New Point(301, 315)
            peligro_rosado.Location = New Point(301, 315)
            casi_rosado.Location = New Point(301, 315)

            pb1.Location = New Point(378, 387)
            pb2.Location = New Point(378, 387)
            pb3.Location = New Point(378, 387)
            pb4.Location = New Point(378, 387)

            a = 0
            b = 0
            c = 0
            Timer1.Start()
            Timer2.Start()
            Timer3.Start()

            Label39.Text = Val(Label39.Text) - 1

        End If
        'fin de amarillo'

        'inicio de rojo'
        If pb1.Bounds.IntersectsWith(rojo.Bounds) And peligro_rojo.Visible = False And casi_rojo.Visible = False Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            rojo.Location = New Point(455, 315)
            peligro_rojo.Location = New Point(455, 315)
            casi_rojo.Location = New Point(455, 315)

            amarillo.Location = New Point(378, 315)
            peligro_amarillo.Location = New Point(378, 315)
            casi_amarillo.Location = New Point(378, 315)

            rosado.Location = New Point(301, 315)
            peligro_rosado.Location = New Point(301, 315)
            casi_rosado.Location = New Point(301, 315)
            pb1.Location = New Point(378, 387)
            pb2.Location = New Point(378, 387)
            pb3.Location = New Point(378, 387)
            pb4.Location = New Point(378, 387)
            MsgBox("perdiste")
            a = 0
            b = 0
            c = 0
            Timer1.Start()
            Timer2.Start()
            Timer3.Start()

            Label39.Text = Val(Label39.Text) - 1
        End If
        'fin de rojo'

        'inicio de rosado'
        If pb1.Bounds.IntersectsWith(rosado.Bounds) And peligro_rosado.Visible = False And casi_rosado.Visible = False Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            rojo.Location = New Point(455, 315)
            peligro_rojo.Location = New Point(455, 315)
            casi_rojo.Location = New Point(455, 315)

            amarillo.Location = New Point(378, 315)
            peligro_amarillo.Location = New Point(378, 315)
            casi_amarillo.Location = New Point(378, 315)

            rosado.Location = New Point(301, 315)
            peligro_rosado.Location = New Point(301, 315)
            casi_rosado.Location = New Point(301, 315)

            pb1.Location = New Point(378, 387)
            pb2.Location = New Point(378, 387)
            pb3.Location = New Point(378, 387)
            pb4.Location = New Point(378, 387)
            MsgBox("perdiste")
            a = 0
            b = 0
            c = 0
            Timer1.Start()
            Timer2.Start()
            Timer3.Start()

            Label39.Text = Val(Label39.Text) - 1
        End If
        'fin de rosado'

        'inicio rosado
        If peligro_rosado.Bounds.IntersectsWith(pb1.Bounds) And rosado.Visible = False And casi_rosado.Visible = False Then
            Label20.Text = Val(Label20.Text) + 50
            rosado.Location = New Point(298, 313)
            peligro_rosado.Location = New Point(298, 313)
            casi_rosado.Location = New Point(298, 313)
            c = 0
            Timer3.Stop()
            Timer3.Start()
        End If
        If casi_rosado.Bounds.IntersectsWith(pb1.Bounds) And rosado.Visible = False And peligro_rosado.Visible = False Then
            Label20.Text = Val(Label20.Text) + 50
            rosado.Location = New Point(298, 313)
            peligro_rosado.Location = New Point(298, 313)
            casi_rosado.Location = New Point(298, 313)
            c = 0
            Timer3.Stop()
            Timer3.Start()
        End If
        'fin rosado

        'inicio rojo
        If peligro_rojo.Bounds.IntersectsWith(pb1.Bounds) And rojo.Visible = False And casi_rojo.Visible = False Then
            Label20.Text = Val(Label20.Text) + 50
            rojo.Location = New Point(452, 313)
            peligro_rojo.Location = New Point(452, 313)
            casi_rojo.Location = New Point(452, 313)
            b = 0
            Timer2.Stop()
            Timer2.Start()
        End If
        If casi_rojo.Bounds.IntersectsWith(pb1.Bounds) And rojo.Visible = False And peligro_rojo.Visible = False Then
            Label20.Text = Val(Label20.Text) + 50
            rojo.Location = New Point(378, 315)
            peligro_rojo.Location = New Point(378, 315)
            casi_rojo.Location = New Point(378, 315)
            b = 0
            Timer1.Stop()
            Timer1.Start()
        End If
        'fin rojo


        'inicio amarillo
        If peligro_amarillo.Bounds.IntersectsWith(pb1.Bounds) And amarillo.Visible = False Then
            Label20.Text = Val(Label20.Text) + 50
            amarillo.Location = New Point(376, 313)
            peligro_amarillo.Location = New Point(376, 313)
            casi_amarillo.Location = New Point(376, 313)
            a = 0
            Timer2.Stop()
            Timer2.Start()
        End If
        If casi_amarillo.Bounds.IntersectsWith(pb1.Bounds) And amarillo.Visible = False Then
            Label20.Text = Val(Label20.Text) + 50
            amarillo.Location = New Point(376, 313)
            peligro_amarillo.Location = New Point(376, 313)
            casi_amarillo.Location = New Point(376, 313)
            a = 0
            Timer1.Stop()
            Timer1.Start()
        End If
        'fin amarillo
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If a = 0 Then
            amarillo.Top -= 5
            peligro_amarillo.Top -= 5
            casi_amarillo.Top -= 5
            If amarillo.Bounds.IntersectsWith(Label14.Bounds) Then
                a = 1
                amarillo.Left += 5
                peligro_amarillo.Left += 5
                casi_amarillo.Left += 5


            End If
        End If

        If a = 1 Then
            amarillo.Left += 5
            peligro_amarillo.Left += 5
            casi_amarillo.Left += 5
            If amarillo.Bounds.IntersectsWith(Label23.Bounds) Then
                a = 2
                amarillo.Top -= 5
                peligro_amarillo.Top -= 5
                casi_amarillo.Top -= 5


            End If
        End If
        If a = 2 Then
            amarillo.Top -= 5
            peligro_amarillo.Top -= 5
            casi_amarillo.Top -= 5
            If amarillo.Bounds.IntersectsWith(lbl3.Bounds) Then
                a = 3
                amarillo.Left += 5
                peligro_amarillo.Left += 5
                casi_amarillo.Left += 5

            End If
        End If
        If a = 3 Then
            amarillo.Left -= 5
            peligro_amarillo.Left -= 5
            casi_amarillo.Left -= 5
            If amarillo.Bounds.IntersectsWith(Label10.Bounds) Then
                a = 4
                amarillo.Top += 5
                peligro_amarillo.Top += 5
                casi_amarillo.Top += 5

            End If
        End If
        If a = 4 Then
            amarillo.Top += 5
            peligro_amarillo.Top += 5
            casi_amarillo.Top += 5
            If amarillo.Bounds.IntersectsWith(Label18.Bounds) Then
                a = 5
                amarillo.Left -= 5
                peligro_amarillo.Left -= 5
                casi_amarillo.Left -= 5

            End If
        End If
        If a = 5 Then
            amarillo.Left -= 5
            peligro_amarillo.Left -= 5
            casi_amarillo.Left -= 5
            If amarillo.Bounds.IntersectsWith(Label31.Bounds) Then
                a = 6
                amarillo.Top -= 5
                peligro_amarillo.Top -= 5
                casi_amarillo.Top -= 5

            End If
        End If
        If a = 6 Then
            amarillo.Top -= 5
            peligro_amarillo.Top -= 5
            casi_amarillo.Top -= 5
            If amarillo.Bounds.IntersectsWith(lbl3.Bounds) Then
                a = 7
                amarillo.Left -= 5
                peligro_amarillo.Left -= 5
                casi_amarillo.Left -= 5

            End If
        End If
        If a = 7 Then
            amarillo.Left -= 5
            peligro_amarillo.Left -= 5
            casi_amarillo.Left -= 5
            If amarillo.Bounds.IntersectsWith(Label9.Bounds) Then
                a = 8
                amarillo.Top += 5
                peligro_amarillo.Top += 5
                casi_amarillo.Top += 5

            End If
        End If
        If a = 8 Then
            amarillo.Top += 5
            peligro_amarillo.Top += 5
            casi_amarillo.Top += 5
            If amarillo.Bounds.IntersectsWith(Label32.Bounds) Then
                a = 9
                amarillo.Left += 5
                peligro_amarillo.Left += 5
                casi_amarillo.Left += 5

            End If
        End If
        If a = 9 Then
            amarillo.Left += 5
            peligro_amarillo.Left += 5
            casi_amarillo.Left += 5
            If amarillo.Bounds.IntersectsWith(Label14.Bounds) Then
                a = 10
                amarillo.Top += 5
                peligro_amarillo.Top += 5
                casi_amarillo.Top += 5

            End If
        End If
        If a = 10 Then
            amarillo.Top += 5
            peligro_amarillo.Top += 5
            casi_amarillo.Top += 5
            If amarillo.Bounds.IntersectsWith(Label33.Bounds) Then
                a = 11
                amarillo.Left += 5
                peligro_amarillo.Left += 5
                casi_amarillo.Left += 5

            End If
        End If
        If a = 11 Then
            amarillo.Left += 5
            peligro_amarillo.Left += 5
            casi_amarillo.Left += 5
            If amarillo.Bounds.IntersectsWith(Label34.Bounds) Then
                a = 12
                amarillo.Top -= 5
                peligro_amarillo.Top -= 5
                casi_amarillo.Top -= 5

            End If
        End If
        If a = 12 Then
            amarillo.Top -= 5
            peligro_amarillo.Top -= 5
            casi_amarillo.Top -= 5
            If amarillo.Bounds.IntersectsWith(Label13.Bounds) Then
                a = 13
                amarillo.Left += 5
                peligro_amarillo.Left += 5
                casi_amarillo.Left += 5

            End If
        End If
        If a = 13 Then
            amarillo.Left += 5
            peligro_amarillo.Left += 5
            casi_amarillo.Left += 5
            If amarillo.Bounds.IntersectsWith(Label10.Bounds) Then
                a = 14
                amarillo.Top += 5
                peligro_amarillo.Top += 5
                casi_amarillo.Top += 5

            End If
        End If
        If a = 14 Then
            amarillo.Top += 5
            peligro_amarillo.Top += 5
            casi_amarillo.Top += 5
            If amarillo.Bounds.IntersectsWith(Label35.Bounds) Then
                a = 15
                amarillo.Left += 5
                peligro_amarillo.Left += 5
                casi_amarillo.Left += 5

            End If
        End If
        If a = 15 Then
            amarillo.Left += 5
            peligro_amarillo.Left += 5
            casi_amarillo.Left += 5
            If amarillo.Bounds.IntersectsWith(Label23.Bounds) Then
                a = 2
                amarillo.Top -= 5
                peligro_amarillo.Top -= 5
                casi_amarillo.Top -= 5

            End If
        End If

        If amarillo.Bounds.IntersectsWith(pb1.Bounds) And peligro_amarillo.Visible = False And casi_amarillo.Visible = False Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            rojo.Location = New Point(455, 315)
            peligro_rojo.Location = New Point(455, 315)
            casi_rojo.Location = New Point(455, 315)

            amarillo.Location = New Point(378, 315)
            peligro_amarillo.Location = New Point(378, 315)
            casi_amarillo.Location = New Point(378, 315)

            rosado.Location = New Point(301, 315)
            peligro_rosado.Location = New Point(301, 315)
            casi_rosado.Location = New Point(301, 315)

            pb1.Location = New Point(378, 387)
            pb2.Location = New Point(378, 387)
            pb3.Location = New Point(378, 387)
            pb4.Location = New Point(378, 387)
            MsgBox("perdiste")
            a = 0
            b = 0
            c = 0
            Timer1.Start()
            Timer2.Start()
            Timer3.Start()

            Label39.Text = Val(Label39.Text) - 1
        End If
        'inicio amarillo
        If peligro_amarillo.Bounds.IntersectsWith(pb1.Bounds) And amarillo.Visible = False Then
            Label20.Text = Val(Label20.Text) + 50
            amarillo.Visible = False
            amarillo.Location = New Point(376, 313)
            peligro_amarillo.Location = New Point(376, 313)
            casi_amarillo.Location = New Point(376, 313)
            a = 0
            Timer2.Stop()
            Timer2.Start()
        End If
        If casi_amarillo.Bounds.IntersectsWith(pb1.Bounds) And amarillo.Visible = False Then
            Label20.Text = Val(Label20.Text) + 50
            amarillo.Location = New Point(376, 313)
            amarillo.Visible = False
            peligro_amarillo.Location = New Point(376, 313)
            casi_amarillo.Location = New Point(376, 313)
            a = 0
            Timer1.Stop()
            Timer1.Start()
        End If
        'fin amarillo
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If b = 0 Then
            rojo.Left -= 5
            peligro_rojo.Left -= 5
            casi_rojo.Left -= 5
            If rojo.Bounds.IntersectsWith(Label30.Bounds) Then
                b = 1
                rojo.Top -= 5
                peligro_rojo.Top -= 5
                casi_rojo.Top -= 5

            End If
        End If
        If b = 1 Then
            rojo.Top -= 5
            peligro_rojo.Top -= 5
            casi_rojo.Top -= 5
            If rojo.Bounds.IntersectsWith(Label14.Bounds) Then
                b = 2
                rojo.Left -= 5
                peligro_rojo.Left -= 5
                casi_rojo.Left -= 5

            End If
        End If
        If b = 2 Then
            rojo.Left -= 5
            peligro_rojo.Left -= 5
            casi_rojo.Left -= 5
            If rojo.Bounds.IntersectsWith(Label26.Bounds) Then
                b = 3
                rojo.Top -= 5
                peligro_rojo.Top -= 5
                casi_rojo.Top -= 5

            End If
        End If
        If b = 3 Then
            rojo.Top -= 5
            peligro_rojo.Top -= 5
            casi_rojo.Top -= 5
            If rojo.Bounds.IntersectsWith(lbl3.Bounds) Then
                b = 4
                rojo.Left += 5
                peligro_rojo.Left += 5
                casi_rojo.Left += 5

            End If
        End If
        If b = 4 Then
            rojo.Left += 5
            peligro_rojo.Left += 5
            casi_rojo.Left += 5
            If rojo.Bounds.IntersectsWith(Label9.Bounds) Then
                b = 5
                rojo.Top += 5
                peligro_rojo.Top += 5
                casi_rojo.Top += 5

            End If
        End If
        If b = 5 Then
            rojo.Top += 5
            peligro_rojo.Top += 5
            casi_rojo.Top += 5
            If rojo.Bounds.IntersectsWith(Label15.Bounds) Then
                b = 6
                rojo.Left += 5
                peligro_rojo.Left += 5
                casi_rojo.Left += 5

            End If
        End If
        If b = 6 Then
            rojo.Left += 5
            peligro_rojo.Left += 5
            casi_rojo.Left += 5
            If rojo.Bounds.IntersectsWith(Label36.Bounds) Then
                b = 7
                rojo.Top += 5
                peligro_rojo.Top += 5
                casi_rojo.Top += 5

            End If
        End If
        If b = 7 Then
            rojo.Top += 5
            peligro_rojo.Top += 5
            casi_rojo.Top += 5
            If rojo.Bounds.IntersectsWith(Label37.Bounds) Then
                b = 8
                rojo.Left -= 5
                peligro_rojo.Left -= 5
                casi_rojo.Left -= 5

            End If
        End If
        If b = 8 Then
            rojo.Left -= 5
            peligro_rojo.Left -= 5
            casi_rojo.Left -= 5
            If rojo.Bounds.IntersectsWith(Label25.Bounds) Then
                b = 9
                rojo.Top += 5
                peligro_rojo.Top += 5
                casi_rojo.Top += 5

            End If
        End If
        If b = 9 Then
            rojo.Top += 5
            peligro_rojo.Top += 5
            casi_rojo.Top += 5
            If rojo.Bounds.IntersectsWith(lbl4.Bounds) Then
                b = 10
                rojo.Left += 5
                peligro_rojo.Left += 5
                casi_rojo.Left += 5

            End If
        End If
        If b = 10 Then
            rojo.Left += 5
            peligro_rojo.Left += 5
            casi_rojo.Left += 5
            If rojo.Bounds.IntersectsWith(lbl2.Bounds) Then
                b = 11
                rojo.Top -= 5
                peligro_rojo.Top -= 5
                casi_rojo.Top -= 5

            End If
        End If
        If b = 11 Then
            rojo.Top -= 5
            peligro_rojo.Top -= 5
            casi_rojo.Top -= 5

            If rojo.Bounds.IntersectsWith(Label16.Bounds) Then
                b = 12
                rojo.Left += 5
                peligro_rojo.Left += 5
                casi_rojo.Left += 5

            End If
        End If
        If b = 12 Then
            rojo.Left += 5
            peligro_rojo.Left += 5
            casi_rojo.Left += 5
            If rojo.Bounds.IntersectsWith(Label8.Bounds) Then
                b = 13
                rojo.Top -= 5
                peligro_rojo.Top -= 5
                casi_rojo.Top -= 5

            End If
        End If
        If b = 13 Then
            rojo.Top -= 5
            peligro_rojo.Top -= 5
            casi_rojo.Top -= 5
            If rojo.Bounds.IntersectsWith(Label40.Bounds) Then
                b = 2
                rojo.Left -= 5
                peligro_rojo.Left -= 5
                casi_rojo.Left -= 5

            End If
        End If
        If rojo.Bounds.IntersectsWith(pb1.Bounds) And peligro_rojo.Visible = False And casi_rojo.Visible = False Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            rojo.Location = New Point(455, 315)
            peligro_rojo.Location = New Point(455, 315)
            casi_rojo.Location = New Point(455, 315)

            amarillo.Location = New Point(378, 315)
            peligro_amarillo.Location = New Point(378, 315)
            casi_amarillo.Location = New Point(378, 315)

            rosado.Location = New Point(301, 315)
            peligro_rosado.Location = New Point(301, 315)
            casi_rosado.Location = New Point(301, 315)

            pb1.Location = New Point(378, 387)
            pb2.Location = New Point(378, 387)
            pb3.Location = New Point(378, 387)
            pb4.Location = New Point(378, 387)
            MsgBox("perdiste", )
            a = 0
            b = 0
            c = 0
            Timer1.Start()
            Timer2.Start()
            Timer3.Start()

            Label39.Text = Val(Label39.Text) - 1
        End If
        'inicio rojo
        If peligro_rojo.Bounds.IntersectsWith(pb1.Bounds) And rojo.Visible = False And casi_rojo.Visible = False Then
            Label20.Text = Val(Label20.Text) + 50
            rojo.Location = New Point(452, 313)
            rojo.Visible = False
            peligro_rojo.Location = New Point(452, 313)
            casi_rojo.Location = New Point(452, 313)
            b = 0
            Timer2.Stop()
            Timer2.Start()
        End If
        If casi_rojo.Bounds.IntersectsWith(pb1.Bounds) And rojo.Visible = False And peligro_rojo.Visible = False Then
            Label20.Text = Val(Label20.Text) + 50
            rojo.Location = New Point(378, 315)
            rojo.Visible = False
            peligro_rojo.Location = New Point(378, 315)
            casi_rojo.Location = New Point(378, 315)
            b = 0
            Timer1.Stop()
            Timer1.Start()
        End If
        'fin rojo
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If c = 0 Then
            rosado.Left += 5
            peligro_rosado.Left += 5
            casi_rosado.Left += 5
            If rosado.Bounds.IntersectsWith(Label29.Bounds) Then
                c = 1
                rosado.Top -= 5
                peligro_rosado.Top -= 5
                casi_rosado.Top -= 5
            End If
        End If
        If c = 1 Then
            rosado.Top -= 5
            peligro_rosado.Top -= 5
            casi_rosado.Top -= 5
            If rosado.Bounds.IntersectsWith(Label14.Bounds) Then
                c = 2
                rosado.Left += 5
                peligro_rosado.Left += 5
                casi_rosado.Left += 5
            End If
        End If
        If c = 2 Then
            rosado.Left += 5
            peligro_rosado.Left += 5
            casi_rosado.Left += 5
            If rosado.Bounds.IntersectsWith(Label41.Bounds) Then
                c = 3
                rosado.Top += 5
                peligro_rosado.Top += 5
                casi_rosado.Top += 5
            End If
        End If
        If c = 3 Then
            rosado.Top += 5
            peligro_rosado.Top += 5
            casi_rosado.Top += 5
            If rosado.Bounds.IntersectsWith(Label42.Bounds) Then
                c = 4
                rosado.Left += 5
                peligro_rosado.Left += 5
                casi_rosado.Left += 5
            End If
        End If
        If c = 4 Then
            rosado.Left += 5
            peligro_rosado.Left += 5
            casi_rosado.Left += 5
            If rosado.Bounds.IntersectsWith(Label24.Bounds) Then
                c = 5
                rosado.Top += 5
                peligro_rosado.Top += 5
                casi_rosado.Top += 5
            End If
        End If
        If c = 5 Then
            rosado.Top += 5
            peligro_rosado.Top += 5
            casi_rosado.Top += 5
            If rosado.Bounds.IntersectsWith(lbl4.Bounds) Then
                c = 6
                rosado.Left -= 5
                peligro_rosado.Left -= 5
                casi_rosado.Left -= 5
            End If
        End If
        If c = 6 Then
            rosado.Left -= 5
            peligro_rosado.Left -= 5
            casi_rosado.Left -= 5
            If rosado.Bounds.IntersectsWith(Label5.Bounds) Then
                c = 7
                rosado.Top -= 5
                peligro_rosado.Top -= 5
                casi_rosado.Top -= 5
            End If
        End If
        If c = 7 Then
            rosado.Top -= 5
            peligro_rosado.Top -= 5
            casi_rosado.Top -= 5
            If rosado.Bounds.IntersectsWith(Label17.Bounds) Then
                c = 8
                rosado.Left -= 5
                peligro_rosado.Left -= 5
                casi_rosado.Left -= 5
            End If
        End If
        If c = 8 Then
            rosado.Left -= 5
            peligro_rosado.Left -= 5
            casi_rosado.Left -= 5
            If rosado.Bounds.IntersectsWith(Label6.Bounds) Then
                c = 9
                rosado.Top += 5
                peligro_rosado.Top += 5
                casi_rosado.Top += 5
            End If
        End If
        If c = 9 Then
            rosado.Top += 5
            peligro_rosado.Top += 5
            casi_rosado.Top += 5
            If rosado.Bounds.IntersectsWith(Label43.Bounds) Then
                c = 10
                rosado.Left -= 5
                peligro_rosado.Left -= 5
                casi_rosado.Left -= 5
            End If
        End If
        If c = 10 Then
            rosado.Left -= 5
            peligro_rosado.Left -= 5
            casi_rosado.Left -= 5
            If rosado.Bounds.IntersectsWith(lbl2.Bounds) Then
                c = 11
                rosado.Top += 5
                peligro_rosado.Top += 5
                casi_rosado.Top += 5

            End If
        End If
        If c = 11 Then
            rosado.Top += 5
            peligro_rosado.Top += 5
            casi_rosado.Top += 5
            If rosado.Bounds.IntersectsWith(Label44.Bounds) Then
                c = 12
                rosado.Left += 5
                peligro_rosado.Left += 5
                casi_rosado.Left += 5

            End If
        End If
        If c = 12 Then
            rosado.Left += 5
            peligro_rosado.Left += 5
            casi_rosado.Left += 5
            If rosado.Bounds.IntersectsWith(Label5.Bounds) Then
                c = 13
                rosado.Top += 5
                peligro_rosado.Top += 5
                casi_rosado.Top += 5
            End If
        End If
        If c = 13 Then
            rosado.Top += 5
            peligro_rosado.Top += 5
            casi_rosado.Top += 5
            If rosado.Bounds.IntersectsWith(lbl4.Bounds) Then
                c = 14
                rosado.Left -= 5
                peligro_rosado.Left -= 5
                casi_rosado.Left -= 5

            End If
        End If
        If c = 14 Then
            rosado.Left -= 5
            peligro_rosado.Left -= 5
            casi_rosado.Left -= 5
            If rosado.Bounds.IntersectsWith(lbl2.Bounds) Then
                c = 15
                rosado.Top -= 5
                peligro_rosado.Top -= 5
                casi_rosado.Top -= 5

            End If
        End If
        If c = 15 Then
            rosado.Top -= 5
            peligro_rosado.Top -= 5
            casi_rosado.Top -= 5
            If rosado.Bounds.IntersectsWith(Label40.Bounds) Then
                c = 16
                rosado.Left += 5
                peligro_rosado.Left += 5
                casi_rosado.Left += 5

            End If
        End If
        If c = 16 Then
            rosado.Left += 5
            peligro_rosado.Left += 5
            casi_rosado.Left += 5
            If rosado.Bounds.IntersectsWith(Label41.Bounds) Then
                c = 3
                rosado.Top += 5
                peligro_rosado.Top += 5
                casi_rosado.Top += 5
            End If
        End If

        If rosado.Bounds.IntersectsWith(pb1.Bounds) And peligro_rosado.Visible = False And casi_rosado.Visible = False Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            rojo.Location = New Point(455, 315)
            peligro_rojo.Location = New Point(455, 315)
            casi_rojo.Location = New Point(455, 315)

            amarillo.Location = New Point(378, 315)
            peligro_amarillo.Location = New Point(378, 315)
            casi_amarillo.Location = New Point(378, 315)

            rosado.Location = New Point(301, 315)
            peligro_rosado.Location = New Point(301, 315)
            casi_rosado.Location = New Point(301, 315)

            pb1.Location = New Point(378, 387)
            pb2.Location = New Point(378, 387)
            pb3.Location = New Point(378, 387)
            pb4.Location = New Point(378, 387)
            MsgBox("perdiste")
            a = 0
            b = 0
            c = 0
            Timer1.Start()
            Timer2.Start()
            Timer3.Start()

            Label39.Text = Val(Label39.Text) - 1
        End If
        'inicio rosado
        If peligro_rosado.Bounds.IntersectsWith(pb1.Bounds) And rosado.Visible = False And casi_rosado.Visible = False Then
            Label20.Text = Val(Label20.Text) + 50
            rosado.Visible = False
            rosado.Location = New Point(298, 313)
            peligro_rosado.Location = New Point(298, 313)
            casi_rosado.Location = New Point(298, 313)
            c = 0
            Timer3.Stop()
            Timer3.Start()
        End If
        If casi_rosado.Bounds.IntersectsWith(pb1.Bounds) And rosado.Visible = False And peligro_rosado.Visible = False Then
            Label20.Text = Val(Label20.Text) + 50
            rosado.Location = New Point(298, 313)
            rosado.Visible = False
            peligro_rosado.Location = New Point(298, 313)
            casi_rosado.Location = New Point(298, 313)
            c = 0
            Timer3.Stop()
            Timer3.Start()
        End If
        'fin rosado
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer6.Start()
        contador = 75
        contador2 = 25
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True

        If Val(Label39.Text) = 0 Then
            MessageBox.Show("perdiste todas tus vidas, lo siento", "PACMAN")
            Estadisticas.dgv_ranking.Rows.Add()
            Estadisticas.dgv_ranking.Rows(Estadisticas.dgv_ranking.Rows.Count - 1).Cells(0).Value = inicio.TextBox1.Text
            Estadisticas.dgv_ranking.Rows(Estadisticas.dgv_ranking.Rows.Count - 1).Cells(1).Value = Label39.Text
            Estadisticas.dgv_ranking.Rows(Estadisticas.dgv_ranking.Rows.Count - 1).Cells(2).Value = Label20.Text
            Estadisticas.dgv_ranking.Rows(Estadisticas.dgv_ranking.Rows.Count - 1).Cells(3).Value = lbl_minutero.Text + ":" + lbl_secundero.Text + ":" + lbl_decimal.Text
            Timer6.Stop()
            Me.Close()
            inicio.Show()
            inicio.ProgressBar1.Visible = False
            inicio.Label2.Visible = False
            inicio.TextBox1.Text = ""
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick

        contador = contador - 1
        If contador = 0 Then
            rojo.Visible = False
            casi_rojo.Visible = True
            peligro_rojo.Visible = False

            amarillo.Visible = False
            peligro_amarillo.Visible = False
            casi_amarillo.Visible = True

            rosado.Visible = False
            peligro_rosado.Visible = False
            casi_rosado.Visible = True


            Timer5.Enabled = True
            Timer5.Start()
            If contador <= 0 Then
                Timer4.Stop()
                contador = 75
                Timer4.Enabled = False
            End If

        End If


    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick

        contador2 = contador2 - 1
        If contador2 = 0 Then
            rojo.Visible = True
            casi_rojo.Visible = False
            peligro_rojo.Visible = False

            amarillo.Visible = True
            peligro_amarillo.Visible = False
            casi_amarillo.Visible = False

            rosado.Visible = True
            peligro_rosado.Visible = False
            casi_rosado.Visible = False
            If contador2 <= 0 Then
                Timer5.Stop()
                contador2 = 25
                Timer5.Enabled = False
            End If
        End If
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        lbl_decimal.Text += 1
        If lbl_decimal.Text = "60" Then
            lbl_secundero.Text += 1
            lbl_decimal.Text = "00"
        End If
        If lbl_secundero.Text = "60" Then
            lbl_minutero.Text += 1
            lbl_secundero.Text = "00"
        End If
    End Sub
End Class

