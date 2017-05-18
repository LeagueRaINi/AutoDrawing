using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDrawer
{
    public partial class MainForm : Form
    {
        private static Thread _DrawingThread { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void ImportImageButton_Click(object sender, EventArgs e)
        {
            var _OpenFileDialog = new OpenFileDialog();
            if (_OpenFileDialog.ShowDialog() != DialogResult.OK) return;

            var _TempPath = _OpenFileDialog.FileName;
            if (_TempPath.IsRecognisedImageFile())
            {
                Globals.OriginalImage = Image.FromFile(_TempPath);
                SmallPreview.Image = Functions.ScaleImage(Globals.OriginalImage, SmallPreview.Size.Width, SmallPreview.Size.Height);
                Globals.EditedImage = Globals.OriginalImage;
            }
        }

        private void PreviewImageButton_Click(object sender, EventArgs e)
        {
            if (Globals.EditedImage != null)
            {
                var _PicturePreviewForm = new PicturePreviewForm();
                _PicturePreviewForm.ShowDialog();
            }
            else if (Globals.OriginalImage != null)
            {
                var _PicturePreviewForm = new PicturePreviewForm();
                _PicturePreviewForm.ShowDialog();
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            int _Threshold;
            if (int.TryParse(BlackAndWhiteThresholdTextbox.Text, out _Threshold))
            {
                Globals.EditedImage = Functions.MakeBlackAndWhite(Globals.OriginalImage, _Threshold);
            }

            int _ImageHeight, _ImageWidth;
            if (int.TryParse(ImageHeightTextbox.Text, out _ImageHeight) && int.TryParse(ImageWidthTextbox.Text, out _ImageWidth))
            {
                Globals.EditedImage = Functions.ScaleImage(Globals.EditedImage, _ImageWidth, _ImageHeight);
            }

            if (Globals.EditedImage != null)
            {
                SmallPreview.Image = Functions.ScaleImage(Globals.EditedImage, SmallPreview.Size.Width, SmallPreview.Size.Height);
            }
        }

        private void ResetImageButton_Click(object sender, EventArgs e)
        {
            Globals.EditedImage = Globals.OriginalImage;
            SmallPreview.Image = Functions.ScaleImage(Globals.EditedImage, SmallPreview.Size.Width, SmallPreview.Size.Height);
        }

        private void StartDrawingFunctionButton_Click(object sender, EventArgs e)
        {
            if (Globals.EditedImage == null) return;

            int _Speed;
            if (!int.TryParse(SpeedTextbox.Text, out _Speed)) return;

            MessageBox.Show("Press 'D' to start Drawing & 'F' to stop (incase you want to abort before it finishes)");

            while (!Convert.ToBoolean((long)Functions.GetAsyncKeyState(Functions.VK_D) & 0x8000))
            {
                Thread.Sleep(1);
            }

            Task.Factory.StartNew(() => Draw(_Speed));
            Task.Factory.StartNew(Cancel);
        }

        private static void Cancel()
        {
            while (true)
            {
                if (Convert.ToBoolean((long)Functions.GetAsyncKeyState(Functions.VK_F) & 0x8000))
                {
                    _DrawingThread.Abort();
                }
                Thread.Sleep(250);
            }
        }

        private static void Draw(int speed)
        {
            _DrawingThread = Thread.CurrentThread;

            var _StopWatch = System.Diagnostics.Stopwatch.StartNew();

            var _StartingPosition = Cursor.Position;
            Functions.ClickMouse(MouseButtons.Left, _StartingPosition.X, _StartingPosition.Y, true);
            Functions.ClickMouse(MouseButtons.Left, _StartingPosition.X, _StartingPosition.Y, false);

            var _Image = new Bitmap(Globals.EditedImage);

            var _Size = _Image.Size;
            var _PixelFormat = _Image.PixelFormat;
            var _Rectangle = new Rectangle(0, 0, _Size.Width, _Size.Height);

            var _BitmapData = _Image.LockBits(_Rectangle, ImageLockMode.ReadOnly, _PixelFormat);

            const byte _BPP = 4;
            var _SizeINT = _BitmapData.Stride * _BitmapData.Height;
            var _Data = new byte[_SizeINT];

            Marshal.Copy(_BitmapData.Scan0, _Data, 0, _SizeINT);

            for (var _Height = 0; _Height < _Size.Height; _Height++)
            {
                for (var _Width = 0; _Width < _Size.Width; _Width++)
                {
                    var _Index = _Height * _BitmapData.Stride + _Width * _BPP;
                    var _Pixels = Color.FromArgb(_Data[_Index + 3], _Data[_Index + 2], _Data[_Index + 1], _Data[_Index + 0]);
                    if (_Pixels.B != 0) continue;

                    var _DrawX = _StartingPosition.X + _Width;
                    var _DrawY = _StartingPosition.Y + _Height;
                    Functions.MoveMouse(_DrawX, _DrawY);
                    Functions.ClickMouse(MouseButtons.Left, _DrawX, _DrawY, true);
                    Functions.ClickMouse(MouseButtons.Left, _DrawX, _DrawY, false);
                    Thread.Sleep(speed);
                }
            }

            _StopWatch.Stop();
            MessageBox.Show("Drawing Time in Seconds: " + TimeSpan.FromMilliseconds(_StopWatch.ElapsedMilliseconds).TotalSeconds, "Drawing Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
