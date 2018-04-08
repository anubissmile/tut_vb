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
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreateddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResuserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestdbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestdbDataSet = New Employee.testdbDataSet()
        Me.Res_userTableAdapter = New Employee.testdbDataSetTableAdapters.res_userTableAdapter()
        Me.TestdbDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResuserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestdbDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.BirthdateDataGridViewTextBoxColumn, Me.CreateddateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ResuserBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(973, 236)
        Me.DataGridView1.TabIndex = 0
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
        'ResuserBindingSource
        '
        Me.ResuserBindingSource.DataMember = "res_user"
        Me.ResuserBindingSource.DataSource = Me.TestdbDataSetBindingSource
        '
        'TestdbDataSetBindingSource
        '
        Me.TestdbDataSetBindingSource.DataSource = Me.TestdbDataSet
        Me.TestdbDataSetBindingSource.Position = 0
        '
        'TestdbDataSet
        '
        Me.TestdbDataSet.DataSetName = "testdbDataSet"
        Me.TestdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(128, 23)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(184, 22)
        Me.txtName.TabIndex = 1
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(128, 68)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(184, 22)
        Me.txtAge.TabIndex = 2
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(453, 22)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(184, 22)
        Me.txtLastname.TabIndex = 3
        '
        'txtBirth
        '
        Me.txtBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtBirth.Location = New System.Drawing.Point(453, 67)
        Me.txtBirth.Name = "txtBirth"
        Me.txtBirth.Size = New System.Drawing.Size(200, 22)
        Me.txtBirth.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(365, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Lastname : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Age : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(365, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Birth Date : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(765, 39)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(139, 45)
        Me.btnRegister.TabIndex = 10
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 366)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBirth)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResuserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestdbDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtBirth As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegister As Button
End Class
