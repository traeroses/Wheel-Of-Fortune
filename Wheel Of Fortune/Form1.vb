Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        frmtest.Visible = True
        Me.Visible = False
        radEasy.Checked = True
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        frmSettings.Visible = True




    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        frmtest.Visible = True
        Me.Visible = False
        radEasy.Checked = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        frmSettings.Visible = True

    End Sub
End Class
