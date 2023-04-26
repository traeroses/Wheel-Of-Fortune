Public Class frmGame
    Dim dblDiff As Double
    Dim strWord As String

    Public strShareword As String
    Dim dblLimb As Double

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.radEasy.Checked = True Then
            dblDiff = 1
        ElseIf Form1.radEasy.Checked = False Then
            dblDiff = 2
        End If
        NewGame()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmSettings.Close()
        Form1.Close()


    End Sub



    Private Sub NewGame()
        If dblDiff = 1 Then
            Dim intRandNum As Integer
            Dim Randgen As New Random
            Dim intUpper As Integer
            Dim randWord
            intUpper = IO.File.ReadAllLines("C:\temp\EasyList.txt").Count
            If intUpper = 0 Then
                MsgBox("There are no words in this file")
                Me.Close()
                Form1.Close()
                frmSettings.Close()
            End If
            intRandNum = Randgen.Next(0, intUpper)
            randWord = IO.File.ReadAllLines("C:\temp\EasyList.txt").ElementAt(intRandNum).ToString.ToUpper
            strWord = randWord
            strShareword = strWord
            For intIndex As Integer = 0 To randWord.Length - 1
                If randWord(intIndex) = Space(1) Then
                    lblWord.Text = lblWord.Text + " "


                Else
                    lblWord.Text = lblWord.Text + "_"

                End If
            Next


        End If
        If dblDiff = 2 Then
            Dim intRandNum As Integer
            Dim Randgen As New Random
            Dim intUpper As Integer
            Dim randWord
            intUpper = IO.File.ReadAllLines("C:\temp\HardList.txt").Count
            If intUpper = 0 Then
                MsgBox("There are no words in this file")
            End If
            intRandNum = Randgen.Next(0, intUpper)
            randWord = IO.File.ReadAllLines("C:\temp\EList.txt").ElementAt(intRandNum).ToString
            strWord = randWord
            For intIndex As Integer = 0 To randWord.Length - 1
                If randWord(intIndex) = Space(1) Then
                    lblWord.Text = lblWord.Text + " "


                Else
                    lblWord.Text = lblWord.Text + "_"

                End If
            Next


        End If

    End Sub


    Private Sub CheckLetter(ByVal strinput As String)


        Dim strLetter As String
        Dim strResult As String

        strLetter = strinput.Trim.ToUpper
        strResult = lblWord.Text
        If strWord.Contains(strLetter) Then
            ' Replace the hyphen(s) in strResult.
            For intIndex As Integer = 0 To strWord.Length - 1
                If strWord(intIndex) = strLetter Then

                    strResult = strResult.Remove(intIndex, 1)
                    strResult = strResult.Insert(intIndex, strLetter)

                    End If
            Next
            If strResult.Contains("_") = False Then


            End If




            ' Display the contents of strResult.
            lblWord.Text = strResult


            ' Determine whether strResult contains any hyphens.

        Else



        End If



    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        CheckLetter("A")
        btnA.Enabled = False
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        CheckLetter("B")
        btnB.Enabled = False
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        CheckLetter("C")
        btnC.Enabled = False
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        CheckLetter("D")
        btnD.Enabled = False
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        CheckLetter("E")
        btnE.Enabled = False
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        CheckLetter("F")
        btnF.Enabled = False
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        CheckLetter("G")
        btnG.Enabled = False
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        CheckLetter("H")
        btnH.Enabled = False
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        CheckLetter("I")
        btnI.Enabled = False
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        CheckLetter("J")
        btnJ.Enabled = False
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        CheckLetter("K")
        btnK.Enabled = False
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        CheckLetter("L")
        btnL.Enabled = False
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        CheckLetter("M")
        btnM.Enabled = False
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        CheckLetter("N")
        btnN.Enabled = False
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        CheckLetter("O")
        btnO.Enabled = False
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        CheckLetter("P")
        btnP.Enabled = False
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        CheckLetter("Q")
        btnQ.Enabled = False
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        CheckLetter("R")
        btnR.Enabled = False
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        CheckLetter("S")
        btnS.Enabled = False
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        CheckLetter("T")
        btnT.Enabled = False
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        CheckLetter("U")
        btnU.Enabled = False
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        CheckLetter("V")
        btnV.Enabled = False
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        CheckLetter("W")
        btnW.Enabled = False
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        CheckLetter("X")
        btnX.Enabled = False
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        CheckLetter("Y")
        btnY.Enabled = False
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        CheckLetter("Z")
        btnZ.Enabled = False
    End Sub

    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        Dim strSA = txtSolve.Text.ToString

        If strSA.ToString.ToUpper = strWord.ToUpper Then

        ElseIf strSA.ToString.ToUpper <> strWord.ToUpper Then

        End If


    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub
End Class