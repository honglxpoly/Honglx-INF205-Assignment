Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frm_QLLSP
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

    Private Sub frm_QLLSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim KetNoi As SqlConnection = New SqlConnection(ChuoiKetNoi)
        Dim TruyVan2 As String = "Insert into Phan_Loai_SP values (@MaLoai,@TenLoai)"
        Dim ThucHienTruyVan1 As New SqlCommand(TruyVan2, KetNoi)
        KetNoi.Open()
        Try
            ThucHienTruyVan1.Parameters.AddWithValue("@MaLoai", txtmaloai.Text)
            ThucHienTruyVan1.Parameters.AddWithValue("@TenLoai", txttenloai.Text)
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
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("Select MaLoai As 'Mã nhóm', TenLoai As 'Tên nhóm' from Phan_Loai_SP", KetNoi)
        KetNoi.Open()
        Query1.Fill(database)
        dgv_Info.DataSource = database.DefaultView
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        Dim KetNoi1 As New SqlConnection(ChuoiKetNoi)
        KetNoi1.Open()
        Dim StringAdd1 As String = "Update Phan_loai_SP set TenLoai = @TenLoai WHERE MaLoai = @MaLoai"
        Dim Command As New SqlCommand(StringAdd1, KetNoi1)
        Try
            Command.Parameters.AddWithValue("@MaLoai", txtmaloai.Text)
            Command.Parameters.AddWithValue("@TenLoai", txttenloai.Text)
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
        Dim XoaDulieu As String = "Delete from Phan_Loai_SP Where MaLoai = @MaLoai"
        Dim Command As New SqlCommand(XoaDulieu, KetNoi)
        Try
            Command.Parameters.AddWithValue("@MaLoai", txtmaloai.Text)
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
        txtmaloai.Clear()
        txttenloai.Clear()
        txtmaloai.Focus()
        database.Clear()
        dgv_Info.DataSource = database
        dgv_Info.DataSource = Nothing
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        ExitApp()
    End Sub

    Private Sub dgv_Info_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Info.CellContentClick
        Dim Index As Integer = dgv_Info.CurrentCell.RowIndex
        txtmaloai.Text = dgv_Info.Item(0, Index).Value
        txttenloai.Text = dgv_Info.Item(1, Index).Value
    End Sub
End Class