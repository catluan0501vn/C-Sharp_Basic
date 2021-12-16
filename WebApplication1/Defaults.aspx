<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defaults.aspx.cs" Inherits="WebApplication1.Defaults" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to Web Form</title>

    <!-- CSS only -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous"/>
    <!-- JS, Popper.js, and jQuery -->
    <script src="Scripts/jquery-3.5.1.js"></script>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
</head>
<body style="font-weight: 700">
    <form id="form1" runat="server">
        <div>
            <div>Trần Bình Cát Luận</div>

            <asp:TextBox ID="txtSearch" runat="server" Height="17px" style="margin-top: 0px" Width="173px"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" Width="81px" OnClick="btnSearch_Click" CssClass="btn-sm"/>
        </div>
        <p>
            <asp:GridView ID="dsNCC" runat="server" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None" Height="184px" style="margin-top: 19px" AutoGenerateColumns="False" CssClass="table-hover">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="MaNCC" DataFormatString="" HeaderText="Mã NCC" />
                    <asp:BoundField DataField="TenCongTy" HeaderText="Tên Công Ty" />
                    <asp:BoundField DataField="Logo" HeaderText="Logo" />
                    <asp:BoundField DataField="NguoiLienLac" HeaderText="Người Liên Lạc" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="DienThoai" HeaderText="Điện Thoại" />
                    <asp:BoundField DataField="DiaChi" HeaderText="Địa Chỉ" />
                    <asp:BoundField DataField="MoTa" HeaderText="Mô Tả" />
                    <asp:HyperLinkField HeaderText="Hành Động" NavigateUrl="~/ChiTiet.aspx" Text="Xem" />
                </Columns>

                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
        </p>

        <!-- Button trigger modal -->
        <button type="button" class="btn-success" data-toggle="modal" data-target="#myModal">
              Import Excel
        </button>
            <!-- Modal -->
            <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
              <div class="modal-dialog" role="document">
                <div class="modal-content">
                  <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="myModalLabel">Modal title</h4>
                  </div>
                  <div class="modal-body">
                    ...
                  </div>
                  <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary">Save changes</button>
                  </div>
                </div>
              </div>
            </div>
        <p>

            <asp:Label ID="Label1" runat="server" Text="Tên Công Ty:"></asp:Label>
            <asp:TextBox ID="txtTenCongTy" runat="server" Height="17px" style="margin-top: 0px" Width="173px" CssClass="form-control"></asp:TextBox>

            <asp:Label ID="Label3" runat="server" Text="Logo:"></asp:Label>
            <asp:TextBox ID="txtLogo" runat="server" Height="17px" style="margin-top: 0px" Width="173px" CssClass="form-control"></asp:TextBox>

            <asp:Label ID="Label2" runat="server" Text="Người Liên Lạc:"></asp:Label>
            <asp:TextBox ID="txtNguoiLienLac" runat="server" Height="17px" style="margin-top: 0px" Width="173px" CssClass="form-control"></asp:TextBox>

            <asp:Label ID="Label4" runat="server" Text="Logo:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="17px" style="margin-top: 0px" Width="173px" CssClass="form-control"></asp:TextBox>

            <asp:Label ID="Label5" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" Height="17px" style="margin-top: 0px" Width="173px" CssClass="form-control"></asp:TextBox>

    </form>
</body>
</html>
