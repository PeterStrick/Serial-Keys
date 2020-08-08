<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SerialKeysUI
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SerialKeysUI))
        Me.ShowOwnDBBtn = New System.Windows.Forms.Button()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.SampleDBBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShowOwnDBBtn
        '
        Me.ShowOwnDBBtn.Location = New System.Drawing.Point(12, 12)
        Me.ShowOwnDBBtn.Name = "ShowOwnDBBtn"
        Me.ShowOwnDBBtn.Size = New System.Drawing.Size(135, 44)
        Me.ShowOwnDBBtn.TabIndex = 0
        Me.ShowOwnDBBtn.Text = "Show your own Serial Keys Database"
        Me.ShowOwnDBBtn.UseVisualStyleBackColor = True
        '
        'SearchBtn
        '
        Me.SearchBtn.Location = New System.Drawing.Point(171, 12)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(135, 44)
        Me.SearchBtn.TabIndex = 1
        Me.SearchBtn.Text = "Search for Serial Keys online"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'SampleDBBtn
        '
        Me.SampleDBBtn.Location = New System.Drawing.Point(331, 12)
        Me.SampleDBBtn.Name = "SampleDBBtn"
        Me.SampleDBBtn.Size = New System.Drawing.Size(135, 44)
        Me.SampleDBBtn.TabIndex = 2
        Me.SampleDBBtn.Text = "Show a sample Serial Keys Database"
        Me.SampleDBBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SerialKeysUI.My.Resources.Resources.key
        Me.PictureBox1.Location = New System.Drawing.Point(46, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SerialKeysUI.My.Resources.Resources.internet_64px
        Me.PictureBox2.Location = New System.Drawing.Point(206, 62)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SerialKeysUI.My.Resources.Resources.key_share_64px
        Me.PictureBox3.Location = New System.Drawing.Point(366, 62)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "(Icons provided by FreePik)"
        '
        'SerialKeysUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 155)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SampleDBBtn)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.ShowOwnDBBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SerialKeysUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Serial Keys User Interface"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ShowOwnDBBtn As Button
    Friend WithEvents SearchBtn As Button
    Friend WithEvents SampleDBBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
End Class
