//------------------------------------------------------------------------------
/// <copyright from='1997' to='2003' company='Microsoft Corporation'>           
///    Copyright (c) Microsoft Corporation. All Rights Reserved.                
///    Information Contained Herein is Proprietary and Confidential.            
/// </copyright> 
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Hello
{
	/// <summary>
	/// WebForm1 is the default Web form. This form displays a
	/// text box for the user to enter their name. When they click the
	/// button, their name is displayed on the form.
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtUserName;
		protected System.Web.UI.WebControls.Button cmdEnterName;
		protected System.Web.UI.WebControls.Label lblUserName;
		protected string HitCount;

		private void Page_Load(object sender, System.EventArgs e)
		{
			//TODO Put user code to initialize the page here
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.cmdEnterName.Click += new System.EventHandler(this.cmdEnterName_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		/// <summary>
		///     This method assigns the user name in txtUserName to the
		///     lblUserName label control. This causes the user name
		///     to be displayed on the form.
		/// </summary>
		private void cmdEnterName_Click(object sender, System.EventArgs e)
		{
			lblUserName.Text = txtUserName.Text;
		}
	}
}
