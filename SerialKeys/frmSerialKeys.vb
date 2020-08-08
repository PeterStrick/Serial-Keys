Imports System.IO
Public Class FrmSerialKeys

    'Initialize Variables
    Dim AppFolder As String = Application.StartupPath + "\"                                                                                         'Application startup path
    Dim DatabaseFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Peters Software Solutions\SerialKeys"   'User\AppData\Roaming
    Dim Database As String = DatabaseFolder + "\Dataset1.xml"                                                                        'Database.xml in Application startup path
    Dim Desktop As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)                                                   'User\Desktop
    Dim LocalAppData As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)                                          'User\AppData\Local
    Dim Temp As String = LocalAppData + "\Temp\"                                                                                                    'User\AppData\Local\Temp
    Private _Datafile As New FileInfo(Database)                                                                                                     'Database
    Dim DataFile As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Peters Software Solutions\SerialKeys\Dataset1.xml"

    Private Sub FrmSerialKeys_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        SerialKeysClass.CheckIfRoamingFolderExists()

        'Buttons and My.Settings
        If My.Settings.usePrinting = False Then
            PrintDatabaseToolStripMenuItem.Enabled = False
            settingsForm.DisablePrintingCheck.Checked = True
        End If
        If My.Settings.useErase = False Then
            EraseDatabaseToolStripMenuItem.Enabled = False
            settingsForm.DisableDbEraseCheck.Checked = True
        End If
        If My.Settings.useEdit = False Then
            EditToolStripMenuItem.Enabled = False
            settingsForm.DisableDbEditCheck.Checked = True
        End If
        If My.Settings.useCopy = False Then
            CopyDatabaseToDesktopToolStripMenuItem.Enabled = False
            settingsForm.DisableDbToDeskCheck.Checked = True
        End If

        If My.Settings.useMasterKey = True Then
            settingsForm.TextBox1.Text = My.Settings.masterKey
            settingsForm.TextBox1.Enabled = True
            settingsForm.Button1.Enabled = True
        Else
            settingsForm.TextBox1.Enabled = False
            settingsForm.Button1.Enabled = False
        End If

        'Load the Database
        LoadDB()

    End Sub
    Private Sub MenuStrip1_MenuClicked(ByVal Sender As Object, ByVal e As EventArgs) _
         Handles SaveToolStripMenuItem.Click, ReloadToolStripMenuItem.Click
        Select Case True
            Case Sender Is SaveToolStripMenuItem
                Save()
                MsgBox("Database saved")
            Case Sender Is ReloadToolStripMenuItem
                Reload()

        End Select
    End Sub
    Private Sub Reload()
        If File.Exists(Database) Then
            OSDataSet.Clear()
            OSDataSet.ReadXml(DataFile)
            MsgBox("Database reloaded")
        Else
            'MsgBox(String.Join(Environment.NewLine, {"Es ist keine Datenbank vorhanden.",
            '_Datafile.FullName, "", "Sie fahren mit einer leeren Datenbank fort"}))
            MsgBox("Error 1 : Es ist keine Datenbank vorhanden. Sie fahren mit einer leeren Datenbank fort.", vbCritical, "Es ist keine Datenbank vorhanden.")
        End If
    End Sub
    Private Sub LoadDB()
        Try
            OSDataSet.Clear()
            OSDataSet.ReadXml(DataFile)
        Catch ex As IOException
            MsgBox("Error 1 : Es ist keine Datenbank vorhanden. Sie fahren mit einer leeren Datenbank fort.", vbCritical, "Es ist keine Datenbank vorhanden.")
        Catch ex As Exception
            MsgBox("Ein Fehler ist aufgetreten." + Environment.NewLine + ex.Message)
        End Try

        'MsgBox(String.Join(Environment.NewLine, {"Es ist keine Datenbank vorhanden.",
        '_Datafile.FullName, "", "Sie fahren mit einer leeren Datenbank fort"}))

    End Sub
    Private Sub Save()
        Me.Validate()
        OSDataSet.WriteXml(DataFile)
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutBox1.Show()
    End Sub
    Private Sub FrmSerialKeys_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        saveForm.ShowDialog()

        My.Settings.Save()
    End Sub
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        settingsForm.ShowDialog()
    End Sub
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        System.Diagnostics.Process.Start("C:\Windows\System32\notepad.exe", "" + Database)
    End Sub
    Private Sub CopyDatabaseToDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyDatabaseToDesktopToolStripMenuItem.Click
        If File.Exists(DatabaseFolder + "\Dataset1.xml") Then
            File.Copy(DatabaseFolder + "\Dataset1.xml", Desktop + "\Dataset1.xml", True)
            MsgBox("File Dataset1.xml copied to Desktop successfully")
        Else
            MsgBox("Error 1 : File not found. The Database file doesn´t exist. Do you want to save it and then copy it to the Desktop?", vbExclamation And vbYesNo, "Error 1 : File not found")
            If CBool(MsgBoxResult.Yes) Then
                Save()
                If IO.File.Exists(DatabaseFolder + "\Dataset1.xml") Then
                    IO.File.Copy(DatabaseFolder + "\Dataset1.xml", Desktop + "\Dataset1.xml")
                    MsgBox("File Dataset1.xml copied to Desktop successfully")
                Else
                    MsgBox("Error 2 : Error while copying File .\DataSet1.xml")
                End If
            End If
        End If
    End Sub
    Private Sub PrintDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintDatabaseToolStripMenuItem.Click

        Dim filename As String = LocalAppData + "TEMP\print_dataSet_tmp.txt"
        Dim Result As Boolean = SaveDataGridContent(SerialKeysClass.AppPath & "DatenBankInText.txt", DataTable1DataGridView)
        Select Case Result
            Case True
                MessageBox.Show("Datei wurde gespeichert.", "Info")
            Case Else
                MessageBox.Show("Datei konnte nicht gespeichert werden...", "Info")
        End Select
        If File.Exists(SerialKeysClass.AppPath & "DatenBankInText.txt") Then
            Diagnostics.Process.Start("C:\Windows\system32\notepad.exe", "/P " + SerialKeysClass.AppPath & "DatenBankInText.txt")
        Else
            MessageBox.Show("Die Datei konnte nicht gedruckt werden. Bitte überprüfen sie ob keine andere Anwendung diese Anwendung blockiert.", "Info")
        End If

    End Sub
    Private Sub EraseDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EraseDatabaseToolStripMenuItem.Click

        MsgBox("Warning this will erase the complete Database. Are you sure?", vbYesNo, "Erase Database")
        If CBool(MsgBoxResult.Yes) Then
            If File.Exists(Database) Then
                File.Delete(Database)
                MsgBox("File Dataset1.xml deleted successfully")
                My.Settings.restartSetting = True
                My.Settings.Save()
                Application.Restart()
            Else
                MsgBox("Error 1 : File not found. The Database file doesn´t exist.", vbCritical And vbOKOnly, "Error 1 : File not found")
            End If
        ElseIf CBool(MsgBoxResult.No) Then
            MsgBox("Database erasion canceled.")
        ElseIf CBool(MsgBoxResult.Cancel) Then
            MsgBox("Database erasion canceled.")
        End If

    End Sub
    Public Function SaveDataGridContent(ByVal Filename As String,
        ByVal dg As DataGridView) As Boolean
        Try
            Using sw As StreamWriter = New StreamWriter(Filename, False, System.Text.Encoding.Default)
                sw.Write("Name des Produktes; Produktschlüssel")
                sw.Write(Environment.NewLine)
                sw.Write(Environment.NewLine)
                For Each rows As DataGridViewRow In dg.Rows
                    For Each cells As DataGridViewCell In rows.Cells
                        If CType(cells.Value, String) <> "" Then
                            sw.Write(CType(cells.Value, String) & " ; ")
                        End If
                    Next
                    sw.Write(Environment.NewLine)
                    sw.Write("- - - - - - - - - - - -")
                    sw.Write(Environment.NewLine)
                Next
            End Using
            If File.Exists(Filename) Then
                Return True
            Else
                Return False
            End If
        Catch ex As IOException
            MessageBox.Show(ex.Message.ToString(), "IOException")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Exception")
        End Try
    End Function

    Private Sub ChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click
        Changelog.ShowDialog()
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        'Works but the searched text needs to be in the NAme cell aswell as the license cell
        'Me.DataTable1BindingSource.Filter = "Text LIKE '" & ToolStripTextBox1.Text & "%' "

        Me.DataTable1BindingSource.Filter = "Text like '%" & ToolStripTextBox1.Text & "%'"
        'Me.DataTable1BindingSource.Filter = "License LIKE '" & ToolStripTextBox1.Text & "%' "
    End Sub

    Private Sub RowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RowToolStripMenuItem.Click
        DataTable1DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'Buttons
        RowToolStripMenuItem.Enabled = False
        DeleteSelectedCellToolStripMenuItem.Enabled = False
        DeleteSelectedRowToolStripMenuItem.Enabled = True
        CellToolStripMenuItem.Enabled = True

    End Sub

    Private Sub CellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CellToolStripMenuItem.Click
        DataTable1DataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect

        'Buttons
        RowToolStripMenuItem.Enabled = True
        CellToolStripMenuItem.Enabled = False
        DeleteSelectedCellToolStripMenuItem.Enabled = True
        DeleteSelectedRowToolStripMenuItem.Enabled = False

    End Sub

    Private Sub EnableMultiSelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableMultiSelectToolStripMenuItem.Click
        DataTable1DataGridView.MultiSelect = True

        'Buttons
        EnableMultiSelectToolStripMenuItem.Enabled = False
        DisableMultiSelectToolStripMenuItem.Enabled = True
    End Sub

    Private Sub DisableMultiSelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisableMultiSelectToolStripMenuItem.Click
        DataTable1DataGridView.MultiSelect = False

        'Buttons
        EnableMultiSelectToolStripMenuItem.Enabled = True
        DisableMultiSelectToolStripMenuItem.Enabled = False
    End Sub

    Private Sub DeleteSelectedCellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedCellToolStripMenuItem.Click
        For Each DataGridViewCell In Me.DataTable1DataGridView.SelectedCells
            'DataGridViewCell.value = ""
        Next
    End Sub
End Class
