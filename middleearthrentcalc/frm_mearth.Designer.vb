<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mearth
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ApartmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeaturedSingleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FeaturedOneBedroomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Featured2BedroomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblSubHeading = New System.Windows.Forms.Label()
        Me.lblBaseRent = New System.Windows.Forms.Label()
        Me.txtBaseRent = New System.Windows.Forms.TextBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.grpBedrooms = New System.Windows.Forms.GroupBox()
        Me.rdoTwoBed = New System.Windows.Forms.RadioButton()
        Me.rdoOneBedDen = New System.Windows.Forms.RadioButton()
        Me.rdoOneBed = New System.Windows.Forms.RadioButton()
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.grpView = New System.Windows.Forms.GroupBox()
        Me.rdoCreek = New System.Windows.Forms.RadioButton()
        Me.rdoMountain = New System.Windows.Forms.RadioButton()
        Me.rdoCourt = New System.Windows.Forms.RadioButton()
        Me.rdoStables = New System.Windows.Forms.RadioButton()
        Me.GrpPets = New System.Windows.Forms.GroupBox()
        Me.rdoSmall = New System.Windows.Forms.RadioButton()
        Me.rdoConeys = New System.Windows.Forms.RadioButton()
        Me.rdoHorse = New System.Windows.Forms.RadioButton()
        Me.grpBathrooms = New System.Windows.Forms.GroupBox()
        Me.rdoBathTwo = New System.Windows.Forms.RadioButton()
        Me.rdoBathHalf = New System.Windows.Forms.RadioButton()
        Me.rdoBathOne = New System.Windows.Forms.RadioButton()
        Me.chkFireplace = New System.Windows.Forms.CheckBox()
        Me.chkNonSmoke = New System.Windows.Forms.CheckBox()
        Me.chkExtraStable = New System.Windows.Forms.CheckBox()
        Me.chkStorage = New System.Windows.Forms.CheckBox()
        Me.chkAgentSauron = New System.Windows.Forms.CheckBox()
        Me.lblRentBoxHeader = New System.Windows.Forms.Label()
        Me.lblDepositBoxHeader = New System.Windows.Forms.Label()
        Me.lblRentTot = New System.Windows.Forms.Label()
        Me.lblDepositTot = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.grpBedrooms.SuspendLayout()
        Me.grpView.SuspendLayout()
        Me.GrpPets.SuspendLayout()
        Me.grpBathrooms.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApartmentsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(645, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ApartmentsToolStripMenuItem
        '
        Me.ApartmentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FeaturedSingleToolStripMenuItem, Me.ToolStripSeparator1, Me.FeaturedOneBedroomToolStripMenuItem, Me.ToolStripSeparator2, Me.Featured2BedroomToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.ApartmentsToolStripMenuItem.Name = "ApartmentsToolStripMenuItem"
        Me.ApartmentsToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ApartmentsToolStripMenuItem.Text = "Apa&rtments"
        '
        'FeaturedSingleToolStripMenuItem
        '
        Me.FeaturedSingleToolStripMenuItem.Name = "FeaturedSingleToolStripMenuItem"
        Me.FeaturedSingleToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.FeaturedSingleToolStripMenuItem.Text = "Featured &Single"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(180, 6)
        '
        'FeaturedOneBedroomToolStripMenuItem
        '
        Me.FeaturedOneBedroomToolStripMenuItem.Name = "FeaturedOneBedroomToolStripMenuItem"
        Me.FeaturedOneBedroomToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.FeaturedOneBedroomToolStripMenuItem.Text = "Featured &1-Bedroom"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(180, 6)
        '
        'Featured2BedroomToolStripMenuItem
        '
        Me.Featured2BedroomToolStripMenuItem.Name = "Featured2BedroomToolStripMenuItem"
        Me.Featured2BedroomToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.Featured2BedroomToolStripMenuItem.Text = "Featured &2-Bedroom"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(180, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Sitka Small", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(139, 20)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(385, 40)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Middle Earth Apartments"
        '
        'lblSubHeading
        '
        Me.lblSubHeading.AutoSize = True
        Me.lblSubHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubHeading.Location = New System.Drawing.Point(232, 64)
        Me.lblSubHeading.Name = "lblSubHeading"
        Me.lblSubHeading.Size = New System.Drawing.Size(190, 16)
        Me.lblSubHeading.TabIndex = 2
        Me.lblSubHeading.Text = "One Landlord to Rule Them All"
        '
        'lblBaseRent
        '
        Me.lblBaseRent.AutoSize = True
        Me.lblBaseRent.Location = New System.Drawing.Point(14, 91)
        Me.lblBaseRent.Name = "lblBaseRent"
        Me.lblBaseRent.Size = New System.Drawing.Size(57, 13)
        Me.lblBaseRent.TabIndex = 3
        Me.lblBaseRent.Text = "&Base Rent"
        '
        'txtBaseRent
        '
        Me.txtBaseRent.Location = New System.Drawing.Point(78, 88)
        Me.txtBaseRent.Name = "txtBaseRent"
        Me.txtBaseRent.Size = New System.Drawing.Size(91, 20)
        Me.txtBaseRent.TabIndex = 4
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(325, 122)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(48, 13)
        Me.lblArea.TabIndex = 5
        Me.lblArea.Text = "&Location"
        '
        'cboArea
        '
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Items.AddRange(New Object() {"The Shire", "Rivendell", "Mordor"})
        Me.cboArea.Location = New System.Drawing.Point(328, 142)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(121, 21)
        Me.cboArea.TabIndex = 6
        '
        'grpBedrooms
        '
        Me.grpBedrooms.Controls.Add(Me.rdoTwoBed)
        Me.grpBedrooms.Controls.Add(Me.rdoOneBedDen)
        Me.grpBedrooms.Controls.Add(Me.rdoOneBed)
        Me.grpBedrooms.Controls.Add(Me.rdoSingle)
        Me.grpBedrooms.Location = New System.Drawing.Point(17, 122)
        Me.grpBedrooms.Name = "grpBedrooms"
        Me.grpBedrooms.Size = New System.Drawing.Size(152, 114)
        Me.grpBedrooms.TabIndex = 7
        Me.grpBedrooms.TabStop = False
        Me.grpBedrooms.Text = "Bedrooms"
        '
        'rdoTwoBed
        '
        Me.rdoTwoBed.AutoSize = True
        Me.rdoTwoBed.Location = New System.Drawing.Point(7, 89)
        Me.rdoTwoBed.Name = "rdoTwoBed"
        Me.rdoTwoBed.Size = New System.Drawing.Size(91, 17)
        Me.rdoTwoBed.TabIndex = 3
        Me.rdoTwoBed.TabStop = True
        Me.rdoTwoBed.Text = "Two Bedroom"
        Me.rdoTwoBed.UseVisualStyleBackColor = True
        '
        'rdoOneBedDen
        '
        Me.rdoOneBedDen.AutoSize = True
        Me.rdoOneBedDen.Location = New System.Drawing.Point(7, 66)
        Me.rdoOneBedDen.Name = "rdoOneBedDen"
        Me.rdoOneBedDen.Size = New System.Drawing.Size(134, 17)
        Me.rdoOneBedDen.TabIndex = 2
        Me.rdoOneBedDen.TabStop = True
        Me.rdoOneBedDen.Text = "One Bedroom and Den"
        Me.rdoOneBedDen.UseVisualStyleBackColor = True
        '
        'rdoOneBed
        '
        Me.rdoOneBed.AutoSize = True
        Me.rdoOneBed.Location = New System.Drawing.Point(7, 43)
        Me.rdoOneBed.Name = "rdoOneBed"
        Me.rdoOneBed.Size = New System.Drawing.Size(90, 17)
        Me.rdoOneBed.TabIndex = 1
        Me.rdoOneBed.TabStop = True
        Me.rdoOneBed.Text = "One Bedroom"
        Me.rdoOneBed.UseVisualStyleBackColor = True
        '
        'rdoSingle
        '
        Me.rdoSingle.AutoSize = True
        Me.rdoSingle.Location = New System.Drawing.Point(7, 20)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(54, 17)
        Me.rdoSingle.TabIndex = 0
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.Text = "Single"
        Me.rdoSingle.UseVisualStyleBackColor = True
        '
        'grpView
        '
        Me.grpView.Controls.Add(Me.rdoCreek)
        Me.grpView.Controls.Add(Me.rdoMountain)
        Me.grpView.Controls.Add(Me.rdoCourt)
        Me.grpView.Controls.Add(Me.rdoStables)
        Me.grpView.Location = New System.Drawing.Point(175, 122)
        Me.grpView.Name = "grpView"
        Me.grpView.Size = New System.Drawing.Size(142, 114)
        Me.grpView.TabIndex = 8
        Me.grpView.TabStop = False
        Me.grpView.Text = "View"
        '
        'rdoCreek
        '
        Me.rdoCreek.AutoSize = True
        Me.rdoCreek.Location = New System.Drawing.Point(6, 88)
        Me.rdoCreek.Name = "rdoCreek"
        Me.rdoCreek.Size = New System.Drawing.Size(106, 17)
        Me.rdoCreek.TabIndex = 3
        Me.rdoCreek.Text = "Creek / Waterfall"
        Me.rdoCreek.UseVisualStyleBackColor = True
        '
        'rdoMountain
        '
        Me.rdoMountain.AutoSize = True
        Me.rdoMountain.Location = New System.Drawing.Point(6, 65)
        Me.rdoMountain.Name = "rdoMountain"
        Me.rdoMountain.Size = New System.Drawing.Size(106, 17)
        Me.rdoMountain.TabIndex = 2
        Me.rdoMountain.Text = "Mountain Foliage"
        Me.rdoMountain.UseVisualStyleBackColor = True
        '
        'rdoCourt
        '
        Me.rdoCourt.AutoSize = True
        Me.rdoCourt.Checked = True
        Me.rdoCourt.Location = New System.Drawing.Point(6, 42)
        Me.rdoCourt.Name = "rdoCourt"
        Me.rdoCourt.Size = New System.Drawing.Size(70, 17)
        Me.rdoCourt.TabIndex = 1
        Me.rdoCourt.TabStop = True
        Me.rdoCourt.Text = "Courtyard"
        Me.rdoCourt.UseVisualStyleBackColor = True
        '
        'rdoStables
        '
        Me.rdoStables.AutoSize = True
        Me.rdoStables.Location = New System.Drawing.Point(6, 19)
        Me.rdoStables.Name = "rdoStables"
        Me.rdoStables.Size = New System.Drawing.Size(60, 17)
        Me.rdoStables.TabIndex = 0
        Me.rdoStables.Text = "Stables"
        Me.rdoStables.UseVisualStyleBackColor = True
        '
        'GrpPets
        '
        Me.GrpPets.Controls.Add(Me.rdoSmall)
        Me.GrpPets.Controls.Add(Me.rdoConeys)
        Me.GrpPets.Controls.Add(Me.rdoHorse)
        Me.GrpPets.Location = New System.Drawing.Point(328, 250)
        Me.GrpPets.Name = "GrpPets"
        Me.GrpPets.Size = New System.Drawing.Size(156, 114)
        Me.GrpPets.TabIndex = 9
        Me.GrpPets.TabStop = False
        Me.GrpPets.Text = "Pets"
        '
        'rdoSmall
        '
        Me.rdoSmall.AutoSize = True
        Me.rdoSmall.Location = New System.Drawing.Point(6, 89)
        Me.rdoSmall.Name = "rdoSmall"
        Me.rdoSmall.Size = New System.Drawing.Size(120, 17)
        Me.rdoSmall.TabIndex = 2
        Me.rdoSmall.Text = "Other Small or None"
        Me.rdoSmall.UseVisualStyleBackColor = True
        '
        'rdoConeys
        '
        Me.rdoConeys.AutoSize = True
        Me.rdoConeys.Location = New System.Drawing.Point(6, 54)
        Me.rdoConeys.Name = "rdoConeys"
        Me.rdoConeys.Size = New System.Drawing.Size(60, 17)
        Me.rdoConeys.TabIndex = 1
        Me.rdoConeys.Text = "Coneys"
        Me.rdoConeys.UseVisualStyleBackColor = True
        '
        'rdoHorse
        '
        Me.rdoHorse.AutoSize = True
        Me.rdoHorse.Location = New System.Drawing.Point(6, 19)
        Me.rdoHorse.Name = "rdoHorse"
        Me.rdoHorse.Size = New System.Drawing.Size(53, 17)
        Me.rdoHorse.TabIndex = 0
        Me.rdoHorse.Text = "Horse"
        Me.rdoHorse.UseVisualStyleBackColor = True
        '
        'grpBathrooms
        '
        Me.grpBathrooms.Controls.Add(Me.rdoBathTwo)
        Me.grpBathrooms.Controls.Add(Me.rdoBathHalf)
        Me.grpBathrooms.Controls.Add(Me.rdoBathOne)
        Me.grpBathrooms.Location = New System.Drawing.Point(17, 251)
        Me.grpBathrooms.Name = "grpBathrooms"
        Me.grpBathrooms.Size = New System.Drawing.Size(152, 100)
        Me.grpBathrooms.TabIndex = 10
        Me.grpBathrooms.TabStop = False
        Me.grpBathrooms.Text = "Bathrooms"
        '
        'rdoBathTwo
        '
        Me.rdoBathTwo.AutoSize = True
        Me.rdoBathTwo.Location = New System.Drawing.Point(6, 71)
        Me.rdoBathTwo.Name = "rdoBathTwo"
        Me.rdoBathTwo.Size = New System.Drawing.Size(65, 17)
        Me.rdoBathTwo.TabIndex = 2
        Me.rdoBathTwo.TabStop = True
        Me.rdoBathTwo.Text = "Two Full"
        Me.rdoBathTwo.UseVisualStyleBackColor = True
        '
        'rdoBathHalf
        '
        Me.rdoBathHalf.AutoSize = True
        Me.rdoBathHalf.Location = New System.Drawing.Point(6, 45)
        Me.rdoBathHalf.Name = "rdoBathHalf"
        Me.rdoBathHalf.Size = New System.Drawing.Size(97, 17)
        Me.rdoBathHalf.TabIndex = 1
        Me.rdoBathHalf.TabStop = True
        Me.rdoBathHalf.Text = "One and a Half"
        Me.rdoBathHalf.UseVisualStyleBackColor = True
        '
        'rdoBathOne
        '
        Me.rdoBathOne.AutoSize = True
        Me.rdoBathOne.Location = New System.Drawing.Point(6, 19)
        Me.rdoBathOne.Name = "rdoBathOne"
        Me.rdoBathOne.Size = New System.Drawing.Size(64, 17)
        Me.rdoBathOne.TabIndex = 0
        Me.rdoBathOne.TabStop = True
        Me.rdoBathOne.Text = "One Full"
        Me.rdoBathOne.UseVisualStyleBackColor = True
        '
        'chkFireplace
        '
        Me.chkFireplace.AutoSize = True
        Me.chkFireplace.Checked = True
        Me.chkFireplace.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFireplace.Location = New System.Drawing.Point(175, 251)
        Me.chkFireplace.Name = "chkFireplace"
        Me.chkFireplace.Size = New System.Drawing.Size(69, 17)
        Me.chkFireplace.TabIndex = 11
        Me.chkFireplace.Text = "Fireplace"
        Me.chkFireplace.UseVisualStyleBackColor = True
        '
        'chkNonSmoke
        '
        Me.chkNonSmoke.AutoSize = True
        Me.chkNonSmoke.Location = New System.Drawing.Point(175, 275)
        Me.chkNonSmoke.Name = "chkNonSmoke"
        Me.chkNonSmoke.Size = New System.Drawing.Size(140, 17)
        Me.chkNonSmoke.TabIndex = 12
        Me.chkNonSmoke.Text = "Non pipe weed smoking"
        Me.chkNonSmoke.UseVisualStyleBackColor = True
        '
        'chkExtraStable
        '
        Me.chkExtraStable.AutoSize = True
        Me.chkExtraStable.Location = New System.Drawing.Point(175, 299)
        Me.chkExtraStable.Name = "chkExtraStable"
        Me.chkExtraStable.Size = New System.Drawing.Size(117, 17)
        Me.chkExtraStable.TabIndex = 13
        Me.chkExtraStable.Text = "Extra Stable Space"
        Me.chkExtraStable.UseVisualStyleBackColor = True
        '
        'chkStorage
        '
        Me.chkStorage.AutoSize = True
        Me.chkStorage.Location = New System.Drawing.Point(175, 323)
        Me.chkStorage.Name = "chkStorage"
        Me.chkStorage.Size = New System.Drawing.Size(98, 17)
        Me.chkStorage.TabIndex = 14
        Me.chkStorage.Text = "Storage Facility"
        Me.chkStorage.UseVisualStyleBackColor = True
        '
        'chkAgentSauron
        '
        Me.chkAgentSauron.AutoSize = True
        Me.chkAgentSauron.Location = New System.Drawing.Point(175, 347)
        Me.chkAgentSauron.Name = "chkAgentSauron"
        Me.chkAgentSauron.Size = New System.Drawing.Size(144, 17)
        Me.chkAgentSauron.TabIndex = 15
        Me.chkAgentSauron.Text = "Possible agent of Sauron"
        Me.chkAgentSauron.UseVisualStyleBackColor = True
        '
        'lblRentBoxHeader
        '
        Me.lblRentBoxHeader.AutoSize = True
        Me.lblRentBoxHeader.Font = New System.Drawing.Font("Sitka Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentBoxHeader.Location = New System.Drawing.Point(516, 146)
        Me.lblRentBoxHeader.Name = "lblRentBoxHeader"
        Me.lblRentBoxHeader.Size = New System.Drawing.Size(83, 35)
        Me.lblRentBoxHeader.TabIndex = 16
        Me.lblRentBoxHeader.Text = "RENT"
        '
        'lblDepositBoxHeader
        '
        Me.lblDepositBoxHeader.AutoSize = True
        Me.lblDepositBoxHeader.Font = New System.Drawing.Font("Sitka Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepositBoxHeader.Location = New System.Drawing.Point(499, 241)
        Me.lblDepositBoxHeader.Name = "lblDepositBoxHeader"
        Me.lblDepositBoxHeader.Size = New System.Drawing.Size(121, 35)
        Me.lblDepositBoxHeader.TabIndex = 18
        Me.lblDepositBoxHeader.Text = "DEPOSIT"
        '
        'lblRentTot
        '
        Me.lblRentTot.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblRentTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRentTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentTot.Location = New System.Drawing.Point(497, 181)
        Me.lblRentTot.Name = "lblRentTot"
        Me.lblRentTot.Size = New System.Drawing.Size(126, 37)
        Me.lblRentTot.TabIndex = 17
        Me.lblRentTot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDepositTot
        '
        Me.lblDepositTot.BackColor = System.Drawing.Color.Gold
        Me.lblDepositTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDepositTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepositTot.Location = New System.Drawing.Point(497, 276)
        Me.lblDepositTot.Name = "lblDepositTot"
        Me.lblDepositTot.Size = New System.Drawing.Size(126, 37)
        Me.lblDepositTot.TabIndex = 19
        Me.lblDepositTot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(186, 401)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 37)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(334, 401)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(106, 37)
        Me.btnCalc.TabIndex = 21
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'frm_mearth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 450)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblDepositTot)
        Me.Controls.Add(Me.lblRentTot)
        Me.Controls.Add(Me.lblDepositBoxHeader)
        Me.Controls.Add(Me.lblRentBoxHeader)
        Me.Controls.Add(Me.chkAgentSauron)
        Me.Controls.Add(Me.chkStorage)
        Me.Controls.Add(Me.chkExtraStable)
        Me.Controls.Add(Me.chkNonSmoke)
        Me.Controls.Add(Me.chkFireplace)
        Me.Controls.Add(Me.grpBathrooms)
        Me.Controls.Add(Me.GrpPets)
        Me.Controls.Add(Me.grpView)
        Me.Controls.Add(Me.grpBedrooms)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.txtBaseRent)
        Me.Controls.Add(Me.lblBaseRent)
        Me.Controls.Add(Me.lblSubHeading)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_mearth"
        Me.Text = "Middle Earth Rental Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpBedrooms.ResumeLayout(False)
        Me.grpBedrooms.PerformLayout()
        Me.grpView.ResumeLayout(False)
        Me.grpView.PerformLayout()
        Me.GrpPets.ResumeLayout(False)
        Me.GrpPets.PerformLayout()
        Me.grpBathrooms.ResumeLayout(False)
        Me.grpBathrooms.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ApartmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSubHeading As Label
    Friend WithEvents lblBaseRent As Label
    Friend WithEvents txtBaseRent As TextBox
    Friend WithEvents lblArea As Label
    Friend WithEvents cboArea As ComboBox
    Friend WithEvents grpBedrooms As GroupBox
    Friend WithEvents grpView As GroupBox
    Friend WithEvents GrpPets As GroupBox
    Friend WithEvents grpBathrooms As GroupBox
    Friend WithEvents chkFireplace As CheckBox
    Friend WithEvents chkNonSmoke As CheckBox
    Friend WithEvents chkExtraStable As CheckBox
    Friend WithEvents chkStorage As CheckBox
    Friend WithEvents chkAgentSauron As CheckBox
    Friend WithEvents lblRentBoxHeader As Label
    Friend WithEvents lblDepositBoxHeader As Label
    Friend WithEvents lblRentTot As Label
    Friend WithEvents lblDepositTot As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents rdoOneBedDen As RadioButton
    Friend WithEvents rdoOneBed As RadioButton
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents rdoTwoBed As RadioButton
    Friend WithEvents rdoCreek As RadioButton
    Friend WithEvents rdoMountain As RadioButton
    Friend WithEvents rdoCourt As RadioButton
    Friend WithEvents rdoStables As RadioButton
    Friend WithEvents rdoSmall As RadioButton
    Friend WithEvents rdoConeys As RadioButton
    Friend WithEvents rdoHorse As RadioButton
    Friend WithEvents rdoBathTwo As RadioButton
    Friend WithEvents rdoBathHalf As RadioButton
    Friend WithEvents rdoBathOne As RadioButton
    Friend WithEvents FeaturedSingleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeaturedOneBedroomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Featured2BedroomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
End Class
