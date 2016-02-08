<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <telerik:RadStyleSheetManager id="RadStyleSheetManager1" runat="server" />
    <style type="text/css">
        .SinError{
        display:none;
    }
    .ConError{
        background:red;
        display:block;
    } 
    </style>
    <script language="javascript" type="text/javascript" >
        function ConError()
        {
            var blink = document.getElementById("pError");        
            color = "red";           
            blink.style.backgroundColor = color;
            document.getElementById("lError").innerHTML = "Cargando....";
        }
        function ValidarBusqueda()
        {
            ConError();           
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
        </Scripts>
    </telerik:RadScriptManager>
    <script type="text/javascript">
        //Put your JavaScript code here.
    </script>
        
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>
    <div>

    </div>

        <asp:Button ID="Button1" runat="server" Text="Button"  OnClientClick="ValidarBusqueda();" OnClick="Button1_Click"/>
     
        <br />
        <br />


        <asp:Panel ID="pError" runat="server" >as
             <asp:Label runat="server" ID="lError"></asp:Label>
        </asp:Panel>
           
        <br />
        <telerik:RadGrid ID="RadGrid1" runat="server" Skin="MetroTouch">
        </telerik:RadGrid>


    </form>
</body>
</html>
