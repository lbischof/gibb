Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Forms.ListBox

Public Class frmSofteis
    Dim WithEvents Icecream As New Icecream
    Dim WithEvents svgSofteis As HtmlDocument
    Dim mdecPaid As Decimal

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateFlavours()
        SelectDefaults()
    End Sub

    Private Sub PopulateFlavours()
        For Each flavour As String In Icecream.GetAvailableFlavours
            lstFlavour.Items.Add(flavour)
        Next
    End Sub
   
    Private Sub SelectDefaults()
        rdoMiddle.Select()
        lstFlavour.ClearSelected()
        lstFlavour.SetSelected(0, True)
        Me.ActiveControl = lstFlavour
    End Sub

    Private Sub lstFlavour_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFlavour.SelectedIndexChanged
        Icecream.Flavours = sender
        If sender.selectedItems.count() > Icecream.mintMaxFlavours Then
            EnforceMaximalFlavours()
        End If
    End Sub

    Private Sub EnforceMaximalFlavours()
        lstFlavour.SetSelected(lstFlavour.FindString(Icecream.GetItemOverMax), False)
    End Sub

    Private Sub rdoSize_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoBig.Click, rdoMiddle.Click, rdoSmall.Click
        Icecream.Size = sender
    End Sub

    Private Sub Icecream_Changed() Handles Icecream.Changed
        lblSelected.Text = Icecream.ToString
        lblPriceVal.Text = Icecream.Price
    End Sub

    Private Sub Coin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5Fr.Click, btn2Fr.Click, btn1Fr.Click, btn50rp.Click, btn20rp.Click, btn10rp.Click
        mdecPaid += sender.Tag
        lblPaidVal.Text = Microsoft.VisualBasic.Strings.Format(mdecPaid, "0.00")
        UpdateErrorIfShowing()
    End Sub

    Private Sub btnBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuy.Click
        If Not lstFlavour.SelectedItems.Count > 3 And mdecPaid >= Icecream.Price Then
            ' Pay the icecream.
            mdecPaid -= Icecream.Price
            GiveChange()
            ShowIcecream()
            SetControlsEnabled(False)
        ElseIf Not mdecPaid >= Icecream.Price Then
            ShowError()
        End If
    End Sub

    Private Sub SetControlsEnabled(ByVal blnEnabled As Boolean)
        Dim objControls As Object() = {lstFlavour, grpSize, btnBuy, btnReset, btn10rp, btn20rp, btn50rp, btn1Fr, btn2Fr, btn5Fr}
        For Each objControl As Object In objControls
            objControl.Enabled = blnEnabled
        Next
    End Sub

    Private Sub lblChangeVal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblChangeVal.Click
        lblChangeVal.Text = String.Empty
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        GiveChange()
        SelectDefaults()
    End Sub

    Private Sub GiveChange()
        lblChangeVal.Text = Strings.Format(Val(lblChangeVal.Text) + mdecPaid, "0.00")
        ' Since we gave out all the change we can now reset the paid cash.
        lblPaidVal.Text = String.Empty
        mdecPaid = 0
    End Sub

    Private Sub ShowIcecream()
        Dim eleCustomCss As HtmlElement = svgSofteis.GetElementById("CustomCss")
        eleCustomCss.InnerHtml = "<style>" & Icecream.GetStyle & "</style>"
        webSofteis.Visible = True
    End Sub

    Private Sub HideIcecream()
        webSofteis.Visible = False
        HideError()
    End Sub

    Private Sub ShowError(Optional ByVal strMessage As String = "")
        If (strMessage IsNot String.Empty) Then
            lblError.Text = strMessage
        Else
            lblError.Text = "Es fehlen noch CHF" & Strings.Format(Icecream.Price - mdecPaid, "0.00")
        End If
    End Sub

    Private Sub UpdateErrorIfShowing()
        If lblError.Text.Length > 0 And mdecPaid < Icecream.Price Then
            ShowError()
        Else
            HideError()
        End If
    End Sub

    Private Sub HideError()
        lblError.Text = String.Empty
    End Sub

    Private Sub frmSofteis_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        If webSofteis.Visible Then
            ShowError("Bitte entnehmen Sie ihr Eis")
        End If
    End Sub

    Private Sub svgSofteis_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.HtmlElementEventArgs) Handles svgSofteis.Click
        HideIcecream()
        SelectDefaults()
        SetControlsEnabled(True)
    End Sub

    Private Sub webSofteis_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles webSofteis.DocumentCompleted
        svgSofteis = webSofteis.Document
    End Sub
