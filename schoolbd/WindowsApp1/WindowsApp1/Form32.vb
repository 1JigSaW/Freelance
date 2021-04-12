Public Class Form32
    Private Sub Form32_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "schoolbdDataSet.Список_учеников". При необходимости она может быть перемещена или удалена.
        Me.Список_учениковTableAdapter.Fill(Me.schoolbdDataSet.Список_учеников)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class