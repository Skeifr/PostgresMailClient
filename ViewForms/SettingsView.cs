using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mailClient
{
    public partial class SettingsView : Form
    {
        private Configuration config;
        public SettingsView()
        {
            InitializeComponent();
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            hostTb.Text = config.AppSettings.Settings["pg_host"].Value;
            portTb.Text = config.AppSettings.Settings["pg_port"].Value;
            dbTb.Text = config.AppSettings.Settings["pg_dbName"].Value;
            userTb.Text = config.AppSettings.Settings["pg_user"].Value;
            passTb.Text = config.AppSettings.Settings["pg_pass"].Value;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            config.AppSettings.Settings["pg_host"].Value = hostTb.Text;
            config.AppSettings.Settings["pg_user"].Value = userTb.Text;
            config.AppSettings.Settings["pg_pass"].Value = passTb.Text;
            config.AppSettings.Settings["pg_dbName"].Value = dbTb.Text;
            config.AppSettings.Settings["pg_port"].Value = portTb.Text;

            config.Save();
            Task.Run(() => dataPg.LoadContacts());
        }
    }
}
