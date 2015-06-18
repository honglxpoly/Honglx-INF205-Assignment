<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_VendorDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_VendorDetail))
        Me.dgv_Info = New System.Windows.Forms.DataGridView()
        Me.btn_Back = New System.Windows.Forms.Button()
        CType(Me.dgv_Info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.dgv_Info.Location = New System.Drawing.Point(-1, -2)
        Me.dgv_Info.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_Info.Name = "dgv_Info"
        Me.dgv_Info.RowHeadersVisible = False
        Me.dgv_Info.RowTemplate.Height = 24
        Me.dgv_Info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Info.Size = New System.Drawing.Size(550, 350)
        Me.dgv_Info.TabIndex = 93
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.White
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Back.Location = New System.Drawing.Point(284, 367)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(250, 50)
        Me.btn_Back.TabIndex = 94
        Me.btn_Back.Text = "Trở về"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'frm_VendorDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(545, 428)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.dgv_Info)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_VendorDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chi tiết hóa đơn"
        CType(Me.dgv_Info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_Info As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Back As System.Windows.Forms.Button
End Class
