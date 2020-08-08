<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SerialKeysOnline
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SerialKeysOnline))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.OpenSerialKeysBtn = New System.Windows.Forms.Button()
        Me.ForwardBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(800, 450)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://findserialnumber.net", System.UriKind.Absolute)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.OpenSerialKeysBtn)
        Me.Panel1.Controls.Add(Me.ForwardBtn)
        Me.Panel1.Controls.Add(Me.BackBtn)
        Me.Panel1.Controls.Add(Me.HomeBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 29)
        Me.Panel1.TabIndex = 1
        '
        'HomeBtn
        '
        Me.HomeBtn.Location = New System.Drawing.Point(3, 3)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(75, 23)
        Me.HomeBtn.TabIndex = 2
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'BackBtn
        '
        Me.BackBtn.Location = New System.Drawing.Point(84, 3)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(75, 23)
        Me.BackBtn.TabIndex = 3
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'OpenSerialKeysBtn
        '
        Me.OpenSerialKeysBtn.Location = New System.Drawing.Point(246, 3)
        Me.OpenSerialKeysBtn.Name = "OpenSerialKeysBtn"
        Me.OpenSerialKeysBtn.Size = New System.Drawing.Size(100, 23)
        Me.OpenSerialKeysBtn.TabIndex = 5
        Me.OpenSerialKeysBtn.Text = "Open Serial Keys"
        Me.OpenSerialKeysBtn.UseVisualStyleBackColor = True
        '
        'ForwardBtn
        '
        Me.ForwardBtn.Location = New System.Drawing.Point(165, 3)
        Me.ForwardBtn.Name = "ForwardBtn"
        Me.ForwardBtn.Size = New System.Drawing.Size(75, 23)
        Me.ForwardBtn.TabIndex = 4
        Me.ForwardBtn.Text = "Forward"
        Me.ForwardBtn.UseVisualStyleBackColor = True
        '
        'SerialKeysOnline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SerialKeysOnline"
        Me.Text = "Find Serial Keys online"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OpenSerialKeysBtn As Button
    Friend WithEvents ForwardBtn As Button
    Friend WithEvents BackBtn As Button
    Friend WithEvents HomeBtn As Button
End Class
