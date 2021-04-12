<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim НаименованиеLabel As System.Windows.Forms.Label
        Dim ОписаниеLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SchoolbdDataSet = New WindowsApp1.schoolbdDataSet()
        Me.Виды_классовBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Виды_классовTableAdapter = New WindowsApp1.schoolbdDataSetTableAdapters.Виды_классовTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.schoolbdDataSetTableAdapters.TableAdapterManager()
        Me.Виды_классовBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Виды_классовBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.НаименованиеTextBox = New System.Windows.Forms.TextBox()
        Me.ОписаниеTextBox = New System.Windows.Forms.TextBox()
        Me.КлассыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.КлассыTableAdapter = New WindowsApp1.schoolbdDataSetTableAdapters.КлассыTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        НаименованиеLabel = New System.Windows.Forms.Label()
        ОписаниеLabel = New System.Windows.Forms.Label()
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Виды_классовBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Виды_классовBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Виды_классовBindingNavigator.SuspendLayout()
        CType(Me.КлассыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'НаименованиеLabel
        '
        НаименованиеLabel.AutoSize = True
        НаименованиеLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        НаименованиеLabel.Location = New System.Drawing.Point(131, 198)
        НаименованиеLabel.Name = "НаименованиеLabel"
        НаименованиеLabel.Size = New System.Drawing.Size(155, 25)
        НаименованиеLabel.TabIndex = 2
        НаименованиеLabel.Text = "Наименование:"
        '
        'ОписаниеLabel
        '
        ОписаниеLabel.AutoSize = True
        ОписаниеLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ОписаниеLabel.Location = New System.Drawing.Point(178, 248)
        ОписаниеLabel.Name = "ОписаниеLabel"
        ОписаниеLabel.Size = New System.Drawing.Size(108, 25)
        ОписаниеLabel.TabIndex = 4
        ОписаниеLabel.Text = "Описание:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Виды классов"
        '
        'SchoolbdDataSet
        '
        Me.SchoolbdDataSet.DataSetName = "schoolbdDataSet"
        Me.SchoolbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Виды_классовBindingSource
        '
        Me.Виды_классовBindingSource.DataMember = "Виды классов"
        Me.Виды_классовBindingSource.DataSource = Me.SchoolbdDataSet
        '
        'Виды_классовTableAdapter
        '
        Me.Виды_классовTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.schoolbdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Виды_классовTableAdapter = Me.Виды_классовTableAdapter
        Me.TableAdapterManager.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager.КлассыTableAdapter = Nothing
        Me.TableAdapterManager.ПредметыTableAdapter = Nothing
        Me.TableAdapterManager.РасписаниеTableAdapter = Nothing
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.УченикиTableAdapter = Nothing
        '
        'Виды_классовBindingNavigator
        '
        Me.Виды_классовBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Виды_классовBindingNavigator.BindingSource = Me.Виды_классовBindingSource
        Me.Виды_классовBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Виды_классовBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Виды_классовBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Виды_классовBindingNavigatorSaveItem})
        Me.Виды_классовBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Виды_классовBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Виды_классовBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Виды_классовBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Виды_классовBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Виды_классовBindingNavigator.Name = "Виды_классовBindingNavigator"
        Me.Виды_классовBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Виды_классовBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Виды_классовBindingNavigator.TabIndex = 1
        Me.Виды_классовBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'Виды_классовBindingNavigatorSaveItem
        '
        Me.Виды_классовBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Виды_классовBindingNavigatorSaveItem.Image = CType(resources.GetObject("Виды_классовBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Виды_классовBindingNavigatorSaveItem.Name = "Виды_классовBindingNavigatorSaveItem"
        Me.Виды_классовBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Виды_классовBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'НаименованиеTextBox
        '
        Me.НаименованиеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Виды_классовBindingSource, "Наименование", True))
        Me.НаименованиеTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.НаименованиеTextBox.Location = New System.Drawing.Point(292, 195)
        Me.НаименованиеTextBox.Name = "НаименованиеTextBox"
        Me.НаименованиеTextBox.Size = New System.Drawing.Size(396, 30)
        Me.НаименованиеTextBox.TabIndex = 3
        '
        'ОписаниеTextBox
        '
        Me.ОписаниеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Виды_классовBindingSource, "Описание", True))
        Me.ОписаниеTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ОписаниеTextBox.Location = New System.Drawing.Point(292, 245)
        Me.ОписаниеTextBox.Name = "ОписаниеTextBox"
        Me.ОписаниеTextBox.Size = New System.Drawing.Size(396, 30)
        Me.ОписаниеTextBox.TabIndex = 5
        '
        'КлассыBindingSource
        '
        Me.КлассыBindingSource.DataMember = "FK_Классы_Виды классов"
        Me.КлассыBindingSource.DataSource = Me.Виды_классовBindingSource
        '
        'КлассыTableAdapter
        '
        Me.КлассыTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(161, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Первая"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(292, 308)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 34)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Предыдущая"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(423, 308)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 34)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(548, 308)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 34)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Последняя"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(228, 363)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 34)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Следующая"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(356, 363)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 34)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(484, 363)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(112, 34)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(614, 363)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(112, 34)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "Таблица"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(90, 363)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(112, 34)
        Me.Button9.TabIndex = 14
        Me.Button9.Text = "Отчет"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 598)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ОписаниеLabel)
        Me.Controls.Add(Me.ОписаниеTextBox)
        Me.Controls.Add(НаименованиеLabel)
        Me.Controls.Add(Me.НаименованиеTextBox)
        Me.Controls.Add(Me.Виды_классовBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Виды_классовBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Виды_классовBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Виды_классовBindingNavigator.ResumeLayout(False)
        Me.Виды_классовBindingNavigator.PerformLayout()
        CType(Me.КлассыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SchoolbdDataSet As schoolbdDataSet
    Friend WithEvents Виды_классовBindingSource As BindingSource
    Friend WithEvents Виды_классовTableAdapter As schoolbdDataSetTableAdapters.Виды_классовTableAdapter
    Friend WithEvents TableAdapterManager As schoolbdDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Виды_классовBindingNavigator As BindingNavigator
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
    Friend WithEvents Виды_классовBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents НаименованиеTextBox As TextBox
    Friend WithEvents ОписаниеTextBox As TextBox
    Friend WithEvents КлассыBindingSource As BindingSource
    Friend WithEvents КлассыTableAdapter As schoolbdDataSetTableAdapters.КлассыTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
