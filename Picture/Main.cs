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

            SetImage();

            SetComboBoxItem();
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

        private void SetImage()
        {
            path = WriteReadSettings();
            if (path != null & path != "")
                pBxPicture.Image = Image.FromFile(path);
        }

        private void SetComboBoxItem()
        {
            var _displayWays = new List<DisplayWays>() {
                new DisplayWays() {Id = 1, Way = "Zoom"},
                new DisplayWays() {Id = 2, Way = "CenterImage"},
                new DisplayWays() {Id = 3, Way = "Normal"},
                new DisplayWays() {Id = 4, Way = "StretchImage"},
                new DisplayWays() {Id = 5, Way = "AutoSize"}
            };


            cmbView.DataSource = _displayWays;
            cmbView.DisplayMember = "Way";
            cmbView.ValueMember = "Id";
        }

        private void cmbView_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cmbView.SelectedValue)
            {
                case 1:
                    pBxPicture.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 2:
                    pBxPicture.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 3:
                    pBxPicture.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case 4:
                    pBxPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pBxPicture.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                default:
                    pBxPicture.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }
    }
}
