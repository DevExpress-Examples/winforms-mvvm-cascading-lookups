Namespace T223550
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.luMaster = New DevExpress.XtraEditors.LookUpEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.luChild = New DevExpress.XtraEditors.LookUpEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.mvvmContext1 = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            CType(Me.luMaster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.luChild.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'luMaster
            '
            Me.luMaster.Location = New System.Drawing.Point(86, 12)
            Me.luMaster.Name = "luMaster"
            Me.luMaster.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.luMaster.Size = New System.Drawing.Size(200, 20)
            Me.luMaster.StyleController = Me.layoutControl1
            Me.luMaster.TabIndex = 0
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.luChild)
            Me.layoutControl1.Controls.Add(Me.luMaster)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(355, 82, 250, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(576, 176)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            '
            'luChild
            '
            Me.luChild.Location = New System.Drawing.Point(364, 12)
            Me.luChild.Name = "luChild"
            Me.luChild.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.luChild.Size = New System.Drawing.Size(200, 20)
            Me.luChild.StyleController = Me.layoutControl1
            Me.luChild.TabIndex = 1
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(576, 176)
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.luMaster
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(278, 24)
            Me.layoutControlItem1.Text = "Master LookUp"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(71, 13)
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.luChild
            Me.layoutControlItem2.Location = New System.Drawing.Point(278, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(278, 24)
            Me.layoutControlItem2.Text = "Child LookUp"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(71, 13)
            '
            'emptySpaceItem1
            '
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 24)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(556, 132)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'mvvmContext1
            '
            Me.mvvmContext1.ContainerControl = Me
            Me.mvvmContext1.ViewModelType = GetType(T223550.ViewModels.OrdersViewModel)
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(576, 176)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "MainForm"
            Me.Text = "How to implement cascading LookUpEdits"
            CType(Me.luMaster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.luChild.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private luMaster As DevExpress.XtraEditors.LookUpEdit
		Private luChild As DevExpress.XtraEditors.LookUpEdit
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private mvvmContext1 As DevExpress.Utils.MVVM.MVVMContext
	End Class
End Namespace

