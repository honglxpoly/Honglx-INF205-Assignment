Imports System.IO

Module Common
    Public HoTen As String
    Public Roles As String
    Public Terminal As String
    Public Username As String
    Public VendorID As String

    'Hàm thoát ứng dụng
    Public Sub ExitApp()
        Dim Message As String 'Tạo biến Message.
        'Gán Bảng thông báo cho biến Message.
        Message = MessageBox.Show( _
            "Bạn có chắc chắn muốn thoát chương trình ?", _
            "Lưu ý !", _
            MessageBoxButtons.YesNo, _
            MessageBoxIcon.Warning) 'Hiện thông báo xác nhận thoát chương trình.
        If (Message = Windows.Forms.DialogResult.Yes) Then
            'Nếu người dùng chọn Yes  thì thoát chương trình.
            Application.Exit()
        End If 'Đóng cửa sổ ứng dụng.
    End Sub

    'Hàm đăng xuất tài khoản
    Public Sub Logout()
        Dim Message As String 'Tạo biến Message.
        'Gán Bảng thông báo cho biến Message.
        Message = MessageBox.Show( _
            "Bạn có chắc chắn muốn đăng xuất ?", _
            "Lưu ý !", _
            MessageBoxButtons.YesNo, _
            MessageBoxIcon.Warning) 'Hiện thông báo xác nhận đăng xuất.
        If (Message = Windows.Forms.DialogResult.Yes) Then
            'Nếu người dùng chọn Yes  thì đăng xuất.
            HoTen = ""
            Roles = ""
            Terminal = ""
            Username = ""
            frm_Login.ShowDialog()
            frm_Login.txt_username.Clear()
            frm_Login.txt_password.Clear()
            frm_Login.txt_username.Focus()
            frm_Main.Close()
        End If 'Đóng cửa sổ ứng dụng.
    End Sub
End Module
