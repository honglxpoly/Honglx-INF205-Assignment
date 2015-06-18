Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frm_Login
    'Sự kiện form Login_Load
    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_Loading.ShowDialog()
        txt_username.Focus()
        HoTen = ""
        Roles = ""
        Terminal = ""
        Username = ""
    End Sub

    'Sự kiện button Login Click
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        'Tạo chuỗi kết nối với Database Online
        Dim ChuoiConnect As String = "workstation id=honglxfpoly.mssql.somee.com;packet size=4096;user id=honglxpoly_SQLLogin_1;pwd=sahxdc7fze;data source=honglxfpoly.mssql.somee.com;persist security info=False;initial catalog=honglxfpoly"
        Dim Connect As SqlConnection = New SqlConnection(ChuoiConnect)
        Dim SQLAdapter As SqlDataAdapter = New SqlDataAdapter("select * from nhan_vien where tendangnhap = '" & txt_username.Text & "' and matkhau = '" & txt_password.Text & "' ", Connect)
        Dim Table As New DataTable
        Dim PhanQuyen As String

        Try
            Connect.Open()
            SQLAdapter.Fill(Table)
            dgv_roles.DataSource = Table.DefaultView
            PhanQuyen = dgv_roles.Item(5, 0).Value
            txt_username.Clear()
            txt_password.Clear()
            If Table.Rows.Count > 0 And PhanQuyen = "admin" Then
                HoTen = dgv_roles.Item(1, 0).Value 'Gán họ tên nhân viên cho biến HoTen
                Roles = PhanQuyen 'Gán vai trò cho biến Roles
                Terminal = dgv_roles.Item(4, 0).Value 'Gán cửa hàng làm việc cho biến Terminal
                Username = dgv_roles.Item(6, 0).Value 'Gán tên đăng nhập cho biến Username
                MessageBox.Show("Đăng nhập thành công với quyền Administrator!")
                frm_Main.ShowDialog()
                Me.Hide()

            ElseIf Table.Rows.Count > 0 And PhanQuyen = "user" Then
                HoTen = dgv_roles.Item(1, 0).Value 'Gán họ tên nhân viên cho biến HoTen
                Roles = PhanQuyen 'Gán vai trò cho biến Roles
                Terminal = dgv_roles.Item(4, 0).Value 'Gán cửa hàng làm việc cho biến Terminal
                Username = dgv_roles.Item(6, 0).Value 'Gán tên đăng nhập cho biến Username
                MessageBox.Show("Đăng nhập thành công với quyền User!")
                frm_Main.ShowDialog()
                Me.Hide()

            Else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu !")
                txt_username.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Sự kiện button Exit Click
    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        ExitApp()
    End Sub
End Class
