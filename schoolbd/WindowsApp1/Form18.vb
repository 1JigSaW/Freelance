Public Class Form18
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "schoolbdDataSet.Классы". При необходимости она может быть перемещена или удалена.
        Me.КлассыTableAdapter.Fill(Me.schoolbdDataSet.Классы)

    End Sub
End Class