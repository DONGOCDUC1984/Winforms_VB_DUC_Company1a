<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PositionForm
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
        Me.dgvPositions = New System.Windows.Forms.DataGridView()
        Me.PoPositionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoPositionName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoDepartmentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoDailySalary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoDepartmentId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbPoDepartment = New System.Windows.Forms.ComboBox()
        Me.txtPoPositionName = New System.Windows.Forms.TextBox()
        Me.txtPoDailySalary = New System.Windows.Forms.TextBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.btnResetPo = New System.Windows.Forms.Button()
        Me.btnDeletePo = New System.Windows.Forms.Button()
        Me.btnSavePo = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.panelNavBar.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFooter.SuspendLayout()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPositions, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnNavPosition.BackColor = System.Drawing.Color.Yellow
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
        'dgvPositions
        '
        Me.dgvPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPositions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PoPositionId, Me.PoPositionName, Me.PoDepartmentName, Me.PoDailySalary, Me.PoDepartmentId})
        Me.dgvPositions.Location = New System.Drawing.Point(395, 219)
        Me.dgvPositions.Name = "dgvPositions"
        Me.dgvPositions.Size = New System.Drawing.Size(509, 150)
        Me.dgvPositions.TabIndex = 84
        '
        'PoPositionId
        '
        Me.PoPositionId.DataPropertyName = "PositionId"
        Me.PoPositionId.HeaderText = "Id "
        Me.PoPositionId.Name = "PoPositionId"
        Me.PoPositionId.Width = 40
        '
        'PoPositionName
        '
        Me.PoPositionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PoPositionName.DataPropertyName = "PositionName"
        Me.PoPositionName.HeaderText = "Name "
        Me.PoPositionName.Name = "PoPositionName"
        '
        'PoDepartmentName
        '
        Me.PoDepartmentName.DataPropertyName = "DepartmentName"
        Me.PoDepartmentName.HeaderText = "Department Name "
        Me.PoDepartmentName.Name = "PoDepartmentName"
        Me.PoDepartmentName.Width = 150
        '
        'PoDailySalary
        '
        Me.PoDailySalary.DataPropertyName = "DailySalary"
        Me.PoDailySalary.HeaderText = "Daily Salary "
        Me.PoDailySalary.Name = "PoDailySalary"
        '
        'PoDepartmentId
        '
        Me.PoDepartmentId.DataPropertyName = "DepartmentId"
        Me.PoDepartmentId.HeaderText = "Department Id "
        Me.PoDepartmentId.Name = "PoDepartmentId"
        Me.PoDepartmentId.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Name"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(24, 267)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(104, 20)
        Me.label5.TabIndex = 87
        Me.label5.Text = "Department"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Daily Salary"
        '
        'cmbPoDepartment
        '
        Me.cmbPoDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPoDepartment.FormattingEnabled = True
        Me.cmbPoDepartment.Location = New System.Drawing.Point(142, 259)
        Me.cmbPoDepartment.Name = "cmbPoDepartment"
        Me.cmbPoDepartment.Size = New System.Drawing.Size(228, 28)
        Me.cmbPoDepartment.TabIndex = 91
        '
        'txtPoPositionName
        '
        Me.txtPoPositionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoPositionName.Location = New System.Drawing.Point(142, 219)
        Me.txtPoPositionName.Name = "txtPoPositionName"
        Me.txtPoPositionName.Size = New System.Drawing.Size(228, 26)
        Me.txtPoPositionName.TabIndex = 92
        '
        'txtPoDailySalary
        '
        Me.txtPoDailySalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoDailySalary.Location = New System.Drawing.Point(142, 320)
        Me.txtPoDailySalary.Name = "txtPoDailySalary"
        Me.txtPoDailySalary.Size = New System.Drawing.Size(228, 26)
        Me.txtPoDailySalary.TabIndex = 93
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.work256
        Me.PictureBox8.Location = New System.Drawing.Point(440, 131)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 85
        Me.PictureBox8.TabStop = False
        '
        'btnResetPo
        '
        Me.btnResetPo.BackColor = System.Drawing.Color.Lime
        Me.btnResetPo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetPo.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.refresh24
        Me.btnResetPo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnResetPo.Location = New System.Drawing.Point(255, 370)
        Me.btnResetPo.Name = "btnResetPo"
        Me.btnResetPo.Size = New System.Drawing.Size(97, 32)
        Me.btnResetPo.TabIndex = 96
        Me.btnResetPo.Text = "Reset"
        Me.btnResetPo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResetPo.UseVisualStyleBackColor = False
        '
        'btnDeletePo
        '
        Me.btnDeletePo.BackColor = System.Drawing.Color.Red
        Me.btnDeletePo.Enabled = False
        Me.btnDeletePo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePo.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.bin24
        Me.btnDeletePo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDeletePo.Location = New System.Drawing.Point(142, 370)
        Me.btnDeletePo.Name = "btnDeletePo"
        Me.btnDeletePo.Size = New System.Drawing.Size(97, 32)
        Me.btnDeletePo.TabIndex = 95
        Me.btnDeletePo.Text = "Delete"
        Me.btnDeletePo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeletePo.UseVisualStyleBackColor = False
        '
        'btnSavePo
        '
        Me.btnSavePo.BackColor = System.Drawing.Color.Lime
        Me.btnSavePo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePo.Image = Global.Winforms_VB_DUC_Company1a.My.Resources.Resources.save24_1
        Me.btnSavePo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSavePo.Location = New System.Drawing.Point(29, 370)
        Me.btnSavePo.Name = "btnSavePo"
        Me.btnSavePo.Size = New System.Drawing.Size(100, 32)
        Me.btnSavePo.TabIndex = 94
        Me.btnSavePo.Text = "Save"
        Me.btnSavePo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSavePo.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(389, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 31)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "POSITION"
        '
        'PositionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 611)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnResetPo)
        Me.Controls.Add(Me.btnDeletePo)
        Me.Controls.Add(Me.btnSavePo)
        Me.Controls.Add(Me.txtPoDailySalary)
        Me.Controls.Add(Me.txtPoPositionName)
        Me.Controls.Add(Me.cmbPoDepartment)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.dgvPositions)
        Me.Controls.Add(Me.panelFooter)
        Me.Controls.Add(Me.panelNavBar)
        Me.Name = "PositionForm"
        Me.Text = "Position"
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
        CType(Me.dgvPositions, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents PictureBox8 As PictureBox
    Private WithEvents dgvPositions As DataGridView
    Private WithEvents PoPositionId As DataGridViewTextBoxColumn
    Private WithEvents PoPositionName As DataGridViewTextBoxColumn
    Private WithEvents PoDepartmentName As DataGridViewTextBoxColumn
    Private WithEvents PoDailySalary As DataGridViewTextBoxColumn
    Private WithEvents PoDepartmentId As DataGridViewTextBoxColumn
    Private WithEvents Label4 As Label
    Private WithEvents label5 As Label
    Private WithEvents Label6 As Label
    Friend WithEvents cmbPoDepartment As ComboBox
    Friend WithEvents txtPoPositionName As TextBox
    Friend WithEvents txtPoDailySalary As TextBox
    Friend WithEvents btnResetPo As Button
    Friend WithEvents btnDeletePo As Button
    Friend WithEvents btnSavePo As Button
    Private WithEvents Label10 As Label
End Class
