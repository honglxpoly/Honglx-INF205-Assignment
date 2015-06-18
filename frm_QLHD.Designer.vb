<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_QLHD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_QLHD))
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.grb_Info = New System.Windows.Forms.GroupBox()
        Me.txt_maHD = New System.Windows.Forms.TextBox()
        Me.txt_Customer = New System.Windows.Forms.TextBox()
        Me.lbl_maHD = New System.Windows.Forms.Label()
        Me.lbl_cusname = New System.Windows.Forms.Label()
        Me.txt_Staff = New System.Windows.Forms.TextBox()
        Me.lbl_StaffName = New System.Windows.Forms.Label()
        Me.lbl_Terminal = New System.Windows.Forms.Label()
        Me.txt_Terminal = New System.Windows.Forms.TextBox()
        Me.lbl_DateCreate = New System.Windows.Forms.Label()
        Me.dgv_Info = New System.Windows.Forms.DataGridView()
        Me.txt_DateCreate = New System.Windows.Forms.TextBox()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_Refesh = New System.Windows.Forms.Button()
        Me.btn_details = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.ptb_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_Value = New System.Windows.Forms.Label()
        Me.txt_value = New System.Windows.Forms.TextBox()
        Me.grb_Info.SuspendLayout()
        CType(Me.dgv_Info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.Font = New System.Drawing.Font("Times New Roman", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.White
        Me.lbl_Title.Location = New System.Drawing.Point(131, 10)
        Me.lbl_Title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(864, 110)
        Me.lbl_Title.TabIndex = 90
        Me.lbl_Title.Text = "Thông tin hóa đơn"
        Me.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grb_Info
        '
        Me.grb_Info.Controls.Add(Me.btn_Back)
        Me.grb_Info.Controls.Add(Me.btn_details)
        Me.grb_Info.Controls.Add(Me.btn_Refesh)
        Me.grb_Info.Controls.Add(Me.btn_Exit)
        Me.grb_Info.Controls.Add(Me.txt_value)
        Me.grb_Info.Controls.Add(Me.txt_DateCreate)
        Me.grb_Info.Controls.Add(Me.txt_Terminal)
        Me.grb_Info.Controls.Add(Me.txt_Staff)
        Me.grb_Info.Controls.Add(Me.lbl_Value)
        Me.grb_Info.Controls.Add(Me.lbl_DateCreate)
        Me.grb_Info.Controls.Add(Me.txt_maHD)
        Me.grb_Info.Controls.Add(Me.lbl_Terminal)
        Me.grb_Info.Controls.Add(Me.txt_Customer)
        Me.grb_Info.Controls.Add(Me.lbl_StaffName)
        Me.grb_Info.Controls.Add(Me.lbl_maHD)
        Me.grb_Info.Controls.Add(Me.lbl_cusname)
        Me.grb_Info.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Info.ForeColor = System.Drawing.Color.White
        Me.grb_Info.Location = New System.Drawing.Point(11, 140)
        Me.grb_Info.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grb_Info.Name = "grb_Info"
        Me.grb_Info.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grb_Info.Size = New System.Drawing.Size(443, 429)
        Me.grb_Info.TabIndex = 91
        Me.grb_Info.TabStop = False
        Me.grb_Info.Text = "Thông tin hóa đơn"
        '
        'txt_maHD
        '
        Me.txt_maHD.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_maHD.Location = New System.Drawing.Point(195, 50)
        Me.txt_maHD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_maHD.Name = "txt_maHD"
        Me.txt_maHD.Size = New System.Drawing.Size(230, 30)
        Me.txt_maHD.TabIndex = 1
        '
        'txt_Customer
        '
        Me.txt_Customer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Customer.Location = New System.Drawing.Point(195, 90)
        Me.txt_Customer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_Customer.Name = "txt_Customer"
        Me.txt_Customer.Size = New System.Drawing.Size(230, 30)
        Me.txt_Customer.TabIndex = 2
        '
        'lbl_maHD
        '
        Me.lbl_maHD.AutoSize = True
        Me.lbl_maHD.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_maHD.Location = New System.Drawing.Point(10, 50)
        Me.lbl_maHD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_maHD.Name = "lbl_maHD"
        Me.lbl_maHD.Size = New System.Drawing.Size(143, 25)
        Me.lbl_maHD.TabIndex = 4
        Me.lbl_maHD.Text = "Mã hóa đơn:"
        '
        'lbl_cusname
        '
        Me.lbl_cusname.AutoSize = True
        Me.lbl_cusname.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cusname.Location = New System.Drawing.Point(10, 90)
        Me.lbl_cusname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_cusname.Name = "lbl_cusname"
        Me.lbl_cusname.Size = New System.Drawing.Size(181, 25)
        Me.lbl_cusname.TabIndex = 4
        Me.lbl_cusname.Text = "Tên khách hàng:"
        '
        'txt_Staff
        '
        Me.txt_Staff.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Staff.Location = New System.Drawing.Point(195, 130)
        Me.txt_Staff.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_Staff.Name = "txt_Staff"
        Me.txt_Staff.Size = New System.Drawing.Size(230, 30)
        Me.txt_Staff.TabIndex = 5
        '
        'lbl_StaffName
        '
        Me.lbl_StaffName.AutoSize = True
        Me.lbl_StaffName.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_StaffName.Location = New System.Drawing.Point(10, 130)
        Me.lbl_StaffName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_StaffName.Name = "lbl_StaffName"
        Me.lbl_StaffName.Size = New System.Drawing.Size(160, 25)
        Me.lbl_StaffName.TabIndex = 4
        Me.lbl_StaffName.Text = "Tên nhân viên:"
        '
        'lbl_Terminal
        '
        Me.lbl_Terminal.AutoSize = True
        Me.lbl_Terminal.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Terminal.Location = New System.Drawing.Point(10, 170)
        Me.lbl_Terminal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Terminal.Name = "lbl_Terminal"
        Me.lbl_Terminal.Size = New System.Drawing.Size(119, 25)
        Me.lbl_Terminal.TabIndex = 4
        Me.lbl_Terminal.Text = "Cửa hàng:"
        '
        'txt_Terminal
        '
        Me.txt_Terminal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Terminal.Location = New System.Drawing.Point(195, 170)
        Me.txt_Terminal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_Terminal.Name = "txt_Terminal"
        Me.txt_Terminal.Size = New System.Drawing.Size(230, 30)
        Me.txt_Terminal.TabIndex = 5
        '
        'lbl_DateCreate
        '
        Me.lbl_DateCreate.AutoSize = True
        Me.lbl_DateCreate.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DateCreate.Location = New System.Drawing.Point(10, 210)
        Me.lbl_DateCreate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_DateCreate.Name = "lbl_DateCreate"
        Me.lbl_DateCreate.Size = New System.Drawing.Size(108, 25)
        Me.lbl_DateCreate.TabIndex = 4
        Me.lbl_DateCreate.Text = "Ngày lập:"
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
        Me.dgv_Info.Location = New System.Drawing.Point(460, 156)
        Me.dgv_Info.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_Info.Name = "dgv_Info"
        Me.dgv_Info.RowHeadersVisible = False
        Me.dgv_Info.RowTemplate.Height = 24
        Me.dgv_Info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Info.Size = New System.Drawing.Size(533, 413)
        Me.dgv_Info.TabIndex = 92
        '
        'txt_DateCreate
        '
        Me.txt_DateCreate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DateCreate.Location = New System.Drawing.Point(195, 210)
        Me.txt_DateCreate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_DateCreate.Name = "txt_DateCreate"
        Me.txt_DateCreate.Size = New System.Drawing.Size(230, 30)
        Me.txt_DateCreate.TabIndex = 5
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.White
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Exit.Location = New System.Drawing.Point(325, 366)
        Me.btn_Exit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(100, 50)
        Me.btn_Exit.TabIndex = 14
        Me.btn_Exit.Text = "Thoát"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'btn_Refesh
        '
        Me.btn_Refesh.BackColor = System.Drawing.Color.White
        Me.btn_Refesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Refesh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Refesh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Refesh.Location = New System.Drawing.Point(325, 296)
        Me.btn_Refesh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_Refesh.Name = "btn_Refesh"
        Me.btn_Refesh.Size = New System.Drawing.Size(100, 50)
        Me.btn_Refesh.TabIndex = 14
        Me.btn_Refesh.Text = "Làm mới"
        Me.btn_Refesh.UseVisualStyleBackColor = False
        '
        'btn_details
        '
        Me.btn_details.BackColor = System.Drawing.Color.White
        Me.btn_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_details.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_details.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_details.Location = New System.Drawing.Point(195, 296)
        Me.btn_details.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_details.Name = "btn_details"
        Me.btn_details.Size = New System.Drawing.Size(100, 50)
        Me.btn_details.TabIndex = 14
        Me.btn_details.Text = "Chi tiết"
        Me.btn_details.UseVisualStyleBackColor = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.White
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Back.Location = New System.Drawing.Point(195, 366)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(100, 50)
        Me.btn_Back.TabIndex = 15
        Me.btn_Back.Text = "Trở về"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'ptb_logo
        '
        Me.ptb_logo.Image = Global.INF205_Asm.My.Resources.Resources.passio3
        Me.ptb_logo.Location = New System.Drawing.Point(9, 10)
        Me.ptb_logo.Margin = New System.Windows.Forms.Padding(2)
        Me.ptb_logo.Name = "ptb_logo"
        Me.ptb_logo.Size = New System.Drawing.Size(119, 110)
        Me.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptb_logo.TabIndex = 0
        Me.ptb_logo.TabStop = False
        '
        'lbl_Value
        '
        Me.lbl_Value.AutoSize = True
        Me.lbl_Value.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Value.Location = New System.Drawing.Point(10, 250)
        Me.lbl_Value.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Value.Name = "lbl_Value"
        Me.lbl_Value.Size = New System.Drawing.Size(115, 25)
        Me.lbl_Value.TabIndex = 4
        Me.lbl_Value.Text = "Tổng tiền:"
        '
        'txt_value
        '
        Me.txt_value.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_value.Location = New System.Drawing.Point(195, 250)
        Me.txt_value.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_value.Name = "txt_value"
        Me.txt_value.Size = New System.Drawing.Size(230, 30)
        Me.txt_value.TabIndex = 5
        '
        'frm_QLHD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1006, 580)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv_Info)
        Me.Controls.Add(Me.grb_Info)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.ptb_logo)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_QLHD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý thông tin hóa đơn"
        Me.grb_Info.ResumeLayout(False)
        Me.grb_Info.PerformLayout()
        CType(Me.dgv_Info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ptb_logo As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents grb_Info As System.Windows.Forms.GroupBox
    Friend WithEvents txt_maHD As System.Windows.Forms.TextBox
    Friend WithEvents txt_Customer As System.Windows.Forms.TextBox
    Friend WithEvents lbl_maHD As System.Windows.Forms.Label
    Friend WithEvents lbl_cusname As System.Windows.Forms.Label
    Friend WithEvents txt_Terminal As System.Windows.Forms.TextBox
    Friend WithEvents txt_Staff As System.Windows.Forms.TextBox
    Friend WithEvents lbl_DateCreate As System.Windows.Forms.Label
    Friend WithEvents lbl_Terminal As System.Windows.Forms.Label
    Friend WithEvents lbl_StaffName As System.Windows.Forms.Label
    Friend WithEvents dgv_Info As System.Windows.Forms.DataGridView
    Friend WithEvents txt_DateCreate As System.Windows.Forms.TextBox
    Friend WithEvents btn_Refesh As System.Windows.Forms.Button
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents btn_details As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents txt_value As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Value As System.Windows.Forms.Label
End Class
