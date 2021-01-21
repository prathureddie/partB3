<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="WebAppLAblast.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>Feedback</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table style="margin: 7%;">
<tr>
<th style="color: #bb000b">Contact Form<br />
<br />
</th>
</tr>
<tr>
<td>Name:</td>
<td>
<asp:TextBox ID="txtName" runat="server" required="required"></asp:TextBox>
</td>
</tr>
<tr>
<td>Email-id:</td>
<td>
<asp:TextBox ID="txtEmail" runat="server" required="required"></asp:TextBox>
</td>
</tr>
<tr>
<td valign="top">Message:</td>
<td>
<asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" required="required"></asp:TextBox>
<br /><br /><br /></td></tr>
<tr>
<td colspan="2" align="center">
<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
&nbsp;&nbsp;&nbsp;
<input id="Reset1" type="reset" value="Reset" />
</td>
</tr>
<tr>
<td colspan="2">
<br />
<asp:Label ID="lblResult" runat="server" Font-Bold="true" ForeColor="#bb000b" /></td>
</tr>
</table>
</asp:Content>
