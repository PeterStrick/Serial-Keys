<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSerialKeys
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSerialKeys))
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OSDataSet = New SerialKeys.DataSet1()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataGridViewContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteRowCellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedCellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectionModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.EnableMultiSelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableMultiSelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyDatabaseToDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.EraseDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangelogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.DataTable1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.License = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.DataGridViewContextMenu.SuspendLayout()
        CType(Me.DataTable1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.OSDataSet
        '
        'OSDataSet
        '
        Me.OSDataSet.DataSetName = "OSDataSet"
        Me.OSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ContextMenuStrip = Me.DataGridViewContextMenu
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseToolStripMenuItem, Me.ProgramToolStripMenuItem, Me.AboutToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripTextBox1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(726, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataGridViewContextMenu
        '
        Me.DataGridViewContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteRowCellToolStripMenuItem, Me.SelectionModeToolStripMenuItem})
        Me.DataGridViewContextMenu.Name = "DataGridViewContextMenu"
        Me.DataGridViewContextMenu.Size = New System.Drawing.Size(157, 48)
        Me.DataGridViewContextMenu.Text = "Data Grid Options"
        '
        'DeleteRowCellToolStripMenuItem
        '
        Me.DeleteRowCellToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSelectedRowToolStripMenuItem, Me.DeleteSelectedCellToolStripMenuItem})
        Me.DeleteRowCellToolStripMenuItem.Name = "DeleteRowCellToolStripMenuItem"
        Me.DeleteRowCellToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.DeleteRowCellToolStripMenuItem.Text = "Delete"
        '
        'DeleteSelectedRowToolStripMenuItem
        '
        Me.DeleteSelectedRowToolStripMenuItem.Enabled = False
        Me.DeleteSelectedRowToolStripMenuItem.Name = "DeleteSelectedRowToolStripMenuItem"
        Me.DeleteSelectedRowToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteSelectedRowToolStripMenuItem.Text = "Delete Selected Row"
        '
        'DeleteSelectedCellToolStripMenuItem
        '
        Me.DeleteSelectedCellToolStripMenuItem.Name = "DeleteSelectedCellToolStripMenuItem"
        Me.DeleteSelectedCellToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteSelectedCellToolStripMenuItem.Text = "Delete Selected Cell"
        '
        'SelectionModeToolStripMenuItem
        '
        Me.SelectionModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RowToolStripMenuItem, Me.CellToolStripMenuItem, Me.ToolStripSeparator5, Me.EnableMultiSelectToolStripMenuItem, Me.DisableMultiSelectToolStripMenuItem})
        Me.SelectionModeToolStripMenuItem.Name = "SelectionModeToolStripMenuItem"
        Me.SelectionModeToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SelectionModeToolStripMenuItem.Text = "Selection mode"
        '
        'RowToolStripMenuItem
        '
        Me.RowToolStripMenuItem.Name = "RowToolStripMenuItem"
        Me.RowToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.RowToolStripMenuItem.Text = "Full Row"
        '
        'CellToolStripMenuItem
        '
        Me.CellToolStripMenuItem.Enabled = False
        Me.CellToolStripMenuItem.Name = "CellToolStripMenuItem"
        Me.CellToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.CellToolStripMenuItem.Text = "Cell only"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(235, 6)
        '
        'EnableMultiSelectToolStripMenuItem
        '
        Me.EnableMultiSelectToolStripMenuItem.Name = "EnableMultiSelectToolStripMenuItem"
        Me.EnableMultiSelectToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.EnableMultiSelectToolStripMenuItem.Text = "Enable Multi Select (Hold Shift)"
        '
        'DisableMultiSelectToolStripMenuItem
        '
        Me.DisableMultiSelectToolStripMenuItem.Enabled = False
        Me.DisableMultiSelectToolStripMenuItem.Name = "DisableMultiSelectToolStripMenuItem"
        Me.DisableMultiSelectToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.DisableMultiSelectToolStripMenuItem.Text = "Disable Multi Select"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ReloadToolStripMenuItem, Me.ToolStripSeparator1, Me.EditToolStripMenuItem, Me.CopyDatabaseToDesktopToolStripMenuItem, Me.ToolStripSeparator4, Me.PrintDatabaseToolStripMenuItem, Me.ToolStripSeparator3, Me.EraseDatabaseToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(67, 23)
        Me.DatabaseToolStripMenuItem.Text = "&Database"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.SaveToolStripMenuItem.Text = "&Save Database"
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.Image = CType(resources.GetObject("ReloadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.ReloadToolStripMenuItem.Text = "&Reload and Restore Database"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(227, 6)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = CType(resources.GetObject("EditToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.EditToolStripMenuItem.Text = "Edit Database"
        '
        'CopyDatabaseToDesktopToolStripMenuItem
        '
        Me.CopyDatabaseToDesktopToolStripMenuItem.Image = CType(resources.GetObject("CopyDatabaseToDesktopToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyDatabaseToDesktopToolStripMenuItem.Name = "CopyDatabaseToDesktopToolStripMenuItem"
        Me.CopyDatabaseToDesktopToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.CopyDatabaseToDesktopToolStripMenuItem.Text = "Copy Database to Desktop"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(227, 6)
        '
        'PrintDatabaseToolStripMenuItem
        '
        Me.PrintDatabaseToolStripMenuItem.Image = CType(resources.GetObject("PrintDatabaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintDatabaseToolStripMenuItem.Name = "PrintDatabaseToolStripMenuItem"
        Me.PrintDatabaseToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.PrintDatabaseToolStripMenuItem.Text = "Print Database"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(227, 6)
        '
        'EraseDatabaseToolStripMenuItem
        '
        Me.EraseDatabaseToolStripMenuItem.Image = CType(resources.GetObject("EraseDatabaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EraseDatabaseToolStripMenuItem.Name = "EraseDatabaseToolStripMenuItem"
        Me.EraseDatabaseToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.EraseDatabaseToolStripMenuItem.Text = "Erase Database"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 23)
        Me.ProgramToolStripMenuItem.Text = "&Program"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(181, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.ChangelogToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(44, 23)
        Me.AboutToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Image = CType(resources.GetObject("AboutToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(184, 26)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'ChangelogToolStripMenuItem
        '
        Me.ChangelogToolStripMenuItem.Image = CType(resources.GetObject("ChangelogToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangelogToolStripMenuItem.Name = "ChangelogToolStripMenuItem"
        Me.ChangelogToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.ChangelogToolStripMenuItem.Text = "Changelog"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Enabled = False
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(60, 23)
        Me.SearchToolStripMenuItem.Text = "Search: "
        Me.SearchToolStripMenuItem.ToolTipText = "Enter a keyword for the Name of the product you are trying to search to start sea" &
    "rching."
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.ToolTipText = "Enter a keyword for the Name of the product you are trying to search to start sea" &
    "rching."
        '
        'DataTable1DataGridView
        '
        Me.DataTable1DataGridView.AllowUserToOrderColumns = True
        Me.DataTable1DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataTable1DataGridView.AutoGenerateColumns = False
        Me.DataTable1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTable1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.License})
        Me.DataTable1DataGridView.ContextMenuStrip = Me.DataGridViewContextMenu
        Me.DataTable1DataGridView.DataSource = Me.DataTable1BindingSource
        Me.DataTable1DataGridView.Location = New System.Drawing.Point(0, 30)
        Me.DataTable1DataGridView.MultiSelect = False
        Me.DataTable1DataGridView.Name = "DataTable1DataGridView"
        Me.DataTable1DataGridView.Size = New System.Drawing.Size(726, 255)
        Me.DataTable1DataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Text"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name des Produktes"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'License
        '
        Me.License.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.License.DataPropertyName = "License"
        Me.License.HeaderText = "Lizensschlüssel"
        Me.License.Name = "License"
        '
        'FrmSerialKeys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 284)
        Me.ContextMenuStrip = Me.DataGridViewContextMenu
        Me.Controls.Add(Me.DataTable1DataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSerialKeys"
        Me.Text = "Serial Keys"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.DataGridViewContextMenu.ResumeLayout(False)
        CType(Me.DataTable1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
   Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ReloadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OSDataSet As SerialKeys.DataSet1
    Friend WithEvents DataTable1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents License As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CopyDatabaseToDesktopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents PrintDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents EraseDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangelogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataTable1BindingSource As BindingSource
    Public WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Public WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents DataGridViewContextMenu As ContextMenuStrip
    Friend WithEvents DeleteRowCellToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectionModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CellToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableMultiSelectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents DisableMultiSelectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteSelectedRowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteSelectedCellToolStripMenuItem As ToolStripMenuItem
End Class
