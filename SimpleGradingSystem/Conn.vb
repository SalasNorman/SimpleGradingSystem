Imports System.Data.OleDb
Module conn

    Public strconn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\salas\source\repos\SimpleGradingSystem\SimpleGradingSystem\bin\Debug\SimpleGradingSystem.accdb")
    Public cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Public dt As New DataTable
    Public result As String
    Public key As String

    Public StudentID As String

    'grade point = point And letter grade = letter
    Public point As String
    Public letter As String

    Public Sub Retrive0(ByVal sql As String, ByVal DGV As Object)
        Try
            strconn.Open()
            dt = New DataTable
            cmd.Connection = strconn
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DGV.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            strconn.Close()
        End Try
    End Sub

    'For Create, Update, Delete
    Public Sub CUD0(ByVal sql As String, ByVal ms As String)
        Try
            strconn.Open()
            cmd.Connection = strconn
            cmd.CommandText = sql
            result = cmd.ExecuteNonQuery
            If result = 1 Then
                MsgBox("Successully " & ms)
            Else
                MsgBox("Failed to " & ms)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            strconn.Close()
        End Try
    End Sub

    Public Sub Update0(ByVal sql As String)
        Try
            strconn.Open()
            cmd.Connection = strconn
            cmd.CommandText = sql
            result = cmd.ExecuteNonQuery
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            strconn.Close()
        End Try
    End Sub

    Public Sub Delete0(ByVal sql As String)
        Try
            strconn.Open()
            cmd.Connection = strconn
            cmd.CommandText = sql
            result = cmd.ExecuteNonQuery
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            strconn.Close()
        End Try
    End Sub

    Public Sub Select0(ByVal sql As String)
        Try
            strconn.Open()
            cmd.Connection = strconn
            cmd.CommandText = sql
            key = cmd.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            strconn.Close()
        End Try
    End Sub

    Public Sub GradeInput(ByVal gradein As String)
        If gradein = "" Then
            gradein = ""
        ElseIf gradein >= 98.0 AndAlso gradein <= 100.0 Then
            letter = ("A+")
            point = ("4.0")
        ElseIf gradein >= 95.0 AndAlso gradein <= 98.0 Then
            letter = ("A")
            point = ("4.0")
        ElseIf gradein >= 92.0 AndAlso gradein <= 95.0 Then
            letter = ("A-")
            point = ("3.7")
        ElseIf gradein >= 89.0 AndAlso gradein <= 92.0 Then
            letter = ("B+")
            point = ("3.3")
        ElseIf gradein >= 86.0 AndAlso gradein <= 89.0 Then
            letter = ("B")
            point = ("3.0")
        ElseIf gradein >= 83.0 AndAlso gradein <= 86.0 Then
            letter = ("B-")
            point = ("2.7")
        ElseIf gradein >= 80.0 AndAlso gradein <= 83.0 Then
            letter = ("C+")
            point = ("2.3")
        ElseIf gradein >= 77.0 AndAlso gradein <= 80.0 Then
            letter = ("C")
            point = ("2.0")
        ElseIf gradein >= 74.0 AndAlso gradein <= 77.0 Then
            letter = ("C-")
            point = ("1.7")
        ElseIf gradein >= 71.0 AndAlso gradein <= 74.0 Then
            letter = ("D+")
            point = ("1.3")
        ElseIf gradein >= 68.0 AndAlso gradein <= 71.0 Then
            letter = ("D")
            point = ("1.0")
        ElseIf gradein >= 65.0 AndAlso gradein <= 68.0 Then
            letter = ("D-")
            point = ("0.7")
        Else
            letter = ("F")
            point = ("0.0")
        End If
    End Sub
End Module
