<%@ Page Language="vb" AutoEventWireup="false" Codebehind="default.aspx.vb" Inherits="Hello.WebForm1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Hello World</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>
				Hello
				<asp:Label id="lblUserName" runat="server"></asp:Label></P>
			<P>Please enter your name:
				<asp:TextBox id="txtUserName" runat="server"></asp:TextBox></P>
			<P>
				<asp:Button id="cmdEnterName" runat="server" Text="Enter Name"></asp:Button></P>
		</form>
	</body>
</HTML>
