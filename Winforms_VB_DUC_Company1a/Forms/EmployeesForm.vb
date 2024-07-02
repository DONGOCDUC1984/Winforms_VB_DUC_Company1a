Imports System.Data.SqlClient
Imports System.IO

Public Class EmployeesForm
    Dim cmbDepartmentId = 0
    Dim isDefaultImage = True
    Dim previousImageString = ""
    'Dim con = CommonServices.con
    ' If I write the above line,there will often be errors with " con.Open()" and "con.Close()"  
    Dim con As New SqlConnection("Data Source=DESKTOP-V8UBCG7\SQLEXPRESS;Initial Catalog=Winforms_VB_DUC_Company1a;Integrated Security=True")
    Dim ofd = New OpenFileDialog()
    Private Sub EmployeesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillProfile()
        FillcmbEmpDepartment()
        FillFormWithEmpId()
        If CommonServices.inEmpId <> 0 Then
            'To allow Delete button to work
            btnDeleteEmp.Enabled = True
        Else
            pbEmpPhoto.Image = New Bitmap(Application.StartupPath + "\\Images\\user256.png")
        End If

    End Sub
    Private Sub FillProfile()
        LabelUser.Text = CommonServices.UserRole & " : " & CommonServices.UserName
    End Sub
    Private Sub btnNavHome_Click(sender As Object, e As EventArgs) Handles btnNavHome.Click
        Me.Hide()
        Dim homeForm As New HomeForm()
        homeForm.Show()
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

    Private Sub btnNavCrystalReport_Click(sender As Object, e As EventArgs) Handles btnNavCrystalReport.Click
        Me.Hide()
        Dim crystalReportForm As New CrystalReportForm()
        crystalReportForm.Show()
    End Sub

    Private Sub FillcmbEmpDepartment()
        con.Open()
        Dim query = "Select * from Departments"
        Dim cmd = New SqlCommand(query, con)
        Dim dt = New DataTable()
        Dim da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        con.Close()
        Dim topItem As DataRow = dt.NewRow()
        topItem(0) = 0
        topItem(1) = "-Select-"
        dt.Rows.InsertAt(topItem, 0)
        'In the 2 following lines,"DepartmentId" And "DepartmentName" are from Departments table
        cmbEmpDepartment.ValueMember = "DepartmentId"
        cmbEmpDepartment.DisplayMember = "DepartmentName"
        cmbEmpDepartment.DataSource = dt
    End Sub

    ' Cascading dropdown
    Private Sub FillcmbEmpPosition(DepartmentId As Integer)
        con.Open()
        Dim query = $"Select * from Positions where DepartmentId = {DepartmentId} "
        Dim cmd = New SqlCommand(query, con)
        Dim dt = New DataTable()
        Dim da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        con.Close()
        Dim topItem As DataRow = dt.NewRow()
        topItem(0) = 0
        topItem(1) = "-Select-"
        dt.Rows.InsertAt(topItem, 0)
        ' In the 2 following lines,"PositionId" And "PositionName" are from Positions table
        cmbEmpPosition.ValueMember = "PositionId"
        cmbEmpPosition.DisplayMember = "PositionName"
        cmbEmpPosition.DataSource = dt

    End Sub

    ' Cascading dropdown
    Private Sub cmbEmpDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpDepartment.SelectedIndexChanged
        If cmbEmpDepartment.SelectedIndex <> 0 Then
            cmbDepartmentId = cmbEmpDepartment.SelectedIndex
            FillcmbEmpPosition(cmbDepartmentId)
        End If
    End Sub
    'Reset
    Private Sub btnResetEmp_Click(sender As Object, e As EventArgs) Handles btnResetEmp.Click
        ClearEmp()
    End Sub

    Private Sub ClearEmp()
        txtEmpName.Clear()
        dtpEmpDOB.Value = DateTime.Now
        If cmbEmpGender.DataSource IsNot Nothing Then
            cmbEmpGender.SelectedIndex = 0
        End If
        txtEmpAddress.Clear()

        If cmbEmpDepartment.DataSource IsNot Nothing Then
            cmbEmpDepartment.SelectedIndex = 0
        End If

        If cmbEmpPosition.DataSource IsNot Nothing Then
            cmbEmpPosition.SelectedIndex = 0
        End If

        CommonServices.inEmpId = 0
        pbEmpPhoto.Image = New Bitmap(Application.StartupPath + "\\Images\\user256.png")
        isDefaultImage = True
        btnSaveEmp.Text = "Save"
        'To disable Delete button
        btnDeleteEmp.Enabled = False
    End Sub

    Private Sub FillFormWithEmpId()
        If CommonServices.inEmpId <> 0 Then
            con.Open()
            Dim cmd = New SqlCommand("GetEmployeeById", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("EmpId", CommonServices.inEmpId)
            cmd.ExecuteNonQuery()
            con.Close()
            Dim dt = New DataTable()
            Dim da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count = 1 Then
                txtEmpName.Text = dt.Rows(0)("EmpName").ToString()
                dtpEmpDOB.Value = Convert.ToDateTime(dt.Rows(0)("EmpDOB").ToString())
                cmbEmpGender.Text = dt.Rows(0)("EmpGender").ToString()
                txtEmpAddress.Text = dt.Rows(0)("EmpAddress").ToString()
                cmbEmpDepartment.SelectedValue = Convert.ToInt32(dt.Rows(0)("DepartmentId").ToString())
                cmbEmpPosition.SelectedValue = Convert.ToInt32(dt.Rows(0)("PositionId").ToString())
                Dim x = dt.Rows(0)("EmpImagePath").ToString()
                If dt.Rows(0)("EmpImagePath").ToString() = "" Then
                    pbEmpPhoto.Image = New Bitmap(Application.StartupPath + "\\Images\\user256.png")
                    isDefaultImage = True
                Else
                    pbEmpPhoto.Image = New Bitmap(Application.StartupPath + "\\Images\\" + dt.Rows(0)("EmpImagePath").ToString())
                    isDefaultImage = False
                    previousImageString = dt.Rows(0)("EmpImagePath").ToString()
                End If
                btnDeleteEmp.Enabled = True
            End If
        End If
    End Sub
    Private Sub btnUploadEmpPhoto_Click(sender As Object, e As EventArgs) Handles btnUploadEmpPhoto.Click
        ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg"
        If ofd.ShowDialog() = DialogResult.OK Then
            pbEmpPhoto.Image = New Bitmap(ofd.FileName.ToString())
            isDefaultImage = False
            previousImageString = ""
        End If
    End Sub

    Private Sub btnClearEmpPhoto_Click(sender As Object, e As EventArgs) Handles btnClearEmpPhoto.Click
        pbEmpPhoto.Image = New Bitmap(Application.StartupPath + "\\Images\\user256.png")
        isDefaultImage = True
        previousImageString = ""
    End Sub

    Private Function checkFormEmp() As Boolean
        If txtEmpName.Text = "" Or txtEmpAddress.Text = "" Then
            MessageBox.Show("Please fill all fields",
                   "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If
    End Function

    Private Function saveImage(_imagePath As String) As String
        Dim _fileName = Path.GetFileNameWithoutExtension(_imagePath)
        Dim _extension = Path.GetExtension(_imagePath)
        'shorten image Name
        If _fileName.Length <= 15 Then
            _fileName = _fileName
        Else
            _fileName = _fileName.Substring(0, 15)
        End If
        _fileName = _fileName + DateTime.Now.ToString("yymmssfff") + _extension
        pbEmpPhoto.Image.Save(Application.StartupPath + "\\Images\\" + _fileName)
        Return _fileName

    End Function

    ' Create or Update employee
    Private Sub btnSaveEmp_Click(sender As Object, e As EventArgs) Handles btnSaveEmp.Click
        If checkFormEmp() Then
            con.Open()
            Dim cmd = New SqlCommand("EmployeeCreateOrEdit", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("EmpId", CommonServices.inEmpId)
            cmd.Parameters.AddWithValue("EmpName", txtEmpName.Text.Trim())
            cmd.Parameters.AddWithValue("EmpDOB", dtpEmpDOB.Value)
            cmd.Parameters.AddWithValue("EmpGender", cmbEmpGender.Text)
            cmd.Parameters.AddWithValue("EmpAddress", txtEmpAddress.Text.Trim())
            cmd.Parameters.AddWithValue("DepartmentId", Convert.ToInt32(cmbEmpDepartment.SelectedValue))
            cmd.Parameters.AddWithValue("PositionId", Convert.ToInt32(cmbEmpPosition.SelectedValue))

            'Create
            If CommonServices.inEmpId = 0 Then
                If isDefaultImage Then
                    cmd.Parameters.AddWithValue("EmpImagePath", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("EmpImagePath", saveImage(ofd.FileName))
                End If
                'Update
            Else
                If isDefaultImage Then
                    cmd.Parameters.AddWithValue("EmpImagePath", DBNull.Value)
                Else
                    If previousImageString IsNot "" Then
                        cmd.Parameters.AddWithValue("EmpImagePath", previousImageString)
                    Else
                        cmd.Parameters.AddWithValue("EmpImagePath", saveImage(ofd.FileName))
                    End If
                End If
            End If
            cmd.ExecuteNonQuery()
            con.Close()
        End If

        If CommonServices.inEmpId = 0 Then
            CommonServices.ShowPopUpNoti("Successfully created")
        Else
            CommonServices.ShowPopUpNoti("Successfully updated")
        End If
        ClearEmp()
    End Sub
    'Delete Employee
    Private Sub btnDeleteEmp_Click(sender As Object, e As EventArgs) Handles btnDeleteEmp.Click
        If MessageBox.Show("Are you sure you want to delete this ?",
                        "CRUD operation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            con.Open()
            Dim cmd = New SqlCommand("EmployeeDelete", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("EmpId", CommonServices.inEmpId)
            cmd.ExecuteNonQuery()
            con.Close()
            ClearEmp()
            CommonServices.ShowPopUpNoti("Successfully deleted")
        End If
    End Sub
End Class