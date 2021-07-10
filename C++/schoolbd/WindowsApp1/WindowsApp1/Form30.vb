Public Class Form30
    Private Sub Form30_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "schoolbdDataSet.Список_классов". При необходимости она может быть перемещена или удалена.
        Me.Список_классовTableAdapter.Fill(Me.schoolbdDataSet.Список_классов)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "schoolbdDataSet.Расписание_занятий". При необходимости она может быть перемещена или удалена.
        Me.Расписание_занятийTableAdapter.Fill(Me.schoolbdDataSet.Расписание_занятий)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport
        Me.ReportViewer1.RefreshReport
    End Sub
End Class