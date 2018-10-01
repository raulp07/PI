<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReporteActa.aspx.cs" Inherits="SICARO.WEB.Reporte.ReporteActa" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <%--<script runat="server">
        void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack)
            {
                
            }
        }
    </script>--%>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" ProcessingMode="Remote"></rsweb:ReportViewer>
    </div>
    </form>
</body>
</html>
