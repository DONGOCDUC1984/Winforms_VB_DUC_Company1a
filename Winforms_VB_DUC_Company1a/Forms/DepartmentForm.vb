Imports System.Data.SqlClient
Public Class DepartmentForm
    Dim con As New SqlConnection("Data Source=DESKTOP-V8UBCG7\SQLEXPRESS;Initial Catalog=Winforms_VB_DUC_Company1a;Integrated Security=True")
    Dim inDepartmentId = 0
    Private Sub DepartmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillProfile()
        FilldgvDepartments()
    End Sub
    Private Sub FillProfile()
        LabelUser.Text = CommonServices.UserRole & " : " & CommonServices.UserName
    End Sub
    Private Sub btnNavHome_Click(sender As Object, e As EventArgs) Handles btnNavHome.Click
        Me.Hide()
        Dim homeForm As New HomeForm()
        homeForm.Show()
    End Sub

    Private Sub btnNavCRUD_Click(sender As Object, e As EventArgs) Handles btnNavCRUD.Click
        Me.Hide()
        Dim employeesForm As New EmployeesForm()
        employeesForm.Show()
    End Sub

    Private Sub btnNavSalary_Click(sender As Object, e As EventArgs) Handles btnNavSalary.Click
        Me.Hide()
        Dim salaryForm As New SalaryForm()
        salaryForm.Show()
    End Sub

    Private Sub btnNavPosition_Click(sender As Object, e As EventArgs) Handles btnNavPosition.Click
        Me.Hide()
        Dim positionForm As New PositionForm()
        positionForm.Show()
    End Sub

    Private Sub btnNavChart_Click(sender As Object, e As EventArgs) Handles btnNavChart.Click
        Me.Hide()
        Dim chartForm As New ChartForm()
        chartForm.Show()
    End Sub

    Private Sub btnNavCrystalReport_Click(sender As Object, e As EventArgs) Handles btnNavCrystalReport.Click
        Me.Hide()
        Dim crystalReportForm As New CrystalReportForm()
        crystalReportForm.Show()
    End Sub

    'Save Department
    Private Sub btnSaveDe_Click(sender As Object, e As EventArgs) Handles btnSaveDe.Click
        If txtDeDepartmentName.Text = "" Then
            MessageBox.Show("Please fill all fields",
                    "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Create
            If inDepartmentId = 0 Then
                Dim query = $"INSERT INTO Departments (DepartmentName) VALUES " +
                            $"( '{txtDeDepartmentName.Text.Trim()}')"
                con.Open()
                Dim cmd = New SqlCommand()
                cmd.Connection = con
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
                con.Close()
                CommonServices.ShowPopUpNoti("Successfully created")
                'Update
            Else
                Dim query = $"Update Departments set DepartmentName='{txtDeDepartmentName.Text.Trim()}' " +
                            $" Where DepartmentId ='{inDepartmentId}'  "
                con.Open()
                Dim cmd = New SqlCommand()
                cmd.Connection = con
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
                con.Close()
                CommonServices.ShowPopUpNoti("Successfully updated")
            End If
            ClearDe()
            FilldgvDepartments()

        End If
    End Sub

    Private Sub ClearDe()
        txtDeDepartmentName.Clear()
        inDepartmentId = 0
        ' To disable Delete button
        btnDeleteDe.Enabled = False
    End Sub

    ' Delete Department
    Private Sub btnDeleteDe_Click(sender As Object, e As EventArgs) Handles btnDeleteDe.Click
        If MessageBox.Show("Are you sure you want to delete this ?",
                "EF CRUD operation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim query = $"Delete from Departments where DepartmentId = {inDepartmentId}"
            con.Open()
            Dim cmd = New SqlCommand()
            cmd.Connection = con
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            con.Close()
            ClearDe()
            FilldgvDepartments()
            CommonServices.ShowPopUpNoti("Successfully deleted")
        End If
    End Sub

    'Reset
    Private Sub btnResetDe_Click(sender As Object, e As EventArgs) Handles btnResetDe.Click
        ClearDe()
    End Sub

    'Fill dgvDepartments
    Private Sub FilldgvDepartments()
        dgvDepartments.AutoGenerateColumns = False
        Dim query = "Select * from Departments"
        con.Open()
        Dim cmd = New SqlCommand()
        cmd.Connection = con
        cmd.CommandText = query
        cmd.ExecuteNonQuery()
        Dim dt = New DataTable()
        Dim da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvDepartments.DataSource = dt
        con.Close()
    End Sub

    Private Sub dgvDepartments_DoubleClick(sender As Object, e As EventArgs) Handles dgvDepartments.DoubleClick
        If dgvDepartments.CurrentRow.Index <> -1 Then
            inDepartmentId = Convert.ToInt32(dgvDepartments.CurrentRow.Cells(0).Value)
            txtDeDepartmentName.Text = dgvDepartments.CurrentRow.Cells(1).Value.ToString()
            btnDeleteDe.Enabled = True
        End If
    End Sub

    Private Sub dgvDepartments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartments.CellContentClick
        If dgvDepartments.CurrentRow.Cells(1).Value.ToString() <> "" Then
            inDepartmentId = Convert.ToInt32(dgvDepartments.CurrentRow.Cells(0).Value)
            If dgvDepartments.Columns(e.ColumnIndex).Name = "Delete" Then
                If MessageBox.Show("Are you sure you want to delete this ?",
                    "EF CRUD operation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Dim query = $"Delete from Departments where DepartmentId = {inDepartmentId}"
                    con.Open()
                    Dim cmd = New SqlCommand()
                    cmd.Connection = con
                    cmd.CommandText = query
                    cmd.ExecuteNonQuery()
                    con.Close()
                    ClearDe()
                    FilldgvDepartments()
                    CommonServices.ShowPopUpNoti("Successfully deleted")
                End If
            End If

            If dgvDepartments.Columns(e.ColumnIndex).Name = "Update" Then
                If dgvDepartments.CurrentRow.Cells(1).Value.ToString() = "" Then
                    MessageBox.Show("Please fill all fields",
                           "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim query = $"Update Departments " +
                               $" set DepartmentName='{dgvDepartments.CurrentRow.Cells(1).Value.ToString()}' " +
                               $" Where DepartmentId ='{inDepartmentId}'  "
                    con.Open()
                    Dim cmd = New SqlCommand()
                    cmd.Connection = con
                    cmd.CommandText = query
                    cmd.ExecuteNonQuery()
                    con.Close()
                    ClearDe()
                    FilldgvDepartments()
                    CommonServices.ShowPopUpNoti("Successfully updated")
                End If
            End If
        End If

    End Sub
End Class