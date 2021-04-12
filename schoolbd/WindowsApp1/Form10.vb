Public Class Form10
    Private Sub ДолжностиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ДолжностиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ДолжностиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolbdDataSet)

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolbdDataSet.Должности". При необходимости она может быть перемещена или удалена.
        Me.ДолжностиTableAdapter.Fill(Me.SchoolbdDataSet.Должности)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = DataGridViewTextBoxColumn2
            Case 1
                Col = DataGridViewTextBoxColumn3
            Case 2
                Col = DataGridViewTextBoxColumn4
            Case 3
                Col = DataGridViewTextBoxColumn5
        End Select
        If RadioButton1.Checked Then
            ДолжностиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            ДолжностиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ДолжностиBindingSource.Filter = "Наименование должности='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ДолжностиBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To ДолжностиDataGridView.ColumnCount - 1
            For j = 0 To ДолжностиDataGridView.RowCount - 1
                ДолжностиDataGridView.Item(i, j).Style.BackColor = Color.White
                ДолжностиDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To ДолжностиDataGridView.ColumnCount - 1
            For j = 0 To ДолжностиDataGridView.RowCount - 1
                If InStr(ДолжностиDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    ДолжностиDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    ДолжностиDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub ДолжностиDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ДолжностиDataGridView.CellContentClick

    End Sub
End Class