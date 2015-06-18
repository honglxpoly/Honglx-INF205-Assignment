Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frm_AddStaffInfo
    Dim database As New DataTable
    Dim ChuoiKetNoi As String = "workstation id=honglxfpoly.mssql.somee.com;packet size=4096;user id=honglxpoly_SQLLogin_1;pwd=sahxdc7fze;data source=honglxfpoly.mssql.somee.com;persist security info=False;initial catalog=honglxfpoly"

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Refesh()
        Me.Close()
    End Sub

    Private Sub btn_Refesh_Click(sender As Object, e As EventArgs) Handles btn_Refesh.Click
        Refesh()
    End Sub

    Private Sub Refesh()
        txt_manv.Clear()
        txt_Name.Clear()
        dtp_bd.Value = Now
        dtp_Sd.Value = Now
        cbb_terminal.Text = " "
        cbb_roles.Text = " "
        txt_id.Clear()
        txt_pw.Clear()
        txt_manv.Focus()
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim KetNoi As SqlConnection = New SqlConnection(ChuoiKetNoi)
        Dim Query As String = "Insert into Nhan_Vien Values(@MaNV,@HoTen,@NgaySinh,@NgayBatDau,@CuaHang,@PhanQuyen,@TenDangNhap,@Matkhau)"
        Dim ExecuteQuery As New SqlCommand(Query, KetNoi)
        KetNoi.Open()
        Try
            ExecuteQuery.Parameters.AddWithValue("@MaNV", txt_manv.Text)
            ExecuteQuery.Parameters.AddWithValue("@HoTen", txt_Name.Text)
            ExecuteQuery.Parameters.AddWithValue("@NgaySinh", dtp_bd.Value)
            ExecuteQuery.Parameters.AddWithValue("@NgayBatDau", dtp_Sd.Value)
            ExecuteQuery.Parameters.AddWithValue("@CuaHang", cbb_terminal.Text)
            ExecuteQuery.Parameters.AddWithValue("@PhanQuyen", cbb_roles.Text)
            ExecuteQuery.Parameters.AddWithValue("@TenDangNhap", txt_id.Text)
            ExecuteQuery.Parameters.AddWithValue("@MatKhau", txt_pw.Text)
            MessageBox.Show("Thêm dữ liệu thành công")
            ExecuteQuery.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Không thể thêm dữ liệu được!")
        End Try
        Refesh()
    End Sub

End Class