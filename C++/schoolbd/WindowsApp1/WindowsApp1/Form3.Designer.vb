<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Наименование_должностиLabel As System.Windows.Forms.Label
        Dim ОкладLabel As System.Windows.Forms.Label
        Dim ОбязанностиLabel As System.Windows.Forms.Label
        Dim ТребованияLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SchoolbdDataSet = New WindowsApp1.schoolbdDataSet()
        Me.ДолжностиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ДолжностиTableAdapter = New WindowsApp1.schoolbdDataSetTableAdapters.ДолжностиTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.schoolbdDataSetTableAdapters.TableAdapterManager()
        Me.ДолжностиBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ДолжностиBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Наименование_должностиTextBox = New System.Windows.Forms.TextBox()
        Me.ОкладTextBox = New System.Windows.Forms.TextBox()
        Me.ОбязанностиTextBox = New System.Windows.Forms.TextBox()
        Me.ТребованияTextBox = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Наименование_должностиLabel = New System.Windows.Forms.Label()
        ОкладLabel = New System.Windows.Forms.Label()
        ОбязанностиLabel = New System.Windows.Forms.Label()
        ТребованияLabel = New System.Windows.Forms.Label()
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ДолжностиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ДолжностиBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ДолжностиBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Наименование_должностиLabel
        '
        Наименование_должностиLabel.AutoSize = True
        Наименование_должностиLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Наименование_должностиLabel.Location = New System.Drawing.Point(69, 170)
        Наименование_должностиLabel.Name = "Наименование_должностиLabel"
        Наименование_должностиLabel.Size = New System.Drawing.Size(267, 25)
        Наименование_должностиLabel.TabIndex = 2
        Наименование_должностиLabel.Text = "Наименование должности:"
        '
        'ОкладLabel
        '
        ОкладLabel.AutoSize = True
        ОкладLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ОкладLabel.Location = New System.Drawing.Point(259, 208)
        ОкладLabel.Name = "ОкладLabel"
        ОкладLabel.Size = New System.Drawing.Size(77, 25)
        ОкладLabel.TabIndex = 4
        ОкладLabel.Text = "Оклад:"
        '
        'ОбязанностиLabel
        '
        ОбязанностиLabel.AutoSize = True
        ОбязанностиLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ОбязанностиLabel.Location = New System.Drawing.Point(194, 247)
        ОбязанностиLabel.Name = "ОбязанностиLabel"
        ОбязанностиLabel.Size = New System.Drawing.Size(142, 25)
        ОбязанностиLabel.TabIndex = 6
        ОбязанностиLabel.Text = "Обязанности:"
        '
        'ТребованияLabel
        '
        ТребованияLabel.AutoSize = True
        ТребованияLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ТребованияLabel.Location = New System.Drawing.Point(209, 284)
        ТребованияLabel.Name = "ТребованияLabel"
        ТребованияLabel.Size = New System.Drawing.Size(127, 25)
        ТребованияLabel.TabIndex = 8
        ТребованияLabel.Text = "Требования:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(288, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Должности"
        '
        'SchoolbdDataSet
        '
        Me.SchoolbdDataSet.DataSetName = "schoolbdDataSet"
        Me.SchoolbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ДолжностиBindingSource
        '
        Me.ДолжностиBindingSource.DataMember = "Должности"
        Me.ДолжностиBindingSource.DataSource = Me.SchoolbdDataSet
        '
        'ДолжностиTableAdapter
        '
        Me.ДолжностиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.schoolbdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Виды_классовTableAdapter = Nothing
        Me.TableAdapterManager.ДолжностиTableAdapter = Me.ДолжностиTableAdapter
        Me.TableAdapterManager.КлассыTableAdapter = Nothing
        Me.TableAdapterManager.ПредметыTableAdapter = Nothing
        Me.TableAdapterManager.РасписаниеTableAdapter = Nothing
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.УченикиTableAdapter = Nothing
        '
        'ДолжностиBindingNavigator
        '
        Me.ДолжностиBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ДолжностиBindingNavigator.BindingSource = Me.ДолжностиBindingSource
        Me.ДолжностиBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ДолжностиBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ДолжностиBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ДолжностиBindingNavigatorSaveItem})
        Me.ДолжностиBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ДолжностиBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ДолжностиBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ДолжностиBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ДолжностиBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ДолжностиBindingNavigator.Name = "ДолжностиBindingNavigator"
        Me.ДолжностиBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ДолжностиBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ДолжностиBindingNavigator.TabIndex = 2
        Me.ДолжностиBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 22)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ДолжностиBindingNavigatorSaveItem
        '
        Me.ДолжностиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ДолжностиBindingNavigatorSaveItem.Image = CType(resources.GetObject("ДолжностиBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ДолжностиBindingNavigatorSaveItem.Name = "ДолжностиBindingNavigatorSaveItem"
        Me.ДолжностиBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ДолжностиBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Наименование_должностиTextBox
        '
        Me.Наименование_должностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ДолжностиBindingSource, "Наименование должности", True))
        Me.Наименование_должностиTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Наименование_должностиTextBox.Location = New System.Drawing.Point(342, 167)
        Me.Наименование_должностиTextBox.Name = "Наименование_должностиTextBox"
        Me.Наименование_должностиTextBox.Size = New System.Drawing.Size(315, 30)
        Me.Наименование_должностиTextBox.TabIndex = 3
        '
        'ОкладTextBox
        '
        Me.ОкладTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ДолжностиBindingSource, "Оклад", True))
        Me.ОкладTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ОкладTextBox.Location = New System.Drawing.Point(342, 205)
        Me.ОкладTextBox.Name = "ОкладTextBox"
        Me.ОкладTextBox.Size = New System.Drawing.Size(315, 30)
        Me.ОкладTextBox.TabIndex = 5
        '
        'ОбязанностиTextBox
        '
        Me.ОбязанностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ДолжностиBindingSource, "Обязанности", True))
        Me.ОбязанностиTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ОбязанностиTextBox.Location = New System.Drawing.Point(342, 244)
        Me.ОбязанностиTextBox.Name = "ОбязанностиTextBox"
        Me.ОбязанностиTextBox.Size = New System.Drawing.Size(315, 30)
        Me.ОбязанностиTextBox.TabIndex = 7
        '
        'ТребованияTextBox
        '
        Me.ТребованияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ДолжностиBindingSource, "Требования", True))
        Me.ТребованияTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ТребованияTextBox.Location = New System.Drawing.Point(342, 281)
        Me.ТребованияTextBox.Name = "ТребованияTextBox"
        Me.ТребованияTextBox.Size = New System.Drawing.Size(315, 30)
        Me.ТребованияTextBox.TabIndex = 9
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(477, 384)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(112, 34)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(349, 384)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 34)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(221, 384)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 34)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Следующая"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(541, 329)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 34)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Последняя"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(416, 329)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 34)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(285, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 34)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Предыдущая"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(154, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Первая"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(605, 384)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(112, 34)
        Me.Button8.TabIndex = 20
        Me.Button8.Text = "Таблица"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(90, 384)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(112, 34)
        Me.Button9.TabIndex = 21
        Me.Button9.Text = "Отчет"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ТребованияLabel)
        Me.Controls.Add(Me.ТребованияTextBox)
        Me.Controls.Add(ОбязанностиLabel)
        Me.Controls.Add(Me.ОбязанностиTextBox)
        Me.Controls.Add(ОкладLabel)
        Me.Controls.Add(Me.ОкладTextBox)
        Me.Controls.Add(Наименование_должностиLabel)
        Me.Controls.Add(Me.Наименование_должностиTextBox)
        Me.Controls.Add(Me.ДолжностиBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ДолжностиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ДолжностиBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ДолжностиBindingNavigator.ResumeLayout(False)
        Me.ДолжностиBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SchoolbdDataSet As schoolbdDataSet
    Friend WithEvents ДолжностиBindingSource As BindingSource
    Friend WithEvents ДолжностиTableAdapter As schoolbdDataSetTableAdapters.ДолжностиTableAdapter
    Friend WithEvents TableAdapterManager As schoolbdDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ДолжностиBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ДолжностиBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Наименование_должностиTextBox As TextBox
    Friend WithEvents ОкладTextBox As TextBox
    Friend WithEvents ОбязанностиTextBox As TextBox
    Friend WithEvents ТребованияTextBox As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
