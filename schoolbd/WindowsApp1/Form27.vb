﻿Public Class Form27
    Public Property Список_учениковBindingSource As Object

    Private Sub Form27_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolbdDataSet.Список_учеников". При необходимости она может быть перемещена или удалена.
        Me.Список_учениковTableAdapter.Fill(Me.SchoolbdDataSet.Список_учеников)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = DataGridView1TextBoxColumn3()
            Case 1
                Col = DataGridView1TextBoxColumn4()
            Case 2
                Col = DataGridView1TextBoxColumn5()
            Case 3
                Col = DataGridView1TextBoxColumn6()
            Case 4
                Col = DataGridView1TextBoxColumn7()
            Case 5
                Col = DataGridView1TextBoxColumn8()
            Case 6
                Col = DataGridViewTextBoxColumn9()
            Case 7
                Col = DataGridViewTextBoxColumn10()
            Case 8
                Col = DataGridViewTextBoxColumn11()
        End Select
        If RadioButton1.Checked Then
            Список_учениковDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            Список_учениковDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Function DataGridViewTextBoxColumn11() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Function DataGridViewTextBoxColumn10() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Function DataGridViewTextBoxColumn9() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Function DataGridView1TextBoxColumn7() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Function DataGridView1TextBoxColumn8() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Function DataGridView1TextBoxColumn5() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Function DataGridView1TextBoxColumn6() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Function DataGridView1TextBoxColumn4() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Function DataGridView1TextBoxColumn3() As DataGridViewColumn
        Throw New NotImplementedException()
    End Function

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Список_учениковBindingSource.Filter = "Буква='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Список_учениковBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To Список_учениковDataGridView.ColumnCount - 1
            For j = 0 To Список_учениковDataGridView.RowCount - 1
                Список_учениковDataGridView.Item(i, j).Style.BackColor = Color.White
                Список_учениковDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To Список_учениковDataGridView.ColumnCount - 1
            For j = 0 To Список_учениковDataGridView.RowCount - 1
                If InStr(Список_учениковDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    Список_учениковDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    Список_учениковDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form32.Show()
    End Sub

    Private Sub Список_учениковDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Список_учениковDataGridView.CellContentClick

    End Sub
End Class