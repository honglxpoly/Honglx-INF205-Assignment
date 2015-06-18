<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AddStaffInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AddStaffInfo))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.grb_Info = New System.Windows.Forms.GroupBox()
        Me.cbb_terminal = New System.Windows.Forms.ComboBox()
        Me.cbb_roles = New System.Windows.Forms.ComboBox()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Refesh = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.dtp_Sd = New System.Windows.Forms.DateTimePicker()
        Me.txt_manv = New System.Windows.Forms.TextBox()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.lbl_manv = New System.Windows.Forms.Label()
        Me.dtp_bd = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.txt_pw = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_pw = New System.Windows.Forms.Label()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.lbl_role = New System.Windows.Forms.Label()
        Me.lbl_birthday = New System.Windows.Forms.Label()
        Me.lbl_terminal = New System.Windows.Forms.Label()
        Me.lbl_startdate = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_Info.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.INF205_Asm.My.Resources.Resources.nv_passio
        Me.PictureBox1.Location = New System.Drawing.Point(-26, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(323, 491)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.INF205_Asm.My.Resources.Resources.passio3
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(124, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'lbl_Title
        '
        Me.lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Title.Font = New System.Drawing.Font("Times New Roman", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.White
        Me.lbl_Title.Location = New System.Drawing.Point(179, 12)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(517, 67)
        Me.lbl_Title.TabIndex = 24
        Me.lbl_Title.Text = "Thêm Nhân viên mới"
        Me.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grb_Info
        '
        Me.grb_Info.BackColor = System.Drawing.Color.Transparent
        Me.grb_Info.Controls.Add(Me.cbb_terminal)
        Me.grb_Info.Controls.Add(Me.cbb_roles)
        Me.grb_Info.Controls.Add(Me.btn_Back)
        Me.grb_Info.Controls.Add(Me.btn_Refesh)
        Me.grb_Info.Controls.Add(Me.btn_Add)
        Me.grb_Info.Controls.Add(Me.dtp_Sd)
        Me.grb_Info.Controls.Add(Me.txt_manv)
        Me.grb_Info.Controls.Add(Me.txt_Name)
        Me.grb_Info.Controls.Add(Me.lbl_manv)
        Me.grb_Info.Controls.Add(Me.dtp_bd)
        Me.grb_Info.Controls.Add(Me.lbl_Name)
        Me.grb_Info.Controls.Add(Me.txt_pw)
        Me.grb_Info.Controls.Add(Me.txt_id)
        Me.grb_Info.Controls.Add(Me.lbl_pw)
        Me.grb_Info.Controls.Add(Me.lbl_ID)
        Me.grb_Info.Controls.Add(Me.lbl_role)
        Me.grb_Info.Controls.Add(Me.lbl_birthday)
        Me.grb_Info.Controls.Add(Me.lbl_terminal)
        Me.grb_Info.Controls.Add(Me.lbl_startdate)
        Me.grb_Info.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Info.ForeColor = System.Drawing.Color.White
        Me.grb_Info.Location = New System.Drawing.Point(264, 112)
        Me.grb_Info.Name = "grb_Info"
        Me.grb_Info.Size = New System.Drawing.Size(432, 436)
        Me.grb_Info.TabIndex = 33
        Me.grb_Info.TabStop = False
        Me.grb_Info.Text = "Thông tin nhân viên"
        '
        'cbb_terminal
        '
        Me.cbb_terminal.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbb_terminal.FormattingEnabled = True
        Me.cbb_terminal.Items.AddRange(New Object() {"15F Nguyễn Thị Minh Khai", "227 Xô Viết Nghệ Tĩnh", "53C Nguyễn Du", "91 Nguyễn Du", "97 Đinh Tiên Hoàng", "431 Lê Hồng Phong", "213 Nguyễn Văn Cừ", "47 Trần Cao Vân", "11 Võ Văn Tần"})
        Me.cbb_terminal.Location = New System.Drawing.Point(211, 192)
        Me.cbb_terminal.Name = "cbb_terminal"
        Me.cbb_terminal.Size = New System.Drawing.Size(200, 27)
        Me.cbb_terminal.TabIndex = 6
        '
        'cbb_roles
        '
        Me.cbb_roles.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbb_roles.FormattingEnabled = True
        Me.cbb_roles.Items.AddRange(New Object() {"admin", "user"})
        Me.cbb_roles.Location = New System.Drawing.Point(211, 232)
        Me.cbb_roles.Name = "cbb_roles"
        Me.cbb_roles.Size = New System.Drawing.Size(200, 27)
        Me.cbb_roles.TabIndex = 6
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.White
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Back.Location = New System.Drawing.Point(311, 366)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(100, 50)
        Me.btn_Back.TabIndex = 11
        Me.btn_Back.Text = "Trở về"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Refesh
        '
        Me.btn_Refesh.BackColor = System.Drawing.Color.White
        Me.btn_Refesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Refesh.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Refesh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Refesh.Location = New System.Drawing.Point(164, 366)
        Me.btn_Refesh.Name = "btn_Refesh"
        Me.btn_Refesh.Size = New System.Drawing.Size(100, 50)
        Me.btn_Refesh.TabIndex = 10
        Me.btn_Refesh.Text = "Làm mới"
        Me.btn_Refesh.UseVisualStyleBackColor = False
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.White
        Me.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Add.Location = New System.Drawing.Point(10, 366)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(100, 50)
        Me.btn_Add.TabIndex = 9
        Me.btn_Add.Text = "Thêm "
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'dtp_Sd
        '
        Me.dtp_Sd.CalendarFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Sd.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Sd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Sd.Location = New System.Drawing.Point(211, 148)
        Me.dtp_Sd.Name = "dtp_Sd"
        Me.dtp_Sd.Size = New System.Drawing.Size(200, 28)
        Me.dtp_Sd.TabIndex = 4
        '
        'txt_manv
        '
        Me.txt_manv.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_manv.Location = New System.Drawing.Point(211, 32)
        Me.txt_manv.Name = "txt_manv"
        Me.txt_manv.Size = New System.Drawing.Size(200, 27)
        Me.txt_manv.TabIndex = 1
        '
        'txt_Name
        '
        Me.txt_Name.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Name.Location = New System.Drawing.Point(211, 72)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(200, 27)
        Me.txt_Name.TabIndex = 2
        '
        'lbl_manv
        '
        Me.lbl_manv.AutoSize = True
        Me.lbl_manv.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_manv.Location = New System.Drawing.Point(6, 35)
        Me.lbl_manv.Name = "lbl_manv"
        Me.lbl_manv.Size = New System.Drawing.Size(113, 19)
        Me.lbl_manv.TabIndex = 36
        Me.lbl_manv.Text = "Mã nhân viên:"
        '
        'dtp_bd
        '
        Me.dtp_bd.CalendarFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_bd.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_bd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_bd.Location = New System.Drawing.Point(211, 108)
        Me.dtp_bd.Name = "dtp_bd"
        Me.dtp_bd.Size = New System.Drawing.Size(200, 28)
        Me.dtp_bd.TabIndex = 3
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(6, 75)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(64, 19)
        Me.lbl_Name.TabIndex = 36
        Me.lbl_Name.Text = "Họ tên:"
        '
        'txt_pw
        '
        Me.txt_pw.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pw.Location = New System.Drawing.Point(211, 312)
        Me.txt_pw.Name = "txt_pw"
        Me.txt_pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pw.Size = New System.Drawing.Size(200, 27)
        Me.txt_pw.TabIndex = 8
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(211, 272)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(200, 27)
        Me.txt_id.TabIndex = 7
        '
        'lbl_pw
        '
        Me.lbl_pw.AutoSize = True
        Me.lbl_pw.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pw.Location = New System.Drawing.Point(6, 315)
        Me.lbl_pw.Name = "lbl_pw"
        Me.lbl_pw.Size = New System.Drawing.Size(84, 19)
        Me.lbl_pw.TabIndex = 34
        Me.lbl_pw.Text = "Mật khẩu:"
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ID.Location = New System.Drawing.Point(6, 275)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(120, 19)
        Me.lbl_ID.TabIndex = 34
        Me.lbl_ID.Text = "Tên đăng nhập:"
        '
        'lbl_role
        '
        Me.lbl_role.AutoSize = True
        Me.lbl_role.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_role.Location = New System.Drawing.Point(6, 235)
        Me.lbl_role.Name = "lbl_role"
        Me.lbl_role.Size = New System.Drawing.Size(99, 19)
        Me.lbl_role.TabIndex = 34
        Me.lbl_role.Text = "Phân quyền:"
        '
        'lbl_birthday
        '
        Me.lbl_birthday.AutoSize = True
        Me.lbl_birthday.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_birthday.Location = New System.Drawing.Point(6, 115)
        Me.lbl_birthday.Name = "lbl_birthday"
        Me.lbl_birthday.Size = New System.Drawing.Size(87, 19)
        Me.lbl_birthday.TabIndex = 35
        Me.lbl_birthday.Text = "Ngày sinh:"
        '
        'lbl_terminal
        '
        Me.lbl_terminal.AutoSize = True
        Me.lbl_terminal.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_terminal.Location = New System.Drawing.Point(6, 195)
        Me.lbl_terminal.Name = "lbl_terminal"
        Me.lbl_terminal.Size = New System.Drawing.Size(84, 19)
        Me.lbl_terminal.TabIndex = 34
        Me.lbl_terminal.Text = "Cửa hàng:"
        '
        'lbl_startdate
        '
        Me.lbl_startdate.AutoSize = True
        Me.lbl_startdate.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_startdate.Location = New System.Drawing.Point(6, 155)
        Me.lbl_startdate.Name = "lbl_startdate"
        Me.lbl_startdate.Size = New System.Drawing.Size(175, 19)
        Me.lbl_startdate.TabIndex = 33
        Me.lbl_startdate.Text = "Ngày bắt đầu làm việc:"
        '
        'frm_AddStaffInfo
        '
        Me.AcceptButton = Me.btn_Add
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(723, 587)
        Me.ControlBox = False
        Me.Controls.Add(Me.grb_Info)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_AddStaffInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm thông tin nhân viên"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_Info.ResumeLayout(False)
        Me.grb_Info.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents grb_Info As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_Sd As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_manv As System.Windows.Forms.TextBox
    Friend WithEvents txt_Name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_manv As System.Windows.Forms.Label
    Friend WithEvents dtp_bd As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Name As System.Windows.Forms.Label
    Friend WithEvents txt_pw As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_pw As System.Windows.Forms.Label
    Friend WithEvents lbl_ID As System.Windows.Forms.Label
    Friend WithEvents lbl_birthday As System.Windows.Forms.Label
    Friend WithEvents lbl_terminal As System.Windows.Forms.Label
    Friend WithEvents lbl_startdate As System.Windows.Forms.Label
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents btn_Refesh As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents cbb_roles As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_role As System.Windows.Forms.Label
    Friend WithEvents cbb_terminal As System.Windows.Forms.ComboBox
End Class
