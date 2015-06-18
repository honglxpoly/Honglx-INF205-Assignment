Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frm_QLHD
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

    Private Sub frm_QLHD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_maHD.Focus()
        Loaddata()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        ExitApp()
    End Sub

    Private Sub btn_Refesh_Click(sender As Object, e As EventArgs) Handles btn_Refesh.Click
        Refesh()
        Loaddata()
    End Sub

    Private Sub Loaddata()
        Dim KetNoi As SqlConnection = New SqlConnection(ChuoiKetNoi)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select mahd As 'Mã HĐ', khach_hang.hoten As 'Tên Khách hàng', nhan_vien.hoten As 'Tên Nhân viên', cuahang As 'Cửa Hàng', convert(nvarchar,hoa_don.ngaylap,103) As 'Ngày lập', REPLACE(LEFT(CONVERT(varchar(20),TongTien,3),LEN(CONVERT(varchar(20),TongTien,3)) - 3), '.',',') + ' VNĐ' As 'Tổng tiền' from hoa_don inner join khach_hang on hoa_don.makh = khach_hang.makh inner join nhan_vien on hoa_don.manv = nhan_vien.manv", KetNoi)
        KetNoi.Open()
        Query1.Fill(database)
        dgv_Info.DataSource = database.DefaultView
    End Sub

    Private Sub Refesh()
        txt_maHD.Clear()
        txt_Customer.Clear()
        txt_Staff.Clear()
        txt_Terminal.Clear()
        txt_DateCreate.Clear()
        txt_value.Clear()
        database.Clear()
        dgv_Info.DataSource = database
        dgv_Info.DataSource = Nothing
        txt_maHD.Focus()
    End Sub

    Private Sub dgv_Info_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Info.CellContentClick
        Dim Index As Integer = dgv_Info.CurrentCell.RowIndex
        txt_maHD.Text = dgv_Info.Item(0, Index).Value
        txt_Customer.Text = dgv_Info.Item(1, Index).Value
        txt_Staff.Text = dgv_Info.Item(2, Index).Value
        txt_Terminal.Text = dgv_Info.Item(3, Index).Value
        txt_DateCreate.Text = dgv_Info.Item(4, Index).Value
        txt_value.Text = dgv_Info.Item(5, Index).Value
    End Sub

    Private Sub btn_details_Click(sender As Object, e As EventArgs) Handles btn_details.Click
        Dim Index As Integer = dgv_Info.CurrentCell.RowIndex
        VendorID = dgv_Info.Item(0, Index).Value 'Gán mã hóa đơn cho biến VendorID
        frm_VendorDetail.Show() 'Đi đến trang chi tiết hóa đơn
    End Sub
End Class