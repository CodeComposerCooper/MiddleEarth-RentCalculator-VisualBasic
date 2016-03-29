' Middle Earth Rental Calculator - V2.00
' By Alistair Cooper

Public Class frm_mearth

    ' Define Constants
    Const minBaseRent = 500       ' Minimum base rent
    Const baseRent = 500          ' Initial base rent to display
    Const stablesDiscount = 10    ' Discount for a horse stables view
    Const mountainPremium = 62    ' Premium for mountain foliage view
    Const creekPremium = 101      ' Premium for creek view
    Const fireplaceDiscount = 15  ' Discount for room without fireplace
    Const nonSmokePremium = 10    ' Premium for non pipe weed smoking room
    Const storagePremium = 90     ' Premium for extra storage
    Const storageDeposit = 42     ' Extra deposit amount for extra storage
    Const stablePremium = 35      ' Premium for extra stable space
    Const horseDeposit = 72       ' Extra deposit for having horse
    Const coneysDeposit = 125     ' Extra deposit for having coneys

    ' Define Variables 
    Dim extraStable As Boolean    ' Does USER select extra stable
    Dim rentTotal As Integer      ' Standard rent total
    Dim depositTotal As Integer   ' Deposit total

    Private Sub frm_mearth_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtBaseRent.Text = minBaseRent   ' Sets the min base rent to the input text box
        cboArea.SelectedIndex = 0        ' Sets value of Area combo box when program opens to The Shire'
        rdoOneBed.Checked = True         ' Defaults the Room selection to one bed
        rdoCourt.Checked = True          ' Defaults the view selection to courtyard
        rdoSmall.Checked = True          ' Defaults the Pet selection to none/small

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        If Not IsNumeric(txtBaseRent.Text) Then
            MessageBox.Show("Base rent must be a number", "Input Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
            txtBaseRent.Focus()
            txtBaseRent.Clear()

            ' Display error messages in output fields
            lblRentTot.Text = "ERROR"
            lblDepositTot.Text = "ERROR"

        ElseIf txtBaseRent.Text < 500 Then
            MessageBox.Show("Base rent must be 500 or higher", "Input Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
            txtBaseRent.Focus()
            txtBaseRent.Clear()

            ' Display error messages in output fields
            lblRentTot.Text = "ERROR"
            lblDepositTot.Text = "ERROR"

        Else
            rentTotal = txtBaseRent.Text     ' Initialize rentTotal with text input

            calcBedrooms()
            calcViews()
            calcOptions()
            calcArea()
            checkParking()

            depositTotal = rentTotal         ' Initialize base deposit value to total rent value 

            calcDeposit()

            ' Display values
            lblRentTot.Text = FormatCurrency(rentTotal, 0)          ' rent total displayed as dollars
            lblDepositTot.Text = FormatCurrency(depositTotal, 0)    ' deposit total displayed as dollars

        End If

    End Sub

    Private Sub calcBedrooms()

        If rdoOneBed.Checked = True Then
            rentTotal += 200            ' If One bedroom is selected 

        ElseIf rdoOneBedDen.Checked Then
            rentTotal += 325            ' If One bedroom with den is selected 

        ElseIf rdoTwoBed.Checked = True And rdoBathTwo.Checked = False Then
            rentTotal += 400            ' If Two bedroom is selected

        ElseIf rdoTwoBed.Checked = True And rdoBathTwo.Checked = True Then
            rentTotal += 435            ' If Two bedroom and two baths is selected

        End If

        If rdoBathHalf.Checked = True And rdoTwoBed.Checked = False Then
            rentTotal += 50               ' If one and a half baths AND it isn't the Two bedroom)

        End If

    End Sub

    Private Sub calcViews()

        If rdoStables.Checked = True Then
            rentTotal -= stablesDiscount   ' Subtract discount for horse stables view
        End If

        If rdoMountain.Checked = True Then
            rentTotal += mountainPremium   ' Adds premium for mountain view
        End If

        If rdoCreek.Checked = True Then
            rentTotal += creekPremium      ' Adds premium for creek view
        End If

    End Sub

    Private Sub calcOptions()

        If chkFireplace.Checked = False Then
            rentTotal -= fireplaceDiscount        ' If fireplace unchecked give discount
        End If

        If chkNonSmoke.Checked = True Then
            rentTotal += nonSmokePremium          ' If non smoking add premium
        End If

        If chkExtraStable.Checked = True Then
            extraStable = True                    ' Variable for extra stable true
        End If

        If chkStorage.Checked = True Then
            rentTotal += storagePremium           ' If extra storage checked add premium
        End If

    End Sub

    Private Sub calcArea()

        If cboArea.Text = "Rivendell" Then
            rentTotal *= 1.4           ' Increase rent by 40%
        End If

        If cboArea.Text = "Mordor" Then
            rentTotal *= 1.1           ' Increase rent by 10%
        End If

    End Sub

    Private Sub checkParking()

        ' Check if extra parking box checked and update variable
        If chkExtraStable.Checked = True Then
            extraStable = True
        Else
            extraStable = False
        End If

        If extraStable = True Then
            rentTotal += stablePremium
        End If

    End Sub

    Private Sub calcDeposit()

        If rdoHorse.Checked = True Then
            depositTotal += horseDeposit           ' Adds horse extra deposit 
        End If

        If rdoConeys.Checked = True Then
            depositTotal += coneysDeposit          ' Adds cat extra deposit
        End If

        If chkStorage.Checked = True Then
            depositTotal += storageDeposit         ' Adds storage deposit
        End If

        If chkAgentSauron.Checked = True Then
            depositTotal *= 2                      ' If possible agent of Sauron multiply deposit by 2
        End If

    End Sub

    Private Sub rdoSingle_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSingle.CheckedChanged

        rdoBathOne.Checked = True     ' Default checks box for one bathroom
        rdoBathOne.Enabled = True     ' Enable one bath
        rdoBathHalf.Enabled = False   ' Disable one and a half bath
        rdoBathTwo.Enabled = False    ' Disable two baths 

    End Sub

    Private Sub rdoOneBed_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOneBed.CheckedChanged

        rdoBathOne.Checked = True     ' Default checks box for one bathroom
        rdoBathOne.Enabled = True     ' Enable one bath
        rdoBathHalf.Enabled = True    ' Enable one and a half bath
        rdoBathTwo.Enabled = False    ' Disable two baths 

    End Sub

    Private Sub rdoOneBedDen_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOneBedDen.CheckedChanged

        rdoBathOne.Checked = True     ' Default checks box for one bathroom
        rdoBathOne.Enabled = True     ' Enable one bath
        rdoBathHalf.Enabled = True    ' Enable one and a half bath
        rdoBathTwo.Enabled = False    ' Disable two baths 

    End Sub

    Private Sub rdoTwoBed_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTwoBed.CheckedChanged

        rdoBathHalf.Checked = True    ' Default checks box for one half bathroom
        rdoBathOne.Enabled = False    ' Disable one bath
        rdoBathHalf.Enabled = True    ' Enable one and a half bath
        rdoBathTwo.Enabled = True     ' Enable two baths

    End Sub

    Private Sub cboArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArea.SelectedIndexChanged

        If cboArea.SelectedIndex = 0 Then
            rdoMountain.Enabled = True         ' Mountain view is enabled
        End If

        If cboArea.SelectedIndex = 1 Then
            rdoMountain.Enabled = True         ' Mountain view is enabled
        End If

        If cboArea.SelectedIndex = 2 Then

            If rdoMountain.Checked = True Then
                rdoStables.Checked = True       ' If mountain view is already selected view changes to stables
            End If

            rdoMountain.Enabled = False         ' Mordor is selected and mountain view is disabled
        End If

    End Sub

    Private Sub FeaturedSingleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeaturedSingleToolStripMenuItem.Click

        rdoSingle.Checked = True          ' Room single checked
        cboArea.SelectedIndex = 0         ' Northern Lights checked
        rdoBathOne.Checked = True         ' One bath checked
        rdoStables.Checked = True         ' Stables view checked
        rdoSmall.Checked = True           ' No pets checked
        chkFireplace.Checked = True       ' Fireplace checked
        chkAgentSauron.Checked = False    ' Agent Sauron not checked
        chkExtraStable.Checked = False    ' Extra parking not checked
        chkNonSmoke.Checked = False       ' Non smoking not checked
        chkStorage.Checked = False        ' Extra storage not checked

    End Sub

    Private Sub FeaturedOneBedroomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeaturedOneBedroomToolStripMenuItem.Click

        rdoOneBed.Checked = True          ' Room one bed checked
        cboArea.SelectedIndex = 0         ' Northern Lights checked
        rdoBathOne.Checked = True         ' One bath checked
        rdoStables.Checked = True         ' Stables view checked
        rdoSmall.Checked = True           ' No pets checked
        chkFireplace.Checked = True       ' Fireplace checked
        chkAgentSauron.Checked = False    ' Agent Sauron not checked
        chkExtraStable.Checked = False    ' Extra stable not checked
        chkNonSmoke.Checked = False       ' Non smoking not checked
        chkStorage.Checked = False        ' Extra storage not checked

    End Sub

    Private Sub Featured2BedroomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Featured2BedroomToolStripMenuItem.Click

        rdoTwoBed.Checked = True          ' Room two bed checked
        cboArea.SelectedIndex = 0         ' Northern Lights checked
        rdoBathHalf.Checked = True        ' One and a half bath checked
        rdoStables.Checked = True         ' Stables view checked
        rdoSmall.Checked = True           ' No pets checked
        chkFireplace.Checked = True       ' Fireplace checked
        chkAgentSauron.Checked = False    ' Agent Sauron not checked
        chkExtraStable.Checked = False    ' Extra stable not checked
        chkNonSmoke.Checked = False       ' Non smoking not checked
        chkStorage.Checked = False        ' Extra storage not checked

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        btnExit.PerformClick()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()  'Closes program'
    End Sub

End Class
