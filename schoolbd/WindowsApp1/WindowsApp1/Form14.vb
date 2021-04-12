Public Class Form14
    Private Sub УченикиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles УченикиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.УченикиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolbdDataSet)

    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolbdDataSet.Ученики". При необходимости она может быть перемещена или удалена.
        Me.УченикиTableAdapter.Fill(Me.SchoolbdDataSet.Ученики)

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
        End Select
        If RadioButton1.Checked Then
            УченикиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            УченикиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        УченикиBindingSource.Filter = "ФИО='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        УченикиBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To УченикиDataGridView.ColumnCount - 1
            For j = 0 To УченикиDataGridView.RowCount - 1
                УченикиDataGridView.Item(i, j).Style.BackColor = Color.White
                УченикиDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To УченикиDataGridView.ColumnCount - 1
            For j = 0 To УченикиDataGridView.RowCount - 1
                If InStr(УченикиDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    УченикиDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    УченикиDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class