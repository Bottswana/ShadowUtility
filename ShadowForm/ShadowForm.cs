using System;
using Cassia;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;

namespace RemoteDesktopShadow
{
	public partial class ShadowForm : Form
	{
		#region Initialisation
		private Dictionary<int, string> _ServerMap;
		private SettingsLoader _Settings;
		private ArrayList _DataSource;

		public ShadowForm(string[] args)
		{
			// Load Configuration
			var ConfigPath = ( args.Length >= 1 ) ? args[0] : "ShadowUtility.json";
			_Settings = SettingsLoader.LoadConfiguration(ConfigPath);

			// Initialise
			InitializeComponent();
			_ServerMap = new Dictionary<int, string>();
			_DataSource = new ArrayList();

			if (_Settings != null )
			{
				if (_Settings.ControlDefault.HasValue )
					ControlBox1.Checked = _Settings.ControlDefault.Value;

				if (_Settings.PermissionsDefault.HasValue )
					AskPermission.Checked = _Settings.PermissionsDefault.Value;

				if(!_Settings.AllowControl )
				{
					// Remove Control Permission
					ControlBox1.Checked = false;
					ControlBox1.Enabled = false;
				}
				if(_Settings.DisablePermission )
				{
					// Remove Request Permission
					AskPermission.Checked = true;
					AskPermission.Enabled = false;
				}
			}

			// Load Users into Form
			_LoadUsersFromServers();
			UserBox.ClearSelected();
		}
		#endregion Initialisation

		#region Shared Functions
		private string _FindServerForUser(KeyValuePair<int,string> Row)
		{
			var Position = _DataSource.IndexOf(Row);
			return _ServerMap[Position];
		}

		private void _LoadUsersFromServers()
		{
			if( _Settings == null || _Settings.Servers.Length <= 0 ) return;
			var TSManager = new TerminalServicesManager();

			// Foreach server in the collection, find active sessions
			int pos = 0;
			foreach( var Server in _Settings.Servers )
			{
				try
				{
					using var thisServer = TSManager.GetRemoteServer(Server);
					thisServer.Open();
					
					foreach( var tSession in thisServer.GetSessions() )
					{
						if( tSession.UserName.Length <= 0 ) continue; // Dont want ghost entries

						var StatusText = ( tSession.ConnectionState == ConnectionState.Idle ) ? " IDLE" : ( (tSession.ConnectionState == ConnectionState.Disconnected) ? " DISCONNECTED" : "");
						var Data = new KeyValuePair<int, string>(tSession.SessionId, $"{tSession.UserAccount} ({Server}){StatusText}");

						_ServerMap.Add(pos, Server);
						_DataSource.Add(Data);
						pos++;
					}
				}
				catch( Exception Ex )
				{
					MessageBox.Show($"Unable to load user information\nServer: {Server}\nError: {Ex.Message}", "User Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			// Apply DataSource to Form
			UserBox.SelectedIndex = -1;
			if( _DataSource.Count >= 1 )
			{
				UserBox.DataSource = _DataSource;
				UserBox.DisplayMember = "Value";
				UserBox.ValueMember = "Key";
			}
		}
		#endregion Shared Functions

		#region Form Events
		private void _UserBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Enable or Disable Shadow button when a user is selected
			try
			{
				var SelectedIndex = int.Parse(UserBox.SelectedValue.ToString().Trim());
				if( SelectedIndex > 0 )
				{
					ShadowButton.Enabled = true;
					LogoutButton.Enabled = true;
				}
				else
				{
					ShadowButton.Enabled = false;
					LogoutButton.Enabled = false;
				}
			}
			catch( Exception )
			{
				ShadowButton.Enabled = false;
				LogoutButton.Enabled = false;
			}
		}

		private void _ShadowButton_Click(object sender, EventArgs e)
		{
			// Activate user shadow
			var SelectedIndex = int.Parse(UserBox.SelectedValue.ToString().Trim());
			if( SelectedIndex <= 0 ) return;

			var SelectedPair = (KeyValuePair<int,string>)UserBox.SelectedItem;
			string Message = string.Format("Are you sure you wish to shadow the following session:\n{0}", SelectedPair.Value);
			if( MessageBox.Show(Message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
			{
				// Shadow User
				var Permission = ( AskPermission.Checked ) ? "" : "/noConsentPrompt ";
				var Control = ( ControlBox1.Checked ) ? "/control " : "";

				var CommandString = string.Format("{0}{1}/shadow:{2} /v:{3}", Permission, Control, SelectedIndex, _FindServerForUser(SelectedPair));
				var Process = new System.Diagnostics.Process()
				{
					StartInfo = new System.Diagnostics.ProcessStartInfo()
					{
						FileName = "mstsc.exe",
						Arguments = CommandString
					}
				}.Start();
			}
		}

		private void _LogoutButton_Click(object sender, EventArgs e)
		{
			// Logout User
			var SelectedIndex = int.Parse(UserBox.SelectedValue.ToString().Trim());
			if( SelectedIndex <= 0 ) return;

			var SelectedPair = (KeyValuePair<int,string>)UserBox.SelectedItem;
			string Message = string.Format("Are you sure you wish to logoff the following session:\n{0}", SelectedPair.Value);
			if( MessageBox.Show(Message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
			{
				// Logout User
				var TSManager = new TerminalServicesManager();
				using( var thisServer = TSManager.GetRemoteServer(_FindServerForUser(SelectedPair)) )
				{
					thisServer.Open();
					thisServer.GetSession(SelectedIndex).Logoff();
				}
			}
		}

		private void _SearchBox_KeyDown(object sender, KeyEventArgs e)
		{
			var SearchText = SearchBox.Text.ToLower();
			var CopyArray = new ArrayList();

			// Check if we are clearing a filter
			if( SearchText.Length <= 0 )
			{
				UserBox.DataSource = _DataSource;
				UserBox.DisplayMember = "Value";
				UserBox.ValueMember = "Key";
				UserBox.SelectedIndex = -1;
				return;
			}

			// Filter Contents
			foreach( KeyValuePair<int,string> entry in _DataSource )
			{
				var thisValue = entry.Value.ToLower();
				if( thisValue.Contains(SearchText) ) CopyArray.Add(entry);
			}

			// Update List
			UserBox.DataSource = CopyArray;
			UserBox.DisplayMember = "Value";
			UserBox.ValueMember = "Key";
			UserBox.SelectedIndex = -1;
		}

		private void _RefreshButton_Click(object sender, EventArgs e)
		{
			_ServerMap = new Dictionary<int, string>();
			_DataSource = new ArrayList();

			UserBox.DataSource = _DataSource;
			UserBox.SelectedIndex = -1;

			ShadowButton.Enabled = false;
			LogoutButton.Enabled = false;
			_LoadUsersFromServers();

			if( _DataSource.Count <= 0 )
			{
				// No entries in list
				var Data = new KeyValuePair<int, String>(-1, "No available sessions");
				_DataSource.Add(Data);

				UserBox.DataSource = _DataSource;
				UserBox.DisplayMember = "Value";
				UserBox.ValueMember = "Key";
				UserBox.SelectedIndex = -1;
			}
		}
		#endregion Form Events
	}
}
