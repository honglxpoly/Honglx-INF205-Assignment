Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frm_QLNV
    Dim database As New DataTable
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

    Private Sub frm_Usermanager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Roles = "user" Then 'Vô hiệu hóa nút Thêm, Sửa, Xóa nếu là Nhân viên
            btn_Add.Enabled = False
            btn_Edit.Enabled = False
            btn_Delete.Enabled = False
        End If
        If Roles = "admin" Then 'Bỏ vô hiệu hóa nút Thêm, Sửa, Xóa nếu là Admin
            btn_Add.Enabled = True
            btn_Delete.Enabled = True
            btn_Edit.Enabled = True
        End If
        Loaddata()
    End Sub

    Private Sub dgv_Info_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Info.CellContentClick
        Dim Index As Integer = dgv_Info.CurrentCell.RowIndex
        txt_Name.Text = dgv_Info.Item(0, Index).Value
        dtp_bd.Value = dgv_Info.Item(1, Index).Value
        dtp_Sd.Value = dgv_Info.Item(2, Index).Value
        txt_Terrminal.Text = dgv_Info.Item(3, Index).Value
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        ExitApp()
    End Sub

    Private Sub btn_Refesh_Click(sender As Object, e As EventArgs) Handles btn_Refesh.Click
        Refesh()
        Loaddata()
    End Sub

    Private Sub Refesh()
        txt_Name.Clear()
        dtp_bd.Value = Now
        dtp_Sd.Value = Now
        txt_Terrminal.Clear()
        txt_Name.Focus()
        database.Clear()
        dgv_Info.DataSource = database
        dgv_Info.DataSource = Nothing
    End Sub

    Private Sub Loaddata()
        Dim KetNoi As SqlConnection = New SqlConnection(ChuoiKetNoi)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select HoTen As 'Họ Tên', Convert(varchar,NgaySinh,103) As 'Ngày Sinh', Convert(varchar,NgayBatDau,103) As 'Ngày Bắt Đầu', CuaHang As 'Cửa Hàng' from Nhan_Vien", KetNoi)
        KetNoi.Open()
        Query1.Fill(database)
        dgv_Info.DataSource = database.DefaultView
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        Dim KetNoi1 As New SqlConnection(ChuoiKetNoi)
        KetNoi1.Open()
        Dim StringAdd1 As String = "Update Nhan_Vien set NgaySinh=@NgaySinh, NgayBatDau=@NgayBatDau, CuaHang=@CuaHang Where HoTen=@HoTen"
        Dim Command As New SqlCommand(StringAdd1, KetNoi1)
        Try
            Command.Parameters.AddWithValue("@HoTen", txt_Name.Text)
            Command.Parameters.AddWithValue("@NgaySinh", dtp_bd.Value)
            Command.Parameters.AddWithValue("@NgayBatDau", dtp_Sd.Value)
            Command.Parameters.AddWithValue("@CuaHang", txt_Terrminal.Text)
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
        Dim XoaDulieu As String = "Delete from Nhan_Vien Where HoTen = @HoTen"
        Dim Command As New SqlCommand(XoaDulieu, KetNoi)
        Try
            Command.Parameters.AddWithValue("@HoTen", txt_Name.Text)
            Command.ExecuteNonQuery()
            KetNoi.Close()
            MessageBox.Show("Xóa thành công !")
        Catch ex As Exception
            MessageBox.Show("Xoá không thành công !")
        End Try
        Refesh()
        Loaddata()
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        frm_AddStaffInfo.Show() 'Mở form Thêm nhân viên
    End Sub
End Class