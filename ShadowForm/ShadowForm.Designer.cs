using System.Drawing;
using RemoteDesktopShadow.Properties;

namespace RemoteDesktopShadow
{
	partial class ShadowForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.UserBox = new System.Windows.Forms.ListBox();
			this.ShadowButton = new System.Windows.Forms.Button();
			this.ControlBox1 = new System.Windows.Forms.CheckBox();
			this.AskPermission = new System.Windows.Forms.CheckBox();
			this.LogoutButton = new System.Windows.Forms.Button();
			this.SearchBox = new System.Windows.Forms.TextBox();
			this.RefreshButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 13);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(395, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please select the name of the user you wish to shadow";
			// 
			// UserBox
			// 
			this.UserBox.FormattingEnabled = true;
			this.UserBox.ItemHeight = 20;
			this.UserBox.Items.AddRange(new object[] {"No available sessions"});
			this.UserBox.Location = new System.Drawing.Point(18, 73);
			this.UserBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.UserBox.Name = "UserBox";
			this.UserBox.Size = new System.Drawing.Size(589, 164);
			this.UserBox.TabIndex = 1;
			this.UserBox.SelectedIndexChanged += new System.EventHandler(this._UserBox_SelectedIndexChanged);
			// 
			// ShadowButton
			// 
			this.ShadowButton.Enabled = false;
			this.ShadowButton.Location = new System.Drawing.Point(492, 265);
			this.ShadowButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ShadowButton.Name = "ShadowButton";
			this.ShadowButton.Size = new System.Drawing.Size(117, 33);
			this.ShadowButton.TabIndex = 2;
			this.ShadowButton.Text = "Shadow";
			this.ShadowButton.UseVisualStyleBackColor = true;
			this.ShadowButton.Click += new System.EventHandler(this._ShadowButton_Click);
			// 
			// ControlBox1
			// 
			this.ControlBox1.AutoSize = true;
			this.ControlBox1.Checked = true;
			this.ControlBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ControlBox1.Location = new System.Drawing.Point(18, 242);
			this.ControlBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ControlBox1.Name = "ControlBox1";
			this.ControlBox1.Size = new System.Drawing.Size(176, 24);
			this.ControlBox1.TabIndex = 3;
			this.ControlBox1.Text = "Full Session Control";
			this.ControlBox1.UseVisualStyleBackColor = true;
			// 
			// AskPermission
			// 
			this.AskPermission.AutoSize = true;
			this.AskPermission.Checked = true;
			this.AskPermission.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AskPermission.Location = new System.Drawing.Point(18, 271);
			this.AskPermission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AskPermission.Name = "AskPermission";
			this.AskPermission.Size = new System.Drawing.Size(143, 24);
			this.AskPermission.TabIndex = 4;
			this.AskPermission.Text = "Ask Permission";
			this.AskPermission.UseVisualStyleBackColor = true;
			// 
			// LogoutButton
			// 
			this.LogoutButton.Enabled = false;
			this.LogoutButton.Location = new System.Drawing.Point(370, 265);
			this.LogoutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.LogoutButton.Name = "LogoutButton";
			this.LogoutButton.Size = new System.Drawing.Size(112, 33);
			this.LogoutButton.TabIndex = 5;
			this.LogoutButton.Text = "Logout";
			this.LogoutButton.UseVisualStyleBackColor = true;
			this.LogoutButton.Click += new System.EventHandler(this._LogoutButton_Click);
			// 
			// SearchBox
			// 
			this.SearchBox.Location = new System.Drawing.Point(18, 36);
			this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.SearchBox.Name = "SearchBox";
			this.SearchBox.Size = new System.Drawing.Size(589, 26);
			this.SearchBox.TabIndex = 6;
			this.SearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this._SearchBox_KeyDown);
			// 
			// RefreshButton
			// 
			this.RefreshButton.Image = global::RemoteDesktopShadow.Properties.Resources.refresh;
			this.RefreshButton.Location = new System.Drawing.Point(326, 265);
			this.RefreshButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.RefreshButton.Name = "RefreshButton";
			this.RefreshButton.Size = new System.Drawing.Size(36, 33);
			this.RefreshButton.TabIndex = 7;
			this.RefreshButton.UseVisualStyleBackColor = true;
			this.RefreshButton.Click += new System.EventHandler(this._RefreshButton_Click);
			// 
			// ShadowForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 307);
			this.Controls.Add(this.RefreshButton);
			this.Controls.Add(this.SearchBox);
			this.Controls.Add(this.LogoutButton);
			this.Controls.Add(this.AskPermission);
			this.Controls.Add(this.ControlBox1);
			this.Controls.Add(this.ShadowButton);
			this.Controls.Add(this.UserBox);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(642, 363);
			this.MinimumSize = new System.Drawing.Size(642, 363);
			this.Name = "ShadowForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Icon = Resources.mstsc;
			this.Text = "Session Management";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.CheckBox AskPermission;
		private System.Windows.Forms.CheckBox ControlBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button LogoutButton;
		private System.Windows.Forms.Button RefreshButton;
		private System.Windows.Forms.TextBox SearchBox;
		private System.Windows.Forms.Button ShadowButton;
		private System.Windows.Forms.ListBox UserBox;

		#endregion
	}
}

