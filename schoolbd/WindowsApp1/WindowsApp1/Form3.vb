Public Class Form3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ДолжностиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ДолжностиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ДолжностиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolbdDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolbdDataSet.Должности". При необходимости она может быть перемещена или удалена.
        Me.ДолжностиTableAdapter.Fill(Me.SchoolbdDataSet.Должности)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ДолжностиBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ДолжностиBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ДолжностиBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ДолжностиBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ДолжностиBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ДолжностиBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.ДолжностиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolbdDataSet)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form10.Show()
    End Sub
End Class