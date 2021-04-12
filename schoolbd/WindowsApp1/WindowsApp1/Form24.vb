Public Class Form24
    Public Property Расписание_занятийBindingSource As Object

    Private Sub Form24_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolbdDataSet.Список_классов". При необходимости она может быть перемещена или удалена.
        Me.Расписание_занятийTableAdapter.Fill(Me.SchoolbdDataSet.Расписание_занятий)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = DataGridViewTextBoxColumn1
            Case 1
                Col = DataGridViewTextBoxColumn2
            Case 2
                Col = DataGridViewTextBoxColumn3
            Case 3
                Col = DataGridViewTextBoxColumn4
            Case 4
                Col = DataGridViewTextBoxColumn6
            Case 5
                Col = DataGridViewTextBoxColumn7
            Case 6
                Col = DataGridViewTextBoxColumn8
            Case 7
                Col = DataGridViewTextBoxColumn9
            Case 8
                Col = DataGridViewTextBoxColumn10
            Case 9
                Col = DataGridViewTextBoxColumn11
        End Select
        If RadioButton1.Checked Then
            Расписание_занятийDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            Расписание_занятийDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Function DataGridViewTextBoxColumn11() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Function DataGridViewTextBoxColumn9() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Function DataGridViewTextBoxColumn8() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Function DataGridViewTextBoxColumn7() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Function DataGridViewTextBoxColumn6() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Function DataGridViewTextBoxColumn2() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Function DataGridViewTextBoxColumn4() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Function DataGridViewTextBoxColumn3() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Function DataGridViewTextBoxColumn1() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Function DataGridViewTextBoxColumn10() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Расписание_занятийBindingSource.Filter = "Буква='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Расписание_занятийBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To Расписание_занятийDataGridView.ColumnCount - 1
            For j = 0 To Расписание_занятийDataGridView.RowCount - 1
                Расписание_занятийDataGridView.Item(i, j).Style.BackColor = Color.White
                Расписание_занятийDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To Расписание_занятийDataGridView.ColumnCount - 1
            For j = 0 To Расписание_занятийDataGridView.RowCount - 1
                If InStr(Расписание_занятийDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    Расписание_занятийDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    Расписание_занятийDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form29.Show()
    End Sub

End Class