<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form21
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
        Me.УченикиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.УченикиTableAdapter = New WindowsApp1.schoolbdDataSetTableAdapters.УченикиTableAdapter()
        CType(Me.schoolbdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.УченикиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Отчет таблицы ""Ученики"""
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.УченикиBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApp1.Report6.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(150, 90)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(500, 271)
        Me.ReportViewer1.TabIndex = 6
        '
        'schoolbdDataSet
        '
        Me.schoolbdDataSet.DataSetName = "schoolbdDataSet"
        Me.schoolbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'УченикиBindingSource
        '
        Me.УченикиBindingSource.DataMember = "Ученики"
        Me.УченикиBindingSource.DataSource = Me.schoolbdDataSet
        '
        'УченикиTableAdapter
        '
        Me.УченикиTableAdapter.ClearBeforeFill = True
        '
        'Form21
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form21"
        Me.Text = "Form21"
        CType(Me.schoolbdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.УченикиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents УченикиBindingSource As BindingSource
    Friend WithEvents schoolbdDataSet As schoolbdDataSet
    Friend WithEvents УченикиTableAdapter As schoolbdDataSetTableAdapters.УченикиTableAdapter
End Class
