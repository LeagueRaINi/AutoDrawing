using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoDrawer
{
    public partial class PicturePreviewForm : Form
    {
        public PicturePreviewForm()
        {
            InitializeComponent();
        }

        private void PicturePreviewForm_Load(object sender, EventArgs e)
        {
            if (Globals.EditedImage != null)
            {
                Size = new Size(Globals.EditedImage.Width, Globals.EditedImage.Height);
                Imagebox.Image = Globals.EditedImage;
            }
            else
            {
                Size = new Size(Globals.OriginalImage.Width, Globals.OriginalImage.Height);
                Imagebox.Image = Globals.OriginalImage;
            }
        }
    }
}
