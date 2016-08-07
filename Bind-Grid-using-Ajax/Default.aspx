<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Export Grid to Excel</title>
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#btnShowData").click(function () {
                $.ajax({
                    type: "POST",
                    contentType: "application/json; charset=utf-8",
                    url: "Default.aspx/BindEmployees",
                    data: "{}",
                    dataType: "json",
                    success: function (result) {
                        for (var i = 0; i < result.d.length; i++) {
                            $("#gvData").append("<tr><td>" + result.d[i].FirstName + "</td><td>" + result.d[i].LastName + "</td><td>" + result.d[i].City + "</td><td>" + result.d[i].Country + "</td></tr>");
                        }
                    },
                    error: function (result) {
                        alert("Error");
                    }
                });
            });
        });
    </script>
</head>
<body>
    <button id="btnShowData" runat="server">Show Data</button>
    <br /><br />
    <form id="form1" runat="server">
        <asp:GridView ID="gvData" runat="server" CellPadding="4" ShowHeaderWhenEmpty="true" ForeColor="#333333">
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
        </asp:GridView>
    </form>
</body>
</html>