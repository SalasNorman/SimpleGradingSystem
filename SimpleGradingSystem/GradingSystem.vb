Public Class GradingSystem
    Dim GradeID As String

    Public Sub Compute1()
        If Exam_TB.Text = "" Or Project_TB.Text = "" Or Quiz_TB.Text = "" Or ClassPar_TB.Text = "" Then
        Else
            Average_TB.Text = CDbl(Exam_TB.Text * 0.5) + CDbl(Project_TB.Text * 0.3) + CDbl(Quiz_TB.Text * 0.1) + CDbl(ClassPar_TB.Text * 0.1)
            GradeInput(Average_TB.Text)
            Average_Grade_TB.Text = point
            Average_Letter_TB.Text = letter
        End If
    End Sub
    Public Sub Retrive1()
        If StudentID <> "" Then
            Retrive0("SELECT grade_id AS [No],exam AS [Exam], project AS [Project], quiz AS [Quiz], class_par AS [Class participation], average_no AS [Average] FROM grade_table WHERE student_id = " & StudentID & " ", Grade_DGV)
        End If
    End Sub

    Public Sub Clear1()
        GradeID = ""
        Exam_TB.Text = ""
        Project_TB.Text = ""
        Quiz_TB.Text = ""
        ClassPar_TB.Text = ""
        Average_TB.Text = ""
    End Sub

    Private Sub GradingSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Retrive1()
    End Sub

    Private Sub Exam_TB_TextChanged(sender As Object, e As EventArgs) Handles Exam_TB.TextChanged
        GradeInput(Exam_TB.Text)
        Exam_Grade_TB.Text = point
        Exam_Letter_TB.Text = letter
        Compute1()
    End Sub

    Private Sub Project_TB_TextChanged(sender As Object, e As EventArgs) Handles Project_TB.TextChanged
        GradeInput(Project_TB.Text)
        Project_Grade_TB.Text = point
        Project_Letter_TB.Text = letter
        Compute1()
    End Sub

    Private Sub Quiz_TB_TextChanged(sender As Object, e As EventArgs) Handles Quiz_TB.TextChanged
        GradeInput(Quiz_TB.Text)
        Quiz_Grade_TB.Text = point
        Quiz_Letter_TB.Text = letter
        Compute1()
    End Sub

    Private Sub ClassPar_TB_TextChanged(sender As Object, e As EventArgs) Handles ClassPar_TB.TextChanged
        GradeInput(ClassPar_TB.Text)
        ClassPar_Grade_TB.Text = point
        ClassPar_Letter_TB.Text = letter
        Compute1()
    End Sub

    Private Sub Update_TB_Click(sender As Object, e As EventArgs) Handles Update_TB.Click
        CUD0("UPDATE grade_table SET 
            exam = " & Exam_TB.Text & ", 
            project = " & Project_TB.Text & ", 
            quiz = " & Quiz_TB.Text & ", 
            class_par = " & ClassPar_TB.Text & ", 
            average_no = " & Average_TB.Text & "
            WHERE grade_id = " & GradeID & "
            ", "Updated")
        Retrive1()
        Clear1()
    End Sub

    Private Sub Student_TB_Click(sender As Object, e As EventArgs) Handles Student_TB.Click
        Student.Show()
        Me.Hide()
    End Sub

    Private Sub Grade_DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grade_DGV.CellClick
        GradeID = Grade_DGV.CurrentRow.Cells(0).Value
        Exam_TB.Text = Grade_DGV.CurrentRow.Cells(1).Value
        Project_TB.Text = Grade_DGV.CurrentRow.Cells(2).Value
        Quiz_TB.Text = Grade_DGV.CurrentRow.Cells(3).Value
        ClassPar_TB.Text = Grade_DGV.CurrentRow.Cells(4).Value
        Average_TB.Text = Grade_DGV.CurrentRow.Cells(5).Value
    End Sub

    Private Sub Clear_TB_Click(sender As Object, e As EventArgs) Handles Clear_TB.Click
        Clear1()
        Retrive1()
    End Sub

    Private Sub Save_TB_Click(sender As Object, e As EventArgs) Handles Save_TB.Click
        If Exam_TB.Text = "" Or Project_TB.Text = "" Or Quiz_TB.Text = "" Or ClassPar_TB.Text = "" Then
            MsgBox("Missing Field", MsgBoxStyle.Critical)
        Else
            CUD0("INSERT INTO grade_table (exam, project, quiz, class_par, average_no, student_id) VALUES (
                '" & Exam_TB.Text & "', 
                '" & Project_TB.Text & "', 
                '" & Quiz_TB.Text & "', 
                '" & ClassPar_TB.Text & "', 
                '" & Average_TB.Text & "', 
                '" & StudentID & "') ", "Saved")
            Clear1()
            Retrive1()
        End If
    End Sub

    Private Sub Average_TB_TextChanged(sender As Object, e As EventArgs) Handles Average_TB.TextChanged
        Compute1()
    End Sub
End Class
