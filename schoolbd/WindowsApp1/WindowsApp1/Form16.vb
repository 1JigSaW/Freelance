Public Class Form16
    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolbdDataSet.Виды_классов". При необходимости она может быть перемещена или удалена.
        Me.Виды_классовTableAdapter.Fill(Me.SchoolbdDataSet.Виды_классов)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class