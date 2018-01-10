using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithAnimation
{
    public class Preview
    {
        public string url;
        public PictureBox image;
        public PictureBox bigPicture;
        public Label nameLabel;
        public int index;

        public Preview(string s)
        {
            url = s;
            image = new PictureBox();   
            image.Size = new System.Drawing.Size(100, 100);
            image.BackgroundImageLayout = ImageLayout.Stretch;
            image.Load(s);
           
            
            // image.MouseHover += new EventHandler(OnHover);
            //name.Text =;
        }

       

        public int returnIndex()
        {
            return index;
        }
        

    }
}
