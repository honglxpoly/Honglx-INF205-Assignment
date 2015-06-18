<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_QLNV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_QLNV))
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.grb_Info = New System.Windows.Forms.GroupBox()
        Me.dtp_Sd = New System.Windows.Forms.DateTimePicker()
        Me.dtp_bd = New System.Windows.Forms.DateTimePicker()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Refesh = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.txt_Terrminal = New System.Windows.Forms.TextBox()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.lbl_startdate = New System.Windows.Forms.Label()
        Me.lbl_terminal = New System.Windows.Forms.Label()
        Me.lbl_birthday = New System.Windows.Forms.Label()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dgv_Info = New System.Windows.Forms.DataGridView()
        Me.grb_Info.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Title.Font = New System.Drawing.Font("Times New Roman", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.White
        Me.lbl_Title.Location = New System.Drawing.Point(142, 9)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(1108, 67)
        Me.lbl_Title.TabIndex = 0
        Me.lbl_Title.Text = "Quản lý thông tin nhân viên"
        Me.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grb_Info
        '
        Me.grb_Info.BackColor = System.Drawing.Color.Transparent
        Me.grb_Info.Controls.Add(Me.dtp_Sd)
        Me.grb_Info.Controls.Add(Me.dtp_bd)
        Me.grb_Info.Controls.Add(Me.btn_Back)
        Me.grb_Info.Controls.Add(Me.btn_Refesh)
        Me.grb_Info.Controls.Add(Me.btn_Exit)
        Me.grb_Info.Controls.Add(Me.btn_Delete)
        Me.grb_Info.Controls.Add(Me.txt_Terrminal)
        Me.grb_Info.Controls.Add(Me.btn_Edit)
        Me.grb_Info.Controls.Add(Me.btn_Add)
        Me.grb_Info.Controls.Add(Me.txt_Name)
        Me.grb_Info.Controls.Add(Me.lbl_startdate)
        Me.grb_Info.Controls.Add(Me.lbl_terminal)
        Me.grb_Info.Controls.Add(Me.lbl_birthday)
        Me.grb_Info.Controls.Add(Me.lbl_Name)
        Me.grb_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grb_Info.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Info.ForeColor = System.Drawing.Color.White
        Me.grb_Info.Location = New System.Drawing.Point(130, 97)
        Me.grb_Info.Name = "grb_Info"
        Me.grb_Info.Size = New System.Drawing.Size(406, 383)
        Me.grb_Info.TabIndex = 2
        Me.grb_Info.TabStop = False
        Me.grb_Info.Text = "Thông tin nhân viên"
        '
        'dtp_Sd
        '
        Me.dtp_Sd.CalendarFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Sd.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Sd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Sd.Location = New System.Drawing.Point(190, 139)
        Me.dtp_Sd.Name = "dtp_Sd"
        Me.dtp_Sd.Size = New System.Drawing.Size(200, 28)
        Me.dtp_Sd.TabIndex = 13
        '
        'dtp_bd
        '
        Me.dtp_bd.CalendarFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_bd.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_bd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_bd.Location = New System.Drawing.Point(190, 94)
        Me.dtp_bd.Name = "dtp_bd"
        Me.dtp_bd.Size = New System.Drawing.Size(200, 28)
        Me.dtp_bd.TabIndex = 13
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.White
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Back.Location = New System.Drawing.Point(156, 309)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(100, 50)
        Me.btn_Back.TabIndex = 12
        Me.btn_Back.Text = "Trở về"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Refesh
        '
        Me.btn_Refesh.BackColor = System.Drawing.Color.White
        Me.btn_Refesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Refesh.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Refesh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Refesh.Location = New System.Drawing.Point(18, 309)
        Me.btn_Refesh.Name = "btn_Refesh"
        Me.btn_Refesh.Size = New System.Drawing.Size(100, 50)
        Me.btn_Refesh.TabIndex = 11
        Me.btn_Refesh.Text = "Làm mới"
        Me.btn_Refesh.UseVisualStyleBackColor = False
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.White
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exit.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Exit.Location = New System.Drawing.Point(290, 309)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(100, 50)
        Me.btn_Exit.TabIndex = 10
        Me.btn_Exit.Text = "Thoát"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'btn_Delete
        '
        Me.btn_Delete.BackColor = System.Drawing.Color.White
        Me.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Delete.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Delete.Location = New System.Drawing.Point(290, 235)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(100, 50)
        Me.btn_Delete.TabIndex = 9
        Me.btn_Delete.Text = "Xóa"
        Me.btn_Delete.UseVisualStyleBackColor = False
        '
        'txt_Terrminal
        '
        Me.txt_Terrminal.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Terrminal.Location = New System.Drawing.Point(190, 188)
        Me.txt_Terrminal.Name = "txt_Terrminal"
        Me.txt_Terrminal.Size = New System.Drawing.Size(200, 27)
        Me.txt_Terrminal.TabIndex = 5
        '
        'btn_Edit
        '
        Me.btn_Edit.BackColor = System.Drawing.Color.White
        Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Edit.Location = New System.Drawing.Point(156, 235)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(100, 50)
        Me.btn_Edit.TabIndex = 8
        Me.btn_Edit.Text = "Sửa"
        Me.btn_Edit.UseVisualStyleBackColor = False
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.White
        Me.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Add.Location = New System.Drawing.Point(18, 235)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(100, 50)
        Me.btn_Add.TabIndex = 7
        Me.btn_Add.Text = "Thêm mới"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'txt_Name
        '
        Me.txt_Name.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Name.Location = New System.Drawing.Point(190, 53)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(200, 27)
        Me.txt_Name.TabIndex = 1
        '
        'lbl_startdate
        '
        Me.lbl_startdate.AutoSize = True
        Me.lbl_startdate.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_startdate.Location = New System.Drawing.Point(13, 146)
        Me.lbl_startdate.Name = "lbl_startdate"
        Me.lbl_startdate.Size = New System.Drawing.Size(175, 19)
        Me.lbl_startdate.TabIndex = 0
        Me.lbl_startdate.Text = "Ngày bắt đầu làm việc:"
        '
        'lbl_terminal
        '
        Me.lbl_terminal.AutoSize = True
        Me.lbl_terminal.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_terminal.Location = New System.Drawing.Point(13, 191)
        Me.lbl_terminal.Name = "lbl_terminal"
        Me.lbl_terminal.Size = New System.Drawing.Size(84, 19)
        Me.lbl_terminal.TabIndex = 0
        Me.lbl_terminal.Text = "Cửa hàng:"
        '
        'lbl_birthday
        '
        Me.lbl_birthday.AutoSize = True
        Me.lbl_birthday.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_birthday.Location = New System.Drawing.Point(13, 101)
        Me.lbl_birthday.Name = "lbl_birthday"
        Me.lbl_birthday.Size = New System.Drawing.Size(87, 19)
        Me.lbl_birthday.TabIndex = 0
        Me.lbl_birthday.Text = "Ngày sinh:"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(13, 56)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(64, 19)
        Me.lbl_Name.TabIndex = 0
        Me.lbl_Name.Text = "Họ tên:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.INF205_Asm.My.Resources.Resources.nv_passio
        Me.PictureBox1.Location = New System.Drawing.Point(2, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 373)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.INF205_Asm.My.Resources.Resources.passio3
        Me.PictureBox2.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(124, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'dgv_Info
        '
        Me.dgv_Info.AllowUserToAddRows = False
        Me.dgv_Info.AllowUserToDeleteRows = False
        Me.dgv_Info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Info.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Info.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_Info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgv_Info.ColumnHeadersHeight = 55
        Me.dgv_Info.GridColor = System.Drawing.Color.White
        Me.dgv_Info.Location = New System.Drawing.Point(545, 114)
        Me.dgv_Info.Margin = New System.Windows.Forms.Padding(6)
        Me.dgv_Info.Name = "dgv_Info"
        Me.dgv_Info.RowHeadersVisible = False
        Me.dgv_Info.RowTemplate.Height = 24
        Me.dgv_Info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Info.Size = New System.Drawing.Size(702, 366)
        Me.dgv_Info.TabIndex = 25
        '
        'frm_QLNV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1262, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv_Info)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.grb_Info)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frm_QLNV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý nhân viên"
        Me.grb_Info.ResumeLayout(False)
        Me.grb_Info.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grb_Info As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_startdate As System.Windows.Forms.Label
    Friend WithEvents lbl_terminal As System.Windows.Forms.Label
    Friend WithEvents lbl_birthday As System.Windows.Forms.Label
    Friend WithEvents lbl_Name As System.Windows.Forms.Label
    Friend WithEvents txt_Name As System.Windows.Forms.TextBox
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents btn_Refesh As System.Windows.Forms.Button
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents btn_Delete As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents txt_Terrminal As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents dgv_Info As System.Windows.Forms.DataGridView
    Friend WithEvents dtp_bd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Sd As System.Windows.Forms.DateTimePicker
End Class
