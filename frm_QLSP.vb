Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frm_QLSP
    Dim database As New DataTable
    Dim ChuoiKetNoi As String = "workstation id=honglxfpoly.mssql.somee.com;packet size=4096;user id=honglxpoly_SQLLogin_1;pwd=sahxdc7fze;data source=honglxfpoly.mssql.somee.com;persist security info=False;initial catalog=honglxfpoly"

    Private Sub Back()  'Tạo hàm trở về form Main.
        Dim Message As String
        Message = MessageBox.Show( _
            "Bạn có chắc chắn muốn trở về giao diện chính ?", _
            "Lưu ý !", _
            MessageBoxButtons.YesNo, _
            MessageBoxIcon.Warning) 'Hiện thông báo xác nhận trở về.

        If (Message = Windows.Forms.DialogResult.Yes) Then
            frm_Main.Show()
            Me.Close() 'Nếu người dùng chọn Yes  thì trở về form Main.
        End If
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Refesh()
        Back() 'Sự kiện nhấn vào nút Trở về.
    End Sub

    Private Sub frm_QLSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Roles = "user" Then
            btn_Delete.Enabled = False 'Vô hiệu hóa nút Xóa Sản phẩm nếu là Nhân viên
        End If

        If Roles = "admin" Then
            btn_Delete.Enabled = True 'Bỏ vô hiệu hóa nút Xóa nếu là Admin.
        End If
        Loaddata()
    End Sub

    Private Sub dgv_Info_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Info.CellContentClick
        Dim Index As Integer = dgv_Info.CurrentCell.RowIndex
        txtmasp.Text = dgv_Info.Item(0, Index).Value
        txtmaloai.Text = dgv_Info.Item(1, Index).Value
        txtten.Text = dgv_Info.Item(2, Index).Value
        txtdongia.Text = dgv_Info.Item(3, Index).Value
        txttonkho.Text = dgv_Info.Item(4, Index).Value
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim KetNoi As SqlConnection = New SqlConnection(ChuoiKetNoi)
        Dim TruyVan2 As String = "Insert into Chi_Tiet_SP values (@MaSP,@MaLoai,@TenSP,@DonGia,@TonKho)"
        Dim ThucHienTruyVan1 As New SqlCommand(TruyVan2, KetNoi)
        KetNoi.Open()
        Try
            ThucHienTruyVan1.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            ThucHienTruyVan1.Parameters.AddWithValue("@MaLoai", txtmaloai.Text)
            ThucHienTruyVan1.Parameters.AddWithValue("@TenSP", txtten.Text)
            ThucHienTruyVan1.Parameters.AddWithValue("@DonGia", txtdongia.Text)
            ThucHienTruyVan1.Parameters.AddWithValue("@TonKho", txttonkho.Text)
            MessageBox.Show("Thêm dữ liệu thành công")
            ThucHienTruyVan1.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Không thể thêm dữ liệu được!")
        End Try
        Refesh()
        Loaddata()
    End Sub

    Private Sub Loaddata()
        Dim KetNoi As SqlConnection = New SqlConnection(ChuoiKetNoi)
        Dim TruyVan As SqlDataAdapter = New SqlDataAdapter("select MaSp As 'Mã Sản phẩm', TenLoai As 'Tên nhóm', TenSP As 'Tên Sản phẩm', REPLACE(LEFT(CONVERT(varchar(20),DonGia,3),LEN(CONVERT(varchar(20),DonGia,3)) - 3), '.',',') + ' VNĐ' As 'Đơn giá', TonKho As 'Tồn kho' from Chi_Tiet_SP Inner Join Phan_loai_SP on Chi_Tiet_SP.MaLoai = Phan_Loai_SP.MaLoai", KetNoi)
        KetNoi.Open()
        TruyVan.Fill(database)
        dgv_Info.DataSource = database.DefaultView
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        Dim KetNoi1 As New SqlConnection(ChuoiKetNoi)
        Dim StringAdd1 As String = "Update Chi_Tiet_SP set MaLoai = @MaLoai, TenSP = @TenSP, DonGia = @DonGia, TonKho = @TonKho WHERE MaSP = @MaSP"
        Dim Command As New SqlCommand(StringAdd1, KetNoi1)
        KetNoi1.Open()
        Try
            Command.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            Command.Parameters.AddWithValue("@MaLoai", txtmaloai.Text)
            Command.Parameters.AddWithValue("@TenSP", txtten.Text)
            Command.Parameters.AddWithValue("@DonGia", txtdongia.Text)
            Command.Parameters.AddWithValue("@TonKho", txttonkho.Text)
            Command.ExecuteNonQuery()
            KetNoi1.Close()
            MessageBox.Show("Sửa thành công !")
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công !")
        End Try
        Refesh()
        Loaddata()
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        Dim KetNoi As New SqlConnection(ChuoiKetNoi)
        KetNoi.Open()
        Dim XoaDulieu As String = "Delete from Chi_Tiet_SP Where MaSP = @MaSP"
        Dim Command As New SqlCommand(XoaDulieu, KetNoi)
        Try
            Command.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            Command.ExecuteNonQuery()
            KetNoi.Close()
            MessageBox.Show("Xóa thành công !")
        Catch ex As Exception
            MessageBox.Show("Xoá không thành công !")
        End Try
        Refesh()
        Loaddata()
    End Sub

    Private Sub btn_refesh_Click(sender As Object, e As EventArgs) Handles btn_Refesh.Click
        Refesh()
        Loaddata()
    End Sub

    Private Sub Refesh()
        txtmasp.Clear()
        txtmaloai.Clear()
        txtten.Clear()
        txtdongia.Clear()
        txttonkho.Clear()
        txtmasp.Focus()
        database.Clear()
        dgv_Info.DataSource = database
        dgv_Info.DataSource = Nothing
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        ExitApp()
    End Sub

End Class
