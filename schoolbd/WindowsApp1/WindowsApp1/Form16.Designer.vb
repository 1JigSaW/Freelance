<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form16
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SchoolbdDataSet = New WindowsApp1.schoolbdDataSet()
        Me.Виды_классовBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Виды_классовTableAdapter = New WindowsApp1.schoolbdDataSetTableAdapters.Виды_классовTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Виды_классовBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(253, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Отчет таблицы ""Виды классов"""
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
        'ReportViewer1
        '
        ReportDataSource1.Name = "schoolbd"
        ReportDataSource1.Value = Me.Виды_классовBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApp1.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(202, 121)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 1
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form16"
        Me.Text = "Form16"
        CType(Me.SchoolbdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Виды_классовBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SchoolbdDataSet As schoolbdDataSet
    Friend WithEvents Виды_классовBindingSource As BindingSource
    Friend WithEvents Виды_классовTableAdapter As schoolbdDataSetTableAdapters.Виды_классовTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
