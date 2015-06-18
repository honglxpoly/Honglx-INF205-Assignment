Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frm_QLKH
    Dim database As New DataTable 'Tạo đối tượng để lưu trữ database online.
    'Tạo chuỗi kết nối với Database Online
    Dim ChuoiKetNoi As String = "workstation id=honglxfpoly.mssql.somee.com;packet size=4096;user id=honglxpoly_SQLLogin_1;pwd=sahxdc7fze;data source=honglxfpoly.mssql.somee.com;persist security info=False;initial catalog=honglxfpoly"
    Dim j As Integer = 0

    'Tạo hàm trở về form Main.
    Private Sub Back()
        Dim Message As String 'Tạo biến Message.
        'Gán Bảng thông báo cho biến Message.
        Message = MessageBox.Show( _
            "Bạn có chắc chắn muốn trở về giao diện chính ?", _
            "Lưu ý !", _
            MessageBoxButtons.YesNo, _
            MessageBoxIcon.Warning) 'Hiện thông báo xác nhận đăng xuất.

        If (Message = Windows.Forms.DialogResult.Yes) Then
            'Nếu người dùng chọn Yes  thì thoát chương trình.
            frm_Main.Show()
            Me.Hide()
        End If 'Đóng cửa sổ ứng dụng.
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        ExitApp()
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Back()
    End Sub

    Private Sub frm_QLKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Roles = "user" Then
            btn_Add.Enabled = False
            btn_Delete.Enabled = False
            btn_Edit.Enabled = False
        End If

        If Roles = "admin" Then
            btn_Add.Enabled = True
            btn_Delete.Enabled = True
            btn_Edit.Enabled = True
        End If
        txt_name.Focus()
        Loaddata()
    End Sub

    Private Sub Loaddata()
        Refesh()
        Dim KetNoi As SqlConnection = New SqlConnection(ChuoiKetNoi)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select MaKH as Mã_KH, HoTen as Họ_Tên, DienThoai as Điện_Thoại, DiaChi as Địa_Chỉ, Email from Khach_Hang", KetNoi)
        KetNoi.Open()
        Query1.Fill(database)
        dgv_Info.DataSource = database.DefaultView
    End Sub

    Private Sub Refesh()
        txt_maKH.Clear()
        txt_name.Clear()
        txt_Phone.Clear()
        txt_Address.Clear()
        txt_Email.Clear()
        database.Clear()
        dgv_Info.DataSource = database
        dgv_Info.DataSource = Nothing
        txt_maKH.Focus()
    End Sub

    Private Sub dgv_Info_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Info.CellContentClick
        Dim Index As Integer = dgv_Info.CurrentCell.RowIndex
        txt_maKH.Text = dgv_Info.Item(0, Index).Value
        txt_name.Text = dgv_Info.Item(1, Index).Value
        txt_Phone.Text = dgv_Info.Item(2, Index).Value
        txt_Address.Text = dgv_Info.Item(3, Index).Value
        txt_Email.Text = dgv_Info.Item(4, Index).Value
    End Sub

    Private Sub btn_Refesh_Click(sender As Object, e As EventArgs) Handles btn_Refesh.Click
        Refesh()
        Loaddata()
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim KetNoi1 As SqlConnection = New SqlConnection(ChuoiKetNoi)
        Dim Query2 As String = "Insert into khach_hang values(@MaKH, @HoTen, @DienThoai, @DiaChi, @Email)"
        Dim Command As New SqlCommand(Query2, KetNoi1)
        KetNoi1.Open()
        If txt_maKH.Text <> "" AndAlso txt_name.Text <> "" AndAlso txt_Phone.Text <> "" AndAlso txt_Address.Text <> "" AndAlso txt_Email.Text <> "" Then
            For i As Integer = 0 To (dgv_Info.RowCount - 2)
                If txt_maKH.Text = dgv_Info.Item(0, i).Value OrElse txt_name.Text = dgv_Info.Item(1, i).Value OrElse txt_Phone.Text = dgv_Info.Item(2, i).Value OrElse txt_Address.Text = dgv_Info.Item(3, i).Value OrElse txt_Email.Text = dgv_Info.Item(4, i).Value Then
                    j += 1
                    MessageBox.Show("Thông tin khách hàng đã tồn tại !")
                    Refesh()
                    Loaddata()
                    txt_maKH.Focus()
                End If
            Next
            If j = 0 Then
                Try
                    Command.Parameters.AddWithValue("@MaKH", txt_maKH.Text)
                    Command.Parameters.AddWithValue("@HoTen", txt_name.Text)
                    Command.Parameters.AddWithValue("@DienThoai", txt_Phone.Text)
                    Command.Parameters.AddWithValue("@DiaChi", txt_Address.Text)
                    Command.Parameters.AddWithValue("@Email", txt_Email.Text)
                    Command.ExecuteNonQuery()
                    MessageBox.Show("Thêm dữ liệu thành công !")
                Catch ex As Exception
                    'Nếu thêm không được thì hiển thị thông báo
                    MessageBox.Show("Không thể thêm dữ liệu được!")
                End Try
                Refesh()
                Loaddata()
                txt_maKH.Focus()
            End If
        Else
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng !")
        End If
        j = 0
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        Dim KetNoi2 As New SqlConnection(ChuoiKetNoi)
        Dim StringAdd As String = "update khach_hang Set hoten=@Hoten, DienThoai=@DienThoai, DiaChi=@DiaChi,Email = @Email where MaKH=@MaKH"
        Dim Command As New SqlCommand(StringAdd, KetNoi2)
        KetNoi2.Open()

        If txt_maKH.Text <> "" AndAlso txt_name.Text <> "" AndAlso txt_Phone.Text <> "" AndAlso txt_Address.Text <> "" AndAlso txt_Email.Text <> "" Then
            Try
                Command.Parameters.AddWithValue("@MaKH", txt_maKH.Text)
                Command.Parameters.AddWithValue("@HoTen", txt_name.Text)
                Command.Parameters.AddWithValue("@DienThoai", txt_Phone.Text)
                Command.Parameters.AddWithValue("@DiaChi", txt_Address.Text)
                Command.Parameters.AddWithValue("@Email", txt_Email.Text)
                Command.ExecuteNonQuery()
                MessageBox.Show("Sửa thành công !")
            Catch ex As Exception
                MessageBox.Show("Sửa không thành công !")
            End Try
            Refesh()
            Loaddata()
            txt_maKH.Focus()
        Else
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng !")
        End If
    End Sub
End Class