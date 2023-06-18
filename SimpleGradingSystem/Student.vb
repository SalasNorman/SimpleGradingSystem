Public Class Student

    Public Sub Clear1()
        StudentID = ""
        LastName_TB.Text = ""
        FirstName_TB.Text = ""
        StudentNo_TB.Text = ""
    End Sub

    Public Sub Retrive1()
        Retrive0("SELECT student_id AS [No],student_no AS [Student No], first_name AS [First Name], last_name AS [Last Name] FROM student_table", Student_DGV)
    End Sub
    Private Sub Save_TB_Click(sender As Object, e As EventArgs) Handles Save_TB.Click
        CUD0("INSERT INTO student_table (first_name, last_name, student_no)  
                VALUES ('" & FirstName_TB.Text & "',
                '" & LastName_TB.Text & "', 
                " & StudentNo_TB.Text & ") ",
                "Saved")
        Retrive1()
        Clear1()
    End Sub

    Private Sub Update_TB_Click(sender As Object, e As EventArgs) Handles Update_TB.Click
        CUD0("UPDATE student_table SET 
            first_name = '" & FirstName_TB.Text & "',
            last_name = '" & LastName_TB.Text & "',
            student_no = " & StudentNo_TB.Text & "
            WHERE student_id = " & StudentID & "
            ", "Updated")
        Retrive1()
        Clear1()
    End Sub

    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Retrive1()
        Clear1()
    End Sub

    Private Sub Student_DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Student_DGV.CellClick
        StudentID = Student_DGV.CurrentRow.Cells(0).Value
        StudentNo_TB.Text = Student_DGV.CurrentRow.Cells(1).Value
        FirstName_TB.Text = Student_DGV.CurrentRow.Cells(2).Value
        LastName_TB.Text = Student_DGV.CurrentRow.Cells(3).Value
    End Sub

    Private Sub Delete_TB_Click(sender As Object, e As EventArgs) Handles Delete_TB.Click
        CUD0("DELETE * FROM student_table WHERE student_id = " & StudentID & "", "Deleted")
        Retrive1()
        Clear1()
    End Sub

    Private Sub Clear_TB_Click(sender As Object, e As EventArgs) Handles Clear_TB.Click
        Retrive1()
        Clear1()
    End Sub

    Private Sub Grade_TB_Click(sender As Object, e As EventArgs) Handles Grade_TB.Click
        GradingSystem.Show()
        Me.Hide()
    End Sub

    Private Sub Student_DGV_DoubleClick(sender As Object, e As EventArgs) Handles Student_DGV.DoubleClick
        StudentID = Student_DGV.CurrentRow.Cells(0).Value
        Select0("SELECT student_no FROM student_table WHERE student_id = " & StudentID & "")
        GradingSystem.StudNo_TB.Text = key
        GradingSystem.Retrive1()
        GradingSystem.Show()
        Me.Hide()
    End Sub

    Private Sub Search_TB_TextChanged(sender As Object, e As EventArgs) Handles Search_TB.TextChanged
        Retrive0("SELECT student_id AS [No],student_no AS [Student No], first_name AS [First Name], last_name AS [Last Name] FROM student_table WHERE 
                    first_name LIKE '%" & Search_TB.Text & "%' OR 
                    last_name LIKE '%" & Search_TB.Text & "%' ", Student_DGV)
    End Sub
End Class