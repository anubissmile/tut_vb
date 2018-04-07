<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TestdbDataSet = New Employee.testdbDataSet()
        Me.TestdbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResuserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Res_userTableAdapter = New Employee.testdbDataSetTableAdapters.res_userTableAdapter()
        Me.TestdbDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreateddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResuserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestdbDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.BirthdateDataGridViewTextBoxColumn, Me.CreateddateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ResuserBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(108, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(766, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'TestdbDataSet
        '
        Me.TestdbDataSet.DataSetName = "testdbDataSet"
        Me.TestdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestdbDataSetBindingSource
        '
        Me.TestdbDataSetBindingSource.DataSource = Me.TestdbDataSet
        Me.TestdbDataSetBindingSource.Position = 0
        '
        'ResuserBindingSource
        '
        Me.ResuserBindingSource.DataMember = "res_user"
        Me.ResuserBindingSource.DataSource = Me.TestdbDataSetBindingSource
        '
        'Res_userTableAdapter
        '
        Me.Res_userTableAdapter.ClearBeforeFill = True
        '
        'TestdbDataSetBindingSource1
        '
        Me.TestdbDataSetBindingSource1.DataSource = Me.TestdbDataSet
        Me.TestdbDataSetBindingSource1.Position = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'BirthdateDataGridViewTextBoxColumn
        '
        Me.BirthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.HeaderText = "birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.Name = "BirthdateDataGridViewTextBoxColumn"
        '
        'CreateddateDataGridViewTextBoxColumn
        '
        Me.CreateddateDataGridViewTextBoxColumn.DataPropertyName = "created_date"
        Me.CreateddateDataGridViewTextBoxColumn.HeaderText = "created_date"
        Me.CreateddateDataGridViewTextBoxColumn.Name = "CreateddateDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 366)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResuserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestdbDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TestdbDataSetBindingSource As BindingSource
    Friend WithEvents TestdbDataSet As testdbDataSet
    Friend WithEvents ResuserBindingSource As BindingSource
    Friend WithEvents Res_userTableAdapter As testdbDataSetTableAdapters.res_userTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreateddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestdbDataSetBindingSource1 As BindingSource
End Class
