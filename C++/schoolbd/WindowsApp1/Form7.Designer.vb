<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim ФИОLabel As System.Windows.Forms.Label
        Dim Дата_рожденияLabel As System.Windows.Forms.Label
        Dim ПолLabel As System.Windows.Forms.Label
        Dim АдресLabel As System.Windows.Forms.Label
        Dim ФИО_отцаLabel As System.Windows.Forms.Label
        Dim ФИО_материLabel As System.Windows.Forms.Label
        Dim Дополнительная_информацияLabel As System.Windows.Forms.Label
        Dim Код_классаLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SchoolbdDataSet = New WindowsApp1.schoolbdDataSet()
        Me.УченикиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.УченикиTableAdapter = New WindowsApp1.schoolbdDataSetTableAdapters.УченикиTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.schoolbdDataSetTableAdapters.TableAdapterManager()
        Me.УченикиBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.УченикиBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ФИОTextBox = New System.Windows.Forms.TextBox()
        Me.Дата_рожденияDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ПолTextBox = New System.Windows.Forms.TextBox()
        Me.АдресTextBox = New System.Windows.Forms.TextBox()
        Me.ФИО_отцаTextBox = New System.Windows.Forms.TextBox()
        Me.ФИО_материTextBox = New System.Windows.Forms.TextBox()
        Me.Дополнительная_информацияTextBox = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button8 = New System.Windows.Forms.Button()
        ФИОLabel = New System.Windows.Forms.Label()
        Дата_рожденияLabel = New System.Windows.Forms.Label()
        ПолLabel = New System.Windows.Forms.Label()
        АдресLabel = New System.Windows.Forms.Label()
        ФИО_отцаLabel = New System.Windows.Forms.Label()
        ФИО_материLabel = New System.Windows.Forms.Label()
        Дополнительная_информацияLabel = New System.Windows.Forms.Label()
        Код_классаLabel = New System.Windows.Forms.Label()
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.УченикиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.УченикиBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.УченикиBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ФИОLabel
        '
        ФИОLabel.AutoSize = True
        ФИОLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ФИОLabel.Location = New System.Drawing.Point(254, 128)
        ФИОLabel.Name = "ФИОLabel"
        ФИОLabel.Size = New System.Drawing.Size(66, 25)
        ФИОLabel.TabIndex = 6
        ФИОLabel.Text = "ФИО:"
        '
        'Дата_рожденияLabel
        '
        Дата_рожденияLabel.AutoSize = True
        Дата_рожденияLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Дата_рожденияLabel.Location = New System.Drawing.Point(153, 170)
        Дата_рожденияLabel.Name = "Дата_рожденияLabel"
        Дата_рожденияLabel.Size = New System.Drawing.Size(167, 25)
        Дата_рожденияLabel.TabIndex = 7
        Дата_рожденияLabel.Text = "Дата рождения:"
        '
        'ПолLabel
        '
        ПолLabel.AutoSize = True
        ПолLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ПолLabel.Location = New System.Drawing.Point(265, 214)
        ПолLabel.Name = "ПолLabel"
        ПолLabel.Size = New System.Drawing.Size(55, 25)
        ПолLabel.TabIndex = 8
        ПолLabel.Text = "Пол:"
        '
        'АдресLabel
        '
        АдресLabel.AutoSize = True
        АдресLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        АдресLabel.Location = New System.Drawing.Point(245, 260)
        АдресLabel.Name = "АдресLabel"
        АдресLabel.Size = New System.Drawing.Size(75, 25)
        АдресLabel.TabIndex = 9
        АдресLabel.Text = "Адрес:"
        '
        'ФИО_отцаLabel
        '
        ФИО_отцаLabel.AutoSize = True
        ФИО_отцаLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ФИО_отцаLabel.Location = New System.Drawing.Point(204, 313)
        ФИО_отцаLabel.Name = "ФИО_отцаLabel"
        ФИО_отцаLabel.Size = New System.Drawing.Size(116, 25)
        ФИО_отцаLabel.TabIndex = 10
        ФИО_отцаLabel.Text = "ФИО отца:"
        '
        'ФИО_материLabel
        '
        ФИО_материLabel.AutoSize = True
        ФИО_материLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ФИО_материLabel.Location = New System.Drawing.Point(177, 354)
        ФИО_материLabel.Name = "ФИО_материLabel"
        ФИО_материLabel.Size = New System.Drawing.Size(143, 25)
        ФИО_материLabel.TabIndex = 12
        ФИО_материLabel.Text = "ФИО матери:"
        '
        'Дополнительная_информацияLabel
        '
        Дополнительная_информацияLabel.AutoSize = True
        Дополнительная_информацияLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Дополнительная_информацияLabel.Location = New System.Drawing.Point(12, 402)
        Дополнительная_информацияLabel.Name = "Дополнительная_информацияLabel"
        Дополнительная_информацияLabel.Size = New System.Drawing.Size(308, 25)
        Дополнительная_информацияLabel.TabIndex = 14
        Дополнительная_информацияLabel.Text = "Дополнительная информация:"
        '
        'Код_классаLabel
        '
        Код_классаLabel.AutoSize = True
        Код_классаLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Код_классаLabel.Location = New System.Drawing.Point(200, 446)
        Код_классаLabel.Name = "Код_классаLabel"
        Код_классаLabel.Size = New System.Drawing.Size(120, 25)
        Код_классаLabel.TabIndex = 16
        Код_классаLabel.Text = "Код класса:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ученики"
        '
        'SchoolbdDataSet
        '
        Me.SchoolbdDataSet.DataSetName = "schoolbdDataSet"
        Me.SchoolbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'УченикиBindingSource
        '
        Me.УченикиBindingSource.DataMember = "Ученики"
        Me.УченикиBindingSource.DataSource = Me.SchoolbdDataSet
        '
        'УченикиTableAdapter
        '
        Me.УченикиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.schoolbdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Виды_классовTableAdapter = Nothing
        Me.TableAdapterManager.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager.КлассыTableAdapter = Nothing
        Me.TableAdapterManager.ПредметыTableAdapter = Nothing
        Me.TableAdapterManager.РасписаниеTableAdapter = Nothing
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.УченикиTableAdapter = Me.УченикиTableAdapter
        '
        'УченикиBindingNavigator
        '
        Me.УченикиBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.УченикиBindingNavigator.BindingSource = Me.УченикиBindingSource
        Me.УченикиBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.УченикиBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.УченикиBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.УченикиBindingNavigatorSaveItem})
        Me.УченикиBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.УченикиBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.УченикиBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.УченикиBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.УченикиBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.УченикиBindingNavigator.Name = "УченикиBindingNavigator"
        Me.УченикиBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.УченикиBindingNavigator.Size = New System.Drawing.Size(778, 25)
        Me.УченикиBindingNavigator.TabIndex = 6
        Me.УченикиBindingNavigator.Text = "BindingNavigator1"
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
        'УченикиBindingNavigatorSaveItem
        '
        Me.УченикиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.УченикиBindingNavigatorSaveItem.Image = CType(resources.GetObject("УченикиBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.УченикиBindingNavigatorSaveItem.Name = "УченикиBindingNavigatorSaveItem"
        Me.УченикиBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.УченикиBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'ФИОTextBox
        '
        Me.ФИОTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.УченикиBindingSource, "ФИО", True))
        Me.ФИОTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ФИОTextBox.Location = New System.Drawing.Point(326, 123)
        Me.ФИОTextBox.Name = "ФИОTextBox"
        Me.ФИОTextBox.Size = New System.Drawing.Size(338, 30)
        Me.ФИОTextBox.TabIndex = 7
        '
        'Дата_рожденияDateTimePicker
        '
        Me.Дата_рожденияDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.УченикиBindingSource, "Дата рождения", True))
        Me.Дата_рожденияDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Дата_рожденияDateTimePicker.Location = New System.Drawing.Point(326, 165)
        Me.Дата_рожденияDateTimePicker.Name = "Дата_рожденияDateTimePicker"
        Me.Дата_рожденияDateTimePicker.Size = New System.Drawing.Size(338, 30)
        Me.Дата_рожденияDateTimePicker.TabIndex = 8
        '
        'ПолTextBox
        '
        Me.ПолTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.УченикиBindingSource, "Пол", True))
        Me.ПолTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ПолTextBox.Location = New System.Drawing.Point(326, 209)
        Me.ПолTextBox.Name = "ПолTextBox"
        Me.ПолTextBox.Size = New System.Drawing.Size(338, 30)
        Me.ПолTextBox.TabIndex = 9
        '
        'АдресTextBox
        '
        Me.АдресTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.УченикиBindingSource, "Адрес", True))
        Me.АдресTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.АдресTextBox.Location = New System.Drawing.Point(326, 257)
        Me.АдресTextBox.Name = "АдресTextBox"
        Me.АдресTextBox.Size = New System.Drawing.Size(338, 30)
        Me.АдресTextBox.TabIndex = 10
        '
        'ФИО_отцаTextBox
        '
        Me.ФИО_отцаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.УченикиBindingSource, "ФИО отца", True))
        Me.ФИО_отцаTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ФИО_отцаTextBox.Location = New System.Drawing.Point(326, 310)
        Me.ФИО_отцаTextBox.Name = "ФИО_отцаTextBox"
        Me.ФИО_отцаTextBox.Size = New System.Drawing.Size(338, 30)
        Me.ФИО_отцаTextBox.TabIndex = 11
        '
        'ФИО_материTextBox
        '
        Me.ФИО_материTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.УченикиBindingSource, "ФИО матери", True))
        Me.ФИО_материTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ФИО_материTextBox.Location = New System.Drawing.Point(326, 354)
        Me.ФИО_материTextBox.Name = "ФИО_материTextBox"
        Me.ФИО_материTextBox.Size = New System.Drawing.Size(338, 30)
        Me.ФИО_материTextBox.TabIndex = 13
        '
        'Дополнительная_информацияTextBox
        '
        Me.Дополнительная_информацияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.УченикиBindingSource, "Дополнительная информация", True))
        Me.Дополнительная_информацияTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Дополнительная_информацияTextBox.Location = New System.Drawing.Point(326, 399)
        Me.Дополнительная_информацияTextBox.Name = "Дополнительная_информацияTextBox"
        Me.Дополнительная_информацияTextBox.Size = New System.Drawing.Size(338, 30)
        Me.Дополнительная_информацияTextBox.TabIndex = 15
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(467, 544)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(112, 34)
        Me.Button7.TabIndex = 24
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(339, 544)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 34)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(211, 544)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 34)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "Следующая"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(531, 489)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 34)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Последняя"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(406, 489)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 34)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(275, 489)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 34)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Предыдущая"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(144, 489)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Первая"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"А", "Б", "В", "Г", "Д"})
        Me.ComboBox1.Location = New System.Drawing.Point(326, 443)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(338, 33)
        Me.ComboBox1.TabIndex = 25
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(600, 544)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(112, 34)
        Me.Button8.TabIndex = 26
        Me.Button8.Text = "Таблица"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 585)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Код_классаLabel)
        Me.Controls.Add(Дополнительная_информацияLabel)
        Me.Controls.Add(Me.Дополнительная_информацияTextBox)
        Me.Controls.Add(ФИО_материLabel)
        Me.Controls.Add(Me.ФИО_материTextBox)
        Me.Controls.Add(ФИО_отцаLabel)
        Me.Controls.Add(Me.ФИО_отцаTextBox)
        Me.Controls.Add(АдресLabel)
        Me.Controls.Add(Me.АдресTextBox)
        Me.Controls.Add(ПолLabel)
        Me.Controls.Add(Me.ПолTextBox)
        Me.Controls.Add(Дата_рожденияLabel)
        Me.Controls.Add(Me.Дата_рожденияDateTimePicker)
        Me.Controls.Add(ФИОLabel)
        Me.Controls.Add(Me.ФИОTextBox)
        Me.Controls.Add(Me.УченикиBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.УченикиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.УченикиBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.УченикиBindingNavigator.ResumeLayout(False)
        Me.УченикиBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SchoolbdDataSet As schoolbdDataSet
    Friend WithEvents УченикиBindingSource As BindingSource
    Friend WithEvents УченикиTableAdapter As schoolbdDataSetTableAdapters.УченикиTableAdapter
    Friend WithEvents TableAdapterManager As schoolbdDataSetTableAdapters.TableAdapterManager
    Friend WithEvents УченикиBindingNavigator As BindingNavigator
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
    Friend WithEvents УченикиBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ФИОTextBox As TextBox
    Friend WithEvents Дата_рожденияDateTimePicker As DateTimePicker
    Friend WithEvents ПолTextBox As TextBox
    Friend WithEvents АдресTextBox As TextBox
    Friend WithEvents ФИО_отцаTextBox As TextBox
    Friend WithEvents ФИО_материTextBox As TextBox
    Friend WithEvents Дополнительная_информацияTextBox As TextBox
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
