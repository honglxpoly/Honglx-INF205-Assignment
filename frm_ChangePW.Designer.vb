<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ChangePW
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ChangePW))
        Me.ptb_pw = New System.Windows.Forms.PictureBox()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.grb_Info = New System.Windows.Forms.GroupBox()
        Me.cbb_username = New System.Windows.Forms.ComboBox()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Refesh = New System.Windows.Forms.Button()
        Me.btn_Change = New System.Windows.Forms.Button()
        Me.txt_confirm = New System.Windows.Forms.TextBox()
        Me.txt_newpw = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_oldpw = New System.Windows.Forms.TextBox()
        Me.lbl_confirm = New System.Windows.Forms.Label()
        Me.lbl_newpw = New System.Windows.Forms.Label()
        Me.lbl_oldpw = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.dgv_Info = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgv_username = New System.Windows.Forms.DataGridView()
        Me.dgv_pw = New System.Windows.Forms.DataGridView()
        CType(Me.ptb_pw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_Info.SuspendLayout()
        CType(Me.dgv_Info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_pw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptb_pw
        '
        Me.ptb_pw.Image = Global.INF205_Asm.My.Resources.Resources.password_manager_1
        Me.ptb_pw.Location = New System.Drawing.Point(12, 150)
        Me.ptb_pw.Name = "ptb_pw"
        Me.ptb_pw.Size = New System.Drawing.Size(244, 392)
        Me.ptb_pw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptb_pw.TabIndex = 0
        Me.ptb_pw.TabStop = False
        '
        'lbl_Title
        '
        Me.lbl_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Title.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.White
        Me.lbl_Title.Location = New System.Drawing.Point(262, 12)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(608, 102)
        Me.lbl_Title.TabIndex = 1
        Me.lbl_Title.Text = "Đổi Mật Khẩu"
        Me.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grb_Info
        '
        Me.grb_Info.Controls.Add(Me.cbb_username)
        Me.grb_Info.Controls.Add(Me.btn_Exit)
        Me.grb_Info.Controls.Add(Me.btn_Back)
        Me.grb_Info.Controls.Add(Me.btn_Refesh)
        Me.grb_Info.Controls.Add(Me.btn_Change)
        Me.grb_Info.Controls.Add(Me.txt_confirm)
        Me.grb_Info.Controls.Add(Me.txt_newpw)
        Me.grb_Info.Controls.Add(Me.txt_username)
        Me.grb_Info.Controls.Add(Me.txt_oldpw)
        Me.grb_Info.Controls.Add(Me.lbl_confirm)
        Me.grb_Info.Controls.Add(Me.lbl_newpw)
        Me.grb_Info.Controls.Add(Me.lbl_oldpw)
        Me.grb_Info.Controls.Add(Me.lbl_user)
        Me.grb_Info.Controls.Add(Me.dgv_Info)
        Me.grb_Info.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Info.ForeColor = System.Drawing.Color.White
        Me.grb_Info.Location = New System.Drawing.Point(262, 136)
        Me.grb_Info.Name = "grb_Info"
        Me.grb_Info.Size = New System.Drawing.Size(608, 406)
        Me.grb_Info.TabIndex = 2
        Me.grb_Info.TabStop = False
        Me.grb_Info.Text = "Thông tin người dùng"
        '
        'cbb_username
        '
        Me.cbb_username.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbb_username.FormattingEnabled = True
        Me.cbb_username.Location = New System.Drawing.Point(232, 54)
        Me.cbb_username.Name = "cbb_username"
        Me.cbb_username.Size = New System.Drawing.Size(323, 30)
        Me.cbb_username.TabIndex = 1
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.White
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Exit.Location = New System.Drawing.Point(405, 342)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(150, 50)
        Me.btn_Exit.TabIndex = 8
        Me.btn_Exit.Text = "Thoát"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.White
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Back.Location = New System.Drawing.Point(232, 342)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(150, 50)
        Me.btn_Back.TabIndex = 7
        Me.btn_Back.Text = "Trở về"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Refesh
        '
        Me.btn_Refesh.BackColor = System.Drawing.Color.White
        Me.btn_Refesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Refesh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Refesh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Refesh.Location = New System.Drawing.Point(405, 269)
        Me.btn_Refesh.Name = "btn_Refesh"
        Me.btn_Refesh.Size = New System.Drawing.Size(150, 50)
        Me.btn_Refesh.TabIndex = 6
        Me.btn_Refesh.Text = "Làm lại"
        Me.btn_Refesh.UseVisualStyleBackColor = False
        '
        'btn_Change
        '
        Me.btn_Change.BackColor = System.Drawing.Color.White
        Me.btn_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Change.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Change.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Change.Location = New System.Drawing.Point(232, 268)
        Me.btn_Change.Name = "btn_Change"
        Me.btn_Change.Size = New System.Drawing.Size(150, 50)
        Me.btn_Change.TabIndex = 5
        Me.btn_Change.Text = "Xác nhận"
        Me.btn_Change.UseVisualStyleBackColor = False
        '
        'txt_confirm
        '
        Me.txt_confirm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirm.Location = New System.Drawing.Point(232, 205)
        Me.txt_confirm.Name = "txt_confirm"
        Me.txt_confirm.Size = New System.Drawing.Size(323, 30)
        Me.txt_confirm.TabIndex = 4
        Me.txt_confirm.UseSystemPasswordChar = True
        '
        'txt_newpw
        '
        Me.txt_newpw.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_newpw.Location = New System.Drawing.Point(232, 155)
        Me.txt_newpw.Name = "txt_newpw"
        Me.txt_newpw.Size = New System.Drawing.Size(323, 30)
        Me.txt_newpw.TabIndex = 3
        Me.txt_newpw.UseSystemPasswordChar = True
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(232, 55)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.ReadOnly = True
        Me.txt_username.Size = New System.Drawing.Size(323, 30)
        Me.txt_username.TabIndex = 96
        '
        'txt_oldpw
        '
        Me.txt_oldpw.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_oldpw.Location = New System.Drawing.Point(232, 105)
        Me.txt_oldpw.Name = "txt_oldpw"
        Me.txt_oldpw.Size = New System.Drawing.Size(323, 30)
        Me.txt_oldpw.TabIndex = 2
        Me.txt_oldpw.UseSystemPasswordChar = True
        '
        'lbl_confirm
        '
        Me.lbl_confirm.AutoSize = True
        Me.lbl_confirm.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_confirm.Location = New System.Drawing.Point(40, 205)
        Me.lbl_confirm.Name = "lbl_confirm"
        Me.lbl_confirm.Size = New System.Drawing.Size(108, 25)
        Me.lbl_confirm.TabIndex = 4
        Me.lbl_confirm.Text = "Xác nhận:"
        '
        'lbl_newpw
        '
        Me.lbl_newpw.AutoSize = True
        Me.lbl_newpw.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_newpw.Location = New System.Drawing.Point(40, 155)
        Me.lbl_newpw.Name = "lbl_newpw"
        Me.lbl_newpw.Size = New System.Drawing.Size(152, 25)
        Me.lbl_newpw.TabIndex = 4
        Me.lbl_newpw.Text = "Mật khẩu mới:"
        '
        'lbl_oldpw
        '
        Me.lbl_oldpw.AutoSize = True
        Me.lbl_oldpw.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_oldpw.Location = New System.Drawing.Point(40, 105)
        Me.lbl_oldpw.Name = "lbl_oldpw"
        Me.lbl_oldpw.Size = New System.Drawing.Size(138, 25)
        Me.lbl_oldpw.TabIndex = 4
        Me.lbl_oldpw.Text = "Mật khẩu cũ:"
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(40, 55)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(161, 25)
        Me.lbl_user.TabIndex = 4
        Me.lbl_user.Text = "Tên đăng nhập:"
        '
        'dgv_Info
        '
        Me.dgv_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Info.Location = New System.Drawing.Point(232, 269)
        Me.dgv_Info.Name = "dgv_Info"
        Me.dgv_Info.RowTemplate.Height = 24
        Me.dgv_Info.Size = New System.Drawing.Size(150, 49)
        Me.dgv_Info.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.INF205_Asm.My.Resources.Resources.passio3
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(244, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'dgv_username
        '
        Me.dgv_username.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_username.Location = New System.Drawing.Point(22, 200)
        Me.dgv_username.Name = "dgv_username"
        Me.dgv_username.RowTemplate.Height = 24
        Me.dgv_username.Size = New System.Drawing.Size(214, 121)
        Me.dgv_username.TabIndex = 4
        '
        'dgv_pw
        '
        Me.dgv_pw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pw.Location = New System.Drawing.Point(12, 392)
        Me.dgv_pw.Name = "dgv_pw"
        Me.dgv_pw.RowTemplate.Height = 24
        Me.dgv_pw.Size = New System.Drawing.Size(240, 150)
        Me.dgv_pw.TabIndex = 5
        '
        'frm_ChangePW
        '
        Me.AcceptButton = Me.btn_Change
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(893, 567)
        Me.ControlBox = False
        Me.Controls.Add(Me.ptb_pw)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grb_Info)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.dgv_username)
        Me.Controls.Add(Me.dgv_pw)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_ChangePW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đổi mật khẩu"
        CType(Me.ptb_pw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_Info.ResumeLayout(False)
        Me.grb_Info.PerformLayout()
        CType(Me.dgv_Info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_pw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ptb_pw As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents grb_Info As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents txt_oldpw As System.Windows.Forms.TextBox
    Friend WithEvents lbl_confirm As System.Windows.Forms.Label
    Friend WithEvents lbl_newpw As System.Windows.Forms.Label
    Friend WithEvents lbl_oldpw As System.Windows.Forms.Label
    Friend WithEvents txt_confirm As System.Windows.Forms.TextBox
    Friend WithEvents txt_newpw As System.Windows.Forms.TextBox
    Friend WithEvents btn_Change As System.Windows.Forms.Button
    Friend WithEvents btn_Refesh As System.Windows.Forms.Button
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents dgv_Info As System.Windows.Forms.DataGridView
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents cbb_username As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_username As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_pw As System.Windows.Forms.DataGridView
End Class
