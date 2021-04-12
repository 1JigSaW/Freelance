Public Class Form6
    Private Sub ПредметыBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ПредметыBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ПредметыBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolbdDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolbdDataSet.Предметы". При необходимости она может быть перемещена или удалена.
        Me.ПредметыTableAdapter.Fill(Me.SchoolbdDataSet.Предметы)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ПредметыBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ПредметыBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ПредметыBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ПредметыBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ПредметыBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ПредметыBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.ПредметыBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolbdDataSet)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form13.Show()
    End Sub
End Class