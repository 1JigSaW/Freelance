<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SchoolbdDataSet = New WindowsApp1.schoolbdDataSet()
        Me.Виды_классовBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Виды_классовTableAdapter = New WindowsApp1.schoolbdDataSetTableAdapters.Виды_классовTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.schoolbdDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Виды_классовBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(321, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "БД Школы"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(95, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 49)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Виды классов"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(271, 119)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 49)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Должности"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(445, 119)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 49)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Классы"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(621, 119)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(135, 49)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Сотрудники"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(170, 274)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(135, 49)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Предметы"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(348, 274)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(135, 49)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Ученики"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(518, 274)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(135, 49)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Расписание"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(673, 402)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(115, 36)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "О программе"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(13, 456)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(135, 49)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "Отдел кадров"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(171, 456)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(135, 49)
        Me.Button10.TabIndex = 10
        Me.Button10.Text = "Расписание занятий"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(329, 456)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(135, 49)
        Me.Button11.TabIndex = 11
        Me.Button11.Text = "Список классов"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(487, 456)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(135, 49)
        Me.Button12.TabIndex = 12
        Me.Button12.Text = "Список предметов"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(641, 456)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(135, 49)
        Me.Button13.TabIndex = 13
        Me.Button13.Text = "Список учеников"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 577)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Виды_классовBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SchoolbdDataSet As schoolbdDataSet
    Friend WithEvents Виды_классовBindingSource As BindingSource
    Friend WithEvents Виды_классовTableAdapter As schoolbdDataSetTableAdapters.Виды_классовTableAdapter
    Friend WithEvents TableAdapterManager As schoolbdDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
End Class
