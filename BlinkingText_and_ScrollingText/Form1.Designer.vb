<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbScrollingTextRL = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbScrollingTextLR = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.sp50 = New System.Windows.Forms.RadioButton()
        Me.sp100 = New System.Windows.Forms.RadioButton()
        Me.sp150 = New System.Windows.Forms.RadioButton()
        Me.sp200 = New System.Windows.Forms.RadioButton()
        Me.sp250 = New System.Windows.Forms.RadioButton()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lbSpeed = New System.Windows.Forms.Label()
        Me.lbBlinkingStatus = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbScrollingTextRL)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(908, 100)
        Me.Panel1.TabIndex = 0
        '
        'lbScrollingTextRL
        '
        Me.lbScrollingTextRL.AutoSize = True
        Me.lbScrollingTextRL.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbScrollingTextRL.ForeColor = System.Drawing.Color.Crimson
        Me.lbScrollingTextRL.Location = New System.Drawing.Point(7, 12)
        Me.lbScrollingTextRL.Name = "lbScrollingTextRL"
        Me.lbScrollingTextRL.Size = New System.Drawing.Size(48, 75)
        Me.lbScrollingTextRL.TabIndex = 0
        Me.lbScrollingTextRL.Text = "|"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbScrollingTextLR)
        Me.Panel2.Location = New System.Drawing.Point(15, 148)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(908, 100)
        Me.Panel2.TabIndex = 1
        '
        'lbScrollingTextLR
        '
        Me.lbScrollingTextLR.AutoSize = True
        Me.lbScrollingTextLR.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbScrollingTextLR.ForeColor = System.Drawing.Color.YellowGreen
        Me.lbScrollingTextLR.Location = New System.Drawing.Point(7, 12)
        Me.lbScrollingTextLR.Name = "lbScrollingTextLR"
        Me.lbScrollingTextLR.Size = New System.Drawing.Size(48, 75)
        Me.lbScrollingTextLR.TabIndex = 0
        Me.lbScrollingTextLR.Text = "|"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.sp250)
        Me.GroupBox1.Controls.Add(Me.sp200)
        Me.GroupBox1.Controls.Add(Me.sp150)
        Me.GroupBox1.Controls.Add(Me.sp100)
        Me.GroupBox1.Controls.Add(Me.sp50)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 88)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Speed :"
        '
        'sp50
        '
        Me.sp50.AutoSize = True
        Me.sp50.Location = New System.Drawing.Point(17, 38)
        Me.sp50.Name = "sp50"
        Me.sp50.Size = New System.Drawing.Size(55, 29)
        Me.sp50.TabIndex = 0
        Me.sp50.TabStop = True
        Me.sp50.Text = "50"
        Me.sp50.UseVisualStyleBackColor = True
        '
        'sp100
        '
        Me.sp100.AutoSize = True
        Me.sp100.Location = New System.Drawing.Point(83, 38)
        Me.sp100.Name = "sp100"
        Me.sp100.Size = New System.Drawing.Size(66, 29)
        Me.sp100.TabIndex = 1
        Me.sp100.TabStop = True
        Me.sp100.Text = "100"
        Me.sp100.UseVisualStyleBackColor = True
        '
        'sp150
        '
        Me.sp150.AutoSize = True
        Me.sp150.Location = New System.Drawing.Point(163, 38)
        Me.sp150.Name = "sp150"
        Me.sp150.Size = New System.Drawing.Size(66, 29)
        Me.sp150.TabIndex = 2
        Me.sp150.TabStop = True
        Me.sp150.Text = "150"
        Me.sp150.UseVisualStyleBackColor = True
        '
        'sp200
        '
        Me.sp200.AutoSize = True
        Me.sp200.Location = New System.Drawing.Point(241, 38)
        Me.sp200.Name = "sp200"
        Me.sp200.Size = New System.Drawing.Size(66, 29)
        Me.sp200.TabIndex = 3
        Me.sp200.TabStop = True
        Me.sp200.Text = "200"
        Me.sp200.UseVisualStyleBackColor = True
        '
        'sp250
        '
        Me.sp250.AutoSize = True
        Me.sp250.Location = New System.Drawing.Point(320, 38)
        Me.sp250.Name = "sp250"
        Me.sp250.Size = New System.Drawing.Size(66, 29)
        Me.sp250.TabIndex = 4
        Me.sp250.TabStop = True
        Me.sp250.Text = "250"
        Me.sp250.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Teal
        Me.btnStart.ForeColor = System.Drawing.SystemColors.Window
        Me.btnStart.Location = New System.Drawing.Point(556, 290)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(166, 74)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Teal
        Me.btnStop.ForeColor = System.Drawing.SystemColors.Window
        Me.btnStop.Location = New System.Drawing.Point(757, 290)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(166, 74)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'lbSpeed
        '
        Me.lbSpeed.AutoSize = True
        Me.lbSpeed.ForeColor = System.Drawing.SystemColors.Window
        Me.lbSpeed.Location = New System.Drawing.Point(12, 401)
        Me.lbSpeed.Name = "lbSpeed"
        Me.lbSpeed.Size = New System.Drawing.Size(180, 25)
        Me.lbSpeed.TabIndex = 5
        Me.lbSpeed.Text = "Current speed: 150"
        '
        'lbBlinkingStatus
        '
        Me.lbBlinkingStatus.AutoSize = True
        Me.lbBlinkingStatus.ForeColor = System.Drawing.SystemColors.Window
        Me.lbBlinkingStatus.Location = New System.Drawing.Point(752, 401)
        Me.lbBlinkingStatus.Name = "lbBlinkingStatus"
        Me.lbBlinkingStatus.Size = New System.Drawing.Size(143, 25)
        Me.lbBlinkingStatus.TabIndex = 6
        Me.lbBlinkingStatus.Text = "Blinking status:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(957, 440)
        Me.Controls.Add(Me.lbBlinkingStatus)
        Me.Controls.Add(Me.lbSpeed)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Working with Timer Control : Scrolling Text and Blinking Text"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbScrollingTextRL As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbScrollingTextLR As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents sp250 As RadioButton
    Friend WithEvents sp200 As RadioButton
    Friend WithEvents sp150 As RadioButton
    Friend WithEvents sp100 As RadioButton
    Friend WithEvents sp50 As RadioButton
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents lbSpeed As Label
    Friend WithEvents lbBlinkingStatus As Label
End Class
