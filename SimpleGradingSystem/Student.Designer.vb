<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Student_DGV = New System.Windows.Forms.DataGridView()
        Me.Search_TB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Clear_TB = New System.Windows.Forms.Button()
        Me.Delete_TB = New System.Windows.Forms.Button()
        Me.Update_TB = New System.Windows.Forms.Button()
        Me.StudentNo_TB = New System.Windows.Forms.TextBox()
        Me.Quiz_TB = New System.Windows.Forms.Label()
        Me.LastName_TB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Save_TB = New System.Windows.Forms.Button()
        Me.FirstName_TB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Grade_TB = New System.Windows.Forms.Button()
        CType(Me.Student_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Student_DGV
        '
        Me.Student_DGV.AllowUserToAddRows = False
        Me.Student_DGV.AllowUserToDeleteRows = False
        Me.Student_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Student_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Student_DGV.Location = New System.Drawing.Point(222, 42)
        Me.Student_DGV.Name = "Student_DGV"
        Me.Student_DGV.RowHeadersVisible = False
        Me.Student_DGV.Size = New System.Drawing.Size(397, 204)
        Me.Student_DGV.TabIndex = 53
        '
        'Search_TB
        '
        Me.Search_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_TB.Location = New System.Drawing.Point(277, 14)
        Me.Search_TB.Name = "Search_TB"
        Me.Search_TB.Size = New System.Drawing.Size(342, 22)
        Me.Search_TB.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(219, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Search:"
        '
        'Clear_TB
        '
        Me.Clear_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_TB.Location = New System.Drawing.Point(113, 183)
        Me.Clear_TB.Name = "Clear_TB"
        Me.Clear_TB.Size = New System.Drawing.Size(75, 23)
        Me.Clear_TB.TabIndex = 46
        Me.Clear_TB.Text = "Clear"
        Me.Clear_TB.UseVisualStyleBackColor = True
        '
        'Delete_TB
        '
        Me.Delete_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_TB.Location = New System.Drawing.Point(32, 183)
        Me.Delete_TB.Name = "Delete_TB"
        Me.Delete_TB.Size = New System.Drawing.Size(75, 23)
        Me.Delete_TB.TabIndex = 45
        Me.Delete_TB.Text = "Delete"
        Me.Delete_TB.UseVisualStyleBackColor = True
        '
        'Update_TB
        '
        Me.Update_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_TB.Location = New System.Drawing.Point(113, 154)
        Me.Update_TB.Name = "Update_TB"
        Me.Update_TB.Size = New System.Drawing.Size(75, 23)
        Me.Update_TB.TabIndex = 44
        Me.Update_TB.Text = "Update"
        Me.Update_TB.UseVisualStyleBackColor = True
        '
        'StudentNo_TB
        '
        Me.StudentNo_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentNo_TB.Location = New System.Drawing.Point(32, 116)
        Me.StudentNo_TB.Name = "StudentNo_TB"
        Me.StudentNo_TB.Size = New System.Drawing.Size(163, 22)
        Me.StudentNo_TB.TabIndex = 33
        '
        'Quiz_TB
        '
        Me.Quiz_TB.AutoSize = True
        Me.Quiz_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quiz_TB.Location = New System.Drawing.Point(12, 97)
        Me.Quiz_TB.Name = "Quiz_TB"
        Me.Quiz_TB.Size = New System.Drawing.Size(80, 16)
        Me.Quiz_TB.TabIndex = 32
        Me.Quiz_TB.Text = "Student No.:"
        '
        'LastName_TB
        '
        Me.LastName_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastName_TB.Location = New System.Drawing.Point(32, 72)
        Me.LastName_TB.Name = "LastName_TB"
        Me.LastName_TB.Size = New System.Drawing.Size(163, 22)
        Me.LastName_TB.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Last Name:"
        '
        'Save_TB
        '
        Me.Save_TB.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Save_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_TB.Location = New System.Drawing.Point(32, 154)
        Me.Save_TB.Name = "Save_TB"
        Me.Save_TB.Size = New System.Drawing.Size(75, 23)
        Me.Save_TB.TabIndex = 29
        Me.Save_TB.Text = "Save"
        Me.Save_TB.UseVisualStyleBackColor = False
        '
        'FirstName_TB
        '
        Me.FirstName_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstName_TB.Location = New System.Drawing.Point(32, 28)
        Me.FirstName_TB.Name = "FirstName_TB"
        Me.FirstName_TB.Size = New System.Drawing.Size(163, 22)
        Me.FirstName_TB.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "First Name:"
        '
        'Grade_TB
        '
        Me.Grade_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grade_TB.Location = New System.Drawing.Point(15, 223)
        Me.Grade_TB.Name = "Grade_TB"
        Me.Grade_TB.Size = New System.Drawing.Size(95, 23)
        Me.Grade_TB.TabIndex = 54
        Me.Grade_TB.Text = "Grade"
        Me.Grade_TB.UseVisualStyleBackColor = True
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 262)
        Me.Controls.Add(Me.Grade_TB)
        Me.Controls.Add(Me.Student_DGV)
        Me.Controls.Add(Me.Search_TB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Clear_TB)
        Me.Controls.Add(Me.Delete_TB)
        Me.Controls.Add(Me.Update_TB)
        Me.Controls.Add(Me.StudentNo_TB)
        Me.Controls.Add(Me.Quiz_TB)
        Me.Controls.Add(Me.LastName_TB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Save_TB)
        Me.Controls.Add(Me.FirstName_TB)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student"
        CType(Me.Student_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Student_DGV As DataGridView
    Friend WithEvents Search_TB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Clear_TB As Button
    Friend WithEvents Delete_TB As Button
    Friend WithEvents Update_TB As Button
    Friend WithEvents StudentNo_TB As TextBox
    Friend WithEvents Quiz_TB As Label
    Friend WithEvents LastName_TB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Save_TB As Button
    Friend WithEvents FirstName_TB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Grade_TB As Button
End Class
