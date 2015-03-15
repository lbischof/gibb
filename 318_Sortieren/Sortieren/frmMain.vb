Imports System.Threading.Tasks
Imports System.Threading
Imports System.Text.RegularExpressions
Imports System.IO

Public Class frmMain
    Dim sw As New Stopwatch
    Dim Sortbase As New Sort
    Dim Bubble As New Bubblesort
    Dim Quick As New Quicksort
    Dim Insert As New Insertsort

    ''' <summary>
    ''' Disables the clicked button and starts stopwatch. When the sorted string is returned it enables the button and shows the stopwatch value. 
    ''' </summary>
    Async Sub Sort()
        If txtInput.Text.Trim IsNot "" Then
            btnSort.Enabled = False
            sw.Start()
            txtOutput.Text = Await CallSortAlgorithm(txtInput.Text)
            lblStats.Text = "Sortierzeit: " & sw.ElapsedMilliseconds.ToString & " ms"
            sw.Reset()
            btnSort.Enabled = True
        Else
            MsgBox("Bitte geben Sie einen Sortiertext ein!")
        End If
    End Sub

    ''' <summary>
    ''' Chooses the sorting algorithm based on cboAlgorithm and calls it
    ''' </summary>
    ''' <param name="input">The unsorted string</param>
    ''' <returns>The sorted string</returns>
    Async Function CallSortAlgorithm(ByVal input As String) As Task(Of String)
        Dim sorted As String
        Dim bolSortUmlauts As Boolean = chkUmlaute.Checked
        Dim bolWords As Boolean = chkWords.Checked
        Dim arr As Array
        If bolWords Then
            input = Regex.Replace(input, "\s+", " ").Trim ' remove excessive whitespace
            arr = input.Split(" ")
        Else
            arr = input.ToCharArray
        End If
        Select Case cboAlgorithm.SelectedItem
            Case "Bubblesort"
                sorted = Await Bubble.Sort(arr, bolSortUmlauts)
            Case "Quicksort"
                sorted = Await Quick.Sort(arr, bolSortUmlauts)
            Case "Insertsort"
                sorted = Await Insert.Sort(arr, bolSortUmlauts)
            Case Else
                sorted = "Algorithmus existiert nicht."
        End Select
        Return sorted
    End Function

    Sub Sort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click, mnuEditSort.Click, tlbSort.Click
        Sort()
    End Sub

    Sub New_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileNew.Click, tlbNew.Click
        txtInput.Text = String.Empty
        txtOutput.Text = String.Empty
    End Sub

    Sub Save_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileSave.Click, tlbSave.Click
        If TypeOf ActiveControl Is TextBox Then
            If dlgSave.ShowDialog() = DialogResult.OK Then
                File.WriteAllText(dlgSave.FileName, CType(ActiveControl, TextBox).Text)
            End If
        Else
            MsgBox("Bitte Fokus in die zu speichernde Textbox setzen", MsgBoxStyle.Information)
        End If
    End Sub

    Sub Open_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileOpen.Click, tlbOpen.Click
        If dlgOpen.ShowDialog() = DialogResult.OK Then
            txtInput.Text = File.ReadAllText(dlgOpen.FileName)
        End If
    End Sub

    Sub Copy_Click(sender As System.Object, e As System.EventArgs) Handles mnuEditCopy.Click, tlbCopy.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Copy()
        End If
    End Sub

    Sub Cut_Click(sender As System.Object, e As System.EventArgs) Handles mnuEditCut.Click, tlbCut.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Cut()
        End If
    End Sub

    Sub Paste_Click(sender As System.Object, e As System.EventArgs) Handles mnuEditPaste.Click, tlbPaste.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Paste()
        End If
    End Sub

    Sub Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cboAlgorithm.SelectedIndex = 0
        txtInput.Select()
    End Sub

    Sub mnuFileExit_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
        End
    End Sub

    Sub mnuOptionsColorForm_Click(sender As System.Object, e As System.EventArgs) Handles mnuOptionsColorForm.Click
        If dlgColor.ShowDialog() = DialogResult.OK Then
            Me.BackColor = dlgColor.Color
        End If
    End Sub

    Sub mnuOptionsColorTextbox_Click(sender As System.Object, e As System.EventArgs) Handles mnuOptionsColorTextbox.Click
        If dlgColor.ShowDialog() = DialogResult.OK Then
            txtInput.BackColor = dlgColor.Color
            txtOutput.BackColor = dlgColor.Color
        End If
    End Sub

    ''' <summary>
    ''' Makes sure both umlaut checkboxes are in sync.
    ''' </summary>
    Private Sub chkUmlaute_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUmlaute.CheckedChanged, mnuOptionsUmlaute.CheckedChanged
        Dim bolChecked As Boolean = sender.Checked
        chkUmlaute.Checked = bolChecked
        mnuOptionsUmlaute.Checked = bolChecked
    End Sub

    ''' <summary>
    ''' Updates the toolbar and menubar if anything important happens: focus changed, text entered, text selected etc.
    ''' </summary>
    Private Sub updateToolbar(sender As System.Object, e As System.EventArgs) Handles mnuEdit.DropDownOpening, txtInput.MouseUp, txtInput.KeyUp, txtInput.Click, txtInput.TextChanged, txtInput.Enter, txtInput.Leave, txtOutput.Click, txtOutput.MouseUp, txtOutput.KeyUp, txtOutput.Enter, txtOutput.Leave
        If TypeOf Me.ActiveControl Is TextBox Then
            Dim bolSelectedText As Boolean = CType(Me.ActiveControl, TextBox).SelectionLength
            mnuEditCopy.Enabled = bolSelectedText
            tlbCopy.Enabled = bolSelectedText
            If Not CType(ActiveControl, TextBox).ReadOnly Then
                mnuEditPaste.Enabled = Clipboard.ContainsText
                mnuEditCut.Enabled = bolSelectedText
                tlbPaste.Enabled = Clipboard.ContainsText
                tlbCut.Enabled = bolSelectedText
            Else
                mnuEditPaste.Enabled = False
                mnuEditCut.Enabled = False
                tlbPaste.Enabled = False
                tlbCut.Enabled = False
            End If
        Else
            mnuEditPaste.Enabled = False
            mnuEditCopy.Enabled = False
            mnuEditCut.Enabled = False
            tlbPaste.Enabled = False
            tlbCopy.Enabled = False
            tlbCut.Enabled = False
        End If
        mnuEditSort.Enabled = txtInput.TextLength
        tlbSort.Enabled = txtInput.TextLength
    End Sub
End Class
