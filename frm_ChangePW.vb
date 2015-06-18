Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frm_ChangePW
    Dim ID As String 'Khai báo biến ID
    Dim OldPW As String 'Khai báo biến pw cũ
    Dim Database As New DataTable
    Dim UserDatabase As New DataTable
    Dim Pwdatabase As New DataTable
    Dim ChuoiKetNoi As String = "workstation id=honglxfpoly.mssql.somee.com;packet size=4096;user id=honglxpoly_SQLLogin_1;pwd=sahxdc7fze;data source=honglxfpoly.mssql.somee.com;persist security info=False;initial catalog=honglxfpoly"

    Private Sub Back()
        Dim Message As String
        Message = MessageBox.Show( _
            "Bạn có chắc chắn muốn trở về giao diện chính ?", _
            "Lưu ý !", _
            MessageBoxButtons.YesNo, _
            MessageBoxIcon.Warning)
        If (Message = Windows.Forms.DialogResult.Yes) Then
            frm_Main.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Refesh()
        Back()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        ExitApp()
    End Sub

    Private Sub frm_ChangePW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_username.Text = Username
        Loaddata()
    End Sub

    Private Sub btn_Refesh_Click(sender As Object, e As EventArgs) Handles btn_Refesh.Click
        Refesh()
        Loaddata()
    End Sub

    Private Sub Refesh()
        txt_oldpw.Clear()
        txt_newpw.Clear()
        txt_confirm.Clear()
        txt_oldpw.Focus()
        cbb_username.Items.Clear()
        'Database.Clear()
        UserDatabase.Clear()
        Pwdatabase.Clear()
        'dgv_Info.DataSource = Database
        'dgv_Info.DataSource = Nothing
        dgv_username.DataSource = UserDatabase
        dgv_username.DataSource = Nothing
        dgv_pw.DataSource = Pwdatabase
        dgv_pw.DataSource = Nothing
    End Sub

    Private Sub Loaddata()
        cbb_username.Items.Clear()
        'Dim KetNoi As SqlConnection = New SqlConnection(ChuoiKetNoi)
        Dim KetNoi2 As SqlConnection = New SqlConnection(ChuoiKetNoi)
        'Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select TenDangNhap, MatKhau from nhan_vien where TenDangNhap like '" & Username & "'", KetNoi)
        Dim Query2 As SqlDataAdapter = New SqlDataAdapter("select TenDangNhap, MatKhau from nhan_vien", KetNoi2)
        'KetNoi.Open()
        KetNoi2.Open()
        'Query1.Fill(Database)
        Query2.Fill(UserDatabase)
        'dgv_Info.DataSource = Database.DefaultView
        dgv_username.DataSource = UserDatabase.DefaultView
        For i As Integer = 0 To (dgv_username.RowCount - 2)
            cbb_username.Items.Add(dgv_username.Item(0, i).Value) 'Thêm tên đăng nhập từ data grid view vào combo box
        Next
        If Roles = "user" Then
            cbb_username.Visible = False 'Ẩn combo box username. Combo box này chỉ dùng cho Admin.
            txt_username.Visible = True
            txt_username.Text = Username 'Nếu người dùng là nhân viên thì hiển thị username của nhân viên đó lên txt_username
            For j As Integer = 0 To (dgv_username.RowCount - 2)
                If dgv_username.Item(0, j).Value = Username Then
                    OldPW = dgv_username.Item(1, j).Value 'Gán mật khẩu cũ tương ứng với tên người dùng trong database.
                End If
            Next
            txt_oldpw.Focus()
        End If
        If Roles = "admin" Then
            cbb_username.Visible = True 'Hiển thị combo box.
            txt_username.Visible = False 'Ẩn txt_username
            cbb_username.Focus()
        End If
        cbb_username.Text = ""
    End Sub

    Private Sub cbb_username_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_username.SelectedIndexChanged
        Dim Index As Integer = cbb_username.SelectedIndex
        ID = cbb_username.Items(Index) 'Gán tên đăng nhập cho biến ID.
        Dim KetNoi1 As New SqlConnection(ChuoiKetNoi)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("Select MatKhau From Nhan_vien where TenDangNhap like '" & ID & "'", KetNoi1)
        KetNoi1.Open()
        Query1.Fill(Pwdatabase)
        dgv_pw.DataSource = Pwdatabase.DefaultView
        OldPW = dgv_pw.Item(0, 0).Value 'Gán mật khẩu cũ cho biến OldPW
    End Sub

    Private Sub btn_Change_Click(sender As Object, e As EventArgs) Handles btn_Change.Click
        If txt_oldpw.TextLength <> 0 AndAlso txt_newpw.TextLength <> 0 AndAlso txt_confirm.TextLength <> 0 Then 'Kiểm tra các thông tin đã được nhập đầy đủ hay chưa
            If txt_oldpw.Text = OldPW Then 'Kiểm tra mật khẩu cũ có trùng khớp không
                If txt_confirm.Text = txt_newpw.Text Then 'Kiểm tra mật khẩu mới và xác nhận có trùng khớp không
                    Dim KetNoi1 As New SqlConnection(ChuoiKetNoi)
                    KetNoi1.Open()
                    Dim ChangePW As String = "Update Nhan_Vien set MatKhau = @MatKhau Where TenDangNhap=@TenDangNhap"
                    Dim Command As New SqlCommand(ChangePW, KetNoi1)
                    Try
                        Command.Parameters.AddWithValue("@MatKhau", txt_newpw.Text)
                        Command.Parameters.AddWithValue("@TenDangNhap", ID)
                        Command.ExecuteNonQuery()
                        KetNoi1.Close()
                        MessageBox.Show("Thay đổi mật khẩu thành công !")
                    Catch ex As Exception
                        MessageBox.Show("Không thể thay đổi mật khẩu !")
                    End Try
                    Refesh()
                    Loaddata()
                Else
                    MessageBox.Show("Mật khẩu mới không trùng khớp !")
                End If
            Else
                MessageBox.Show("Mật khẩu cũ không đúng !")
            End If
        Else
            MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu cũ và mật khẩu mới !")
        End If
    End Sub
End Class