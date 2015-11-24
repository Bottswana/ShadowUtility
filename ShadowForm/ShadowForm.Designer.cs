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
			this.ControlBox = new System.Windows.Forms.CheckBox();
			this.AskPermission = new System.Windows.Forms.CheckBox();
			this.LogoutButton = new System.Windows.Forms.Button();
			this.SearchBox = new System.Windows.Forms.TextBox();
			this.RefreshButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(266, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please select the name of the user you wish to shadow";
			// 
			// UserBox
			// 
			this.UserBox.FormattingEnabled = true;
			this.UserBox.Items.AddRange(new object[] {
            "No available sessions"});
			this.UserBox.Location = new System.Drawing.Point(12, 50);
			this.UserBox.Name = "UserBox";
			this.UserBox.Size = new System.Drawing.Size(394, 121);
			this.UserBox.TabIndex = 1;
			this.UserBox.SelectedIndexChanged += new System.EventHandler(this._UserBox_SelectedIndexChanged);
			// 
			// ShadowButton
			// 
			this.ShadowButton.Enabled = false;
			this.ShadowButton.Location = new System.Drawing.Point(328, 181);
			this.ShadowButton.Name = "ShadowButton";
			this.ShadowButton.Size = new System.Drawing.Size(78, 23);
			this.ShadowButton.TabIndex = 2;
			this.ShadowButton.Text = "Shadow";
			this.ShadowButton.UseVisualStyleBackColor = true;
			this.ShadowButton.Click += new System.EventHandler(this._ShadowButton_Click);
			// 
			// ControlBox
			// 
			this.ControlBox.AutoSize = true;
			this.ControlBox.Checked = true;
			this.ControlBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ControlBox.Location = new System.Drawing.Point(12, 181);
			this.ControlBox.Name = "ControlBox";
			this.ControlBox.Size = new System.Drawing.Size(118, 17);
			this.ControlBox.TabIndex = 3;
			this.ControlBox.Text = "Full Session Control";
			this.ControlBox.UseVisualStyleBackColor = true;
			// 
			// AskPermission
			// 
			this.AskPermission.AutoSize = true;
			this.AskPermission.Checked = true;
			this.AskPermission.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AskPermission.Location = new System.Drawing.Point(12, 199);
			this.AskPermission.Name = "AskPermission";
			this.AskPermission.Size = new System.Drawing.Size(97, 17);
			this.AskPermission.TabIndex = 4;
			this.AskPermission.Text = "Ask Permission";
			this.AskPermission.UseVisualStyleBackColor = true;
			// 
			// LogoutButton
			// 
			this.LogoutButton.Enabled = false;
			this.LogoutButton.Location = new System.Drawing.Point(247, 181);
			this.LogoutButton.Name = "LogoutButton";
			this.LogoutButton.Size = new System.Drawing.Size(75, 23);
			this.LogoutButton.TabIndex = 5;
			this.LogoutButton.Text = "Logout";
			this.LogoutButton.UseVisualStyleBackColor = true;
			this.LogoutButton.Click += new System.EventHandler(this._LogoutButton_Click);
			// 
			// SearchBox
			// 
			this.SearchBox.Location = new System.Drawing.Point(12, 25);
			this.SearchBox.Name = "SearchBox";
			this.SearchBox.Size = new System.Drawing.Size(394, 20);
			this.SearchBox.TabIndex = 6;
			this.SearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this._SearchBox_KeyDown);
			// 
			// RefreshButton
			// 
			this.RefreshButton.Image = global::RemoteDesktopShadow.Properties.Resources.refresh;
			this.RefreshButton.Location = new System.Drawing.Point(217, 181);
			this.RefreshButton.Name = "RefreshButton";
			this.RefreshButton.Size = new System.Drawing.Size(24, 23);
			this.RefreshButton.TabIndex = 7;
			this.RefreshButton.UseVisualStyleBackColor = true;
			this.RefreshButton.Click += new System.EventHandler(this._RefreshButton_Click);
			// 
			// ShadowForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(418, 226);
			this.Controls.Add(this.RefreshButton);
			this.Controls.Add(this.SearchBox);
			this.Controls.Add(this.LogoutButton);
			this.Controls.Add(this.AskPermission);
			this.Controls.Add(this.ControlBox);
			this.Controls.Add(this.ShadowButton);
			this.Controls.Add(this.UserBox);
			this.Controls.Add(this.label1);
			this.Icon = global::RemoteDesktopShadow.Properties.Resources.mstsc;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(434, 265);
			this.MinimumSize = new System.Drawing.Size(434, 265);
			this.Name = "ShadowForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Session Management";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox UserBox;
		private System.Windows.Forms.Button ShadowButton;
		private System.Windows.Forms.CheckBox ControlBox;
		private System.Windows.Forms.CheckBox AskPermission;
		private System.Windows.Forms.Button LogoutButton;
		private System.Windows.Forms.TextBox SearchBox;
		private System.Windows.Forms.Button RefreshButton;
	}
}

