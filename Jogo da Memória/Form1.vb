Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        PictureBox1.BackgroundImage = imagem(0)




    End Sub
    Function imagem(i)
        Select Case i
            Case 0
                Return My.Resources.1.kkk
            Case 1
                Return My.Resources.2.
            Case 2
                Return My.Resources.3.
            Case 3
                Return My.Resources.
            Case 4
                Return My.Resources.
            Case 5
                Return My.Resources.
            Case 6
                Return My.Resources.
            Case 7
                Return My.Resources.
            Case 8
                Return My.Resources.

        End Select
    End Function
End Class
