Public Class Form29
    Private Sub Form29_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "schoolbdDataSet.Расписание_занятий". При необходимости она может быть перемещена или удалена.
        Me.Расписание_занятийTableAdapter.Fill(Me.schoolbdDataSet.Расписание_занятий)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class