Public Class Form11
    Private Sub КлассыBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles КлассыBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.КлассыBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolbdDataSet)

    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolbdDataSet.Классы". При необходимости она может быть перемещена или удалена.
        Me.КлассыTableAdapter.Fill(Me.SchoolbdDataSet.Классы)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = DataGridViewTextBoxColumn4
            Case 1
                Col = DataGridViewTextBoxColumn5
            Case 2
                Col = DataGridViewTextBoxColumn6
            Case 3
                Col = DataGridViewTextBoxColumn7
        End Select
        If RadioButton1.Checked Then
            КлассыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            КлассыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        КлассыBindingSource.Filter = "Наименование='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        КлассыBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To КлассыDataGridView.ColumnCount - 1
            For j = 0 To КлассыDataGridView.RowCount - 1
                КлассыDataGridView.Item(i, j).Style.BackColor = Color.White
                КлассыDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To КлассыDataGridView.ColumnCount - 1
            For j = 0 To КлассыDataGridView.RowCount - 1
                If InStr(КлассыDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    КлассыDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    КлассыDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class