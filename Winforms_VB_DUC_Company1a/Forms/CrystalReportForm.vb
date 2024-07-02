Imports System.Data.SqlClient
Public Class CrystalReportForm
    Dim con As New SqlConnection("Data Source=DESKTOP-V8UBCG7\SQLEXPRESS;Initial Catalog=Winforms_VB_DUC_Company1a;Integrated Security=True")
    Private Sub CrystalReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillProfile()
        ShowCRProfit_2023()
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

    Private Sub btnNavChart_Click(sender As Object, e As EventArgs) Handles btnNavChart.Click
        Me.Hide()
        Dim chartForm As New ChartForm()
        chartForm.Show()
    End Sub

    'Show Crystal Report CRProfit_2023
    Private Sub ShowCRProfit_2023()
        Dim query = "Select Month ,Profit  from Profit_2023  "
        Dim cmd = New SqlCommand()
        cmd.Connection = con
        cmd.CommandText = query
        con.Open()
        cmd.ExecuteNonQuery()
        Dim dt = New DataTable()
        Dim da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        con.Close()
        Dim cRProfit2023 = New CRProfit2023()
        cRProfit2023.Database.Tables("Profit_2023").SetDataSource(dt)
        CRViewer1.ReportSource = Nothing
        CRViewer1.ReportSource = cRProfit2023
    End Sub

End Class