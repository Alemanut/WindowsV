Public Class Form1
    Dim y As Integer
    Dim mov As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Visible = True And Label1.Visible = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        y = 20
        mov = True
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Visible = True Then
            If mov = True Then
                y = y + 100
                Label1.Location = New Point(326, y)
            End If
            If y > 500 Then
                mov = False
            End If
            If mov = False Then
                y = y - 100
                Label1.Location = New Point(326, y)
            End If
            If y < 100 Then
                mov = True
            End If
        End If
    End Sub


End Class
