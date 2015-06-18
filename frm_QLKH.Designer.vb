<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_QLKH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_QLKH))
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.grb_Info = New System.Windows.Forms.GroupBox()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Refesh = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.txt_Phone = New System.Windows.Forms.TextBox()
        Me.txt_maKH = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.lbl_Address = New System.Windows.Forms.Label()
        Me.lbl_maKH = New System.Windows.Forms.Label()
        Me.lbl_Phone = New System.Windows.Forms.Label()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.dgv_Info = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ptb_logo = New System.Windows.Forms.PictureBox()
        Me.grb_Info.SuspendLayout()
        CType(Me.dgv_Info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.Font = New System.Drawing.Font("Times New Roman", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.White
        Me.lbl_Title.Location = New System.Drawing.Point(157, 8)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(923, 115)
        Me.lbl_Title.TabIndex = 1
        Me.lbl_Title.Text = "Quản lý thông tin khách hàng"
        Me.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grb_Info
        '
        Me.grb_Info.Controls.Add(Me.btn_Back)
        Me.grb_Info.Controls.Add(Me.btn_Refesh)
        Me.grb_Info.Controls.Add(Me.btn_Exit)
        Me.grb_Info.Controls.Add(Me.btn_Delete)
        Me.grb_Info.Controls.Add(Me.btn_Edit)
        Me.grb_Info.Controls.Add(Me.btn_Add)
        Me.grb_Info.Controls.Add(Me.txt_Email)
        Me.grb_Info.Controls.Add(Me.txt_Address)
        Me.grb_Info.Controls.Add(Me.txt_Phone)
        Me.grb_Info.Controls.Add(Me.txt_maKH)
        Me.grb_Info.Controls.Add(Me.txt_name)
        Me.grb_Info.Controls.Add(Me.lbl_Email)
        Me.grb_Info.Controls.Add(Me.lbl_Address)
        Me.grb_Info.Controls.Add(Me.lbl_maKH)
        Me.grb_Info.Controls.Add(Me.lbl_Phone)
        Me.grb_Info.Controls.Add(Me.lbl_Name)
        Me.grb_Info.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Info.ForeColor = System.Drawing.Color.White
        Me.grb_Info.Location = New System.Drawing.Point(167, 128)
        Me.grb_Info.Name = "grb_Info"
        Me.grb_Info.Size = New System.Drawing.Size(429, 428)
        Me.grb_Info.TabIndex = 3
        Me.grb_Info.TabStop = False
        Me.grb_Info.Text = "Thông tin khách hàng"
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.White
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Back.Location = New System.Drawing.Point(172, 370)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(102, 42)
        Me.btn_Back.TabIndex = 10
        Me.btn_Back.Text = "Trở về"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Refesh
        '
        Me.btn_Refesh.BackColor = System.Drawing.Color.White
        Me.btn_Refesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Refesh.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Refesh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Refesh.Location = New System.Drawing.Point(25, 370)
        Me.btn_Refesh.Name = "btn_Refesh"
        Me.btn_Refesh.Size = New System.Drawing.Size(102, 42)
        Me.btn_Refesh.TabIndex = 9
        Me.btn_Refesh.Text = "Làm mới"
        Me.btn_Refesh.UseVisualStyleBackColor = False
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.White
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exit.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Exit.Location = New System.Drawing.Point(319, 370)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(102, 42)
        Me.btn_Exit.TabIndex = 11
        Me.btn_Exit.Text = "Thoát"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'btn_Delete
        '
        Me.btn_Delete.BackColor = System.Drawing.Color.White
        Me.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Delete.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Delete.Location = New System.Drawing.Point(319, 300)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(102, 42)
        Me.btn_Delete.TabIndex = 8
        Me.btn_Delete.Text = "Xóa"
        Me.btn_Delete.UseVisualStyleBackColor = False
        '
        'btn_Edit
        '
        Me.btn_Edit.BackColor = System.Drawing.Color.White
        Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Edit.Location = New System.Drawing.Point(172, 300)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(102, 42)
        Me.btn_Edit.TabIndex = 7
        Me.btn_Edit.Text = "Sửa"
        Me.btn_Edit.UseVisualStyleBackColor = False
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.White
        Me.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Add.Location = New System.Drawing.Point(25, 300)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(102, 42)
        Me.btn_Add.TabIndex = 6
        Me.btn_Add.Text = "Thêm mới"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email.Location = New System.Drawing.Point(156, 250)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(265, 30)
        Me.txt_Email.TabIndex = 5
        '
        'txt_Address
        '
        Me.txt_Address.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Address.Location = New System.Drawing.Point(156, 200)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(265, 30)
        Me.txt_Address.TabIndex = 4
        '
        'txt_Phone
        '
        Me.txt_Phone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Phone.Location = New System.Drawing.Point(156, 150)
        Me.txt_Phone.Name = "txt_Phone"
        Me.txt_Phone.Size = New System.Drawing.Size(265, 30)
        Me.txt_Phone.TabIndex = 3
        '
        'txt_maKH
        '
        Me.txt_maKH.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_maKH.Location = New System.Drawing.Point(156, 43)
        Me.txt_maKH.Name = "txt_maKH"
        Me.txt_maKH.Size = New System.Drawing.Size(265, 30)
        Me.txt_maKH.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(156, 100)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(265, 30)
        Me.txt_name.TabIndex = 2
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Email.Location = New System.Drawing.Point(25, 250)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(81, 26)
        Me.lbl_Email.TabIndex = 4
        Me.lbl_Email.Text = "Email:"
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Address.Location = New System.Drawing.Point(25, 200)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(93, 26)
        Me.lbl_Address.TabIndex = 4
        Me.lbl_Address.Text = "Địa chỉ:"
        '
        'lbl_maKH
        '
        Me.lbl_maKH.AutoSize = True
        Me.lbl_maKH.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_maKH.Location = New System.Drawing.Point(25, 50)
        Me.lbl_maKH.Name = "lbl_maKH"
        Me.lbl_maKH.Size = New System.Drawing.Size(99, 26)
        Me.lbl_maKH.TabIndex = 4
        Me.lbl_maKH.Text = "Mã KH:"
        '
        'lbl_Phone
        '
        Me.lbl_Phone.AutoSize = True
        Me.lbl_Phone.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Phone.Location = New System.Drawing.Point(25, 150)
        Me.lbl_Phone.Name = "lbl_Phone"
        Me.lbl_Phone.Size = New System.Drawing.Size(126, 26)
        Me.lbl_Phone.TabIndex = 4
        Me.lbl_Phone.Text = "Điện thoại:"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(25, 100)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(89, 26)
        Me.lbl_Name.TabIndex = 4
        Me.lbl_Name.Text = "Họ tên:"
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
        Me.dgv_Info.Location = New System.Drawing.Point(604, 140)
        Me.dgv_Info.Margin = New System.Windows.Forms.Padding(5)
        Me.dgv_Info.Name = "dgv_Info"
        Me.dgv_Info.RowHeadersVisible = False
        Me.dgv_Info.RowTemplate.Height = 24
        Me.dgv_Info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Info.Size = New System.Drawing.Size(476, 416)
        Me.dgv_Info.TabIndex = 26
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.INF205_Asm.My.Resources.Resources.join_renew_icon_2x
        Me.PictureBox1.Location = New System.Drawing.Point(10, 128)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 428)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ptb_logo
        '
        Me.ptb_logo.Image = Global.INF205_Asm.My.Resources.Resources.passio3
        Me.ptb_logo.Location = New System.Drawing.Point(12, 0)
        Me.ptb_logo.Name = "ptb_logo"
        Me.ptb_logo.Size = New System.Drawing.Size(144, 123)
        Me.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptb_logo.TabIndex = 0
        Me.ptb_logo.TabStop = False
        '
        'frm_QLKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1094, 581)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv_Info)
        Me.Controls.Add(Me.grb_Info)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.ptb_logo)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_QLKH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý thông tin khách hàng"
        Me.grb_Info.ResumeLayout(False)
        Me.grb_Info.PerformLayout()
        CType(Me.dgv_Info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ptb_logo As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grb_Info As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Name As System.Windows.Forms.Label
    Friend WithEvents lbl_Phone As System.Windows.Forms.Label
    Friend WithEvents lbl_Address As System.Windows.Forms.Label
    Friend WithEvents lbl_Email As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_Email As System.Windows.Forms.TextBox
    Friend WithEvents txt_Address As System.Windows.Forms.TextBox
    Friend WithEvents txt_Phone As System.Windows.Forms.TextBox
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents btn_Refesh As System.Windows.Forms.Button
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents btn_Delete As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents dgv_Info As System.Windows.Forms.DataGridView
    Friend WithEvents txt_maKH As System.Windows.Forms.TextBox
    Friend WithEvents lbl_maKH As System.Windows.Forms.Label
End Class
