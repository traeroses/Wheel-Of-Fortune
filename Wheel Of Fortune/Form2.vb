﻿Option Strict Off
Option Infer Off
Option Explicit On
'Program: Wheel of fortune
'Purpose: recreation of Wheel of Fortune
'Programmer: Will Young

Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock


Public Class frmGame

    Dim dblDiff As Double
    Dim strWord As String
    Dim wheelstate = 0
    Dim RandGen As New Random
    Dim intRandNum As Integer
    Dim uppertime As Double
    Dim Time As Integer
    Dim TurnState As Double
    Dim dblValue As Double
    Dim countOne As Double
    Dim countTwo As Double

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

        Timer1.Start()
        Time = 0
        intRandNum = RandGen.Next(15, 24)
        uppertime = intRandNum



    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time += 1

        If Time = uppertime Then
            Timer1.Stop()
            Dim intVal As Double
            intVal = RandGen.Next(0, 25)
            If intVal = 0 Then
                MsgBox("You are playing for 10,000 Dollars!")
                dblValue = 10000
            ElseIf intVal > 0 And intVal < 3 Then
                MsgBox("You are Bankrupt!")
                If TurnState = 1 Then
                    lblOnecount.Text = "0"
                    TurnState = 2
                    changeTurn()
                ElseIf TurnState = 2 Then
                    lblTwocount.Text = "0"
                    TurnState = 1
                    changeTurn()
                End If
            ElseIf intVal > 2 And intVal < 6 Then
                MsgBox("You've been skipped!")
                If TurnState = 1 Then
                    TurnState = 2
                    changeTurn()
                ElseIf TurnState = 2 Then
                    TurnState = 1
                    changeTurn()
                End If
            ElseIf intVal > 5 And intVal < 9 Then
                MsgBox("You are playing for 5,000 Dollars!")
                dblValue = 5000
            ElseIf intVal > 8 And intVal < 15 Then
                MsgBox("You are playing for 2,000 Dollars!")
                dblValue = 2000
            ElseIf intVal > 14 And intVal < 26 Then
                MsgBox("You are playing for 1,000 Dollars!")
                dblValue = 1000
            End If

            btnA.Enabled = True
            btnB.Enabled = True
            btnC.Enabled = True
            btnD.Enabled = True
            btnE.Enabled = True
            btnF.Enabled = True
            btnG.Enabled = True
            btnH.Enabled = True
            btnI.Enabled = True
            btnJ.Enabled = True
            btnK.Enabled = True
            btnL.Enabled = True
            btnM.Enabled = True
            btnN.Enabled = True
            btnO.Enabled = True
            btnP.Enabled = True
            btnQ.Enabled = True
            btnR.Enabled = True
            btnS.Enabled = True
            btnT.Enabled = True
            btnU.Enabled = True
            btnV.Enabled = True
            btnW.Enabled = True
            btnX.Enabled = True
            btnY.Enabled = True
            btnZ.Enabled = True

        Else
            If wheelstate = 24 Then
                wheelstate = 0
                picWheel.Image = imgWheel.Images.Item(wheelstate)
            Else
                wheelstate += 1
                picWheel.Image = imgWheel.Images.Item(wheelstate)
            End If

        End If
    End Sub






    Private Sub NewGame()
        lblWord.Text = String.Empty
        btnA.Enabled = True
        btnB.Enabled = True
        btnC.Enabled = True
        btnD.Enabled = True
        btnE.Enabled = True
        btnF.Enabled = True
        btnG.Enabled = True
        btnH.Enabled = True
        btnI.Enabled = True
        btnJ.Enabled = True
        btnK.Enabled = True
        btnL.Enabled = True
        btnM.Enabled = True
        btnN.Enabled = True
        btnO.Enabled = True
        btnP.Enabled = True
        btnQ.Enabled = True
        btnR.Enabled = True
        btnS.Enabled = True
        btnT.Enabled = True
        btnU.Enabled = True
        btnV.Enabled = True
        btnW.Enabled = True
        btnX.Enabled = True
        btnY.Enabled = True
        btnZ.Enabled = True


        If dblDiff = 1 Then
            Dim intRandNum As Integer
            Dim Randgen As New Random
            Dim intUpper As Integer
            Dim randWord As String
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
                    lblWord.Text = lblWord.Text + "_" + " "

                End If
            Next


        End If
        If dblDiff = 2 Then
            Dim intRandNum As Integer
            Dim Randgen As New Random
            Dim intUpper As Integer
            Dim randWord As String
            intUpper = IO.File.ReadAllLines("C:\temp\HardList.txt").Count
            If intUpper = 0 Then
                MsgBox("There are no words in this file")
            End If
            intRandNum = Randgen.Next(0, intUpper)
            randWord = IO.File.ReadAllLines("C:\temp\HardList.txt").ElementAt(intRandNum).ToString
            strWord = randWord
            For intIndex As Integer = 0 To randWord.Length - 1
                If randWord(intIndex) = Space(1) Then


                    lblWord.Text = lblWord.Text + " "


                Else
                    lblWord.Text = lblWord.Text + "_" + " "

                End If
            Next


        End If

        TurnState = 1

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





            ' Display the contents of strResult.
            lblWord.Text = strResult


            ' Determine whether strResult contains any hyphens.
            If TurnState = 1 Then
                lblOnecount.Text = countOne
                lblOnecount.Text = (countOne + dblValue).ToString("C2")
                countOne = lblOnecount.Text
            ElseIf TurnState = 2 Then
                lblTwocount.Text = countTwo
                lblTwocount.Text = (countTwo + dblValue).ToString("C2")
                countTwo = lblTwocount.Text
            End If

            If strResult.Contains("_") = False Then

                Winstate()

            End If
        Else

            If TurnState = 1 Then
                TurnState = 2
            ElseIf TurnState = 2 Then
                TurnState = 1
            End If
            changeTurn()
        End If



    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        btnA.Enabled = False
        CheckLetter("A")

    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        btnB.Enabled = False
        CheckLetter("B")

    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click

        btnC.Enabled = False
        CheckLetter("C")

    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        btnD.Enabled = False
        CheckLetter("D")

    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        btnE.Enabled = False
        CheckLetter("E")

    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click

        btnF.Enabled = False
        CheckLetter("F")

    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        btnG.Enabled = False
        CheckLetter("G")

    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        btnH.Enabled = False
        CheckLetter("H")

    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        btnI.Enabled = False
        CheckLetter("I")

    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        btnJ.Enabled = False
        CheckLetter("J")

    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        btnK.Enabled = False
        CheckLetter("K")

    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        btnL.Enabled = False
        CheckLetter("L")

    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        btnM.Enabled = False
        CheckLetter("M")

    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        btnN.Enabled = False
        CheckLetter("N")

    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        btnO.Enabled = False
        CheckLetter("O")

    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        btnP.Enabled = False
        CheckLetter("P")

    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        btnQ.Enabled = False
        CheckLetter("Q")

    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        btnR.Enabled = False
        CheckLetter("R")

    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        btnS.Enabled = False
        CheckLetter("S")

    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        btnT.Enabled = False
        CheckLetter("T")

    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        btnU.Enabled = False
        CheckLetter("U")

    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        btnV.Enabled = False
        CheckLetter("V")

    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        btnW.Enabled = False
        CheckLetter("W")

    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        btnX.Enabled = False
        CheckLetter("X")

    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        btnY.Enabled = False
        CheckLetter("Y")

    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        btnZ.Enabled = False
        CheckLetter("Z")

    End Sub

    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        Dim strSA As String = txtSolve.Text.ToString

        If strSA.ToString.ToUpper = strWord.ToUpper Then

            Winstate()

        ElseIf strSA.ToString.ToUpper <> strWord.ToUpper Then
            If TurnState = 1 Then
                TurnState = 2
                Winstate()
            Else
                TurnState = 1
                Winstate()
            End If
        End If

        txtSolve.Text = String.Empty
    End Sub

    Private Sub changeTurn()
        frmExtra.Visible = True
        If TurnState = 1 Then
            frmExtra.lblTitle.Text = "Hi Player 1, Would You like to.."
        ElseIf TurnState = 2 Then
            frmExtra.lblTitle.Text = "Hi Player 2, Would You like to.."
        End If
    End Sub

    Private Sub Winstate()
        If TurnState = 1 Then
            Dim dlgbutton As DialogResult
            dlgbutton = MessageBox.Show("Player 1 Won!The word/phrase was " + strShareword + "! Start a New Round?", "Wheel Of Fortune!",
                MessageBoxButtons.YesNo,
                  MessageBoxIcon.Exclamation)
            If dlgbutton = DialogResult.Yes Then
                NewGame()
            ElseIf dlgbutton = DialogResult.No Then
                frmExtra.Close()
                Form1.Visible = True
                Me.Close()

            End If
        ElseIf TurnState = 2 Then
            Dim dlgbutton As DialogResult
            dlgbutton = MessageBox.Show("Player 2 Won!The word/phrase was " + strShareword + "! Start a New Round?", "Wheel Of Fortune!",
                    MessageBoxButtons.YesNo,
                      MessageBoxIcon.Exclamation)
            If dlgbutton = DialogResult.Yes Then
                NewGame()
            ElseIf dlgbutton = DialogResult.No Then
                frmExtra.Close()
                Form1.Visible = True
                Me.Close()

            End If
        End If


    End Sub

End Class