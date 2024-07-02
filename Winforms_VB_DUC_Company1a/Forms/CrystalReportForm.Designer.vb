<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrystalReportForm
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
        Me.CRViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.panelNavBar.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFooter.SuspendLayout()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnNavCrystalReport.BackColor = System.Drawing.Color.Yellow
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
        'CRViewer1
        '
        Me.CRViewer1.ActiveViewIndex = -1
        Me.CRViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewer1.Location = New System.Drawing.Point(0, 55)
        Me.CRViewer1.Name = "CRViewer1"
        Me.CRViewer1.Size = New System.Drawing.Size(1164, 501)
        Me.CRViewer1.TabIndex = 7
        Me.CRViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'CrystalReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 611)
        Me.Controls.Add(Me.CRViewer1)
        Me.Controls.Add(Me.panelFooter)
        Me.Controls.Add(Me.panelNavBar)
        Me.Name = "CrystalReportForm"
        Me.Text = "Crystal Report"
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
        Me.ResumeLayout(False)

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
    Friend WithEvents CRViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
