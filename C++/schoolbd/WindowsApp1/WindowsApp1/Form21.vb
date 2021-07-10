Public Class Form21
    Private Sub Form21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "schoolbdDataSet.Ученики". При необходимости она может быть перемещена или удалена.
        Me.УченикиTableAdapter.Fill(Me.schoolbdDataSet.Ученики)

    End Sub
End Class