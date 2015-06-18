Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frm_VendorDetail
    Dim database As New DataTable 'Tạo đối tượng để lưu trữ database online.
    'Tạo chuỗi kết nối với Database Online
    Dim ChuoiKetNoi As String = "workstation id=honglxfpoly.mssql.somee.com;packet size=4096;user id=honglxpoly_SQLLogin_1;pwd=sahxdc7fze;data source=honglxfpoly.mssql.somee.com;persist security info=False;initial catalog=honglxfpoly"

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Refesh()
        Me.Close()
    End Sub

    Private Sub Loaddata()
        Dim Index As Integer = frm_QLHD.dgv_Info.CurrentCell.RowIndex
        VendorID = frm_QLHD.dgv_Info.Item(0, Index).Value
        Dim KetNoi As SqlConnection = New SqlConnection(ChuoiKetNoi)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select '" & VendorID & "' As 'Mã Hóa Đơn', tensp as 'Tên Sản phẩm', REPLACE(LEFT(CONVERT(varchar(20),DonGia,3),LEN(CONVERT(varchar(20),DonGia,3)) - 3), '.',',') + ' VNĐ' as 'Đơn giá', soluong as 'Số lượng', REPLACE(LEFT(CONVERT(varchar(20),DonGia*Soluong,3),LEN(CONVERT(varchar(20),DonGia*Soluong,3)) - 3), '.',',') + ' VNĐ' as 'Thành tiền' from chi_tiet_hd inner join chi_tiet_sp on chi_tiet_hd.masp = chi_tiet_sp.masp where chi_tiet_hd.mahd = '" & VendorID & "'", KetNoi)
        KetNoi.Open()
        Query1.Fill(database)
        dgv_Info.DataSource = database.DefaultView
    End Sub

    Private Sub frm_VendorDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddata()
    End Sub

    Private Sub Refesh()
        database.Clear()
        dgv_Info.DataSource = database
        dgv_Info.DataSource = Nothing
    End Sub
End Class