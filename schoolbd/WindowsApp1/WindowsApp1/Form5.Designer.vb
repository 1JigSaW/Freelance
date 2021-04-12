<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim ВозрастLabel As System.Windows.Forms.Label
        Dim ПолLabel As System.Windows.Forms.Label
        Dim АдресLabel As System.Windows.Forms.Label
        Dim ТелефонLabel As System.Windows.Forms.Label
        Dim Паспортные_данныеLabel As System.Windows.Forms.Label
        Dim Код_должностиLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SchoolbdDataSet = New WindowsApp1.schoolbdDataSet()
        Me.СотрудникиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СотрудникиTableAdapter = New WindowsApp1.schoolbdDataSetTableAdapters.СотрудникиTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.schoolbdDataSetTableAdapters.TableAdapterManager()
        Me.СотрудникиBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.СотрудникиBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ФИОTextBox = New System.Windows.Forms.TextBox()
        Me.ВозрастTextBox = New System.Windows.Forms.TextBox()
        Me.ПолTextBox = New System.Windows.Forms.TextBox()
        Me.АдресTextBox = New System.Windows.Forms.TextBox()
        Me.ТелефонTextBox = New System.Windows.Forms.TextBox()
        Me.Паспортные_данныеTextBox = New System.Windows.Forms.TextBox()
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
        ВозрастLabel = New System.Windows.Forms.Label()
        ПолLabel = New System.Windows.Forms.Label()
        АдресLabel = New System.Windows.Forms.Label()
        ТелефонLabel = New System.Windows.Forms.Label()
        Паспортные_данныеLabel = New System.Windows.Forms.Label()
        Код_должностиLabel = New System.Windows.Forms.Label()
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СотрудникиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СотрудникиBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.СотрудникиBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ФИОLabel
        '
        ФИОLabel.AutoSize = True
        ФИОLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ФИОLabel.Location = New System.Drawing.Point(172, 123)
        ФИОLabel.Name = "ФИОLabel"
        ФИОLabel.Size = New System.Drawing.Size(66, 25)
        ФИОLabel.TabIndex = 4
        ФИОLabel.Text = "ФИО:"
        '
        'ВозрастLabel
        '
        ВозрастLabel.AutoSize = True
        ВозрастLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ВозрастLabel.Location = New System.Drawing.Point(143, 164)
        ВозрастLabel.Name = "ВозрастLabel"
        ВозрастLabel.Size = New System.Drawing.Size(95, 25)
        ВозрастLabel.TabIndex = 5
        ВозрастLabel.Text = "Возраст:"
        '
        'ПолLabel
        '
        ПолLabel.AutoSize = True
        ПолLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ПолLabel.Location = New System.Drawing.Point(183, 210)
        ПолLabel.Name = "ПолLabel"
        ПолLabel.Size = New System.Drawing.Size(55, 25)
        ПолLabel.TabIndex = 6
        ПолLabel.Text = "Пол:"
        '
        'АдресLabel
        '
        АдресLabel.AutoSize = True
        АдресLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        АдресLabel.Location = New System.Drawing.Point(163, 252)
        АдресLabel.Name = "АдресLabel"
        АдресLabel.Size = New System.Drawing.Size(75, 25)
        АдресLabel.TabIndex = 8
        АдресLabel.Text = "Адрес:"
        '
        'ТелефонLabel
        '
        ТелефонLabel.AutoSize = True
        ТелефонLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ТелефонLabel.Location = New System.Drawing.Point(133, 294)
        ТелефонLabel.Name = "ТелефонLabel"
        ТелефонLabel.Size = New System.Drawing.Size(105, 25)
        ТелефонLabel.TabIndex = 10
        ТелефонLabel.Text = "Телефон:"
        '
        'Паспортные_данныеLabel
        '
        Паспортные_данныеLabel.AutoSize = True
        Паспортные_данныеLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Паспортные_данныеLabel.Location = New System.Drawing.Point(31, 338)
        Паспортные_данныеLabel.Name = "Паспортные_данныеLabel"
        Паспортные_данныеLabel.Size = New System.Drawing.Size(207, 25)
        Паспортные_данныеLabel.TabIndex = 12
        Паспортные_данныеLabel.Text = "Паспортные данные:"
        '
        'Код_должностиLabel
        '
        Код_должностиLabel.AutoSize = True
        Код_должностиLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Код_должностиLabel.Location = New System.Drawing.Point(73, 386)
        Код_должностиLabel.Name = "Код_должностиLabel"
        Код_должностиLabel.Size = New System.Drawing.Size(165, 25)
        Код_должностиLabel.TabIndex = 14
        Код_должностиLabel.Text = "Код должности:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(308, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Сотрудники"
        '
        'SchoolbdDataSet
        '
        Me.SchoolbdDataSet.DataSetName = "schoolbdDataSet"
        Me.SchoolbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'СотрудникиBindingSource
        '
        Me.СотрудникиBindingSource.DataMember = "Сотрудники"
        Me.СотрудникиBindingSource.DataSource = Me.SchoolbdDataSet
        '
        'СотрудникиTableAdapter
        '
        Me.СотрудникиTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.СотрудникиTableAdapter = Me.СотрудникиTableAdapter
        Me.TableAdapterManager.УченикиTableAdapter = Nothing
        '
        'СотрудникиBindingNavigator
        '
        Me.СотрудникиBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.СотрудникиBindingNavigator.BindingSource = Me.СотрудникиBindingSource
        Me.СотрудникиBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.СотрудникиBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.СотрудникиBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.СотрудникиBindingNavigatorSaveItem})
        Me.СотрудникиBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.СотрудникиBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.СотрудникиBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.СотрудникиBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.СотрудникиBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.СотрудникиBindingNavigator.Name = "СотрудникиBindingNavigator"
        Me.СотрудникиBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.СотрудникиBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.СотрудникиBindingNavigator.TabIndex = 4
        Me.СотрудникиBindingNavigator.Text = "BindingNavigator1"
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
        'СотрудникиBindingNavigatorSaveItem
        '
        Me.СотрудникиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.СотрудникиBindingNavigatorSaveItem.Image = CType(resources.GetObject("СотрудникиBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.СотрудникиBindingNavigatorSaveItem.Name = "СотрудникиBindingNavigatorSaveItem"
        Me.СотрудникиBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.СотрудникиBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'ФИОTextBox
        '
        Me.ФИОTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СотрудникиBindingSource, "ФИО", True))
        Me.ФИОTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ФИОTextBox.Location = New System.Drawing.Point(244, 120)
        Me.ФИОTextBox.Name = "ФИОTextBox"
        Me.ФИОTextBox.Size = New System.Drawing.Size(400, 30)
        Me.ФИОTextBox.TabIndex = 5
        '
        'ВозрастTextBox
        '
        Me.ВозрастTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СотрудникиBindingSource, "Возраст", True))
        Me.ВозрастTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ВозрастTextBox.Location = New System.Drawing.Point(244, 164)
        Me.ВозрастTextBox.Name = "ВозрастTextBox"
        Me.ВозрастTextBox.Size = New System.Drawing.Size(400, 30)
        Me.ВозрастTextBox.TabIndex = 6
        '
        'ПолTextBox
        '
        Me.ПолTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СотрудникиBindingSource, "Пол", True))
        Me.ПолTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ПолTextBox.Location = New System.Drawing.Point(244, 207)
        Me.ПолTextBox.Name = "ПолTextBox"
        Me.ПолTextBox.Size = New System.Drawing.Size(400, 30)
        Me.ПолTextBox.TabIndex = 7
        '
        'АдресTextBox
        '
        Me.АдресTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СотрудникиBindingSource, "Адрес", True))
        Me.АдресTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.АдресTextBox.Location = New System.Drawing.Point(244, 249)
        Me.АдресTextBox.Name = "АдресTextBox"
        Me.АдресTextBox.Size = New System.Drawing.Size(400, 30)
        Me.АдресTextBox.TabIndex = 9
        '
        'ТелефонTextBox
        '
        Me.ТелефонTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СотрудникиBindingSource, "Телефон", True))
        Me.ТелефонTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ТелефонTextBox.Location = New System.Drawing.Point(244, 291)
        Me.ТелефонTextBox.Name = "ТелефонTextBox"
        Me.ТелефонTextBox.Size = New System.Drawing.Size(400, 30)
        Me.ТелефонTextBox.TabIndex = 11
        '
        'Паспортные_данныеTextBox
        '
        Me.Паспортные_данныеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СотрудникиBindingSource, "Паспортные данные", True))
        Me.Паспортные_данныеTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Паспортные_данныеTextBox.Location = New System.Drawing.Point(244, 335)
        Me.Паспортные_данныеTextBox.Name = "Паспортные_данныеTextBox"
        Me.Паспортные_данныеTextBox.Size = New System.Drawing.Size(400, 30)
        Me.Паспортные_данныеTextBox.TabIndex = 13
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(468, 494)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(112, 34)
        Me.Button7.TabIndex = 22
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(340, 494)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 34)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(212, 494)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 34)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Следующая"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(532, 439)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 34)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Последняя"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(407, 439)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 34)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(276, 439)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 34)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Предыдущая"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(145, 439)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Первая"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Учитель", "Секретарь", "Директор", "Заместитель директора", "Психолог"})
        Me.ComboBox1.Location = New System.Drawing.Point(244, 383)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(400, 33)
        Me.ComboBox1.TabIndex = 23
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(596, 494)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(112, 34)
        Me.Button8.TabIndex = 24
        Me.Button8.Text = "Таблица"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 548)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Код_должностиLabel)
        Me.Controls.Add(Паспортные_данныеLabel)
        Me.Controls.Add(Me.Паспортные_данныеTextBox)
        Me.Controls.Add(ТелефонLabel)
        Me.Controls.Add(Me.ТелефонTextBox)
        Me.Controls.Add(АдресLabel)
        Me.Controls.Add(Me.АдресTextBox)
        Me.Controls.Add(ПолLabel)
        Me.Controls.Add(Me.ПолTextBox)
        Me.Controls.Add(ВозрастLabel)
        Me.Controls.Add(Me.ВозрастTextBox)
        Me.Controls.Add(ФИОLabel)
        Me.Controls.Add(Me.ФИОTextBox)
        Me.Controls.Add(Me.СотрудникиBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СотрудникиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СотрудникиBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.СотрудникиBindingNavigator.ResumeLayout(False)
        Me.СотрудникиBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SchoolbdDataSet As schoolbdDataSet
    Friend WithEvents СотрудникиBindingSource As BindingSource
    Friend WithEvents СотрудникиTableAdapter As schoolbdDataSetTableAdapters.СотрудникиTableAdapter
    Friend WithEvents TableAdapterManager As schoolbdDataSetTableAdapters.TableAdapterManager
    Friend WithEvents СотрудникиBindingNavigator As BindingNavigator
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
    Friend WithEvents СотрудникиBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ФИОTextBox As TextBox
    Friend WithEvents ВозрастTextBox As TextBox
    Friend WithEvents ПолTextBox As TextBox
    Friend WithEvents АдресTextBox As TextBox
    Friend WithEvents ТелефонTextBox As TextBox
    Friend WithEvents Паспортные_данныеTextBox As TextBox
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
