Public Class Form9
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Виды_классовBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Виды_классовBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Виды_классовBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolbdDataSet)

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolbdDataSet.Виды_классов". При необходимости она может быть перемещена или удалена.
        Me.Виды_классовTableAdapter.Fill(Me.SchoolbdDataSet.Виды_классов)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Виды_классовDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Виды_классовDataGridView.CellContentClick

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
            Виды_классовDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            Виды_классовDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Виды_классовBindingSource.Filter = "Наименование='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Виды_классовBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To Виды_классовDataGridView.ColumnCount - 1
            For j = 0 To Виды_классовDataGridView.RowCount - 1
                Виды_классовDataGridView.Item(i, j).Style.BackColor = Color.White
                Виды_классовDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To Виды_классовDataGridView.ColumnCount - 1
            For j = 0 To Виды_классовDataGridView.RowCount - 1
                If InStr(Виды_классовDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    Виды_классовDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    Виды_классовDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class