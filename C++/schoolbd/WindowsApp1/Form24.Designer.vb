<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form24
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.РасписаниеЗанятийBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolbdDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Расписание_занятийTableAdapter = New WindowsApp1.schoolbdDataSetTableAdapters.Расписание_занятийTableAdapter()
        Me.Список_классовBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Список_классовTableAdapter = New WindowsApp1.schoolbdDataSetTableAdapters.Список_классовTableAdapter()
        Me.РасписаниеЗанятийBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.РасписаниеЗанятийBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.РасписаниеЗанятийBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Расписание_занятийDataGridView = New System.Windows.Forms.DataGridView()
        Me.ДеньНеделиDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ДатаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ВремяНачалаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ВремяОкончанияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ОписаниеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.НаименованиеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ГодСозданияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ГодОбученияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.БукваDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.КоличествоУчениковDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.РасписаниеЗанятийBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolbdDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Список_классовBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РасписаниеЗанятийBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РасписаниеЗанятийBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РасписаниеЗанятийBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Расписание_занятийDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(561, 428)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(225, 32)
        Me.Button6.TabIndex = 46
        Me.Button6.Text = "Отчет"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(675, 391)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(111, 32)
        Me.Button5.TabIndex = 45
        Me.Button5.Text = "Закрыть"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(561, 390)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 32)
        Me.Button4.TabIndex = 44
        Me.Button4.Text = "Найти"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(675, 355)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 32)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "Показать все"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(561, 355)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 32)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Фильтровать"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(122, 355)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(433, 29)
        Me.TextBox1.TabIndex = 41
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.РасписаниеЗанятийBindingSource
        Me.ComboBox1.DisplayMember = "Буква"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(122, 390)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(433, 32)
        Me.ComboBox1.TabIndex = 40
        '
        'РасписаниеЗанятийBindingSource
        '
        Me.РасписаниеЗанятийBindingSource.DataMember = "Расписание занятий"
        Me.РасписаниеЗанятийBindingSource.DataSource = Me.SchoolbdDataSetBindingSource
        '
        'SchoolbdDataSetBindingSource
        '
        Me.SchoolbdDataSetBindingSource.DataSource = Me.SchoolbdDataSet
        Me.SchoolbdDataSetBindingSource.Position = 0
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
        Me.Label4.Location = New System.Drawing.Point(44, 399)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Критерий"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 364)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 38
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
        Me.GroupBox1.Location = New System.Drawing.Point(561, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 315)
        Me.GroupBox1.TabIndex = 37
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
        Me.ListBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 24
        Me.ListBox1.Items.AddRange(New Object() {"День недели", "Дата", "Время начала", "Время окончания", "Описание", "Наименование", "Год создания", "Год обучения", "Буква", "Количество учеников"})
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
        Me.Label1.Location = New System.Drawing.Point(214, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 24)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Расписание занятий (Табличный вид)"
        '
        'Расписание_занятийTableAdapter
        '
        Me.Расписание_занятийTableAdapter.ClearBeforeFill = True
        '
        'Список_классовBindingSource
        '
        Me.Список_классовBindingSource.DataMember = "Список классов"
        Me.Список_классовBindingSource.DataSource = Me.SchoolbdDataSet
        '
        'Список_классовTableAdapter
        '
        Me.Список_классовTableAdapter.ClearBeforeFill = True
        '
        'РасписаниеЗанятийBindingSource1
        '
        Me.РасписаниеЗанятийBindingSource1.DataMember = "Расписание занятий"
        Me.РасписаниеЗанятийBindingSource1.DataSource = Me.SchoolbdDataSetBindingSource
        '
        'РасписаниеЗанятийBindingSource2
        '
        Me.РасписаниеЗанятийBindingSource2.DataMember = "Расписание занятий"
        Me.РасписаниеЗанятийBindingSource2.DataSource = Me.SchoolbdDataSet
        '
        'РасписаниеЗанятийBindingSource3
        '
        Me.РасписаниеЗанятийBindingSource3.DataMember = "Расписание занятий"
        Me.РасписаниеЗанятийBindingSource3.DataSource = Me.SchoolbdDataSetBindingSource
        '
        'Расписание_занятийDataGridView
        '
        Me.Расписание_занятийDataGridView.AutoGenerateColumns = False
        Me.Расписание_занятийDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Расписание_занятийDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ДеньНеделиDataGridViewTextBoxColumn, Me.ДатаDataGridViewTextBoxColumn, Me.ВремяНачалаDataGridViewTextBoxColumn, Me.ВремяОкончанияDataGridViewTextBoxColumn, Me.ОписаниеDataGridViewTextBoxColumn, Me.НаименованиеDataGridViewTextBoxColumn, Me.ГодСозданияDataGridViewTextBoxColumn, Me.ГодОбученияDataGridViewTextBoxColumn, Me.БукваDataGridViewTextBoxColumn, Me.КоличествоУчениковDataGridViewTextBoxColumn})
        Me.Расписание_занятийDataGridView.DataSource = Me.РасписаниеЗанятийBindingSource
        Me.Расписание_занятийDataGridView.Location = New System.Drawing.Point(12, 49)
        Me.Расписание_занятийDataGridView.Name = "Расписание_занятийDataGridView"
        Me.Расписание_занятийDataGridView.Size = New System.Drawing.Size(530, 294)
        Me.Расписание_занятийDataGridView.TabIndex = 47
        '
        'ДеньНеделиDataGridViewTextBoxColumn
        '
        Me.ДеньНеделиDataGridViewTextBoxColumn.DataPropertyName = "День недели"
        Me.ДеньНеделиDataGridViewTextBoxColumn.HeaderText = "День недели"
        Me.ДеньНеделиDataGridViewTextBoxColumn.Name = "ДеньНеделиDataGridViewTextBoxColumn"
        '
        'ДатаDataGridViewTextBoxColumn
        '
        Me.ДатаDataGridViewTextBoxColumn.DataPropertyName = "Дата"
        Me.ДатаDataGridViewTextBoxColumn.HeaderText = "Дата"
        Me.ДатаDataGridViewTextBoxColumn.Name = "ДатаDataGridViewTextBoxColumn"
        '
        'ВремяНачалаDataGridViewTextBoxColumn
        '
        Me.ВремяНачалаDataGridViewTextBoxColumn.DataPropertyName = "Время начала"
        Me.ВремяНачалаDataGridViewTextBoxColumn.HeaderText = "Время начала"
        Me.ВремяНачалаDataGridViewTextBoxColumn.Name = "ВремяНачалаDataGridViewTextBoxColumn"
        '
        'ВремяОкончанияDataGridViewTextBoxColumn
        '
        Me.ВремяОкончанияDataGridViewTextBoxColumn.DataPropertyName = "Время окончания"
        Me.ВремяОкончанияDataGridViewTextBoxColumn.HeaderText = "Время окончания"
        Me.ВремяОкончанияDataGridViewTextBoxColumn.Name = "ВремяОкончанияDataGridViewTextBoxColumn"
        '
        'ОписаниеDataGridViewTextBoxColumn
        '
        Me.ОписаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание"
        Me.ОписаниеDataGridViewTextBoxColumn.HeaderText = "Описание"
        Me.ОписаниеDataGridViewTextBoxColumn.Name = "ОписаниеDataGridViewTextBoxColumn"
        '
        'НаименованиеDataGridViewTextBoxColumn
        '
        Me.НаименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование"
        Me.НаименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование"
        Me.НаименованиеDataGridViewTextBoxColumn.Name = "НаименованиеDataGridViewTextBoxColumn"
        '
        'ГодСозданияDataGridViewTextBoxColumn
        '
        Me.ГодСозданияDataGridViewTextBoxColumn.DataPropertyName = "Год создания"
        Me.ГодСозданияDataGridViewTextBoxColumn.HeaderText = "Год создания"
        Me.ГодСозданияDataGridViewTextBoxColumn.Name = "ГодСозданияDataGridViewTextBoxColumn"
        '
        'ГодОбученияDataGridViewTextBoxColumn
        '
        Me.ГодОбученияDataGridViewTextBoxColumn.DataPropertyName = "Год обучения"
        Me.ГодОбученияDataGridViewTextBoxColumn.HeaderText = "Год обучения"
        Me.ГодОбученияDataGridViewTextBoxColumn.Name = "ГодОбученияDataGridViewTextBoxColumn"
        '
        'БукваDataGridViewTextBoxColumn
        '
        Me.БукваDataGridViewTextBoxColumn.DataPropertyName = "Буква"
        Me.БукваDataGridViewTextBoxColumn.HeaderText = "Буква"
        Me.БукваDataGridViewTextBoxColumn.Name = "БукваDataGridViewTextBoxColumn"
        '
        'КоличествоУчениковDataGridViewTextBoxColumn
        '
        Me.КоличествоУчениковDataGridViewTextBoxColumn.DataPropertyName = "Количество учеников"
        Me.КоличествоУчениковDataGridViewTextBoxColumn.HeaderText = "Количество учеников"
        Me.КоличествоУчениковDataGridViewTextBoxColumn.Name = "КоличествоУчениковDataGridViewTextBoxColumn"
        '
        'Form24
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 489)
        Me.Controls.Add(Me.Расписание_занятийDataGridView)
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
        Me.Name = "Form24"
        Me.Text = "Form24"
        CType(Me.РасписаниеЗанятийBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolbdDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Список_классовBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РасписаниеЗанятийBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РасписаниеЗанятийBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РасписаниеЗанятийBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Расписание_занятийDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SchoolbdDataSetBindingSource As BindingSource
    Friend WithEvents SchoolbdDataSet As schoolbdDataSet
    Friend WithEvents РасписаниеЗанятийBindingSource As BindingSource
    Friend WithEvents Расписание_занятийTableAdapter As schoolbdDataSetTableAdapters.Расписание_занятийTableAdapter
    Friend WithEvents Список_классовBindingSource As BindingSource
    Friend WithEvents Список_классовTableAdapter As schoolbdDataSetTableAdapters.Список_классовTableAdapter
    Friend WithEvents РасписаниеЗанятийBindingSource1 As BindingSource
    Friend WithEvents РасписаниеЗанятийBindingSource2 As BindingSource
    Friend WithEvents РасписаниеЗанятийBindingSource3 As BindingSource
    Friend WithEvents Расписание_занятийDataGridView As DataGridView
    Friend WithEvents ДеньНеделиDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ДатаDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ВремяНачалаDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ВремяОкончанияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ОписаниеDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents НаименованиеDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ГодСозданияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ГодОбученияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents БукваDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents КоличествоУчениковDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
