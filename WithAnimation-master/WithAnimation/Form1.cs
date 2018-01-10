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
        List<string> imagesList = new List<string>();
        int index=0;
        bool isPhotoPanel = false;

        public mainForm()
        {
            InitializeComponent();
            //FIND PATH TO DIRECTORY
            string dir = Directory.GetCurrentDirectory();
            string path = Path.GetFullPath(Path.Combine(dir, @"..\..\..\"));
            string packsPath = path + @"Packs\";
            photosPath = packsPath + @"Photos\";
            videosPath = packsPath + @"Videos\";
            musicPath = packsPath + @"Music\";
            //SETUP PANELS
            photosPanel.Location = new Point(photosPanel.Location.X, -3*photosPanel.Height - 5);

            selectedPanel.BackColor = Color.Transparent;

        }

      

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //NEXT AND PREV--------
        private void button4_Click(object sender, EventArgs e)
        {
            if (index < imagesList.Capacity - 1) index++;
            else index = 0;
            bigPicture.Load(imagesList[index]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (index > 0) index--;
            else index = imagesList.Capacity - 1;
            bigPicture.Load(imagesList[index]);
        }
        //-----------
        //VIDEOS BUTTON
        private void button2_Click(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            isPhotoPanel = false;

        }
        //MUSIC BUTTON
        private void button1_Click(object sender, EventArgs e)
        {

        }
        //PHOTOS BUTTON
        private void photosButton_Click(object sender, EventArgs e)
        {
            if (!isPhotoPanel)
            {
                selectedPanel.BackColor = Color.WhiteSmoke;
                selectedPanel.Location = new Point (photosButton.Location.X,photosButton.Top);

                isPhotoPanel = true;
                flowLayoutPanel1.Controls.Clear();
                photosPanel.Location = new Point(flowLayoutPanel1.Width + 4, 4);
                imagesList.AddRange( Directory.GetFiles(photosPath));
                flowLayoutPanel1.SetBounds(1, 1, flowLayoutPanel1.Width - 5, flowLayoutPanel1.Height - 5);
                for(int i=0;i<imagesList.Capacity; i++)
                {
                    
                    PreviewPhoto(imagesList[i],i);
                }
            }
        }

       public void PreviewPhoto(string s,int i)
        {
            Preview preview = new Preview(s);
            preview.bigPicture = bigPicture;
            preview.index = i;
            preview.image.Click += new EventHandler(OnImageClicked);
            flowLayoutPanel1.Controls.Add(preview.image);
            WAIT(0.2f);
            // preview  
           
        }

        public void OnImageClicked(Object sender, EventArgs e)
        {
             PictureBox pb = (PictureBox)sender;
             string currentPicture = pb.ImageLocation.ToString();
             bigPicture.Load(currentPicture);

            for(int i=0;i<imagesList.Capacity; i++)
            {
                if(currentPicture==imagesList[i]) { index = i; break; }
            }

        }

        public void WAIT(float seconds)
        {
            int miliseconds = (int)seconds * 1000;
            System.Threading.Thread.Sleep(miliseconds);
        }



    }
}
