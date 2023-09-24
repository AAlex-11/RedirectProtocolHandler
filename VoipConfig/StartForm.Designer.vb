<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
        Me.btNext = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.btTest = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txUser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txExt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txUrl = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txProtocol = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txDest = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lCode = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lUrl = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lRow = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ShowAllCheckBox = New System.Windows.Forms.CheckBox()
        Me.lNew = New System.Windows.Forms.Label()
        Me.btPrev = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btNext
        '
        Me.btNext.Location = New System.Drawing.Point(380, 81)
        Me.btNext.Name = "btNext"
        Me.btNext.Size = New System.Drawing.Size(100, 23)
        Me.btNext.TabIndex = 0
        Me.btNext.Text = "Next row"
        Me.btNext.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(8, 81)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(198, 23)
        Me.btSave.TabIndex = 1
        Me.btSave.Text = "Save row to Registry and Next"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btExit
        '
        Me.btExit.Location = New System.Drawing.Point(534, 81)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(198, 23)
        Me.btExit.TabIndex = 2
        Me.btExit.Text = "Exit configurator"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'btTest
        '
        Me.btTest.Location = New System.Drawing.Point(266, 36)
        Me.btTest.Name = "btTest"
        Me.btTest.Size = New System.Drawing.Size(198, 23)
        Me.btTest.TabIndex = 3
        Me.btTest.Text = "Test"
        Me.btTest.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txPass)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txUser)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txExt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txUrl)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txProtocol)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(751, 138)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(263, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Password"
        '
        'txPass
        '
        Me.txPass.Location = New System.Drawing.Point(266, 93)
        Me.txPass.Name = "txPass"
        Me.txPass.Size = New System.Drawing.Size(198, 22)
        Me.txPass.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Username"
        '
        'txUser
        '
        Me.txUser.Location = New System.Drawing.Point(6, 93)
        Me.txUser.Name = "txUser"
        Me.txUser.Size = New System.Drawing.Size(198, 22)
        Me.txUser.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(532, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Ext"
        '
        'txExt
        '
        Me.txExt.Location = New System.Drawing.Point(535, 38)
        Me.txExt.Name = "txExt"
        Me.txExt.Size = New System.Drawing.Size(198, 22)
        Me.txExt.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(263, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "URL"
        '
        'txUrl
        '
        Me.txUrl.Location = New System.Drawing.Point(266, 38)
        Me.txUrl.Name = "txUrl"
        Me.txUrl.Size = New System.Drawing.Size(198, 22)
        Me.txUrl.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Protocol"
        '
        'txProtocol
        '
        Me.txProtocol.Location = New System.Drawing.Point(6, 38)
        Me.txProtocol.Name = "txProtocol"
        Me.txProtocol.Size = New System.Drawing.Size(198, 22)
        Me.txProtocol.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(6, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Destination"
        '
        'txDest
        '
        Me.txDest.Location = New System.Drawing.Point(6, 37)
        Me.txDest.Name = "txDest"
        Me.txDest.Size = New System.Drawing.Size(198, 22)
        Me.txDest.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lCode)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lUrl)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txDest)
        Me.GroupBox2.Controls.Add(Me.btTest)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(751, 200)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'lCode
        '
        Me.lCode.AutoSize = True
        Me.lCode.Location = New System.Drawing.Point(9, 166)
        Me.lCode.Name = "lCode"
        Me.lCode.Size = New System.Drawing.Size(11, 16)
        Me.lCode.TabIndex = 18
        Me.lCode.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(6, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Result"
        '
        'lUrl
        '
        Me.lUrl.AutoSize = True
        Me.lUrl.Location = New System.Drawing.Point(9, 108)
        Me.lUrl.Name = "lUrl"
        Me.lUrl.Size = New System.Drawing.Size(11, 16)
        Me.lUrl.TabIndex = 16
        Me.lUrl.Text = "-"
        Me.lUrl.UseMnemonic = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(6, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "URL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(8, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "ConfigRow #"
        '
        'lRow
        '
        Me.lRow.AutoSize = True
        Me.lRow.Location = New System.Drawing.Point(8, 45)
        Me.lRow.Name = "lRow"
        Me.lRow.Size = New System.Drawing.Size(14, 16)
        Me.lRow.TabIndex = 17
        Me.lRow.Text = "0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ShowAllCheckBox)
        Me.GroupBox3.Controls.Add(Me.lNew)
        Me.GroupBox3.Controls.Add(Me.btPrev)
        Me.GroupBox3.Controls.Add(Me.lRow)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.btSave)
        Me.GroupBox3.Controls.Add(Me.btExit)
        Me.GroupBox3.Controls.Add(Me.btNext)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 406)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(750, 130)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'ShowAllCheckBox
        '
        Me.ShowAllCheckBox.AutoSize = True
        Me.ShowAllCheckBox.Location = New System.Drawing.Point(113, 17)
        Me.ShowAllCheckBox.Name = "ShowAllCheckBox"
        Me.ShowAllCheckBox.Size = New System.Drawing.Size(80, 20)
        Me.ShowAllCheckBox.TabIndex = 20
        Me.ShowAllCheckBox.Text = "Show All"
        Me.ShowAllCheckBox.UseVisualStyleBackColor = True
        '
        'lNew
        '
        Me.lNew.AutoSize = True
        Me.lNew.Location = New System.Drawing.Point(49, 45)
        Me.lNew.Name = "lNew"
        Me.lNew.Size = New System.Drawing.Size(39, 16)
        Me.lNew.TabIndex = 19
        Me.lNew.Text = "(new)"
        Me.lNew.Visible = False
        '
        'btPrev
        '
        Me.btPrev.Location = New System.Drawing.Point(265, 81)
        Me.btPrev.Name = "btPrev"
        Me.btPrev.Size = New System.Drawing.Size(100, 23)
        Me.btPrev.TabIndex = 18
        Me.btPrev.Text = "Prev row"
        Me.btPrev.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(13, 571)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(750, 428)
        Me.TextBox1.TabIndex = 17
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 557)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StartForm"
        Me.Text = "VoipPlus configuration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btNext As Button
    Friend WithEvents btSave As Button
    Friend WithEvents btExit As Button
    Friend WithEvents btTest As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txUrl As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txProtocol As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txUser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txExt As TextBox
    Friend WithEvents txDest As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lRow As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lUrl As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lCode As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btPrev As Button
    Friend WithEvents lNew As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ShowAllCheckBox As CheckBox
End Class
