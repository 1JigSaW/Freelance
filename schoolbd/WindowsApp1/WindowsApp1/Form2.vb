Public Class Form2
    Private Sub Виды_классовBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Виды_классовBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Виды_классовBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolbdDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolbdDataSet.Классы". При необходимости она может быть перемещена или удалена.
        Me.КлассыTableAdapter.Fill(Me.SchoolbdDataSet.Классы)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolbdDataSet.Виды_классов". При необходимости она может быть перемещена или удалена.
        Me.Виды_классовTableAdapter.Fill(Me.SchoolbdDataSet.Виды_классов)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Виды_классовBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Виды_классовBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Виды_классовBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Виды_классовBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Виды_классовBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Виды_классовBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.Виды_классовBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolbdDataSet)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form9.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form16.Show()
    End Sub
End Class