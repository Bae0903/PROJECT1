Public Class ZakatUnivApplication

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetValue()
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        checkInput()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        exitProgram()
    End Sub

    Public Function exitProgram()
        Dim exitmsg As String
        exitmsg = MsgBox("Are you sure to Exit?", vbQuestion + vbYesNo, "Zakat for University Student Application")
        If exitmsg = vbYes Then
            Me.Close()
        Else
            MsgBox("You can continue.", vbQuestion + vbOKOnly, "Zakat for University Student Application")
        End If
        Return True
    End Function

    Public Function checkInput()
        numAge.Maximum = 30
        numAge.Minimum = 18

        If txtName.Text = "" Then
            MsgBox("Please fill in your name !", vbExclamation + vbOKOnly, "Zakat for University Student Application")
        ElseIf txtIC.TextLength < 12 Then
            MsgBox("Identical Card Number should not less than 12 !", vbExclamation + vbOKOnly, "Zakat for University Student Application")
        ElseIf txtIC.TextLength > 12 Then
            MsgBox("Identical Card Number should not more than 12 !", vbExclamation + vbOKOnly, "Zakat for University Student Application")
        ElseIf radioFemale.Checked = False And radioMale.Checked = False Then
            MsgBox("Please select gender !", vbExclamation + vbOKOnly, "Zakat for University Student Application")
        ElseIf txtAddress.Text = "" Then
            MsgBox("Please fill in your address !", vbExclamation + vbOKOnly, "Zakat for University Student Application")
        ElseIf txtEmail.Text = "" Then
            MsgBox("Please fill in your email address !", vbExclamation + vbOKOnly, "Zakat for University Student Application")
        ElseIf txtPhone.TextLength < 10 Then
            MsgBox("Phone Number should not less than 10 !", vbExclamation + vbOKOnly, "Zakat for University Student Application")
        ElseIf txtPhone.TextLength > 11 Then
            MsgBox("Phone Number should not more than 11 !", vbExclamation + vbOKOnly, "Zakat for University Student Application")
        ElseIf radioYes.Checked = False And radioNo.Checked = False Then
            MsgBox("Please select yes or no for religion status !", vbExclamation + vbOKOnly, "Zakat for University Student Application")
        ElseIf selectionResult.Text = "" Then
            MsgBox("Please select your result !", vbExclamation + vbOKOnly, "Zakat for University Student Application")
        ElseIf selectionCitizen.Text = "" Then
            MsgBox("Please select the citizenship !", vbExclamation + vbOKOnly, "Zakat for University Student Application")
        ElseIf radioYesMin.Checked = False And radioNoMin.Checked = False Then
            MsgBox("Please select yes or no for minimum grade!", vbExclamation + vbOKOnly, "Zakat for University Student Application")
        Else
            Dim formResult As New ZakatApplicationResult
            MsgBox("Submit Successful !", vbOKOnly, "Zakat for University Student Application")
            ZakatApplicationResult.Show()
            ZakatApplicationResult.dataSubmit()
        End If
        Return True
    End Function

    Public Function resetValue()
        txtName.Clear()
        txtAddress.Clear()
        txtEmail.Clear()
        txtIC.Clear()
        txtPhone.Clear()
        radioMale.Checked = False
        radioFemale.Checked = False
        radioYes.Checked = False
        radioNo.Checked = False
        numAge.Value = 18
        selectionResult.Text = ""
        selectionCitizen.Text = ""
        chBoxChemistry.Checked = False
        chBoxPhysics.Checked = False
        chBoxBiology.Checked = False
        chBoxAddMath.Checked = False
        radioYesMin.Checked = False
        radioNoMin.Checked = False

        Return True
    End Function

End Class
