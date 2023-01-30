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
        Dim IdLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim RollLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LoginCrudDataSet = New Login_con_Crud.LoginCrudDataSet()
        Me.TablaLoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TablaLoginTableAdapter = New Login_con_Crud.LoginCrudDataSetTableAdapters.TablaLoginTableAdapter()
        Me.TableAdapterManager = New Login_con_Crud.LoginCrudDataSetTableAdapters.TableAdapterManager()
        Me.TablaLoginBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TablaLoginBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.RollTextBox = New System.Windows.Forms.TextBox()
        Me.btn_iniciar = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        RollLabel = New System.Windows.Forms.Label()
        CType(Me.LoginCrudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaLoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaLoginBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TablaLoginBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(139, 55)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Location = New System.Drawing.Point(94, 107)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(64, 13)
        ContraseñaLabel.TabIndex = 3
        ContraseñaLabel.Text = "Contraseña:"
        '
        'RollLabel
        '
        RollLabel.AutoSize = True
        RollLabel.Location = New System.Drawing.Point(130, 163)
        RollLabel.Name = "RollLabel"
        RollLabel.Size = New System.Drawing.Size(28, 13)
        RollLabel.TabIndex = 5
        RollLabel.Text = "Roll:"
        '
        'LoginCrudDataSet
        '
        Me.LoginCrudDataSet.DataSetName = "LoginCrudDataSet"
        Me.LoginCrudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TablaLoginBindingSource
        '
        Me.TablaLoginBindingSource.DataMember = "TablaLogin"
        Me.TablaLoginBindingSource.DataSource = Me.LoginCrudDataSet
        '
        'TablaLoginTableAdapter
        '
        Me.TablaLoginTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TablaLoginTableAdapter = Me.TablaLoginTableAdapter
        Me.TableAdapterManager.UpdateOrder = Login_con_Crud.LoginCrudDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TablaLoginBindingNavigator
        '
        Me.TablaLoginBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TablaLoginBindingNavigator.BindingSource = Me.TablaLoginBindingSource
        Me.TablaLoginBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TablaLoginBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TablaLoginBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TablaLoginBindingNavigatorSaveItem})
        Me.TablaLoginBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TablaLoginBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TablaLoginBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TablaLoginBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TablaLoginBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TablaLoginBindingNavigator.Name = "TablaLoginBindingNavigator"
        Me.TablaLoginBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TablaLoginBindingNavigator.Size = New System.Drawing.Size(406, 25)
        Me.TablaLoginBindingNavigator.TabIndex = 0
        Me.TablaLoginBindingNavigator.Text = "BindingNavigator1"
        Me.TablaLoginBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
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
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TablaLoginBindingNavigatorSaveItem
        '
        Me.TablaLoginBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TablaLoginBindingNavigatorSaveItem.Image = CType(resources.GetObject("TablaLoginBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TablaLoginBindingNavigatorSaveItem.Name = "TablaLoginBindingNavigatorSaveItem"
        Me.TablaLoginBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TablaLoginBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablaLoginBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(164, 52)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablaLoginBindingSource, "Contraseña", True))
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(164, 104)
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContraseñaTextBox.TabIndex = 4
        '
        'RollTextBox
        '
        Me.RollTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablaLoginBindingSource, "Roll", True))
        Me.RollTextBox.Location = New System.Drawing.Point(164, 160)
        Me.RollTextBox.Name = "RollTextBox"
        Me.RollTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RollTextBox.TabIndex = 6
        '
        'btn_iniciar
        '
        Me.btn_iniciar.Location = New System.Drawing.Point(164, 215)
        Me.btn_iniciar.Name = "btn_iniciar"
        Me.btn_iniciar.Size = New System.Drawing.Size(75, 23)
        Me.btn_iniciar.TabIndex = 7
        Me.btn_iniciar.Text = "Iniciar"
        Me.btn_iniciar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 364)
        Me.Controls.Add(Me.btn_iniciar)
        Me.Controls.Add(RollLabel)
        Me.Controls.Add(Me.RollTextBox)
        Me.Controls.Add(ContraseñaLabel)
        Me.Controls.Add(Me.ContraseñaTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.TablaLoginBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.LoginCrudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaLoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaLoginBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TablaLoginBindingNavigator.ResumeLayout(False)
        Me.TablaLoginBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginCrudDataSet As LoginCrudDataSet
    Friend WithEvents TablaLoginBindingSource As BindingSource
    Friend WithEvents TablaLoginTableAdapter As LoginCrudDataSetTableAdapters.TablaLoginTableAdapter
    Friend WithEvents TableAdapterManager As LoginCrudDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TablaLoginBindingNavigator As BindingNavigator
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
    Friend WithEvents TablaLoginBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents RollTextBox As TextBox
    Private WithEvents btn_iniciar As Button
End Class
