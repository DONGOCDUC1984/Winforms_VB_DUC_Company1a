<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalaryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalaryForm))
        Me.panelNavBar = New System.Windows.Forms.Panel()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.btnNavCrystalReport = New System.Windows.Forms.Button()
        Me.btnNavChart = New System.Windows.Forms.Button()
        Me.btnNavPosition = New System.Windows.Forms.Button()
        Me.btnNavDepartment = New System.Windows.Forms.Button()
        Me.btnNavSalary = New System.Windows.Forms.Button()
        Me.btnNavCRUD = New System.Windows.Forms.Button()
        Me.btnNavHome = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelFooter = New System.Windows.Forms.Panel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.pictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pictureBox6 = New System.Windows.Forms.PictureBox()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dgvSaEmployees = New System.Windows.Forms.DataGridView()
        Me.dataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LateTimes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkingDays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Month = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlySalary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSaSearchEmpById = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.btnSaShowMoSalary = New System.Windows.Forms.Button()
        Me.btnSaSearchById = New System.Windows.Forms.Button()
        Me.btnSaPrint = New System.Windows.Forms.Button()
        Me.btnSaExportToPDF = New System.Windows.Forms.Button()
        Me.btnSaExportToExcel = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.panelNavBar.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFooter.SuspendLayout()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSaEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelNavBar
        '
        Me.panelNavBar.BackColor = System.Drawing.Color.SaddleBrown
        Me.panelNavBar.Controls.Add(Me.LabelUser)
        Me.panelNavBar.Controls.Add(Me.PictureBox7)
        Me.panelNavBar.Controls.Add(Me.btnNavCrystalReport)
        Me.panelNavBar.Controls.Add(Me.btnNavChart)
        Me.panelNavBar.Controls.Add(Me.btnNavPosition)
        Me.panelNavBar.Controls.Add(Me.btnNavDepartment)
        Me.panelNavBar.Controls.Add(Me.btnNavSalary)
        Me.panelNavBar.Controls.Add(Me.btnNavCRUD)
        Me.panelNavBar.Controls.Add(Me.btnNavHome)
        Me.panelNavBar.Controls.Add(Me.label1)
        Me.panelNavBar.Controls.Add(Me.pictureBox1)
        Me.panelNavBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelNavBar.Location = New System.Drawing.Point(0, 0)
        Me.panelNavBar.Name = "panelNavBar"
        Me.panelNavBar.Size = New System.Drawing.Size(1164, 55)
        Me.panelNavBar.TabIndex = 4
        '
        'LabelUser
        '
        Me.LabelUser.AutoSize = True
        Me.LabelUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.Location = New System.Drawing.Point(955, 21)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(47, 20)
        Me.LabelUser.TabIndex = 35
        Me.LabelUser.Text = "User"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.user256
        Me.PictureBox7.Location = New System.Drawing.Point(925, 17)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 34
        Me.PictureBox7.TabStop = False
        '
        'btnNavCrystalReport
        '
        Me.btnNavCrystalReport.BackColor = System.Drawing.Color.Transparent
        Me.btnNavCrystalReport.FlatAppearance.BorderSize = 0
        Me.btnNavCrystalReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavCrystalReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavCrystalReport.ForeColor = System.Drawing.Color.Black
        Me.btnNavCrystalReport.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.report24_1
        Me.btnNavCrystalReport.Location = New System.Drawing.Point(810, 0)
        Me.btnNavCrystalReport.Name = "btnNavCrystalReport"
        Me.btnNavCrystalReport.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnNavCrystalReport.Size = New System.Drawing.Size(90, 55)
        Me.btnNavCrystalReport.TabIndex = 6
        Me.btnNavCrystalReport.Text = "Crystal Report"
        Me.btnNavCrystalReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNavCrystalReport.UseVisualStyleBackColor = False
        '
        'btnNavChart
        '
        Me.btnNavChart.BackColor = System.Drawing.Color.Transparent
        Me.btnNavChart.FlatAppearance.BorderSize = 0
        Me.btnNavChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavChart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavChart.ForeColor = System.Drawing.Color.Black
        Me.btnNavChart.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.chart24
        Me.btnNavChart.Location = New System.Drawing.Point(730, 0)
        Me.btnNavChart.Name = "btnNavChart"
        Me.btnNavChart.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnNavChart.Size = New System.Drawing.Size(80, 55)
        Me.btnNavChart.TabIndex = 7
        Me.btnNavChart.Text = "Chart"
        Me.btnNavChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNavChart.UseVisualStyleBackColor = False
        '
        'btnNavPosition
        '
        Me.btnNavPosition.BackColor = System.Drawing.Color.Transparent
        Me.btnNavPosition.FlatAppearance.BorderSize = 0
        Me.btnNavPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavPosition.ForeColor = System.Drawing.Color.Black
        Me.btnNavPosition.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.work24
        Me.btnNavPosition.Location = New System.Drawing.Point(630, 0)
        Me.btnNavPosition.Name = "btnNavPosition"
        Me.btnNavPosition.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnNavPosition.Size = New System.Drawing.Size(100, 55)
        Me.btnNavPosition.TabIndex = 6
        Me.btnNavPosition.Text = "Position"
        Me.btnNavPosition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNavPosition.UseVisualStyleBackColor = False
        '
        'btnNavDepartment
        '
        Me.btnNavDepartment.BackColor = System.Drawing.Color.Transparent
        Me.btnNavDepartment.FlatAppearance.BorderSize = 0
        Me.btnNavDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavDepartment.ForeColor = System.Drawing.Color.Black
        Me.btnNavDepartment.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.people2_24
        Me.btnNavDepartment.Location = New System.Drawing.Point(510, 0)
        Me.btnNavDepartment.Name = "btnNavDepartment"
        Me.btnNavDepartment.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnNavDepartment.Size = New System.Drawing.Size(120, 55)
        Me.btnNavDepartment.TabIndex = 5
        Me.btnNavDepartment.Text = "Department"
        Me.btnNavDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNavDepartment.UseVisualStyleBackColor = False
        '
        'btnNavSalary
        '
        Me.btnNavSalary.BackColor = System.Drawing.Color.Yellow
        Me.btnNavSalary.FlatAppearance.BorderSize = 0
        Me.btnNavSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavSalary.ForeColor = System.Drawing.Color.Black
        Me.btnNavSalary.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.salary24
        Me.btnNavSalary.Location = New System.Drawing.Point(420, 0)
        Me.btnNavSalary.Name = "btnNavSalary"
        Me.btnNavSalary.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnNavSalary.Size = New System.Drawing.Size(90, 55)
        Me.btnNavSalary.TabIndex = 2
        Me.btnNavSalary.Text = "Salary"
        Me.btnNavSalary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNavSalary.UseVisualStyleBackColor = False
        '
        'btnNavCRUD
        '
        Me.btnNavCRUD.BackColor = System.Drawing.Color.Transparent
        Me.btnNavCRUD.FlatAppearance.BorderSize = 0
        Me.btnNavCRUD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavCRUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavCRUD.ForeColor = System.Drawing.Color.Black
        Me.btnNavCRUD.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.people24
        Me.btnNavCRUD.Location = New System.Drawing.Point(300, 0)
        Me.btnNavCRUD.Name = "btnNavCRUD"
        Me.btnNavCRUD.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnNavCRUD.Size = New System.Drawing.Size(120, 55)
        Me.btnNavCRUD.TabIndex = 2
        Me.btnNavCRUD.Text = "Employees"
        Me.btnNavCRUD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNavCRUD.UseVisualStyleBackColor = False
        '
        'btnNavHome
        '
        Me.btnNavHome.BackColor = System.Drawing.Color.Transparent
        Me.btnNavHome.FlatAppearance.BorderSize = 0
        Me.btnNavHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavHome.ForeColor = System.Drawing.Color.Black
        Me.btnNavHome.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.home24
        Me.btnNavHome.Location = New System.Drawing.Point(220, 0)
        Me.btnNavHome.Name = "btnNavHome"
        Me.btnNavHome.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnNavHome.Size = New System.Drawing.Size(80, 55)
        Me.btnNavHome.TabIndex = 2
        Me.btnNavHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNavHome.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label1.Font = New System.Drawing.Font("Elephant", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.label1.Location = New System.Drawing.Point(73, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(142, 18)
        Me.label1.TabIndex = 1
        Me.label1.Text = "DUC COMPANY"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.building2_512
        Me.pictureBox1.Location = New System.Drawing.Point(12, 1)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'panelFooter
        '
        Me.panelFooter.BackColor = System.Drawing.Color.SaddleBrown
        Me.panelFooter.Controls.Add(Me.label3)
        Me.panelFooter.Controls.Add(Me.pictureBox5)
        Me.panelFooter.Controls.Add(Me.pictureBox6)
        Me.panelFooter.Controls.Add(Me.pictureBox4)
        Me.panelFooter.Controls.Add(Me.pictureBox3)
        Me.panelFooter.Controls.Add(Me.label2)
        Me.panelFooter.Controls.Add(Me.pictureBox2)
        Me.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelFooter.Location = New System.Drawing.Point(0, 556)
        Me.panelFooter.Name = "panelFooter"
        Me.panelFooter.Size = New System.Drawing.Size(1164, 55)
        Me.panelFooter.TabIndex = 6
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(239, 18)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(114, 20)
        Me.label3.TabIndex = 6
        Me.label3.Text = "Follow us on:"
        '
        'pictureBox5
        '
        Me.pictureBox5.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.linkedin24
        Me.pictureBox5.Location = New System.Drawing.Point(395, 8)
        Me.pictureBox5.Name = "pictureBox5"
        Me.pictureBox5.Size = New System.Drawing.Size(30, 30)
        Me.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox5.TabIndex = 4
        Me.pictureBox5.TabStop = False
        '
        'pictureBox6
        '
        Me.pictureBox6.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.facebook24
        Me.pictureBox6.Location = New System.Drawing.Point(359, 8)
        Me.pictureBox6.Name = "pictureBox6"
        Me.pictureBox6.Size = New System.Drawing.Size(30, 30)
        Me.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox6.TabIndex = 5
        Me.pictureBox6.TabStop = False
        '
        'pictureBox4
        '
        Me.pictureBox4.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.youtube24
        Me.pictureBox4.Location = New System.Drawing.Point(467, 7)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(30, 30)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox4.TabIndex = 2
        Me.pictureBox4.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.twitter24
        Me.pictureBox3.Location = New System.Drawing.Point(431, 8)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox3.TabIndex = 2
        Me.pictureBox3.TabStop = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label2.Font = New System.Drawing.Font("Elephant", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.LimeGreen
        Me.label2.Location = New System.Drawing.Point(73, 19)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(142, 18)
        Me.label2.TabIndex = 1
        Me.label2.Text = "DUC COMPANY"
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.building2_512
        Me.pictureBox2.Location = New System.Drawing.Point(12, 1)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(55, 55)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 0
        Me.pictureBox2.TabStop = False
        '
        'dgvSaEmployees
        '
        Me.dgvSaEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSaEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataGridViewTextBoxColumn1, Me.dataGridViewTextBoxColumn2, Me.dataGridViewTextBoxColumn6, Me.dataGridViewTextBoxColumn7, Me.dataGridViewTextBoxColumn8, Me.LateTimes, Me.WorkingDays, Me.Month, Me.MonthlySalary})
        Me.dgvSaEmployees.Location = New System.Drawing.Point(29, 313)
        Me.dgvSaEmployees.Name = "dgvSaEmployees"
        Me.dgvSaEmployees.Size = New System.Drawing.Size(878, 110)
        Me.dgvSaEmployees.TabIndex = 61
        '
        'dataGridViewTextBoxColumn1
        '
        Me.dataGridViewTextBoxColumn1.DataPropertyName = "EmpId"
        Me.dataGridViewTextBoxColumn1.HeaderText = "Id "
        Me.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1"
        Me.dataGridViewTextBoxColumn1.Width = 30
        '
        'dataGridViewTextBoxColumn2
        '
        Me.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dataGridViewTextBoxColumn2.DataPropertyName = "EmpName"
        Me.dataGridViewTextBoxColumn2.HeaderText = "Name "
        Me.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2"
        '
        'dataGridViewTextBoxColumn6
        '
        Me.dataGridViewTextBoxColumn6.DataPropertyName = "DepartmentName"
        Me.dataGridViewTextBoxColumn6.HeaderText = "Department Name "
        Me.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6"
        Me.dataGridViewTextBoxColumn6.Width = 150
        '
        'dataGridViewTextBoxColumn7
        '
        Me.dataGridViewTextBoxColumn7.DataPropertyName = "PositionName"
        Me.dataGridViewTextBoxColumn7.HeaderText = "Position Name "
        Me.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7"
        Me.dataGridViewTextBoxColumn7.Width = 150
        '
        'dataGridViewTextBoxColumn8
        '
        Me.dataGridViewTextBoxColumn8.DataPropertyName = "DailySalary"
        Me.dataGridViewTextBoxColumn8.HeaderText = "Daily Salary ($)"
        Me.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8"
        Me.dataGridViewTextBoxColumn8.Width = 80
        '
        'LateTimes
        '
        Me.LateTimes.HeaderText = "Late Times"
        Me.LateTimes.Name = "LateTimes"
        Me.LateTimes.Width = 80
        '
        'WorkingDays
        '
        Me.WorkingDays.HeaderText = "Working Days"
        Me.WorkingDays.Name = "WorkingDays"
        Me.WorkingDays.Width = 80
        '
        'Month
        '
        Me.Month.HeaderText = "Month"
        Me.Month.Name = "Month"
        Me.Month.Width = 60
        '
        'MonthlySalary
        '
        Me.MonthlySalary.HeaderText = "Monthly Salary ($)"
        Me.MonthlySalary.Name = "MonthlySalary"
        Me.MonthlySalary.Width = 80
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(396, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 31)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "SALARY"
        '
        'txtSaSearchEmpById
        '
        Me.txtSaSearchEmpById.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaSearchEmpById.Location = New System.Drawing.Point(159, 244)
        Me.txtSaSearchEmpById.Name = "txtSaSearchEmpById"
        Me.txtSaSearchEmpById.Size = New System.Drawing.Size(141, 26)
        Me.txtSaSearchEmpById.TabIndex = 97
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(25, 247)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(113, 20)
        Me.label11.TabIndex = 98
        Me.label11.Text = "EmployeeId :"
        '
        'btnSaShowMoSalary
        '
        Me.btnSaShowMoSalary.BackColor = System.Drawing.Color.Lime
        Me.btnSaShowMoSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaShowMoSalary.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaShowMoSalary.Location = New System.Drawing.Point(455, 238)
        Me.btnSaShowMoSalary.Name = "btnSaShowMoSalary"
        Me.btnSaShowMoSalary.Size = New System.Drawing.Size(200, 32)
        Me.btnSaShowMoSalary.TabIndex = 100
        Me.btnSaShowMoSalary.Text = "Show Monthly Salary"
        Me.btnSaShowMoSalary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaShowMoSalary.UseVisualStyleBackColor = False
        '
        'btnSaSearchById
        '
        Me.btnSaSearchById.BackColor = System.Drawing.Color.Lime
        Me.btnSaSearchById.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaSearchById.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.search24
        Me.btnSaSearchById.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaSearchById.Location = New System.Drawing.Point(330, 238)
        Me.btnSaSearchById.Name = "btnSaSearchById"
        Me.btnSaSearchById.Size = New System.Drawing.Size(109, 32)
        Me.btnSaSearchById.TabIndex = 99
        Me.btnSaSearchById.Text = "Search"
        Me.btnSaSearchById.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaSearchById.UseVisualStyleBackColor = False
        '
        'btnSaPrint
        '
        Me.btnSaPrint.BackColor = System.Drawing.Color.Lime
        Me.btnSaPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaPrint.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.print24_1
        Me.btnSaPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaPrint.Location = New System.Drawing.Point(402, 442)
        Me.btnSaPrint.Name = "btnSaPrint"
        Me.btnSaPrint.Size = New System.Drawing.Size(97, 32)
        Me.btnSaPrint.TabIndex = 85
        Me.btnSaPrint.Text = "Print"
        Me.btnSaPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaPrint.UseVisualStyleBackColor = False
        '
        'btnSaExportToPDF
        '
        Me.btnSaExportToPDF.BackColor = System.Drawing.Color.Lime
        Me.btnSaExportToPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaExportToPDF.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.pdf24_2
        Me.btnSaExportToPDF.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaExportToPDF.Location = New System.Drawing.Point(211, 442)
        Me.btnSaExportToPDF.Name = "btnSaExportToPDF"
        Me.btnSaExportToPDF.Size = New System.Drawing.Size(166, 32)
        Me.btnSaExportToPDF.TabIndex = 84
        Me.btnSaExportToPDF.Text = "Export To PDF"
        Me.btnSaExportToPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaExportToPDF.UseVisualStyleBackColor = False
        '
        'btnSaExportToExcel
        '
        Me.btnSaExportToExcel.BackColor = System.Drawing.Color.Lime
        Me.btnSaExportToExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaExportToExcel.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.excel24_1
        Me.btnSaExportToExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaExportToExcel.Location = New System.Drawing.Point(29, 442)
        Me.btnSaExportToExcel.Name = "btnSaExportToExcel"
        Me.btnSaExportToExcel.Size = New System.Drawing.Size(167, 32)
        Me.btnSaExportToExcel.TabIndex = 83
        Me.btnSaExportToExcel.Text = "Export To Excel"
        Me.btnSaExportToExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaExportToExcel.UseVisualStyleBackColor = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.salary256
        Me.PictureBox8.Location = New System.Drawing.Point(431, 121)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 62
        Me.PictureBox8.TabStop = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'SalaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 611)
        Me.Controls.Add(Me.btnSaShowMoSalary)
        Me.Controls.Add(Me.btnSaSearchById)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.txtSaSearchEmpById)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnSaPrint)
        Me.Controls.Add(Me.btnSaExportToPDF)
        Me.Controls.Add(Me.btnSaExportToExcel)
        Me.Controls.Add(Me.dgvSaEmployees)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.panelFooter)
        Me.Controls.Add(Me.panelNavBar)
        Me.Name = "SalaryForm"
        Me.Text = "Salary"
        Me.panelNavBar.ResumeLayout(False)
        Me.panelNavBar.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFooter.ResumeLayout(False)
        Me.panelFooter.PerformLayout()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSaEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panelNavBar As Panel
    Friend WithEvents LabelUser As Label
    Private WithEvents PictureBox7 As PictureBox
    Private WithEvents btnNavCrystalReport As Button
    Private WithEvents btnNavChart As Button
    Private WithEvents btnNavPosition As Button
    Private WithEvents btnNavDepartment As Button
    Private WithEvents btnNavSalary As Button
    Private WithEvents btnNavCRUD As Button
    Private WithEvents btnNavHome As Button
    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents panelFooter As Panel
    Private WithEvents label3 As Label
    Private WithEvents pictureBox5 As PictureBox
    Private WithEvents pictureBox6 As PictureBox
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents dgvSaEmployees As DataGridView
    Private WithEvents dataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Private WithEvents dataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Private WithEvents dataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Private WithEvents dataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Private WithEvents dataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Private WithEvents LateTimes As DataGridViewTextBoxColumn
    Private WithEvents WorkingDays As DataGridViewTextBoxColumn
    Private WithEvents Month As DataGridViewTextBoxColumn
    Private WithEvents MonthlySalary As DataGridViewTextBoxColumn
    Private WithEvents PictureBox8 As PictureBox
    Friend WithEvents btnSaPrint As Button
    Friend WithEvents btnSaExportToPDF As Button
    Friend WithEvents btnSaExportToExcel As Button
    Private WithEvents Label10 As Label
    Friend WithEvents txtSaSearchEmpById As TextBox
    Private WithEvents label11 As Label
    Friend WithEvents btnSaShowMoSalary As Button
    Friend WithEvents btnSaSearchById As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
