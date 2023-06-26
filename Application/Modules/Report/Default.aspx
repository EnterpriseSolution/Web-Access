<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Report</title>
    <link href="/aspnet_client/System_Web/2_0_50727/crystalreportviewers13/css/default.css" rel="stylesheet" type="text/css" />
    <script src="/Scripts/jquery-3.1.1.js?" type="text/javascript"></script>
</head>
<body>
    <script type="text/javascript">
        var width;
        var height;

        window.onresize = function (event) {
            SetWidthHeight();
        }
        function SetWidthHeight() {
            //var height = $(window).height();
            //var width = $(window).width();
            //$.ajax({
            //    url: "windowSize.ashx",
            //    data: {
            //        'Height': height,
            //        'Width': width
            //    },
            //    contentType: "application/json; charset=utf-8",
            //    dataType: "json"
            //}).done(function (data) {
            //    if (data.isFirst) {
            //        window.location.reload();
            //    };
            //}).fail(function (xhr) {
            //    alert("Problem to retrieve browser size.");
            //});
           <%-- $("#clientScreenWidth").val($(window).width());
            $("#clientScreenHeight").val($(window).height());

            width = $(window).width();
            height = $(window).height();

            document.getElementById("<%= crystalReportViewer.ClientID %>").Width = width;
            document.getElementById("<%= crystalReportViewer.ClientID %>").Height = height;

            console.log("width", width);
            console.log("height", height);--%>
        }

        $(function () {
            SetWidthHeight();
            //callAjaxMethod()'

            //$("#clientScreenWidth").val($(window).width());
            //$("#clientScreenHeight").val($(window).height());
        });

        //$(document).ready(function () {
        //    $("#clientScreenWidth").val($(window).width());
        //    $("#clientScreenHeight").val($(window).height());
        //});
        function callAjaxMethod() {

            //To prevent postback from happening as we are ASP.Net TextBox control

            //If we had used input html element, there is no need to use ' e.preventDefault()' as posback will not happen

            //e.preventDefault();

            //$.ajax({
            //    type: "POST",
            //    url: "Default.aspx/IsLeapYear",
            //    data: '{year: "2018" }',
            //    contentType: "application/json; charset=utf-8",
            //    dataType: "json",
            //    success: function (response) {
            //        console.log(response);
            //    },
            //    failure: function (response) {
            //        console.log(response);
            //    }
            //});

            //var height = $(window).height();
            //var width = $(window).width();
            //var data = {
            //    width: width,
            //    height: height
            //};
            //var url = "/Dashboard/ResolveScreenSize";
            //$.get(url, data,
            //    function (response) {
            //        console.log("get", response);
            //    });
        }

    </script>
    <%--<form id="report" runat="server">
        <input type="hidden" value="" name="clientScreenHeight" id="clientScreenHeight" />
        <input type="hidden" value="" name="clientScreenWidth" id="clientScreenWidth" />

        <asp:Label ID="lblDim" runat="server" Text=""></asp:Label>

        <div style="width: 98%; margin-left: auto; margin-right: auto;">
            <CR:CrystalReportViewer ID="crystalReportViewer" runat="server"
                EnableDatabaseLogonPrompt="False" EnableDrillDown="False"
                HasCrystalLogo="False" HasDrillUpButton="False" HasToggleGroupTreeButton="False"
                ToolbarStyle-BackColor="#E0E0E0" ToolbarStyle-BorderColor="Silver" ToolbarStyle-BorderStyle="Solid"
                ToolbarStyle-BorderWidth="1px" EnableParameterPrompt="False" HasSearchButton="False"
                ToolPanelView="None" AutoDataBind="true" GroupTreeStyle-ShowLines="False" />
        </div>
    </form>--%>
    <body ms_positioning="GridLayout">
        <form id="report" runat="server">
            <table id="Table1" cellspacing="1" cellpadding="1" width="100%" height="840" border="1">
                <tr>
                    <td>
                        <CR:CrystalReportViewer ID="crystalReportViewer" runat="server"
                            EnableDatabaseLogonPrompt="False" EnableDrillDown="False"
                            HasCrystalLogo="False" HasDrillUpButton="False" HasToggleGroupTreeButton="False" BestFitPage="False"
                            ToolbarStyle-BackColor="#E0E0E0" ToolbarStyle-BorderColor="Silver" ToolbarStyle-BorderStyle="Solid"
                            ToolbarStyle-BorderWidth="1px" EnableParameterPrompt="False" HasSearchButton="False"
                            Height="100%" Width="100%"
                            ToolPanelView="None" AutoDataBind="true" GroupTreeStyle-ShowLines="False" />
                    </td>
                </tr>
            </table>
        </form>
    </body>
</html>
