<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim ДатаLabel As System.Windows.Forms.Label
        Dim День_неделиLabel As System.Windows.Forms.Label
        Dim Время_началаLabel As System.Windows.Forms.Label
        Dim Время_окончанияLabel As System.Windows.Forms.Label
        Dim Код_классаLabel As System.Windows.Forms.Label
        Dim Код_предметаLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SchoolbdDataSet = New WindowsApp1.schoolbdDataSet()
        Me.РасписаниеBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.РасписаниеTableAdapter = New WindowsApp1.schoolbdDataSetTableAdapters.РасписаниеTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.schoolbdDataSetTableAdapters.TableAdapterManager()
        Me.РасписаниеBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.РасписаниеBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ДатаDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.День_неделиTextBox = New System.Windows.Forms.TextBox()
        Me.Время_началаTextBox = New System.Windows.Forms.TextBox()
        Me.Время_окончанияTextBox = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Button8 = New System.Windows.Forms.Button()
        ДатаLabel = New System.Windows.Forms.Label()
        День_неделиLabel = New System.Windows.Forms.Label()
        Время_началаLabel = New System.Windows.Forms.Label()
        Время_окончанияLabel = New System.Windows.Forms.Label()
        Код_классаLabel = New System.Windows.Forms.Label()
        Код_предметаLabel = New System.Windows.Forms.Label()
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РасписаниеBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РасписаниеBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.РасписаниеBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ДатаLabel
        '
        ДатаLabel.AutoSize = True
        ДатаLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ДатаLabel.Location = New System.Drawing.Point(223, 154)
        ДатаLabel.Name = "ДатаLabel"
        ДатаLabel.Size = New System.Drawing.Size(67, 25)
        ДатаLabel.TabIndex = 7
        ДатаLabel.Text = "Дата:"
        '
        'День_неделиLabel
        '
        День_неделиLabel.AutoSize = True
        День_неделиLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        День_неделиLabel.Location = New System.Drawing.Point(150, 188)
        День_неделиLabel.Name = "День_неделиLabel"
        День_неделиLabel.Size = New System.Drawing.Size(140, 25)
        День_неделиLabel.TabIndex = 8
        День_неделиLabel.Text = "День недели:"
        '
        'Время_началаLabel
        '
        Время_началаLabel.AutoSize = True
        Время_началаLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Время_началаLabel.Location = New System.Drawing.Point(141, 229)
        Время_началаLabel.Name = "Время_началаLabel"
        Время_началаLabel.Size = New System.Drawing.Size(149, 25)
        Время_началаLabel.TabIndex = 9
        Время_началаLabel.Text = "Время начала:"
        '
        'Время_окончанияLabel
        '
        Время_окончанияLabel.AutoSize = True
        Время_окончанияLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Время_окончанияLabel.Location = New System.Drawing.Point(108, 269)
        Время_окончанияLabel.Name = "Время_окончанияLabel"
        Время_окончанияLabel.Size = New System.Drawing.Size(182, 25)
        Время_окончанияLabel.TabIndex = 10
        Время_окончанияLabel.Text = "Время окончания:"
        '
        'Код_классаLabel
        '
        Код_классаLabel.AutoSize = True
        Код_классаLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Код_классаLabel.Location = New System.Drawing.Point(170, 308)
        Код_классаLabel.Name = "Код_классаLabel"
        Код_классаLabel.Size = New System.Drawing.Size(120, 25)
        Код_классаLabel.TabIndex = 11
        Код_классаLabel.Text = "Код класса:"
        '
        'Код_предметаLabel
        '
        Код_предметаLabel.AutoSize = True
        Код_предметаLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Код_предметаLabel.Location = New System.Drawing.Point(137, 350)
        Код_предметаLabel.Name = "Код_предметаLabel"
        Код_предметаLabel.Size = New System.Drawing.Size(153, 25)
        Код_предметаLabel.TabIndex = 12
        Код_предметаLabel.Text = "Код предмета:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(308, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 39)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Расписание"
        '
        'SchoolbdDataSet
        '
        Me.SchoolbdDataSet.DataSetName = "schoolbdDataSet"
        Me.SchoolbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'РасписаниеBindingSource
        '
        Me.РасписаниеBindingSource.DataMember = "Расписание"
        Me.РасписаниеBindingSource.DataSource = Me.SchoolbdDataSet
        '
        'РасписаниеTableAdapter
        '
        Me.РасписаниеTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.schoolbdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Виды_классовTableAdapter = Nothing
        Me.TableAdapterManager.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager.КлассыTableAdapter = Nothing
        Me.TableAdapterManager.ПредметыTableAdapter = Nothing
        Me.TableAdapterManager.РасписаниеTableAdapter = Me.РасписаниеTableAdapter
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.УченикиTableAdapter = Nothing
        '
        'РасписаниеBindingNavigator
        '
        Me.РасписаниеBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.РасписаниеBindingNavigator.BindingSource = Me.РасписаниеBindingSource
        Me.РасписаниеBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.РасписаниеBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.РасписаниеBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.РасписаниеBindingNavigatorSaveItem})
        Me.РасписаниеBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.РасписаниеBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.РасписаниеBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.РасписаниеBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.РасписаниеBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.РасписаниеBindingNavigator.Name = "РасписаниеBindingNavigator"
        Me.РасписаниеBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.РасписаниеBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.РасписаниеBindingNavigator.TabIndex = 7
        Me.РасписаниеBindingNavigator.Text = "BindingNavigator1"
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
        'РасписаниеBindingNavigatorSaveItem
        '
        Me.РасписаниеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.РасписаниеBindingNavigatorSaveItem.Image = CType(resources.GetObject("РасписаниеBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.РасписаниеBindingNavigatorSaveItem.Name = "РасписаниеBindingNavigatorSaveItem"
        Me.РасписаниеBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.РасписаниеBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'ДатаDateTimePicker
        '
        Me.ДатаDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.РасписаниеBindingSource, "Дата", True))
        Me.ДатаDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ДатаDateTimePicker.Location = New System.Drawing.Point(296, 149)
        Me.ДатаDateTimePicker.Name = "ДатаDateTimePicker"
        Me.ДатаDateTimePicker.Size = New System.Drawing.Size(304, 30)
        Me.ДатаDateTimePicker.TabIndex = 8
        '
        'День_неделиTextBox
        '
        Me.День_неделиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РасписаниеBindingSource, "День недели", True))
        Me.День_неделиTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.День_неделиTextBox.Location = New System.Drawing.Point(296, 185)
        Me.День_неделиTextBox.Name = "День_неделиTextBox"
        Me.День_неделиTextBox.Size = New System.Drawing.Size(304, 30)
        Me.День_неделиTextBox.TabIndex = 9
        '
        'Время_началаTextBox
        '
        Me.Время_началаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РасписаниеBindingSource, "Время начала", True))
        Me.Время_началаTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Время_началаTextBox.Location = New System.Drawing.Point(296, 226)
        Me.Время_началаTextBox.Name = "Время_началаTextBox"
        Me.Время_началаTextBox.Size = New System.Drawing.Size(304, 30)
        Me.Время_началаTextBox.TabIndex = 10
        '
        'Время_окончанияTextBox
        '
        Me.Время_окончанияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РасписаниеBindingSource, "Время окончания", True))
        Me.Время_окончанияTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Время_окончанияTextBox.Location = New System.Drawing.Point(296, 264)
        Me.Время_окончанияTextBox.Name = "Время_окончанияTextBox"
        Me.Время_окончанияTextBox.Size = New System.Drawing.Size(304, 30)
        Me.Время_окончанияTextBox.TabIndex = 11
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(462, 449)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(112, 34)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(334, 449)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 34)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(206, 449)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 34)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Следующая"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(526, 394)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 34)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Последняя"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(401, 394)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 34)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(270, 394)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 34)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Предыдущая"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(139, 394)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Первая"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 21
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"А", "Б", "В", "Г", "Д"})
        Me.ComboBox2.Location = New System.Drawing.Point(296, 305)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(304, 33)
        Me.ComboBox2.TabIndex = 22
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Математика", "Русский язык", "Физика", "Английский язык", "География", "История", "Физкультура", "Технология", "Черчение", "Психология"})
        Me.ComboBox3.Location = New System.Drawing.Point(296, 350)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(304, 33)
        Me.ComboBox3.TabIndex = 23
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(593, 449)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(112, 34)
        Me.Button8.TabIndex = 27
        Me.Button8.Text = "Таблица"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 492)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Код_предметаLabel)
        Me.Controls.Add(Код_классаLabel)
        Me.Controls.Add(Время_окончанияLabel)
        Me.Controls.Add(Me.Время_окончанияTextBox)
        Me.Controls.Add(Время_началаLabel)
        Me.Controls.Add(Me.Время_началаTextBox)
        Me.Controls.Add(День_неделиLabel)
        Me.Controls.Add(Me.День_неделиTextBox)
        Me.Controls.Add(ДатаLabel)
        Me.Controls.Add(Me.ДатаDateTimePicker)
        Me.Controls.Add(Me.РасписаниеBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form8"
        Me.Text = "Form8"
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РасписаниеBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РасписаниеBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.РасписаниеBindingNavigator.ResumeLayout(False)
        Me.РасписаниеBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SchoolbdDataSet As schoolbdDataSet
    Friend WithEvents РасписаниеBindingSource As BindingSource
    Friend WithEvents РасписаниеTableAdapter As schoolbdDataSetTableAdapters.РасписаниеTableAdapter
    Friend WithEvents TableAdapterManager As schoolbdDataSetTableAdapters.TableAdapterManager
    Friend WithEvents РасписаниеBindingNavigator As BindingNavigator
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
    Friend WithEvents РасписаниеBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ДатаDateTimePicker As DateTimePicker
    Friend WithEvents День_неделиTextBox As TextBox
    Friend WithEvents Время_началаTextBox As TextBox
    Friend WithEvents Время_окончанияTextBox As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Button8 As Button
End Class
