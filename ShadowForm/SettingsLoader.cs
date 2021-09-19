using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Collections.Generic;

namespace RemoteDesktopShadow
{
	class SettingsLoader
	{
        #region Static Methods
        public static SettingsLoader LoadConfiguration(string ConfigurationName)
        {
			string json = null;
			SettingsLoader CastData = null;

			try
			{
				TextReader reader = new StreamReader(ConfigurationName);
				json = reader.ReadToEnd();
				reader.Close();
			}
			catch( Exception Ex )
			{
				MessageBox.Show("Unable to open configuration file:\n"+Ex.Message, "Application Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}

			try
			{
				CastData = JsonConvert.DeserializeObject<SettingsLoader>(json);
			}
			catch( Newtonsoft.Json.JsonReaderException Ex )
			{
				MessageBox.Show("Unable to read configuration file:\n"+Ex.Message, "Application Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}

            return CastData;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            var fields = this.GetType().GetProperties();

            foreach( var propInfo in fields )
            {
                sb.AppendFormat("{0} = {1}" + Environment.NewLine, propInfo.Name, propInfo.GetValue(this, null));
            }

            return sb.ToString();
        }
        #endregion Static Methods

        #region Configuration Top-Level
		public String[] Servers { get; set; }

		public bool AllowControl { get; set; }
		public bool? ControlDefault { get; set; }
		public bool DisablePermission { get; set; }
		public bool? PermissionsDefault { get; set; }
		#endregion Configuration Top-Level
    }
}
