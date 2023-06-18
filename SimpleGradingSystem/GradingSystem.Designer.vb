<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradingSystem
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Exam_TB = New System.Windows.Forms.TextBox()
        Me.Project_TB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ClassPar_TB = New System.Windows.Forms.TextBox()
        Me.Quiz_TB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Update_TB = New System.Windows.Forms.Button()
        Me.Clear_TB = New System.Windows.Forms.Button()
        Me.Delete_TB = New System.Windows.Forms.Button()
        Me.Average_TB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Exam_Grade_TB = New System.Windows.Forms.TextBox()
        Me.Project_Grade_TB = New System.Windows.Forms.TextBox()
        Me.Quiz_Grade_TB = New System.Windows.Forms.TextBox()
        Me.ClassPar_Grade_TB = New System.Windows.Forms.TextBox()
        Me.Exam_Letter_TB = New System.Windows.Forms.TextBox()
        Me.Project_Letter_TB = New System.Windows.Forms.TextBox()
        Me.Quiz_Letter_TB = New System.Windows.Forms.TextBox()
        Me.ClassPar_Letter_TB = New System.Windows.Forms.TextBox()
        Me.Average_Grade_TB = New System.Windows.Forms.TextBox()
        Me.Average_Letter_TB = New System.Windows.Forms.TextBox()
        Me.Grade_DGV = New System.Windows.Forms.DataGridView()
        Me.Student_TB = New System.Windows.Forms.Button()
        Me.StudNo_TB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Save_TB = New System.Windows.Forms.Button()
        CType(Me.Grade_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Exams:"
        '
        'Exam_TB
        '
        Me.Exam_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam_TB.Location = New System.Drawing.Point(32, 72)
        Me.Exam_TB.Name = "Exam_TB"
        Me.Exam_TB.Size = New System.Drawing.Size(85, 22)
        Me.Exam_TB.TabIndex = 1
        '
        'Project_TB
        '
        Me.Project_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Project_TB.Location = New System.Drawing.Point(32, 116)
        Me.Project_TB.Name = "Project_TB"
        Me.Project_TB.Size = New System.Drawing.Size(85, 22)
        Me.Project_TB.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Projects:"
        '
        'ClassPar_TB
        '
        Me.ClassPar_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassPar_TB.Location = New System.Drawing.Point(32, 204)
        Me.ClassPar_TB.Name = "ClassPar_TB"
        Me.ClassPar_TB.Size = New System.Drawing.Size(85, 22)
        Me.ClassPar_TB.TabIndex = 8
        '
        'Quiz_TB
        '
        Me.Quiz_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quiz_TB.Location = New System.Drawing.Point(32, 160)
        Me.Quiz_TB.Name = "Quiz_TB"
        Me.Quiz_TB.Size = New System.Drawing.Size(85, 22)
        Me.Quiz_TB.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Quizzes:"
        '
        'Update_TB
        '
        Me.Update_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_TB.Location = New System.Drawing.Point(113, 305)
        Me.Update_TB.Name = "Update_TB"
        Me.Update_TB.Size = New System.Drawing.Size(75, 23)
        Me.Update_TB.TabIndex = 17
        Me.Update_TB.Text = "Update"
        Me.Update_TB.UseVisualStyleBackColor = True
        '
        'Clear_TB
        '
        Me.Clear_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_TB.Location = New System.Drawing.Point(113, 334)
        Me.Clear_TB.Name = "Clear_TB"
        Me.Clear_TB.Size = New System.Drawing.Size(75, 23)
        Me.Clear_TB.TabIndex = 19
        Me.Clear_TB.Text = "Clear"
        Me.Clear_TB.UseVisualStyleBackColor = True
        '
        'Delete_TB
        '
        Me.Delete_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_TB.Location = New System.Drawing.Point(32, 334)
        Me.Delete_TB.Name = "Delete_TB"
        Me.Delete_TB.Size = New System.Drawing.Size(75, 23)
        Me.Delete_TB.TabIndex = 18
        Me.Delete_TB.Text = "Delete"
        Me.Delete_TB.UseVisualStyleBackColor = True
        '
        'Average_TB
        '
        Me.Average_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Average_TB.Location = New System.Drawing.Point(32, 248)
        Me.Average_TB.Name = "Average_TB"
        Me.Average_TB.Size = New System.Drawing.Size(85, 22)
        Me.Average_TB.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Average:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Class Participation:"
        '
        'Exam_Grade_TB
        '
        Me.Exam_Grade_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Exam_Grade_TB.Enabled = False
        Me.Exam_Grade_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam_Grade_TB.ForeColor = System.Drawing.Color.Transparent
        Me.Exam_Grade_TB.Location = New System.Drawing.Point(123, 72)
        Me.Exam_Grade_TB.Name = "Exam_Grade_TB"
        Me.Exam_Grade_TB.Size = New System.Drawing.Size(31, 22)
        Me.Exam_Grade_TB.TabIndex = 9
        '
        'Project_Grade_TB
        '
        Me.Project_Grade_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Project_Grade_TB.Enabled = False
        Me.Project_Grade_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Project_Grade_TB.ForeColor = System.Drawing.Color.Transparent
        Me.Project_Grade_TB.Location = New System.Drawing.Point(123, 116)
        Me.Project_Grade_TB.Name = "Project_Grade_TB"
        Me.Project_Grade_TB.Size = New System.Drawing.Size(31, 22)
        Me.Project_Grade_TB.TabIndex = 10
        '
        'Quiz_Grade_TB
        '
        Me.Quiz_Grade_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Quiz_Grade_TB.Enabled = False
        Me.Quiz_Grade_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quiz_Grade_TB.ForeColor = System.Drawing.Color.Transparent
        Me.Quiz_Grade_TB.Location = New System.Drawing.Point(123, 160)
        Me.Quiz_Grade_TB.Name = "Quiz_Grade_TB"
        Me.Quiz_Grade_TB.Size = New System.Drawing.Size(31, 22)
        Me.Quiz_Grade_TB.TabIndex = 11
        '
        'ClassPar_Grade_TB
        '
        Me.ClassPar_Grade_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClassPar_Grade_TB.Enabled = False
        Me.ClassPar_Grade_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassPar_Grade_TB.ForeColor = System.Drawing.Color.Transparent
        Me.ClassPar_Grade_TB.Location = New System.Drawing.Point(123, 204)
        Me.ClassPar_Grade_TB.Name = "ClassPar_Grade_TB"
        Me.ClassPar_Grade_TB.Size = New System.Drawing.Size(31, 22)
        Me.ClassPar_Grade_TB.TabIndex = 12
        '
        'Exam_Letter_TB
        '
        Me.Exam_Letter_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Exam_Letter_TB.Enabled = False
        Me.Exam_Letter_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam_Letter_TB.Location = New System.Drawing.Point(160, 72)
        Me.Exam_Letter_TB.Name = "Exam_Letter_TB"
        Me.Exam_Letter_TB.Size = New System.Drawing.Size(31, 22)
        Me.Exam_Letter_TB.TabIndex = 13
        '
        'Project_Letter_TB
        '
        Me.Project_Letter_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Project_Letter_TB.Enabled = False
        Me.Project_Letter_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Project_Letter_TB.Location = New System.Drawing.Point(160, 116)
        Me.Project_Letter_TB.Name = "Project_Letter_TB"
        Me.Project_Letter_TB.Size = New System.Drawing.Size(31, 22)
        Me.Project_Letter_TB.TabIndex = 14
        '
        'Quiz_Letter_TB
        '
        Me.Quiz_Letter_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Quiz_Letter_TB.Enabled = False
        Me.Quiz_Letter_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quiz_Letter_TB.Location = New System.Drawing.Point(160, 160)
        Me.Quiz_Letter_TB.Name = "Quiz_Letter_TB"
        Me.Quiz_Letter_TB.Size = New System.Drawing.Size(31, 22)
        Me.Quiz_Letter_TB.TabIndex = 15
        '
        'ClassPar_Letter_TB
        '
        Me.ClassPar_Letter_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClassPar_Letter_TB.Enabled = False
        Me.ClassPar_Letter_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassPar_Letter_TB.Location = New System.Drawing.Point(160, 204)
        Me.ClassPar_Letter_TB.Name = "ClassPar_Letter_TB"
        Me.ClassPar_Letter_TB.Size = New System.Drawing.Size(31, 22)
        Me.ClassPar_Letter_TB.TabIndex = 16
        '
        'Average_Grade_TB
        '
        Me.Average_Grade_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Average_Grade_TB.Enabled = False
        Me.Average_Grade_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Average_Grade_TB.ForeColor = System.Drawing.Color.Transparent
        Me.Average_Grade_TB.Location = New System.Drawing.Point(123, 248)
        Me.Average_Grade_TB.Name = "Average_Grade_TB"
        Me.Average_Grade_TB.Size = New System.Drawing.Size(31, 22)
        Me.Average_Grade_TB.TabIndex = 24
        '
        'Average_Letter_TB
        '
        Me.Average_Letter_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Average_Letter_TB.Enabled = False
        Me.Average_Letter_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Average_Letter_TB.Location = New System.Drawing.Point(160, 248)
        Me.Average_Letter_TB.Name = "Average_Letter_TB"
        Me.Average_Letter_TB.Size = New System.Drawing.Size(31, 22)
        Me.Average_Letter_TB.TabIndex = 25
        '
        'Grade_DGV
        '
        Me.Grade_DGV.AllowUserToAddRows = False
        Me.Grade_DGV.AllowUserToDeleteRows = False
        Me.Grade_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grade_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grade_DGV.Location = New System.Drawing.Point(222, 12)
        Me.Grade_DGV.Name = "Grade_DGV"
        Me.Grade_DGV.RowHeadersVisible = False
        Me.Grade_DGV.Size = New System.Drawing.Size(397, 345)
        Me.Grade_DGV.TabIndex = 26
        '
        'Student_TB
        '
        Me.Student_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_TB.Location = New System.Drawing.Point(12, 374)
        Me.Student_TB.Name = "Student_TB"
        Me.Student_TB.Size = New System.Drawing.Size(95, 23)
        Me.Student_TB.TabIndex = 55
        Me.Student_TB.Text = "Student"
        Me.Student_TB.UseVisualStyleBackColor = True
        '
        'StudNo_TB
        '
        Me.StudNo_TB.Enabled = False
        Me.StudNo_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudNo_TB.Location = New System.Drawing.Point(32, 28)
        Me.StudNo_TB.Name = "StudNo_TB"
        Me.StudNo_TB.Size = New System.Drawing.Size(156, 22)
        Me.StudNo_TB.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Student No."
        '
        'Save_TB
        '
        Me.Save_TB.BackColor = System.Drawing.Color.Transparent
        Me.Save_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_TB.Location = New System.Drawing.Point(32, 305)
        Me.Save_TB.Name = "Save_TB"
        Me.Save_TB.Size = New System.Drawing.Size(75, 23)
        Me.Save_TB.TabIndex = 58
        Me.Save_TB.Text = "Save"
        Me.Save_TB.UseVisualStyleBackColor = False
        '
        'GradingSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 415)
        Me.Controls.Add(Me.Save_TB)
        Me.Controls.Add(Me.StudNo_TB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Student_TB)
        Me.Controls.Add(Me.Grade_DGV)
        Me.Controls.Add(Me.Average_Letter_TB)
        Me.Controls.Add(Me.Average_Grade_TB)
        Me.Controls.Add(Me.Average_TB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Clear_TB)
        Me.Controls.Add(Me.Delete_TB)
        Me.Controls.Add(Me.Update_TB)
        Me.Controls.Add(Me.ClassPar_Letter_TB)
        Me.Controls.Add(Me.Quiz_Letter_TB)
        Me.Controls.Add(Me.Project_Letter_TB)
        Me.Controls.Add(Me.Exam_Letter_TB)
        Me.Controls.Add(Me.ClassPar_Grade_TB)
        Me.Controls.Add(Me.Quiz_Grade_TB)
        Me.Controls.Add(Me.Project_Grade_TB)
        Me.Controls.Add(Me.Exam_Grade_TB)
        Me.Controls.Add(Me.ClassPar_TB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Quiz_TB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Project_TB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Exam_TB)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "GradingSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grading System"
        CType(Me.Grade_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Exam_TB As TextBox
    Friend WithEvents Project_TB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ClassPar_TB As TextBox
    Friend WithEvents Quiz_TB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Update_TB As Button
    Friend WithEvents Clear_TB As Button
    Friend WithEvents Delete_TB As Button
    Friend WithEvents Average_TB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Exam_Grade_TB As TextBox
    Friend WithEvents Project_Grade_TB As TextBox
    Friend WithEvents Quiz_Grade_TB As TextBox
    Friend WithEvents ClassPar_Grade_TB As TextBox
    Friend WithEvents Exam_Letter_TB As TextBox
    Friend WithEvents Project_Letter_TB As TextBox
    Friend WithEvents Quiz_Letter_TB As TextBox
    Friend WithEvents ClassPar_Letter_TB As TextBox
    Friend WithEvents Average_Grade_TB As TextBox
    Friend WithEvents Average_Letter_TB As TextBox
    Friend WithEvents Grade_DGV As DataGridView
    Friend WithEvents Student_TB As Button
    Friend WithEvents StudNo_TB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Save_TB As Button
End Class
