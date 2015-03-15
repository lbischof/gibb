<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnSort = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.lblStats = New System.Windows.Forms.Label()
        Me.cboAlgorithm = New System.Windows.Forms.ComboBox()
        Me.chkUmlaute = New System.Windows.Forms.CheckBox()
        Me.chkWords = New System.Windows.Forms.CheckBox()
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEditSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsUmlaute = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsColorForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsColorTextbox = New System.Windows.Forms.ToolStripMenuItem()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.tlbToolbar = New System.Windows.Forms.ToolStrip()
        Me.tlbNew = New System.Windows.Forms.ToolStripButton()
        Me.tlbOpen = New System.Windows.Forms.ToolStripButton()
        Me.tlbSave = New System.Windows.Forms.ToolStripButton()
        Me.tlbCut = New System.Windows.Forms.ToolStripButton()
        Me.tlbCopy = New System.Windows.Forms.ToolStripButton()
        Me.tlbPaste = New System.Windows.Forms.ToolStripButton()
        Me.tlbSort = New System.Windows.Forms.ToolStripButton()
        Me.mnuMenu.SuspendLayout()
        Me.tlbToolbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(521, 291)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(75, 23)
        Me.btnSort.TabIndex = 4
        Me.btnSort.Text = "Sortieren"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(12, 52)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInput.Size = New System.Drawing.Size(503, 196)
        Me.txtInput.TabIndex = 0
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(13, 264)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(502, 234)
        Me.txtOutput.TabIndex = 5
        '
        'lblStats
        '
        Me.lblStats.AutoSize = True
        Me.lblStats.Location = New System.Drawing.Point(519, 324)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(0, 13)
        Me.lblStats.TabIndex = 3
        '
        'cboAlgorithm
        '
        Me.cboAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlgorithm.FormattingEnabled = True
        Me.cboAlgorithm.Items.AddRange(New Object() {"Bubblesort", "Insertsort", "Quicksort"})
        Me.cboAlgorithm.Location = New System.Drawing.Point(521, 264)
        Me.cboAlgorithm.Name = "cboAlgorithm"
        Me.cboAlgorithm.Size = New System.Drawing.Size(121, 21)
        Me.cboAlgorithm.Sorted = True
        Me.cboAlgorithm.TabIndex = 3
        '
        'chkUmlaute
        '
        Me.chkUmlaute.AutoSize = True
        Me.chkUmlaute.Location = New System.Drawing.Point(521, 208)
        Me.chkUmlaute.Name = "chkUmlaute"
        Me.chkUmlaute.Size = New System.Drawing.Size(65, 17)
        Me.chkUmlaute.TabIndex = 1
        Me.chkUmlaute.Text = "Umlaute"
        Me.chkUmlaute.UseVisualStyleBackColor = True
        '
        'chkWords
        '
        Me.chkWords.AutoSize = True
        Me.chkWords.Location = New System.Drawing.Point(521, 231)
        Me.chkWords.Name = "chkWords"
        Me.chkWords.Size = New System.Drawing.Size(58, 17)
        Me.chkWords.TabIndex = 2
        Me.chkWords.Text = "Wörter"
        Me.chkWords.UseVisualStyleBackColor = True
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuOptions})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(653, 24)
        Me.mnuMenu.TabIndex = 8
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.mnuFileSave, Me.ToolStripMenuItem2, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(46, 20)
        Me.mnuFile.Text = "&Datei"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(168, 22)
        Me.mnuFileNew.Text = "&Neu"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeyDisplayString = ""
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(168, 22)
        Me.mnuFileOpen.Text = "&Öffnen"
        Me.mnuFileOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(168, 22)
        Me.mnuFileSave.Text = "&Speichern"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(165, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(168, 22)
        Me.mnuFileExit.Text = "&Beenden"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCut, Me.mnuEditCopy, Me.mnuEditPaste, Me.ToolStripMenuItem1, Me.mnuEditSort})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(75, 20)
        Me.mnuEdit.Text = "&Bearbeiten"
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEditCut.Size = New System.Drawing.Size(191, 22)
        Me.mnuEditCut.Text = "&Ausschneiden"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(191, 22)
        Me.mnuEditCopy.Text = "&Kopieren"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(191, 22)
        Me.mnuEditPaste.Text = "&Einfügen"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(188, 6)
        '
        'mnuEditSort
        '
        Me.mnuEditSort.Name = "mnuEditSort"
        Me.mnuEditSort.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuEditSort.Size = New System.Drawing.Size(191, 22)
        Me.mnuEditSort.Text = "&Sortieren"
        '
        'mnuOptions
        '
        Me.mnuOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsUmlaute, Me.mnuOptionsColor})
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(69, 20)
        Me.mnuOptions.Text = "&Optionen"
        '
        'mnuOptionsUmlaute
        '
        Me.mnuOptionsUmlaute.CheckOnClick = True
        Me.mnuOptionsUmlaute.Name = "mnuOptionsUmlaute"
        Me.mnuOptionsUmlaute.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnuOptionsUmlaute.Size = New System.Drawing.Size(163, 22)
        Me.mnuOptionsUmlaute.Text = "&Umlaute"
        '
        'mnuOptionsColor
        '
        Me.mnuOptionsColor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsColorForm, Me.mnuOptionsColorTextbox})
        Me.mnuOptionsColor.Name = "mnuOptionsColor"
        Me.mnuOptionsColor.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuOptionsColor.Size = New System.Drawing.Size(163, 22)
        Me.mnuOptionsColor.Text = "&Farbe"
        '
        'mnuOptionsColorForm
        '
        Me.mnuOptionsColorForm.Name = "mnuOptionsColorForm"
        Me.mnuOptionsColorForm.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuOptionsColorForm.Size = New System.Drawing.Size(164, 22)
        Me.mnuOptionsColorForm.Text = "&Formular"
        '
        'mnuOptionsColorTextbox
        '
        Me.mnuOptionsColorTextbox.Name = "mnuOptionsColorTextbox"
        Me.mnuOptionsColorTextbox.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mnuOptionsColorTextbox.Size = New System.Drawing.Size(164, 22)
        Me.mnuOptionsColorTextbox.Text = "&Textbox"
        '
        'dlgSave
        '
        Me.dlgSave.DefaultExt = "txt"
        Me.dlgSave.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*"
        Me.dlgSave.RestoreDirectory = True
        '
        'dlgOpen
        '
        Me.dlgOpen.FileName = "OpenFileDialog1"
        Me.dlgOpen.Filter = "Textdateien (*.txt)|*.txt"
        '
        'tlbToolbar
        '
        Me.tlbToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbNew, Me.tlbOpen, Me.tlbSave, Me.tlbCut, Me.tlbCopy, Me.tlbPaste, Me.tlbSort})
        Me.tlbToolbar.Location = New System.Drawing.Point(0, 24)
        Me.tlbToolbar.Name = "tlbToolbar"
        Me.tlbToolbar.Size = New System.Drawing.Size(653, 25)
        Me.tlbToolbar.TabIndex = 9
        Me.tlbToolbar.Text = "ToolStrip1"
        '
        'tlbNew
        '
        Me.tlbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbNew.Image = CType(resources.GetObject("tlbNew.Image"), System.Drawing.Image)
        Me.tlbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbNew.Name = "tlbNew"
        Me.tlbNew.Size = New System.Drawing.Size(23, 22)
        Me.tlbNew.Text = "Neu"
        '
        'tlbOpen
        '
        Me.tlbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbOpen.Image = Global.Sortieren.My.Resources.Resources.Open
        Me.tlbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbOpen.Name = "tlbOpen"
        Me.tlbOpen.Size = New System.Drawing.Size(23, 22)
        Me.tlbOpen.Text = "Öffnen"
        '
        'tlbSave
        '
        Me.tlbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbSave.Image = Global.Sortieren.My.Resources.Resources.Save
        Me.tlbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbSave.Name = "tlbSave"
        Me.tlbSave.Size = New System.Drawing.Size(23, 22)
        Me.tlbSave.Text = "Speichern"
        '
        'tlbCut
        '
        Me.tlbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbCut.Image = Global.Sortieren.My.Resources.Resources.Cut
        Me.tlbCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbCut.Name = "tlbCut"
        Me.tlbCut.Size = New System.Drawing.Size(23, 22)
        Me.tlbCut.Text = "Ausschneiden"
        '
        'tlbCopy
        '
        Me.tlbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbCopy.Image = Global.Sortieren.My.Resources.Resources.Copy
        Me.tlbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbCopy.Name = "tlbCopy"
        Me.tlbCopy.Size = New System.Drawing.Size(23, 22)
        Me.tlbCopy.Text = "Kopieren"
        '
        'tlbPaste
        '
        Me.tlbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbPaste.Image = Global.Sortieren.My.Resources.Resources.Paste
        Me.tlbPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbPaste.Name = "tlbPaste"
        Me.tlbPaste.Size = New System.Drawing.Size(23, 22)
        Me.tlbPaste.Text = "Einfügen"
        '
        'tlbSort
        '
        Me.tlbSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbSort.Image = Global.Sortieren.My.Resources.Resources.Sortasc
        Me.tlbSort.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbSort.Name = "tlbSort"
        Me.tlbSort.Size = New System.Drawing.Size(23, 22)
        Me.tlbSort.Text = "Sortieren"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 510)
        Me.Controls.Add(Me.tlbToolbar)
        Me.Controls.Add(Me.chkWords)
        Me.Controls.Add(Me.chkUmlaute)
        Me.Controls.Add(Me.cboAlgorithm)
        Me.Controls.Add(Me.lblStats)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.mnuMenu)
        Me.MainMenuStrip = Me.mnuMenu
        Me.Name = "frmMain"
        Me.Text = "Sortieren"
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.tlbToolbar.ResumeLayout(False)
        Me.tlbToolbar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents lblStats As System.Windows.Forms.Label
    Friend WithEvents cboAlgorithm As System.Windows.Forms.ComboBox
    Friend WithEvents chkUmlaute As System.Windows.Forms.CheckBox
    Friend WithEvents chkWords As System.Windows.Forms.CheckBox
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditSort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptionsUmlaute As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptionsColor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptionsColorForm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptionsColorTextbox As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dlgColor As System.Windows.Forms.ColorDialog
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tlbToolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbSort As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbSave As System.Windows.Forms.ToolStripButton

End Class
