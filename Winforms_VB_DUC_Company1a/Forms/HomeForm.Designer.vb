<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
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
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.cmbHomeDepartment = New System.Windows.Forms.ComboBox()
        Me.txtSearchEmpByName = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.EmpId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpDOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailySalary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpImagePath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnExportToPDF = New System.Windows.Forms.Button()
        Me.btnExportToExcel = New System.Windows.Forms.Button()
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
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelNavBar.TabIndex = 3
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
        Me.btnNavSalary.BackColor = System.Drawing.Color.Transparent
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
        Me.btnNavHome.BackColor = System.Drawing.Color.Yellow
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
        Me.panelFooter.TabIndex = 5
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
        'btnShowAll
        '
        Me.btnShowAll.BackColor = System.Drawing.Color.Lime
        Me.btnShowAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnShowAll.Location = New System.Drawing.Point(865, 175)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(96, 32)
        Me.btnShowAll.TabIndex = 84
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShowAll.UseVisualStyleBackColor = False
        '
        'cmbHomeDepartment
        '
        Me.cmbHomeDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHomeDepartment.FormattingEnabled = True
        Me.cmbHomeDepartment.Location = New System.Drawing.Point(583, 178)
        Me.cmbHomeDepartment.Name = "cmbHomeDepartment"
        Me.cmbHomeDepartment.Size = New System.Drawing.Size(159, 28)
        Me.cmbHomeDepartment.TabIndex = 79
        '
        'txtSearchEmpByName
        '
        Me.txtSearchEmpByName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchEmpByName.Location = New System.Drawing.Point(186, 178)
        Me.txtSearchEmpByName.Name = "txtSearchEmpByName"
        Me.txtSearchEmpByName.Size = New System.Drawing.Size(176, 26)
        Me.txtSearchEmpByName.TabIndex = 78
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.Location = New System.Drawing.Point(388, 181)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(175, 20)
        Me.label13.TabIndex = 77
        Me.label13.Text = "Filter  by department"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(36, 178)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(143, 20)
        Me.label11.TabIndex = 76
        Me.label11.Text = "Search  by name"
        '
        'dgvEmployees
        '
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpId, Me.EmpName, Me.EmpDOB, Me.EmpGender, Me.EmpAddress, Me.DepartmentName, Me.PositionName, Me.DailySalary, Me.DepartmentId, Me.PositionId, Me.EmpImagePath})
        Me.dgvEmployees.Location = New System.Drawing.Point(40, 223)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.Size = New System.Drawing.Size(921, 274)
        Me.dgvEmployees.TabIndex = 75
        '
        'EmpId
        '
        Me.EmpId.DataPropertyName = "EmpId"
        Me.EmpId.HeaderText = "Id "
        Me.EmpId.Name = "EmpId"
        Me.EmpId.Width = 30
        '
        'EmpName
        '
        Me.EmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmpName.DataPropertyName = "EmpName"
        Me.EmpName.HeaderText = "Name "
        Me.EmpName.Name = "EmpName"
        '
        'EmpDOB
        '
        Me.EmpDOB.DataPropertyName = "EmpDOB"
        Me.EmpDOB.HeaderText = "Date of birth"
        Me.EmpDOB.Name = "EmpDOB"
        Me.EmpDOB.Width = 90
        '
        'EmpGender
        '
        Me.EmpGender.DataPropertyName = "EmpGender"
        Me.EmpGender.HeaderText = "Gender "
        Me.EmpGender.Name = "EmpGender"
        Me.EmpGender.Width = 80
        '
        'EmpAddress
        '
        Me.EmpAddress.DataPropertyName = "EmpAddress"
        Me.EmpAddress.HeaderText = "Address "
        Me.EmpAddress.Name = "EmpAddress"
        Me.EmpAddress.Width = 200
        '
        'DepartmentName
        '
        Me.DepartmentName.DataPropertyName = "DepartmentName"
        Me.DepartmentName.HeaderText = "Department Name "
        Me.DepartmentName.Name = "DepartmentName"
        Me.DepartmentName.Width = 120
        '
        'PositionName
        '
        Me.PositionName.DataPropertyName = "PositionName"
        Me.PositionName.HeaderText = "Position Name "
        Me.PositionName.Name = "PositionName"
        Me.PositionName.Width = 150
        '
        'DailySalary
        '
        Me.DailySalary.DataPropertyName = "DailySalary"
        Me.DailySalary.HeaderText = "Daily Salary ($)"
        Me.DailySalary.Name = "DailySalary"
        Me.DailySalary.Width = 50
        '
        'DepartmentId
        '
        Me.DepartmentId.DataPropertyName = "DepartmentId"
        Me.DepartmentId.HeaderText = "Department Id"
        Me.DepartmentId.Name = "DepartmentId"
        Me.DepartmentId.Visible = False
        Me.DepartmentId.Width = 20
        '
        'PositionId
        '
        Me.PositionId.DataPropertyName = "PositionId"
        Me.PositionId.HeaderText = "Position Id "
        Me.PositionId.Name = "PositionId"
        Me.PositionId.Visible = False
        Me.PositionId.Width = 20
        '
        'EmpImagePath
        '
        Me.EmpImagePath.DataPropertyName = "EmpImagePath"
        Me.EmpImagePath.HeaderText = "EmpImagePath "
        Me.EmpImagePath.Name = "EmpImagePath"
        Me.EmpImagePath.Visible = False
        Me.EmpImagePath.Width = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(386, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(307, 31)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "LIST OF EMPLOYEES"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.home256
        Me.PictureBox8.Location = New System.Drawing.Point(503, 109)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 95
        Me.PictureBox8.TabStop = False
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.Lime
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.filter20_1
        Me.btnFilter.Location = New System.Drawing.Point(757, 175)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(102, 31)
        Me.btnFilter.TabIndex = 83
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Lime
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.print24_1
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(413, 512)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(97, 32)
        Me.btnPrint.TabIndex = 82
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnExportToPDF
        '
        Me.btnExportToPDF.BackColor = System.Drawing.Color.Lime
        Me.btnExportToPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportToPDF.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.pdf24_2
        Me.btnExportToPDF.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExportToPDF.Location = New System.Drawing.Point(222, 512)
        Me.btnExportToPDF.Name = "btnExportToPDF"
        Me.btnExportToPDF.Size = New System.Drawing.Size(166, 32)
        Me.btnExportToPDF.TabIndex = 81
        Me.btnExportToPDF.Text = "Export To PDF"
        Me.btnExportToPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportToPDF.UseVisualStyleBackColor = False
        '
        'btnExportToExcel
        '
        Me.btnExportToExcel.BackColor = System.Drawing.Color.Lime
        Me.btnExportToExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportToExcel.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.excel24_1
        Me.btnExportToExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExportToExcel.Location = New System.Drawing.Point(40, 512)
        Me.btnExportToExcel.Name = "btnExportToExcel"
        Me.btnExportToExcel.Size = New System.Drawing.Size(167, 32)
        Me.btnExportToExcel.TabIndex = 80
        Me.btnExportToExcel.Text = "Export To Excel"
        Me.btnExportToExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportToExcel.UseVisualStyleBackColor = False
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
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 611)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnExportToPDF)
        Me.Controls.Add(Me.btnExportToExcel)
        Me.Controls.Add(Me.cmbHomeDepartment)
        Me.Controls.Add(Me.txtSearchEmpByName)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Controls.Add(Me.panelFooter)
        Me.Controls.Add(Me.panelNavBar)
        Me.Name = "HomeForm"
        Me.Text = "Home"
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
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnShowAll As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnExportToPDF As Button
    Friend WithEvents btnExportToExcel As Button
    Friend WithEvents cmbHomeDepartment As ComboBox
    Friend WithEvents txtSearchEmpByName As TextBox
    Private WithEvents label13 As Label
    Private WithEvents label11 As Label
    Private WithEvents dgvEmployees As DataGridView
    Private WithEvents EmpId As DataGridViewTextBoxColumn
    Private WithEvents EmpName As DataGridViewTextBoxColumn
    Private WithEvents EmpDOB As DataGridViewTextBoxColumn
    Private WithEvents EmpGender As DataGridViewTextBoxColumn
    Private WithEvents EmpAddress As DataGridViewTextBoxColumn
    Private WithEvents DepartmentName As DataGridViewTextBoxColumn
    Private WithEvents PositionName As DataGridViewTextBoxColumn
    Private WithEvents DailySalary As DataGridViewTextBoxColumn
    Private WithEvents DepartmentId As DataGridViewTextBoxColumn
    Private WithEvents PositionId As DataGridViewTextBoxColumn
    Private WithEvents EmpImagePath As DataGridViewTextBoxColumn
    Private WithEvents PictureBox8 As PictureBox
    Private WithEvents Label10 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
