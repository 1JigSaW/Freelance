Public Class Form34
    Private Sub Form34_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "schoolbdDataSet.Отдел_кадров". При необходимости она может быть перемещена или удалена.
        Me.Отдел_кадровTableAdapter.Fill(Me.schoolbdDataSet.Отдел_кадров)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class