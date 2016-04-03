<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Customer_idLabel As System.Windows.Forms.Label
        Dim Customer_nameLabel As System.Windows.Forms.Label
        Dim Customer_PhoneLabel As System.Windows.Forms.Label
        Dim Order_DateLabel As System.Windows.Forms.Label
        Dim Order_TimeLabel As System.Windows.Forms.Label
        Dim Ref_NoLabel As System.Windows.Forms.Label
        Dim Qty2Label As System.Windows.Forms.Label
        Dim Qty3Label As System.Windows.Forms.Label
        Dim Sub_Total1Label As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim SubTotalLabel As System.Windows.Forms.Label
        Dim TaxLabel As System.Windows.Forms.Label
        Dim OrderSubTotalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ref_NoTextBox = New System.Windows.Forms.TextBox()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_dataDataSet = New database_system.Order_dataDataSet()
        Me.Order_TimeTextBox = New System.Windows.Forms.TextBox()
        Me.Order_DateTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_idTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Sub_Total3TextBox = New System.Windows.Forms.TextBox()
        Me.Sub_Total2TextBox = New System.Windows.Forms.TextBox()
        Me.Sub_Total1TextBox = New System.Windows.Forms.TextBox()
        Me.Unit_Price3TextBox = New System.Windows.Forms.TextBox()
        Me.Unit_Price2TextBox = New System.Windows.Forms.TextBox()
        Me.Unit_Price1TextBox = New System.Windows.Forms.TextBox()
        Me.Qty3TextBox = New System.Windows.Forms.TextBox()
        Me.Qty2TextBox = New System.Windows.Forms.TextBox()
        Me.Qty1TextBox = New System.Windows.Forms.TextBox()
        Me.btnCart = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnReicept = New System.Windows.Forms.Button()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnCC = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.LblConvert = New System.Windows.Forms.Label()
        Me.txtConversion = New System.Windows.Forms.TextBox()
        Me.Cmbcurrency = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblShowCal = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtReicept = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.OrderSubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.TaxTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.TableTableAdapter = New database_system.Order_dataDataSetTableAdapters.TableTableAdapter()
        Me.TableAdapterManager = New database_system.Order_dataDataSetTableAdapters.TableAdapterManager()
        Me.TableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Customer_idLabel = New System.Windows.Forms.Label()
        Customer_nameLabel = New System.Windows.Forms.Label()
        Customer_PhoneLabel = New System.Windows.Forms.Label()
        Order_DateLabel = New System.Windows.Forms.Label()
        Order_TimeLabel = New System.Windows.Forms.Label()
        Ref_NoLabel = New System.Windows.Forms.Label()
        Qty2Label = New System.Windows.Forms.Label()
        Qty3Label = New System.Windows.Forms.Label()
        Sub_Total1Label = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        SubTotalLabel = New System.Windows.Forms.Label()
        TaxLabel = New System.Windows.Forms.Label()
        OrderSubTotalLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_dataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Customer_idLabel
        '
        Customer_idLabel.AutoSize = True
        Customer_idLabel.Location = New System.Drawing.Point(34, 78)
        Customer_idLabel.Name = "Customer_idLabel"
        Customer_idLabel.Size = New System.Drawing.Size(65, 13)
        Customer_idLabel.TabIndex = 1
        Customer_idLabel.Text = "Customer id:"
        '
        'Customer_nameLabel
        '
        Customer_nameLabel.AutoSize = True
        Customer_nameLabel.Location = New System.Drawing.Point(16, 128)
        Customer_nameLabel.Name = "Customer_nameLabel"
        Customer_nameLabel.Size = New System.Drawing.Size(83, 13)
        Customer_nameLabel.TabIndex = 3
        Customer_nameLabel.Text = "Customer name:"
        '
        'Customer_PhoneLabel
        '
        Customer_PhoneLabel.AutoSize = True
        Customer_PhoneLabel.Location = New System.Drawing.Point(11, 185)
        Customer_PhoneLabel.Name = "Customer_PhoneLabel"
        Customer_PhoneLabel.Size = New System.Drawing.Size(88, 13)
        Customer_PhoneLabel.TabIndex = 5
        Customer_PhoneLabel.Text = "Customer Phone:"
        '
        'Order_DateLabel
        '
        Order_DateLabel.AutoSize = True
        Order_DateLabel.Location = New System.Drawing.Point(277, 75)
        Order_DateLabel.Name = "Order_DateLabel"
        Order_DateLabel.Size = New System.Drawing.Size(62, 13)
        Order_DateLabel.TabIndex = 7
        Order_DateLabel.Text = "Order Date:"
        '
        'Order_TimeLabel
        '
        Order_TimeLabel.AutoSize = True
        Order_TimeLabel.Location = New System.Drawing.Point(277, 125)
        Order_TimeLabel.Name = "Order_TimeLabel"
        Order_TimeLabel.Size = New System.Drawing.Size(62, 13)
        Order_TimeLabel.TabIndex = 9
        Order_TimeLabel.Text = "Order Time:"
        '
        'Ref_NoLabel
        '
        Ref_NoLabel.AutoSize = True
        Ref_NoLabel.Location = New System.Drawing.Point(295, 185)
        Ref_NoLabel.Name = "Ref_NoLabel"
        Ref_NoLabel.Size = New System.Drawing.Size(44, 13)
        Ref_NoLabel.TabIndex = 11
        Ref_NoLabel.Text = "Ref No:"
        '
        'Qty2Label
        '
        Qty2Label.AutoSize = True
        Qty2Label.Location = New System.Drawing.Point(122, 79)
        Qty2Label.Name = "Qty2Label"
        Qty2Label.Size = New System.Drawing.Size(23, 13)
        Qty2Label.TabIndex = 9
        Qty2Label.Text = "Qty"
        '
        'Qty3Label
        '
        Qty3Label.AutoSize = True
        Qty3Label.Location = New System.Drawing.Point(256, 79)
        Qty3Label.Name = "Qty3Label"
        Qty3Label.Size = New System.Drawing.Size(53, 13)
        Qty3Label.TabIndex = 11
        Qty3Label.Text = "Unit Price"
        '
        'Sub_Total1Label
        '
        Sub_Total1Label.AutoSize = True
        Sub_Total1Label.Location = New System.Drawing.Point(373, 79)
        Sub_Total1Label.Name = "Sub_Total1Label"
        Sub_Total1Label.Size = New System.Drawing.Size(53, 13)
        Sub_Total1Label.TabIndex = 18
        Sub_Total1Label.Text = "Sub Total"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(16, 124)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(59, 13)
        Label4.TabIndex = 22
        Label4.Text = "Cellphones"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(16, 165)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(45, 13)
        Label5.TabIndex = 23
        Label5.Text = "Laptops"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(16, 217)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(57, 13)
        Label6.TabIndex = 24
        Label6.Text = "Computers"
        '
        'SubTotalLabel
        '
        SubTotalLabel.AutoSize = True
        SubTotalLabel.Location = New System.Drawing.Point(141, 177)
        SubTotalLabel.Name = "SubTotalLabel"
        SubTotalLabel.Size = New System.Drawing.Size(56, 13)
        SubTotalLabel.TabIndex = 0
        SubTotalLabel.Text = "Sub Total:"
        '
        'TaxLabel
        '
        TaxLabel.AutoSize = True
        TaxLabel.Location = New System.Drawing.Point(169, 97)
        TaxLabel.Name = "TaxLabel"
        TaxLabel.Size = New System.Drawing.Size(28, 13)
        TaxLabel.TabIndex = 2
        TaxLabel.Text = "Tax:"
        '
        'OrderSubTotalLabel
        '
        OrderSubTotalLabel.AutoSize = True
        OrderSubTotalLabel.Location = New System.Drawing.Point(112, 34)
        OrderSubTotalLabel.Name = "OrderSubTotalLabel"
        OrderSubTotalLabel.Size = New System.Drawing.Size(85, 13)
        OrderSubTotalLabel.TabIndex = 4
        OrderSubTotalLabel.Text = "Order Sub Total:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Ref_NoLabel)
        Me.GroupBox1.Controls.Add(Me.Ref_NoTextBox)
        Me.GroupBox1.Controls.Add(Order_TimeLabel)
        Me.GroupBox1.Controls.Add(Me.Order_TimeTextBox)
        Me.GroupBox1.Controls.Add(Order_DateLabel)
        Me.GroupBox1.Controls.Add(Me.Order_DateTextBox)
        Me.GroupBox1.Controls.Add(Customer_PhoneLabel)
        Me.GroupBox1.Controls.Add(Me.Customer_PhoneTextBox)
        Me.GroupBox1.Controls.Add(Customer_nameLabel)
        Me.GroupBox1.Controls.Add(Me.Customer_nameTextBox)
        Me.GroupBox1.Controls.Add(Customer_idLabel)
        Me.GroupBox1.Controls.Add(Me.Customer_idTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 239)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Ref_NoTextBox
        '
        Me.Ref_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Ref_No", True))
        Me.Ref_NoTextBox.Location = New System.Drawing.Point(345, 182)
        Me.Ref_NoTextBox.Name = "Ref_NoTextBox"
        Me.Ref_NoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Ref_NoTextBox.TabIndex = 12
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.Order_dataDataSet
        '
        'Order_dataDataSet
        '
        Me.Order_dataDataSet.DataSetName = "Order_dataDataSet"
        Me.Order_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Order_TimeTextBox
        '
        Me.Order_TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Order_Time", True))
        Me.Order_TimeTextBox.Location = New System.Drawing.Point(345, 122)
        Me.Order_TimeTextBox.Name = "Order_TimeTextBox"
        Me.Order_TimeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Order_TimeTextBox.TabIndex = 10
        '
        'Order_DateTextBox
        '
        Me.Order_DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Order_Date", True))
        Me.Order_DateTextBox.Location = New System.Drawing.Point(345, 72)
        Me.Order_DateTextBox.Name = "Order_DateTextBox"
        Me.Order_DateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Order_DateTextBox.TabIndex = 8
        '
        'Customer_PhoneTextBox
        '
        Me.Customer_PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Customer_Phone", True))
        Me.Customer_PhoneTextBox.Location = New System.Drawing.Point(105, 182)
        Me.Customer_PhoneTextBox.Name = "Customer_PhoneTextBox"
        Me.Customer_PhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Customer_PhoneTextBox.TabIndex = 6
        '
        'Customer_nameTextBox
        '
        Me.Customer_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Customer_name", True))
        Me.Customer_nameTextBox.Location = New System.Drawing.Point(105, 125)
        Me.Customer_nameTextBox.Name = "Customer_nameTextBox"
        Me.Customer_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Customer_nameTextBox.TabIndex = 4
        '
        'Customer_idTextBox
        '
        Me.Customer_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Customer_id", True))
        Me.Customer_idTextBox.Location = New System.Drawing.Point(105, 75)
        Me.Customer_idTextBox.Name = "Customer_idTextBox"
        Me.Customer_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Customer_idTextBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(460, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Online Billing System"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Label6)
        Me.GroupBox2.Controls.Add(Label5)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Me.Sub_Total3TextBox)
        Me.GroupBox2.Controls.Add(Me.Sub_Total2TextBox)
        Me.GroupBox2.Controls.Add(Sub_Total1Label)
        Me.GroupBox2.Controls.Add(Me.Sub_Total1TextBox)
        Me.GroupBox2.Controls.Add(Me.Unit_Price3TextBox)
        Me.GroupBox2.Controls.Add(Me.Unit_Price2TextBox)
        Me.GroupBox2.Controls.Add(Me.Unit_Price1TextBox)
        Me.GroupBox2.Controls.Add(Qty3Label)
        Me.GroupBox2.Controls.Add(Me.Qty3TextBox)
        Me.GroupBox2.Controls.Add(Qty2Label)
        Me.GroupBox2.Controls.Add(Me.Qty2TextBox)
        Me.GroupBox2.Controls.Add(Me.Qty1TextBox)
        Me.GroupBox2.Controls.Add(Me.btnCart)
        Me.GroupBox2.Controls.Add(Me.btnOrder)
        Me.GroupBox2.Controls.Add(Me.btnReicept)
        Me.GroupBox2.Controls.Add(Me.btnCal)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnReset)
        Me.GroupBox2.Controls.Add(Me.btnTotal)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 257)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(527, 451)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Sub_Total3TextBox
        '
        Me.Sub_Total3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Sub_Total3", True))
        Me.Sub_Total3TextBox.Location = New System.Drawing.Point(360, 214)
        Me.Sub_Total3TextBox.Name = "Sub_Total3TextBox"
        Me.Sub_Total3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sub_Total3TextBox.TabIndex = 21
        '
        'Sub_Total2TextBox
        '
        Me.Sub_Total2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Sub_Total2", True))
        Me.Sub_Total2TextBox.Location = New System.Drawing.Point(360, 167)
        Me.Sub_Total2TextBox.Name = "Sub_Total2TextBox"
        Me.Sub_Total2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sub_Total2TextBox.TabIndex = 20
        '
        'Sub_Total1TextBox
        '
        Me.Sub_Total1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Sub_Total1", True))
        Me.Sub_Total1TextBox.Location = New System.Drawing.Point(360, 121)
        Me.Sub_Total1TextBox.Name = "Sub_Total1TextBox"
        Me.Sub_Total1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sub_Total1TextBox.TabIndex = 19
        '
        'Unit_Price3TextBox
        '
        Me.Unit_Price3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Unit_Price3", True))
        Me.Unit_Price3TextBox.Location = New System.Drawing.Point(229, 214)
        Me.Unit_Price3TextBox.Name = "Unit_Price3TextBox"
        Me.Unit_Price3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Unit_Price3TextBox.TabIndex = 18
        '
        'Unit_Price2TextBox
        '
        Me.Unit_Price2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Unit_Price2", True))
        Me.Unit_Price2TextBox.Location = New System.Drawing.Point(229, 167)
        Me.Unit_Price2TextBox.Name = "Unit_Price2TextBox"
        Me.Unit_Price2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Unit_Price2TextBox.TabIndex = 16
        '
        'Unit_Price1TextBox
        '
        Me.Unit_Price1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Unit_Price1", True))
        Me.Unit_Price1TextBox.Location = New System.Drawing.Point(229, 121)
        Me.Unit_Price1TextBox.Name = "Unit_Price1TextBox"
        Me.Unit_Price1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Unit_Price1TextBox.TabIndex = 14
        '
        'Qty3TextBox
        '
        Me.Qty3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Qty3", True))
        Me.Qty3TextBox.Location = New System.Drawing.Point(92, 212)
        Me.Qty3TextBox.Name = "Qty3TextBox"
        Me.Qty3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Qty3TextBox.TabIndex = 12
        '
        'Qty2TextBox
        '
        Me.Qty2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Qty2", True))
        Me.Qty2TextBox.Location = New System.Drawing.Point(92, 162)
        Me.Qty2TextBox.Name = "Qty2TextBox"
        Me.Qty2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Qty2TextBox.TabIndex = 10
        '
        'Qty1TextBox
        '
        Me.Qty1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Qty1", True))
        Me.Qty1TextBox.Location = New System.Drawing.Point(92, 117)
        Me.Qty1TextBox.Name = "Qty1TextBox"
        Me.Qty1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Qty1TextBox.TabIndex = 8
        '
        'btnCart
        '
        Me.btnCart.Location = New System.Drawing.Point(191, 326)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(148, 39)
        Me.btnCart.TabIndex = 6
        Me.btnCart.Text = "Add To Cart"
        Me.btnCart.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(411, 382)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(75, 39)
        Me.btnOrder.TabIndex = 5
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnReicept
        '
        Me.btnReicept.Location = New System.Drawing.Point(330, 382)
        Me.btnReicept.Name = "btnReicept"
        Me.btnReicept.Size = New System.Drawing.Size(75, 39)
        Me.btnReicept.TabIndex = 4
        Me.btnReicept.Text = "Receipt"
        Me.btnReicept.UseVisualStyleBackColor = True
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(249, 382)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(75, 39)
        Me.btnCal.TabIndex = 3
        Me.btnCal.Text = "Calculator"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(168, 382)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 39)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(87, 382)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 39)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(6, 382)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(75, 39)
        Me.btnTotal.TabIndex = 0
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.TabControl1)
        Me.GroupBox3.Location = New System.Drawing.Point(545, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(487, 451)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(6, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(475, 432)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gray
        Me.TabPage1.Controls.Add(Me.btnCC)
        Me.TabPage1.Controls.Add(Me.btnClose)
        Me.TabPage1.Controls.Add(Me.btnConvert)
        Me.TabPage1.Controls.Add(Me.LblConvert)
        Me.TabPage1.Controls.Add(Me.txtConversion)
        Me.TabPage1.Controls.Add(Me.Cmbcurrency)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Button18)
        Me.TabPage1.Controls.Add(Me.Button17)
        Me.TabPage1.Controls.Add(Me.Button16)
        Me.TabPage1.Controls.Add(Me.Button15)
        Me.TabPage1.Controls.Add(Me.Button14)
        Me.TabPage1.Controls.Add(Me.Button13)
        Me.TabPage1.Controls.Add(Me.Button12)
        Me.TabPage1.Controls.Add(Me.Button11)
        Me.TabPage1.Controls.Add(Me.Button10)
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.Button8)
        Me.TabPage1.Controls.Add(Me.Button7)
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.lblShowCal)
        Me.TabPage1.Controls.Add(Me.lblDisplay)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(467, 406)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Calculator"
        '
        'btnCC
        '
        Me.btnCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCC.Location = New System.Drawing.Point(224, 6)
        Me.btnCC.Name = "btnCC"
        Me.btnCC.Size = New System.Drawing.Size(218, 299)
        Me.btnCC.TabIndex = 26
        Me.btnCC.Text = "Currency Converter"
        Me.btnCC.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(330, 265)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 34)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(234, 265)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 34)
        Me.btnConvert.TabIndex = 24
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'LblConvert
        '
        Me.LblConvert.Location = New System.Drawing.Point(265, 203)
        Me.LblConvert.Name = "LblConvert"
        Me.LblConvert.Size = New System.Drawing.Size(128, 32)
        Me.LblConvert.TabIndex = 23
        Me.LblConvert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtConversion
        '
        Me.txtConversion.Location = New System.Drawing.Point(279, 139)
        Me.txtConversion.Multiline = True
        Me.txtConversion.Name = "txtConversion"
        Me.txtConversion.Size = New System.Drawing.Size(100, 40)
        Me.txtConversion.TabIndex = 22
        '
        'Cmbcurrency
        '
        Me.Cmbcurrency.FormattingEnabled = True
        Me.Cmbcurrency.Location = New System.Drawing.Point(259, 85)
        Me.Cmbcurrency.Name = "Cmbcurrency"
        Me.Cmbcurrency.Size = New System.Drawing.Size(134, 21)
        Me.Cmbcurrency.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(230, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 65)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Currency Converter"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(24, 247)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(34, 32)
        Me.Button18.TabIndex = 19
        Me.Button18.Text = "0"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(104, 247)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(88, 32)
        Me.Button17.TabIndex = 18
        Me.Button17.Text = "="
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(104, 203)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(34, 32)
        Me.Button16.TabIndex = 17
        Me.Button16.Text = "1"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(158, 203)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(34, 32)
        Me.Button15.TabIndex = 16
        Me.Button15.Text = "*"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(64, 203)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(34, 32)
        Me.Button14.TabIndex = 15
        Me.Button14.Text = "2"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(24, 203)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(34, 32)
        Me.Button13.TabIndex = 14
        Me.Button13.Text = "3"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(158, 165)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(34, 32)
        Me.Button12.TabIndex = 13
        Me.Button12.Text = "/"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(104, 165)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(34, 32)
        Me.Button11.TabIndex = 12
        Me.Button11.Text = "6"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(64, 165)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(34, 32)
        Me.Button10.TabIndex = 11
        Me.Button10.Text = "5"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(24, 165)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(34, 32)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "4"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(158, 127)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(34, 32)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "-"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(104, 127)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(34, 32)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "9"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(64, 127)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(34, 32)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "8"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(24, 127)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(34, 32)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "7"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(158, 89)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(34, 32)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(104, 89)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 32)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "C"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(64, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "BS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblShowCal
        '
        Me.lblShowCal.BackColor = System.Drawing.Color.White
        Me.lblShowCal.Location = New System.Drawing.Point(21, 17)
        Me.lblShowCal.Name = "lblShowCal"
        Me.lblShowCal.Size = New System.Drawing.Size(100, 23)
        Me.lblShowCal.TabIndex = 1
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.Color.White
        Me.lblDisplay.Location = New System.Drawing.Point(21, 17)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(171, 52)
        Me.lblDisplay.TabIndex = 0
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtReicept)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(467, 406)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Receipt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtReicept
        '
        Me.txtReicept.Location = New System.Drawing.Point(6, 6)
        Me.txtReicept.Multiline = True
        Me.txtReicept.Name = "txtReicept"
        Me.txtReicept.Size = New System.Drawing.Size(455, 385)
        Me.txtReicept.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.TableDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(467, 406)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Order"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TableDataGridView
        '
        Me.TableDataGridView.AutoGenerateColumns = False
        Me.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.TableDataGridView.DataSource = Me.TableBindingSource
        Me.TableDataGridView.Location = New System.Drawing.Point(3, 0)
        Me.TableDataGridView.Name = "TableDataGridView"
        Me.TableDataGridView.Size = New System.Drawing.Size(464, 403)
        Me.TableDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Customer_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Customer_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Customer_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Customer_Phone"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Customer_Phone"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Order_Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Order_Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Order_Time"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Order_Time"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Ref_No"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ref_No"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Qty1"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Qty1"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Qty2"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Qty2"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Qty3"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Qty3"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Unit_Price1"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Unit_Price1"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Unit_Price2"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Unit_Price2"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Unit_Price3"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Unit_Price3"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Sub_Total1"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Sub_Total1"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Sub_Total2"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Sub_Total2"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Sub_Total3"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Sub_Total3"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "SubTotal"
        Me.DataGridViewTextBoxColumn16.HeaderText = "SubTotal"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Tax"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Tax"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "OrderSubTotal"
        Me.DataGridViewTextBoxColumn18.HeaderText = "OrderSubTotal"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox4.Controls.Add(OrderSubTotalLabel)
        Me.GroupBox4.Controls.Add(Me.OrderSubTotalTextBox)
        Me.GroupBox4.Controls.Add(TaxLabel)
        Me.GroupBox4.Controls.Add(Me.TaxTextBox)
        Me.GroupBox4.Controls.Add(SubTotalLabel)
        Me.GroupBox4.Controls.Add(Me.SubTotalTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(545, 469)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(491, 238)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'OrderSubTotalTextBox
        '
        Me.OrderSubTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "OrderSubTotal", True))
        Me.OrderSubTotalTextBox.Location = New System.Drawing.Point(203, 34)
        Me.OrderSubTotalTextBox.Name = "OrderSubTotalTextBox"
        Me.OrderSubTotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OrderSubTotalTextBox.TabIndex = 5
        '
        'TaxTextBox
        '
        Me.TaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Tax", True))
        Me.TaxTextBox.Location = New System.Drawing.Point(203, 94)
        Me.TaxTextBox.Name = "TaxTextBox"
        Me.TaxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TaxTextBox.TabIndex = 3
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "SubTotal", True))
        Me.SubTotalTextBox.Location = New System.Drawing.Point(203, 174)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SubTotalTextBox.TabIndex = 1
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TableTableAdapter = Me.TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = database_system.Order_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableBindingNavigator
        '
        Me.TableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TableBindingNavigator.BindingSource = Me.TableBindingSource
        Me.TableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TableBindingNavigatorSaveItem})
        Me.TableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TableBindingNavigator.Name = "TableBindingNavigator"
        Me.TableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TableBindingNavigator.Size = New System.Drawing.Size(1036, 25)
        Me.TableBindingNavigator.TabIndex = 3
        Me.TableBindingNavigator.Text = "BindingNavigator1"
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
        'TableBindingNavigatorSaveItem
        '
        Me.TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TableBindingNavigatorSaveItem.Image = CType(resources.GetObject("TableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TableBindingNavigatorSaveItem.Name = "TableBindingNavigatorSaveItem"
        Me.TableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1028, 750)
        Me.Controls.Add(Me.TableBindingNavigator)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Billing System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_dataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.TableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableBindingNavigator.ResumeLayout(False)
        Me.TableBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblShowCal As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCC As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnConvert As Button
    Friend WithEvents LblConvert As Label
    Friend WithEvents txtConversion As TextBox
    Friend WithEvents Cmbcurrency As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCart As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnReicept As Button
    Friend WithEvents btnCal As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtReicept As TextBox
    Friend WithEvents Order_dataDataSet As Order_dataDataSet
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As Order_dataDataSetTableAdapters.TableTableAdapter
    Friend WithEvents TableAdapterManager As Order_dataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableBindingNavigator As BindingNavigator
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
    Friend WithEvents TableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Sub_Total3TextBox As TextBox
    Friend WithEvents Sub_Total2TextBox As TextBox
    Friend WithEvents Sub_Total1TextBox As TextBox
    Friend WithEvents Unit_Price3TextBox As TextBox
    Friend WithEvents Unit_Price2TextBox As TextBox
    Friend WithEvents Unit_Price1TextBox As TextBox
    Friend WithEvents Qty3TextBox As TextBox
    Friend WithEvents Qty2TextBox As TextBox
    Friend WithEvents Qty1TextBox As TextBox
    Friend WithEvents TableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents OrderSubTotalTextBox As TextBox
    Friend WithEvents TaxTextBox As TextBox
    Friend WithEvents SubTotalTextBox As TextBox
    Friend WithEvents Customer_idTextBox As TextBox
    Friend WithEvents Customer_nameTextBox As TextBox
    Friend WithEvents Customer_PhoneTextBox As TextBox
    Friend WithEvents Order_DateTextBox As TextBox
    Friend WithEvents Order_TimeTextBox As TextBox
    Friend WithEvents Ref_NoTextBox As TextBox
End Class
