<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_QLSP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_QLSP))
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.grb_info = New System.Windows.Forms.GroupBox()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Refesh = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.txttonkho = New System.Windows.Forms.TextBox()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.txtten = New System.Windows.Forms.TextBox()
        Me.txtmaloai = New System.Windows.Forms.TextBox()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.lbl_TonKho = New System.Windows.Forms.Label()
        Me.lbl_DonGia = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_loai = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.dgv_Info = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grb_info.SuspendLayout()
        CType(Me.dgv_Info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Title.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.White
        Me.lbl_Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_Title.Location = New System.Drawing.Point(311, 46)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(738, 68)
        Me.lbl_Title.TabIndex = 1
        Me.lbl_Title.Text = "Quản lý thông tin sản phẩm"
        '
        'grb_info
        '
        Me.grb_info.Controls.Add(Me.btn_Exit)
        Me.grb_info.Controls.Add(Me.btn_Back)
        Me.grb_info.Controls.Add(Me.btn_Delete)
        Me.grb_info.Controls.Add(Me.btn_Refesh)
        Me.grb_info.Controls.Add(Me.btn_Edit)
        Me.grb_info.Controls.Add(Me.btn_Add)
        Me.grb_info.Controls.Add(Me.txttonkho)
        Me.grb_info.Controls.Add(Me.txtdongia)
        Me.grb_info.Controls.Add(Me.txtten)
        Me.grb_info.Controls.Add(Me.txtmaloai)
        Me.grb_info.Controls.Add(Me.txtmasp)
        Me.grb_info.Controls.Add(Me.lbl_TonKho)
        Me.grb_info.Controls.Add(Me.lbl_DonGia)
        Me.grb_info.Controls.Add(Me.lbl_name)
        Me.grb_info.Controls.Add(Me.lbl_loai)
        Me.grb_info.Controls.Add(Me.lbl_id)
        Me.grb_info.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_info.ForeColor = System.Drawing.Color.White
        Me.grb_info.Location = New System.Drawing.Point(12, 173)
        Me.grb_info.Name = "grb_info"
        Me.grb_info.Size = New System.Drawing.Size(518, 419)
        Me.grb_info.TabIndex = 2
        Me.grb_info.TabStop = False
        Me.grb_info.Text = "Thông tin sản phẩm"
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.White
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Exit.Location = New System.Drawing.Point(372, 355)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(120, 50)
        Me.btn_Exit.TabIndex = 11
        Me.btn_Exit.Text = "Thoát"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.White
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Back.Location = New System.Drawing.Point(203, 355)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(120, 50)
        Me.btn_Back.TabIndex = 10
        Me.btn_Back.Text = "Trở về"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Delete
        '
        Me.btn_Delete.BackColor = System.Drawing.Color.White
        Me.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Delete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Delete.Location = New System.Drawing.Point(372, 283)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(120, 50)
        Me.btn_Delete.TabIndex = 8
        Me.btn_Delete.Text = "Xóa"
        Me.btn_Delete.UseVisualStyleBackColor = False
        '
        'btn_Refesh
        '
        Me.btn_Refesh.BackColor = System.Drawing.Color.White
        Me.btn_Refesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Refesh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Refesh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Refesh.Location = New System.Drawing.Point(29, 355)
        Me.btn_Refesh.Name = "btn_Refesh"
        Me.btn_Refesh.Size = New System.Drawing.Size(120, 50)
        Me.btn_Refesh.TabIndex = 9
        Me.btn_Refesh.Text = "Làm mới"
        Me.btn_Refesh.UseVisualStyleBackColor = False
        '
        'btn_Edit
        '
        Me.btn_Edit.BackColor = System.Drawing.Color.White
        Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Edit.Location = New System.Drawing.Point(203, 283)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(120, 50)
        Me.btn_Edit.TabIndex = 7
        Me.btn_Edit.Text = "Sửa"
        Me.btn_Edit.UseVisualStyleBackColor = False
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.White
        Me.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Add.Location = New System.Drawing.Point(29, 283)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(120, 50)
        Me.btn_Add.TabIndex = 6
        Me.btn_Add.Text = "Thêm mới"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'txttonkho
        '
        Me.txttonkho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttonkho.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttonkho.Location = New System.Drawing.Point(203, 219)
        Me.txttonkho.Name = "txttonkho"
        Me.txttonkho.Size = New System.Drawing.Size(289, 30)
        Me.txttonkho.TabIndex = 5
        '
        'txtdongia
        '
        Me.txtdongia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdongia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdongia.Location = New System.Drawing.Point(203, 179)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(289, 30)
        Me.txtdongia.TabIndex = 4
        '
        'txtten
        '
        Me.txtten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtten.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtten.Location = New System.Drawing.Point(203, 139)
        Me.txtten.Name = "txtten"
        Me.txtten.Size = New System.Drawing.Size(289, 30)
        Me.txtten.TabIndex = 3
        '
        'txtmaloai
        '
        Me.txtmaloai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmaloai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmaloai.Location = New System.Drawing.Point(203, 99)
        Me.txtmaloai.Name = "txtmaloai"
        Me.txtmaloai.Size = New System.Drawing.Size(289, 30)
        Me.txtmaloai.TabIndex = 2
        '
        'txtmasp
        '
        Me.txtmasp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmasp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmasp.Location = New System.Drawing.Point(203, 59)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(289, 30)
        Me.txtmasp.TabIndex = 1
        '
        'lbl_TonKho
        '
        Me.lbl_TonKho.AutoSize = True
        Me.lbl_TonKho.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TonKho.Location = New System.Drawing.Point(24, 220)
        Me.lbl_TonKho.Name = "lbl_TonKho"
        Me.lbl_TonKho.Size = New System.Drawing.Size(79, 23)
        Me.lbl_TonKho.TabIndex = 0
        Me.lbl_TonKho.Text = "Tồn kho"
        '
        'lbl_DonGia
        '
        Me.lbl_DonGia.AutoSize = True
        Me.lbl_DonGia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DonGia.Location = New System.Drawing.Point(24, 180)
        Me.lbl_DonGia.Name = "lbl_DonGia"
        Me.lbl_DonGia.Size = New System.Drawing.Size(75, 23)
        Me.lbl_DonGia.TabIndex = 0
        Me.lbl_DonGia.Text = "Đơn giá"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(24, 140)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(125, 23)
        Me.lbl_name.TabIndex = 0
        Me.lbl_name.Text = "Tên sản phẩm"
        '
        'lbl_loai
        '
        Me.lbl_loai.AutoSize = True
        Me.lbl_loai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loai.Location = New System.Drawing.Point(24, 100)
        Me.lbl_loai.Name = "lbl_loai"
        Me.lbl_loai.Size = New System.Drawing.Size(99, 23)
        Me.lbl_loai.TabIndex = 0
        Me.lbl_loai.Text = "Tên nhóm:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(24, 60)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(121, 23)
        Me.lbl_id.TabIndex = 0
        Me.lbl_id.Text = "Mã sản phẩm"
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
        Me.dgv_Info.Location = New System.Drawing.Point(539, 188)
        Me.dgv_Info.Margin = New System.Windows.Forms.Padding(6)
        Me.dgv_Info.Name = "dgv_Info"
        Me.dgv_Info.RowHeadersVisible = False
        Me.dgv_Info.RowTemplate.Height = 24
        Me.dgv_Info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Info.Size = New System.Drawing.Size(597, 404)
        Me.dgv_Info.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.INF205_Asm.My.Resources.Resources.passio3
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frm_QLSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1159, 617)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv_Info)
        Me.Controls.Add(Me.grb_info)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_QLSP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý sản phẩm"
        Me.grb_info.ResumeLayout(False)
        Me.grb_info.PerformLayout()
        CType(Me.dgv_Info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents grb_info As System.Windows.Forms.GroupBox
    Friend WithEvents txttonkho As System.Windows.Forms.TextBox
    Friend WithEvents txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents txtten As System.Windows.Forms.TextBox
    Friend WithEvents txtmaloai As System.Windows.Forms.TextBox
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TonKho As System.Windows.Forms.Label
    Friend WithEvents lbl_DonGia As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents lbl_loai As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents btn_Delete As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents dgv_Info As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Refesh As System.Windows.Forms.Button
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
End Class
