Imports System.Data.SqlClient

Public Class RegisterForm
    Dim con = CommonServices.con
    Private Sub btnNavLogin_Click(sender As Object, e As EventArgs) Handles btnNavLogin.Click
        Me.Hide()
        Dim loginForm As New LoginForm()
        loginForm.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtUserNameRe.Text = "" Or txtUserEmailRe.Text = "" Or
               txtUserPasswordRe.Text = "" Or txtConfirmUserPasswordRe.Text = "" Then
            MessageBox.Show("Please fill all fields",
                               "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If txtUserPasswordRe.Text <> txtConfirmUserPasswordRe.Text Then
                MessageBox.Show("Passwords do not match",
                 "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' For Admin
                ' Dim Role = "Admin"

                'For User
                Dim UserRole = "User"

                con.Open()
                Dim cmd = New SqlCommand("UserCreate", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("UserName", txtUserNameRe.Text.Trim())
                cmd.Parameters.AddWithValue("UserEmail", txtUserEmailRe.Text.Trim())
                cmd.Parameters.AddWithValue("UserPassword",
                                            CommonServices.GetHashedPassword(txtUserPasswordRe.Text.Trim()))
                cmd.Parameters.AddWithValue("UserRole", UserRole)
                cmd.ExecuteNonQuery()
                con.Close()
                'The following lines are used to send data from this form to HomeForm
                Dim homeForm = New HomeForm()
                CommonServices.UserName = txtUserNameRe.Text.Trim()
                CommonServices.UserEmail = txtUserEmailRe.Text.Trim()
                CommonServices.UserRole = UserRole
                Me.Hide()
                homeForm.Show()
                CommonServices.ShowPopUpNoti("Successfully registered")
                Clear()
            End If
        End If
    End Sub
    Private Sub Clear()
        txtUserNameRe.Clear()
        txtUserEmailRe.Clear()
        txtUserPasswordRe.Clear()
        txtConfirmUserPasswordRe.Clear()
    End Sub


End Class