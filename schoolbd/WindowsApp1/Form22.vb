Public Class Form22
    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "schoolbdDataSet.Расписание". При необходимости она может быть перемещена или удалена.
        Me.РасписаниеTableAdapter.Fill(Me.schoolbdDataSet.Расписание)

    End Sub
End Class