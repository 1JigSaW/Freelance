<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form34
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.schoolbdDataSet = New WindowsApp1.schoolbdDataSet()
        Me.Отдел_кадровBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Отдел_кадровTableAdapter = New WindowsApp1.schoolbdDataSetTableAdapters.Отдел_кадровTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.schoolbdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Отдел_кадровBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Отдел_кадровBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApp1.Report14.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(148, 94)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(495, 297)
        Me.ReportViewer1.TabIndex = 0
        '
        'schoolbdDataSet
        '
        Me.schoolbdDataSet.DataSetName = "schoolbdDataSet"
        Me.schoolbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Отдел_кадровBindingSource
        '
        Me.Отдел_кадровBindingSource.DataMember = "Отдел кадров"
        Me.Отдел_кадровBindingSource.DataSource = Me.schoolbdDataSet
        '
        'Отдел_кадровTableAdapter
        '
        Me.Отдел_кадровTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "График"
        '
        'Form34
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form34"
        Me.Text = "Form34"
        CType(Me.schoolbdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Отдел_кадровBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Отдел_кадровBindingSource As BindingSource
    Friend WithEvents schoolbdDataSet As schoolbdDataSet
    Friend WithEvents Отдел_кадровTableAdapter As schoolbdDataSetTableAdapters.Отдел_кадровTableAdapter
    Friend WithEvents Label1 As Label
End Class
