Public Class Form12
    Private Sub СотрудникиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles СотрудникиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.СотрудникиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolbdDataSet)

    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolbdDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
        Me.СотрудникиTableAdapter.Fill(Me.SchoolbdDataSet.Сотрудники)

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
            Case 4
                Col = DataGridViewTextBoxColumn6
            Case 5
                Col = DataGridViewTextBoxColumn7
        End Select
        If RadioButton1.Checked Then
            СотрудникиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            СотрудникиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        СотрудникиBindingSource.Filter = "ФИО='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        СотрудникиBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To СотрудникиDataGridView.ColumnCount - 1
            For j = 0 To СотрудникиDataGridView.RowCount - 1
                СотрудникиDataGridView.Item(i, j).Style.BackColor = Color.White
                СотрудникиDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To СотрудникиDataGridView.ColumnCount - 1
            For j = 0 To СотрудникиDataGridView.RowCount - 1
                If InStr(СотрудникиDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    СотрудникиDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    СотрудникиDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class