<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProperties
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
        Me.tbAddProperty = New System.Windows.Forms.TabControl()
        Me.TabList = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboStatus = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btnPropertyExit = New System.Windows.Forms.Button()
        Me.TabSales = New System.Windows.Forms.TabPage()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabRent = New System.Windows.Forms.TabPage()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnSalesCancel = New System.Windows.Forms.Button()
        Me.btnSalesSave = New System.Windows.Forms.Button()
        Me.cboRentPropertyType = New System.Windows.Forms.ComboBox()
        Me.cboRentMstatus = New System.Windows.Forms.ComboBox()
        Me.dtpRentage = New System.Windows.Forms.DateTimePicker()
        Me.txtOccupation = New System.Windows.Forms.TextBox()
        Me.txtRentPnumber = New System.Windows.Forms.TextBox()
        Me.txtRentfname = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbAddProperty.SuspendLayout()
        Me.TabList.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSales.SuspendLayout()
        Me.TabRent.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbAddProperty
        '
        Me.tbAddProperty.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbAddProperty.Controls.Add(Me.TabList)
        Me.tbAddProperty.Controls.Add(Me.TabSales)
        Me.tbAddProperty.Controls.Add(Me.TabRent)
        Me.tbAddProperty.Location = New System.Drawing.Point(2, 73)
        Me.tbAddProperty.Name = "tbAddProperty"
        Me.tbAddProperty.SelectedIndex = 0
        Me.tbAddProperty.Size = New System.Drawing.Size(1276, 747)
        Me.tbAddProperty.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tbAddProperty.TabIndex = 3
        '
        'TabList
        '
        Me.TabList.BackColor = System.Drawing.Color.White
        Me.TabList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabList.Controls.Add(Me.Button3)
        Me.TabList.Controls.Add(Me.DataGridView1)
        Me.TabList.Controls.Add(Me.btnPropertyExit)
        Me.TabList.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabList.Location = New System.Drawing.Point(4, 22)
        Me.TabList.Name = "TabList"
        Me.TabList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabList.Size = New System.Drawing.Size(1268, 721)
        Me.TabList.TabIndex = 0
        Me.TabList.Text = "LIST"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button3.Location = New System.Drawing.Point(65, 690)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 25)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "ADD PROPERTY"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtName, Me.txtType, Me.txtLocation, Me.txtPrice, Me.cboStatus})
        Me.DataGridView1.Location = New System.Drawing.Point(3, -4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.DividerHeight = 10
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.Size = New System.Drawing.Size(1262, 688)
        Me.DataGridView1.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.txtName.HeaderText = "PROPERTY NAME"
        Me.txtName.Name = "txtName"
        '
        'txtType
        '
        Me.txtType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.txtType.HeaderText = "PROPERTY TYPE"
        Me.txtType.Name = "txtType"
        '
        'txtLocation
        '
        Me.txtLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.txtLocation.HeaderText = "PROPERTY LOCATION"
        Me.txtLocation.Name = "txtLocation"
        '
        'txtPrice
        '
        Me.txtPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.txtPrice.HeaderText = "PROPERTY PRICE"
        Me.txtPrice.Name = "txtPrice"
        '
        'cboStatus
        '
        Me.cboStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cboStatus.HeaderText = "PROPERTY STATUS"
        Me.cboStatus.Name = "cboStatus"
        '
        'btnPropertyExit
        '
        Me.btnPropertyExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPropertyExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPropertyExit.Location = New System.Drawing.Point(6, 690)
        Me.btnPropertyExit.Name = "btnPropertyExit"
        Me.btnPropertyExit.Size = New System.Drawing.Size(53, 25)
        Me.btnPropertyExit.TabIndex = 1
        Me.btnPropertyExit.Text = "BACK"
        Me.btnPropertyExit.UseVisualStyleBackColor = True
        '
        'TabSales
        '
        Me.TabSales.BackColor = System.Drawing.Color.Cyan
        Me.TabSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabSales.Controls.Add(Me.TextBox6)
        Me.TabSales.Controls.Add(Me.Label22)
        Me.TabSales.Controls.Add(Me.ComboBox7)
        Me.TabSales.Controls.Add(Me.Label24)
        Me.TabSales.Controls.Add(Me.ComboBox8)
        Me.TabSales.Controls.Add(Me.Label25)
        Me.TabSales.Controls.Add(Me.Button2)
        Me.TabSales.Controls.Add(Me.Button1)
        Me.TabSales.Controls.Add(Me.TextBox4)
        Me.TabSales.Controls.Add(Me.TextBox3)
        Me.TabSales.Controls.Add(Me.TextBox2)
        Me.TabSales.Controls.Add(Me.TextBox1)
        Me.TabSales.Controls.Add(Me.Label17)
        Me.TabSales.Controls.Add(Me.ComboBox2)
        Me.TabSales.Controls.Add(Me.ComboBox1)
        Me.TabSales.Controls.Add(Me.DateTimePicker1)
        Me.TabSales.Controls.Add(Me.Label9)
        Me.TabSales.Controls.Add(Me.Label8)
        Me.TabSales.Controls.Add(Me.Label7)
        Me.TabSales.Controls.Add(Me.Label6)
        Me.TabSales.Controls.Add(Me.Label5)
        Me.TabSales.Controls.Add(Me.Label4)
        Me.TabSales.Controls.Add(Me.Label3)
        Me.TabSales.Controls.Add(Me.Label2)
        Me.TabSales.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabSales.Location = New System.Drawing.Point(4, 22)
        Me.TabSales.Name = "TabSales"
        Me.TabSales.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSales.Size = New System.Drawing.Size(1268, 721)
        Me.TabSales.TabIndex = 1
        Me.TabSales.Text = "SALES"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(1057, 296)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(139, 35)
        Me.TextBox6.TabIndex = 30
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(725, 305)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(323, 26)
        Me.Label22.TabIndex = 29
        Me.Label22.Text = "PURPOSE FOR  PROPERTY"
        '
        'ComboBox7
        '
        Me.ComboBox7.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6 or more "})
        Me.ComboBox7.Location = New System.Drawing.Point(1055, 221)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(143, 34)
        Me.ComboBox7.TabIndex = 26
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(725, 230)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(227, 26)
        Me.Label24.TabIndex = 25
        Me.Label24.Text = "NUMBER OF CARS"
        '
        'ComboBox8
        '
        Me.ComboBox8.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Items.AddRange(New Object() {"1 Bedroom", "2 Bedrooms", "3 Bedrooms ", "4 Bedrooms ", "5 Bedrooms ", "6 and more"})
        Me.ComboBox8.Location = New System.Drawing.Point(1055, 137)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(143, 34)
        Me.ComboBox8.TabIndex = 24
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(725, 146)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(254, 26)
        Me.Label25.TabIndex = 23
        Me.Label25.Text = "NUMBER OF ROOMS"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(98, 694)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "BACK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 694)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(346, 601)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(342, 35)
        Me.TextBox4.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(362, 377)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(326, 35)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(362, 296)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(326, 35)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(362, 146)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(326, 35)
        Me.TextBox1.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(31, 605)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(274, 26)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "PROPERTY LOCATION"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(346, 522)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(342, 34)
        Me.ComboBox2.TabIndex = 13
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(362, 447)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(326, 34)
        Me.ComboBox1.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(359, 221)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(329, 35)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(31, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(210, 26)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "PHONE NUMBER"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 15)
        Me.Label8.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 530)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(250, 26)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "TYPE OF PROPERTY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 455)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(221, 26)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "MARITAL STATUS "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 380)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 26)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "OCCUPATION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 26)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "AGE "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "FULL NAME "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(330, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(580, 40)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BUYERS REGISTRATION FORMS "
        '
        'TabRent
        '
        Me.TabRent.BackColor = System.Drawing.Color.Cyan
        Me.TabRent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabRent.Controls.Add(Me.TextBox5)
        Me.TabRent.Controls.Add(Me.Label21)
        Me.TabRent.Controls.Add(Me.ComboBox5)
        Me.TabRent.Controls.Add(Me.Label20)
        Me.TabRent.Controls.Add(Me.ComboBox4)
        Me.TabRent.Controls.Add(Me.Label19)
        Me.TabRent.Controls.Add(Me.ComboBox3)
        Me.TabRent.Controls.Add(Me.Label18)
        Me.TabRent.Controls.Add(Me.btnSalesCancel)
        Me.TabRent.Controls.Add(Me.btnSalesSave)
        Me.TabRent.Controls.Add(Me.cboRentPropertyType)
        Me.TabRent.Controls.Add(Me.cboRentMstatus)
        Me.TabRent.Controls.Add(Me.dtpRentage)
        Me.TabRent.Controls.Add(Me.txtOccupation)
        Me.TabRent.Controls.Add(Me.txtRentPnumber)
        Me.TabRent.Controls.Add(Me.txtRentfname)
        Me.TabRent.Controls.Add(Me.Label16)
        Me.TabRent.Controls.Add(Me.Label15)
        Me.TabRent.Controls.Add(Me.Label14)
        Me.TabRent.Controls.Add(Me.Label13)
        Me.TabRent.Controls.Add(Me.Label12)
        Me.TabRent.Controls.Add(Me.Label11)
        Me.TabRent.Controls.Add(Me.Label10)
        Me.TabRent.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabRent.Location = New System.Drawing.Point(4, 22)
        Me.TabRent.Name = "TabRent"
        Me.TabRent.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRent.Size = New System.Drawing.Size(1268, 721)
        Me.TabRent.TabIndex = 2
        Me.TabRent.Text = "RENT"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(1096, 393)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(139, 35)
        Me.TextBox5.TabIndex = 22
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(762, 402)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(323, 26)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "PURPOSE FOR  PROPERTY"
        '
        'ComboBox5
        '
        Me.ComboBox5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"1 year", "2 years", "3 years", "4 years", "5 years", "6 and more "})
        Me.ComboBox5.Location = New System.Drawing.Point(1092, 321)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(143, 34)
        Me.ComboBox5.TabIndex = 20
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(762, 330)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(241, 26)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "DURATION OF STAY"
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6 or more "})
        Me.ComboBox4.Location = New System.Drawing.Point(1092, 250)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(143, 34)
        Me.ComboBox4.TabIndex = 18
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(762, 259)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(227, 26)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "NUMBER OF CARS"
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"1 Bedroom", "2 Bedrooms", "3 Bedrooms ", "4 Bedrooms ", "5 Bedrooms ", "6 and more"})
        Me.ComboBox3.Location = New System.Drawing.Point(1092, 177)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(143, 34)
        Me.ComboBox3.TabIndex = 16
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(762, 186)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(254, 26)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "NUMBER OF ROOMS"
        '
        'btnSalesCancel
        '
        Me.btnSalesCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSalesCancel.Location = New System.Drawing.Point(84, 692)
        Me.btnSalesCancel.Name = "btnSalesCancel"
        Me.btnSalesCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnSalesCancel.TabIndex = 14
        Me.btnSalesCancel.Text = "BACK"
        Me.btnSalesCancel.UseVisualStyleBackColor = True
        '
        'btnSalesSave
        '
        Me.btnSalesSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSalesSave.Location = New System.Drawing.Point(3, 692)
        Me.btnSalesSave.Name = "btnSalesSave"
        Me.btnSalesSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSalesSave.TabIndex = 13
        Me.btnSalesSave.Text = "SAVE"
        Me.btnSalesSave.UseVisualStyleBackColor = True
        '
        'cboRentPropertyType
        '
        Me.cboRentPropertyType.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRentPropertyType.FormattingEnabled = True
        Me.cboRentPropertyType.Location = New System.Drawing.Point(310, 538)
        Me.cboRentPropertyType.Name = "cboRentPropertyType"
        Me.cboRentPropertyType.Size = New System.Drawing.Size(357, 34)
        Me.cboRentPropertyType.TabIndex = 12
        '
        'cboRentMstatus
        '
        Me.cboRentMstatus.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRentMstatus.FormattingEnabled = True
        Me.cboRentMstatus.Location = New System.Drawing.Point(310, 466)
        Me.cboRentMstatus.Name = "cboRentMstatus"
        Me.cboRentMstatus.Size = New System.Drawing.Size(357, 34)
        Me.cboRentMstatus.TabIndex = 11
        '
        'dtpRentage
        '
        Me.dtpRentage.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRentage.Location = New System.Drawing.Point(310, 252)
        Me.dtpRentage.Name = "dtpRentage"
        Me.dtpRentage.Size = New System.Drawing.Size(357, 35)
        Me.dtpRentage.TabIndex = 10
        '
        'txtOccupation
        '
        Me.txtOccupation.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccupation.Location = New System.Drawing.Point(310, 393)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Size = New System.Drawing.Size(357, 35)
        Me.txtOccupation.TabIndex = 9
        '
        'txtRentPnumber
        '
        Me.txtRentPnumber.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentPnumber.Location = New System.Drawing.Point(310, 321)
        Me.txtRentPnumber.Name = "txtRentPnumber"
        Me.txtRentPnumber.Size = New System.Drawing.Size(357, 35)
        Me.txtRentPnumber.TabIndex = 8
        '
        'txtRentfname
        '
        Me.txtRentfname.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentfname.Location = New System.Drawing.Point(310, 177)
        Me.txtRentfname.Name = "txtRentfname"
        Me.txtRentfname.Size = New System.Drawing.Size(357, 35)
        Me.txtRentfname.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 546)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(250, 26)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "TYPE OF PROPERTY"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 474)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(221, 26)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "MARITAL STATUS "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 402)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(170, 26)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "OCCUPATION"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 330)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(216, 26)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "PHONE NUMBER "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 258)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 26)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "AGE "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(160, 26)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "FULL NAME "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(354, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(505, 40)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "RENT REGISTRATION FORM"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1276, 64)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROPERTIES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmProperties
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1275, 818)
        Me.Controls.Add(Me.tbAddProperty)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "frmProperties"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbAddProperty.ResumeLayout(False)
        Me.TabList.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSales.ResumeLayout(False)
        Me.TabSales.PerformLayout()
        Me.TabRent.ResumeLayout(False)
        Me.TabRent.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabRent As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TabSales As TabPage
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabList As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtName As DataGridViewTextBoxColumn
    Friend WithEvents txtType As DataGridViewTextBoxColumn
    Friend WithEvents txtLocation As DataGridViewTextBoxColumn
    Friend WithEvents txtPrice As DataGridViewTextBoxColumn
    Friend WithEvents cboStatus As DataGridViewComboBoxColumn
    Friend WithEvents tbAddProperty As TabControl
    Friend WithEvents dtpRentage As DateTimePicker
    Friend WithEvents txtOccupation As TextBox
    Friend WithEvents txtRentPnumber As TextBox
    Friend WithEvents txtRentfname As TextBox
    Friend WithEvents cboRentPropertyType As ComboBox
    Friend WithEvents cboRentMstatus As ComboBox
    Friend WithEvents btnSalesCancel As Button
    Friend WithEvents btnSalesSave As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnPropertyExit As Button

    Private Sub btnPropertyExit_Click(sender As Object, e As EventArgs) Handles btnPropertyExit.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        frmNewProperty.Show()
    End Sub

    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents Label25 As Label

    Private Sub btnSalesCancel_Click(sender As Object, e As EventArgs) Handles btnSalesCancel.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub TabSales_Click(sender As Object, e As EventArgs) Handles TabSales.Click

    End Sub
End Class
