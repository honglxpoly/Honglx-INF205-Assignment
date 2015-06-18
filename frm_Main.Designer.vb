<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.mns_menu = New System.Windows.Forms.MenuStrip()
        Me.mni_HeThong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_DangXuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Thoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_nhomsp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_QLNSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_SP = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_QLSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_KH = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_QLKH = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_HoaDon = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_QLHD = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_TaiKhoan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_QLNV = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_DoiMK = New System.Windows.Forms.ToolStripMenuItem()
        Me.grb_Info = New System.Windows.Forms.GroupBox()
        Me.lbl_terminalinfo = New System.Windows.Forms.Label()
        Me.lbl_rolesinfo = New System.Windows.Forms.Label()
        Me.lbl_nameinfo = New System.Windows.Forms.Label()
        Me.lbl_terminal = New System.Windows.Forms.Label()
        Me.lbl_roles = New System.Windows.Forms.Label()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mns_menu.SuspendLayout()
        Me.grb_Info.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mns_menu
        '
        Me.mns_menu.BackColor = System.Drawing.Color.White
        Me.mns_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.mns_menu.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mns_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mni_HeThong, Me.mni_nhomsp, Me.mni_SP, Me.mni_KH, Me.mni_HoaDon, Me.mni_TaiKhoan})
        Me.mns_menu.Location = New System.Drawing.Point(0, 0)
        Me.mns_menu.Margin = New System.Windows.Forms.Padding(5)
        Me.mns_menu.Name = "mns_menu"
        Me.mns_menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mns_menu.Size = New System.Drawing.Size(920, 33)
        Me.mns_menu.TabIndex = 0
        Me.mns_menu.Text = "MenuStrip1"
        '
        'mni_HeThong
        '
        Me.mni_HeThong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mni_DangXuat, Me.mni_Thoat})
        Me.mni_HeThong.Name = "mni_HeThong"
        Me.mni_HeThong.Size = New System.Drawing.Size(102, 29)
        Me.mni_HeThong.Text = "Hệ thống"
        '
        'mni_DangXuat
        '
        Me.mni_DangXuat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mni_DangXuat.Name = "mni_DangXuat"
        Me.mni_DangXuat.Size = New System.Drawing.Size(160, 26)
        Me.mni_DangXuat.Text = "Đăng xuất"
        '
        'mni_Thoat
        '
        Me.mni_Thoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mni_Thoat.Name = "mni_Thoat"
        Me.mni_Thoat.Size = New System.Drawing.Size(160, 26)
        Me.mni_Thoat.Text = "Thoát"
        '
        'mni_nhomsp
        '
        Me.mni_nhomsp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mni_QLNSP})
        Me.mni_nhomsp.Name = "mni_nhomsp"
        Me.mni_nhomsp.Size = New System.Drawing.Size(165, 29)
        Me.mni_nhomsp.Text = "Nhóm sản phẩm"
        '
        'mni_QLNSP
        '
        Me.mni_QLNSP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mni_QLNSP.Name = "mni_QLNSP"
        Me.mni_QLNSP.Size = New System.Drawing.Size(269, 26)
        Me.mni_QLNSP.Text = "Quản lý nhóm sản phẩm"
        '
        'mni_SP
        '
        Me.mni_SP.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mni_QLSP})
        Me.mni_SP.Name = "mni_SP"
        Me.mni_SP.Size = New System.Drawing.Size(109, 29)
        Me.mni_SP.Text = "Sản phẩm"
        '
        'mni_QLSP
        '
        Me.mni_QLSP.Name = "mni_QLSP"
        Me.mni_QLSP.Size = New System.Drawing.Size(242, 30)
        Me.mni_QLSP.Text = "Quản lý sản phẩm"
        '
        'mni_KH
        '
        Me.mni_KH.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mni_QLKH})
        Me.mni_KH.Name = "mni_KH"
        Me.mni_KH.Size = New System.Drawing.Size(125, 29)
        Me.mni_KH.Text = "Khách hàng"
        '
        'mni_QLKH
        '
        Me.mni_QLKH.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mni_QLKH.Name = "mni_QLKH"
        Me.mni_QLKH.Size = New System.Drawing.Size(307, 26)
        Me.mni_QLKH.Text = "Quản lý thông tin khách hàng"
        '
        'mni_HoaDon
        '
        Me.mni_HoaDon.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mni_QLHD})
        Me.mni_HoaDon.Name = "mni_HoaDon"
        Me.mni_HoaDon.Size = New System.Drawing.Size(99, 29)
        Me.mni_HoaDon.Text = "Hóa đơn"
        '
        'mni_QLHD
        '
        Me.mni_QLHD.Name = "mni_QLHD"
        Me.mni_QLHD.Size = New System.Drawing.Size(230, 30)
        Me.mni_QLHD.Text = "Quản lý hóa đơn"
        '
        'mni_TaiKhoan
        '
        Me.mni_TaiKhoan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mni_QLNV, Me.mni_DoiMK})
        Me.mni_TaiKhoan.Name = "mni_TaiKhoan"
        Me.mni_TaiKhoan.Size = New System.Drawing.Size(112, 29)
        Me.mni_TaiKhoan.Text = "Tài khoản"
        '
        'mni_QLNV
        '
        Me.mni_QLNV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mni_QLNV.Name = "mni_QLNV"
        Me.mni_QLNV.Size = New System.Drawing.Size(300, 26)
        Me.mni_QLNV.Text = "Quản lý tài khoản nhân viên"
        '
        'mni_DoiMK
        '
        Me.mni_DoiMK.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mni_DoiMK.Name = "mni_DoiMK"
        Me.mni_DoiMK.Size = New System.Drawing.Size(300, 26)
        Me.mni_DoiMK.Text = "Đổi mật khẩu"
        '
        'grb_Info
        '
        Me.grb_Info.Controls.Add(Me.lbl_terminalinfo)
        Me.grb_Info.Controls.Add(Me.lbl_rolesinfo)
        Me.grb_Info.Controls.Add(Me.lbl_nameinfo)
        Me.grb_Info.Controls.Add(Me.lbl_terminal)
        Me.grb_Info.Controls.Add(Me.lbl_roles)
        Me.grb_Info.Controls.Add(Me.lbl_Name)
        Me.grb_Info.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Info.ForeColor = System.Drawing.Color.White
        Me.grb_Info.Location = New System.Drawing.Point(12, 491)
        Me.grb_Info.Name = "grb_Info"
        Me.grb_Info.Size = New System.Drawing.Size(894, 100)
        Me.grb_Info.TabIndex = 2
        Me.grb_Info.TabStop = False
        Me.grb_Info.Text = "Thông tin người sử dụng"
        '
        'lbl_terminalinfo
        '
        Me.lbl_terminalinfo.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_terminalinfo.Location = New System.Drawing.Point(613, 53)
        Me.lbl_terminalinfo.Name = "lbl_terminalinfo"
        Me.lbl_terminalinfo.Size = New System.Drawing.Size(275, 21)
        Me.lbl_terminalinfo.TabIndex = 2
        Me.lbl_terminalinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_rolesinfo
        '
        Me.lbl_rolesinfo.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rolesinfo.Location = New System.Drawing.Point(408, 53)
        Me.lbl_rolesinfo.Name = "lbl_rolesinfo"
        Me.lbl_rolesinfo.Size = New System.Drawing.Size(74, 21)
        Me.lbl_rolesinfo.TabIndex = 2
        Me.lbl_rolesinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_nameinfo
        '
        Me.lbl_nameinfo.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nameinfo.Location = New System.Drawing.Point(101, 53)
        Me.lbl_nameinfo.Name = "lbl_nameinfo"
        Me.lbl_nameinfo.Size = New System.Drawing.Size(204, 21)
        Me.lbl_nameinfo.TabIndex = 1
        Me.lbl_nameinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_terminal
        '
        Me.lbl_terminal.AutoSize = True
        Me.lbl_terminal.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_terminal.Location = New System.Drawing.Point(488, 50)
        Me.lbl_terminal.Name = "lbl_terminal"
        Me.lbl_terminal.Size = New System.Drawing.Size(119, 26)
        Me.lbl_terminal.TabIndex = 0
        Me.lbl_terminal.Text = "Cửa hàng:"
        '
        'lbl_roles
        '
        Me.lbl_roles.AutoSize = True
        Me.lbl_roles.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roles.Location = New System.Drawing.Point(311, 50)
        Me.lbl_roles.Name = "lbl_roles"
        Me.lbl_roles.Size = New System.Drawing.Size(91, 26)
        Me.lbl_roles.TabIndex = 0
        Me.lbl_roles.Text = "Vai trò:"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(6, 50)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(89, 26)
        Me.lbl_Name.TabIndex = 0
        Me.lbl_Name.Text = "Họ tên:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.INF205_Asm.My.Resources.Resources.ql_bg
        Me.PictureBox1.Location = New System.Drawing.Point(12, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(894, 421)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(920, 603)
        Me.ControlBox = False
        Me.Controls.Add(Me.grb_Info)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mns_menu)
        Me.Font = New System.Drawing.Font("VNI-Hobo", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mns_menu
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hệ thống quản lý bán hàng Passio Coffee"
        Me.mns_menu.ResumeLayout(False)
        Me.mns_menu.PerformLayout()
        Me.grb_Info.ResumeLayout(False)
        Me.grb_Info.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mns_menu As System.Windows.Forms.MenuStrip
    Friend WithEvents mni_HeThong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mni_DangXuat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mni_Thoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mni_nhomsp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mni_KH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mni_TaiKhoan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mni_QLNV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mni_QLNSP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mni_SP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mni_QLSP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mni_QLKH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mni_DoiMK As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grb_Info As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Name As System.Windows.Forms.Label
    Friend WithEvents lbl_terminal As System.Windows.Forms.Label
    Friend WithEvents lbl_roles As System.Windows.Forms.Label
    Friend WithEvents lbl_nameinfo As System.Windows.Forms.Label
    Friend WithEvents lbl_terminalinfo As System.Windows.Forms.Label
    Friend WithEvents lbl_rolesinfo As System.Windows.Forms.Label
    Friend WithEvents mni_HoaDon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mni_QLHD As System.Windows.Forms.ToolStripMenuItem
End Class
