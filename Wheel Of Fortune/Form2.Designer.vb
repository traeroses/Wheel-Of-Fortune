<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblOnecount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTwocount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSolve = New System.Windows.Forms.TextBox()
        Me.btnY = New System.Windows.Forms.Button()
        Me.btnX = New System.Windows.Forms.Button()
        Me.btnSolve = New System.Windows.Forms.Button()
        Me.btnZ = New System.Windows.Forms.Button()
        Me.btnW = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.btnU = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnP = New System.Windows.Forms.Button()
        Me.btnO = New System.Windows.Forms.Button()
        Me.btnR = New System.Windows.Forms.Button()
        Me.btnQ = New System.Windows.Forms.Button()
        Me.btnN = New System.Windows.Forms.Button()
        Me.btnM = New System.Windows.Forms.Button()
        Me.btnL = New System.Windows.Forms.Button()
        Me.btnK = New System.Windows.Forms.Button()
        Me.btnJ = New System.Windows.Forms.Button()
        Me.btnG = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnI = New System.Windows.Forms.Button()
        Me.btnH = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.imgWheel = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picWheel = New System.Windows.Forms.PictureBox()
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitle.Location = New System.Drawing.Point(275, -3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(439, 64)
        Me.lblTitle.TabIndex = 18
        Me.lblTitle.Text = "Wheel of Fortune"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOnecount
        '
        Me.lblOnecount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOnecount.Location = New System.Drawing.Point(112, 31)
        Me.lblOnecount.Name = "lblOnecount"
        Me.lblOnecount.Size = New System.Drawing.Size(100, 23)
        Me.lblOnecount.TabIndex = 32
        Me.lblOnecount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Total Amount:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Player One"
        '
        'lblTwocount
        '
        Me.lblTwocount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTwocount.Location = New System.Drawing.Point(112, 91)
        Me.lblTwocount.Name = "lblTwocount"
        Me.lblTwocount.Size = New System.Drawing.Size(100, 23)
        Me.lblTwocount.TabIndex = 35
        Me.lblTwocount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Total Amount:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Player Two"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1, 484)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(396, 99)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Spin!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSolve
        '
        Me.txtSolve.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSolve.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSolve.Location = New System.Drawing.Point(533, 449)
        Me.txtSolve.Name = "txtSolve"
        Me.txtSolve.Size = New System.Drawing.Size(274, 29)
        Me.txtSolve.TabIndex = 80
        '
        'btnY
        '
        Me.btnY.Enabled = False
        Me.btnY.Location = New System.Drawing.Point(717, 336)
        Me.btnY.Name = "btnY"
        Me.btnY.Size = New System.Drawing.Size(52, 21)
        Me.btnY.TabIndex = 79
        Me.btnY.Text = "Y"
        Me.btnY.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.Enabled = False
        Me.btnX.Location = New System.Drawing.Point(472, 390)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(52, 21)
        Me.btnX.TabIndex = 78
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = True
        '
        'btnSolve
        '
        Me.btnSolve.Location = New System.Drawing.Point(421, 449)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(102, 29)
        Me.btnSolve.TabIndex = 77
        Me.btnSolve.Text = "Solve!"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'btnZ
        '
        Me.btnZ.Enabled = False
        Me.btnZ.Location = New System.Drawing.Point(411, 390)
        Me.btnZ.Name = "btnZ"
        Me.btnZ.Size = New System.Drawing.Size(52, 21)
        Me.btnZ.TabIndex = 76
        Me.btnZ.Text = "Z"
        Me.btnZ.UseVisualStyleBackColor = True
        '
        'btnW
        '
        Me.btnW.Enabled = False
        Me.btnW.Location = New System.Drawing.Point(472, 336)
        Me.btnW.Name = "btnW"
        Me.btnW.Size = New System.Drawing.Size(52, 21)
        Me.btnW.TabIndex = 75
        Me.btnW.Text = "W"
        Me.btnW.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.Enabled = False
        Me.btnV.Location = New System.Drawing.Point(595, 390)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(52, 21)
        Me.btnV.TabIndex = 74
        Me.btnV.Text = "V"
        Me.btnV.UseVisualStyleBackColor = True
        '
        'btnU
        '
        Me.btnU.Enabled = False
        Me.btnU.Location = New System.Drawing.Point(778, 336)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(52, 21)
        Me.btnU.TabIndex = 73
        Me.btnU.Text = "U"
        Me.btnU.UseVisualStyleBackColor = True
        '
        'btnT
        '
        Me.btnT.Enabled = False
        Me.btnT.Location = New System.Drawing.Point(656, 336)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(52, 21)
        Me.btnT.TabIndex = 72
        Me.btnT.Text = "T"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnS
        '
        Me.btnS.Enabled = False
        Me.btnS.Location = New System.Drawing.Point(472, 363)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(52, 21)
        Me.btnS.TabIndex = 71
        Me.btnS.Text = "S"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnP
        '
        Me.btnP.Enabled = False
        Me.btnP.Location = New System.Drawing.Point(960, 336)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(52, 21)
        Me.btnP.TabIndex = 70
        Me.btnP.Text = "P"
        Me.btnP.UseVisualStyleBackColor = True
        '
        'btnO
        '
        Me.btnO.Enabled = False
        Me.btnO.Location = New System.Drawing.Point(899, 336)
        Me.btnO.Name = "btnO"
        Me.btnO.Size = New System.Drawing.Size(52, 21)
        Me.btnO.TabIndex = 69
        Me.btnO.Text = "O"
        Me.btnO.UseVisualStyleBackColor = True
        '
        'btnR
        '
        Me.btnR.Enabled = False
        Me.btnR.Location = New System.Drawing.Point(594, 336)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(53, 21)
        Me.btnR.TabIndex = 68
        Me.btnR.Text = "R"
        Me.btnR.UseVisualStyleBackColor = True
        '
        'btnQ
        '
        Me.btnQ.Enabled = False
        Me.btnQ.Location = New System.Drawing.Point(411, 336)
        Me.btnQ.Name = "btnQ"
        Me.btnQ.Size = New System.Drawing.Size(52, 21)
        Me.btnQ.TabIndex = 67
        Me.btnQ.Text = "Q"
        Me.btnQ.UseVisualStyleBackColor = True
        '
        'btnN
        '
        Me.btnN.Enabled = False
        Me.btnN.Location = New System.Drawing.Point(717, 390)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(52, 21)
        Me.btnN.TabIndex = 66
        Me.btnN.Text = "N"
        Me.btnN.UseVisualStyleBackColor = True
        '
        'btnM
        '
        Me.btnM.Enabled = False
        Me.btnM.Location = New System.Drawing.Point(778, 390)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(52, 21)
        Me.btnM.TabIndex = 65
        Me.btnM.Text = "M"
        Me.btnM.UseVisualStyleBackColor = True
        '
        'btnL
        '
        Me.btnL.Enabled = False
        Me.btnL.Location = New System.Drawing.Point(901, 363)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(52, 21)
        Me.btnL.TabIndex = 64
        Me.btnL.Text = "L"
        Me.btnL.UseVisualStyleBackColor = True
        '
        'btnK
        '
        Me.btnK.Enabled = False
        Me.btnK.Location = New System.Drawing.Point(840, 363)
        Me.btnK.Name = "btnK"
        Me.btnK.Size = New System.Drawing.Size(52, 21)
        Me.btnK.TabIndex = 63
        Me.btnK.Text = "K"
        Me.btnK.UseVisualStyleBackColor = True
        '
        'btnJ
        '
        Me.btnJ.Enabled = False
        Me.btnJ.Location = New System.Drawing.Point(778, 363)
        Me.btnJ.Name = "btnJ"
        Me.btnJ.Size = New System.Drawing.Size(52, 21)
        Me.btnJ.TabIndex = 62
        Me.btnJ.Text = "J"
        Me.btnJ.UseVisualStyleBackColor = True
        '
        'btnG
        '
        Me.btnG.Enabled = False
        Me.btnG.Location = New System.Drawing.Point(656, 363)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(52, 21)
        Me.btnG.TabIndex = 61
        Me.btnG.Text = "G"
        Me.btnG.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.Enabled = False
        Me.btnF.Location = New System.Drawing.Point(595, 363)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(52, 21)
        Me.btnF.TabIndex = 60
        Me.btnF.Text = "F"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'btnI
        '
        Me.btnI.Enabled = False
        Me.btnI.Location = New System.Drawing.Point(839, 336)
        Me.btnI.Name = "btnI"
        Me.btnI.Size = New System.Drawing.Size(53, 21)
        Me.btnI.TabIndex = 59
        Me.btnI.Text = "I"
        Me.btnI.UseVisualStyleBackColor = True
        '
        'btnH
        '
        Me.btnH.Enabled = False
        Me.btnH.Location = New System.Drawing.Point(717, 363)
        Me.btnH.Name = "btnH"
        Me.btnH.Size = New System.Drawing.Size(52, 21)
        Me.btnH.TabIndex = 58
        Me.btnH.Text = "H"
        Me.btnH.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Enabled = False
        Me.btnE.Location = New System.Drawing.Point(533, 336)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(52, 21)
        Me.btnE.TabIndex = 57
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.Enabled = False
        Me.btnD.Location = New System.Drawing.Point(533, 363)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(52, 21)
        Me.btnD.TabIndex = 56
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Enabled = False
        Me.btnC.Location = New System.Drawing.Point(533, 390)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(52, 21)
        Me.btnC.TabIndex = 55
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Enabled = False
        Me.btnB.Location = New System.Drawing.Point(656, 390)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(52, 21)
        Me.btnB.TabIndex = 54
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.Enabled = False
        Me.btnA.Location = New System.Drawing.Point(411, 363)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(52, 21)
        Me.btnA.TabIndex = 53
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'lblWord
        '
        Me.lblWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWord.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord.Location = New System.Drawing.Point(403, 95)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lblWord.Size = New System.Drawing.Size(609, 214)
        Me.lblWord.TabIndex = 81
        Me.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgWheel
        '
        Me.imgWheel.ImageStream = CType(resources.GetObject("imgWheel.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgWheel.TransparentColor = System.Drawing.Color.Transparent
        Me.imgWheel.Images.SetKeyName(0, "1.png")
        Me.imgWheel.Images.SetKeyName(1, "2.png")
        Me.imgWheel.Images.SetKeyName(2, "3.png")
        Me.imgWheel.Images.SetKeyName(3, "4.png")
        Me.imgWheel.Images.SetKeyName(4, "5.png")
        Me.imgWheel.Images.SetKeyName(5, "6.png")
        Me.imgWheel.Images.SetKeyName(6, "7.png")
        Me.imgWheel.Images.SetKeyName(7, "8.png")
        Me.imgWheel.Images.SetKeyName(8, "9.png")
        Me.imgWheel.Images.SetKeyName(9, "10.png")
        Me.imgWheel.Images.SetKeyName(10, "11.png")
        Me.imgWheel.Images.SetKeyName(11, "12.png")
        Me.imgWheel.Images.SetKeyName(12, "13.png")
        Me.imgWheel.Images.SetKeyName(13, "14.png")
        Me.imgWheel.Images.SetKeyName(14, "15.png")
        Me.imgWheel.Images.SetKeyName(15, "16.png")
        Me.imgWheel.Images.SetKeyName(16, "17.png")
        Me.imgWheel.Images.SetKeyName(17, "18.png")
        Me.imgWheel.Images.SetKeyName(18, "19.png")
        Me.imgWheel.Images.SetKeyName(19, "20.png")
        Me.imgWheel.Images.SetKeyName(20, "21.png")
        Me.imgWheel.Images.SetKeyName(21, "22.png")
        Me.imgWheel.Images.SetKeyName(22, "23.png")
        Me.imgWheel.Images.SetKeyName(23, "24.png")
        Me.imgWheel.Images.SetKeyName(24, "25.png")
        '
        'Timer1
        '
        '
        'picWheel
        '
        Me.picWheel.Image = Global.Wheel_Of_Fortune.My.Resources.Resources.Picture1
        Me.picWheel.Location = New System.Drawing.Point(1, 149)
        Me.picWheel.Name = "picWheel"
        Me.picWheel.Size = New System.Drawing.Size(396, 329)
        Me.picWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWheel.TabIndex = 37
        Me.picWheel.TabStop = False
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 629)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.txtSolve)
        Me.Controls.Add(Me.btnY)
        Me.Controls.Add(Me.btnX)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.btnZ)
        Me.Controls.Add(Me.btnW)
        Me.Controls.Add(Me.btnV)
        Me.Controls.Add(Me.btnU)
        Me.Controls.Add(Me.btnT)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.btnP)
        Me.Controls.Add(Me.btnO)
        Me.Controls.Add(Me.btnR)
        Me.Controls.Add(Me.btnQ)
        Me.Controls.Add(Me.btnN)
        Me.Controls.Add(Me.btnM)
        Me.Controls.Add(Me.btnL)
        Me.Controls.Add(Me.btnK)
        Me.Controls.Add(Me.btnJ)
        Me.Controls.Add(Me.btnG)
        Me.Controls.Add(Me.btnF)
        Me.Controls.Add(Me.btnI)
        Me.Controls.Add(Me.btnH)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.picWheel)
        Me.Controls.Add(Me.lblTwocount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblOnecount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmGame"
        Me.Text = "Wheel of Fortune!"
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblOnecount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTwocount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents picWheel As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSolve As TextBox
    Friend WithEvents btnY As Button
    Friend WithEvents btnX As Button
    Friend WithEvents btnSolve As Button
    Friend WithEvents btnZ As Button
    Friend WithEvents btnW As Button
    Friend WithEvents btnV As Button
    Friend WithEvents btnU As Button
    Friend WithEvents btnT As Button
    Friend WithEvents btnS As Button
    Friend WithEvents btnP As Button
    Friend WithEvents btnO As Button
    Friend WithEvents btnR As Button
    Friend WithEvents btnQ As Button
    Friend WithEvents btnN As Button
    Friend WithEvents btnM As Button
    Friend WithEvents btnL As Button
    Friend WithEvents btnK As Button
    Friend WithEvents btnJ As Button
    Friend WithEvents btnG As Button
    Friend WithEvents btnF As Button
    Friend WithEvents btnI As Button
    Friend WithEvents btnH As Button
    Friend WithEvents btnE As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnA As Button
    Friend WithEvents lblWord As Label
    Friend WithEvents imgWheel As ImageList
    Friend WithEvents Timer1 As Timer
End Class
