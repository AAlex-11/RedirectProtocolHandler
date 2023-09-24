<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.lUrl = New System.Windows.Forms.Label()
        Me.lCode = New System.Windows.Forms.Label()
        Me.lProtocol = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lUrl
        '
        Me.lUrl.AutoSize = True
        Me.lUrl.Location = New System.Drawing.Point(12, 30)
        Me.lUrl.Name = "lUrl"
        Me.lUrl.Size = New System.Drawing.Size(42, 16)
        Me.lUrl.TabIndex = 0
        Me.lUrl.Text = "NoUrl"
        Me.lUrl.UseMnemonic = False
        '
        'lCode
        '
        Me.lCode.AutoSize = True
        Me.lCode.Location = New System.Drawing.Point(110, 76)
        Me.lCode.Name = "lCode"
        Me.lCode.Size = New System.Drawing.Size(58, 16)
        Me.lCode.TabIndex = 1
        Me.lCode.Text = "NoCode"
        '
        'lProtocol
        '
        Me.lProtocol.AutoSize = True
        Me.lProtocol.Location = New System.Drawing.Point(12, 76)
        Me.lProtocol.Name = "lProtocol"
        Me.lProtocol.Size = New System.Drawing.Size(75, 16)
        Me.lProtocol.TabIndex = 3
        Me.lProtocol.Text = "NoProtocol"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "URL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Protocol"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(110, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "RetCode"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 116)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lProtocol)
        Me.Controls.Add(Me.lCode)
        Me.Controls.Add(Me.lUrl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "VoipPlus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lUrl As Label
    Friend WithEvents lCode As Label
    Friend WithEvents lProtocol As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
