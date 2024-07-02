Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class HomeForm

    'Dim con = CommonServices.con
    ' If I write the above line,there will often be errors with " con.Open()" and "con.Close()"  
    Dim con As New SqlConnection("Data Source=DESKTOP-V8UBCG7\SQLEXPRESS;Initial Catalog=Winforms_VB_DUC_Company1a;Integrated Security=True")
    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForAdmin()
        FillProfile()
        FilldgvEmployees()
        FillcmbHomeDepartment()
    End Sub

    Private Sub ForAdmin()
        If CommonServices.UserRole = "Admin" Then
            btnNavCRUD.Show()
            btnNavSalary.Show()
            btnNavDepartment.Show()
            btnNavPosition.Show()
            btnNavChart.Show()
            btnNavCrystalReport.Show()
        Else
            btnNavCRUD.Hide()
            btnNavSalary.Hide()
            btnNavDepartment.Hide()
            btnNavPosition.Hide()
            btnNavChart.Hide()
            btnNavCrystalReport.Hide()
        End If
    End Sub

    Private Sub FillProfile()
        LabelUser.Text = CommonServices.UserRole & " : " & CommonServices.UserName
    End Sub

    Private Sub FilldgvEmployees()
        txtSearchEmpByName.Clear()
        dgvEmployees.AutoGenerateColumns = False

        con.Open()
        Dim cmd = New SqlCommand("EmployeeList", con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        Dim dt = New DataTable()
        Dim da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvEmployees.DataSource = dt
        con.Close()
    End Sub

    Private Sub FillcmbHomeDepartment()
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
        cmbHomeDepartment.ValueMember = "DepartmentId"
        cmbHomeDepartment.DisplayMember = "DepartmentName"
        cmbHomeDepartment.DataSource = dt
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

    Private Sub btnNavCrystalReport_Click(sender As Object, e As EventArgs) Handles btnNavCrystalReport.Click
        Me.Hide()
        Dim crystalReportForm As New CrystalReportForm()
        crystalReportForm.Show()
    End Sub

    Private Sub dgvEmployees_DoubleClick(sender As Object, e As EventArgs) Handles dgvEmployees.DoubleClick
        If dgvEmployees.CurrentRow.Index <> -1 Then
            CommonServices.inEmpId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells(0).Value)
        End If
    End Sub
    'txtSearchEmpByName only accepts letters, "-" or "'" 
    Private Sub txtSearchEmpByName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchEmpByName.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = vbBack Or e.KeyChar = "-" Or e.KeyChar = "'" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'Search employee by name
    Private Sub txtSearchEmpByName_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEmpByName.TextChanged
        If txtSearchEmpByName.Text <> "" Then
            dgvEmployees.AutoGenerateColumns = False
            con.Open()
            Dim cmd = New SqlCommand("GetEmployeeByName", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("searchStr", txtSearchEmpByName.Text.Trim())
            cmd.ExecuteNonQuery()
            con.Close()
            Dim dt = New DataTable()
            Dim da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            dgvEmployees.DataSource = dt
        Else
            FilldgvEmployees()
        End If
    End Sub
    ' Filter Employees
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        txtSearchEmpByName.Clear()
        dgvEmployees.AutoGenerateColumns = False
        con.Open()
        Dim cmd = New SqlCommand("GetEmployeeByDepartmentId", con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("DepartmentId", Convert.ToInt32(cmbHomeDepartment.SelectedValue))
        cmd.ExecuteNonQuery()
        con.Close()
        Dim dt = New DataTable()
        Dim da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvEmployees.DataSource = dt
    End Sub
    'Show All Employees
    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        FilldgvEmployees()
    End Sub

    'Export to Excel file
    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Excel Workbook|*.xlsx"
        If sfd.ShowDialog() = DialogResult.OK Then
            Dim excel = New Microsoft.Office.Interop.Excel.Application()
            Dim workbook As Microsoft.Office.Interop.Excel._Workbook = excel.Workbooks.Add(Type.Missing)
            Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
            Try
                excel = New Microsoft.Office.Interop.Excel.Application()
                excel.Visible = False
                excel.DisplayAlerts = False
                'Create a workbook by Add()
                workbook = excel.Workbooks.Add(Type.Missing)
                worksheet = workbook.ActiveSheet
                worksheet.Name = "Employee Management"
                'Export header from Datagridview."-4" because we do not need to see 3 last columns
                For i = 0 To dgvEmployees.ColumnCount - 4
                    worksheet.Cells(1, i + 1) = dgvEmployees.Columns(i).HeaderText
                Next
                'Export content from Datagridview
                For i = 0 To dgvEmployees.RowCount - 1
                    '"-4" because we do not need to see 3 last columns
                    For j = 0 To dgvEmployees.ColumnCount - 4
                        worksheet.Cells(i + 2, j + 1) = dgvEmployees.Rows(i).Cells(j).Value?.ToString()
                    Next
                Next
                'Save
                workbook.SaveAs(sfd.FileName)
                workbook.Close()
                excel.Quit()
                CommonServices.ShowPopUpNoti("Exported to Excel successfully")

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                workbook = Nothing
                excel = Nothing
            End Try
        End If
    End Sub
    ' Export to PDF file
    Private Sub btnExportToPDF_Click(sender As Object, e As EventArgs) Handles btnExportToPDF.Click
        If dgvEmployees.Rows.Count > 0 Then
            Dim sfd = New SaveFileDialog()
            sfd.Filter = "PDF (*.pdf)|*.pdf"
            sfd.FileName = "PDFResult.pdf"
            Dim ErrorMessage = False
            If sfd.ShowDialog() = DialogResult.OK Then
                If File.Exists(sfd.FileName) Then
                    Try
                        File.Delete(sfd.FileName)
                    Catch ex As Exception
                        ErrorMessage = True
                        MessageBox.Show("Unable to save " + ex.Message, "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

                If ErrorMessage = False Then
                    Try
                        Dim pdfPTable =
                               New PdfPTable(dgvEmployees.Columns.Count)
                        pdfPTable.DefaultCell.Padding = 2
                        pdfPTable.WidthPercentage = 100
                        pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT

                        For Each col In dgvEmployees.Columns
                            Dim PdfPCell =
                                   New PdfPCell(New Phrase(CStr(col.HeaderText)))
                            pdfPTable.AddCell(PdfPCell)
                        Next

                        For Each row In dgvEmployees.Rows
                            For Each cell In row.Cells
                                pdfPTable.AddCell(cell.Value?.ToString())
                            Next
                        Next

                        Dim FileStream = New FileStream(sfd.FileName, FileMode.Create)
                        Dim document =
                                   New Document(PageSize.A4, 8.0F, 16.0F, 16.0F, 8.0F)
                        PdfWriter.GetInstance(document, FileStream)
                        document.Open()
                        document.Add(pdfPTable)
                        document.Close()
                        FileStream.Close()
                        CommonServices.ShowPopUpNoti("Exported to PDF successfully")
                    Catch ex As Exception
                        MessageBox.Show("Error while exporting: " + ex.Message, "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        Else
            MessageBox.Show("No record found", "Info")
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Bitmap = New Bitmap(dgvEmployees.Width, dgvEmployees.Height)
        dgvEmployees.DrawToBitmap(Bitmap, New System.Drawing.Rectangle(0, 0, dgvEmployees.Width, dgvEmployees.Height))
        e.Graphics.DrawImage(Bitmap, 80, 150)
        'Print Header
        e.Graphics.DrawString("Employees", New System.Drawing.Font("Verdana", 25, FontStyle.Bold), Brushes.Black, New Point(50, 50))
    End Sub
    'Print
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Show()
    End Sub


End Class