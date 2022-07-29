using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ScreenSaver
{
    public partial class Config : Form
    {
        ScrParameters Parameters { get; set; }
        public Config(ScrParameters p)
        {
            InitializeComponent();

            Parameters = p;

            Entite.Text = p.entite;
            systeme.Text = p.systeme;
            classification.Text = p.classification;
            mentions.Text = p.mentions;
            imgPath.Text = p.imgPath;
            couleurClassif.BackColor = Color.FromArgb(p.CouleurClassif);
        }

        private void ColorPickerBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                couleurClassif.BackColor = colorDialog1.Color;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Parameters.entite = Entite.Text;
            Parameters.systeme = systeme.Text;
            Parameters.classification = classification.Text;
            Parameters.mentions = mentions.Text;
            Parameters.imgPath = imgPath.Text;
            Parameters.CouleurClassif = couleurClassif.BackColor.ToArgb();

            string path = "ScreenSaverParams.json";
            string s = new JavaScriptSerializer().Serialize(Parameters);
            
            File.WriteAllText(path, s);
            Close();
        }

        private void Config_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ImageBrowsBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|Bitmap (*.bmp)|*.bmp|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    imgPath.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
