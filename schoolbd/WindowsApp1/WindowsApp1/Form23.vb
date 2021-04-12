Public Class Form23
    Private Sub Form23_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolbdDataSet.Отдел_кадров". При необходимости она может быть перемещена или удалена.
        Me.Отдел_кадровTableAdapter.Fill(Me.SchoolbdDataSet.Отдел_кадров)

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
                Col = DataGridViewTextBoxColumn5
            Case 5
                Col = DataGridViewTextBoxColumn6
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
            Отдел_кадровDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            Отдел_кадровDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Отдел_кадровBindingSource.Filter = "Наименование должности='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Отдел_кадровBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To Отдел_кадровDataGridView.ColumnCount - 1
            For j = 0 To Отдел_кадровDataGridView.RowCount - 1
                Отдел_кадровDataGridView.Item(i, j).Style.BackColor = Color.White
                Отдел_кадровDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To Отдел_кадровDataGridView.ColumnCount - 1
            For j = 0 To Отдел_кадровDataGridView.RowCount - 1
                If InStr(Отдел_кадровDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    Отдел_кадровDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    Отдел_кадровDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form28.Show()
    End Sub

    Private Sub Отдел_кадровDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Отдел_кадровDataGridView.CellContentClick

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form34.Show()
    End Sub
End Class