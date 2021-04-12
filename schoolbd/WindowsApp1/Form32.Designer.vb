<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form32
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.schoolbdDataSet = New WindowsApp1.schoolbdDataSet()
        Me.Список_учениковBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Список_учениковTableAdapter = New WindowsApp1.schoolbdDataSetTableAdapters.Список_учениковTableAdapter()
        CType(Me.schoolbdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Список_учениковBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Отчет  ""Списка учеников"""
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Список_учениковBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApp1.Report12.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(199, 117)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 7
        '
        'schoolbdDataSet
        '
        Me.schoolbdDataSet.DataSetName = "schoolbdDataSet"
        Me.schoolbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Список_учениковBindingSource
        '
        Me.Список_учениковBindingSource.DataMember = "Список учеников"
        Me.Список_учениковBindingSource.DataSource = Me.schoolbdDataSet
        '
        'Список_учениковTableAdapter
        '
        Me.Список_учениковTableAdapter.ClearBeforeFill = True
        '
        'Form32
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form32"
        Me.Text = "Form32"
        CType(Me.schoolbdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Список_учениковBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Список_учениковBindingSource As BindingSource
    Friend WithEvents schoolbdDataSet As schoolbdDataSet
    Friend WithEvents Список_учениковTableAdapter As schoolbdDataSetTableAdapters.Список_учениковTableAdapter
End Class
