'------------------------------------------------------------------------------
' <copyright from='1997' to='2003' company='Microsoft Corporation'>           
'    Copyright (c) Microsoft Corporation. All Rights Reserved.                
'    Information Contained Herein is Proprietary and Confidential.            
' </copyright> 

' <summary>
' WebForm1 is the default Web form. This form displays a
' text box for the user to enter their name. When they click the
' button, their name is displayed on the form.
' </summary>
Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected WithEvents txtUserName As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblUserName As System.Web.UI.WebControls.Label
    Protected WithEvents cmdEnterName As System.Web.UI.WebControls.Button

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO Put user code to initialize the page her

    End Sub

    ' <summary>
    '     This method assigns the user name in txtUserName to the
    '     lblUserName label control. This causes the user name
    '     to be displayed on the form.
    ' </summary>
    Private Sub cmdEnterName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnterName.Click
        lblUserName.Text = txtUserName.Text
    End Sub
End Class
