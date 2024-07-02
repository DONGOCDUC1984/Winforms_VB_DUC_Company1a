Imports System.Data.SqlClient

Public Class LoginForm
    Dim con = CommonServices.con
    Private Sub btnNavRegister_Click(sender As Object, e As EventArgs) Handles btnNavRegister.Click
        Me.Hide()
        Dim registerForm As New RegisterForm()
        registerForm.Show()
    End Sub
    Private Sub Clear()
        txtUserNameLo.Clear()
        txtUserPasswordLo.Clear()

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        con.Open()
        Dim query = "Select * from Users where UserName ='" & txtUserNameLo.Text.Trim() &
               "' and UserPassword ='" + CommonServices.GetHashedPassword(txtUserPasswordLo.Text.Trim()) & "'"
        Dim cmd = New SqlCommand(query, con)
        Dim dtbl = New DataTable()
        Dim sqlDa = New SqlDataAdapter(cmd)
        sqlDa.Fill(dtbl)
        If dtbl.Rows.Count = 1 Then
            'The following lines are used to send data from this form to HomeForm
            Dim homeForm = New HomeForm()
            CommonServices.UserName = dtbl.Rows(0)("UserName").ToString()
            CommonServices.UserEmail = dtbl.Rows(0)("UserEmail").ToString()
            CommonServices.UserRole = dtbl.Rows(0)("UserRole").ToString()
            Me.Hide()
            homeForm.Show()
            CommonServices.ShowPopUpNoti("Successfully logged in")
            Clear()
        Else
            MessageBox.Show("Wrong username or wrong password",
                       "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        con.Close()

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class