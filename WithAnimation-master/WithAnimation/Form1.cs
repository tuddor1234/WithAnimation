using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WithAnimation
{
    public partial class mainForm : Form
    {
        string photosPath = null, videosPath = null, musicPath = null;

        public mainForm()
        {
            InitializeComponent();
            string dir = Directory.GetCurrentDirectory();
            string path = Path.GetFullPath(Path.Combine(dir, @"..\..\..\"));
            string packsPath = path + @"Packs\";
            
            photosPath = packsPath + @"Photos\";
        }

      

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void photosButton_Click(object sender, EventArgs e)
        {
           // photosPanel.Location = new Point(217, 4);
            string[] imagesList = Directory.GetFiles(photosPath);
            flowLayoutPanel1.SetBounds(5, 5, flowLayoutPanel1.Width-2, flowLayoutPanel1.Height-2);
            foreach (string s in imagesList)
            {
                PreviewPhoto(s);
            }

        }

       public void PreviewPhoto(string s)
        {
            Preview preview = new Preview(s);
            flowLayoutPanel1.Controls.Add(preview.image);
            // preview
           
        }

        


    }
}
