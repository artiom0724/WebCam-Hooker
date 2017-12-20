using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCam
{
    public partial class HookerForm : Form
    {
        private readonly Settings _tempConfig = new Settings();
        private readonly GlobalHooks _globalHooks;
        private Settings _config;

        public HookerForm()
        {
            InitializeComponent();
            ConfigInit();
            _globalHooks = new GlobalHooks(_config, MainWindowShow);
        }

        private void ConfigInit()
        {
            _config = _tempConfig.UpdateProgram();
            hideMode.Checked = _config.IsHooks;
            emailText.Text = _config.Email;
            fileSize.Value = _config.FileSize > 2048 ? _config.FileSize : 2048;
        }

        private void SaveSettingsButtonClick(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            _config.Email = emailText.Text;
            _config.IsHooks = true;
            _config.FileSize = (long)fileSize.Value;
            _config.HideCheck = hideMode.Checked;

            _tempConfig.SaveConfig(_config);
        }

        private void HideProgramButtonClick(object sender, EventArgs e)
        {
            SaveSettings();
            Hide();
        }

        private void MainWindowShown(object sender, EventArgs e)
        {
            if (_config.HideCheck)
            {
                Hide();
            }
        }

        private void MainWindowShow()
        {
            Show();
        }
    }
}
