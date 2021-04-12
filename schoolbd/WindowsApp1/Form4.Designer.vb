<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim Количество_учениковLabel As System.Windows.Forms.Label
        Dim БукваLabel As System.Windows.Forms.Label
        Dim Год_обученияLabel As System.Windows.Forms.Label
        Dim Год_созданияLabel As System.Windows.Forms.Label
        Dim Код_сотрудника___классного_руководителяLabel As System.Windows.Forms.Label
        Dim Код_видаLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SchoolbdDataSet = New WindowsApp1.schoolbdDataSet()
        Me.КлассыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.КлассыTableAdapter = New WindowsApp1.schoolbdDataSetTableAdapters.КлассыTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.schoolbdDataSetTableAdapters.TableAdapterManager()
        Me.КлассыBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.КлассыBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Количество_учениковTextBox = New System.Windows.Forms.TextBox()
        Me.БукваTextBox = New System.Windows.Forms.TextBox()
        Me.Год_обученияTextBox = New System.Windows.Forms.TextBox()
        Me.Год_созданияTextBox = New System.Windows.Forms.TextBox()
        Me.Код_сотрудника___классного_руководителяTextBox = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Количество_учениковLabel = New System.Windows.Forms.Label()
        БукваLabel = New System.Windows.Forms.Label()
        Год_обученияLabel = New System.Windows.Forms.Label()
        Год_созданияLabel = New System.Windows.Forms.Label()
        Код_сотрудника___классного_руководителяLabel = New System.Windows.Forms.Label()
        Код_видаLabel = New System.Windows.Forms.Label()
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КлассыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КлассыBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.КлассыBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Количество_учениковLabel
        '
        Количество_учениковLabel.AutoSize = True
        Количество_учениковLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Количество_учениковLabel.Location = New System.Drawing.Point(190, 153)
        Количество_учениковLabel.Name = "Количество_учениковLabel"
        Количество_учениковLabel.Size = New System.Drawing.Size(218, 25)
        Количество_учениковLabel.TabIndex = 3
        Количество_учениковLabel.Text = "Количество учеников:"
        '
        'БукваLabel
        '
        БукваLabel.AutoSize = True
        БукваLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        БукваLabel.Location = New System.Drawing.Point(339, 190)
        БукваLabel.Name = "БукваLabel"
        БукваLabel.Size = New System.Drawing.Size(69, 25)
        БукваLabel.TabIndex = 4
        БукваLabel.Text = "Буква:"
        '
        'Год_обученияLabel
        '
        Год_обученияLabel.AutoSize = True
        Год_обученияLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Год_обученияLabel.Location = New System.Drawing.Point(264, 228)
        Год_обученияLabel.Name = "Год_обученияLabel"
        Год_обученияLabel.Size = New System.Drawing.Size(144, 25)
        Год_обученияLabel.TabIndex = 6
        Год_обученияLabel.Text = "Год обучения:"
        '
        'Год_созданияLabel
        '
        Год_созданияLabel.AutoSize = True
        Год_созданияLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Год_созданияLabel.Location = New System.Drawing.Point(263, 268)
        Год_созданияLabel.Name = "Год_созданияLabel"
        Год_созданияLabel.Size = New System.Drawing.Size(145, 25)
        Год_созданияLabel.TabIndex = 8
        Год_созданияLabel.Text = "Год создания:"
        '
        'Код_сотрудника___классного_руководителяLabel
        '
        Код_сотрудника___классного_руководителяLabel.AutoSize = True
        Код_сотрудника___классного_руководителяLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Код_сотрудника___классного_руководителяLabel.Location = New System.Drawing.Point(-3, 120)
        Код_сотрудника___классного_руководителяLabel.Name = "Код_сотрудника___классного_руководителяLabel"
        Код_сотрудника___классного_руководителяLabel.Size = New System.Drawing.Size(411, 25)
        Код_сотрудника___классного_руководителяLabel.TabIndex = 10
        Код_сотрудника___классного_руководителяLabel.Text = "Код сотрудника - классного руководителя:"
        AddHandler Код_сотрудника___классного_руководителяLabel.Click, AddressOf Me.Код_сотрудника___классного_руководителяLabel_Click
        '
        'Код_видаLabel
        '
        Код_видаLabel.AutoSize = True
        Код_видаLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Код_видаLabel.Location = New System.Drawing.Point(307, 309)
        Код_видаLabel.Name = "Код_видаLabel"
        Код_видаLabel.Size = New System.Drawing.Size(101, 25)
        Код_видаLabel.TabIndex = 12
        Код_видаLabel.Text = "Код вида:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Классы"
        '
        'SchoolbdDataSet
        '
        Me.SchoolbdDataSet.DataSetName = "schoolbdDataSet"
        Me.SchoolbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'КлассыBindingSource
        '
        Me.КлассыBindingSource.DataMember = "Классы"
        Me.КлассыBindingSource.DataSource = Me.SchoolbdDataSet
        '
        'КлассыTableAdapter
        '
        Me.КлассыTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.schoolbdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Виды_классовTableAdapter = Nothing
        Me.TableAdapterManager.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager.КлассыTableAdapter = Me.КлассыTableAdapter
        Me.TableAdapterManager.ПредметыTableAdapter = Nothing
        Me.TableAdapterManager.РасписаниеTableAdapter = Nothing
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.УченикиTableAdapter = Nothing
        '
        'КлассыBindingNavigator
        '
        Me.КлассыBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.КлассыBindingNavigator.BindingSource = Me.КлассыBindingSource
        Me.КлассыBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.КлассыBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.КлассыBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.КлассыBindingNavigatorSaveItem})
        Me.КлассыBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.КлассыBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.КлассыBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.КлассыBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.КлассыBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.КлассыBindingNavigator.Name = "КлассыBindingNavigator"
        Me.КлассыBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.КлассыBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.КлассыBindingNavigator.TabIndex = 3
        Me.КлассыBindingNavigator.Text = "BindingNavigator1"
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
        'КлассыBindingNavigatorSaveItem
        '
        Me.КлассыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.КлассыBindingNavigatorSaveItem.Image = CType(resources.GetObject("КлассыBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.КлассыBindingNavigatorSaveItem.Name = "КлассыBindingNavigatorSaveItem"
        Me.КлассыBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.КлассыBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Количество_учениковTextBox
        '
        Me.Количество_учениковTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КлассыBindingSource, "Количество учеников", True))
        Me.Количество_учениковTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Количество_учениковTextBox.Location = New System.Drawing.Point(414, 153)
        Me.Количество_учениковTextBox.Name = "Количество_учениковTextBox"
        Me.Количество_учениковTextBox.Size = New System.Drawing.Size(272, 30)
        Me.Количество_учениковTextBox.TabIndex = 4
        '
        'БукваTextBox
        '
        Me.БукваTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КлассыBindingSource, "Буква", True))
        Me.БукваTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.БукваTextBox.Location = New System.Drawing.Point(414, 192)
        Me.БукваTextBox.Name = "БукваTextBox"
        Me.БукваTextBox.Size = New System.Drawing.Size(272, 30)
        Me.БукваTextBox.TabIndex = 5
        '
        'Год_обученияTextBox
        '
        Me.Год_обученияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КлассыBindingSource, "Год обучения", True))
        Me.Год_обученияTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Год_обученияTextBox.Location = New System.Drawing.Point(414, 228)
        Me.Год_обученияTextBox.Name = "Год_обученияTextBox"
        Me.Год_обученияTextBox.Size = New System.Drawing.Size(272, 30)
        Me.Год_обученияTextBox.TabIndex = 7
        '
        'Год_созданияTextBox
        '
        Me.Год_созданияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КлассыBindingSource, "Год создания", True))
        Me.Год_созданияTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Год_созданияTextBox.Location = New System.Drawing.Point(414, 268)
        Me.Год_созданияTextBox.Name = "Год_созданияTextBox"
        Me.Год_созданияTextBox.Size = New System.Drawing.Size(272, 30)
        Me.Год_созданияTextBox.TabIndex = 9
        '
        'Код_сотрудника___классного_руководителяTextBox
        '
        Me.Код_сотрудника___классного_руководителяTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КлассыBindingSource, "Код сотрудника - классного руководителя", True))
        Me.Код_сотрудника___классного_руководителяTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Код_сотрудника___классного_руководителяTextBox.Location = New System.Drawing.Point(414, 120)
        Me.Код_сотрудника___классного_руководителяTextBox.Name = "Код_сотрудника___классного_руководителяTextBox"
        Me.Код_сотрудника___классного_руководителяTextBox.Size = New System.Drawing.Size(272, 30)
        Me.Код_сотрудника___классного_руководителяTextBox.TabIndex = 11
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(488, 402)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(112, 34)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(360, 402)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 34)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(232, 402)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 34)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Следующая"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(552, 347)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 34)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Последняя"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(427, 347)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 34)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(296, 347)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 34)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Предыдущая"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(165, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Первая"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Подготовительная", "Начальная", "Средняя", "Старшая", "Выпускники"})
        Me.ComboBox1.Location = New System.Drawing.Point(414, 309)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(272, 33)
        Me.ComboBox1.TabIndex = 21
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(621, 402)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(112, 34)
        Me.Button8.TabIndex = 22
        Me.Button8.Text = "Таблица"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Код_видаLabel)
        Me.Controls.Add(Код_сотрудника___классного_руководителяLabel)
        Me.Controls.Add(Me.Код_сотрудника___классного_руководителяTextBox)
        Me.Controls.Add(Год_созданияLabel)
        Me.Controls.Add(Me.Год_созданияTextBox)
        Me.Controls.Add(Год_обученияLabel)
        Me.Controls.Add(Me.Год_обученияTextBox)
        Me.Controls.Add(БукваLabel)
        Me.Controls.Add(Me.БукваTextBox)
        Me.Controls.Add(Количество_учениковLabel)
        Me.Controls.Add(Me.Количество_учениковTextBox)
        Me.Controls.Add(Me.КлассыBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КлассыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КлассыBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.КлассыBindingNavigator.ResumeLayout(False)
        Me.КлассыBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SchoolbdDataSet As schoolbdDataSet
    Friend WithEvents КлассыBindingSource As BindingSource
    Friend WithEvents КлассыTableAdapter As schoolbdDataSetTableAdapters.КлассыTableAdapter
    Friend WithEvents TableAdapterManager As schoolbdDataSetTableAdapters.TableAdapterManager
    Friend WithEvents КлассыBindingNavigator As BindingNavigator
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
    Friend WithEvents КлассыBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Количество_учениковTextBox As TextBox
    Friend WithEvents БукваTextBox As TextBox
    Friend WithEvents Год_обученияTextBox As TextBox
    Friend WithEvents Год_созданияTextBox As TextBox
    Friend WithEvents Код_сотрудника___классного_руководителяTextBox As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button8 As Button
End Class
