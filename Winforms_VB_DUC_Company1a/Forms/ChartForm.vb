Imports System.Data.SqlClient
Public Class ChartForm
    Dim con As New SqlConnection("Data Source=DESKTOP-V8UBCG7\SQLEXPRESS;Initial Catalog=Winforms_VB_DUC_Company1a;Integrated Security=True")
    Private Sub ChartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillProfile()
        DrawChart()
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

    Private Sub btnNavPosition_Click(sender As Object, e As EventArgs) Handles btnNavPosition.Click
        Me.Hide()
        Dim positionForm As New PositionForm()
        positionForm.Show()
    End Sub

    Private Sub btnNavCrystalReport_Click(sender As Object, e As EventArgs) Handles btnNavCrystalReport.Click
        Me.Hide()
        Dim crystalReportForm As New CrystalReportForm()
        crystalReportForm.Show()
    End Sub

    Private Sub DrawChart()
        Dim query = "Select Month ,Profit  from Profit_2023  "
        Dim cmd = New SqlCommand()
        cmd.Connection = con
        cmd.CommandText = query
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        Dim dt = New DataTable()
        Dim da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        Chart1.DataSource = dt
        Chart1.Series("Profit_In_2023").XValueMember = "Month"
        Chart1.Series("Profit_In_2023").YValueMembers = "Profit"
        Chart1.Titles.Add("Profit in 2023")
    End Sub

End Class