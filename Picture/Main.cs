using Picture.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture
{
    public partial class Main : Form
    {
        string path;

        public Main()
        {
            InitializeComponent();

            path = WriteReadSettings();
            if (path != null & path != "")
                pBxPicture.Image = Image.FromFile(path);
        }

        private void btLoadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Wybierz obrazek do wczytania";

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                path = openFileDialog.FileName;
            }

            pBxPicture.Image = Image.FromFile(path);
            WriteReadSettings(path);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (pBxPicture.Image != null)
            {
                pBxPicture.Image = null;
                path = "";
                WriteReadSettings(path);
            }
            pBxPicture.Refresh();
        }

        private string WriteReadSettings(string s = null)
        {
            string _path = null;

            if (s == null)
            {
                _path = Settings.Default.path;

                if (_path == "" || _path == null)
                    btDelete.Visible = false;
                else
                    btDelete.Visible = true;
            }
            else
            {
                Settings.Default.path = s;
                Settings.Default.Save();
                btDelete.Visible = true;
            }

            return _path;
        }
    }
}
