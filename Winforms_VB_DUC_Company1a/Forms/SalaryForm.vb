Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class SalaryForm
    Dim con As New SqlConnection("Data Source=DESKTOP-V8UBCG7\SQLEXPRESS;Initial Catalog=Winforms_VB_DUC_Company1a;Integrated Security=True")
    Private Sub SalaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillProfile()
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

    'txtSaSearchEmpById only accepts numbers and "BackSpace"
    ''48 - 57  = Ascii codes for numbers
    Private Sub txtSaSearchEmpById_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaSearchEmpById.KeyPress
        'It only accepts numbers
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
        'It accepts "BackSpace"
        If e.KeyChar = vbBack Then
            e.Handled = False
        End If
    End Sub

    'Search employee by Id
    Private Sub btnSaSearchById_Click(sender As Object, e As EventArgs) Handles btnSaSearchById.Click
        dgvSaEmployees.AutoGenerateColumns = False
        con.Open()
        Dim cmd = New SqlCommand("GetEmployeeById", con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("EmpId", Convert.ToInt32(txtSaSearchEmpById.Text.Trim()))
        cmd.ExecuteNonQuery()
        con.Close()
        Dim dt = New DataTable()
        Dim da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvSaEmployees.DataSource = dt
    End Sub
    'Show Monthly Salary
    Private Sub btnSaShowMoSalary_Click(sender As Object, e As EventArgs) Handles btnSaShowMoSalary.Click
        Dim dailySalary = Convert.ToDouble(dgvSaEmployees.Rows(0).Cells(4).Value)
        Dim LateTimes = Convert.ToDouble(dgvSaEmployees.Rows(0).Cells(5).Value)
        Dim WorkingDays = Convert.ToDouble(dgvSaEmployees.Rows(0).Cells(6).Value)
        Dim MonthlySalary = dailySalary * WorkingDays - LateTimes * 2
        dgvSaEmployees.Rows(0).Cells(8).Value = MonthlySalary
    End Sub
    'Export to Excel file
    Private Sub btnSaExportToExcel_Click(sender As Object, e As EventArgs) Handles btnSaExportToExcel.Click
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
                'Export header from Datagridview.
                For i = 0 To dgvSaEmployees.ColumnCount - 1
                    worksheet.Cells(1, i + 1) = dgvSaEmployees.Columns(i).HeaderText
                Next
                'Export content from Datagridview
                For i = 0 To dgvSaEmployees.RowCount - 1
                    '"-4" because we do not need to see 3 last columns
                    For j = 0 To dgvSaEmployees.ColumnCount - 1
                        worksheet.Cells(i + 2, j + 1) = dgvSaEmployees.Rows(i).Cells(j).Value?.ToString()
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
    Private Sub btnSaExportToPDF_Click(sender As Object, e As EventArgs) Handles btnSaExportToPDF.Click
        If dgvSaEmployees.Rows.Count > 0 Then
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
                               New PdfPTable(dgvSaEmployees.Columns.Count)
                        pdfPTable.DefaultCell.Padding = 2
                        pdfPTable.WidthPercentage = 100
                        pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT

                        For Each col In dgvSaEmployees.Columns
                            Dim PdfPCell =
                                   New PdfPCell(New Phrase(CStr(col.HeaderText)))
                            pdfPTable.AddCell(PdfPCell)
                        Next

                        For Each row In dgvSaEmployees.Rows
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
        Dim Bitmap = New Bitmap(dgvSaEmployees.Width, dgvSaEmployees.Height)
        dgvSaEmployees.DrawToBitmap(Bitmap,
                New System.Drawing.Rectangle(0, 0, dgvSaEmployees.Width, dgvSaEmployees.Height))
        e.Graphics.DrawImage(Bitmap, 60, 200)
        ' Print Header
        e.Graphics.DrawString("Salary",
                New System.Drawing.Font("Verdana", 25, FontStyle.Bold), Brushes.Black,
                New Point(50, 50))
    End Sub

    'Print
    Private Sub btnSaPrint_Click(sender As Object, e As EventArgs) Handles btnSaPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Show()
    End Sub

End Class