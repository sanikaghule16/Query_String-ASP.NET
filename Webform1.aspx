<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QueryString.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             Enter Name:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Button ID="btnSave" runat="server" Text="Save in ViewState" OnClick="btnSave_Click" />
            <br /><br />

            <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <br /><br />

         <asp:Button ID="btnNext" runat="server" Text="Go to Next Page"
    OnClick="btnNext_Click" />

        </div>
    </form>
</body>
</html>
