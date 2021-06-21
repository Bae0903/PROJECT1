Public Class ZakatApplicationResult

    'Back button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    'View button
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        viewReason()
    End Sub

    'Display output function
    Public Function dataSubmit()
        lblName.Text = ZakatUnivApplication.txtName.Text
        lblIC.Text = ZakatUnivApplication.txtIC.Text
        lblAddress.Text = ZakatUnivApplication.txtAddress.Text
        lblAge.Text = ZakatUnivApplication.numAge.Value
        lblEmail.Text = ZakatUnivApplication.txtEmail.Text
        lblPhoneNo.Text = ZakatUnivApplication.txtPhone.Text

        If ZakatUnivApplication.radioMale.Checked = True Then
            lblGender.Text = ZakatUnivApplication.radioMale.Text
        ElseIf ZakatUnivApplication.radioFemale.Checked = True Then
            lblGender.Text = ZakatUnivApplication.radioFemale.Text
        End If

        If ZakatUnivApplication.radioYes.Checked = True Then
            lblYesNoMuslim.Text = ZakatUnivApplication.radioYes.Text
        ElseIf ZakatUnivApplication.radioNo.Checked = True Then
            lblYesNoMuslim.Text = ZakatUnivApplication.radioNo.Text
        End If

        If ZakatUnivApplication.selectionResult.Text = "1A" Then
            lblSPMResult.Text = "1A"
        ElseIf ZakatUnivApplication.selectionResult.Text = "2A" Then
            lblSPMResult.Text = "2A"
        ElseIf ZakatUnivApplication.selectionResult.Text = "3A" Then
            lblSPMResult.Text = "3A"
        ElseIf ZakatUnivApplication.selectionResult.Text = "4A" Then
            lblSPMResult.Text = "4A"
        ElseIf ZakatUnivApplication.selectionResult.Text = "5A" Then
            lblSPMResult.Text = "5A"
        ElseIf ZakatUnivApplication.selectionResult.Text = "6A" Then
            lblSPMResult.Text = "6A"
        ElseIf ZakatUnivApplication.selectionResult.Text = "7A" Then
            lblSPMResult.Text = "7A"
        ElseIf ZakatUnivApplication.selectionResult.Text = "8A" Then
            lblSPMResult.Text = "8A"
        ElseIf ZakatUnivApplication.selectionResult.Text = "9A and Above" Then
            lblSPMResult.Text = "9A and Above"
        End If

        If ZakatUnivApplication.chBoxPhysics.Checked = True Then
            lblPhysics.Text = "Physics"
        End If

        If ZakatUnivApplication.chBoxBiology.Checked = True Then
            lblBiology.Text = "Biology"
        End If

        If ZakatUnivApplication.chBoxChemistry.Checked = True Then
            lblChemistry.Text = "Chemistry"
        End If

        If ZakatUnivApplication.chBoxAddMath.Checked = True Then
            lblAddMath.Text = "Add Math"
        End If

        If ZakatUnivApplication.selectionCitizen.Text = "Yes" Then
            lblYesNoCitizen.Text = "Yes"
        ElseIf ZakatUnivApplication.selectionCitizen.Text = "No" Then
            lblYesNoCitizen.Text = "No"
        End If

        If ZakatUnivApplication.radioYesMin.Checked = True Then
            lblYesNoGrade.Text = ZakatUnivApplication.radioYesMin.Text
        ElseIf ZakatUnivApplication.radioNoMin.Checked = True Then
            lblYesNoGrade.Text = ZakatUnivApplication.radioNoMin.Text
        End If

        'Call for ApplicationCondition function
        ApplicationCondition()
        Return True
    End Function

    'Check for condition
    Public Function ApplicationCondition()
        If ZakatUnivApplication.radioYes.Checked = True Then
            If ZakatUnivApplication.selectionCitizen.Text = "Yes" Then
                If ZakatUnivApplication.selectionResult.Text = "5A" Or ZakatUnivApplication.selectionResult.Text = "6A" Or ZakatUnivApplication.selectionResult.Text = "7A" Or ZakatUnivApplication.selectionResult.Text = "8A" Or ZakatUnivApplication.selectionResult.Text = "9A and Above" Then
                    If ZakatUnivApplication.chBoxPhysics.Checked = True Or ZakatUnivApplication.chBoxBiology.Checked = True Or ZakatUnivApplication.chBoxChemistry.Checked = True Or ZakatUnivApplication.chBoxAddMath.Checked = True Then
                        If ZakatUnivApplication.radioYesMin.Checked = True Then
                            lblResult.Text = "Qualified"
                            lblResult.ForeColor = Color.Green
                            btnView.Hide()
                        Else
                            lblResult.Text = "Not Qualified"
                            lblResult.ForeColor = Color.Red
                        End If
                    Else
                        lblResult.Text = "Not Qualified"
                        lblResult.ForeColor = Color.Red
                    End If
                Else
                    lblResult.Text = "Not Qualified"
                    lblResult.ForeColor = Color.Red
                End If
            Else
                lblResult.Text = "Not Qualified"
                lblResult.ForeColor = Color.Red
            End If
        Else
            lblResult.Text = "Not Qualified"
            lblResult.ForeColor = Color.Red
        End If
        Return True
    End Function

    'View reason
    Public Function viewReason()
        Dim formView As New ZakatApplicationCondView
        ZakatApplicationCondView.Show()
        Return True
    End Function

    Private Sub btnBack3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class