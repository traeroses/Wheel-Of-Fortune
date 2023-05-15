Imports System.Threading

Public Class frmtest
    Private Sub frmtest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intupper As Integer
        Dim strFact As String
        Dim IntFact As String
        Dim Randgen As New Random
        intupper = IO.File.ReadAllLines("C:\temp\Fun.txt").Count
        IntFact = Randgen.Next(0, intupper)
        strFact = IO.File.ReadAllLines("C:\temp\Fun.txt").ElementAt(IntFact).ToString
        Label4.Text = "Snapple Fact #" + IntFact + ": " + strFact

        Timer1.Enabled = True


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(3)

        If ProgressBar1.Value = 100 Then
            frmGame.Visible = True
            Me.Visible = False
            Me.Close()
            Timer1.Stop()
            Timer1.Enabled = False
        End If

        Label2.Text = ProgressBar1.Value & "%"

    End Sub


End Class