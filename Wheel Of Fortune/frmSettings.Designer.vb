<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblHcount = New System.Windows.Forms.Label()
        Me.lblEcount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEClear = New System.Windows.Forms.Button()
        Me.btnHclear = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnHover = New System.Windows.Forms.Button()
        Me.btnHadd = New System.Windows.Forms.Button()
        Me.btnEOver = New System.Windows.Forms.Button()
        Me.btnEadd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'lblHcount
        '
        Me.lblHcount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHcount.Location = New System.Drawing.Point(178, 226)
        Me.lblHcount.Name = "lblHcount"
        Me.lblHcount.Size = New System.Drawing.Size(100, 23)
        Me.lblHcount.TabIndex = 30
        Me.lblHcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEcount
        '
        Me.lblEcount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEcount.Location = New System.Drawing.Point(178, 149)
        Me.lblEcount.Name = "lblEcount"
        Me.lblEcount.Size = New System.Drawing.Size(100, 23)
        Me.lblEcount.TabIndex = 29
        Me.lblEcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 15)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Hard Mode Word Count:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Easy Mode Word Count:"
        '
        'btnEClear
        '
        Me.btnEClear.Location = New System.Drawing.Point(396, 112)
        Me.btnEClear.Name = "btnEClear"
        Me.btnEClear.Size = New System.Drawing.Size(75, 23)
        Me.btnEClear.TabIndex = 26
        Me.btnEClear.Text = "Clear"
        Me.btnEClear.UseVisualStyleBackColor = True
        '
        'btnHclear
        '
        Me.btnHclear.Location = New System.Drawing.Point(396, 192)
        Me.btnHclear.Name = "btnHclear"
        Me.btnHclear.Size = New System.Drawing.Size(75, 23)
        Me.btnHclear.TabIndex = 25
        Me.btnHclear.Text = "Clear"
        Me.btnHclear.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(600, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(88, 31)
        Me.btnMenu.TabIndex = 24
        Me.btnMenu.Text = "Back to Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnHover
        '
        Me.btnHover.Location = New System.Drawing.Point(299, 192)
        Me.btnHover.Name = "btnHover"
        Me.btnHover.Size = New System.Drawing.Size(75, 23)
        Me.btnHover.TabIndex = 23
        Me.btnHover.Text = "OverWrite"
        Me.btnHover.UseVisualStyleBackColor = True
        '
        'btnHadd
        '
        Me.btnHadd.Location = New System.Drawing.Point(189, 192)
        Me.btnHadd.Name = "btnHadd"
        Me.btnHadd.Size = New System.Drawing.Size(75, 23)
        Me.btnHadd.TabIndex = 22
        Me.btnHadd.Text = "Add To"
        Me.btnHadd.UseVisualStyleBackColor = True
        '
        'btnEOver
        '
        Me.btnEOver.Location = New System.Drawing.Point(299, 112)
        Me.btnEOver.Name = "btnEOver"
        Me.btnEOver.Size = New System.Drawing.Size(75, 23)
        Me.btnEOver.TabIndex = 21
        Me.btnEOver.Text = "OverWrite"
        Me.btnEOver.UseVisualStyleBackColor = True
        '
        'btnEadd
        '
        Me.btnEadd.Location = New System.Drawing.Point(189, 112)
        Me.btnEadd.Name = "btnEadd"
        Me.btnEadd.Size = New System.Drawing.Size(75, 23)
        Me.btnEadd.TabIndex = 20
        Me.btnEadd.Text = "Add To"
        Me.btnEadd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Hard Mode Word Bank:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Easy Mode Word Bank:"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitle.Location = New System.Drawing.Point(171, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(358, 64)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Settings"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 319)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblHcount)
        Me.Controls.Add(Me.lblEcount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEClear)
        Me.Controls.Add(Me.btnHclear)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnHover)
        Me.Controls.Add(Me.btnHadd)
        Me.Controls.Add(Me.btnEOver)
        Me.Controls.Add(Me.btnEadd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHcount As Label
    Friend WithEvents lblEcount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEClear As Button
    Friend WithEvents btnHclear As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnHover As Button
    Friend WithEvents btnHadd As Button
    Friend WithEvents btnEOver As Button
    Friend WithEvents btnEadd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
