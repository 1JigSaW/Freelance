<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form25
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form25))
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.СписокКлассовBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolbdDataSet = New WindowsApp1.schoolbdDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Список_клаасовDataGridView = New System.Windows.Forms.DataGridView()
        Me.КодКлассаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.КоличествоУчениковDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.БукваDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ГодОбученияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ГодСозданияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.НаименованиеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ОписаниеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПаспортныеДанныеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ТелефонDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.КодДолжностиDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.АдресDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПолDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ВозрастDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ФИОDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Список_классовTableAdapter = New WindowsApp1.schoolbdDataSetTableAdapters.Список_классовTableAdapter()
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
        CType(Me.СписокКлассовBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Список_клаасовDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.УченикиBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.УченикиBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(558, 431)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(225, 32)
        Me.Button6.TabIndex = 58
        Me.Button6.Text = "Отчет"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(672, 394)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(111, 32)
        Me.Button5.TabIndex = 57
        Me.Button5.Text = "Закрыть"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(558, 393)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 32)
        Me.Button4.TabIndex = 56
        Me.Button4.Text = "Найти"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(672, 358)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 32)
        Me.Button3.TabIndex = 55
        Me.Button3.Text = "Показать все"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(558, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 32)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "Фильтровать"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(119, 358)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(433, 29)
        Me.TextBox1.TabIndex = 53
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.СписокКлассовBindingSource
        Me.ComboBox1.DisplayMember = "Буква"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(119, 393)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(433, 32)
        Me.ComboBox1.TabIndex = 52
        '
        'СписокКлассовBindingSource
        '
        Me.СписокКлассовBindingSource.DataMember = "Список классов"
        Me.СписокКлассовBindingSource.DataSource = Me.SchoolbdDataSet
        '
        'SchoolbdDataSet
        '
        Me.SchoolbdDataSet.DataSetName = "schoolbdDataSet"
        Me.SchoolbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 402)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Критерий"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 367)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Наименование"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(558, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 315)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Сортировка"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(213, 52)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Сортировать"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(6, 223)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(194, 21)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.Text = "Сортировка по убыванию"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(5, 196)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(214, 21)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Сортировка по возрастанию"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 24
        Me.ListBox1.Items.AddRange(New Object() {"Количество учеников", "Буква", "Год обучения", "Год создания", "Наименование ", "Описание", "Паспортные данные", "Телефон", "Адрес", "Пол", "Возраст", "ФИО"})
        Me.ListBox1.Location = New System.Drawing.Point(6, 56)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(213, 124)
        Me.ListBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Поле для сортировки"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 24)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Список классов (Табличный вид)"
        '
        'Список_клаасовDataGridView
        '
        Me.Список_клаасовDataGridView.AutoGenerateColumns = False
        Me.Список_клаасовDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Список_клаасовDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодКлассаDataGridViewTextBoxColumn, Me.КоличествоУчениковDataGridViewTextBoxColumn, Me.БукваDataGridViewTextBoxColumn, Me.ГодОбученияDataGridViewTextBoxColumn, Me.ГодСозданияDataGridViewTextBoxColumn, Me.НаименованиеDataGridViewTextBoxColumn, Me.ОписаниеDataGridViewTextBoxColumn, Me.ПаспортныеДанныеDataGridViewTextBoxColumn, Me.ТелефонDataGridViewTextBoxColumn, Me.КодДолжностиDataGridViewTextBoxColumn, Me.АдресDataGridViewTextBoxColumn, Me.ПолDataGridViewTextBoxColumn, Me.ВозрастDataGridViewTextBoxColumn, Me.ФИОDataGridViewTextBoxColumn})
        Me.Список_клаасовDataGridView.DataSource = Me.СписокКлассовBindingSource
        Me.Список_клаасовDataGridView.Location = New System.Drawing.Point(44, 52)
        Me.Список_клаасовDataGridView.Name = "Список_клаасовDataGridView"
        Me.Список_клаасовDataGridView.Size = New System.Drawing.Size(508, 300)
        Me.Список_клаасовDataGridView.TabIndex = 59
        '
        'КодКлассаDataGridViewTextBoxColumn
        '
        Me.КодКлассаDataGridViewTextBoxColumn.DataPropertyName = "Код класса"
        Me.КодКлассаDataGridViewTextBoxColumn.HeaderText = "Код класса"
        Me.КодКлассаDataGridViewTextBoxColumn.Name = "КодКлассаDataGridViewTextBoxColumn"
        '
        'КоличествоУчениковDataGridViewTextBoxColumn
        '
        Me.КоличествоУчениковDataGridViewTextBoxColumn.DataPropertyName = "Количество учеников"
        Me.КоличествоУчениковDataGridViewTextBoxColumn.HeaderText = "Количество учеников"
        Me.КоличествоУчениковDataGridViewTextBoxColumn.Name = "КоличествоУчениковDataGridViewTextBoxColumn"
        '
        'БукваDataGridViewTextBoxColumn
        '
        Me.БукваDataGridViewTextBoxColumn.DataPropertyName = "Буква"
        Me.БукваDataGridViewTextBoxColumn.HeaderText = "Буква"
        Me.БукваDataGridViewTextBoxColumn.Name = "БукваDataGridViewTextBoxColumn"
        '
        'ГодОбученияDataGridViewTextBoxColumn
        '
        Me.ГодОбученияDataGridViewTextBoxColumn.DataPropertyName = "Год обучения"
        Me.ГодОбученияDataGridViewTextBoxColumn.HeaderText = "Год обучения"
        Me.ГодОбученияDataGridViewTextBoxColumn.Name = "ГодОбученияDataGridViewTextBoxColumn"
        '
        'ГодСозданияDataGridViewTextBoxColumn
        '
        Me.ГодСозданияDataGridViewTextBoxColumn.DataPropertyName = "Год создания"
        Me.ГодСозданияDataGridViewTextBoxColumn.HeaderText = "Год создания"
        Me.ГодСозданияDataGridViewTextBoxColumn.Name = "ГодСозданияDataGridViewTextBoxColumn"
        '
        'НаименованиеDataGridViewTextBoxColumn
        '
        Me.НаименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование"
        Me.НаименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование"
        Me.НаименованиеDataGridViewTextBoxColumn.Name = "НаименованиеDataGridViewTextBoxColumn"
        '
        'ОписаниеDataGridViewTextBoxColumn
        '
        Me.ОписаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание"
        Me.ОписаниеDataGridViewTextBoxColumn.HeaderText = "Описание"
        Me.ОписаниеDataGridViewTextBoxColumn.Name = "ОписаниеDataGridViewTextBoxColumn"
        '
        'ПаспортныеДанныеDataGridViewTextBoxColumn
        '
        Me.ПаспортныеДанныеDataGridViewTextBoxColumn.DataPropertyName = "Паспортные данные"
        Me.ПаспортныеДанныеDataGridViewTextBoxColumn.HeaderText = "Паспортные данные"
        Me.ПаспортныеДанныеDataGridViewTextBoxColumn.Name = "ПаспортныеДанныеDataGridViewTextBoxColumn"
        '
        'ТелефонDataGridViewTextBoxColumn
        '
        Me.ТелефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон"
        Me.ТелефонDataGridViewTextBoxColumn.HeaderText = "Телефон"
        Me.ТелефонDataGridViewTextBoxColumn.Name = "ТелефонDataGridViewTextBoxColumn"
        '
        'КодДолжностиDataGridViewTextBoxColumn
        '
        Me.КодДолжностиDataGridViewTextBoxColumn.DataPropertyName = "Код должности"
        Me.КодДолжностиDataGridViewTextBoxColumn.HeaderText = "Код должности"
        Me.КодДолжностиDataGridViewTextBoxColumn.Name = "КодДолжностиDataGridViewTextBoxColumn"
        '
        'АдресDataGridViewTextBoxColumn
        '
        Me.АдресDataGridViewTextBoxColumn.DataPropertyName = "Адрес"
        Me.АдресDataGridViewTextBoxColumn.HeaderText = "Адрес"
        Me.АдресDataGridViewTextBoxColumn.Name = "АдресDataGridViewTextBoxColumn"
        '
        'ПолDataGridViewTextBoxColumn
        '
        Me.ПолDataGridViewTextBoxColumn.DataPropertyName = "Пол"
        Me.ПолDataGridViewTextBoxColumn.HeaderText = "Пол"
        Me.ПолDataGridViewTextBoxColumn.Name = "ПолDataGridViewTextBoxColumn"
        '
        'ВозрастDataGridViewTextBoxColumn
        '
        Me.ВозрастDataGridViewTextBoxColumn.DataPropertyName = "Возраст"
        Me.ВозрастDataGridViewTextBoxColumn.HeaderText = "Возраст"
        Me.ВозрастDataGridViewTextBoxColumn.Name = "ВозрастDataGridViewTextBoxColumn"
        '
        'ФИОDataGridViewTextBoxColumn
        '
        Me.ФИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО"
        Me.ФИОDataGridViewTextBoxColumn.HeaderText = "ФИО"
        Me.ФИОDataGridViewTextBoxColumn.Name = "ФИОDataGridViewTextBoxColumn"
        '
        'Список_классовTableAdapter
        '
        Me.Список_классовTableAdapter.ClearBeforeFill = True
        '
        'УченикиBindingNavigator
        '
        Me.УченикиBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
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
        Me.УченикиBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.УченикиBindingNavigator.TabIndex = 86
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
        'Form25
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 483)
        Me.Controls.Add(Me.УченикиBindingNavigator)
        Me.Controls.Add(Me.Список_клаасовDataGridView)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form25"
        Me.Text = "Form25"
        CType(Me.СписокКлассовBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Список_клаасовDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.УченикиBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.УченикиBindingNavigator.ResumeLayout(False)
        Me.УченикиBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Список_клаасовDataGridView As DataGridView
    Friend WithEvents SchoolbdDataSet As schoolbdDataSet
    Friend WithEvents СписокКлассовBindingSource As BindingSource
    Friend WithEvents Список_классовTableAdapter As schoolbdDataSetTableAdapters.Список_классовTableAdapter
    Friend WithEvents КодКлассаDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents КоличествоУчениковDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents БукваDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ГодОбученияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ГодСозданияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents НаименованиеDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ОписаниеDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ПаспортныеДанныеDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ТелефонDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents КодДолжностиDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents АдресDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ПолDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ВозрастDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ФИОDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
End Class
