﻿    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="01_SingleValueBinding.aspx.cs" Inherits="DataBindingSamples._01_SingleValueBinding" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Привязка одного значения</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--
            Выражения <%# %> позволяют привязать свойства элементов управления к защищенным или открытым
            полям и свойствам текущей страницы. Для того что бы фактически произвести привязку и извлечь
            значения из свойств, нужно вызвать метод DataBind();
        --%>
        <asp:Literal Text="<%# FirstName %>" runat="server" />
        <asp:Label runat="server" 
        Text="<%# LastName %>"  
        Font-Size="<%# size %>"
        Font-Bold="true" />
    </div>
    </form>
</body>
</html>
