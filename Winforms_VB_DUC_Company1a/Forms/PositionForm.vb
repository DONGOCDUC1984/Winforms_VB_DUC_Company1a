Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab

Public Class PositionForm
    Dim con As New SqlConnection("Data Source=DESKTOP-V8UBCG7\SQLEXPRESS;Initial Catalog=Winforms_VB_DUC_Company1a;Integrated Security=True")
    Dim inPositionId = 0
    Private Sub PositionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillProfile()
        FillcmbPoDepartment()
        FilldgvPositions()
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

    Private Sub btnNavDepartment_Click(sender As Object, e As EventArgs) Handles btnNavDepartment.Click
        Me.Hide()
        Dim departmentForm As New DepartmentForm()
        departmentForm.Show()
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

    'Save Position
    Private Sub btnSavePo_Click(sender As Object, e As EventArgs) Handles btnSavePo.Click
        If txtPoPositionName.Text = "" Or txtPoDailySalary.Text = "" Then
            MessageBox.Show("Please fill all fields",
                    "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Create
            If inPositionId = 0 Then
                Dim query = $"INSERT INTO Positions (PositionName,DepartmentId " +
                           $" , DailySalary  ) VALUES " +
                           $"( '{txtPoPositionName.Text.Trim()}'," +
                           $" '{Convert.ToInt32(cmbPoDepartment.SelectedValue)}' , " +
                           $" '{Convert.ToDouble(txtPoDailySalary.Text.Trim())}'  )"
                con.Open()
                Dim cmd = New SqlCommand()
                cmd.Connection = con
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
                con.Close()
                CommonServices.ShowPopUpNoti("Successfully created")
                'Update
            Else
                Dim query = $"Update Positions set PositionName='{txtPoPositionName.Text.Trim()}' , " +
                           $" DepartmentId = '{Convert.ToInt32(cmbPoDepartment.SelectedValue)}' , " +
                           $" DailySalary = '{Convert.ToDouble(txtPoDailySalary.Text.Trim())}'  " +
                           $" Where PositionId ='{inPositionId}'  "
                con.Open()
                Dim cmd = New SqlCommand()
                cmd.Connection = con
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
                con.Close()
                CommonServices.ShowPopUpNoti("Successfully updated")
            End If
            ClearPo()
            FilldgvPositions()

        End If
    End Sub

    'Delete Position
    Private Sub btnDeletePo_Click(sender As Object, e As EventArgs) Handles btnDeletePo.Click
        If MessageBox.Show("Are you sure you want to delete this ?",
                "CRUD operation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim query = $"Delete from Positions where PositionId  = {inPositionId}"
            con.Open()
            Dim cmd = New SqlCommand()
            cmd.Connection = con
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            con.Close()
            ClearPo()
            FilldgvPositions()
            CommonServices.ShowPopUpNoti("Successfully deleted")
        End If
    End Sub
    'Reset
    Private Sub btnResetPo_Click(sender As Object, e As EventArgs) Handles btnResetPo.Click
        ClearPo()
    End Sub

    Private Sub ClearPo()
        txtPoPositionName.Clear()
        txtPoDailySalary.Clear()
        inPositionId = 0
        'To disable Delete button
        btnDeletePo.Enabled = False
    End Sub

    'Fill dgvPositions
    Private Sub FilldgvPositions()
        dgvPositions.AutoGenerateColumns = False
        con.Open()
        Dim cmd = New SqlCommand("PositionList", con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        con.Close()
        Dim dt = New DataTable()
        Dim da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvPositions.DataSource = dt
    End Sub

    'Fill combobox cmbPoDepartment
    Private Sub FillcmbPoDepartment()
        con.Open()
        Dim query = "Select * from Departments"
        Dim dt = New DataTable()
        Dim da = New SqlDataAdapter(query, con)
        da.Fill(dt)
        con.Close()
        Dim topItem = dt.NewRow()
        topItem(0) = 0
        topItem(1) = "-Select-"
        dt.Rows.InsertAt(topItem, 0)
        ' In the 2 following lines,"DepartmentId" And "DepartmentName" are from Departments table
        cmbPoDepartment.ValueMember = "DepartmentId"
        cmbPoDepartment.DisplayMember = "DepartmentName"
        cmbPoDepartment.DataSource = dt

    End Sub

    Private Sub dgvPositions_DoubleClick(sender As Object, e As EventArgs) Handles dgvPositions.DoubleClick
        If dgvPositions.CurrentRow.Index <> -1 Then
            inPositionId = Convert.ToInt32(dgvPositions.CurrentRow.Cells(0).Value)
            txtPoPositionName.Text = dgvPositions.CurrentRow.Cells(1).Value.ToString()
            cmbPoDepartment.SelectedValue = Convert.ToInt32(dgvPositions.CurrentRow.Cells(4).Value)
            txtPoDailySalary.Text = dgvPositions.CurrentRow.Cells(3).Value.ToString()
            btnDeletePo.Enabled = True
        End If
    End Sub
End Class