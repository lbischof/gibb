<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSofteis
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
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.rdoSmall = New System.Windows.Forms.RadioButton()
        Me.rdoMiddle = New System.Windows.Forms.RadioButton()
        Me.rdoBig = New System.Windows.Forms.RadioButton()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblChangeVal = New System.Windows.Forms.Label()
        Me.lblPaidVal = New System.Windows.Forms.Label()
        Me.lblPriceVal = New System.Windows.Forms.Label()
        Me.lstFlavour = New System.Windows.Forms.ListBox()
        Me.webSofteis = New System.Windows.Forms.WebBrowser()
        Me.btn5Fr = New System.Windows.Forms.Button()
        Me.btn2Fr = New System.Windows.Forms.Button()
        Me.btn1Fr = New System.Windows.Forms.Button()
        Me.btn50rp = New System.Windows.Forms.Button()
        Me.btn20rp = New System.Windows.Forms.Button()
        Me.btn10rp = New System.Windows.Forms.Button()
        Me.grpSize.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSize
        '
        Me.grpSize.Controls.Add(Me.rdoSmall)
        Me.grpSize.Controls.Add(Me.rdoMiddle)
        Me.grpSize.Controls.Add(Me.rdoBig)
        Me.grpSize.Location = New System.Drawing.Point(174, 32)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(113, 100)
        Me.grpSize.TabIndex = 1
        Me.grpSize.TabStop = False
        '
        'rdoSmall
        '
        Me.rdoSmall.AutoSize = True
        Me.rdoSmall.Location = New System.Drawing.Point(7, 68)
        Me.rdoSmall.Name = "rdoSmall"
        Me.rdoSmall.Size = New System.Drawing.Size(48, 17)
        Me.rdoSmall.TabIndex = 2
        Me.rdoSmall.Tag = "1"
        Me.rdoSmall.Text = "Klein"
        Me.rdoSmall.UseVisualStyleBackColor = True
        '
        'rdoMiddle
        '
        Me.rdoMiddle.AutoSize = True
        Me.rdoMiddle.Checked = True
        Me.rdoMiddle.Location = New System.Drawing.Point(7, 44)
        Me.rdoMiddle.Name = "rdoMiddle"
        Me.rdoMiddle.Size = New System.Drawing.Size(50, 17)
        Me.rdoMiddle.TabIndex = 1
        Me.rdoMiddle.TabStop = True
        Me.rdoMiddle.Tag = "2"
        Me.rdoMiddle.Text = "Mittel"
        Me.rdoMiddle.UseVisualStyleBackColor = True
        '
        'rdoBig
        '
        Me.rdoBig.AutoSize = True
        Me.rdoBig.Location = New System.Drawing.Point(7, 20)
        Me.rdoBig.Name = "rdoBig"
        Me.rdoBig.Size = New System.Drawing.Size(52, 17)
        Me.rdoBig.TabIndex = 0
        Me.rdoBig.Tag = "3"
        Me.rdoBig.Text = "Gross"
        Me.rdoBig.UseVisualStyleBackColor = True
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(263, 356)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(92, 13)
        Me.lblSelected.TabIndex = 3
        Me.lblSelected.Text = "Kleines Vanille Eis"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(453, 43)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(30, 13)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.Text = "Preis"
        '
        'lblPaid
        '
        Me.lblPaid.AutoSize = True
        Me.lblPaid.Location = New System.Drawing.Point(441, 76)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(42, 13)
        Me.lblPaid.TabIndex = 5
        Me.lblPaid.Text = "Bezahlt"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Location = New System.Drawing.Point(264, 403)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(39, 13)
        Me.lblChange.TabIndex = 6
        Me.lblChange.Text = "Retour"
        '
        'btnBuy
        '
        Me.btnBuy.Location = New System.Drawing.Point(266, 372)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(75, 23)
        Me.btnBuy.TabIndex = 8
        Me.btnBuy.Text = "Bestellen"
        Me.btnBuy.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(347, 372)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(344, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Bitte wählen Sie maximal 3 Sorten und eine Grösse"
        '
        'lblError
        '
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(264, 328)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(325, 23)
        Me.lblError.TabIndex = 19
        '
        'lblChangeVal
        '
        Me.lblChangeVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChangeVal.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeVal.Location = New System.Drawing.Point(267, 421)
        Me.lblChangeVal.Name = "lblChangeVal"
        Me.lblChangeVal.Size = New System.Drawing.Size(105, 38)
        Me.lblChangeVal.TabIndex = 10
        Me.lblChangeVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPaidVal
        '
        Me.lblPaidVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPaidVal.Location = New System.Drawing.Point(489, 72)
        Me.lblPaidVal.Name = "lblPaidVal"
        Me.lblPaidVal.Size = New System.Drawing.Size(100, 20)
        Me.lblPaidVal.TabIndex = 21
        Me.lblPaidVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPriceVal
        '
        Me.lblPriceVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriceVal.Location = New System.Drawing.Point(489, 39)
        Me.lblPriceVal.Name = "lblPriceVal"
        Me.lblPriceVal.Size = New System.Drawing.Size(100, 20)
        Me.lblPriceVal.TabIndex = 22
        Me.lblPriceVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstFlavour
        '
        Me.lstFlavour.FormattingEnabled = True
        Me.lstFlavour.Location = New System.Drawing.Point(37, 39)
        Me.lstFlavour.Name = "lstFlavour"
        Me.lstFlavour.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstFlavour.Size = New System.Drawing.Size(120, 95)
        Me.lstFlavour.Sorted = True
        Me.lstFlavour.TabIndex = 0
        '
        'webSofteis
        '
        Me.webSofteis.Location = New System.Drawing.Point(8, 150)
        Me.webSofteis.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webSofteis.Name = "webSofteis"
        Me.webSofteis.Size = New System.Drawing.Size(253, 309)
        Me.webSofteis.TabIndex = 7
        Me.webSofteis.Url = New System.Uri("http://www.lorenzz.ch/softeis.svg?nocache=true", System.UriKind.Absolute)
        Me.webSofteis.Visible = False
        '
        'btn5Fr
        '
        Me.btn5Fr.BackgroundImage = Global.Softeis.My.Resources.Resources._5Fr_front
        Me.btn5Fr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn5Fr.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn5Fr.FlatAppearance.BorderSize = 0
        Me.btn5Fr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5Fr.Location = New System.Drawing.Point(279, 144)
        Me.btn5Fr.Name = "btn5Fr"
        Me.btn5Fr.Size = New System.Drawing.Size(89, 87)
        Me.btn5Fr.TabIndex = 2
        Me.btn5Fr.Tag = "5"
        Me.btn5Fr.UseVisualStyleBackColor = True
        '
        'btn2Fr
        '
        Me.btn2Fr.BackgroundImage = Global.Softeis.My.Resources.Resources._2Fr_front
        Me.btn2Fr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn2Fr.FlatAppearance.BorderSize = 0
        Me.btn2Fr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2Fr.Location = New System.Drawing.Point(380, 142)
        Me.btn2Fr.Name = "btn2Fr"
        Me.btn2Fr.Size = New System.Drawing.Size(86, 89)
        Me.btn2Fr.TabIndex = 3
        Me.btn2Fr.Tag = "2"
        Me.btn2Fr.UseVisualStyleBackColor = True
        '
        'btn1Fr
        '
        Me.btn1Fr.BackgroundImage = Global.Softeis.My.Resources.Resources._1Fr_front
        Me.btn1Fr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn1Fr.FlatAppearance.BorderSize = 0
        Me.btn1Fr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1Fr.Location = New System.Drawing.Point(479, 144)
        Me.btn1Fr.Name = "btn1Fr"
        Me.btn1Fr.Size = New System.Drawing.Size(87, 87)
        Me.btn1Fr.TabIndex = 4
        Me.btn1Fr.Tag = "1"
        Me.btn1Fr.UseVisualStyleBackColor = True
        '
        'btn50rp
        '
        Me.btn50rp.BackgroundImage = Global.Softeis.My.Resources.Resources._50Rp_front
        Me.btn50rp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn50rp.FlatAppearance.BorderSize = 0
        Me.btn50rp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50rp.Location = New System.Drawing.Point(279, 237)
        Me.btn50rp.Name = "btn50rp"
        Me.btn50rp.Size = New System.Drawing.Size(89, 88)
        Me.btn50rp.TabIndex = 5
        Me.btn50rp.Tag = ".50"
        Me.btn50rp.UseVisualStyleBackColor = True
        '
        'btn20rp
        '
        Me.btn20rp.BackgroundImage = Global.Softeis.My.Resources.Resources._20Rp_front
        Me.btn20rp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn20rp.FlatAppearance.BorderSize = 0
        Me.btn20rp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn20rp.Location = New System.Drawing.Point(380, 237)
        Me.btn20rp.Name = "btn20rp"
        Me.btn20rp.Size = New System.Drawing.Size(86, 88)
        Me.btn20rp.TabIndex = 6
        Me.btn20rp.Tag = ".20"
        Me.btn20rp.UseVisualStyleBackColor = True
        '
        'btn10rp
        '
        Me.btn10rp.BackgroundImage = Global.Softeis.My.Resources.Resources._10Rp_front
        Me.btn10rp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn10rp.FlatAppearance.BorderSize = 0
        Me.btn10rp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn10rp.Location = New System.Drawing.Point(479, 237)
        Me.btn10rp.Name = "btn10rp"
        Me.btn10rp.Size = New System.Drawing.Size(87, 88)
        Me.btn10rp.TabIndex = 7
        Me.btn10rp.Tag = ".10"
        Me.btn10rp.UseVisualStyleBackColor = True
        '
        'frmSofteis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 484)
        Me.Controls.Add(Me.btn10rp)
        Me.Controls.Add(Me.btn20rp)
        Me.Controls.Add(Me.btn50rp)
        Me.Controls.Add(Me.btn1Fr)
        Me.Controls.Add(Me.btn2Fr)
        Me.Controls.Add(Me.btn5Fr)
        Me.Controls.Add(Me.webSofteis)
        Me.Controls.Add(Me.lstFlavour)
        Me.Controls.Add(Me.lblPriceVal)
        Me.Controls.Add(Me.lblPaidVal)
        Me.Controls.Add(Me.lblChangeVal)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.grpSize)
        Me.Name = "frmSofteis"
        Me.Text = "Softeis Maschine"
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSize As System.Windows.Forms.GroupBox
    Friend WithEvents rdoSmall As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMiddle As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBig As System.Windows.Forms.RadioButton
    Friend WithEvents lblSelected As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblPaid As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents btnBuy As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblChangeVal As System.Windows.Forms.Label
    Friend WithEvents lblPaidVal As System.Windows.Forms.Label
    Friend WithEvents lblPriceVal As System.Windows.Forms.Label
    Friend WithEvents lstFlavour As System.Windows.Forms.ListBox
    Friend WithEvents webSofteis As System.Windows.Forms.WebBrowser
    Friend WithEvents btn5Fr As System.Windows.Forms.Button
    Friend WithEvents btn2Fr As System.Windows.Forms.Button
    Friend WithEvents btn1Fr As System.Windows.Forms.Button
    Friend WithEvents btn50rp As System.Windows.Forms.Button
    Friend WithEvents btn20rp As System.Windows.Forms.Button
    Friend WithEvents btn10rp As System.Windows.Forms.Button

End Class
