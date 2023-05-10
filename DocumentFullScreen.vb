Public Class DocumentFullScreen


    Private Sub DocumentFullScreen_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.Close()
    End Sub

    Private Sub DocumentFullScreen_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Close()

    End Sub
End Class