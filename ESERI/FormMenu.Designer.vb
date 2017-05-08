<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTLogout = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BTSound = New System.Windows.Forms.Button
        Me.BTTime = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTLogout)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BTSound)
        Me.GroupBox1.Controls.Add(Me.BTTime)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 346)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'BTLogout
        '
        Me.BTLogout.BackColor = System.Drawing.Color.SeaGreen
        Me.BTLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTLogout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTLogout.Location = New System.Drawing.Point(245, 285)
        Me.BTLogout.Name = "BTLogout"
        Me.BTLogout.Size = New System.Drawing.Size(105, 40)
        Me.BTLogout.TabIndex = 16
        Me.BTLogout.Text = "LOGOUT"
        Me.BTLogout.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tempus Sans ITC", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(390, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 26)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "SOUND"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(126, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "TIMER"
        '
        'BTSound
        '
        Me.BTSound.BackColor = System.Drawing.SystemColors.Window
        Me.BTSound.BackgroundImage = CType(resources.GetObject("BTSound.BackgroundImage"), System.Drawing.Image)
        Me.BTSound.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTSound.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTSound.Location = New System.Drawing.Point(365, 92)
        Me.BTSound.Name = "BTSound"
        Me.BTSound.Size = New System.Drawing.Size(131, 132)
        Me.BTSound.TabIndex = 10
        Me.BTSound.UseVisualStyleBackColor = False
        '
        'BTTime
        '
        Me.BTTime.BackColor = System.Drawing.SystemColors.Window
        Me.BTTime.BackgroundImage = CType(resources.GetObject("BTTime.BackgroundImage"), System.Drawing.Image)
        Me.BTTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTTime.Location = New System.Drawing.Point(98, 93)
        Me.BTTime.Name = "BTTime"
        Me.BTTime.Size = New System.Drawing.Size(131, 132)
        Me.BTTime.TabIndex = 7
        Me.BTTime.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.ESERI
        Me.PictureBox1.Location = New System.Drawing.Point(266, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(669, 434)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ESERI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTSound As System.Windows.Forms.Button
    Friend WithEvents BTTime As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTLogout As System.Windows.Forms.Button
End Class
