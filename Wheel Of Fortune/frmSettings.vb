Imports System.Reflection.Emit

Public Class frmSettings
    Dim dblPL
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEadd.Click
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            dblPL = OpenFileDialog1.FileName

            Dim inFile As IO.StreamReader

            If IO.File.Exists(dblPL) Then
                inFile = IO.File.OpenText(OpenFileDialog1.FileName)
                Dim strLine As String
                Do Until inFile.Peek = -1
                    strLine = inFile.ReadLine
                    Label4.Text = Label4.Text & strLine & ControlChars.NewLine
                Loop

                Dim InputString = Label4.Text
                My.Computer.FileSystem.WriteAllText("C:\temp\EasyList.txt", InputString, True)

            End If

        End If

        Label4.Text = String.Empty
        GetLineCount()
    End Sub

    Private Sub btnHadd_Click(sender As Object, e As EventArgs) Handles btnHadd.Click
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            dblPL = OpenFileDialog1.FileName

            Dim inFile As IO.StreamReader

            If IO.File.Exists(dblPL) Then
                inFile = IO.File.OpenText(OpenFileDialog1.FileName)
                Dim strLine As String
                Do Until inFile.Peek = -1
                    strLine = inFile.ReadLine
                    Label6.Text = Label6.Text & strLine & ControlChars.NewLine
                Loop
                Dim InputString = Label6.Text
                My.Computer.FileSystem.WriteAllText("C:\temp\HardList.txt", InputString, True)

            End If

        End If

        Label6.Text = String.Empty
        GetLineCount()
    End Sub

    Private Sub btnEOver_Click(sender As Object, e As EventArgs) Handles btnEOver.Click
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            dblPL = OpenFileDialog1.FileName

            Dim inFile As IO.StreamReader

            If IO.File.Exists(dblPL) Then
                inFile = IO.File.OpenText(OpenFileDialog1.FileName)
                Dim strLine As String
                Do Until inFile.Peek = -1
                    strLine = inFile.ReadLine
                    Label4.Text = Label4.Text & strLine & ControlChars.NewLine
                Loop
                Dim InputString = Label4.Text
                My.Computer.FileSystem.WriteAllText("C:\temp\EasyList.txt", InputString, False)

            End If

        End If

        Label4.Text = String.Empty
        GetLineCount()
    End Sub

    Private Sub btnHover_Click(sender As Object, e As EventArgs) Handles btnHover.Click
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            dblPL = OpenFileDialog1.FileName

            Dim inFile As IO.StreamReader

            If IO.File.Exists(dblPL) Then
                inFile = IO.File.OpenText(OpenFileDialog1.FileName)
                Dim strLine As String
                Do Until inFile.Peek = -1
                    strLine = inFile.ReadLine
                    Label6.Text = Label6.Text & strLine & ControlChars.NewLine
                Loop
                Dim InputString = Label6.Text
                My.Computer.FileSystem.WriteAllText("C:\temp\HardList.txt", InputString, False)
            End If
        End If

        Label6.Text = String.Empty
        GetLineCount()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEClear.Click

        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Are you sure you want to clear this list?", "Hangman", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButton = DialogResult.Yes Then
            Label4.Text = String.Empty
            Dim InputString = Label4.Text
            My.Computer.FileSystem.WriteAllText("C:\temp\EasyList.txt", InputString, False)
        End If

        GetLineCount()
    End Sub

    Private Sub btnHclear_Click(sender As Object, e As EventArgs) Handles btnHclear.Click


        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Are you sure you want to clear this list?", "Hangman", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButton = DialogResult.Yes Then
            Label6.Text = String.Empty
            Dim InputString = Label6.Text
            My.Computer.FileSystem.WriteAllText("C:\temp\HardList.txt", InputString, False)
        End If
        GetLineCount()

    End Sub
    Private Sub GetLineCount()
        Dim LCeasy = IO.File.ReadAllLines("C:\temp\EasyList.txt").Count
        Dim LChard = IO.File.ReadAllLines("C:\temp\HardList.txt").Count
        lblEcount.Text = LCeasy.ToString
        lblHcount.Text = LChard.ToString

    End Sub
End Class