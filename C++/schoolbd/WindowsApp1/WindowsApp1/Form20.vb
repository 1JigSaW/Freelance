Public Class Form20
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "schoolbdDataSet.Предметы". При необходимости она может быть перемещена или удалена.
        Me.ПредметыTableAdapter.Fill(Me.schoolbdDataSet.Предметы)

    End Sub
End Class