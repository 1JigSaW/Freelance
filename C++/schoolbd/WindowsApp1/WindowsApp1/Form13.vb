Public Class Form13
    Private Sub ПредметыBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ПредметыBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ПредметыBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolbdDataSet)

    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolbdDataSet.Предметы". При необходимости она может быть перемещена или удалена.
        Me.ПредметыTableAdapter.Fill(Me.SchoolbdDataSet.Предметы)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = DataGridViewTextBoxColumn2
            Case 1
                Col = DataGridViewTextBoxColumn3
        End Select
        If RadioButton1.Checked Then
            ПредметыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            ПредметыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ПредметыBindingSource.Filter = "Наименование='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ПредметыBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To ПредметыDataGridView.ColumnCount - 1
            For j = 0 To ПредметыDataGridView.RowCount - 1
                ПредметыDataGridView.Item(i, j).Style.BackColor = Color.White
                ПредметыDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To ПредметыDataGridView.ColumnCount - 1
            For j = 0 To ПредметыDataGridView.RowCount - 1
                If InStr(ПредметыDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    ПредметыDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    ПредметыDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class