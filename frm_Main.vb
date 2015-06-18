Public Class frm_Main

    Private Sub mni_DangXuat_Click(sender As Object, e As EventArgs) Handles mni_DangXuat.Click
        lbl_nameinfo.Text = ""
        lbl_rolesinfo.Text = ""
        lbl_terminalinfo.Text = ""
        Logout() 'Đăng xuất
    End Sub

    Private Sub mni_Thoat_Click(sender As Object, e As EventArgs) Handles mni_Thoat.Click
        ExitApp() 'Thoát chương trình
    End Sub

    Private Sub mni_QLNV_Click(sender As Object, e As EventArgs) Handles mni_QLNV.Click
        Me.Hide()
        frm_QLNV.Show() 'Đi đến form Quản lý nhân viên
    End Sub

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nameinfo.Text = HoTen
        lbl_rolesinfo.Text = Roles
        lbl_terminalinfo.Text = Terminal
    End Sub

    Private Sub mni_QLSP_Click(sender As Object, e As EventArgs) Handles mni_QLSP.Click
        Me.Hide()
        frm_QLSP.Show() 'Đi đến form Quản lý sản phẩm
    End Sub

    Private Sub mni_QLNSP_Click(sender As Object, e As EventArgs) Handles mni_QLNSP.Click
        Me.Hide()
        frm_QLLSP.Show() 'Đi đến form Quản lý loại sản phẩm
    End Sub

    Private Sub mni_DoiMK_Click(sender As Object, e As EventArgs) Handles mni_DoiMK.Click
        Me.Hide()
        frm_ChangePW.Show() 'Đi đến form Đổi mật khẩu
    End Sub

    Private Sub mni_QLKH_Click(sender As Object, e As EventArgs) Handles mni_QLKH.Click
        Me.Hide()
        frm_QLKH.Show() 'Đi đến form Quản lý khách hàng
    End Sub

    Private Sub mni_QLHD_Click(sender As Object, e As EventArgs) Handles mni_QLHD.Click
        Me.Hide()
        frm_QLHD.Show() 'Đi đến form Quản lý hóa đơn
    End Sub
End Class