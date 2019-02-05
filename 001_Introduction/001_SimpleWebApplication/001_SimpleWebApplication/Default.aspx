<%--Дериктива определяющая общие настройки страницы--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_001_SimpleWebApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hello ASP.NET</title>
</head>
<body>
    <%--Форма для серверных элементов управления--%>
    <form id="form1" runat="server">
    <div>
        <%--Серверный элемент управления для вывода текста--%>
        <asp:Label ID="Output" runat="server">Click on button</asp:Label>
        <br />
        <p>
            <asp:Button ID="btnTest" runat="server" OnClick="btnTest_Click" Text="Button" />
        </p> 
    </div>           
    </form>
</body>
</html>