End Class

Public Class Icecream
    Public Const mintMaxFlavours As Integer = 3
    Private mlstSelectedFlavours As New List(Of String)
    Private mstrSize As String
    Private mdblPrice As Double
    Private mdicFlavours As New Dictionary(Of String, String) From {
        {"Schokolade", "#7B3F00"},
        {"Vanille", "#F3E5AB"},
        {"Mokka", "#9d7651"},
        {"Heidelbeere", "#4F86F7"},
        {"Mango", "#DC8700"},
        {"Pistazie", "#93c572"},
        {"Kirsche", "#DE3163"}
    }
    Private mdicSizes As New Dictionary(Of String, Integer) From {
        {"Klein", 60},
        {"Mittel", 80},
        {"Gross", 100}
    }
    Public Event Changed()

    WriteOnly Property Flavours() As Object
        Set(ByVal sender As Object)
            OrderSelectedFlavoursChronologicaly(sender.selectedItems)
            RaiseEvent Changed()
        End Set
    End Property

    WriteOnly Property Size() As Object
        Set(ByVal sender As Object)
            mstrSize = sender.Text
            mdblPrice = sender.Tag
            RaiseEvent Changed()
        End Set
    End Property

    Public Function GetStyle() As String
        Dim css As String = ""
        css = "svg { height: " & mdicSizes.Item(mstrSize) & "% }"
        Dim intIndex As Integer
        For Each strFlavour As String In mlstSelectedFlavours
            intIndex += 1
            css &= ".topping" & intIndex & " { fill: " & mdicFlavours.Item(strFlavour) & " }"
        Next
        Return css
    End Function

    Public Function GetAvailableFlavours() As String()
        Return mdicFlavours.Keys.ToArray
    End Function

    Public Function GetItemOverMax() As String
        Return mlstSelectedFlavours.Item(mintMaxFlavours)
    End Function

    ReadOnly Property Price() As Double
        Get
            Return mdblPrice
        End Get
    End Property

    Public Overrides Function ToString() As String
        Dim strSelected As String
        Dim seperator As String = ", "
        If mstrSize = "Mittel" Then
            strSelected = "Mittelgrosses Eis"
        Else
            strSelected = mstrSize & "es Eis"
        End If
        If mlstSelectedFlavours.Count > 0 Then
            strSelected &= " mit " & String.Join(", ", mlstSelectedFlavours)
            Dim intLastCommaIndex As Integer = strSelected.LastIndexOf(",")
            If intLastCommaIndex > 0 Then
                strSelected = strSelected.Remove(intLastCommaIndex, 1).Insert(intLastCommaIndex, " und")
            End If
        End If
        Return strSelected
    End Function

    ' stackoverflow.com/a/26491395/938541 Thanks Plutonix. 
    Private Sub OrderSelectedFlavoursChronologicaly(ByVal colSelectedItems As SelectedObjectCollection)
        ' add missing ones at the bottom
        For Each n As String In colSelectedItems
            If Not mlstSelectedFlavours.Contains(n) Then
                mlstSelectedFlavours.Add(n)
            End If
        Next

        ' remove old ones
        For n As Integer = mlstSelectedFlavours.Count - 1 To 0 Step -1
            If Not colSelectedItems.Contains(mlstSelectedFlavours(n)) Then
                mlstSelectedFlavours.Remove(mlstSelectedFlavours(n))
            End If
        Next
    End Sub
End Class

